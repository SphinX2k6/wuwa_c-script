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
	// Token: 0x02004DC6 RID: 19910
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class RoguelikeBossChallengeDebuffItem : GridProxyAbstract<RoguelikeBossChallengeBuffData>
	{
		// Token: 0x06033652 RID: 210514 RVA: 0x00BFFCE0 File Offset: 0x00BFDEE0
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

		// Token: 0x06033653 RID: 210515 RVA: 0x00BFFE2B File Offset: 0x00BFE02B
		protected override void OnStart()
		{
			this.SequencePlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06033654 RID: 210516 RVA: 0x00BFFE40 File Offset: 0x00BFE040
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

		// Token: 0x06033655 RID: 210517 RVA: 0x00BFFEFA File Offset: 0x00BFE0FA
		public void SetNewTipsVisible(bool visible)
		{
			base.GetItem(4).SetUIActive(visible);
		}

		// Token: 0x06033656 RID: 210518 RVA: 0x00BFFF09 File Offset: 0x00BFE109
		public bool IsCurrentBossBuff(int bossId)
		{
			RoguelikeBossChallengeBuffData currentData = this.CurrentData;
			return currentData != null && currentData.BossId == bossId;
		}

		// Token: 0x06033657 RID: 210519 RVA: 0x00BFFF20 File Offset: 0x00BFE120
		public void PlayStartSequence()
		{
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayOrReplaySequenceByName("Start", false, null);
		}

		// Token: 0x06033658 RID: 210520 RVA: 0x00BFFF4C File Offset: 0x00BFE14C
		public UUIButtonComponent GetDetailBtn()
		{
			return base.GetButton(5);
		}

		// Token: 0x06033659 RID: 210521 RVA: 0x00BFFF55 File Offset: 0x00BFE155
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

		// Token: 0x0603365A RID: 210522 RVA: 0x00BFFF78 File Offset: 0x00BFE178
		private void RefreshDesc(RogueTowerBuff cfg)
		{
			RoguelikeBossChallengeBuffData currentData = this.CurrentData;
			EDescModel edescModel = (currentData != null) ? currentData.DescMode : EDescModel.DETAIL;
			string textStringId = (edescModel == EDescModel.SIMPLE) ? cfg.BriefDesc : cfg.Describe;
			string[] args = (edescModel == EDescModel.SIMPLE) ? cfg.BriefDescParam() : cfg.DescParam();
			LguiUtil.Instance.SetLocalTextNew(base.GetText(3), textStringId, args);
		}

		// Token: 0x0603365B RID: 210523 RVA: 0x00BFFFD1 File Offset: 0x00BFE1D1
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

		// Token: 0x0401B49F RID: 111775
		protected RoguelikeBossChallengeBuffData CurrentData;

		// Token: 0x0401B4A0 RID: 111776
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0200AF3D RID: 44861
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x04035369 RID: 217961
			public const int SprBuffIcon = 0;

			// Token: 0x0403536A RID: 217962
			public const int TexBuffIcon = 1;

			// Token: 0x0403536B RID: 217963
			public const int TxtBuffName = 2;

			// Token: 0x0403536C RID: 217964
			public const int TxtDesc = 3;

			// Token: 0x0403536D RID: 217965
			public const int PnlNewTips = 4;

			// Token: 0x0403536E RID: 217966
			public const int BtnDetail = 5;

			// Token: 0x0403536F RID: 217967
			public const int ItemActive = 6;
		}
	}
}
