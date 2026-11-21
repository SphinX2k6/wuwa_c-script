using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02003D8F RID: 15759
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeBossChallengeDebuffItem : GridProxyAbstract<RoguelikeBossChallengeBuffData>
	{
		// Token: 0x060284BF RID: 165055 RVA: 0x00B49220 File Offset: 0x00B47420
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUITexture));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action(this.OnBtnDetailClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060284C0 RID: 165056 RVA: 0x00B4936B File Offset: 0x00B4756B
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x060284C1 RID: 165057 RVA: 0x00B49380 File Offset: 0x00B47580
		[NullableContext(1)]
		public override void Refresh(RoguelikeBossChallengeBuffData data, bool isSelected, int gridIndex)
		{
			this.CurrentData = data;
			RoguelikeConfig instance = RoguelikeConfig.Instance;
			RogueTowerBuff? rogueTowerBuff = (instance != null) ? instance.GetRogueTowerBuffConfig(data.Id) : null;
			if (rogueTowerBuff == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueTowerBuff.Value.Name, Array.Empty<object>());
			this.RefreshDesc(rogueTowerBuff.Value);
			base.SetTextureByPath(rogueTowerBuff.Value.Icon, base.GetTexture(1), null, null);
			base.GetItem(4).SetUIActive(data.IsNew);
			base.GetItem(6).SetUIActive(data.IsActive);
		}

		// Token: 0x060284C2 RID: 165058 RVA: 0x00B4943A File Offset: 0x00B4763A
		public void SetNewTipsVisible(bool visible)
		{
			base.GetItem(4).SetUIActive(visible);
		}

		// Token: 0x060284C3 RID: 165059 RVA: 0x00B49449 File Offset: 0x00B47649
		public bool IsCurrentBossBuff(int bossId)
		{
			RoguelikeBossChallengeBuffData currentData = this.CurrentData;
			return currentData != null && currentData.BossId == bossId;
		}

		// Token: 0x060284C4 RID: 165060 RVA: 0x00B49460 File Offset: 0x00B47660
		public void PlayStartSequence()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x060284C5 RID: 165061 RVA: 0x00B4948C File Offset: 0x00B4768C
		public UUIButtonComponent GetDetailBtn()
		{
			return base.GetButton(5);
		}

		// Token: 0x060284C6 RID: 165062 RVA: 0x00B49495 File Offset: 0x00B47695
		protected override void OnBeforeDestroy()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer != null)
			{
				sequencePlayer.Clear();
			}
			this.SequencePlayer = null;
			this.CurrentData = null;
		}

		// Token: 0x060284C7 RID: 165063 RVA: 0x00B494B8 File Offset: 0x00B476B8
		private void RefreshDesc(RogueTowerBuff cfg)
		{
			RoguelikeBossChallengeBuffData currentData = this.CurrentData;
			EDescModel edescModel = (currentData != null) ? currentData.DescMode : EDescModel.DETAIL;
			string textStringId = (edescModel == EDescModel.SIMPLE) ? cfg.BriefDesc : cfg.Describe;
			string[] args = (edescModel == EDescModel.SIMPLE) ? cfg.BriefDescParam() : cfg.DescParam();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, args);
		}

		// Token: 0x060284C8 RID: 165064 RVA: 0x00B49511 File Offset: 0x00B47711
		private void OnBtnDetailClick()
		{
			if (this.CurrentData == null)
			{
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.RoguelikeBossChallengeBuffDetailView, new int[]
			{
				this.CurrentData.BossId,
				this.CurrentData.Id
			}, null);
		}

		// Token: 0x04015E72 RID: 89714
		protected RoguelikeBossChallengeBuffData CurrentData;

		// Token: 0x04015E73 RID: 89715
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x02009972 RID: 39282
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402FD9E RID: 195998
			public const int SprBuffIcon = 0;

			// Token: 0x0402FD9F RID: 195999
			public const int TexBuffIcon = 1;

			// Token: 0x0402FDA0 RID: 196000
			public const int TxtBuffName = 2;

			// Token: 0x0402FDA1 RID: 196001
			public const int TxtDesc = 3;

			// Token: 0x0402FDA2 RID: 196002
			public const int PnlNewTips = 4;

			// Token: 0x0402FDA3 RID: 196003
			public const int BtnDetail = 5;

			// Token: 0x0402FDA4 RID: 196004
			public const int ItemActive = 6;
		}
	}
}
