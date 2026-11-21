using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02000882 RID: 2178
internal class NewPlayerAdventureV2RoleItem : GridProxyAbstract<int>
{
	// Token: 0x060062AB RID: 25259 RVA: 0x001F70C0 File Offset: 0x001F52C0
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

	// Token: 0x060062AC RID: 25260 RVA: 0x001F7128 File Offset: 0x001F5328
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

	// Token: 0x060062AD RID: 25261 RVA: 0x001F716F File Offset: 0x001F536F
	public void SelectToggle()
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, true, false, false);
	}

	// Token: 0x060062AE RID: 25262 RVA: 0x001F7182 File Offset: 0x001F5382
	private void OnClickToggle(EToggleState toggleState)
	{
		Action<int, UUIExtendToggle> onClickToggleCallBack = this.OnClickToggleCallBack;
		if (onClickToggleCallBack == null)
		{
			return;
		}
		onClickToggleCallBack(this.RoleId, base.GetExtendToggle(0));
	}

	// Token: 0x04003FEB RID: 16363
	private int RoleId;

	// Token: 0x04003FEC RID: 16364
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<int, UUIExtendToggle> OnClickToggleCallBack;
}
