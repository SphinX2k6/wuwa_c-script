using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C09 RID: 7177
public class RacingBetsPreviewViewOrganItem : GridProxyAbstract<int>
{
	// Token: 0x06011D3D RID: 73021 RVA: 0x0053D4BE File Offset: 0x0053B6BE
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x06011D3E RID: 73022 RVA: 0x0053D4D0 File Offset: 0x0053B6D0
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

	// Token: 0x06011D3F RID: 73023 RVA: 0x0053D538 File Offset: 0x0053B738
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.Id = data;
		base.SetTextureByPath(RacingBetsConfig.Instance.GetOrganConfig(this.Id).Value.IconPath, base.GetTexture(1), null, null);
	}

	// Token: 0x06011D40 RID: 73024 RVA: 0x0053D584 File Offset: 0x0053B784
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x06011D41 RID: 73025 RVA: 0x0053D5AA File Offset: 0x0053B7AA
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x06011D42 RID: 73026 RVA: 0x0053D5B3 File Offset: 0x0053B7B3
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x06011D43 RID: 73027 RVA: 0x0053D5BC File Offset: 0x0053B7BC
	private void OnClickToggle(EToggleState state)
	{
		Action<int, int> onToggleCallBack = this.OnToggleCallBack;
		if (onToggleCallBack == null)
		{
			return;
		}
		onToggleCallBack(base.GridIndex, this.Id);
	}

	// Token: 0x04009BB1 RID: 39857
	public int Id;

	// Token: 0x04009BB2 RID: 39858
	[Nullable(2)]
	public Action<int, int> OnToggleCallBack;

	// Token: 0x02007EFA RID: 32506
	private class EComponent
	{
		// Token: 0x04029160 RID: 168288
		public const int ToggleRoot = 0;

		// Token: 0x04029161 RID: 168289
		public const int TextureIcon = 1;
	}
}
