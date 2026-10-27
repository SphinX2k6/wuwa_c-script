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
	// Token: 0x0200464E RID: 17998
	[NullableContext(1)]
	[Nullable(0)]
	public class PopupCaptionItem : UiPanelBase
	{
		// Token: 0x0602E74D RID: 190285 RVA: 0x00ABBC59 File Offset: 0x00AB9E59
		[NullableContext(2)]
		public PopupCaptionItem(UUIItem item = null)
		{
			if (item == null)
			{
				return;
			}
			base.CreateThenShowByActor(item.GetOwner(), null);
		}

		// Token: 0x0602E74E RID: 190286 RVA: 0x00ABBC74 File Offset: 0x00AB9E74
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

		// Token: 0x0602E74F RID: 190287 RVA: 0x00ABBE03 File Offset: 0x00ABA003
		protected override void OnStart()
		{
			this.CurrencyItemListComponent = new CommonCurrencyItemListComponent(base.GetItem(4));
		}

		// Token: 0x0602E750 RID: 190288 RVA: 0x00ABBE17 File Offset: 0x00ABA017
		private void OnClickCloseBtn()
		{
			if (this.OnClickCloseBtnCall != null)
			{
				this.OnClickCloseBtnCall();
			}
		}

		// Token: 0x0602E751 RID: 190289 RVA: 0x00ABBE2C File Offset: 0x00ABA02C
		private void OnClickHelpBtn()
		{
			if (this.OnClickHelpBtnCall != null)
			{
				this.OnClickHelpBtnCall();
			}
		}

		// Token: 0x0602E752 RID: 190290 RVA: 0x00ABBE44 File Offset: 0x00ABA044
		public void SetCloseBtnActive(bool state)
		{
			UUIItem uuiitem = base.GetButton(3).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(state);
			}
			this.SetHomeBtnShowState(state);
		}

		// Token: 0x0602E753 RID: 190291 RVA: 0x00ABBE78 File Offset: 0x00ABA078
		public void SetHelpBtnActive(bool state)
		{
			UUIItem uuiitem = base.GetButton(2).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetUIActive(state);
		}

		// Token: 0x0602E754 RID: 190292 RVA: 0x00ABBEA4 File Offset: 0x00ABA0A4
		public void SetCloseCallBack(Action call)
		{
			this.OnClickCloseBtnCall = call;
		}

		// Token: 0x0602E755 RID: 190293 RVA: 0x00ABBEAD File Offset: 0x00ABA0AD
		public void SetHelpCallBack(Action call)
		{
			this.OnClickHelpBtnCall = call;
		}

		// Token: 0x0602E756 RID: 190294 RVA: 0x00ABBEB8 File Offset: 0x00ABA0B8
		public void SetCloseBtnRaycast(bool state)
		{
			UUIItem uuiitem = base.GetButton(3).RootUIComp.Get();
			if (uuiitem == null)
			{
				return;
			}
			uuiitem.SetRaycastTarget(state);
		}

		// Token: 0x0602E757 RID: 190295 RVA: 0x00ABBEE4 File Offset: 0x00ABA0E4
		public void SetCloseBtnShowState(bool state)
		{
			UUIItem uuiitem = base.GetButton(3).RootUIComp.Get();
			if (uuiitem != null)
			{
				uuiitem.SetUIActive(state);
			}
			this.SetHomeBtnShowState(state);
		}

		// Token: 0x0602E758 RID: 190296 RVA: 0x00ABBF18 File Offset: 0x00ABA118
		public void SetHomeBtnShowState(bool state)
		{
			base.GetItem(6).SetUIActive(state);
		}

		// Token: 0x0602E759 RID: 190297 RVA: 0x00ABBF27 File Offset: 0x00ABA127
		public void SetTitle(string title)
		{
			base.GetText(1).SetText(title, true);
		}

		// Token: 0x0602E75A RID: 190298 RVA: 0x00ABBF37 File Offset: 0x00ABA137
		public void SetTitleByTextIdAndArg(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalText(base.GetText(1), textId, args);
		}

		// Token: 0x0602E75B RID: 190299 RVA: 0x00ABBF4C File Offset: 0x00ABA14C
		public void SetTitleByTextIdAndArgNew(string textId, params object[] args)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, args);
		}

		// Token: 0x0602E75C RID: 190300 RVA: 0x00ABBF61 File Offset: 0x00ABA161
		public void SetTitleByTitleData(CommonTabTitleData titleData)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), titleData.TextId, titleData.Args);
		}

		// Token: 0x0602E75D RID: 190301 RVA: 0x00ABBF80 File Offset: 0x00ABA180
		public void SetTitleLocalText(string textId)
		{
			LguiUtil.Instance.SetLocalTextNew(base.GetText(1), textId, Array.Empty<object>());
		}

		// Token: 0x0602E75E RID: 190302 RVA: 0x00ABBF9C File Offset: 0x00ABA19C
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

		// Token: 0x0602E75F RID: 190303 RVA: 0x00ABBFE8 File Offset: 0x00ABA1E8
		public void SetTitleIcon(string iconPath)
		{
			this.SetSpriteByPath(iconPath, base.GetSprite(0), false, null, null);
		}

		// Token: 0x0602E760 RID: 190304 RVA: 0x00ABC00E File Offset: 0x00ABA20E
		public void SetTitleTextActive(bool value)
		{
			base.GetText(1).SetUIActive(value);
		}

		// Token: 0x0602E761 RID: 190305 RVA: 0x00ABC01D File Offset: 0x00ABA21D
		public void SetTitleIconVisible(bool bVisible)
		{
			base.GetSprite(0).SetUIActive(bVisible);
		}

		// Token: 0x0602E762 RID: 190306 RVA: 0x00ABC02C File Offset: 0x00ABA22C
		public void SetCurrencyItemVisible(bool bVisible)
		{
			base.GetItem(4).SetUIActive(bVisible);
		}

		// Token: 0x0602E763 RID: 190307 RVA: 0x00ABC03C File Offset: 0x00ABA23C
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

		// Token: 0x0602E764 RID: 190308 RVA: 0x00ABC087 File Offset: 0x00ABA287
		public void SetCurrencyItemResourceId(string resourceId)
		{
			CommonCurrencyItemListComponent currencyItemListComponent = this.CurrencyItemListComponent;
			if (currencyItemListComponent == null)
			{
				return;
			}
			currencyItemListComponent.SetResourceId(resourceId);
		}

		// Token: 0x0602E765 RID: 190309 RVA: 0x00ABC09A File Offset: 0x00ABA29A
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

		// Token: 0x0602E766 RID: 190310 RVA: 0x00ABC0B0 File Offset: 0x00ABA2B0
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

		// Token: 0x0602E767 RID: 190311 RVA: 0x00ABC120 File Offset: 0x00ABA320
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

		// Token: 0x0602E768 RID: 190312 RVA: 0x00ABC16B File Offset: 0x00ABA36B
		public void SetToggleName(string name)
		{
			PopupCaptionToggleItem toggleItem = this.ToggleItem;
			if (toggleItem == null)
			{
				return;
			}
			toggleItem.SetNameText(name);
		}

		// Token: 0x0602E769 RID: 190313 RVA: 0x00ABC17E File Offset: 0x00ABA37E
		public void SetToggleVisible(bool visible)
		{
			PopupCaptionToggleItem toggleItem = this.ToggleItem;
			if (toggleItem == null)
			{
				return;
			}
			toggleItem.SetUiActive(visible);
		}

		// Token: 0x0602E76A RID: 190314 RVA: 0x00ABC191 File Offset: 0x00ABA391
		public EToggleState GetToggleState()
		{
			if (this.ToggleItem == null)
			{
				return EToggleState.ETT_UnChecked;
			}
			return this.ToggleItem.GetToggleState();
		}

		// Token: 0x0602E76B RID: 190315 RVA: 0x00ABC1A8 File Offset: 0x00ABA3A8
		public UUIItem GetCostContent()
		{
			return base.GetItem(4);
		}

		// Token: 0x0602E76C RID: 190316 RVA: 0x00ABC1B4 File Offset: 0x00ABA3B4
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

		// Token: 0x0602E76D RID: 190317 RVA: 0x00ABC1FF File Offset: 0x00ABA3FF
		public void SetCaptionStateTip(string localKey)
		{
			PopupCaptionStateItem captionStateItem = this.CaptionStateItem;
			if (captionStateItem == null)
			{
				return;
			}
			captionStateItem.SetTipsLocalText(localKey);
		}

		// Token: 0x0602E76E RID: 190318 RVA: 0x00ABC212 File Offset: 0x00ABA412
		public void SetCaptionStateActive(bool active)
		{
			PopupCaptionStateItem captionStateItem = this.CaptionStateItem;
			if (captionStateItem == null)
			{
				return;
			}
			captionStateItem.SetActive(active);
		}

		// Token: 0x0602E76F RID: 190319 RVA: 0x00ABC225 File Offset: 0x00ABA425
		public void SetCaptionChangeColor(bool useChangeColor)
		{
			PopupCaptionStateItem captionStateItem = this.CaptionStateItem;
			if (captionStateItem == null)
			{
				return;
			}
			captionStateItem.SetCaptionChangeColor(useChangeColor);
		}

		// Token: 0x0602E770 RID: 190320 RVA: 0x00ABC238 File Offset: 0x00ABA438
		public UUIItem GetToggleRootItem()
		{
			return base.GetItem(5);
		}

		// Token: 0x0602E771 RID: 190321 RVA: 0x00ABC241 File Offset: 0x00ABA441
		[NullableContext(2)]
		public void CreateHomeBtn(EUiViewName viewName, string tag = null, bool snapSize = false)
		{
			HomeBtnController.Instance.CreateHomeBtnFromUiItem(base.GetItem(6), viewName, tag, snapSize);
		}

		// Token: 0x0602E772 RID: 190322 RVA: 0x00ABC257 File Offset: 0x00ABA457
		public UUIItem GetHomeBtnRootItem()
		{
			return base.GetItem(6);
		}

		// Token: 0x0602E773 RID: 190323 RVA: 0x00ABC260 File Offset: 0x00ABA460
		[NullableContext(2)]
		public UUIItem GetTitleIconRootItem()
		{
			return base.GetItem(7);
		}

		// Token: 0x0602E774 RID: 190324 RVA: 0x00ABC269 File Offset: 0x00ABA469
		public UUIButtonComponent GetHelpBtn()
		{
			return base.GetButton(2);
		}

		// Token: 0x0602E775 RID: 190325 RVA: 0x00ABC272 File Offset: 0x00ABA472
		public UUIButtonComponent GetCloseBtn()
		{
			return base.GetButton(3);
		}

		// Token: 0x04018E27 RID: 101927
		private CommonCurrencyItemListComponent CurrencyItemListComponent;

		// Token: 0x04018E28 RID: 101928
		private PopupCaptionToggleItem ToggleItem;

		// Token: 0x04018E29 RID: 101929
		private PopupCaptionStateItem CaptionStateItem;

		// Token: 0x04018E2A RID: 101930
		protected Action OnClickCloseBtnCall;

		// Token: 0x04018E2B RID: 101931
		protected Action OnClickHelpBtnCall;

		// Token: 0x0200A8AF RID: 43183
		[NullableContext(0)]
		private class EComponents
		{
			// Token: 0x0403359B RID: 210331
			public const int TitleIcon = 0;

			// Token: 0x0403359C RID: 210332
			public const int Title = 1;

			// Token: 0x0403359D RID: 210333
			public const int HelpBtn = 2;

			// Token: 0x0403359E RID: 210334
			public const int BackBtn = 3;

			// Token: 0x0403359F RID: 210335
			public const int CostContent = 4;

			// Token: 0x040335A0 RID: 210336
			public const int ToggleRoot = 5;

			// Token: 0x040335A1 RID: 210337
			public const int HomeBtnRoot = 6;

			// Token: 0x040335A2 RID: 210338
			public const int TitleIconRoot = 7;
		}
	}
}
