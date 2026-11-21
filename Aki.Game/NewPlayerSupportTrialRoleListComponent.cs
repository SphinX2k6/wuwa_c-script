using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x0200087B RID: 2171
[NullableContext(1)]
[Nullable(0)]
public class NewPlayerSupportTrialRoleListComponent : UiPanelBase
{
	// Token: 0x06006276 RID: 25206 RVA: 0x001F648D File Offset: 0x001F468D
	public NewPlayerSupportTrialRoleListComponent(NewPlayerSupportTrialRoleViewModel viewModel)
	{
		this.ViewModel = viewModel;
	}

	// Token: 0x06006277 RID: 25207 RVA: 0x001F64A8 File Offset: 0x001F46A8
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

	// Token: 0x06006278 RID: 25208 RVA: 0x001F6588 File Offset: 0x001F4788
	protected override UniTask OnBeforeStartAsync()
	{
		NewPlayerSupportTrialRoleListComponent.<OnBeforeStartAsync>d__8 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<NewPlayerSupportTrialRoleListComponent.<OnBeforeStartAsync>d__8>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06006279 RID: 25209 RVA: 0x001F65CC File Offset: 0x001F47CC
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

	// Token: 0x0600627A RID: 25210 RVA: 0x001F6620 File Offset: 0x001F4820
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

	// Token: 0x0600627B RID: 25211 RVA: 0x001F6671 File Offset: 0x001F4871
	private bool CanSelectRoleItem()
	{
		return this.CanSelectRoleItemCallback == null || this.CanSelectRoleItemCallback();
	}

	// Token: 0x0600627C RID: 25212 RVA: 0x001F6688 File Offset: 0x001F4888
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

	// Token: 0x0600627D RID: 25213 RVA: 0x001F6774 File Offset: 0x001F4974
	public void SetSelectRoleItemCallback(Action<int> callback)
	{
		this.SelectRoleItemCallback = callback;
	}

	// Token: 0x0600627E RID: 25214 RVA: 0x001F677D File Offset: 0x001F497D
	public void SetCanSelectRoleItemCallback(Func<bool> callback)
	{
		this.CanSelectRoleItemCallback = callback;
	}

	// Token: 0x04003FC4 RID: 16324
	private readonly List<NewPlayerSupportTrialRoleListItem> RoleItemList = new List<NewPlayerSupportTrialRoleListItem>();

	// Token: 0x04003FC5 RID: 16325
	[Nullable(2)]
	private NewPlayerSupportTrialRoleListItem CurSelectRoleItem;

	// Token: 0x04003FC6 RID: 16326
	[Nullable(2)]
	private Action<int> SelectRoleItemCallback;

	// Token: 0x04003FC7 RID: 16327
	[Nullable(2)]
	private Func<bool> CanSelectRoleItemCallback;

	// Token: 0x04003FC8 RID: 16328
	[Nullable(2)]
	private NewPlayerSupportTrialRoleViewModel ViewModel;

	// Token: 0x02006BCE RID: 27598
	[NullableContext(0)]
	private static class EComponentType
	{
		// Token: 0x04023717 RID: 145175
		public const int RoleItem1 = 0;

		// Token: 0x04023718 RID: 145176
		public const int RoleItem2 = 1;

		// Token: 0x04023719 RID: 145177
		public const int RoleItem3 = 2;

		// Token: 0x0402371A RID: 145178
		public const int RoleItem4 = 3;

		// Token: 0x0402371B RID: 145179
		public const int RoleItem5 = 4;

		// Token: 0x0402371C RID: 145180
		public const int RoleItem6 = 5;

		// Token: 0x0402371D RID: 145181
		public const int RoleItem7 = 6;

		// Token: 0x0402371E RID: 145182
		public const int RoleItem8 = 7;

		// Token: 0x0402371F RID: 145183
		public const int RoleItem9 = 8;
	}
}
