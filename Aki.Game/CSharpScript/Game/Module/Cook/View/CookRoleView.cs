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
	// Token: 0x02005B21 RID: 23329
	public class CookRoleView : UiViewBase
	{
		// Token: 0x0603B0E3 RID: 241891 RVA: 0x00E146DF File Offset: 0x00E128DF
		[NullableContext(1)]
		public CookRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603B0E4 RID: 241892 RVA: 0x00E146E8 File Offset: 0x00E128E8
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

		// Token: 0x0603B0E5 RID: 241893 RVA: 0x00E147D0 File Offset: 0x00E129D0
		protected override void OnBeforeDestroy()
		{
			if (this.RoleItemScrollView != null)
			{
				this.RoleItemScrollView.ClearGridProxies();
				this.RoleItemScrollView = null;
			}
		}

		// Token: 0x0603B0E6 RID: 241894 RVA: 0x00E147EC File Offset: 0x00E129EC
		protected override void OnStart()
		{
			this.RoleItemScrollView = new LoopScrollView<CookRoleItem, ICookRoleItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<CookRoleItem>(this.OnGridProxyCreate), false);
			LguiUtil.Instance.SetLocalText(base.GetText(3), "CookSelectRoleButtonText", Array.Empty<object>());
			this.ShowView((this.OpenParam as int?).Value);
		}

		// Token: 0x0603B0E7 RID: 241895 RVA: 0x00E14862 File Offset: 0x00E12A62
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

		// Token: 0x0603B0E8 RID: 241896 RVA: 0x00E1487F File Offset: 0x00E12A7F
		[NullableContext(1)]
		private CookRoleItem OnGridProxyCreate()
		{
			CookRoleItem cookRoleItem = new CookRoleItem();
			cookRoleItem.BindOnClickedCallback(new Action<int>(this.RefreshConfirm));
			return cookRoleItem;
		}

		// Token: 0x0603B0E9 RID: 241897 RVA: 0x00E14898 File Offset: 0x00E12A98
		public void HideView(bool isHide)
		{
			this.SetActive(!isHide);
		}

		// Token: 0x0603B0EA RID: 241898 RVA: 0x00E148A4 File Offset: 0x00E12AA4
		public void ShowView(int itemId)
		{
			this.SetActive(true);
			CookModel.Instance.CurrentCookViewType = ECookDataType.CookRole;
			this.ItemId = itemId;
			this.TmpId = CookModel.Instance.CurrentCookRoleId.Value;
			this.RefreshCookRoleScroll();
		}

		// Token: 0x0603B0EB RID: 241899 RVA: 0x00E148E8 File Offset: 0x00E12AE8
		private void RefreshCookRoleScroll()
		{
			this.RoleItemDataList = CookModel.Instance.GetCookRoleItemDataList(this.ItemId);
			this.RoleItemScrollView.ReloadData(this.RoleItemDataList, false);
			this.SetSelectedPhantomItem();
		}

		// Token: 0x0603B0EC RID: 241900 RVA: 0x00E14918 File Offset: 0x00E12B18
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

		// Token: 0x0603B0ED RID: 241901 RVA: 0x00E14988 File Offset: 0x00E12B88
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

		// Token: 0x0603B0EE RID: 241902 RVA: 0x00E149F7 File Offset: 0x00E12BF7
		private void OnConfirm()
		{
			CookModel.Instance.CurrentCookRoleId = new int?(this.TmpId);
			base.CloseMe(null);
			EventSystem.Instance.Emit(EEventName.CloseCookRole);
		}

		// Token: 0x0401ECC9 RID: 126153
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<CookRoleItem, ICookRoleItemData> RoleItemScrollView;

		// Token: 0x0401ECCA RID: 126154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICookRoleItemData> RoleItemDataList;

		// Token: 0x0401ECCB RID: 126155
		private int ItemId;

		// Token: 0x0401ECCC RID: 126156
		private int TmpId;

		// Token: 0x0200BD59 RID: 48473
		public enum ECookRoleDefine
		{
			// Token: 0x040391C2 RID: 233922
			CookRoleLoopScroll,
			// Token: 0x040391C3 RID: 233923
			CookRoleItem,
			// Token: 0x040391C4 RID: 233924
			ConfirmButton,
			// Token: 0x040391C5 RID: 233925
			TxtConfirm
		}
	}
}
