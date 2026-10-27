using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.AutoAttach;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.SpringManor
{
	// Token: 0x0200607F RID: 24703
	[NullableContext(2)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class LevelItem : AutoAttachItem<SpringLevelData>
	{
		// Token: 0x0603E76A RID: 255850 RVA: 0x00F183D4 File Offset: 0x00F165D4
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

		// Token: 0x0603E76B RID: 255851 RVA: 0x00F18531 File Offset: 0x00F16731
		protected override void OnStart()
		{
			this.SeqPlayer = new LevelSequencePlayer(this.RootItem);
		}

		// Token: 0x0603E76C RID: 255852 RVA: 0x00F18544 File Offset: 0x00F16744
		protected override void OnRefreshItem(SpringLevelData data)
		{
			if (data == null)
			{
				return;
			}
			this.Data = data;
			this.RefreshPerformance();
		}

		// Token: 0x0603E76D RID: 255853 RVA: 0x00F18558 File Offset: 0x00F16758
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

		// Token: 0x0603E76E RID: 255854 RVA: 0x00F186D8 File Offset: 0x00F168D8
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

		// Token: 0x0603E76F RID: 255855 RVA: 0x00F18713 File Offset: 0x00F16913
		public override void OnSelect()
		{
			if (this.SelectCallback != null && this.Data != null)
			{
				this.SelectCallback(this.Data.Level, this);
			}
		}

		// Token: 0x0603E770 RID: 255856 RVA: 0x00F1873C File Offset: 0x00F1693C
		protected override void OnUnSelect()
		{
		}

		// Token: 0x0603E771 RID: 255857 RVA: 0x00F1873E File Offset: 0x00F1693E
		protected override void OnMoveItem()
		{
		}

		// Token: 0x0603E772 RID: 255858 RVA: 0x00F18740 File Offset: 0x00F16940
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

		// Token: 0x0603E773 RID: 255859 RVA: 0x00F187AB File Offset: 0x00F169AB
		[NullableContext(1)]
		private UUIText GetSelectText()
		{
			if (this.IsLock)
			{
				return base.GetText(8);
			}
			return base.GetText(7);
		}

		// Token: 0x0603E774 RID: 255860 RVA: 0x00F187C4 File Offset: 0x00F169C4
		private void OnButtonClick()
		{
			if (this.ClickCallback != null && this.Data != null)
			{
				this.ClickCallback(this.Data.Level);
			}
		}

		// Token: 0x0603E775 RID: 255861 RVA: 0x00F187EC File Offset: 0x00F169EC
		public LevelItem() : base(null)
		{
		}

		// Token: 0x04020ACC RID: 133836
		private SpringLevelData Data;

		// Token: 0x04020ACD RID: 133837
		public Action<int> ClickCallback;

		// Token: 0x04020ACE RID: 133838
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Action<int, LevelItem> SelectCallback;

		// Token: 0x04020ACF RID: 133839
		public Func<int, bool> GetIsSelectLevel;

		// Token: 0x04020AD0 RID: 133840
		private bool IsLock = true;

		// Token: 0x04020AD1 RID: 133841
		private LevelSequencePlayer SeqPlayer;
	}
}
