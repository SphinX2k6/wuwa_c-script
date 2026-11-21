using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02004668 RID: 18024
	public class HelpRoleView : UiNavigationView
	{
		// Token: 0x0602D53C RID: 185660 RVA: 0x00CB0C8C File Offset: 0x00CAEE8C
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

		// Token: 0x0602D53D RID: 185661 RVA: 0x00CB0D74 File Offset: 0x00CAEF74
		protected override void OnBeforeDestroy()
		{
			if (this.RoleItemScrollView != null)
			{
				this.RoleItemScrollView.ClearGridProxies();
				this.RoleItemScrollView = null;
			}
		}

		// Token: 0x0602D53E RID: 185662 RVA: 0x00CB0D90 File Offset: 0x00CAEF90
		protected override void OnStart()
		{
			this.RoleItemScrollView = new LoopScrollView<HelpRoleItem, ICommonRoleItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<HelpRoleItem>(this.OnGridProxyCreate), false);
		}

		// Token: 0x0602D53F RID: 185663 RVA: 0x00CB0DC2 File Offset: 0x00CAEFC2
		[NullableContext(1)]
		private HelpRoleItem OnGridProxyCreate()
		{
			HelpRoleItem helpRoleItem = new HelpRoleItem();
			helpRoleItem.BindOnClickedCallback(new Action<int>(this.RefreshConfirm));
			return helpRoleItem;
		}

		// Token: 0x0602D540 RID: 185664 RVA: 0x00CB0DDB File Offset: 0x00CAEFDB
		public void HideView(bool isHide)
		{
			this.SetActive(!isHide);
		}

		// Token: 0x0602D541 RID: 185665 RVA: 0x00CB0DE8 File Offset: 0x00CAEFE8
		public void ShowView(int itemId)
		{
			this.SetActive(true);
			EventSystem.Instance.Emit<EViewType>(EEventName.SwitchViewType, EViewType.RoleViewType);
			this.ItemId = itemId;
			this.TmpId = CommonManager.Instance.GetCurrentRoleId().Value;
			this.RefreshHelpRoleScroll();
		}

		// Token: 0x0602D542 RID: 185666 RVA: 0x00CB0E32 File Offset: 0x00CAF032
		private void RefreshHelpRoleScroll()
		{
			this.RoleItemDataList = CommonManager.Instance.GetHelpRoleItemDataList(this.ItemId);
			this.RoleItemScrollView.ReloadData(this.RoleItemDataList, false);
			this.SetSelectedRoleItem();
		}

		// Token: 0x0602D543 RID: 185667 RVA: 0x00CB0E64 File Offset: 0x00CAF064
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

		// Token: 0x0602D544 RID: 185668 RVA: 0x00CB0EC8 File Offset: 0x00CAF0C8
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

		// Token: 0x0602D545 RID: 185669 RVA: 0x00CB0F3A File Offset: 0x00CAF13A
		private void OnConfirm()
		{
			CommonManager.Instance.SetCurrentRoleId(this.TmpId);
			EventSystem.Instance.Emit(EEventName.CloseHelpRole);
		}

		// Token: 0x0401849A RID: 99482
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<HelpRoleItem, ICommonRoleItemData> RoleItemScrollView;

		// Token: 0x0401849B RID: 99483
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonRoleItemData> RoleItemDataList;

		// Token: 0x0401849C RID: 99484
		private int ItemId;

		// Token: 0x0401849D RID: 99485
		private int TmpId;

		// Token: 0x0200A27C RID: 41596
		private class EHelpRoleDefine
		{
			// Token: 0x040326C7 RID: 206535
			public const int HelpRoleLoopScroll = 0;

			// Token: 0x040326C8 RID: 206536
			public const int HelpRoleItem = 1;

			// Token: 0x040326C9 RID: 206537
			public const int ConfirmButton = 2;

			// Token: 0x040326CA RID: 206538
			public const int ConfirmText = 3;
		}
	}
}
