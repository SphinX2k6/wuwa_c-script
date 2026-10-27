using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02002797 RID: 10135
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TeamRoleSkillItem : GridProxyAbstract<TeamRoleSkillData>
{
	// Token: 0x06014CD1 RID: 85201 RVA: 0x00546738 File Offset: 0x00544938
	protected override void OnStart()
	{
		base.GetExtendToggle(1).OnStateChange.Add(delegate(EToggleState state)
		{
			if (this.Data != null)
			{
				Action<EToggleState, TeamRoleSkillData> callback = this.Callback;
				if (callback == null)
				{
					return;
				}
				callback(state, this.Data);
			}
		});
	}

	// Token: 0x06014CD2 RID: 85202 RVA: 0x00546757 File Offset: 0x00544957
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(1).OnStateChange.Clear();
	}

	// Token: 0x06014CD3 RID: 85203 RVA: 0x0054676A File Offset: 0x0054496A
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x06014CD4 RID: 85204 RVA: 0x005467A3 File Offset: 0x005449A3
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x06014CD5 RID: 85205 RVA: 0x005467B5 File Offset: 0x005449B5
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x06014CD6 RID: 85206 RVA: 0x005467C8 File Offset: 0x005449C8
	public override void Refresh(TeamRoleSkillData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.SetSpriteByPath(data.SkillIcon, base.GetSprite(0), false, null, null);
	}

	// Token: 0x06014CD7 RID: 85207 RVA: 0x005467FA File Offset: 0x005449FA
	public void BindOnSkillStateChange(Action<EToggleState, TeamRoleSkillData> callback)
	{
		this.Callback = callback;
	}

	// Token: 0x04009CA1 RID: 40097
	[Nullable(2)]
	private TeamRoleSkillData Data;

	// Token: 0x04009CA2 RID: 40098
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<EToggleState, TeamRoleSkillData> Callback;

	// Token: 0x02008E01 RID: 36353
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x0402E142 RID: 188738
		IconSprite,
		// Token: 0x0402E143 RID: 188739
		ExtendToggle
	}
}
