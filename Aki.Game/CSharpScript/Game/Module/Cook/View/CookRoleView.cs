using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Cook.View
{
	// Token: 0x02004B02 RID: 19202
	public class CookRoleView : UiViewBase
	{
		// Token: 0x06030055 RID: 196693 RVA: 0x00D653F7 File Offset: 0x00D635F7
		[NullableContext(1)]
		public CookRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030056 RID: 196694 RVA: 0x00D65400 File Offset: 0x00D63600
		protected unsafe override void OnRegisterComponent()
		{
			int num = 4;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIText));
			this.ComponentRegisterInfos = list;
			num2 = 1;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(delegate()
			{
				this.OnConfirm();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06030057 RID: 196695 RVA: 0x00D654E8 File Offset: 0x00D636E8
		protected override void OnBeforeDestroy()
		{
			if (this.RoleItemScrollView != null)
			{
				this.RoleItemScrollView.ClearGridProxies();
				this.RoleItemScrollView = null;
			}
		}

		// Token: 0x06030058 RID: 196696 RVA: 0x00D65504 File Offset: 0x00D63704
		protected override void OnStart()
		{
			this.RoleItemScrollView = new LoopScrollView<CookRoleItem, ICookRoleItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<CookRoleItem>(this.OnGridProxyCreate), false);
			LguiUtil.Instance.SetLocalText(base.GetText(3), "CookSelectRoleButtonText", Array.Empty<object>());
			this.ShowView((this.OpenParam as int?).Value);
		}

		// Token: 0x06030059 RID: 196697 RVA: 0x00D6557A File Offset: 0x00D6377A
		protected override void OnBeforeShow()
		{
			IUiPopFrameInterface childPopView = this.ChildPopView;
			if (childPopView == null)
			{
				return;
			}
			CommonPopViewBase popItem = childPopView.PopItem;
			if (popItem == null)
			{
				return;
			}
			popItem.SetTexBgVisible(false);
		}

		// Token: 0x0603005A RID: 196698 RVA: 0x00D65597 File Offset: 0x00D63797
		[NullableContext(1)]
		private CookRoleItem OnGridProxyCreate()
		{
			CookRoleItem cookRoleItem = new CookRoleItem();
			cookRoleItem.BindOnClickedCallback(new Action<int>(this.RefreshConfirm));
			return cookRoleItem;
		}

		// Token: 0x0603005B RID: 196699 RVA: 0x00D655B0 File Offset: 0x00D637B0
		public void HideView(bool isHide)
		{
			this.SetActive(!isHide);
		}

		// Token: 0x0603005C RID: 196700 RVA: 0x00D655BC File Offset: 0x00D637BC
		public void ShowView(int itemId)
		{
			this.SetActive(true);
			CookModel.Instance.CurrentCookViewType = ECookDataType.CookRole;
			this.ItemId = itemId;
			this.TmpId = CookModel.Instance.CurrentCookRoleId.Value;
			this.RefreshCookRoleScroll();
		}

		// Token: 0x0603005D RID: 196701 RVA: 0x00D65600 File Offset: 0x00D63800
		private void RefreshCookRoleScroll()
		{
			this.RoleItemDataList = CookModel.Instance.GetCookRoleItemDataList(this.ItemId);
			this.RoleItemScrollView.ReloadData(this.RoleItemDataList, false);
			this.SetSelectedPhantomItem();
		}

		// Token: 0x0603005E RID: 196702 RVA: 0x00D65630 File Offset: 0x00D63830
		private void SetSelectedPhantomItem()
		{
			int num = 0;
			this.RoleItemScrollView.DeselectCurrentGridProxy(false);
			if (this.RoleItemDataList.Count == 0)
			{
				return;
			}
			while (num < this.RoleItemDataList.Count && this.TmpId != this.RoleItemDataList[num].RoleId)
			{
				num++;
			}
			this.RoleItemScrollView.ScrollToGridIndex(num, true);
			this.RoleItemScrollView.SelectGridProxy(num, false);
		}

		// Token: 0x0603005F RID: 196703 RVA: 0x00D656A0 File Offset: 0x00D638A0
		private void RefreshConfirm(int roleId)
		{
			this.TmpId = roleId;
			int num = 0;
			this.RoleItemScrollView.DeselectCurrentGridProxy(false);
			if (this.RoleItemDataList.Count == 0)
			{
				return;
			}
			while (num < this.RoleItemDataList.Count && roleId != this.RoleItemDataList[num].RoleId)
			{
				num++;
			}
			this.RoleItemScrollView.SelectGridProxy(num, false);
			this.RoleItemScrollView.RefreshGridProxy(num);
		}

		// Token: 0x06030060 RID: 196704 RVA: 0x00D6570F File Offset: 0x00D6390F
		private void OnConfirm()
		{
			CookModel.Instance.CurrentCookRoleId = new int?(this.TmpId);
			base.CloseMe(null);
			EventSystem.Instance.Emit(EEventName.CloseCookRole);
		}

		// Token: 0x04019785 RID: 104325
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<CookRoleItem, ICookRoleItemData> RoleItemScrollView;

		// Token: 0x04019786 RID: 104326
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICookRoleItemData> RoleItemDataList;

		// Token: 0x04019787 RID: 104327
		private int ItemId;

		// Token: 0x04019788 RID: 104328
		private int TmpId;

		// Token: 0x0200A762 RID: 42850
		public enum ECookRoleDefine
		{
			// Token: 0x04033B8E RID: 211854
			CookRoleLoopScroll,
			// Token: 0x04033B8F RID: 211855
			CookRoleItem,
			// Token: 0x04033B90 RID: 211856
			ConfirmButton,
			// Token: 0x04033B91 RID: 211857
			TxtConfirm
		}
	}
}
