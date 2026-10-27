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
	// Token: 0x0200660C RID: 26124
	[NullableContext(2)]
	[Nullable(0)]
	public class FishingDockView : UiViewBase
	{
		// Token: 0x06041779 RID: 268153 RVA: 0x00FDAB55 File Offset: 0x00FD8D55
		[NullableContext(1)]
		public FishingDockView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0604177A RID: 268154 RVA: 0x00FDAB60 File Offset: 0x00FD8D60
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

		// Token: 0x0604177B RID: 268155 RVA: 0x00FDAED2 File Offset: 0x00FD90D2
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.FishingRefreshBackpackData, new Action(this.FishingRefreshBackpackData));
		}

		// Token: 0x0604177C RID: 268156 RVA: 0x00FDAEF0 File Offset: 0x00FD90F0
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.FishingRefreshBackpackData, new Action(this.FishingRefreshBackpackData));
		}

		// Token: 0x0604177D RID: 268157 RVA: 0x00FDAF10 File Offset: 0x00FD9110
		protected override UniTask OnBeforeStartAsync()
		{
			FishingDockView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<FishingDockView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0604177E RID: 268158 RVA: 0x00FDAF54 File Offset: 0x00FD9154
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

		// Token: 0x0604177F RID: 268159 RVA: 0x00FDAFAC File Offset: 0x00FD91AC
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

		// Token: 0x06041780 RID: 268160 RVA: 0x00FDAFE1 File Offset: 0x00FD91E1
		protected override void OnBeforeDestroy()
		{
			FishingModel.Instance.DockId = 0;
			RedDotController.Instance.UnBindGivenUi(ERedDotName.FishingTech, base.GetItem(17), 0);
			FishingController.Instance.ShowEffectInWorld();
		}

		// Token: 0x06041781 RID: 268161 RVA: 0x00FDB010 File Offset: 0x00FD9210
		private void RefreshShopRedDot()
		{
			int shopId = DockyardModel.Instance.ShopId;
			bool uiactive = PayShopModel.Instance.CheckShopItemCheckFlag((PayShopDefine.EPayShopTabType)shopId, 1);
			base.GetItem(18).SetUIActive(uiactive);
		}

		// Token: 0x06041782 RID: 268162 RVA: 0x00FDB044 File Offset: 0x00FD9244
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

		// Token: 0x06041783 RID: 268163 RVA: 0x00FDB230 File Offset: 0x00FD9430
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

		// Token: 0x06041784 RID: 268164 RVA: 0x00FDB281 File Offset: 0x00FD9481
		private void OnClickSailingBtn()
		{
			UiManager.Instance.OpenView(EUiViewName.SailingView, null, null);
		}

		// Token: 0x06041785 RID: 268165 RVA: 0x00FDB294 File Offset: 0x00FD9494
		private void OnClickIllustratedBtn()
		{
			FishingController.Instance.OpenFishingHandBookView();
		}

		// Token: 0x06041786 RID: 268166 RVA: 0x00FDB2A0 File Offset: 0x00FD94A0
		private void OnClickCabinBtn()
		{
			FishingController.Instance.OpenDockyardView();
		}

		// Token: 0x06041787 RID: 268167 RVA: 0x00FDB2AC File Offset: 0x00FD94AC
		private void OnClickTechnologyBtn()
		{
			FishingController.Instance.OpenFishingTechRootView();
		}

		// Token: 0x06041788 RID: 268168 RVA: 0x00FDB2B8 File Offset: 0x00FD94B8
		private void OnClickTransactionBtn()
		{
			FishingController.Instance.OpenDockyardShopView(null);
		}

		// Token: 0x06041789 RID: 268169 RVA: 0x00FDB2D8 File Offset: 0x00FD94D8
		private void RefreshTechRedDot()
		{
			FishingModel.Instance.RefreshTechCanLevelUp();
		}

		// Token: 0x0604178A RID: 268170 RVA: 0x00FDB2E4 File Offset: 0x00FD94E4
		private void FishingRefreshBackpackData()
		{
			this.RefreshCabinText();
		}

		// Token: 0x0604178B RID: 268171 RVA: 0x00FDB2EC File Offset: 0x00FD94EC
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

		// Token: 0x04022130 RID: 139568
		private PopupCaptionItem CaptionItem;

		// Token: 0x04022131 RID: 139569
		private FishingDockQuestItem FishingDockQuestItem;

		// Token: 0x04022132 RID: 139570
		private FishingDockReputationItem FishingDockReputationItem;

		// Token: 0x04022133 RID: 139571
		private FishingRewardLimitTimeButton LimitTimeRewardItem;

		// Token: 0x04022134 RID: 139572
		private FishingPermanentRewardButton PermanentRewardItem;

		// Token: 0x04022135 RID: 139573
		private LevelSequencePlayer RoleTalkLevelSequencePlayer;

		// Token: 0x04022136 RID: 139574
		private FishingCurrencyItem FishingCurrencyItem;

		// Token: 0x0200C817 RID: 51223
		[NullableContext(0)]
		private class EComponentDefine
		{
			// Token: 0x0403C6C9 RID: 247497
			public const int CaptionItem = 0;

			// Token: 0x0403C6CA RID: 247498
			public const int ExpItem = 1;

			// Token: 0x0403C6CB RID: 247499
			public const int QuestItem = 2;

			// Token: 0x0403C6CC RID: 247500
			public const int RoleTalkItem = 3;

			// Token: 0x0403C6CD RID: 247501
			public const int IllustratedRewardBtn = 4;

			// Token: 0x0403C6CE RID: 247502
			public const int IllustratedRewardText = 5;

			// Token: 0x0403C6CF RID: 247503
			public const int TimeLimitRewardBtn = 6;

			// Token: 0x0403C6D0 RID: 247504
			public const int TimeLimitRewardText = 7;

			// Token: 0x0403C6D1 RID: 247505
			public const int IllustratedBtn = 8;

			// Token: 0x0403C6D2 RID: 247506
			public const int IllustratedText = 9;

			// Token: 0x0403C6D3 RID: 247507
			public const int CabinBtn = 10;

			// Token: 0x0403C6D4 RID: 247508
			public const int CabinText = 11;

			// Token: 0x0403C6D5 RID: 247509
			public const int TechnologyBtn = 12;

			// Token: 0x0403C6D6 RID: 247510
			public const int TechnologyText = 13;

			// Token: 0x0403C6D7 RID: 247511
			public const int TransactionBtn = 14;

			// Token: 0x0403C6D8 RID: 247512
			public const int SailingBtn = 15;

			// Token: 0x0403C6D9 RID: 247513
			public const int RoleTalkText = 16;

			// Token: 0x0403C6DA RID: 247514
			public const int TechRedDotItem = 17;

			// Token: 0x0403C6DB RID: 247515
			public const int ShopRedDotItem = 18;
		}
	}
}
