using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Morale
{
	// Token: 0x020053A4 RID: 21412
	[NullableContext(1)]
	[Nullable(0)]
	public class MoraleBuffActiveTips : UiTickViewBase
	{
		// Token: 0x06036B75 RID: 224117 RVA: 0x00CF3348 File Offset: 0x00CF1548
		public MoraleBuffActiveTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06036B76 RID: 224118 RVA: 0x00CF335C File Offset: 0x00CF155C
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

		// Token: 0x06036B77 RID: 224119 RVA: 0x00CF346C File Offset: 0x00CF166C
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

		// Token: 0x06036B78 RID: 224120 RVA: 0x00CF34C1 File Offset: 0x00CF16C1
		protected override void OnBeforeShow()
		{
			this.UpdateData();
		}

		// Token: 0x06036B79 RID: 224121 RVA: 0x00CF34CC File Offset: 0x00CF16CC
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

		// Token: 0x06036B7A RID: 224122 RVA: 0x00CF35A4 File Offset: 0x00CF17A4
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

		// Token: 0x06036B7B RID: 224123 RVA: 0x00CF35E4 File Offset: 0x00CF17E4
		public void SetStateActive()
		{
			this.SetLockShow(false);
			this.SetTagName("Morale_title_24");
			this.SetTagBg("SP_ItemNewBg");
			this.SetCheckState(9);
			this.SetInvalidLine(false);
			this.SetTitleChangeColor(false);
		}

		// Token: 0x06036B7C RID: 224124 RVA: 0x00CF3619 File Offset: 0x00CF1819
		public void SetStateTempActive()
		{
			this.SetLockShow(true);
			this.SetTagName("Morale_title_25");
			this.SetTagBg("SP_ItemNewBg");
			this.SetCheckState(9);
			this.SetInvalidLine(false);
			this.SetTitleChangeColor(false);
		}

		// Token: 0x06036B7D RID: 224125 RVA: 0x00CF364E File Offset: 0x00CF184E
		public void SetStateNotActive()
		{
			this.SetLockShow(false);
			this.SetTagName("Morale_title_26");
			this.SetTagBg("SP_InvalidationBg");
			this.SetCheckState(10);
			this.SetInvalidLine(true);
			this.SetTitleChangeColor(true);
		}

		// Token: 0x06036B7E RID: 224126 RVA: 0x00CF3683 File Offset: 0x00CF1883
		private void SetLockShow(bool show)
		{
			base.GetItem(7).SetUIActive(show);
		}

		// Token: 0x06036B7F RID: 224127 RVA: 0x00CF3692 File Offset: 0x00CF1892
		private void SetTagName(string key)
		{
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(key);
		}

		// Token: 0x06036B80 RID: 224128 RVA: 0x00CF36A8 File Offset: 0x00CF18A8
		private void SetTagBg(string resId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			UUISprite sprite = base.GetSprite(6);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x06036B81 RID: 224129 RVA: 0x00CF36DC File Offset: 0x00CF18DC
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

		// Token: 0x06036B82 RID: 224130 RVA: 0x00CF371C File Offset: 0x00CF191C
		private void SetInvalidLine(bool show)
		{
			base.GetItem(11).SetUIActive(show);
		}

		// Token: 0x06036B83 RID: 224131 RVA: 0x00CF372C File Offset: 0x00CF192C
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

		// Token: 0x06036B84 RID: 224132 RVA: 0x00CF3759 File Offset: 0x00CF1959
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

		// Token: 0x06036B85 RID: 224133 RVA: 0x00CF378A File Offset: 0x00CF198A
		private void CloseViewOrShowNextData()
		{
			if (this.ShowBuffList.Count > 0)
			{
				this.ShowNextBuff();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x06036B86 RID: 224134 RVA: 0x00CF37AC File Offset: 0x00CF19AC
		private UniTask ShowNextBuff()
		{
			MoraleBuffActiveTips.<ShowNextBuff>d__21 <ShowNextBuff>d__;
			<ShowNextBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextBuff>d__.<>4__this = this;
			<ShowNextBuff>d__.<>1__state = -1;
			<ShowNextBuff>d__.<>t__builder.Start<MoraleBuffActiveTips.<ShowNextBuff>d__21>(ref <ShowNextBuff>d__);
			return <ShowNextBuff>d__.<>t__builder.Task;
		}

		// Token: 0x0401CE4F RID: 118351
		public float TipCountDown;

		// Token: 0x0401CE50 RID: 118352
		public List<MoraleBuffActiveTipsInfo> ShowBuffList = new List<MoraleBuffActiveTipsInfo>();

		// Token: 0x0401CE51 RID: 118353
		[Nullable(2)]
		public MoraleBuffActiveTipsInfo CurShowInfo;

		// Token: 0x0200B635 RID: 46645
		[NullableContext(0)]
		private class EChildType
		{
			// Token: 0x0403731A RID: 226074
			public const int TextTitle = 1;

			// Token: 0x0403731B RID: 226075
			public const int TextDes = 2;

			// Token: 0x0403731C RID: 226076
			public const int PanelHaveTitle = 3;

			// Token: 0x0403731D RID: 226077
			public const int PanelNoTitle = 4;

			// Token: 0x0403731E RID: 226078
			public const int ItemTagNew = 5;

			// Token: 0x0403731F RID: 226079
			public const int SpriteTagBg = 6;

			// Token: 0x04037320 RID: 226080
			public const int PanelClockIcon = 7;

			// Token: 0x04037321 RID: 226081
			public const int TxtNew = 8;

			// Token: 0x04037322 RID: 226082
			public const int ItemCheck = 9;

			// Token: 0x04037323 RID: 226083
			public const int ItemInvalid = 10;

			// Token: 0x04037324 RID: 226084
			public const int ItemInvalidLine = 11;
		}
	}
}
