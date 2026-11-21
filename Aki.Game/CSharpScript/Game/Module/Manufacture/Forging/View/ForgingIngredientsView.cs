using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Aki.Config;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Item;
using CSharpScript.Game.Module.Manufacture.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Forging.View
{
	// Token: 0x02004627 RID: 17959
	public class ForgingIngredientsView : UiPanelBase
	{
		// Token: 0x0602D1DF RID: 184799 RVA: 0x00C9D1E4 File Offset: 0x00C9B3E4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickConfirmButton));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0602D1E0 RID: 184800 RVA: 0x00C9D350 File Offset: 0x00C9B550
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.CloseHelpRole, new Action(this.RefreshHelpRole));
			EventSystem.Instance.Add(EEventName.ForgingSuccess, new Action(this.RefreshCurrentView));
			EventSystem.Instance.Add(EEventName.ForgingFail, new Action(this.RefreshCurrentView));
		}

		// Token: 0x0602D1E1 RID: 184801 RVA: 0x00C9D3B4 File Offset: 0x00C9B5B4
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.CloseHelpRole, new Action(this.RefreshHelpRole));
			EventSystem.Instance.Remove(EEventName.ForgingSuccess, new Action(this.RefreshCurrentView));
			EventSystem.Instance.Remove(EEventName.ForgingFail, new Action(this.RefreshCurrentView));
		}

		// Token: 0x0602D1E2 RID: 184802 RVA: 0x00C9D415 File Offset: 0x00C9B615
		private void RefreshCurrentView()
		{
			this.RefreshTips(this.ForgingItemData);
		}

		// Token: 0x0602D1E3 RID: 184803 RVA: 0x00C9D423 File Offset: 0x00C9B623
		private void RefreshHelpRole()
		{
			this.VerticalTextView.RefreshHelpRole();
		}

		// Token: 0x0602D1E4 RID: 184804 RVA: 0x00C9D430 File Offset: 0x00C9B630
		protected override UniTask OnBeforeStartAsync()
		{
			ForgingIngredientsView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ForgingIngredientsView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D1E5 RID: 184805 RVA: 0x00C9D473 File Offset: 0x00C9B673
		protected override void OnStart()
		{
			this.AddEventListener();
			this.VerticalTextView.BindChangeClickCall(new Action(this.OnClickChangeRole));
			base.GetButton(3).SetCanClickWhenDisable(true);
		}

		// Token: 0x0602D1E6 RID: 184806 RVA: 0x00C9D49F File Offset: 0x00C9B69F
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
			this.VerticalTextView.Destroy(null);
		}

		// Token: 0x0602D1E7 RID: 184807 RVA: 0x00C9D4B4 File Offset: 0x00C9B6B4
		private void OnClickConfirmButton()
		{
			if (!base.GetButton(3).IsSelfInteractive)
			{
				ForgingController.Instance.PlayForgingFailDisplay(delegate
				{
					ForgingController.Instance.PlayForgingLoopDisplay();
				});
				return;
			}
			if (this.ForgingItemData.IsUnlock == 0)
			{
				ForgingController.Instance.SendForgeFormulaUnlockRequest(this.ForgingItemData.ItemId);
				return;
			}
			CommonManager.Instance.SendManufacture(this.ForgingItemData.ItemId, this.VerticalTextView.GetManufactureCount());
		}

		// Token: 0x0602D1E8 RID: 184808 RVA: 0x00C9D53C File Offset: 0x00C9B73C
		private void OnClickChangeRole()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenHelpRole, this.ForgingItemData.ItemId);
		}

		// Token: 0x0602D1E9 RID: 184809 RVA: 0x00C9D559 File Offset: 0x00C9B759
		public void OnSecondTimerRefresh()
		{
			if (this.ForgingItemData == null)
			{
				return;
			}
			ForgingIngredientsVerticalView verticalTextView = this.VerticalTextView;
			if (verticalTextView == null)
			{
				return;
			}
			verticalTextView.OnSecondTimerRefresh();
		}

		// Token: 0x0602D1EA RID: 184810 RVA: 0x00C9D574 File Offset: 0x00C9B774
		[NullableContext(1)]
		public void RefreshTips(IWeaponForgingData data)
		{
			this.ForgingItemData = data;
			ForgeFormula? forgeFormulaById = ForgingConfig.Instance.GetForgeFormulaById(data.ItemId);
			WeaponConf? weaponConfigByItemId = WeaponConfig.Instance.GetWeaponConfigByItemId(forgeFormulaById.Value.ItemId);
			base.GetText(0).ShowTextNew(((weaponConfigByItemId != null) ? weaponConfigByItemId.GetValueOrDefault().WeaponName : null) ?? "");
			int itemCountByConfigId = InventoryModel.Instance.GetItemCountByConfigId(forgeFormulaById.Value.ItemId, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(1), "Have", new <>z__ReadOnlySingleElementList<object>(itemCountByConfigId));
			this.VerticalTextView.RefreshForging(this.ForgingItemData);
			this.CheckCanInteractConfirm();
		}

		// Token: 0x0602D1EB RID: 184811 RVA: 0x00C9D638 File Offset: 0x00C9B838
		private void CheckCanInteractConfirm()
		{
			bool flag = true;
			ForgingModel instance = ForgingModel.Instance;
			bool flag2 = instance.CheckUnlock(this.ForgingItemData);
			bool isCoinEnough = instance.CheckCoinEnough(this.ForgingItemData.ItemId);
			bool flag3 = instance.CheckLimitCount(this.ForgingItemData);
			string textById;
			if (flag2)
			{
				textById = TextConfig.Instance.GetTextById("WeaponMaking");
				flag = instance.CheckMaterialEnough(this.ForgingItemData.ItemId);
				base.GetItem(2).SetUIActive(true);
			}
			else
			{
				textById = TextConfig.Instance.GetTextById("UnlockWeapon");
				base.GetItem(2).SetUIActive(false);
			}
			base.GetText(5).SetText(textById, true);
			base.GetText(7).SetText(this.GetDisableText(flag2, flag, isCoinEnough, flag3), true);
			base.GetItem(6).SetUIActive(!flag2 || !flag || !flag3);
			base.GetButton(3).RootUIComp.Get().SetUIActive(flag2 && flag && flag3);
		}

		// Token: 0x0602D1EC RID: 184812 RVA: 0x00C9D730 File Offset: 0x00C9B930
		[NullableContext(1)]
		private string GetDisableText(bool isUnlock, bool isMatEnough, bool isCoinEnough, bool isMakeCountEnough)
		{
			if (!isUnlock)
			{
				return ConfigMultiTextLang.GetLocalTextNew("GenericPrompt_Unlocked_TipsText", null);
			}
			if (!isMatEnough)
			{
				string localTextNew = ConfigMultiTextLang.GetLocalTextNew("LackMakeMaterial", null);
				if (!isCoinEnough)
				{
					return StringUtils.Format(localTextNew, new string[]
					{
						ItemConfig.Instance.GetItemName(ForgingController.Instance.ForgingCostId)
					});
				}
				return StringUtils.Format(localTextNew, new string[]
				{
					ConfigMultiTextLang.GetLocalTextNew("Material_Text", null)
				});
			}
			else
			{
				if (isMakeCountEnough)
				{
					return "";
				}
				string refreshLimitTime = ForgingModel.Instance.GetRefreshLimitTime();
				if (refreshLimitTime != null)
				{
					return StringUtils.Format(ConfigMultiTextLang.GetLocalTextNew("LackMakeCount", null), new string[]
					{
						refreshLimitTime
					});
				}
				return ConfigMultiTextLang.GetLocalTextNew("LackMakeCountWithoutTime", null);
			}
		}

		// Token: 0x04018361 RID: 99169
		[Nullable(2)]
		private IWeaponForgingData ForgingItemData;

		// Token: 0x04018362 RID: 99170
		[Nullable(2)]
		private ForgingIngredientsVerticalView VerticalTextView;

		// Token: 0x0200A233 RID: 41523
		public class EForgingIngredientsDefine
		{
			// Token: 0x04032503 RID: 206083
			public const int TxtName = 0;

			// Token: 0x04032504 RID: 206084
			public const int TxtHaveNum = 1;

			// Token: 0x04032505 RID: 206085
			public const int PanelBuy = 2;

			// Token: 0x04032506 RID: 206086
			public const int BtnConfirm = 3;

			// Token: 0x04032507 RID: 206087
			public const int PanelVertical = 4;

			// Token: 0x04032508 RID: 206088
			public const int TxtConfirm = 5;

			// Token: 0x04032509 RID: 206089
			public const int PnlActivate = 6;

			// Token: 0x0403250A RID: 206090
			public const int TxtActivate = 7;
		}
	}
}
