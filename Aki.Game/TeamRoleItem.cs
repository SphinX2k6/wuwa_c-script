using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;
using CSharpScript.Game.Module.Util;
using UnrealEngine;

// Token: 0x02001387 RID: 4999
[NullableContext(1)]
[Nullable(new byte[]
{
	0,
	1
})]
internal class TeamRoleItem : GridProxyAbstract<TeamData>
{
	// Token: 0x06008C14 RID: 35860 RVA: 0x001E0208 File Offset: 0x001DE408
	protected override void OnRegisterComponent()
	{
		this.ComponentRegisterInfos = new List<ValueTuple<int, Type>>
		{
			new ValueTuple<int, Type>(0, typeof(UUIButtonComponent)),
			new ValueTuple<int, Type>(1, typeof(UUISprite)),
			new ValueTuple<int, Type>(2, typeof(UUITexture))
		};
	}

	// Token: 0x06008C15 RID: 35861 RVA: 0x001E0262 File Offset: 0x001DE462
	public override void Refresh(TeamData data, bool isSelected, int gridIndex)
	{
		this.CurrentTeamData = data;
		this.RefreshRoleTexture();
	}

	// Token: 0x06008C16 RID: 35862 RVA: 0x001E0274 File Offset: 0x001DE474
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

	// Token: 0x04003E1C RID: 15900
	private TeamData CurrentTeamData = new TeamData();

	// Token: 0x020079FA RID: 31226
	[NullableContext(0)]
	private class ETeamRoleComponent
	{
		// Token: 0x04028263 RID: 164451
		public const int Button = 0;

		// Token: 0x04028264 RID: 164452
		public const int BgSprite = 1;

		// Token: 0x04028265 RID: 164453
		public const int RoleTexture = 2;
	}
}
