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
	// Token: 0x02005673 RID: 22131
	public class ComposeIngredientsView : UiPanelBase
	{
		// Token: 0x060384F3 RID: 230643 RVA: 0x00D5B568 File Offset: 0x00D59768
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

		// Token: 0x060384F4 RID: 230644 RVA: 0x00D5B6D4 File Offset: 0x00D598D4
		protected override UniTask OnBeforeStartAsync()
		{
			ComposeIngredientsView.<OnBeforeStartAsync>d__4 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<ComposeIngredientsView.<OnBeforeStartAsync>d__4>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060384F5 RID: 230645 RVA: 0x00D5B718 File Offset: 0x00D59918
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

		// Token: 0x060384F6 RID: 230646 RVA: 0x00D5B780 File Offset: 0x00D59980
		protected override void OnStart()
		{
			this.VerticalTextView.BindChangeClickCall(new Action(this.OnClickChangeRole));
			this.AddEventListener();
			LguiUtil.Instance.SetLocalText(base.GetText(5), "ComposeButtonText", Array.Empty<object>());
			base.GetButton(3).SetCanClickWhenDisable(true);
		}

		// Token: 0x060384F7 RID: 230647 RVA: 0x00D5B7D2 File Offset: 0x00D599D2
		private void OnClickChangeRole()
		{
			EventSystem.Instance.Emit<int>(EEventName.OpenHelpRole, this.ComposeItemData.ConfigId);
		}

		// Token: 0x060384F8 RID: 230648 RVA: 0x00D5B7EF File Offset: 0x00D599EF
		protected override void OnBeforeDestroy()
		{
			this.RemoveEventListener();
		}

		// Token: 0x060384F9 RID: 230649 RVA: 0x00D5B7F8 File Offset: 0x00D599F8
		private void AddEventListener()
		{
			EventSystem.Instance.Add(EEventName.CloseHelpRole, new Action(this.RefreshProficiencyAndHelpRoleWithCurrent));
			EventSystem.Instance.Add(EEventName.UpgradeComposeLevel, new Action(this.RefreshProficiencyAndHelpRoleWithCurrent));
			EventSystem.Instance.Add(EEventName.ComposeSuccess, new Action(this.RefreshCurrentView));
			EventSystem.Instance.Add(EEventName.ComposeFail, new Action(this.RefreshCurrentView));
		}

		// Token: 0x060384FA RID: 230650 RVA: 0x00D5B878 File Offset: 0x00D59A78
		private void RemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.CloseHelpRole, new Action(this.RefreshProficiencyAndHelpRoleWithCurrent));
			EventSystem.Instance.Remove(EEventName.UpgradeComposeLevel, new Action(this.RefreshProficiencyAndHelpRoleWithCurrent));
			EventSystem.Instance.Remove(EEventName.ComposeSuccess, new Action(this.RefreshCurrentView));
			EventSystem.Instance.Remove(EEventName.ComposeFail, new Action(this.RefreshCurrentView));
		}

		// Token: 0x060384FB RID: 230651 RVA: 0x00D5B8F5 File Offset: 0x00D59AF5
		private void RefreshProficiencyAndHelpRoleWithCurrent()
		{
			if (this.ComposeItemData.MainType == EComposeListType.ReagentProduction)
			{
				this.VerticalTextView.RefreshProficiencyAndHelpRole((IReagentProductionData)this.ComposeItemData);
				return;
			}
			this.VerticalTextView.RefreshHelpRole();
		}

		// Token: 0x060384FC RID: 230652 RVA: 0x00D5B927 File Offset: 0x00D59B27
		private void RefreshCurrentView()
		{
			this.RefreshTips(this.ComposeItemData);
		}

		// Token: 0x060384FD RID: 230653 RVA: 0x00D5B935 File Offset: 0x00D59B35
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

		// Token: 0x060384FE RID: 230654 RVA: 0x00D5B950 File Offset: 0x00D59B50
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

		// Token: 0x060384FF RID: 230655 RVA: 0x00D5BA18 File Offset: 0x00D59C18
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

		// Token: 0x06038500 RID: 230656 RVA: 0x00D5BABC File Offset: 0x00D59CBC
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

		// Token: 0x06038501 RID: 230657 RVA: 0x00D5BB67 File Offset: 0x00D59D67
		private void RefreshReagentProduction()
		{
			this.VerticalTextView.RefreshReagentProduction((IReagentProductionData)this.ComposeItemData);
		}

		// Token: 0x06038502 RID: 230658 RVA: 0x00D5BB7F File Offset: 0x00D59D7F
		private void RefreshStructure()
		{
			this.VerticalTextView.RefreshStructure((IStructureData)this.ComposeItemData);
		}

		// Token: 0x06038503 RID: 230659 RVA: 0x00D5BB97 File Offset: 0x00D59D97
		private void RefreshPurification()
		{
			this.VerticalTextView.RefreshPurification((IPurificationData)this.ComposeItemData);
		}

		// Token: 0x0401D99B RID: 121243
		[Nullable(2)]
		private IBaseItemData ComposeItemData;

		// Token: 0x0401D99C RID: 121244
		[Nullable(2)]
		private ComposeIngredientsVerticalView VerticalTextView;

		// Token: 0x0200B835 RID: 47157
		private class EComposeIngredientsDefine
		{
			// Token: 0x04037C05 RID: 228357
			public const int TxtName = 0;

			// Token: 0x04037C06 RID: 228358
			public const int TxtHaveNum = 1;

			// Token: 0x04037C07 RID: 228359
			public const int PanelBuy = 2;

			// Token: 0x04037C08 RID: 228360
			public const int BtnConfirm = 3;

			// Token: 0x04037C09 RID: 228361
			public const int PanelVertical = 4;

			// Token: 0x04037C0A RID: 228362
			public const int TxtConfirm = 5;

			// Token: 0x04037C0B RID: 228363
			public const int PnlActivate = 6;

			// Token: 0x04037C0C RID: 228364
			public const int TxtActivate = 7;
		}
	}
}
