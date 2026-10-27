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
	// Token: 0x02005651 RID: 22097
	public class ForgingIngredientsView : UiPanelBase
	{
		// Token: 0x060382E1 RID: 230113 RVA: 0x00D4F458 File Offset: 0x00D4D658
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

		// Token: 0x060382E2 RID: 230114 RVA: 0x00D4F5C4 File Offset: 0x00D4D7C4
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.CloseHelpRole, new Action(this.RefreshHelpRole));
			EventSystem.Instance.Add(EEventName.ForgingSuccess, new Action(this.RefreshCurrentView));
			EventSystem.Instance.Add(EEventName.ForgingFail, new Action(this.RefreshCurrentView));
		}

		// Token: 0x060382E3 RID: 230115 RVA: 0x00D4F628 File Offset: 0x00D4D828
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.CloseHelpRole, new Action(this.RefreshHelpRole));
			EventSystem.Instance.Remove(EEventName.ForgingSuccess, new Action(this.RefreshCurrentView));
			EventSystem.Instance.Remove(EEventName.ForgingFail, new Action(this.RefreshCurrentView));
		}

		// Token: 0x060382E4 RID: 230116 RVA: 0x00D4F689 File Offset: 0x00D4D889
		private void RefreshCurrentView()
		{
			this.RefreshTips(this.ForgingItemData);
		}

		// Token: 0x060382E5 RID: 230117 RVA: 0x00D4F697 File Offset: 0x00D4D897
		private void RefreshHelpRole()
		{
			this.VerticalTextView.RefreshHelpRole();
		}

		// Token: 0x060382E6 RID: 230118 RVA: 0x00D4F6A4 File Offset: 0x00D4D8A4
		protected override UniTask OnBeforeStartAsync()
		{
			ForgingIngredientsView.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ForgingIngredientsView.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060382E7 RID: 230119 RVA: 0x00D4F6E7 File Offset: 0x00D4D8E7
		protected override void OnStart()
		{
			this.AddEventListener();
			this.VerticalTextView.BindChangeClickCall(new Action(this.OnClickChangeRole));
			base.GetButton(3).SetCanClickWhenDisable(true);
		}

		// Token: 0x060382E8 RID: 230120 RVA: 0x00D4F713 File Offset: 0x00D4D913
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
			this.VerticalTextView.Destroy(null);
		}

		// Token: 0x060382E9 RID: 230121 RVA: 0x00D4F728 File Offset: 0x00D4D928
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

		// Token: 0x060382EA RID: 230122 RVA: 0x00D4F7B0 File Offset: 0x00D4D9B0
		private void OnClickChangeRole()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenHelpRole, this.ForgingItemData.ItemId);
		}

		// Token: 0x060382EB RID: 230123 RVA: 0x00D4F7CD File Offset: 0x00D4D9CD
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

		// Token: 0x060382EC RID: 230124 RVA: 0x00D4F7E8 File Offset: 0x00D4D9E8
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

		// Token: 0x060382ED RID: 230125 RVA: 0x00D4F8AC File Offset: 0x00D4DAAC
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

		// Token: 0x060382EE RID: 230126 RVA: 0x00D4F9A4 File Offset: 0x00D4DBA4
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

		// Token: 0x0401D8D6 RID: 121046
		[Nullable(2)]
		private IWeaponForgingData ForgingItemData;

		// Token: 0x0401D8D7 RID: 121047
		[Nullable(2)]
		private ForgingIngredientsVerticalView VerticalTextView;

		// Token: 0x0200B809 RID: 47113
		public class EForgingIngredientsDefine
		{
			// Token: 0x04037ADB RID: 228059
			public const int TxtName = 0;

			// Token: 0x04037ADC RID: 228060
			public const int TxtHaveNum = 1;

			// Token: 0x04037ADD RID: 228061
			public const int PanelBuy = 2;

			// Token: 0x04037ADE RID: 228062
			public const int BtnConfirm = 3;

			// Token: 0x04037ADF RID: 228063
			public const int PanelVertical = 4;

			// Token: 0x04037AE0 RID: 228064
			public const int TxtConfirm = 5;

			// Token: 0x04037AE1 RID: 228065
			public const int PnlActivate = 6;

			// Token: 0x04037AE2 RID: 228066
			public const int TxtActivate = 7;
		}
	}
}
