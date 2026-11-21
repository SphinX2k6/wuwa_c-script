using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200357A RID: 13690
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonPopViewBase : UiPanelBase
	{
		// Token: 0x06022E40 RID: 142912 RVA: 0x009E8314 File Offset: 0x009E6514
		public void AttachItem(UUIItem item, UUIItem viewRoot)
		{
			UUIItem attachParent = this.GetAttachParent();
			if (attachParent == null)
			{
				return;
			}
			UIAnchorHorizontalAlign anchorHAlign = item.GetAnchorHAlign();
			UIAnchorVerticalAlign anchorVAlign = item.GetAnchorVAlign();
			float stretchBottom = item.GetStretchBottom();
			float stretchLeft = item.GetStretchLeft();
			float stretchRight = item.GetStretchRight();
			float stretchTop = item.GetStretchTop();
			item.SetUIParent(attachParent, false);
			item.SetAnchorAlign(anchorHAlign, anchorVAlign);
			item.SetStretchBottom(stretchBottom);
			item.SetStretchLeft(stretchLeft);
			item.SetStretchRight(stretchRight);
			item.SetStretchTop(stretchTop);
			if (viewRoot != item)
			{
				viewRoot.SetAnchorAlign(anchorHAlign, anchorVAlign);
				viewRoot.SetStretchBottom(stretchBottom);
				viewRoot.SetStretchLeft(stretchLeft);
				viewRoot.SetStretchRight(stretchRight);
				viewRoot.SetStretchTop(stretchTop);
			}
		}

		// Token: 0x06022E41 RID: 142913 RVA: 0x009E83B3 File Offset: 0x009E65B3
		protected void OnClickMaskButton()
		{
			if (!this.MaskCallable)
			{
				return;
			}
			this.TryHideSelf();
		}

		// Token: 0x06022E42 RID: 142914 RVA: 0x009E83C4 File Offset: 0x009E65C4
		protected void OnClickCloseBtn()
		{
			this.TryHideSelf();
		}

		// Token: 0x06022E43 RID: 142915 RVA: 0x009E83CC File Offset: 0x009E65CC
		[NullableContext(2)]
		public virtual UUIItem GetAttachParent()
		{
			Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.YZY, "子类没有重写获取父物体方法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x06022E44 RID: 142916 RVA: 0x009E83F6 File Offset: 0x009E65F6
		public virtual void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x06022E45 RID: 142917 RVA: 0x009E83F8 File Offset: 0x009E65F8
		public virtual void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x06022E46 RID: 142918 RVA: 0x009E83FA File Offset: 0x009E65FA
		public virtual void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
		}

		// Token: 0x06022E47 RID: 142919 RVA: 0x009E83FC File Offset: 0x009E65FC
		public virtual void OnSetBackBtnShowState(bool state)
		{
		}

		// Token: 0x06022E48 RID: 142920 RVA: 0x009E83FE File Offset: 0x009E65FE
		public virtual void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
		}

		// Token: 0x06022E49 RID: 142921 RVA: 0x009E8400 File Offset: 0x009E6600
		[NullableContext(2)]
		public virtual UUIItem GetCostParent()
		{
			return null;
		}

		// Token: 0x06022E4A RID: 142922 RVA: 0x009E8403 File Offset: 0x009E6603
		public void SetViewInfo(UiViewInfo info)
		{
			this.ViewInfo = info;
		}

		// Token: 0x06022E4B RID: 142923 RVA: 0x009E840C File Offset: 0x009E660C
		public void SetPopupViewBase()
		{
			if (this is ICommonPopView)
			{
				this.SelfItem = (this as ICommonPopView);
			}
		}

		// Token: 0x06022E4C RID: 142924 RVA: 0x009E8422 File Offset: 0x009E6622
		protected void TryHideSelf()
		{
			this.OnClickHideFunction();
		}

		// Token: 0x06022E4D RID: 142925 RVA: 0x009E842A File Offset: 0x009E662A
		public void OverrideBackBtnCallBack(Action call)
		{
			this.OnClickBtnBtnCall = call;
			this.OverrideCloseBtnFuncState = true;
		}

		// Token: 0x06022E4E RID: 142926 RVA: 0x009E843A File Offset: 0x009E663A
		private void OnClickHideFunction()
		{
			if (!this.OverrideCloseBtnFuncState)
			{
				if (this.ViewInfo != null)
				{
					UiManager.Instance.CloseView(this.ViewInfo.Name, null);
				}
				return;
			}
			Action onClickBtnBtnCall = this.OnClickBtnBtnCall;
			if (onClickBtnBtnCall == null)
			{
				return;
			}
			onClickBtnBtnCall();
		}

		// Token: 0x06022E4F RID: 142927 RVA: 0x009E8473 File Offset: 0x009E6673
		public void SetCloseBtnInteractive(bool state)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnSetCloseBtnInteractive(state);
		}

		// Token: 0x06022E50 RID: 142928 RVA: 0x009E8486 File Offset: 0x009E6686
		public void SetHelpButtonActive(bool state)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnSetHelpButtonActive(state);
		}

		// Token: 0x06022E51 RID: 142929 RVA: 0x009E8499 File Offset: 0x009E6699
		public void SetTitleByTextIdAndArg(string textId, params object[] args)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnSetTitleByTextIdAndArg(textId, args);
		}

		// Token: 0x06022E52 RID: 142930 RVA: 0x009E84AD File Offset: 0x009E66AD
		public void SetBackBtnShowState(bool state)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnSetBackBtnShowState(state);
		}

		// Token: 0x06022E53 RID: 142931 RVA: 0x009E84C0 File Offset: 0x009E66C0
		public void RefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnRefreshCost(commonCurrencyItemList);
		}

		// Token: 0x06022E54 RID: 142932 RVA: 0x009E84D3 File Offset: 0x009E66D3
		public void SetMaskResponsibleState(bool state)
		{
			this.MaskCallable = state;
		}

		// Token: 0x06022E55 RID: 142933 RVA: 0x009E84DC File Offset: 0x009E66DC
		public UniTask SetCurrencyItemList(int[] itemIdList)
		{
			CommonPopViewBase.<SetCurrencyItemList>d__28 <SetCurrencyItemList>d__;
			<SetCurrencyItemList>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<SetCurrencyItemList>d__.<>4__this = this;
			<SetCurrencyItemList>d__.itemIdList = itemIdList;
			<SetCurrencyItemList>d__.<>1__state = -1;
			<SetCurrencyItemList>d__.<>t__builder.Start<CommonPopViewBase.<SetCurrencyItemList>d__28>(ref <SetCurrencyItemList>d__);
			return <SetCurrencyItemList>d__.<>t__builder.Task;
		}

		// Token: 0x06022E56 RID: 142934 RVA: 0x009E8527 File Offset: 0x009E6727
		[NullableContext(2)]
		public CommonCurrencyItemListComponent GetCurrencyComponent()
		{
			return this.CurrencyItemListComponent;
		}

		// Token: 0x06022E57 RID: 142935 RVA: 0x009E852F File Offset: 0x009E672F
		public virtual void SetTitleVisible(bool bVisible)
		{
		}

		// Token: 0x06022E58 RID: 142936 RVA: 0x009E8531 File Offset: 0x009E6731
		public virtual void SetTitleText(string titleTextId)
		{
		}

		// Token: 0x06022E59 RID: 142937 RVA: 0x009E8533 File Offset: 0x009E6733
		public virtual void SetTexBgVisible(bool bVisible)
		{
		}

		// Token: 0x04013473 RID: 78963
		[Nullable(2)]
		private CommonCurrencyItemListComponent CurrencyItemListComponent;

		// Token: 0x04013474 RID: 78964
		private bool MaskCallable = true;

		// Token: 0x04013475 RID: 78965
		[Nullable(2)]
		private ICommonPopView SelfItem;

		// Token: 0x04013476 RID: 78966
		[Nullable(2)]
		protected UUIItem ContentItem;

		// Token: 0x04013477 RID: 78967
		[Nullable(2)]
		protected UiViewInfo ViewInfo;

		// Token: 0x04013478 RID: 78968
		[Nullable(2)]
		protected Action OnClickBtnBtnCall;

		// Token: 0x04013479 RID: 78969
		private bool OverrideCloseBtnFuncState;
	}
}
