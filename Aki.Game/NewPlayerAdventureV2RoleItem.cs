using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x020013CE RID: 5070
internal class NewPlayerAdventureV2RoleItem : GridProxyAbstract<int>
{
	// Token: 0x06008F16 RID: 36630 RVA: 0x001EE5A0 File Offset: 0x001EC7A0
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnClickToggle))
		};
	}

	// Token: 0x06008F17 RID: 36631 RVA: 0x001EE608 File Offset: 0x001EC808
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		RoleInfo? roleConfig = RoleConfig.Instance.GetRoleConfig(data);
		if (roleConfig == null)
		{
			return;
		}
		this.RoleId = data;
		base.SetTextureShowUntilLoaded(roleConfig.Value.RoleHeadIcon, base.GetTexture(1), null);
	}

	// Token: 0x06008F18 RID: 36632 RVA: 0x001EE64F File Offset: 0x001EC84F
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06008F19 RID: 36633 RVA: 0x001EE662 File Offset: 0x001EC862
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.RoleId, base.GetExtendToggle(0));
	}

	// Token: 0x04003F53 RID: 16211
	private int RoleId;

	// Token: 0x04003F54 RID: 16212
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickToggleCallBack;
}
