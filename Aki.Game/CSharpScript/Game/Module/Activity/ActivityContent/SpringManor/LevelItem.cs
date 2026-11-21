using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x02004FFD RID: 20477
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LevelItem : AutoAttachItem<SpringLevelData>
	{
		// Token: 0x0603342E RID: 209966 RVA: 0x00E5F198 File Offset: 0x00E5D398
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(0, typeof(UUIItem)),
				new ValueTuple<int, Type>(1, typeof(UUIButtonComponent)),
				new ValueTuple<int, Type>(2, typeof(UUIItem)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUIItem)),
				new ValueTuple<int, Type>(7, typeof(UUIText)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUISprite)),
				new ValueTuple<int, Type>(11, typeof(UUIItem)),
				new ValueTuple<int, Type>(12, typeof(UUIItem))
			};
			this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
			{
				new ValueTuple<int, Delegate>(1, new Action(this.OnButtonClick))
			};
		}

		// Token: 0x0603342F RID: 209967 RVA: 0x00E5F2F5 File Offset: 0x00E5D4F5
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x06033430 RID: 209968 RVA: 0x00E5F308 File Offset: 0x00E5D508
		protected override void OnRefreshItem(SpringLevelData data)
		{
			if (data == null)
			{
				return;
			}
			this.Data = data;
			this.RefreshPerformance();
		}

		// Token: 0x06033431 RID: 209969 RVA: 0x00E5F31C File Offset: 0x00E5D51C
		public void RefreshPerformance()
		{
			SpringLevelData data = this.Data;
			int atmosphereLevel = SpringManorModel.Instance.GetAtmosphereLevel();
			bool isLock = data.Level > atmosphereLevel;
			this.SetIsLock(isLock);
			UUIText selectText = this.GetSelectText();
			if (selectText != null)
			{
				selectText.SetText(data.Level.ToString(), true);
			}
			UUIItem item = base.GetItem(11);
			if (item != null)
			{
				item.SetUIActive(false);
			}
			bool flag = data.Level >= SpringManorModel.Instance.GetMaxLevel();
			UUIItem item2 = base.GetItem(12);
			if (item2 != null)
			{
				item2.SetUIActive(!flag);
			}
			UUISprite sprite = base.GetSprite(10);
			if (sprite != null)
			{
				sprite.SetUIActive(!flag);
			}
			if (!flag)
			{
				int atmosphere = SpringManorModel.Instance.ActivityData.GetAtmosphere();
				int num = MathUtils.Instance.Clamp((atmosphere - data.ExpLevel) / data.ExpNext, 0, 1);
				sprite.SetFillAmount((float)num);
			}
			SpringManorModel instance = SpringManorModel.Instance;
			bool? flag2 = (instance != null) ? new bool?(instance.ActivityData.IsLevelCanReceive(data.Level)) : null;
			UUIItem item3 = base.GetItem(6);
			if (item3 != null)
			{
				item3.SetUIActive(flag2.GetValueOrDefault());
			}
			Func<int, bool> getIsSelectLevel = this.GetIsSelectLevel;
			bool flag3 = getIsSelectLevel != null && getIsSelectLevel(data.Level);
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.PlayOrReplaySequenceByName(flag3 ? "NorToSle" : "SleToNor", false, null);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 == null)
			{
				return;
			}
			seqPlayer2.StopCurrentSequence(false, true);
		}

		// Token: 0x06033432 RID: 209970 RVA: 0x00E5F49C File Offset: 0x00E5D69C
		[NullableContext(1)]
		public void PlaySequence(string seqName)
		{
			LevelSequencePlayer seqPlayer = this.SeqPlayer;
			if (seqPlayer != null)
			{
				seqPlayer.StopPlayingSequence(false, true);
			}
			LevelSequencePlayer seqPlayer2 = this.SeqPlayer;
			if (seqPlayer2 == null)
			{
				return;
			}
			seqPlayer2.PlayOrReplaySequenceByName(seqName, false, null);
		}

		// Token: 0x06033433 RID: 209971 RVA: 0x00E5F4D7 File Offset: 0x00E5D6D7
		public override void OnSelect()
		{
			if (this.SelectCallback != null && this.Data != null)
			{
				this.SelectCallback(this.Data.Level, this);
			}
		}

		// Token: 0x06033434 RID: 209972 RVA: 0x00E5F500 File Offset: 0x00E5D700
		protected override void OnUnSelect()
		{
		}

		// Token: 0x06033435 RID: 209973 RVA: 0x00E5F502 File Offset: 0x00E5D702
		protected override void OnMoveItem()
		{
		}

		// Token: 0x06033436 RID: 209974 RVA: 0x00E5F504 File Offset: 0x00E5D704
		private void SetIsLock(bool isLock)
		{
			this.IsLock = isLock;
			base.GetItem(2).SetUIActive(!isLock);
			base.GetItem(4).SetUIActive(isLock);
			base.GetText(7).SetUIActive(!isLock);
			base.GetText(8).SetUIActive(isLock);
			base.GetItem(3).SetUIActive(!isLock);
			base.GetItem(5).SetUIActive(isLock);
		}

		// Token: 0x06033437 RID: 209975 RVA: 0x00E5F56F File Offset: 0x00E5D76F
		[NullableContext(1)]
		private UUIText GetSelectText()
		{
			if (this.IsLock)
			{
				return base.GetText(8);
			}
			return base.GetText(7);
		}

		// Token: 0x06033438 RID: 209976 RVA: 0x00E5F588 File Offset: 0x00E5D788
		private void OnButtonClick()
		{
			if (this.ClickCallback != null && this.Data != null)
			{
				this.ClickCallback(this.Data.Level);
			}
		}

		// Token: 0x06033439 RID: 209977 RVA: 0x00E5F5B0 File Offset: 0x00E5D7B0
		public LevelItem() : base(null)
		{
		}

		// Token: 0x0401B3F9 RID: 111609
		private SpringLevelData Data;

		// Token: 0x0401B3FA RID: 111610
		public Action<int> ClickCallback;

		// Token: 0x0401B3FB RID: 111611
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, LevelItem> SelectCallback;

		// Token: 0x0401B3FC RID: 111612
		public Func<int, bool> GetIsSelectLevel;

		// Token: 0x0401B3FD RID: 111613
		private bool IsLock = true;

		// Token: 0x0401B3FE RID: 111614
		private LevelSequencePlayer SeqPlayer;
	}
}
