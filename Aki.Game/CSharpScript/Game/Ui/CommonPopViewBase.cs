using System;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02004649 RID: 17993
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class CommonPopViewBase : UiPanelBase
	{
		// Token: 0x0602E6F6 RID: 190198 RVA: 0x00ABACE4 File Offset: 0x00AB8EE4
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

		// Token: 0x0602E6F7 RID: 190199 RVA: 0x00ABAD83 File Offset: 0x00AB8F83
		protected void OnClickMaskButton()
		{
			if (!this.MaskCallable)
			{
				return;
			}
			this.TryHideSelf();
		}

		// Token: 0x0602E6F8 RID: 190200 RVA: 0x00ABAD94 File Offset: 0x00AB8F94
		protected void OnClickCloseBtn()
		{
			this.TryHideSelf();
		}

		// Token: 0x0602E6F9 RID: 190201 RVA: 0x00ABAD9C File Offset: 0x00AB8F9C
		[NullableContext(2)]
		public virtual UUIItem GetAttachParent()
		{
			Log.Instance.Error(ELogModule.UiCommon, ELogAuthor.YZY, "子类没有重写获取父物体方法", default(ReadOnlySpan<ValueTuple<string, object>>));
			return null;
		}

		// Token: 0x0602E6FA RID: 190202 RVA: 0x00ABADC6 File Offset: 0x00AB8FC6
		public virtual void OnSetCloseBtnInteractive(bool state)
		{
		}

		// Token: 0x0602E6FB RID: 190203 RVA: 0x00ABADC8 File Offset: 0x00AB8FC8
		public virtual void OnSetHelpButtonActive(bool state)
		{
		}

		// Token: 0x0602E6FC RID: 190204 RVA: 0x00ABADCA File Offset: 0x00AB8FCA
		public virtual void OnSetTitleByTextIdAndArg(string textId, params object[] args)
		{
		}

		// Token: 0x0602E6FD RID: 190205 RVA: 0x00ABADCC File Offset: 0x00AB8FCC
		public virtual void OnSetBackBtnShowState(bool state)
		{
		}

		// Token: 0x0602E6FE RID: 190206 RVA: 0x00ABADCE File Offset: 0x00AB8FCE
		public virtual void OnRefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
		}

		// Token: 0x0602E6FF RID: 190207 RVA: 0x00ABADD0 File Offset: 0x00AB8FD0
		[NullableContext(2)]
		public virtual UUIItem GetCostParent()
		{
			return null;
		}

		// Token: 0x0602E700 RID: 190208 RVA: 0x00ABADD3 File Offset: 0x00AB8FD3
		public void SetViewInfo(UiViewInfo info)
		{
			this.ViewInfo = info;
		}

		// Token: 0x0602E701 RID: 190209 RVA: 0x00ABADDC File Offset: 0x00AB8FDC
		public void SetPopupViewBase()
		{
			if (this is ICommonPopView)
			{
				this.SelfItem = (this as ICommonPopView);
			}
		}

		// Token: 0x0602E702 RID: 190210 RVA: 0x00ABADF2 File Offset: 0x00AB8FF2
		protected void TryHideSelf()
		{
			this.OnClickHideFunction();
		}

		// Token: 0x0602E703 RID: 190211 RVA: 0x00ABADFA File Offset: 0x00AB8FFA
		public void OverrideBackBtnCallBack(Action call)
		{
			this.OnClickBtnBtnCall = call;
			this.OverrideCloseBtnFuncState = true;
		}

		// Token: 0x0602E704 RID: 190212 RVA: 0x00ABAE0A File Offset: 0x00AB900A
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

		// Token: 0x0602E705 RID: 190213 RVA: 0x00ABAE43 File Offset: 0x00AB9043
		public void SetCloseBtnInteractive(bool state)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnSetCloseBtnInteractive(state);
		}

		// Token: 0x0602E706 RID: 190214 RVA: 0x00ABAE56 File Offset: 0x00AB9056
		public void SetHelpButtonActive(bool state)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnSetHelpButtonActive(state);
		}

		// Token: 0x0602E707 RID: 190215 RVA: 0x00ABAE69 File Offset: 0x00AB9069
		public void SetTitleByTextIdAndArg(string textId, params object[] args)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnSetTitleByTextIdAndArg(textId, args);
		}

		// Token: 0x0602E708 RID: 190216 RVA: 0x00ABAE7D File Offset: 0x00AB907D
		public void SetBackBtnShowState(bool state)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnSetBackBtnShowState(state);
		}

		// Token: 0x0602E709 RID: 190217 RVA: 0x00ABAE90 File Offset: 0x00AB9090
		public void RefreshCost(CommonCurrencyItem[] commonCurrencyItemList)
		{
			ICommonPopView selfItem = this.SelfItem;
			if (selfItem == null)
			{
				return;
			}
			selfItem.OnRefreshCost(commonCurrencyItemList);
		}

		// Token: 0x0602E70A RID: 190218 RVA: 0x00ABAEA3 File Offset: 0x00AB90A3
		public void SetMaskResponsibleState(bool state)
		{
			this.MaskCallable = state;
		}

		// Token: 0x0602E70B RID: 190219 RVA: 0x00ABAEAC File Offset: 0x00AB90AC
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

		// Token: 0x0602E70C RID: 190220 RVA: 0x00ABAEF7 File Offset: 0x00AB90F7
		[NullableContext(2)]
		public CommonCurrencyItemListComponent GetCurrencyComponent()
		{
			return this.CurrencyItemListComponent;
		}

		// Token: 0x0602E70D RID: 190221 RVA: 0x00ABAEFF File Offset: 0x00AB90FF
		public virtual void SetTitleVisible(bool bVisible)
		{
		}

		// Token: 0x0602E70E RID: 190222 RVA: 0x00ABAF01 File Offset: 0x00AB9101
		public virtual void SetTitleText(string titleTextId)
		{
		}

		// Token: 0x0602E70F RID: 190223 RVA: 0x00ABAF03 File Offset: 0x00AB9103
		public virtual void SetTexBgVisible(bool bVisible)
		{
		}

		// Token: 0x04018E1A RID: 101914
		[Nullable(2)]
		private CommonCurrencyItemListComponent CurrencyItemListComponent;

		// Token: 0x04018E1B RID: 101915
		private bool MaskCallable = true;

		// Token: 0x04018E1C RID: 101916
		[Nullable(2)]
		private ICommonPopView SelfItem;

		// Token: 0x04018E1D RID: 101917
		[Nullable(2)]
		protected UUIItem ContentItem;

		// Token: 0x04018E1E RID: 101918
		[Nullable(2)]
		protected UiViewInfo ViewInfo;

		// Token: 0x04018E1F RID: 101919
		[Nullable(2)]
		protected Action OnClickBtnBtnCall;

		// Token: 0x04018E20 RID: 101920
		private bool OverrideCloseBtnFuncState;
	}
}
