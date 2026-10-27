using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001317 RID: 4887
[NullableContext(1)]
[Nullable(0)]
public class DelegationRoleModule : UiPanelBase
{
	// Token: 0x06008786 RID: 34694 RVA: 0x001CED80 File Offset: 0x001CCF80
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06008787 RID: 34695 RVA: 0x001CEDDC File Offset: 0x001CCFDC
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

	// Token: 0x06008788 RID: 34696 RVA: 0x001CEE28 File Offset: 0x001CD028
	protected override UniTask OnBeforeStartAsync()
	{
		DelegationRoleModule.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<DelegationRoleModule.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06008789 RID: 34697 RVA: 0x001CEE6B File Offset: 0x001CD06B
	private void OnClick()
	{
		Action onClickEvent = this.OnClickEvent;
		if (onClickEvent == null)
		{
			return;
		}
		onClickEvent();
	}

	// Token: 0x0600878A RID: 34698 RVA: 0x001CEE80 File Offset: 0x001CD080
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

	// Token: 0x0600878B RID: 34699 RVA: 0x001CEEDD File Offset: 0x001CD0DD
	[NullableContext(2)]
	public void SetClickEvent(Action onClickEvent)
	{
		this.OnClickEvent = onClickEvent;
	}

	// Token: 0x04003C73 RID: 15475
	protected List<DelegationRoleModuleRoleItem> RoleItemList = new List<DelegationRoleModuleRoleItem>();

	// Token: 0x04003C74 RID: 15476
	[Nullable(2)]
	protected Action OnClickEvent;

	// Token: 0x02007960 RID: 31072
	[NullableContext(0)]
	private static class EComponentDefine
	{
		// Token: 0x04027F9C RID: 163740
		public const int FirstRole = 0;

		// Token: 0x04027F9D RID: 163741
		public const int SecondRole = 1;

		// Token: 0x04027F9E RID: 163742
		public const int ThirdRole = 2;
	}
}
