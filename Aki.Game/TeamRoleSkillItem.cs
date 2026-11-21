using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001C82 RID: 7298
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
public class TeamRoleSkillItem : GridProxyAbstract<TeamRoleSkillData>
{
	// Token: 0x060121BC RID: 74172 RVA: 0x00555824 File Offset: 0x00553A24
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

	// Token: 0x060121BD RID: 74173 RVA: 0x00555843 File Offset: 0x00553A43
	protected override void OnBeforeDestroy()
	{
		base.GetExtendToggle(1).OnStateChange.Clear();
	}

	// Token: 0x060121BE RID: 74174 RVA: 0x00555856 File Offset: 0x00553A56
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUISprite)),
			new ValueTuple<int, Type>(1, typeof(UUIExtendToggle))
		};
	}

	// Token: 0x060121BF RID: 74175 RVA: 0x0055588F File Offset: 0x00553A8F
	public override void OnSelected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleStateForce(EToggleState.ETT_Checked, false, false, false);
	}

	// Token: 0x060121C0 RID: 74176 RVA: 0x005558A1 File Offset: 0x00553AA1
	public override void OnDeselected(bool fireEvent)
	{
		base.GetExtendToggle(1).SetToggleState(EToggleState.ETT_UnChecked, false, false, false);
	}

	// Token: 0x060121C1 RID: 74177 RVA: 0x005558B4 File Offset: 0x00553AB4
	public override void Refresh(TeamRoleSkillData data, bool isSelected, int gridIndex)
	{
		this.Data = data;
		this.SetSpriteByPath(data.SkillIcon, base.GetSprite(0), false, null, null);
	}

	// Token: 0x060121C2 RID: 74178 RVA: 0x005558E6 File Offset: 0x00553AE6
	public void BindOnSkillStateChange(Action<EToggleState, TeamRoleSkillData> callback)
	{
		this.Callback = callback;
	}

	// Token: 0x04009E05 RID: 40453
	[Nullable(2)]
	private TeamRoleSkillData Data;

	// Token: 0x04009E06 RID: 40454
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Action<EToggleState, TeamRoleSkillData> Callback;

	// Token: 0x02007F88 RID: 32648
	[NullableContext(0)]
	private enum EChildType
	{
		// Token: 0x04029455 RID: 169045
		IconSprite,
		// Token: 0x04029456 RID: 169046
		ExtendToggle
	}
}
