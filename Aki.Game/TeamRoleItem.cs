using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x0200083B RID: 2107
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class TeamRoleItem : GridProxyAbstract<TeamData>
{
	// Token: 0x06005FAF RID: 24495 RVA: 0x001E905C File Offset: 0x001E725C
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06005FB0 RID: 24496 RVA: 0x001E90B6 File Offset: 0x001E72B6
	public override void Refresh(TeamData data, bool isSelected, int gridIndex)
	{
		this.CurrentTeamData = data;
		this.RefreshRoleTexture();
	}

	// Token: 0x06005FB1 RID: 24497 RVA: 0x001E90C8 File Offset: 0x001E72C8
	private void RefreshRoleTexture()
	{
		if (this.CurrentTeamData.RoleId == 0)
		{
			base.GetTexture(2).SetUIActive(false);
			return;
		}
		base.GetTexture(2).SetUIActive(true);
		base.SetRoleIcon(RoleConfig.Instance.GetRoleConfig(this.CurrentTeamData.RoleId).Value.RoleHeadIconCircle, base.GetTexture(2), this.CurrentTeamData.RoleId, null, null);
	}

	// Token: 0x04003EB4 RID: 16052
	private TeamData CurrentTeamData = new TeamData();

	// Token: 0x02006B84 RID: 27524
	[NullableContext(0)]
	private class ETeamRoleComponent
	{
		// Token: 0x04023590 RID: 144784
		public const int Button = 0;

		// Token: 0x04023591 RID: 144785
		public const int BgSprite = 1;

		// Token: 0x04023592 RID: 144786
		public const int RoleTexture = 2;
	}
}
