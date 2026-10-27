using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001438 RID: 5176
internal class ActivityRegressAdventureRoleItem : GridProxyAbstract<int>
{
	// Token: 0x06009235 RID: 37429 RVA: 0x001F3ED0 File Offset: 0x001F20D0
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

	// Token: 0x06009236 RID: 37430 RVA: 0x001F3F38 File Offset: 0x001F2138
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

	// Token: 0x06009237 RID: 37431 RVA: 0x001F3F7F File Offset: 0x001F217F
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x06009238 RID: 37432 RVA: 0x001F3F92 File Offset: 0x001F2192
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.RoleId, base.GetExtendToggle(0));
	}

	// Token: 0x040040B2 RID: 16562
	private int RoleId;

	// Token: 0x040040B3 RID: 16563
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickToggleCallBack;
}
