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
	// Token: 0x02005296 RID: 21142
	[NullableContext(1)]
	[Nullable(0)]
	public class PinballRoleView : UiViewBase
	{
		// Token: 0x060349E3 RID: 215523 RVA: 0x00EB78C7 File Offset: 0x00EB5AC7
		public PinballRoleView(UiViewInfo info) : base(info)
		{
		}

		// Token: 0x060349E4 RID: 215524 RVA: 0x00EB78F8 File Offset: 0x00EB5AF8
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

		// Token: 0x060349E5 RID: 215525 RVA: 0x00EB7ACC File Offset: 0x00EB5CCC
		protected override UniTask OnBeforeStartAsync()
		{
			PinballRoleView.<OnBeforeStartAsync>d__12 <OnBeforeStartAsync>d__;
			<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeStartAsync>d__.<>4__this = this;
			<OnBeforeStartAsync>d__.<>1__state = -1;
			<OnBeforeStartAsync>d__.<>t__builder.Start<PinballRoleView.<OnBeforeStartAsync>d__12>(ref <OnBeforeStartAsync>d__);
			return <OnBeforeStartAsync>d__.<>t__builder.Task;
		}

		// Token: 0x060349E6 RID: 215526 RVA: 0x00EB7B10 File Offset: 0x00EB5D10
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

		// Token: 0x060349E7 RID: 215527 RVA: 0x00EB7B80 File Offset: 0x00EB5D80
		protected override UniTask OnBeforeShowAsyncImplementImplement()
		{
			PinballRoleView.<OnBeforeShowAsyncImplementImplement>d__14 <OnBeforeShowAsyncImplementImplement>d__;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<OnBeforeShowAsyncImplementImplement>d__.<>4__this = this;
			<OnBeforeShowAsyncImplementImplement>d__.<>1__state = -1;
			<OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Start<PinballRoleView.<OnBeforeShowAsyncImplementImplement>d__14>(ref <OnBeforeShowAsyncImplementImplement>d__);
			return <OnBeforeShowAsyncImplementImplement>d__.<>t__builder.Task;
		}

		// Token: 0x060349E8 RID: 215528 RVA: 0x00EB7BC3 File Offset: 0x00EB5DC3
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnPinballRoleLevelUp, new Action<int, int, int>(this.OnPinballRoleLevelUp));
		}

		// Token: 0x060349E9 RID: 215529 RVA: 0x00EB7BE1 File Offset: 0x00EB5DE1
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnPinballRoleLevelUp, new Action<int, int, int>(this.OnPinballRoleLevelUp));
		}

		// Token: 0x060349EA RID: 215530 RVA: 0x00EB7C00 File Offset: 0x00EB5E00
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

		// Token: 0x060349EB RID: 215531 RVA: 0x00EB7CB8 File Offset: 0x00EB5EB8
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

		// Token: 0x060349EC RID: 215532 RVA: 0x00EB7D38 File Offset: 0x00EB5F38
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

		// Token: 0x060349ED RID: 215533 RVA: 0x00EB7DC4 File Offset: 0x00EB5FC4
		private void CancelSelectedRole()
		{
			if (this.Proxy == null || this.Proxy.GetSelectedRoleIndex() < 0 || this.Proxy.GetSelectedRoleIndex() >= this.RoleHeadItemDataList.Count)
			{
				return;
			}
			this.RoleHeadItemDataList[this.Proxy.GetSelectedRoleIndex()].IsSelected = false;
		}

		// Token: 0x060349EE RID: 215534 RVA: 0x00EB7E1C File Offset: 0x00EB601C
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

		// Token: 0x060349EF RID: 215535 RVA: 0x00EB7EA0 File Offset: 0x00EB60A0
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

		// Token: 0x060349F0 RID: 215536 RVA: 0x00EB7F27 File Offset: 0x00EB6127
		[NullableContext(2)]
		private IPinballRoleViewOpenParam GetOpenParam()
		{
			return this.OpenParam as IPinballRoleViewOpenParam;
		}

		// Token: 0x060349F1 RID: 215537 RVA: 0x00EB7F34 File Offset: 0x00EB6134
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

		// Token: 0x060349F2 RID: 215538 RVA: 0x00EB7FBE File Offset: 0x00EB61BE
		private void OnRoleSelectConfirm(int roleId)
		{
			this.SetSelectedRole(roleId);
		}

		// Token: 0x060349F3 RID: 215539 RVA: 0x00EB7FC7 File Offset: 0x00EB61C7
		private PinballRoleHeadItem CreateRoleHeadItem()
		{
			return new PinballRoleHeadItem
			{
				OnSelectCallBack = new Action<IPinballRoleHeadItemData>(this.OnRoleHeadItemSelect)
			};
		}

		// Token: 0x060349F4 RID: 215540 RVA: 0x00EB7FE0 File Offset: 0x00EB61E0
		private void OnRoleHeadItemSelect(IPinballRoleHeadItemData data)
		{
			this.SelectRole(data.RoleConfig.Id);
		}

		// Token: 0x060349F5 RID: 215541 RVA: 0x00EB8001 File Offset: 0x00EB6201
		private void OnWeaponTabToggleClick()
		{
			this.SelectTab(EPinballRoleTabIndex.Weapon);
		}

		// Token: 0x060349F6 RID: 215542 RVA: 0x00EB800A File Offset: 0x00EB620A
		private void OnAttributeTabToggleClick()
		{
			this.SelectTab(EPinballRoleTabIndex.RoleAttribute);
		}

		// Token: 0x060349F7 RID: 215543 RVA: 0x00EB8014 File Offset: 0x00EB6214
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

		// Token: 0x060349F8 RID: 215544 RVA: 0x00EB804F File Offset: 0x00EB624F
		private void OnCloseBtnClick()
		{
			base.CloseMe(null);
		}

		// Token: 0x0401BE07 RID: 114183
		[Nullable(2)]
		protected PinballRoleViewProxy Proxy;

		// Token: 0x0401BE08 RID: 114184
		private EPinballRoleTabIndex SelectedTabIndex = EPinballRoleTabIndex.None;

		// Token: 0x0401BE09 RID: 114185
		private readonly List<IPinballRoleHeadItemData> RoleHeadItemDataList = new List<IPinballRoleHeadItemData>();

		// Token: 0x0401BE0A RID: 114186
		[Nullable(2)]
		protected PinballRoleSpineItem RoleSpineItem;

		// Token: 0x0401BE0B RID: 114187
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private LoopScrollView<PinballRoleHeadItem, IPinballRoleHeadItemData> RoleHeadItemLoopScrollView;

		// Token: 0x0401BE0C RID: 114188
		[Nullable(2)]
		private PopupCaptionItem CaptionItem;

		// Token: 0x0401BE0D RID: 114189
		[Nullable(2)]
		protected TabViewComponent<int> TabViewComponent;

		// Token: 0x0401BE0E RID: 114190
		private readonly List<UUIExtendToggle> TabToggleList = new List<UUIExtendToggle>();

		// Token: 0x0401BE0F RID: 114191
		private readonly List<EUiTabViewName> TabViewNameList = new List<EUiTabViewName>();

		// Token: 0x0200AEF9 RID: 44793
		[NullableContext(0)]
		private enum EComponent
		{
			// Token: 0x040360F5 RID: 221429
			CaptionItem,
			// Token: 0x040360F6 RID: 221430
			RoleHeadLoopScrollView,
			// Token: 0x040360F7 RID: 221431
			RoleHeadItem,
			// Token: 0x040360F8 RID: 221432
			RoleSelectButton,
			// Token: 0x040360F9 RID: 221433
			WeaponTabToggle,
			// Token: 0x040360FA RID: 221434
			AttributeTabToggle,
			// Token: 0x040360FB RID: 221435
			RoleSpineItem,
			// Token: 0x040360FC RID: 221436
			ContentRootItem,
			// Token: 0x040360FD RID: 221437
			RedDotWeapon
		}
	}
}
