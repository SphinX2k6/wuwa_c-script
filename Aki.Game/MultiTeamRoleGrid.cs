using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C70 RID: 7280
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MultiTeamRoleGrid : GridProxyAbstract<MultiTeamRoleGridContentData>
{
	// Token: 0x060120FE RID: 73982 RVA: 0x0054F8EC File Offset: 0x0054DAEC
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x060120FF RID: 73983 RVA: 0x0054F946 File Offset: 0x0054DB46
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<RoleGrid, RoleGridContentData>(base.GetGridLayout(1), new Func<RoleGrid>(this.CreateItem), null, false, true);
		this.Layout.GetUiAnimController().PlayFromIndex = 1;
	}

	// Token: 0x06012100 RID: 73984 RVA: 0x0054F97A File Offset: 0x0054DB7A
	private RoleGrid CreateItem()
	{
		return new RoleGrid();
	}

	// Token: 0x06012101 RID: 73985 RVA: 0x0054F984 File Offset: 0x0054DB84
	public override void Refresh(MultiTeamRoleGridContentData data, bool isSelected, int gridIndex)
	{
		if (data.Data == null)
		{
			return;
		}
		base.GetText(0).ShowTextNew(data.Data.GetTitle());
		List<MultiTeamRoleGridData> showMultiTeamRoleGridDataList = data.Data.GetShowMultiTeamRoleGridDataList();
		List<RoleGridContentData> list = new List<RoleGridContentData>();
		foreach (MultiTeamRoleGridData multiTeamRoleGridData in showMultiTeamRoleGridDataList)
		{
			list.Add(new RoleGridContentData
			{
				Data = multiTeamRoleGridData,
				CurrentSelectedRoleList = data.CurrentSelectedRoleList,
				IsSingleSelect = data.IsSingleSelect,
				CurrentTagBranchId = data.CurrentSelectTagMap.GetValueOrNull(multiTeamRoleGridData.GetRole().GetDataId()).GetValueOrDefault(-1),
				OnToggleCallBack = data.OnToggleCallBack,
				CanExecuteChangeCallBack = data.CanExecuteChangeCallBack
			});
		}
		this.Layout.RefreshByData(list, null, data.ShowGridAnimation);
	}

	// Token: 0x04009D6F RID: 40303
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleGrid, RoleGridContentData> Layout;

	// Token: 0x02007F74 RID: 32628
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x040293CA RID: 168906
		TitleText,
		// Token: 0x040293CB RID: 168907
		Layout,
		// Token: 0x040293CC RID: 168908
		GridItem
	}
}
