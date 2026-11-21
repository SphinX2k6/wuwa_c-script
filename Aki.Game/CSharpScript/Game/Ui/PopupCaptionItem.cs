using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Module.UiComponent.UiHomeButton;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200357F RID: 13695
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupCaptionItem : UiPanelBase
	{
		// Token: 0x06022E97 RID: 142999 RVA: 0x009E9289 File Offset: 0x009E7489
		[NullableContext(2)]
		public PopupCaptionItem(UUIItem item = null)
		{
			if (item == null)
			{
				return;
			}
			base.CreateThenShowByActor(item.GetOwner(), null);
		}

		// Token: 0x06022E98 RID: 143000 RVA: 0x009E92A4 File Offset: 0x009E74A4
		protected unsafe override void OnRegisterComponent()
		{
			int num = 8;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUISprite));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 2;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnClickCloseBtn));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnClickHelpBtn));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06022E99 RID: 143001 RVA: 0x009E9433 File Offset: 0x009E7633
		protected override void OnStart()
		{
			this.CurrencyItemListComponent = new CommonCurrencyItemListComponent(base.GetItem(4));
		}

		// Token: 0x06022E9A RID: 143002 RVA: 0x009E9447 File Offset: 0x009E7647
		private void OnClickCloseBtn()
		{
			if (this.OnClickCloseBtnCall != null)
			{
				this.OnClickCloseBtnCall();
			}
		}

		// Token: 0x06022E9B RID: 143003 RVA: 0x009E945C File Offset: 0x009E765C
		private void OnClickHelpBtn()
		{
			if (this.OnClickHelpBtnCall != null)
			{
				this.OnClickHelpBtnCall();
			}
		}

		// Token: 0x06022E9C RID: 143004 RVA: 0x009E9474 File Offset: 0x009E7674
		public void SetCloseBtnActive(bool state)
		{
			UUIItem uuiitem = base.GetButton(3).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(state);
			}
			this.SetHomeBtnShowState(state);
		}

		// Token: 0x06022E9D RID: 143005 RVA: 0x009E94A8 File Offset: 0x009E76A8
		public void SetHelpBtnActive(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x06022E9E RID: 143006 RVA: 0x009E94D4 File Offset: 0x009E76D4
		public void SetCloseCallBack(Action call)
		{
			this.OnClickCloseBtnCall = call;
		}

		// Token: 0x06022E9F RID: 143007 RVA: 0x009E94DD File Offset: 0x009E76DD
		public void SetHelpCallBack(Action call)
		{
			this.OnClickHelpBtnCall = call;
		}

		// Token: 0x06022EA0 RID: 143008 RVA: 0x009E94E8 File Offset: 0x009E76E8
		public void SetCloseBtnRaycast(bool state)
		{
			UUIItem uuiitem = base.GetButton(3).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetRaycastTarget(state);
		}

		// Token: 0x06022EA1 RID: 143009 RVA: 0x009E9514 File Offset: 0x009E7714
		public void SetCloseBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(3).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(state);
			}
			this.SetHomeBtnShowState(state);
		}

		// Token: 0x06022EA2 RID: 143010 RVA: 0x009E9548 File Offset: 0x009E7748
		public void SetHomeBtnShowState(bool state)
		{
			base.GetItem(6).SetUIActive(state);
		}

		// Token: 0x06022EA3 RID: 143011 RVA: 0x009E9557 File Offset: 0x009E7757
		public void SetTitle(string title)
		{
			base.GetText(1).SetText(title, true);
		}

		// Token: 0x06022EA4 RID: 143012 RVA: 0x009E9567 File Offset: 0x009E7767
		public void SetTitleByTextIdAndArg(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
		}

		// Token: 0x06022EA5 RID: 143013 RVA: 0x009E957C File Offset: 0x009E777C
		public void SetTitleByTextIdAndArgNew(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x06022EA6 RID: 143014 RVA: 0x009E9591 File Offset: 0x009E7791
		public void SetTitleByTitleData(CommonTabTitleData titleData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), titleData.TextId, titleData.Args);
		}

		// Token: 0x06022EA7 RID: 143015 RVA: 0x009E95B0 File Offset: 0x009E77B0
		public void SetTitleLocalText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x06022EA8 RID: 143016 RVA: 0x009E95CC File Offset: 0x009E77CC
		public UniTask SetTitleIconByResourceId(string resourceId)
		{
			PopupCaptionItem.<SetTitleIconByResourceId>d__23 <SetTitleIconByResourceId>d__;
			<SetTitleIconByResourceId>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetTitleIconByResourceId>d__.<>4__this = this;
			<SetTitleIconByResourceId>d__.resourceId = resourceId;
			<SetTitleIconByResourceId>d__.<>1__state = -1;
			<SetTitleIconByResourceId>d__.<>t__builder.Start<PopupCaptionItem.<SetTitleIconByResourceId>d__23>(ref <SetTitleIconByResourceId>d__);
			return <SetTitleIconByResourceId>d__.<>t__builder.Task;
		}

		// Token: 0x06022EA9 RID: 143017 RVA: 0x009E9618 File Offset: 0x009E7818
		public void SetTitleIcon(string iconPath)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x06022EAA RID: 143018 RVA: 0x009E963E File Offset: 0x009E783E
		public void SetTitleTextActive(bool value)
		{
			base.GetText(1).SetUIActive(value);
		}

		// Token: 0x06022EAB RID: 143019 RVA: 0x009E964D File Offset: 0x009E784D
		public void SetTitleIconVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x06022EAC RID: 143020 RVA: 0x009E965C File Offset: 0x009E785C
		public void SetCurrencyItemVisible(bool bVisible)
		{
			base.GetItem(4).SetUIActive(bVisible);
		}

		// Token: 0x06022EAD RID: 143021 RVA: 0x009E966C File Offset: 0x009E786C
		public UniTask SetCurrencyItemList(int[] itemIdList)
		{
			PopupCaptionItem.<SetCurrencyItemList>d__28 <SetCurrencyItemList>d__;
			<SetCurrencyItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetCurrencyItemList>d__.<>4__this = this;
			<SetCurrencyItemList>d__.itemIdList = itemIdList;
			<SetCurrencyItemList>d__.<>1__state = -1;
			<SetCurrencyItemList>d__.<>t__builder.Start<PopupCaptionItem.<SetCurrencyItemList>d__28>(ref <SetCurrencyItemList>d__);
			return <SetCurrencyItemList>d__.<>t__builder.Task;
		}

		// Token: 0x06022EAE RID: 143022 RVA: 0x009E96B7 File Offset: 0x009E78B7
		public void SetCurrencyItemResourceId(string resourceId)
		{
			CommonCurrencyItemListComponent currencyItemListComponent = this.CurrencyItemListComponent;
			if (currencyItemListComponent == null)
			{
				return;
			}
			currencyItemListComponent.SetResourceId(resourceId);
		}

		// Token: 0x06022EAF RID: 143023 RVA: 0x009E96CA File Offset: 0x009E78CA
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<CommonCurrencyItem> GetCurrencyItemList()
		{
			CommonCurrencyItemListComponent currencyItemListComponent = this.CurrencyItemListComponent;
			if (currencyItemListComponent == null)
			{
				return null;
			}
			return currencyItemListComponent.GetCurrencyItemList();
		}

		// Token: 0x06022EB0 RID: 143024 RVA: 0x009E96E0 File Offset: 0x009E78E0
		public void SetCurrencyItemBtnFunction(int itemId, Action<int> callBack)
		{
			CommonCurrencyItemListComponent currencyItemListComponent = this.CurrencyItemListComponent;
			List<CommonCurrencyItem> list = (currencyItemListComponent != null) ? currencyItemListComponent.GetCurrencyItemList() : null;
			if (list != null)
			{
				foreach (CommonCurrencyItem commonCurrencyItem in list)
				{
					if (commonCurrencyItem.ItemId == itemId)
					{
						commonCurrencyItem.SetButtonFunction(callBack);
						break;
					}
				}
			}
		}

		// Token: 0x06022EB1 RID: 143025 RVA: 0x009E9750 File Offset: 0x009E7950
		public UniTask CreateToggleTab(Action<EToggleState> callback)
		{
			PopupCaptionItem.<CreateToggleTab>d__32 <CreateToggleTab>d__;
			<CreateToggleTab>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateToggleTab>d__.<>4__this = this;
			<CreateToggleTab>d__.callback = callback;
			<CreateToggleTab>d__.<>1__state = -1;
			<CreateToggleTab>d__.<>t__builder.Start<PopupCaptionItem.<CreateToggleTab>d__32>(ref <CreateToggleTab>d__);
			return <CreateToggleTab>d__.<>t__builder.Task;
		}

		// Token: 0x06022EB2 RID: 143026 RVA: 0x009E979B File Offset: 0x009E799B
		public void SetToggleName(string name)
		{
			PopupCaptionToggleItem toggleItem = this.ToggleItem;
			if (toggleItem == null)
			{
				return;
			}
			toggleItem.SetNameText(name);
		}

		// Token: 0x06022EB3 RID: 143027 RVA: 0x009E97AE File Offset: 0x009E79AE
		public void SetToggleVisible(bool visible)
		{
			PopupCaptionToggleItem toggleItem = this.ToggleItem;
			if (toggleItem == null)
			{
				return;
			}
			toggleItem.SetUiActive(visible);
		}

		// Token: 0x06022EB4 RID: 143028 RVA: 0x009E97C1 File Offset: 0x009E79C1
		public EToggleState GetToggleState()
		{
			if (this.ToggleItem == null)
			{
				return EToggleState.ETT_UnChecked;
			}
			return this.ToggleItem.GetToggleState();
		}

		// Token: 0x06022EB5 RID: 143029 RVA: 0x009E97D8 File Offset: 0x009E79D8
		public UUIItem GetCostContent()
		{
			return base.GetItem(4);
		}

		// Token: 0x06022EB6 RID: 143030 RVA: 0x009E97E4 File Offset: 0x009E79E4
		public UniTask CreateCaptionStateItem(Action callback)
		{
			PopupCaptionItem.<CreateCaptionStateItem>d__37 <CreateCaptionStateItem>d__;
			<CreateCaptionStateItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<CreateCaptionStateItem>d__.<>4__this = this;
			<CreateCaptionStateItem>d__.callback = callback;
			<CreateCaptionStateItem>d__.<>1__state = -1;
			<CreateCaptionStateItem>d__.<>t__builder.Start<PopupCaptionItem.<CreateCaptionStateItem>d__37>(ref <CreateCaptionStateItem>d__);
			return <CreateCaptionStateItem>d__.<>t__builder.Task;
		}

		// Token: 0x06022EB7 RID: 143031 RVA: 0x009E982F File Offset: 0x009E7A2F
		public void SetCaptionStateTip(string localKey)
		{
			PopupCaptionStateItem captionStateItem = this.CaptionStateItem;
			if (captionStateItem == null)
			{
				return;
			}
			captionStateItem.SetTipsLocalText(localKey);
		}

		// Token: 0x06022EB8 RID: 143032 RVA: 0x009E9842 File Offset: 0x009E7A42
		public void SetCaptionStateActive(bool active)
		{
			PopupCaptionStateItem captionStateItem = this.CaptionStateItem;
			if (captionStateItem == null)
			{
				return;
			}
			captionStateItem.SetActive(active);
		}

		// Token: 0x06022EB9 RID: 143033 RVA: 0x009E9855 File Offset: 0x009E7A55
		public void SetCaptionChangeColor(bool useChangeColor)
		{
			PopupCaptionStateItem captionStateItem = this.CaptionStateItem;
			if (captionStateItem == null)
			{
				return;
			}
			captionStateItem.SetCaptionChangeColor(useChangeColor);
		}

		// Token: 0x06022EBA RID: 143034 RVA: 0x009E9868 File Offset: 0x009E7A68
		public UUIItem GetToggleRootItem()
		{
			return base.GetItem(5);
		}

		// Token: 0x06022EBB RID: 143035 RVA: 0x009E9871 File Offset: 0x009E7A71
		[NullableContext(2)]
		public void CreateHomeBtn(EUiViewName viewName, string tag = null, bool snapSize = false)
		{
			HomeBtnController.Instance.CreateHomeBtnFromUiItem(base.GetItem(6), viewName, tag, snapSize);
		}

		// Token: 0x06022EBC RID: 143036 RVA: 0x009E9887 File Offset: 0x009E7A87
		public UUIItem GetHomeBtnRootItem()
		{
			return base.GetItem(6);
		}

		// Token: 0x06022EBD RID: 143037 RVA: 0x009E9890 File Offset: 0x009E7A90
		[NullableContext(2)]
		public UUIItem GetTitleIconRootItem()
		{
			return base.GetItem(7);
		}

		// Token: 0x06022EBE RID: 143038 RVA: 0x009E9899 File Offset: 0x009E7A99
		public UUIButtonComponent GetHelpBtn()
		{
			return base.GetButton(2);
		}

		// Token: 0x06022EBF RID: 143039 RVA: 0x009E98A2 File Offset: 0x009E7AA2
		public UUIButtonComponent GetCloseBtn()
		{
			return base.GetButton(3);
		}

		// Token: 0x04013480 RID: 78976
		private CommonCurrencyItemListComponent CurrencyItemListComponent;

		// Token: 0x04013481 RID: 78977
		private PopupCaptionToggleItem ToggleItem;

		// Token: 0x04013482 RID: 78978
		private PopupCaptionStateItem CaptionStateItem;

		// Token: 0x04013483 RID: 78979
		protected Action OnClickCloseBtnCall;

		// Token: 0x04013484 RID: 78980
		protected Action OnClickHelpBtnCall;

		// Token: 0x0200926B RID: 37483
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0402DD31 RID: 187697
			public const int TitleIcon = 0;

			// Token: 0x0402DD32 RID: 187698
			public const int Title = 1;

			// Token: 0x0402DD33 RID: 187699
			public const int HelpBtn = 2;

			// Token: 0x0402DD34 RID: 187700
			public const int BackBtn = 3;

			// Token: 0x0402DD35 RID: 187701
			public const int CostContent = 4;

			// Token: 0x0402DD36 RID: 187702
			public const int ToggleRoot = 5;

			// Token: 0x0402DD37 RID: 187703
			public const int HomeBtnRoot = 6;

			// Token: 0x0402DD38 RID: 187704
			public const int TitleIconRoot = 7;
		}
	}
}
