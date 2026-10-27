using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002D30 RID: 11568
public class WeeklyRogueArtifactGrid : GridProxyAbstract<int>
{
	// Token: 0x0601852A RID: 99626 RVA: 0x00630D4C File Offset: 0x0062EF4C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIExtendToggle)),
			new ValueTuple<int, Type>(1, typeof(UUITexture)),
			new ValueTuple<int, Type>(2, typeof(UUIText))
		};
		this.BtnBindInfo = new List<ValueTuple<int, Delegate>>
		{
			new ValueTuple<int, Delegate>(0, new Action<EToggleState>(this.OnToggleClick))
		};
	}

	// Token: 0x0601852B RID: 99627 RVA: 0x00630DCC File Offset: 0x0062EFCC
	private void OnToggleClick(EToggleState state)
	{
		bool arg = base.GetExtendToggle(0).GetToggleState() == EToggleState.ETT_Checked;
		Action<int, bool> onSelectedChange = this.OnSelectedChange;
		if (onSelectedChange == null)
		{
			return;
		}
		onSelectedChange(this.TokenId, arg);
	}

	// Token: 0x0601852C RID: 99628 RVA: 0x00630E00 File Offset: 0x0062F000
	public override void Refresh(int tokenId, bool isSelected, int gridIndex)
	{
		this.TokenId = tokenId;
		if (tokenId == 0)
		{
			return;
		}
		RogueWeeklyBuffPool? rogueWeeklyBuffPool = WeeklyRogueConfig.Instance.GetRogueWeeklyBuffPool(tokenId);
		if (rogueWeeklyBuffPool == null)
		{
			return;
		}
		base.SetTextureShowUntilLoaded(rogueWeeklyBuffPool.Value.BuffIcon, base.GetTexture(1), null);
		LguiUtil.Instance.SetLocalTextNew(base.GetText(2), rogueWeeklyBuffPool.Value.BuffName, Array.Empty<object>());
	}

	// Token: 0x0601852D RID: 99629 RVA: 0x00630E70 File Offset: 0x0062F070
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_Checked, fireEvent, false, false);
	}

	// Token: 0x0601852E RID: 99630 RVA: 0x00630E83 File Offset: 0x0062F083
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(0).SetToggleState(EToggleState.ETT_UnChecked, fireEvent, false, false);
	}

	// Token: 0x0601852F RID: 99631 RVA: 0x00630E96 File Offset: 0x0062F096
	[NullableContext(1)]
	public override object GetKey(int data, int displayIndex)
	{
		return this.TokenId;
	}

	// Token: 0x0400B499 RID: 46233
	[Nullable(2)]
	public Action<int, bool> OnSelectedChange;

	// Token: 0x0400B49A RID: 46234
	protected int TokenId;

	// Token: 0x020092BE RID: 37566
	private enum EComponents
	{
		// Token: 0x0402F6EE RID: 194286
		ToggleSelf,
		// Token: 0x0402F6EF RID: 194287
		TexIcon,
		// Token: 0x0402F6F0 RID: 194288
		TxtName
	}
}
