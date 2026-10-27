using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.Util;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Pinball.View.Role
{
	// Token: 0x02006318 RID: 25368
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleView : UiViewBase
	{
		// Token: 0x0603FD22 RID: 261410 RVA: 0x00F7096B File Offset: 0x00F6EB6B
		public PinballRoleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x0603FD23 RID: 261411 RVA: 0x00F7099C File Offset: 0x00F6EB9C
		protected unsafe override void OnRegisterComponent()
		{
			int num = 9;
			List<ValueTuple<int, Type>> list = new List<ValueTuple<int, Type>>(num);
			CollectionsMarshal.SetCount<ValueTuple<int, Type>>(list, num);
			Span<ValueTuple<int, Type>> span = CollectionsMarshal.AsSpan<ValueTuple<int, Type>>(list);
			int num2 = 0;
			*span[num2] = new ValueTuple<int, Type>(0, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(1, typeof(UUILoopScrollViewComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(2, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(3, typeof(UUIButtonComponent));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(4, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(5, typeof(UUIExtendToggle));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(6, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(7, typeof(UUIItem));
			num2++;
			*span[num2] = new ValueTuple<int, Type>(8, typeof(UUIItem));
			this.ComponentRegisterInfos = list;
			num2 = 3;
			List<ValueTuple<int, Delegate>> list2 = new List<ValueTuple<int, Delegate>>(num2);
			CollectionsMarshal.SetCount<ValueTuple<int, Delegate>>(list2, num2);
			Span<ValueTuple<int, Delegate>> span2 = CollectionsMarshal.AsSpan<ValueTuple<int, Delegate>>(list2);
			num = 0;
			*span2[num] = new ValueTuple<int, Delegate>(3, new Action(this.OnRoleSelectButtonClick));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(4, new Action<EToggleState>(delegate(EToggleState _)
			{
				this.OnWeaponTabToggleClick();
			}));
			num++;
			*span2[num] = new ValueTuple<int, Delegate>(5, new Action<EToggleState>(delegate(EToggleState _)
			{
				this.OnAttributeTabToggleClick();
			}));
			this.BtnBindInfo = list2;
		}

		// Token: 0x0603FD24 RID: 261412 RVA: 0x00F70B70 File Offset: 0x00F6ED70
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD25 RID: 261413 RVA: 0x00F70BB4 File Offset: 0x00F6EDB4
		protected override void OnBeforeShow()
		{
			if (this.SelectedTabIndex == EPinballRoleTabIndex.None)
			{
				this.SelectTab(EPinballRoleTabIndex.RoleAttribute);
			}
			else
			{
				UiTabViewBase currentTabView = this.TabViewComponent.GetCurrentTabView();
				if (currentTabView != null)
				{
					((IPinballRoleTabViewRefresh)currentTabView).RefreshView();
				}
			}
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(PinballModel.Instance.GetWeaponRedDot(this.Proxy.GetActivityData().Id, this.Proxy.GetSelectedRoleId()));
		}

		// Token: 0x0603FD26 RID: 261414 RVA: 0x00F70C24 File Offset: 0x00F6EE24
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			PinballRoleView.<OnBeforeShowAsyncImplementImplement>d__14 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<PinballRoleView.<OnBeforeShowAsyncImplementImplement>d__14>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x0603FD27 RID: 261415 RVA: 0x00F70C67 File Offset: 0x00F6EE67
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPinballRoleLevelUp, new Action<int, int, int>(this.OnPinballRoleLevelUp));
		}

		// Token: 0x0603FD28 RID: 261416 RVA: 0x00F70C85 File Offset: 0x00F6EE85
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPinballRoleLevelUp, new Action<int, int, int>(this.OnPinballRoleLevelUp));
		}

		// Token: 0x0603FD29 RID: 261417 RVA: 0x00F70CA4 File Offset: 0x00F6EEA4
		private void BuildRoleHeadItemDataList()
		{
			if (this.Proxy == null)
			{
				return;
			}
			this.RoleHeadItemDataList.Clear();
			int selectedRoleId = this.Proxy.GetSelectedRoleId();
			foreach (PinballRoleDataBase pinballRoleDataBase in this.Proxy.GetRoleDataList())
			{
				PinballRoleHeadItemData item = new PinballRoleHeadItemData
				{
					RoleConfig = pinballRoleDataBase.GetConfig(),
					IsSelected = (pinballRoleDataBase.GetId() == selectedRoleId),
					IsLocked = pinballRoleDataBase.IsLocked(),
					IsTrail = false,
					NeedRedDot = true
				};
				this.RoleHeadItemDataList.Add(item);
			}
		}

		// Token: 0x0603FD2A RID: 261418 RVA: 0x00F70D5C File Offset: 0x00F6EF5C
		private void SelectDefaultRoleWhenNoSelected()
		{
			if (this.Proxy == null || this.RoleHeadItemDataList.Count == 0 || this.Proxy.GetSelectedRoleId() != 0)
			{
				return;
			}
			IPinballRoleViewOpenParam openParam = this.GetOpenParam();
			int selectedRole = ((openParam != null) ? openParam.RoleId : null) ?? this.RoleHeadItemDataList[0].RoleConfig.Id;
			this.SetSelectedRole(selectedRole);
		}

		// Token: 0x0603FD2B RID: 261419 RVA: 0x00F70DDC File Offset: 0x00F6EFDC
		private void SetSelectedRole(int roleId)
		{
			this.CancelSelectedRole();
			this.Proxy.SetSelectedRoleDataById(roleId);
			this.RoleHeadItemDataList[this.Proxy.GetSelectedRoleIndex()].IsSelected = true;
			PinballController instance = PinballController.Instance;
			if (instance != null)
			{
				instance.CheckToSetRoleRedDotAsRead(this.Proxy.GetActivityData().Id, roleId);
			}
			UUIItem item = base.GetItem(8);
			if (item == null)
			{
				return;
			}
			item.SetUIActive(PinballModel.Instance.GetWeaponRedDot(this.Proxy.GetActivityData().Id, roleId));
		}

		// Token: 0x0603FD2C RID: 261420 RVA: 0x00F70E68 File Offset: 0x00F6F068
		private void CancelSelectedRole()
		{
			if (this.Proxy == null || this.Proxy.GetSelectedRoleIndex() < 0 || this.Proxy.GetSelectedRoleIndex() >= this.RoleHeadItemDataList.Count)
			{
				return;
			}
			this.RoleHeadItemDataList[this.Proxy.GetSelectedRoleIndex()].IsSelected = false;
		}

		// Token: 0x0603FD2D RID: 261421 RVA: 0x00F70EC0 File Offset: 0x00F6F0C0
		private void SelectRole(int roleId)
		{
			if (this.Proxy == null)
			{
				return;
			}
			int selectedRoleIndex = this.Proxy.GetSelectedRoleIndex();
			this.SetSelectedRole(roleId);
			this.RoleHeadItemLoopScrollView.RefreshGridProxy(selectedRoleIndex);
			this.RoleHeadItemLoopScrollView.RefreshGridProxy(this.Proxy.GetSelectedRoleIndex());
			this.RoleSpineItem.RefreshRole(this.Proxy.GetSelectedRoleId(), "Idle_Fight", true);
			UiTabViewBase currentTabView = this.TabViewComponent.GetCurrentTabView();
			if (currentTabView != null)
			{
				((IPinballRoleTabViewRoleChange)currentTabView).RefreshByRoleChange();
			}
		}

		// Token: 0x0603FD2E RID: 261422 RVA: 0x00F70F44 File Offset: 0x00F6F144
		private void SelectTab(EPinballRoleTabIndex tabIndex)
		{
			if (tabIndex == this.SelectedTabIndex)
			{
				return;
			}
			EPinballRoleTabIndex selectedTabIndex = this.SelectedTabIndex;
			this.SelectedTabIndex = tabIndex;
			if (selectedTabIndex != EPinballRoleTabIndex.None)
			{
				this.TabToggleList[(int)selectedTabIndex].SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
			}
			this.TabToggleList[(int)tabIndex].SetToggleState(EToggleState.ETT_Checked, false, false, false);
			this.TabViewComponent.ToggleCallBack(this.Proxy.GetSelectedRoleIndex(), this.TabViewNameList[(int)tabIndex], null, this.Proxy, null);
		}

		// Token: 0x0603FD2F RID: 261423 RVA: 0x00F70FCB File Offset: 0x00F6F1CB
		[NullableContext(2)]
		private IPinballRoleViewOpenParam GetOpenParam()
		{
			return this.OpenParam as IPinballRoleViewOpenParam;
		}

		// Token: 0x0603FD30 RID: 261424 RVA: 0x00F70FD8 File Offset: 0x00F6F1D8
		private void OnRoleSelectButtonClick()
		{
			if (this.Proxy == null)
			{
				return;
			}
			PinballRoleSelectViewOpenData pinballRoleSelectViewOpenData = new PinballRoleSelectViewOpenData();
			pinballRoleSelectViewOpenData.ActivityData = this.Proxy.GetActivityData();
			pinballRoleSelectViewOpenData.SelectedRoleId = this.Proxy.GetSelectedRoleId();
			pinballRoleSelectViewOpenData.RoleDataList = this.Proxy.GetRoleDataList();
			IPinballRoleViewOpenParam openParam = this.GetOpenParam();
			pinballRoleSelectViewOpenData.FormationRoleIds = ((openParam != null) ? openParam.FormationRoleIds : null);
			pinballRoleSelectViewOpenData.OnSelectConfirm = new Action<int>(this.OnRoleSelectConfirm);
			PinballRoleSelectViewOpenData param = pinballRoleSelectViewOpenData;
			UiManager.Instance.OpenView(EUiViewName.PinballRoleSelectView, param, null);
		}

		// Token: 0x0603FD31 RID: 261425 RVA: 0x00F71062 File Offset: 0x00F6F262
		private void OnRoleSelectConfirm(int roleId)
		{
			this.SetSelectedRole(roleId);
		}

		// Token: 0x0603FD32 RID: 261426 RVA: 0x00F7106B File Offset: 0x00F6F26B
		private PinballRoleHeadItem CreateRoleHeadItem()
		{
			return new PinballRoleHeadItem
			{
				OnSelectCallBack = new Action<IPinballRoleHeadItemData>(this.OnRoleHeadItemSelect)
			};
		}

		// Token: 0x0603FD33 RID: 261427 RVA: 0x00F71084 File Offset: 0x00F6F284
		private void OnRoleHeadItemSelect(IPinballRoleHeadItemData data)
		{
			this.SelectRole(data.RoleConfig.Id);
		}

		// Token: 0x0603FD34 RID: 261428 RVA: 0x00F710A5 File Offset: 0x00F6F2A5
		private void OnWeaponTabToggleClick()
		{
			this.SelectTab(EPinballRoleTabIndex.Weapon);
		}

		// Token: 0x0603FD35 RID: 261429 RVA: 0x00F710AE File Offset: 0x00F6F2AE
		private void OnAttributeTabToggleClick()
		{
			this.SelectTab(EPinballRoleTabIndex.RoleAttribute);
		}

		// Token: 0x0603FD36 RID: 261430 RVA: 0x00F710B8 File Offset: 0x00F6F2B8
		private void OnPinballRoleLevelUp(int activityId, int roleId, int addLevel)
		{
			if (roleId != this.Proxy.GetSelectedRoleId())
			{
				return;
			}
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.PlayOrReplaySequenceByName("LevelUp", false, null);
		}

		// Token: 0x0603FD37 RID: 261431 RVA: 0x00F710F3 File Offset: 0x00F6F2F3
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x040214D8 RID: 136408
		[Nullable(2)]
		protected PinballRoleViewProxy Proxy;

		// Token: 0x040214D9 RID: 136409
		private EPinballRoleTabIndex SelectedTabIndex = EPinballRoleTabIndex.None;

		// Token: 0x040214DA RID: 136410
		private readonly List<IPinballRoleHeadItemData> RoleHeadItemDataList = new List<IPinballRoleHeadItemData>();

		// Token: 0x040214DB RID: 136411
		[Nullable(2)]
		protected PinballRoleSpineItem RoleSpineItem;

		// Token: 0x040214DC RID: 136412
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PinballRoleHeadItem, IPinballRoleHeadItemData> RoleHeadItemLoopScrollView;

		// Token: 0x040214DD RID: 136413
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x040214DE RID: 136414
		[Nullable(2)]
		protected TabViewComponent<int> TabViewComponent;

		// Token: 0x040214DF RID: 136415
		private readonly List<UUIExtendToggle> TabToggleList = new List<UUIExtendToggle>();

		// Token: 0x040214E0 RID: 136416
		private readonly List<EUiTabViewName> TabViewNameList = new List<EUiTabViewName>();

		// Token: 0x0200C512 RID: 50450
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x0403B793 RID: 243603
			CaptionItem,
			// Token: 0x0403B794 RID: 243604
			RoleHeadLoopScrollView,
			// Token: 0x0403B795 RID: 243605
			RoleHeadItem,
			// Token: 0x0403B796 RID: 243606
			RoleSelectButton,
			// Token: 0x0403B797 RID: 243607
			WeaponTabToggle,
			// Token: 0x0403B798 RID: 243608
			AttributeTabToggle,
			// Token: 0x0403B799 RID: 243609
			RoleSpineItem,
			// Token: 0x0403B79A RID: 243610
			ContentRootItem,
			// Token: 0x0403B79B RID: 243611
			RedDotWeapon
		}
	}
}
