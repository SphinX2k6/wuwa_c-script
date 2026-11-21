using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x02004387 RID: 17287
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffActiveTips : UiTickViewBase
	{
		// Token: 0x0602BABB RID: 178875 RVA: 0x00C423F0 File Offset: 0x00C405F0
		public MoraleBuffActiveTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602BABC RID: 178876 RVA: 0x00C42404 File Offset: 0x00C40604
		protected override void OnRegisterComponent()
		{
			this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
			{
				new ValueTuple<int, Type>(1, typeof(UUIText)),
				new ValueTuple<int, Type>(2, typeof(UUIText)),
				new ValueTuple<int, Type>(3, typeof(UUIItem)),
				new ValueTuple<int, Type>(4, typeof(UUIItem)),
				new ValueTuple<int, Type>(5, typeof(UUIItem)),
				new ValueTuple<int, Type>(6, typeof(UUISprite)),
				new ValueTuple<int, Type>(7, typeof(UUIItem)),
				new ValueTuple<int, Type>(8, typeof(UUIText)),
				new ValueTuple<int, Type>(9, typeof(UUIItem)),
				new ValueTuple<int, Type>(10, typeof(UUIItem)),
				new ValueTuple<int, Type>(11, typeof(UUIItem))
			};
		}

		// Token: 0x0602BABD RID: 178877 RVA: 0x00C42514 File Offset: 0x00C40714
		protected override void OnStart()
		{
			this.ShowBuffList = MoraleModel.Instance.BuffActiveTipsList;
			UUIItem item = base.GetItem(3);
			if (item != null)
			{
				item.SetUIActive(true);
			}
			UUIItem item2 = base.GetItem(5);
			if (item2 != null)
			{
				item2.SetUIActive(true);
			}
			UUIItem item3 = base.GetItem(4);
			if (item3 == null)
			{
				return;
			}
			item3.SetUIActive(false);
		}

		// Token: 0x0602BABE RID: 178878 RVA: 0x00C42569 File Offset: 0x00C40769
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x0602BABF RID: 178879 RVA: 0x00C42574 File Offset: 0x00C40774
		public void UpdateData()
		{
			if (this.ShowBuffList.Count > 0)
			{
				this.CurShowInfo = this.ShowBuffList[0];
				this.ShowBuffList.RemoveAt(0);
			}
			else
			{
				this.CurShowInfo = null;
			}
			if (this.CurShowInfo == null)
			{
				base.CloseMe(null);
				return;
			}
			this.TipCountDown = (float)MoraleConfig.Instance.GetMoraleBuffShowTime();
			MoraleBuffData moraleBuffData = MoraleModel.Instance.BuffMap.ContainsKey(this.CurShowInfo.BuffId) ? MoraleModel.Instance.BuffMap[this.CurShowInfo.BuffId] : null;
			if (moraleBuffData == null)
			{
				return;
			}
			base.GetText(1).ShowTextNew(moraleBuffData.Config.BuffName);
			base.GetText(2).ShowTextNew(moraleBuffData.Config.BuffDescDetail);
			this.UpdateState();
		}

		// Token: 0x0602BAC0 RID: 178880 RVA: 0x00C4264C File Offset: 0x00C4084C
		public void UpdateState()
		{
			switch (this.CurShowInfo.State)
			{
			case EMoraleBuffState.TempActive:
				this.SetStateTempActive();
				return;
			case EMoraleBuffState.Active:
				this.SetStateActive();
				return;
			case EMoraleBuffState.NotActive:
				this.SetStateNotActive();
				return;
			default:
				return;
			}
		}

		// Token: 0x0602BAC1 RID: 178881 RVA: 0x00C4268C File Offset: 0x00C4088C
		public void SetStateActive()
		{
			this.SetLockShow(false);
			this.SetTagName("Morale_title_24");
			this.SetTagBg("SP_ItemNewBg");
			this.SetCheckState(9);
			this.SetInvalidLine(false);
			this.SetTitleChangeColor(false);
		}

		// Token: 0x0602BAC2 RID: 178882 RVA: 0x00C426C1 File Offset: 0x00C408C1
		public void SetStateTempActive()
		{
			this.SetLockShow(true);
			this.SetTagName("Morale_title_25");
			this.SetTagBg("SP_ItemNewBg");
			this.SetCheckState(9);
			this.SetInvalidLine(false);
			this.SetTitleChangeColor(false);
		}

		// Token: 0x0602BAC3 RID: 178883 RVA: 0x00C426F6 File Offset: 0x00C408F6
		public void SetStateNotActive()
		{
			this.SetLockShow(false);
			this.SetTagName("Morale_title_26");
			this.SetTagBg("SP_InvalidationBg");
			this.SetCheckState(10);
			this.SetInvalidLine(true);
			this.SetTitleChangeColor(true);
		}

		// Token: 0x0602BAC4 RID: 178884 RVA: 0x00C4272B File Offset: 0x00C4092B
		private void SetLockShow(bool show)
		{
			base.GetItem(7).SetUIActive(show);
		}

		// Token: 0x0602BAC5 RID: 178885 RVA: 0x00C4273A File Offset: 0x00C4093A
		private void SetTagName(string key)
		{
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(key);
		}

		// Token: 0x0602BAC6 RID: 178886 RVA: 0x00C42750 File Offset: 0x00C40950
		private void SetTagBg(string resId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			UUISprite sprite = base.GetSprite(6);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x0602BAC7 RID: 178887 RVA: 0x00C42784 File Offset: 0x00C40984
		private void SetCheckState(int index)
		{
			foreach (int num in new int[]
			{
				9,
				10
			})
			{
				base.GetItem(num).SetUIActive(num == index);
			}
		}

		// Token: 0x0602BAC8 RID: 178888 RVA: 0x00C427C4 File Offset: 0x00C409C4
		private void SetInvalidLine(bool show)
		{
			base.GetItem(11).SetUIActive(show);
		}

		// Token: 0x0602BAC9 RID: 178889 RVA: 0x00C427D4 File Offset: 0x00C409D4
		private void SetTitleChangeColor(bool useChangeColor)
		{
			UUIText text = base.GetText(1);
			if (text != null)
			{
				UUIItem uuiitem = text;
				FColor? fcolor = new FColor?(text.changeColor);
				uuiitem.SetChangeColor(useChangeColor, fcolor);
			}
		}

		// Token: 0x0602BACA RID: 178890 RVA: 0x00C42801 File Offset: 0x00C40A01
		protected override void OnTick(float delta)
		{
			if (this.TipCountDown <= 0f)
			{
				return;
			}
			this.TipCountDown -= delta;
			if (this.TipCountDown <= 0f)
			{
				this.CloseViewOrShowNextData();
			}
		}

		// Token: 0x0602BACB RID: 178891 RVA: 0x00C42832 File Offset: 0x00C40A32
		private void CloseViewOrShowNextData()
		{
			if (this.ShowBuffList.Count > 0)
			{
				this.ShowNextBuff();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0602BACC RID: 178892 RVA: 0x00C42854 File Offset: 0x00C40A54
		private UniTask ShowNextBuff()
		{
			MoraleBuffActiveTips.<ShowNextBuff>d__21 <ShowNextBuff>d__;
			<ShowNextBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextBuff>d__.<>4__this = this;
			<ShowNextBuff>d__.<>1__state = -1;
			<ShowNextBuff>d__.<>t__builder.Start<MoraleBuffActiveTips.<ShowNextBuff>d__21>(ref <ShowNextBuff>d__);
			return <ShowNextBuff>d__.<>t__builder.Task;
		}

		// Token: 0x040178E7 RID: 96487
		public float TipCountDown;

		// Token: 0x040178E8 RID: 96488
		public List<MoraleBuffActiveTipsInfo> ShowBuffList = new List<MoraleBuffActiveTipsInfo>();

		// Token: 0x040178E9 RID: 96489
		[Nullable(2)]
		public MoraleBuffActiveTipsInfo CurShowInfo;

		// Token: 0x0200A06D RID: 41069
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x04031D6F RID: 204143
			public const int TextTitle = 1;

			// Token: 0x04031D70 RID: 204144
			public const int TextDes = 2;

			// Token: 0x04031D71 RID: 204145
			public const int PanelHaveTitle = 3;

			// Token: 0x04031D72 RID: 204146
			public const int PanelNoTitle = 4;

			// Token: 0x04031D73 RID: 204147
			public const int ItemTagNew = 5;

			// Token: 0x04031D74 RID: 204148
			public const int SpriteTagBg = 6;

			// Token: 0x04031D75 RID: 204149
			public const int PanelClockIcon = 7;

			// Token: 0x04031D76 RID: 204150
			public const int TxtNew = 8;

			// Token: 0x04031D77 RID: 204151
			public const int ItemCheck = 9;

			// Token: 0x04031D78 RID: 204152
			public const int ItemInvalid = 10;

			// Token: 0x04031D79 RID: 204153
			public const int ItemInvalidLine = 11;
		}
	}
}
