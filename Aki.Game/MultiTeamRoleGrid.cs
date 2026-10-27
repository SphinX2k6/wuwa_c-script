using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Core.Extension;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002785 RID: 10117
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class MultiTeamRoleGrid : GridProxyAbstract<MultiTeamRoleGridContentData>
{
	// Token: 0x06014C1B RID: 85019 RVA: 0x00540A68 File Offset: 0x0053EC68
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIText)),
			new ValueTuple<int, Type>(1, typeof(UUIGridLayout)),
			new ValueTuple<int, Type>(2, typeof(UUIItem))
		};
	}

	// Token: 0x06014C1C RID: 85020 RVA: 0x00540AC2 File Offset: 0x0053ECC2
	protected override void OnStart()
	{
		this.Layout = new GenericLayout<RoleGrid, RoleGridContentData>(base.GetGridLayout(1), new Func<RoleGrid>(this.CreateItem), null, false, true);
		this.Layout.GetUiAnimController().PlayFromIndex = 1;
	}

	// Token: 0x06014C1D RID: 85021 RVA: 0x00540AF6 File Offset: 0x0053ECF6
	private RoleGrid CreateItem()
	{
		return new RoleGrid();
	}

	// Token: 0x06014C1E RID: 85022 RVA: 0x00540B00 File Offset: 0x0053ED00
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
				CurrentTagBranchId = data.CurrentSelectTagMap.GetValueOrNull(multiTeamRoleGridData.GetRole().GetDataId()).GetValueOrDefault(-1),
				OnToggleCallBack = data.OnToggleCallBack,
				CanExecuteChangeCallBack = data.CanExecuteChangeCallBack
			});
		}
		this.Layout.RefreshByData(list, null, data.ShowGridAnimation);
	}

	// Token: 0x04009C16 RID: 39958
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private GenericLayout<RoleGrid, RoleGridContentData> Layout;

	// Token: 0x02008DED RID: 36333
	[NullableContext(0)]
	private enum EComponents
	{
		// Token: 0x0402E0B6 RID: 188598
		TitleText,
		// Token: 0x0402E0B7 RID: 188599
		Layout,
		// Token: 0x0402E0B8 RID: 188600
		GridItem
	}
}
