using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020013C7 RID: 5063
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerSupportTrialRoleListComponent : UiPanelBase
{
	// Token: 0x06008EE1 RID: 36577 RVA: 0x001ED96D File Offset: 0x001EBB6D
	public NewPlayerSupportTrialRoleListComponent(NewPlayerSupportTrialRoleViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06008EE2 RID: 36578 RVA: 0x001ED988 File Offset: 0x001EBB88
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem)),
			new ValueTuple<int, Type>(3, typeof(UUIItem)),
			new ValueTuple<int, Type>(4, typeof(UUIItem)),
			new ValueTuple<int, Type>(5, typeof(UUIItem)),
			new ValueTuple<int, Type>(6, typeof(UUIItem)),
			new ValueTuple<int, Type>(7, typeof(UUIItem)),
			new ValueTuple<int, Type>(8, typeof(UUIItem))
		};
	}

	// Token: 0x06008EE3 RID: 36579 RVA: 0x001EDA68 File Offset: 0x001EBC68
	protected override UniTask OnBeforeStartAsync()
	{
		NewPlayerSupportTrialRoleListComponent.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewPlayerSupportTrialRoleListComponent.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008EE4 RID: 36580 RVA: 0x001EDAAC File Offset: 0x001EBCAC
	private UniTask CreateRoleItem(UUIItem parent, TrialRoleGroupData trialRoleData)
	{
		NewPlayerSupportTrialRoleListComponent.<CreateRoleItem>d__9 <CreateRoleItem>d__;
		<CreateRoleItem>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateRoleItem>d__.<>4__this = this;
		<CreateRoleItem>d__.parent = parent;
		<CreateRoleItem>d__.trialRoleData = trialRoleData;
		<CreateRoleItem>d__.<>1__state = -1;
		<CreateRoleItem>d__.<>t__builder.Start<NewPlayerSupportTrialRoleListComponent.<CreateRoleItem>d__9>(ref <CreateRoleItem>d__);
		return <CreateRoleItem>d__.<>t__builder.Task;
	}

	// Token: 0x06008EE5 RID: 36581 RVA: 0x001EDB00 File Offset: 0x001EBD00
	private void OnSelectRoleItem(NewPlayerSupportTrialRoleListItem roleItem, int groupId)
	{
		if (this.CurSelectRoleItem != null)
		{
			this.CurSelectRoleItem.SetSelected(false);
		}
		roleItem.SetSelected(true);
		this.CurSelectRoleItem = roleItem;
		Action<int> selectRoleItemCallback = this.SelectRoleItemCallback;
		if (selectRoleItemCallback != null)
		{
			selectRoleItemCallback(groupId);
		}
		EventSystem.Instance.Emit(EEventName.OnGroupTrialRoleRedDotUpdate);
	}

	// Token: 0x06008EE6 RID: 36582 RVA: 0x001EDB51 File Offset: 0x001EBD51
	private bool CanSelectRoleItem()
	{
		return this.CanSelectRoleItemCallback == null || this.CanSelectRoleItemCallback();
	}

	// Token: 0x06008EE7 RID: 36583 RVA: 0x001EDB68 File Offset: 0x001EBD68
	public void RefreshDefaultSelected(int? selectedGroupId = null)
	{
		NewPlayerSupportTrialRoleListComponent.<>c__DisplayClass12_0 CS$<>8__locals1 = new NewPlayerSupportTrialRoleListComponent.<>c__DisplayClass12_0();
		TrialRoleGroupData trialRoleGroupData = this.ViewModel.CurUseTrialRoleGroupData();
		NewPlayerSupportTrialRoleListComponent.<>c__DisplayClass12_0 CS$<>8__locals2 = CS$<>8__locals1;
		int? num = selectedGroupId;
		CS$<>8__locals2.groupId = ((num != null) ? num : ((trialRoleGroupData != null) ? new int?(trialRoleGroupData.TrialRoleGroupId) : null));
		List<TrialRoleGroupData> list = this.ViewModel.GetTrialRoleList() ?? new List<TrialRoleGroupData>();
		int num2 = -1;
		if (CS$<>8__locals1.groupId != null)
		{
			num2 = list.FindIndex((TrialRoleGroupData data) => data.TrialRoleGroupId == CS$<>8__locals1.groupId.Value);
		}
		if (num2 < 0)
		{
			num2 = list.FindIndex((TrialRoleGroupData data) => data.IsUnlocked());
		}
		if (num2 < 0)
		{
			num2 = 0;
		}
		NewPlayerSupportTrialRoleListItem newPlayerSupportTrialRoleListItem = (this.RoleItemList != null && num2 >= 0 && num2 < this.RoleItemList.Count) ? this.RoleItemList[num2] : null;
		if (newPlayerSupportTrialRoleListItem != null)
		{
			newPlayerSupportTrialRoleListItem.SelectItem();
		}
	}

	// Token: 0x06008EE8 RID: 36584 RVA: 0x001EDC54 File Offset: 0x001EBE54
	public void SetSelectRoleItemCallback(Action<int> callback)
	{
		this.SelectRoleItemCallback = callback;
	}

	// Token: 0x06008EE9 RID: 36585 RVA: 0x001EDC5D File Offset: 0x001EBE5D
	public void SetCanSelectRoleItemCallback(Func<bool> callback)
	{
		this.CanSelectRoleItemCallback = callback;
	}

	// Token: 0x04003F2C RID: 16172
	private readonly List<NewPlayerSupportTrialRoleListItem> RoleItemList = new List<NewPlayerSupportTrialRoleListItem>();

	// Token: 0x04003F2D RID: 16173
	[Nullable(2)]
	private NewPlayerSupportTrialRoleListItem CurSelectRoleItem;

	// Token: 0x04003F2E RID: 16174
	[Nullable(2)]
	private Action<int> SelectRoleItemCallback;

	// Token: 0x04003F2F RID: 16175
	[Nullable(2)]
	private Func<bool> CanSelectRoleItemCallback;

	// Token: 0x04003F30 RID: 16176
	[Nullable(2)]
	private NewPlayerSupportTrialRoleViewModel ViewModel;

	// Token: 0x02007A48 RID: 31304
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x040283FA RID: 164858
		public const int RoleItem1 = 0;

		// Token: 0x040283FB RID: 164859
		public const int RoleItem2 = 1;

		// Token: 0x040283FC RID: 164860
		public const int RoleItem3 = 2;

		// Token: 0x040283FD RID: 164861
		public const int RoleItem4 = 3;

		// Token: 0x040283FE RID: 164862
		public const int RoleItem5 = 4;

		// Token: 0x040283FF RID: 164863
		public const int RoleItem6 = 5;

		// Token: 0x04028400 RID: 164864
		public const int RoleItem7 = 6;

		// Token: 0x04028401 RID: 164865
		public const int RoleItem8 = 7;

		// Token: 0x04028402 RID: 164866
		public const int RoleItem9 = 8;
	}
}
