using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Cook;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Manufacture.Common
{
	// Token: 0x02005697 RID: 22167
	public class ManufactureHelpRoleView : UiViewBase
	{
		// Token: 0x0603867B RID: 231035 RVA: 0x00D63EDE File Offset: 0x00D620DE
		[NullableContext(1)]
		public ManufactureHelpRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603867C RID: 231036 RVA: 0x00D63EE8 File Offset: 0x00D620E8
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

		// Token: 0x0603867D RID: 231037 RVA: 0x00D63FD0 File Offset: 0x00D621D0
		protected override void OnBeforeDestroy()
		{
			if (this.RoleItemScrollView != null)
			{
				this.RoleItemScrollView.ClearGridProxies();
				this.RoleItemScrollView = null;
			}
		}

		// Token: 0x0603867E RID: 231038 RVA: 0x00D63FEC File Offset: 0x00D621EC
		protected override void OnStart()
		{
			this.RoleItemScrollView = new LoopScrollView<ManufactureHelpRoleView.HelpRoleItem, ICommonRoleItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<ManufactureHelpRoleView.HelpRoleItem>(this.OnGridProxyCreate), false);
			LguiUtil.Instance.SetLocalText(base.GetText(3), "ComposeSelectRoleButtonText", Array.Empty<object>());
			EventSystem.Instance.Emit<EViewType>(EEventName.SwitchViewType, EViewType.RoleViewType);
			this.ItemId = (int)this.OpenParam;
			this.CurrentSelectedRoleId = CommonManager.Instance.GetCurrentRoleId().Value;
			this.RefreshHelpRoleScroll();
		}

		// Token: 0x0603867F RID: 231039 RVA: 0x00D64084 File Offset: 0x00D62284
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

		// Token: 0x06038680 RID: 231040 RVA: 0x00D640A1 File Offset: 0x00D622A1
		[NullableContext(1)]
		private ManufactureHelpRoleView.HelpRoleItem OnGridProxyCreate()
		{
			ManufactureHelpRoleView.HelpRoleItem helpRoleItem = new ManufactureHelpRoleView.HelpRoleItem();
			helpRoleItem.BindOnClickedCallback(new Action<int>(this.RefreshConfirm));
			return helpRoleItem;
		}

		// Token: 0x06038681 RID: 231041 RVA: 0x00D640BA File Offset: 0x00D622BA
		private void RefreshHelpRoleScroll()
		{
			this.RoleItemDataList = CommonManager.Instance.GetHelpRoleItemDataList(this.ItemId);
			this.RoleItemScrollView.ReloadData(this.RoleItemDataList, false);
			this.SetSelectedRoleItem();
		}

		// Token: 0x06038682 RID: 231042 RVA: 0x00D640EC File Offset: 0x00D622EC
		private void SetSelectedRoleItem()
		{
			int num = 0;
			this.RoleItemScrollView.DeselectCurrentGridProxy(false);
			while (num < this.RoleItemDataList.Count && this.CurrentSelectedRoleId != this.RoleItemDataList[num].RoleId)
			{
				num++;
			}
			this.RoleItemScrollView.ScrollToGridIndex(num, true);
			this.RoleItemScrollView.SelectGridProxy(num, false);
		}

		// Token: 0x06038683 RID: 231043 RVA: 0x00D64150 File Offset: 0x00D62350
		private void RefreshConfirm(int roleId)
		{
			this.CurrentSelectedRoleId = roleId;
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

		// Token: 0x06038684 RID: 231044 RVA: 0x00D641C2 File Offset: 0x00D623C2
		private void OnConfirm()
		{
			CommonManager.Instance.SetCurrentRoleId(this.CurrentSelectedRoleId);
			UiManager.Instance.CloseView(EUiViewName.ManufactureHelpRoleView, null);
			EventSystem.Instance.Emit(EEventName.CloseHelpRole);
		}

		// Token: 0x0401DA1A RID: 121370
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ManufactureHelpRoleView.HelpRoleItem, ICommonRoleItemData> RoleItemScrollView;

		// Token: 0x0401DA1B RID: 121371
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonRoleItemData> RoleItemDataList;

		// Token: 0x0401DA1C RID: 121372
		private int ItemId;

		// Token: 0x0401DA1D RID: 121373
		private int CurrentSelectedRoleId;

		// Token: 0x0200B858 RID: 47192
		private class EHelpRoleDefine
		{
			// Token: 0x04037CC3 RID: 228547
			public const int HelpRoleLoopScroll = 0;

			// Token: 0x04037CC4 RID: 228548
			public const int HelpRoleItem = 1;

			// Token: 0x04037CC5 RID: 228549
			public const int ConfirmButton = 2;

			// Token: 0x04037CC6 RID: 228550
			public const int TxtConfirm = 3;
		}

		// Token: 0x0200B859 RID: 47193
		[NullableContext(2)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class HelpRoleItem : GridProxyAbstract<ICommonRoleItemData>
		{
			// Token: 0x0604F3FB RID: 324603 RVA: 0x01531B58 File Offset: 0x0152FD58
			protected unsafe override void OnRegisterComponent()
			{
				int num = 4;
				List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
				CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
				Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
				int num2 = 0;
				*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIExtendToggle));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(1, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIText));
				num2++;
				*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIItem));
				this.ComponentRegisterInfos = list;
				num2 = 1;
				List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
				CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
				Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
				num = 0;
				*span2[num] = new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClick));
				this.BtnBindInfo = list2;
			}

			// Token: 0x0604F3FC RID: 324604 RVA: 0x01531C40 File Offset: 0x0152FE40
			protected override void OnStart()
			{
				this.ItemGrid = new SmallItemGrid();
				this.ItemGrid.Initialize(base.GetItem(3).GetOwner());
			}

			// Token: 0x0604F3FD RID: 324605 RVA: 0x01531C64 File Offset: 0x0152FE64
			[NullableContext(1)]
			public override void Refresh(ICommonRoleItemData data, bool isSelected, int gridIndex)
			{
				this.ItemData = data;
				CharacterSmallItemGrid characterSmallItemGrid = new CharacterSmallItemGrid();
				characterSmallItemGrid.Data = data;
				characterSmallItemGrid.ItemConfigId = new int?(data.RoleId);
				characterSmallItemGrid.IsCookUp = new bool?(data.IsBuff);
				int? currentCookRoleId = CookModel.Instance.CurrentCookRoleId;
				int roleId = data.RoleId;
				characterSmallItemGrid.IsReceivedVisible = new bool?(currentCookRoleId.GetValueOrDefault() == roleId & currentCookRoleId != null);
				CharacterSmallItemGrid parameters = characterSmallItemGrid;
				this.ItemGrid.Apply<CharacterSmallItemGrid>(parameters);
				this.SetName();
				this.SetInfoText();
				this.Selected(isSelected, false);
				base.GetText(2).OnSelfLanguageChange.Bind(new Action(this.SetInfoText));
			}

			// Token: 0x0604F3FE RID: 324606 RVA: 0x01531D13 File Offset: 0x0152FF13
			public override void Clear()
			{
				base.GetText(2).OnSelfLanguageChange.Unbind();
			}

			// Token: 0x0604F3FF RID: 324607 RVA: 0x01531D26 File Offset: 0x0152FF26
			protected override void OnBeforeDestroy()
			{
				this.ItemGrid = null;
			}

			// Token: 0x0604F400 RID: 324608 RVA: 0x01531D2F File Offset: 0x0152FF2F
			private void SetName()
			{
				base.GetText(1).SetText(this.ItemData.RoleName, true);
			}

			// Token: 0x0604F401 RID: 324609 RVA: 0x01531D4C File Offset: 0x0152FF4C
			private void SetInfoText()
			{
				if (CommonManager.Instance.CheckIsBuff(this.ItemData.RoleId, this.ItemData.ItemId))
				{
					string infoText = CommonManager.Instance.GetInfoText(this.ItemData.RoleId);
					base.GetText(2).SetText(infoText, true);
					return;
				}
				string textById = TextConfig.Instance.GetTextById(CommonManager.Instance.GetDefaultRoleText());
				base.GetText(2).SetText(textById, true);
			}

			// Token: 0x0604F402 RID: 324610 RVA: 0x01531DC3 File Offset: 0x0152FFC3
			[NullableContext(1)]
			public void BindOnClickedCallback(Action<int> onItemButtonClicked)
			{
				this.OnClickedCallback = onItemButtonClicked;
			}

			// Token: 0x0604F403 RID: 324611 RVA: 0x01531DCC File Offset: 0x0152FFCC
			public override void OnSelected(bool fireEvent)
			{
				this.Selected(true, true);
			}

			// Token: 0x0604F404 RID: 324612 RVA: 0x01531DD6 File Offset: 0x0152FFD6
			public override void OnDeselected(bool fireEvent)
			{
				this.Selected(false, true);
			}

			// Token: 0x0604F405 RID: 324613 RVA: 0x01531DE0 File Offset: 0x0152FFE0
			private void Selected(bool bSelected, bool fireEvent = true)
			{
				UUIExtendToggle extendToggle = base.GetExtendToggle(0);
				if (bSelected)
				{
					extendToggle.SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
					return;
				}
				extendToggle.SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}

			// Token: 0x0604F406 RID: 324614 RVA: 0x01531E0F File Offset: 0x0153000F
			private void OnClick(EToggleState state)
			{
				if (this.OnClickedCallback != null)
				{
					this.OnClickedCallback(this.ItemData.RoleId);
				}
			}

			// Token: 0x04037CC7 RID: 228551
			private ICommonRoleItemData ItemData;

			// Token: 0x04037CC8 RID: 228552
			private SmallItemGrid ItemGrid;

			// Token: 0x04037CC9 RID: 228553
			private Action<int> OnClickedCallback;

			// Token: 0x0200D169 RID: 53609
			[NullableContext(0)]
			private class EHelpRoleItemDefine
			{
				// Token: 0x0403ED8E RID: 257422
				public const int HelpRoleExtendToggle = 0;

				// Token: 0x0403ED8F RID: 257423
				public const int RoleNameText = 1;

				// Token: 0x0403ED90 RID: 257424
				public const int CommonInfoText = 2;

				// Token: 0x0403ED91 RID: 257425
				public const int ItemGridItem = 3;
			}
		}
	}
}
