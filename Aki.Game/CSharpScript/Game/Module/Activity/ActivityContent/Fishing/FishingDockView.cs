using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Fishing
{
	// Token: 0x0200558A RID: 21898
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingDockView : UiViewBase
	{
		// Token: 0x0603643E RID: 222270 RVA: 0x00F21BD5 File Offset: 0x00F1FDD5
		[NullableContext(1)]
		public FishingDockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603643F RID: 222271 RVA: 0x00F21BE0 File Offset: 0x00F1FDE0
		protected unsafe override void OnRegisterComponent()
		{
			int num = 19;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(9, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(10, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(11, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(12, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(13, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(14, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(15, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(16, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(17, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(18, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 5;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(8, new Action(this.OnClickIllustratedBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(10, new Action(this.OnClickCabinBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(12, new Action(this.OnClickTechnologyBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(14, new Action(this.OnClickTransactionBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(15, new Action(this.OnClickSailingBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06036440 RID: 222272 RVA: 0x00F21F52 File Offset: 0x00F20152
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingRefreshBackpackData, new Action(this.FishingRefreshBackpackData));
		}

		// Token: 0x06036441 RID: 222273 RVA: 0x00F21F70 File Offset: 0x00F20170
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingRefreshBackpackData, new Action(this.FishingRefreshBackpackData));
		}

		// Token: 0x06036442 RID: 222274 RVA: 0x00F21F90 File Offset: 0x00F20190
		protected override UniTask OnBeforeStartAsync()
		{
			FishingDockView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingDockView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x06036443 RID: 222275 RVA: 0x00F21FD4 File Offset: 0x00F201D4
		protected override void OnStart()
		{
			FishingRewardLimitTimeButton limitTimeRewardItem = this.LimitTimeRewardItem;
			if (limitTimeRewardItem != null)
			{
				limitTimeRewardItem.RefreshActive();
			}
			LevelSequencePlayer roleTalkLevelSequencePlayer = this.RoleTalkLevelSequencePlayer;
			if (roleTalkLevelSequencePlayer != null)
			{
				roleTalkLevelSequencePlayer.PlayLevelSequenceByName("Start", false, null, false);
			}
			RedDotController.Instance.BindRedDot(ERedDotName.FishingTech, base.GetItem(17), null, 0);
		}

		// Token: 0x06036444 RID: 222276 RVA: 0x00F2202C File Offset: 0x00F2022C
		protected override void OnBeforeShow()
		{
			this.RefreshView();
			FishingRewardLimitTimeButton limitTimeRewardItem = this.LimitTimeRewardItem;
			if (limitTimeRewardItem != null)
			{
				limitTimeRewardItem.RefreshActive();
			}
			this.RefreshShopRedDot();
			this.RefreshTechRedDot();
			FishingCurrencyItem fishingCurrencyItem = this.FishingCurrencyItem;
			if (fishingCurrencyItem == null)
			{
				return;
			}
			fishingCurrencyItem.RefreshItem();
		}

		// Token: 0x06036445 RID: 222277 RVA: 0x00F22061 File Offset: 0x00F20261
		protected override void OnBeforeDestroy()
		{
			FishingModel.Instance.DockId = 0;
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingTech, base.GetItem(17), 0);
			FishingController.Instance.ShowEffectInWorld();
		}

		// Token: 0x06036446 RID: 222278 RVA: 0x00F22090 File Offset: 0x00F20290
		private void RefreshShopRedDot()
		{
			int shopId = DockyardModel.Instance.ShopId;
			bool uiactive = PayShopModel.Instance.CheckShopItemCheckFlag((PayShopDefine.EPayShopTabType)shopId, 1);
			base.GetItem(18).SetUIActive(uiactive);
		}

		// Token: 0x06036447 RID: 222279 RVA: 0x00F220C4 File Offset: 0x00F202C4
		private void RefreshView()
		{
			FishingDockQuestItem fishingDockQuestItem = this.FishingDockQuestItem;
			if (fishingDockQuestItem != null)
			{
				fishingDockQuestItem.RefreshItem();
			}
			FishingDockReputationItem fishingDockReputationItem = this.FishingDockReputationItem;
			if (fishingDockReputationItem != null)
			{
				fishingDockReputationItem.RefreshItem();
			}
			bool uiactive = FunctionModel.Instance.IsOpen(10077);
			UUIButtonComponent button = base.GetButton(14);
			if (button != null)
			{
				button.RootUIComp.Get().SetUIActive(uiactive);
			}
			this.RefreshCabinText();
			bool uiactive2 = FunctionModel.Instance.IsOpen(10078);
			UUIButtonComponent button2 = base.GetButton(12);
			if (button2 != null)
			{
				button2.RootUIComp.Get().SetUIActive(uiactive2);
			}
			int allFishingTechCount = FishingModel.Instance.AllFishingTechCount;
			int unlockFishingTechCount = FishingModel.Instance.UnlockFishingTechCount;
			base.GetText(13).SetText(unlockFishingTechCount.ToString() + "/" + allFishingTechCount.ToString(), true);
			bool flag = FunctionModel.Instance.IsOpen(10079);
			UUIButtonComponent button3 = base.GetButton(8);
			if (button3 != null)
			{
				button3.RootUIComp.Get().SetUIActive(flag);
			}
			FishingPermanentRewardButton permanentRewardItem = this.PermanentRewardItem;
			if (permanentRewardItem != null)
			{
				permanentRewardItem.SetUiActive(flag);
			}
			int allFishingItemCount = FishingModel.Instance.AllFishingItemCount;
			int unLockFishingItemCount = FishingModel.Instance.UnLockFishingItemCount;
			base.GetText(9).SetText(unLockFishingItemCount.ToString() + "/" + allFishingItemCount.ToString(), true);
			List<int> roleTalkIds = FishingModel.Instance.RoleTalkIds;
			if (roleTalkIds != null)
			{
				roleTalkIds.Sort((int a, int b) => b - a);
			}
			if (roleTalkIds == null || roleTalkIds.Count == 0)
			{
				base.GetItem(3).SetUIActive(false);
				return;
			}
			base.GetItem(3).SetUIActive(true);
			FishingNotice fishingNotice = FishingConfig.Instance.GetFishingNotice(roleTalkIds[0]);
			LguiUtil.Instance.SetLocalTextNew(base.GetText(16), fishingNotice.AlertTip, Array.Empty<object>());
		}

		// Token: 0x06036448 RID: 222280 RVA: 0x00F222B0 File Offset: 0x00F204B0
		private void OnClickBackBtn()
		{
			if (FishingController.Instance.IsInFishingShip())
			{
				FishingController.Instance.ConfirmToTeleportToPort(delegate
				{
					FishingController.Instance.TeleportToPortPosition(FishingModel.Instance.DockId);
					UiManager.Instance.OpenView(EUiViewName.FishingLoadingView, false, delegate(bool _, int _)
					{
						base.CloseMe(null);
					});
				});
				return;
			}
			UiManager.Instance.OpenView(EUiViewName.FishingLoadingView, false, delegate(bool _, int _)
			{
				base.CloseMe(null);
			});
		}

		// Token: 0x06036449 RID: 222281 RVA: 0x00F22301 File Offset: 0x00F20501
		private void OnClickSailingBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.SailingView, null, null);
		}

		// Token: 0x0603644A RID: 222282 RVA: 0x00F22314 File Offset: 0x00F20514
		private void OnClickIllustratedBtn()
		{
			FishingController.Instance.OpenFishingHandBookView();
		}

		// Token: 0x0603644B RID: 222283 RVA: 0x00F22320 File Offset: 0x00F20520
		private void OnClickCabinBtn()
		{
			FishingController.Instance.OpenDockyardView();
		}

		// Token: 0x0603644C RID: 222284 RVA: 0x00F2232C File Offset: 0x00F2052C
		private void OnClickTechnologyBtn()
		{
			FishingController.Instance.OpenFishingTechRootView();
		}

		// Token: 0x0603644D RID: 222285 RVA: 0x00F22338 File Offset: 0x00F20538
		private void OnClickTransactionBtn()
		{
			FishingController.Instance.OpenDockyardShopView(null);
		}

		// Token: 0x0603644E RID: 222286 RVA: 0x00F22358 File Offset: 0x00F20558
		private void RefreshTechRedDot()
		{
			FishingModel.Instance.RefreshTechCanLevelUp();
		}

		// Token: 0x0603644F RID: 222287 RVA: 0x00F22364 File Offset: 0x00F20564
		private void FishingRefreshBackpackData()
		{
			this.RefreshCabinText();
		}

		// Token: 0x06036450 RID: 222288 RVA: 0x00F2236C File Offset: 0x00F2056C
		private void RefreshCabinText()
		{
			int backpackSize = DockyardModel.Instance.BackpackSize;
			int backpackUseSize = DockyardModel.Instance.BackpackUseSize;
			string str;
			if ((float)backpackUseSize / (float)backpackSize * 100f >= (float)FishingModel.Instance.FishingBagRedPercentage)
			{
				str = StringUtils.Format("<color=#c25757>{0}</color>", new string[]
				{
					backpackUseSize.ToString() ?? ""
				});
			}
			else
			{
				str = StringUtils.Format("<color=#ffffff>{0}</color>", new string[]
				{
					backpackUseSize.ToString() ?? ""
				});
			}
			base.GetText(11).SetText(str + "/" + backpackSize.ToString(), true);
		}

		// Token: 0x0401CA61 RID: 117345
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401CA62 RID: 117346
		private FishingDockQuestItem FishingDockQuestItem;

		// Token: 0x0401CA63 RID: 117347
		private FishingDockReputationItem FishingDockReputationItem;

		// Token: 0x0401CA64 RID: 117348
		private FishingRewardLimitTimeButton LimitTimeRewardItem;

		// Token: 0x0401CA65 RID: 117349
		private FishingPermanentRewardButton PermanentRewardItem;

		// Token: 0x0401CA66 RID: 117350
		private LevelSequencePlayer RoleTalkLevelSequencePlayer;

		// Token: 0x0401CA67 RID: 117351
		private FishingCurrencyItem FishingCurrencyItem;

		// Token: 0x0200B1FA RID: 45562
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x04037011 RID: 225297
			public const int CaptionItem = 0;

			// Token: 0x04037012 RID: 225298
			public const int ExpItem = 1;

			// Token: 0x04037013 RID: 225299
			public const int QuestItem = 2;

			// Token: 0x04037014 RID: 225300
			public const int RoleTalkItem = 3;

			// Token: 0x04037015 RID: 225301
			public const int IllustratedRewardBtn = 4;

			// Token: 0x04037016 RID: 225302
			public const int IllustratedRewardText = 5;

			// Token: 0x04037017 RID: 225303
			public const int TimeLimitRewardBtn = 6;

			// Token: 0x04037018 RID: 225304
			public const int TimeLimitRewardText = 7;

			// Token: 0x04037019 RID: 225305
			public const int IllustratedBtn = 8;

			// Token: 0x0403701A RID: 225306
			public const int IllustratedText = 9;

			// Token: 0x0403701B RID: 225307
			public const int CabinBtn = 10;

			// Token: 0x0403701C RID: 225308
			public const int CabinText = 11;

			// Token: 0x0403701D RID: 225309
			public const int TechnologyBtn = 12;

			// Token: 0x0403701E RID: 225310
			public const int TechnologyText = 13;

			// Token: 0x0403701F RID: 225311
			public const int TransactionBtn = 14;

			// Token: 0x04037020 RID: 225312
			public const int SailingBtn = 15;

			// Token: 0x04037021 RID: 225313
			public const int RoleTalkText = 16;

			// Token: 0x04037022 RID: 225314
			public const int TechRedDotItem = 17;

			// Token: 0x04037023 RID: 225315
			public const int ShopRedDotItem = 18;
		}
	}
}
