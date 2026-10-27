using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02005692 RID: 22162
	public class HelpRoleView : UiNavigationView
	{
		// Token: 0x0603863F RID: 230975 RVA: 0x00D62B3C File Offset: 0x00D60D3C
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
			*span2[num] = new ValueTuple<int, Delegate>(2, new Action(this.OnConfirm));
			this.BtnBindInfo = list2;
		}

		// Token: 0x06038640 RID: 230976 RVA: 0x00D62C24 File Offset: 0x00D60E24
		protected override void OnBeforeDestroy()
		{
			if (this.RoleItemScrollView != null)
			{
				this.RoleItemScrollView.ClearGridProxies();
				this.RoleItemScrollView = null;
			}
		}

		// Token: 0x06038641 RID: 230977 RVA: 0x00D62C40 File Offset: 0x00D60E40
		protected override void OnStart()
		{
			this.RoleItemScrollView = new LoopScrollView<HelpRoleItem, ICommonRoleItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<HelpRoleItem>(this.OnGridProxyCreate), false);
		}

		// Token: 0x06038642 RID: 230978 RVA: 0x00D62C72 File Offset: 0x00D60E72
		[NullableContext(1)]
		private HelpRoleItem OnGridProxyCreate()
		{
			HelpRoleItem helpRoleItem = new HelpRoleItem();
			helpRoleItem.BindOnClickedCallback(new Action<int>(this.RefreshConfirm));
			return helpRoleItem;
		}

		// Token: 0x06038643 RID: 230979 RVA: 0x00D62C8B File Offset: 0x00D60E8B
		public void HideView(bool isHide)
		{
			this.SetActive(!isHide);
		}

		// Token: 0x06038644 RID: 230980 RVA: 0x00D62C98 File Offset: 0x00D60E98
		public void ShowView(int itemId)
		{
			this.SetActive(true);
			EventSystem.Instance.Emit<EViewType>(EEventName.SwitchViewType, EViewType.RoleViewType);
			this.ItemId = itemId;
			this.TmpId = CommonManager.Instance.GetCurrentRoleId().Value;
			this.RefreshHelpRoleScroll();
		}

		// Token: 0x06038645 RID: 230981 RVA: 0x00D62CE2 File Offset: 0x00D60EE2
		private void RefreshHelpRoleScroll()
		{
			this.RoleItemDataList = CommonManager.Instance.GetHelpRoleItemDataList(this.ItemId);
			this.RoleItemScrollView.ReloadData(this.RoleItemDataList, false);
			this.SetSelectedRoleItem();
		}

		// Token: 0x06038646 RID: 230982 RVA: 0x00D62D14 File Offset: 0x00D60F14
		private void SetSelectedRoleItem()
		{
			int num = 0;
			this.RoleItemScrollView.DeselectCurrentGridProxy(false);
			while (num < this.RoleItemDataList.Count && this.TmpId != this.RoleItemDataList[num].RoleId)
			{
				num++;
			}
			this.RoleItemScrollView.ScrollToGridIndex(num, true);
			this.RoleItemScrollView.SelectGridProxy(num, false);
		}

		// Token: 0x06038647 RID: 230983 RVA: 0x00D62D78 File Offset: 0x00D60F78
		private void RefreshConfirm(int roleId)
		{
			this.TmpId = roleId;
			int num = 0;
			this.RoleItemScrollView.DeselectCurrentGridProxy(false);
			while (num < this.RoleItemDataList.Count && roleId != this.RoleItemDataList[num].RoleId)
			{
				num++;
			}
			if (!this.RoleItemScrollView.IsGridDisplaying(num))
			{
				return;
			}
			this.RoleItemScrollView.SelectGridProxy(num, false);
			this.RoleItemScrollView.RefreshGridProxy(num);
		}

		// Token: 0x06038648 RID: 230984 RVA: 0x00D62DEA File Offset: 0x00D60FEA
		private void OnConfirm()
		{
			CommonManager.Instance.SetCurrentRoleId(this.TmpId);
			EventSystem.Instance.Emit(EEventName.CloseHelpRole);
		}

		// Token: 0x0401DA0F RID: 121359
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<HelpRoleItem, ICommonRoleItemData> RoleItemScrollView;

		// Token: 0x0401DA10 RID: 121360
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonRoleItemData> RoleItemDataList;

		// Token: 0x0401DA11 RID: 121361
		private int ItemId;

		// Token: 0x0401DA12 RID: 121362
		private int TmpId;

		// Token: 0x0200B854 RID: 47188
		private class EHelpRoleDefine
		{
			// Token: 0x04037CAA RID: 228522
			public const int HelpRoleLoopScroll = 0;

			// Token: 0x04037CAB RID: 228523
			public const int HelpRoleItem = 1;

			// Token: 0x04037CAC RID: 228524
			public const int ConfirmButton = 2;

			// Token: 0x04037CAD RID: 228525
			public const int ConfirmText = 3;
		}
	}
}
