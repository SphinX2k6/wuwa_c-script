using System;
using System.Collections.Generic;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001A40 RID: 6720
internal class DangoScrollItem : GridProxyAbstract<int>
{
	// Token: 0x0600C5B3 RID: 50611 RVA: 0x002CE654 File Offset: 0x002CC854
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUITexture)),
			new ValueTuple<int, Type>(1, typeof(UUIItem))
		};
	}

	// Token: 0x0600C5B4 RID: 50612 RVA: 0x002CE68D File Offset: 0x002CC88D
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.RefreshTexture(data);
		this.RefreshGetItem(data);
	}

	// Token: 0x0600C5B5 RID: 50613 RVA: 0x002CE6A0 File Offset: 0x002CC8A0
	private void RefreshTexture(int id)
	{
		string icon = DangoAbyssModel.Instance.GetDangoAbyssRoleData(id).GetConfig().Value.Icon;
		base.SetTextureByPath(icon, base.GetTexture(0), null, null);
	}

	// Token: 0x0600C5B6 RID: 50614 RVA: 0x002CE6E8 File Offset: 0x002CC8E8
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
