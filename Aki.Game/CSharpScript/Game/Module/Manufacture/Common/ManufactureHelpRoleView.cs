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
	// Token: 0x0200466D RID: 18029
	public class ManufactureHelpRoleView : UiViewBase
	{
		// Token: 0x0602D578 RID: 185720 RVA: 0x00CB202E File Offset: 0x00CB022E
		[NullableContext(1)]
		public ManufactureHelpRoleView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0602D579 RID: 185721 RVA: 0x00CB2038 File Offset: 0x00CB0238
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

		// Token: 0x0602D57A RID: 185722 RVA: 0x00CB2120 File Offset: 0x00CB0320
		protected override void OnBeforeDestroy()
		{
			if (this.RoleItemScrollView != null)
			{
				this.RoleItemScrollView.ClearGridProxies();
				this.RoleItemScrollView = null;
			}
		}

		// Token: 0x0602D57B RID: 185723 RVA: 0x00CB213C File Offset: 0x00CB033C
		protected override void OnStart()
		{
			this.RoleItemScrollView = new LoopScrollView<ManufactureHelpRoleView.HelpRoleItem, ICommonRoleItemData>(base.GetLoopScrollViewComponent(0), base.GetItem(1).GetOwner() as AUIBaseActor, new Func<ManufactureHelpRoleView.HelpRoleItem>(this.OnGridProxyCreate), false);
			LguiUtil.Instance.SetLocalText(base.GetText(3), "ComposeSelectRoleButtonText", Array.Empty<object>());
			EventSystem.Instance.Emit<EViewType>(EEventName.SwitchViewType, EViewType.RoleViewType);
			this.ItemId = (int)this.OpenParam;
			this.CurrentSelectedRoleId = CommonManager.Instance.GetCurrentRoleId().Value;
			this.RefreshHelpRoleScroll();
		}

		// Token: 0x0602D57C RID: 185724 RVA: 0x00CB21D4 File Offset: 0x00CB03D4
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

		// Token: 0x0602D57D RID: 185725 RVA: 0x00CB21F1 File Offset: 0x00CB03F1
		[NullableContext(1)]
		private ManufactureHelpRoleView.HelpRoleItem OnGridProxyCreate()
		{
			ManufactureHelpRoleView.HelpRoleItem helpRoleItem = new ManufactureHelpRoleView.HelpRoleItem();
			helpRoleItem.BindOnClickedCallback(new Action<int>(this.RefreshConfirm));
			return helpRoleItem;
		}

		// Token: 0x0602D57E RID: 185726 RVA: 0x00CB220A File Offset: 0x00CB040A
		private void RefreshHelpRoleScroll()
		{
			this.RoleItemDataList = CommonManager.Instance.GetHelpRoleItemDataList(this.ItemId);
			this.RoleItemScrollView.ReloadData(this.RoleItemDataList, false);
			this.SetSelectedRoleItem();
		}

		// Token: 0x0602D57F RID: 185727 RVA: 0x00CB223C File Offset: 0x00CB043C
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

		// Token: 0x0602D580 RID: 185728 RVA: 0x00CB22A0 File Offset: 0x00CB04A0
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

		// Token: 0x0602D581 RID: 185729 RVA: 0x00CB2312 File Offset: 0x00CB0512
		private void OnConfirm()
		{
			CommonManager.Instance.SetCurrentRoleId(this.CurrentSelectedRoleId);
			UiManager.Instance.CloseView(EUiViewName.ManufactureHelpRoleView, null);
			EventSystem.Instance.Emit(EEventName.CloseHelpRole);
		}

		// Token: 0x040184A5 RID: 99493
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<ManufactureHelpRoleView.HelpRoleItem, ICommonRoleItemData> RoleItemScrollView;

		// Token: 0x040184A6 RID: 99494
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private List<ICommonRoleItemData> RoleItemDataList;

		// Token: 0x040184A7 RID: 99495
		private int ItemId;

		// Token: 0x040184A8 RID: 99496
		private int CurrentSelectedRoleId;

		// Token: 0x0200A280 RID: 41600
		private class EHelpRoleDefine
		{
			// Token: 0x040326E0 RID: 206560
			public const int HelpRoleLoopScroll = 0;

			// Token: 0x040326E1 RID: 206561
			public const int HelpRoleItem = 1;

			// Token: 0x040326E2 RID: 206562
			public const int ConfirmButton = 2;

			// Token: 0x040326E3 RID: 206563
			public const int TxtConfirm = 3;
		}

		// Token: 0x0200A281 RID: 41601
		[NullableContext(2)]
		[Nullable(new byte[]
		{
			0,
			1
		})]
		public class HelpRoleItem : GridProxyAbstract<ICommonRoleItemData>
		{
			// Token: 0x060459C8 RID: 285128 RVA: 0x014EB3A4 File Offset: 0x014E95A4
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

			// Token: 0x060459C9 RID: 285129 RVA: 0x014EB48C File Offset: 0x014E968C
			protected override void OnStart()
			{
				this.ItemGrid = new SmallItemGrid();
				this.ItemGrid.Initialize(base.GetItem(3).GetOwner());
			}

			// Token: 0x060459CA RID: 285130 RVA: 0x014EB4B0 File Offset: 0x014E96B0
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

			// Token: 0x060459CB RID: 285131 RVA: 0x014EB55F File Offset: 0x014E975F
			public override void Clear()
			{
				base.GetText(2).OnSelfLanguageChange.Unbind();
			}

			// Token: 0x060459CC RID: 285132 RVA: 0x014EB572 File Offset: 0x014E9772
			protected override void OnBeforeDestroy()
			{
				this.ItemGrid = null;
			}

			// Token: 0x060459CD RID: 285133 RVA: 0x014EB57B File Offset: 0x014E977B
			private void SetName()
			{
				base.GetText(1).SetText(this.ItemData.RoleName, true);
			}

			// Token: 0x060459CE RID: 285134 RVA: 0x014EB598 File Offset: 0x014E9798
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

			// Token: 0x060459CF RID: 285135 RVA: 0x014EB60F File Offset: 0x014E980F
			[NullableContext(1)]
			public void BindOnClickedCallback(Action<int> onItemButtonClicked)
			{
				this.OnClickedCallback = onItemButtonClicked;
			}

			// Token: 0x060459D0 RID: 285136 RVA: 0x014EB618 File Offset: 0x014E9818
			public override void OnSelected(bool fireEvent)
			{
				this.Selected(true, true);
			}

			// Token: 0x060459D1 RID: 285137 RVA: 0x014EB622 File Offset: 0x014E9822
			public override void OnDeselected(bool fireEvent)
			{
				this.Selected(false, true);
			}

			// Token: 0x060459D2 RID: 285138 RVA: 0x014EB62C File Offset: 0x014E982C
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

			// Token: 0x060459D3 RID: 285139 RVA: 0x014EB65B File Offset: 0x014E985B
			private void OnClick(EToggleState state)
			{
				if (this.OnClickedCallback != null)
				{
					this.OnClickedCallback(this.ItemData.RoleId);
				}
			}

			// Token: 0x040326E4 RID: 206564
			private ICommonRoleItemData ItemData;

			// Token: 0x040326E5 RID: 206565
			private SmallItemGrid ItemGrid;

			// Token: 0x040326E6 RID: 206566
			private Action<int> OnClickedCallback;

			// Token: 0x0200BD47 RID: 48455
			[NullableContext(0)]
			private class EHelpRoleItemDefine
			{
				// Token: 0x0403A1D6 RID: 238038
				public const int HelpRoleExtendToggle = 0;

				// Token: 0x0403A1D7 RID: 238039
				public const int RoleNameText = 1;

				// Token: 0x0403A1D8 RID: 238040
				public const int CommonInfoText = 2;

				// Token: 0x0403A1D9 RID: 238041
				public const int ItemGridItem = 3;
			}
		}
	}
}
