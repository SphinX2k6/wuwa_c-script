using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Protocol;
using CSharpScript.Game.Module.Util;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002766 RID: 10086
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class RogueBattleBuyRoleGroupItem : GridProxyAbstract<RoleBuyInfoGroupData>
{
	// Token: 0x06014AFB RID: 84731 RVA: 0x0053BF14 File Offset: 0x0053A114
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIItem)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x06014AFC RID: 84732 RVA: 0x0053BF50 File Offset: 0x0053A150
	protected override UniTask OnBeforeStartAsync()
	{
		RogueBattleBuyRoleGroupItem.<OnBeforeStartAsync>d__5 <OnBeforeStartAsync>d__;
		<OnBeforeStartAsync>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<OnBeforeStartAsync>d__.<>4__this = this;
		<OnBeforeStartAsync>d__.<>1__state = -1;
		<OnBeforeStartAsync>d__.<>t__builder.Start<RogueBattleBuyRoleGroupItem.<OnBeforeStartAsync>d__5>(ref <OnBeforeStartAsync>d__);
		return <OnBeforeStartAsync>d__.<>t__builder.Task;
	}

	// Token: 0x06014AFD RID: 84733 RVA: 0x0053BF94 File Offset: 0x0053A194
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

	// Token: 0x06014AFE RID: 84734 RVA: 0x0053BFF5 File Offset: 0x0053A1F5
	private RogueBattleBuyRoleItem GetRoleItem(int index)
	{
		if (index % 2 != 0)
		{
			return this.RoleItem2;
		}
		return this.RoleItem1;
	}

	// Token: 0x06014AFF RID: 84735 RVA: 0x0053C009 File Offset: 0x0053A209
	public void Select(int index)
	{
		this.GetRoleItem(index).OnSelected();
	}

	// Token: 0x06014B00 RID: 84736 RVA: 0x0053C017 File Offset: 0x0053A217
	public void Deselect(int index)
	{
		this.GetRoleItem(index).OnDeselected();
	}

	// Token: 0x06014B01 RID: 84737 RVA: 0x0053C025 File Offset: 0x0053A225
	[NullableContext(2)]
	public UUIItem GetRoleUiItem(int index)
	{
		return this.GetRoleItem(index).GetOriginalItem();
	}

	// Token: 0x06014B02 RID: 84738 RVA: 0x0053C033 File Offset: 0x0053A233
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

	// Token: 0x04009B6F RID: 39791
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, RogueResGainData> OnSelectCallback;

	// Token: 0x04009B70 RID: 39792
	[Nullable(2)]
	public Func<int, bool> IsSelectOn;

	// Token: 0x04009B71 RID: 39793
	private RogueBattleBuyRoleItem RoleItem1;

	// Token: 0x04009B72 RID: 39794
	private RogueBattleBuyRoleItem RoleItem2;
}
