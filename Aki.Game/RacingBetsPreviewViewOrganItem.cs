using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200271E RID: 10014
public class RacingBetsPreviewViewOrganItem : GridProxyAbstract<int>
{
	// Token: 0x0601485B RID: 84059 RVA: 0x0052E7A2 File Offset: 0x0052C9A2
	protected override void OnStart()
	{
		base.GetExtendToggle(0).bLockStateOnSelect = true;
	}

	// Token: 0x0601485C RID: 84060 RVA: 0x0052E7B4 File Offset: 0x0052C9B4
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

	// Token: 0x0601485D RID: 84061 RVA: 0x0052E81C File Offset: 0x0052CA1C
	public override void Refresh(int data, bool isSelected, int gridIndex)
	{
		this.Id = data;
		base.SetTextureByPath(RacingBetsConfig.Instance.GetOrganConfig(this.Id).Value.IconPath, base.GetTexture(1), null, null);
	}

	// Token: 0x0601485E RID: 84062 RVA: 0x0052E868 File Offset: 0x0052CA68
	public void SetToggleState(bool state)
	{
		EToggleState state2 = state ? EToggleState.ETT_Checked : EToggleState.ETT_UnChecked;
		base.GetExtendToggle(0).SetToggleState(state2, false, false, false);
	}

	// Token: 0x0601485F RID: 84063 RVA: 0x0052E88E File Offset: 0x0052CA8E
	public override void OnSelected(bool fireEvent)
	{
		this.SetToggleState(true);
	}

	// Token: 0x06014860 RID: 84064 RVA: 0x0052E897 File Offset: 0x0052CA97
	public override void OnDeselected(bool fireEvent)
	{
		this.SetToggleState(false);
	}

	// Token: 0x06014861 RID: 84065 RVA: 0x0052E8A0 File Offset: 0x0052CAA0
	private void OnClickToggle(EToggleState state)
	{
		Action<int, int> onToggleCallBack = this.OnToggleCallBack;
		if (onToggleCallBack == null)
		{
			return;
		}
		onToggleCallBack(base.GridIndex, this.Id);
	}

	// Token: 0x04009A59 RID: 39513
	public int Id;

	// Token: 0x04009A5A RID: 39514
	[Nullable(2)]
	public Action<int, int> OnToggleCallBack;

	// Token: 0x02008D71 RID: 36209
	private class EComponent
	{
		// Token: 0x0402DE49 RID: 187977
		public const int ToggleRoot = 0;

		// Token: 0x0402DE4A RID: 187978
		public const int TextureIcon = 1;
	}
}
