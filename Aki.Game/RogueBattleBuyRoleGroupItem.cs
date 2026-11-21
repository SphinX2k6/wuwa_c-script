using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02001C51 RID: 7249
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RogueBattleBuyRoleGroupItem : GridProxyAbstract<RoleBuyInfoGroupData>
{
	// Token: 0x06011FDE RID: 73694 RVA: 0x0054AD24 File Offset: 0x00548F24
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06011FDF RID: 73695 RVA: 0x0054AD60 File Offset: 0x00548F60
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleBuyRoleGroupItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleBuyRoleGroupItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06011FE0 RID: 73696 RVA: 0x0054ADA4 File Offset: 0x00548FA4
	public override void Refresh(RoleBuyInfoGroupData data, bool isSelected, int gridIndex)
	{
		int num = gridIndex * 2;
		int num2 = gridIndex * 2 + 1;
		RogueBattleBuyRoleItem roleItem = this.RoleItem1;
		RogueResGainData data2 = data.Data1;
		Func<int, bool> isSelectOn = this.IsSelectOn;
		roleItem.Refresh(data2, isSelectOn != null && isSelectOn(num), num);
		RogueBattleBuyRoleItem roleItem2 = this.RoleItem2;
		RogueResGainData data3 = data.Data2;
		Func<int, bool> isSelectOn2 = this.IsSelectOn;
		roleItem2.Refresh(data3, isSelectOn2 != null && isSelectOn2(num2), num2);
	}

	// Token: 0x06011FE1 RID: 73697 RVA: 0x0054AE05 File Offset: 0x00549005
	private RogueBattleBuyRoleItem GetRoleItem(int index)
	{
		if (index % 2 != 0)
		{
			return this.RoleItem2;
		}
		return this.RoleItem1;
	}

	// Token: 0x06011FE2 RID: 73698 RVA: 0x0054AE19 File Offset: 0x00549019
	public void Select(int index)
	{
		this.GetRoleItem(index).OnSelected();
	}

	// Token: 0x06011FE3 RID: 73699 RVA: 0x0054AE27 File Offset: 0x00549027
	public void Deselect(int index)
	{
		this.GetRoleItem(index).OnDeselected();
	}

	// Token: 0x06011FE4 RID: 73700 RVA: 0x0054AE35 File Offset: 0x00549035
	[NullableContext(2)]
	public UUIItem GetRoleUiItem(int index)
	{
		return this.GetRoleItem(index).GetOriginalItem();
	}

	// Token: 0x06011FE5 RID: 73701 RVA: 0x0054AE43 File Offset: 0x00549043
	[return: Nullable(new byte[]
	{
		2,
		1
	})]
	public override UUIItem[] GetGuideUiItemAndUiItemForShowEx(string[] configParams)
	{
		if (configParams.Length == 0)
		{
			return null;
		}
		if (!(configParams[0] == "FirstRole"))
		{
			return null;
		}
		RogueBattleBuyRoleItem roleItem = this.GetRoleItem(0);
		if (roleItem == null)
		{
			return null;
		}
		return roleItem.GetGuideUiItemAndUiItemForShowEx(configParams);
	}

	// Token: 0x04009CC7 RID: 40135
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, RogueResGainData> OnSelectCallback;

	// Token: 0x04009CC8 RID: 40136
	[Nullable(2)]
	public Func<int, bool> IsSelectOn;

	// Token: 0x04009CC9 RID: 40137
	private RogueBattleBuyRoleItem RoleItem1;

	// Token: 0x04009CCA RID: 40138
	private RogueBattleBuyRoleItem RoleItem2;
}
