using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.FlagChallenge
{
	// Token: 0x02004A2F RID: 18991
	[NullableContext(1)]
	[Nullable(0)]
	public class FlagChallengeBuffActiveTips : UiTickViewBase
	{
		// Token: 0x17005FC4 RID: 24516
		// (get) Token: 0x0602F93F RID: 194879 RVA: 0x00D44F1E File Offset: 0x00D4311E
		[Nullable(2)]
		public new FlagChallengeBuffActiveTipsParams OpenParam
		{
			[NullableContext(2)]
			get
			{
				return this.OpenParam as FlagChallengeBuffActiveTipsParams;
			}
		}

		// Token: 0x0602F940 RID: 194880 RVA: 0x00D44F2B File Offset: 0x00D4312B
		public FlagChallengeBuffActiveTips(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602F941 RID: 194881 RVA: 0x00D44F40 File Offset: 0x00D43140
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

		// Token: 0x0602F942 RID: 194882 RVA: 0x00D45050 File Offset: 0x00D43250
		protected override void OnStart()
		{
			int activityId = this.OpenParam.ActivityId;
			this.Data = FlagChallengeModel.Instance.GetFlagChallengeData(activityId);
			this.ShowBuffList = this.Data.GetBuffActiveTipsList();
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
			if (item3 != null)
			{
				item3.SetUIActive(false);
			}
			FlagChallengeBuffActiveTipsInfo flagChallengeBuffActiveTipsInfo = null;
			if (this.ShowBuffList.Count > 0)
			{
				flagChallengeBuffActiveTipsInfo = this.ShowBuffList[0];
				this.ShowBuffList.RemoveAt(0);
			}
			if (flagChallengeBuffActiveTipsInfo == null)
			{
				base.CloseMe(null);
				return;
			}
			this.UpdateData(flagChallengeBuffActiveTipsInfo);
		}

		// Token: 0x0602F943 RID: 194883 RVA: 0x00D450FF File Offset: 0x00D432FF
		protected override void OnBeforeDestroy()
		{
			FlagChallengeData data = this.Data;
			if (data == null)
			{
				return;
			}
			data.ClearBuffActiveTipsList();
		}

		// Token: 0x0602F944 RID: 194884 RVA: 0x00D45114 File Offset: 0x00D43314
		public void UpdateData(FlagChallengeBuffActiveTipsInfo buffInfo)
		{
			this.CurShowInfo = buffInfo;
			if (this.CurShowInfo == null)
			{
				base.CloseMe(null);
				return;
			}
			this.TipCountDown = (float)FlagChallengeConfig.Instance.GetBuffShowTime();
			FlagChallengeBuffData buffData = this.Data.GetBuffData(this.CurShowInfo.BuffId);
			if (buffData == null)
			{
				return;
			}
			base.GetText(1).ShowTextNew(buffData.Config.BuffName);
			base.GetText(2).ShowTextNew(buffData.Config.BuffDesc);
			this.UpdateState();
		}

		// Token: 0x0602F945 RID: 194885 RVA: 0x00D451A0 File Offset: 0x00D433A0
		public void UpdateState()
		{
			switch (this.CurShowInfo.State)
			{
			case EFlagChallengeBuffStatus.NotActive:
				this.SetStateNotActive();
				return;
			case EFlagChallengeBuffStatus.Active:
				this.SetStateActive();
				return;
			case EFlagChallengeBuffStatus.TempActive:
				this.SetStateTempActive();
				return;
			default:
				return;
			}
		}

		// Token: 0x0602F946 RID: 194886 RVA: 0x00D451E0 File Offset: 0x00D433E0
		public void SetStateActive()
		{
			this.SetLockShow(false);
			this.SetTagName("Morale_title_24");
			this.SetTagBg("SP_ItemNewBg");
			this.SetCheckState(9);
			this.SetInvalidLine(false);
			this.SetTitleChangeColor(false);
		}

		// Token: 0x0602F947 RID: 194887 RVA: 0x00D45215 File Offset: 0x00D43415
		public void SetStateTempActive()
		{
			this.SetLockShow(true);
			this.SetTagName("Morale_title_25");
			this.SetTagBg("SP_ItemNewBg");
			this.SetCheckState(9);
			this.SetInvalidLine(false);
			this.SetTitleChangeColor(false);
		}

		// Token: 0x0602F948 RID: 194888 RVA: 0x00D4524A File Offset: 0x00D4344A
		public void SetStateNotActive()
		{
			this.SetLockShow(false);
			this.SetTagName("Morale_title_26");
			this.SetTagBg("SP_InvalidationBg");
			this.SetCheckState(10);
			this.SetInvalidLine(true);
			this.SetTitleChangeColor(true);
		}

		// Token: 0x0602F949 RID: 194889 RVA: 0x00D4527F File Offset: 0x00D4347F
		private void SetLockShow(bool show)
		{
			base.GetItem(7).SetUIActive(show);
		}

		// Token: 0x0602F94A RID: 194890 RVA: 0x00D4528E File Offset: 0x00D4348E
		private void SetTagName(string key)
		{
			UUIText text = base.GetText(8);
			if (text == null)
			{
				return;
			}
			text.ShowTextNew(key);
		}

		// Token: 0x0602F94B RID: 194891 RVA: 0x00D452A4 File Offset: 0x00D434A4
		private void SetTagBg(string resId)
		{
			string resourcePath = UiResourceConfig.Instance.GetResourcePath(resId);
			UUISprite sprite = base.GetSprite(6);
			this.SetSpriteByPath(resourcePath, sprite, false, null, null);
		}

		// Token: 0x0602F94C RID: 194892 RVA: 0x00D452D8 File Offset: 0x00D434D8
		private void SetCheckState(int index)
		{
			foreach (int num in new List<int>
			{
				9,
				10
			})
			{
				base.GetItem(num).SetUIActive(num == index);
			}
		}

		// Token: 0x0602F94D RID: 194893 RVA: 0x00D45344 File Offset: 0x00D43544
		private void SetInvalidLine(bool show)
		{
			base.GetItem(11).SetUIActive(show);
		}

		// Token: 0x0602F94E RID: 194894 RVA: 0x00D45354 File Offset: 0x00D43554
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

		// Token: 0x0602F94F RID: 194895 RVA: 0x00D45381 File Offset: 0x00D43581
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

		// Token: 0x0602F950 RID: 194896 RVA: 0x00D453B2 File Offset: 0x00D435B2
		private void CloseViewOrShowNextData()
		{
			if (this.ShowBuffList.Count > 0)
			{
				this.ShowNextBuff();
				return;
			}
			base.CloseMe(null);
		}

		// Token: 0x0602F951 RID: 194897 RVA: 0x00D453D4 File Offset: 0x00D435D4
		private UniTask ShowNextBuff()
		{
			FlagChallengeBuffActiveTips.<ShowNextBuff>d__23 <ShowNextBuff>d__;
			<ShowNextBuff>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<ShowNextBuff>d__.<>4__this = this;
			<ShowNextBuff>d__.<>1__state = -1;
			<ShowNextBuff>d__.<>t__builder.Start<FlagChallengeBuffActiveTips.<ShowNextBuff>d__23>(ref <ShowNextBuff>d__);
			return <ShowNextBuff>d__.<>t__builder.Task;
		}

		// Token: 0x04019392 RID: 103314
		public float TipCountDown;

		// Token: 0x04019393 RID: 103315
		public List<FlagChallengeBuffActiveTipsInfo> ShowBuffList = new List<FlagChallengeBuffActiveTipsInfo>();

		// Token: 0x04019394 RID: 103316
		[Nullable(2)]
		public FlagChallengeBuffActiveTipsInfo CurShowInfo;

		// Token: 0x04019395 RID: 103317
		[Nullable(2)]
		private FlagChallengeData Data;
	}
}
