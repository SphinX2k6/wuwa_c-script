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

namespace CSharpScript.Game.Module.Manufacture.Compose.View
{
	// Token: 0x02004649 RID: 17993
	public class ComposeIngredientsView : UiPanelBase
	{
		// Token: 0x0602D3F0 RID: 185328 RVA: 0x00CA9668 File Offset: 0x00CA7868
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

		// Token: 0x0602D3F1 RID: 185329 RVA: 0x00CA97D4 File Offset: 0x00CA79D4
		protected override UniTask OnBeforeStartAsync()
		{
			ComposeIngredientsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposeIngredientsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0602D3F2 RID: 185330 RVA: 0x00CA9818 File Offset: 0x00CA7A18
		private void OnClickConfirmButton()
		{
			if (base.GetButton(3).IsSelfInteractive)
			{
				CommonManager.Instance.SendManufacture(this.ComposeItemData.ConfigId, this.VerticalTextView.GetManufactureCount());
				return;
			}
			ComposeController.Instance.PlayCompositeFailDisplay(delegate
			{
				ComposeController.Instance.PlayCompositeLoopDisplay();
			});
		}

		// Token: 0x0602D3F3 RID: 185331 RVA: 0x00CA9880 File Offset: 0x00CA7A80
		protected override void OnStart()
		{
			this.VerticalTextView.BindChangeClickCall(new Action(this.OnClickChangeRole));
			this.AddEventListener();
			LguiUtil.Instance.SetLocalText(base.GetText(5), "ComposeButtonText", Array.Empty<object>());
			base.GetButton(3).SetCanClickWhenDisable(true);
		}

		// Token: 0x0602D3F4 RID: 185332 RVA: 0x00CA98D2 File Offset: 0x00CA7AD2
		private void OnClickChangeRole()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenHelpRole, this.ComposeItemData.ConfigId);
		}

