using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Aki.Config;
using Aki.Protocol;
using CSharpScript.Game.Module.Activity.ActivityContent.RougeActivity;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004E0E RID: 19982
	public class RoguelikeInstanceBtnPanel : UiPanelBase
	{
		// Token: 0x060338D8 RID: 211160 RVA: 0x00C0CA14 File Offset: 0x00C0AC14
		protected unsafe override void OnRegisterComponent()
		{
			int num = 7;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(1, new Action(this.OnBtnShopClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(0, new Action(this.OnBtnSkillTreeClick));
			this.BtnBindInfo = list2;
		}

		// Token: 0x060338D9 RID: 211161 RVA: 0x00C0CB84 File Offset: 0x00C0AD84
		protected override UniTask OnBeforeStartAsync()
		{
			RoguelikeInstanceBtnPanel.<OnBeforeStartAsync>d__2 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<RoguelikeInstanceBtnPanel.<OnBeforeStartAsync>d__2>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060338DA RID: 211162 RVA: 0x00C0CBBF File Offset: 0x00C0ADBF
		protected override void OnStart()
		{
			this.Refresh();
		}

		// Token: 0x060338DB RID: 211163 RVA: 0x00C0CBC7 File Offset: 0x00C0ADC7
		protected override void OnBeforeShow()
		{
			this.BindRedDot();
		}

		// Token: 0x060338DC RID: 211164 RVA: 0x00C0CBCF File Offset: 0x00C0ADCF
		protected override void OnAfterHide()
		{
			this.UnBindRedDot();
		}

		// Token: 0x060338DD RID: 211165 RVA: 0x00C0CBD7 File Offset: 0x00C0ADD7
		public void BindRedDot()
		{
			RedDotController.Instance.BindRedDot(ERedDotName.RogueSkillUnlock, base.GetItem(5), null, 0);
			RedDotController.Instance.BindRedDot(ERedDotName.RoguelikeShop, base.GetItem(6), null, 0);
		}

		// Token: 0x060338DE RID: 211166 RVA: 0x00C0CC03 File Offset: 0x00C0AE03
		public void UnBindRedDot()
		{
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RogueSkillUnlock, base.GetItem(5), 0);
			RedDotController.Instance.UnBindGivenUi(ERedDotName.RoguelikeShop, base.GetItem(6), 0);
		}

		// Token: 0x060338DF RID: 211167 RVA: 0x00C0CC30 File Offset: 0x00C0AE30
		private unsafe void OnBtnShopClick()
		{
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				return;
			}
			RogueSeason? rogueSeasonConfigById = RoguelikeConfig.Instance.GetRogueSeasonConfigById(rogueSeasonData.SeasonId);
			PayShopViewData payShopViewData = new PayShopViewData();
			PayShopViewData payShopViewData2 = payShopViewData;
			int num = 1;
			List<int> list = new List<int>(num);
			CollectionsMarshal.SetCount<int>(list, num);
			Span<int> span = CollectionsMarshal.AsSpan<int>(list);
			int index = 0;
			*span[index] = rogueSeasonConfigById.Value.ShopId;
			payShopViewData2.ShowShopIdList = list;
			payShopViewData.PayShopId = (PayShopDefine.EPayShopTabType)rogueSeasonConfigById.Value.ShopId;
			RoguelikeModel.Instance.RecordRoguelikeShopRedDot();
			PayShopController.Instance.OpenPayShopView(payShopViewData, null);
		}

		// Token: 0x060338E0 RID: 211168 RVA: 0x00C0CCD8 File Offset: 0x00C0AED8
		private void OnBtnSkillTreeClick()
		{
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
			if (rogueSeasonData == null)
			{
				return;
			}
			RoguelikeController.Instance.OpenRoguelikeSkillView(rogueSeasonData.SeasonId);
		}

		// Token: 0x060338E1 RID: 211169 RVA: 0x00C0CD10 File Offset: 0x00C0AF10
		public void Refresh()
		{
			ActivityRogueData currentActivityData = ActivityRogueController.Instance.GetCurrentActivityData();
			RogueSeasonData rogueSeasonData = (currentActivityData != null) ? currentActivityData.SeasonData : null;
			if (rogueSeasonData != null)
			{
				RogueParam? rogueParam;
				int num = (RoguelikeModel.Instance.GetParamConfigBySeasonId(null) != null) ? rogueParam.GetValueOrDefault().WeekTokenMaxCount : 1;
				float fillAmount = (float)rogueSeasonData.TokenItemCount / (float)num;
				UUISprite sprite = base.GetSprite(4);
				if (sprite != null)
				{
					sprite.SetFillAmount(fillAmount);
				}
				LguiUtil.Instance.SetLocalTextNew(base.GetText(3), "Roguelike_ActivityMain_Score", new <>z__ReadOnlyArray<object>(new object[]
				{
					rogueSeasonData.TokenItemCount,
					num
				}));
			}
			double time = (double)RoguelikeModel.Instance.TempCountdown.GetValueOrDefault() - TimeUtil.Instance.GetServerTime();
			CommonDefine.IRemainTime remainTime = TimeUtil.Instance.CalculateRemainingTime(time, CommonDefine.ETimeType.Minute);
			if (remainTime == null)
			{
				return;
			}
			LguiUtil.Instance.SetLocalText(base.GetText(2), remainTime.TextId, new <>z__ReadOnlySingleElementList<object>(remainTime.TimeValue));
		}

		// Token: 0x0200AFA5 RID: 44965
		private class ERoguelikeInstanceBtnPanelDefine
		{
			// Token: 0x04035530 RID: 218416
			public const int BtnSkillTree = 0;

			// Token: 0x04035531 RID: 218417
			public const int BtnShop = 1;

			// Token: 0x04035532 RID: 218418
			public const int TxtShopTime = 2;

			// Token: 0x04035533 RID: 218419
			public const int TxtShopPoint = 3;

			// Token: 0x04035534 RID: 218420
			public const int SpriteProgress = 4;

			// Token: 0x04035535 RID: 218421
			public const int SkillTreeRedItem = 5;

			// Token: 0x04035536 RID: 218422
			public const int ShopRedItem = 6;
		}
	}
}
