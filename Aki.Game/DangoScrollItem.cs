using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000EFF RID: 3839
internal class DangoScrollItem : GridProxyAbstract<int>
{
	// Token: 0x060099C3 RID: 39363 RVA: 0x002D9768 File Offset: 0x002D7968
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x060099C4 RID: 39364 RVA: 0x002D97A1 File Offset: 0x002D79A1
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RefreshTexture(data);
		this.RefreshGetItem(data);
	}

	// Token: 0x060099C5 RID: 39365 RVA: 0x002D97B4 File Offset: 0x002D79B4
	private void RefreshTexture(int id)
	{
		string icon = DangoAbyssModel.Instance.GetDangoAbyssRoleData(id).GetConfig().Value.Icon;
		base.SetTextureByPath(icon, base.GetTexture(0), null, null);
	}

	// Token: 0x060099C6 RID: 39366 RVA: 0x002D97FC File Offset: 0x002D79FC
	private void RefreshGetItem(int id)
	{
		AbyssDangoRoleData dangoAbyssRoleData = DangoAbyssModel.Instance.GetDangoAbyssRoleData(id);
		if (dangoAbyssRoleData != null)
		{
			base.GetItem(1).SetUIActive(!dangoAbyssRoleData.GetIfLock());
			return;
		}
		base.GetItem(1).SetUIActive(false);
	}
}