		// Token: 0x0602D3F5 RID: 185333 RVA: 0x00CA98EF File Offset: 0x00CA7AEF
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x0602D3F6 RID: 185334 RVA: 0x00CA98F8 File Offset: 0x00CA7AF8
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.CloseHelpRole, new Action(this.RefreshProficiencyAndHelpRoleWithCurrent));
			EventSystem.Instance.Add(EEventName.UpgradeComposeLevel, new Action(this.RefreshProficiencyAndHelpRoleWithCurrent));
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(this.RefreshCurrentView));
			EventSystem.Instance.Add(EEventName.ComposeFail, new Action(this.RefreshCurrentView));
		}

		// Token: 0x0602D3F7 RID: 185335 RVA: 0x00CA9978 File Offset: 0x00CA7B78
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.CloseHelpRole, new Action(this.RefreshProficiencyAndHelpRoleWithCurrent));
			EventSystem.Instance.Remove(EEventName.UpgradeComposeLevel, new Action(this.RefreshProficiencyAndHelpRoleWithCurrent));
			EventSystem.Instance.Remove(EEventName.ComposeSuccess, new Action(this.RefreshCurrentView));
			EventSystem.Instance.Remove(EEventName.ComposeFail, new Action(this.RefreshCurrentView));
		}

		// Token: 0x0602D3F8 RID: 185336 RVA: 0x00CA99F5 File Offset: 0x00CA7BF5
		private void RefreshProficiencyAndHelpRoleWithCurrent()
		{
			if (this.ComposeItemData.MainType == EComposeListType.ReagentProduction)
			{
				this.VerticalTextView.RefreshProficiencyAndHelpRole((IReagentProductionData)this.ComposeItemData);
				return;
			}
			this.VerticalTextView.RefreshHelpRole();
		}

		// Token: 0x0602D3F9 RID: 185337 RVA: 0x00CA9A27 File Offset: 0x00CA7C27
		private void RefreshCurrentView()
		{
			this.RefreshTips(this.ComposeItemData);
		}

		// Token: 0x0602D3FA RID: 185338 RVA: 0x00CA9A35 File Offset: 0x00CA7C35
		public void OnSecondTimerRefresh()
		{
			if (this.ComposeItemData == null)
			{
				return;
			}
			ComposeIngredientsVerticalView verticalTextView = this.VerticalTextView;
			if (verticalTextView == null)
			{
				return;
			}
			verticalTextView.OnSecondTimerRefresh();
		}

		// Token: 0x0602D3FB RID: 185339 RVA: 0x00CA9A50 File Offset: 0x00CA7C50
		[NullableContext(1)]
		public void RefreshTips(IBaseItemData data)
		{
			this.ComposeItemData = data;
			SynthesisFormula? synthesisFormulaById = ComposeConfig.Instance.GetSynthesisFormulaById(data.ConfigId);
			string itemName = ItemConfig.Instance.GetItemName(synthesisFormulaById.Value.ItemId);
			base.GetText(0).SetText(itemName, true);
			int commonItemCount = InventoryModel.Instance.GetCommonItemCount(synthesisFormulaById.Value.ItemId, 0);
			LguiUtil.Instance.SetLocalText(base.GetText(1), "Have", new <>z__ReadOnlySingleElementList<object>(commonItemCount));
			this.CheckCanInteractConfirm();
			switch (this.ComposeItemData.MainType)
			{
			case EComposeListType.ReagentProduction:
				this.RefreshReagentProduction();
				return;
			case EComposeListType.Structure:
				this.RefreshStructure();
				return;
			case EComposeListType.Purification:
				this.RefreshPurification();
				return;
			default:
				return;
			}
		}

		// Token: 0x0602D3FC RID: 185340 RVA: 0x00CA9B18 File Offset: 0x00CA7D18
		private void CheckCanInteractConfirm()
		{
			ComposeModel instance = ComposeModel.Instance;
			bool flag = instance.CheckComposeMaterialEnough(this.ComposeItemData.ConfigId);
			bool flag2 = instance.CheckUnlock(this.ComposeItemData);
			bool isCoinEnough = instance.CheckCoinEnough(this.ComposeItemData.ConfigId);
			bool flag3 = instance.CheckLimitCount(this.ComposeItemData);
			base.GetText(7).SetText(this.GetDisableText(flag2, flag, isCoinEnough, flag3), true);
			base.GetItem(6).SetUIActive(!flag2 || !flag || !flag3);
			base.GetButton(3).RootUIComp.Get().SetUIActive(flag2 && flag && flag3);
		}

		// Token: 0x0602D3FD RID: 185341 RVA: 0x00CA9BBC File Offset: 0x00CA7DBC
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
						ItemConfig.Instance.GetItemName(ComposeController.Instance.ComposeCoinId)
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
				string refreshLimitTime = ComposeModel.Instance.GetRefreshLimitTime();
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

		// Token: 0x0602D3FE RID: 185342 RVA: 0x00CA9C67 File Offset: 0x00CA7E67
		private void RefreshReagentProduction()
		{
			this.VerticalTextView.RefreshReagentProduction((IReagentProductionData)this.ComposeItemData);
		}

		// Token: 0x0602D3FF RID: 185343 RVA: 0x00CA9C7F File Offset: 0x00CA7E7F
		private void RefreshStructure()
		{
			this.VerticalTextView.RefreshStructure((IStructureData)this.ComposeItemData);
		}

		// Token: 0x0602D400 RID: 185344 RVA: 0x00CA9C97 File Offset: 0x00CA7E97
		private void RefreshPurification()
		{
			this.VerticalTextView.RefreshPurification((IPurificationData)this.ComposeItemData);
		}

		// Token: 0x04018426 RID: 99366
		[Nullable(2)]
		private IBaseItemData ComposeItemData;

		// Token: 0x04018427 RID: 99367
		[Nullable(2)]
		private ComposeIngredientsVerticalView VerticalTextView;

		// Token: 0x0200A25D RID: 41565
		private class EComposeIngredientsDefine
		{
			// Token: 0x04032623 RID: 206371
			public const int TxtName = 0;

			// Token: 0x04032624 RID: 206372
			public const int TxtHaveNum = 1;

			// Token: 0x04032625 RID: 206373
			public const int PanelBuy = 2;

			// Token: 0x04032626 RID: 206374
			public const int BtnConfirm = 3;

			// Token: 0x04032627 RID: 206375
			public const int PanelVertical = 4;

			// Token: 0x04032628 RID: 206376
			public const int TxtConfirm = 5;

			// Token: 0x04032629 RID: 206377
			public const int PnlActivate = 6;

			// Token: 0x0403262A RID: 206378
			public const int TxtActivate = 7;
		}
	}
}
