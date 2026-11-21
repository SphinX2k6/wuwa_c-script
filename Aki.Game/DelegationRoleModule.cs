using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x020007CB RID: 1995
[NullableContext(1)]
[Nullable(0)]
public class DelegationRoleModule : UiPanelBase
{
	// Token: 0x06005B21 RID: 23329 RVA: 0x001D7BEC File Offset: 0x001D5DEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06005B22 RID: 23330 RVA: 0x001D7C48 File Offset: 0x001D5E48
	[return: Nullable(new byte[]
	{
		0,
		1
	})]
	private UniTask<DelegationRoleModuleRoleItem> CreateMediumItemGrid(UUIItem item)
	{
		DelegationRoleModule.<CreateMediumItemGrid>d__4 <CreateMediumItemGrid>d__;
		<CreateMediumItemGrid>d__.<>t__builder = AsyncUniTaskMethodBuilder<DelegationRoleModuleRoleItem>.Create();
		<CreateMediumItemGrid>d__.<>4__this = this;
		<CreateMediumItemGrid>d__.item = item;
		<CreateMediumItemGrid>d__.<>1__state = -1;
		<CreateMediumItemGrid>d__.<>t__builder.Start<DelegationRoleModule.<CreateMediumItemGrid>d__4>(ref <CreateMediumItemGrid>d__);
		return <CreateMediumItemGrid>d__.<>t__builder.Task;
	}

	// Token: 0x06005B23 RID: 23331 RVA: 0x001D7C94 File Offset: 0x001D5E94
	protected override UniTask OnBeforeStartAsync()
	{
		DelegationRoleModule.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DelegationRoleModule.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06005B24 RID: 23332 RVA: 0x001D7CD7 File Offset: 0x001D5ED7
	private void OnClick()
	{
		Action onClickEvent = this.OnClickEvent;
		if (onClickEvent == null)
		{
			return;
		}
		onClickEvent();
	}

	// Token: 0x06005B25 RID: 23333 RVA: 0x001D7CEC File Offset: 0x001D5EEC
	public void Refresh(OrderedSet<int> roleIdSet)
	{
		List<int> list = new List<int>(roleIdSet);
		for (int i = 0; i < this.RoleItemList.Count; i++)
		{
			DelegationRoleModuleRoleItem delegationRoleModuleRoleItem = this.RoleItemList[i];
			int? roleId = (i < list.Count) ? new int?(list[i]) : null;
			delegationRoleModuleRoleItem.Refresh(roleId);
		}
	}

	// Token: 0x06005B26 RID: 23334 RVA: 0x001D7D49 File Offset: 0x001D5F49
	[NullableContext(2)]
	public void SetClickEvent(Action onClickEvent)
	{
		this.OnClickEvent = onClickEvent;
	}

	// Token: 0x04003D0B RID: 15627
	protected List<DelegationRoleModuleRoleItem> RoleItemList = new List<DelegationRoleModuleRoleItem>();

	// Token: 0x04003D0C RID: 15628
	[Nullable(2)]
	protected Action OnClickEvent;

	// Token: 0x02006AEA RID: 27370
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x040232C9 RID: 144073
		public const int FirstRole = 0;

		// Token: 0x040232CA RID: 144074
		public const int SecondRole = 1;

		// Token: 0x040232CB RID: 144075
		public const int ThirdRole = 2;
	}
}
