using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x02002D67 RID: 11623
public class WeeklyRoguePreviewRoleData : RoleDataBase
{
	// Token: 0x06018723 RID: 100131 RVA: 0x00639162 File Offset: 0x00637362
	public WeeklyRoguePreviewRoleData(int id) : base(id)
	{
	}

	// Token: 0x06018724 RID: 100132 RVA: 0x0063916B File Offset: 0x0063736B
	public override bool IsTrialRole()
	{
		return true;
	}

	// Token: 0x06018725 RID: 100133 RVA: 0x00639170 File Offset: 0x00637370
	[NullableContext(1)]
	public override string GetName(int? playerId = null)
	{
		return RoleConfig.Instance.GetRoleName(base.GetRoleConfig().Name);
	}

	// Token: 0x06018726 RID: 100134 RVA: 0x00639195 File Offset: 0x00637395
	public override int GetRoleId()
	{
		return this.Id;
	}

	// Token: 0x06018727 RID: 100135 RVA: 0x0063919D File Offset: 0x0063739D
	public override bool IsOnlineRole()
	{
		return false;
	}

	// Token: 0x06018728 RID: 100136 RVA: 0x006391A0 File Offset: 0x006373A0
	public override bool CanChangeName()
	{
		return false;
	}

	// Token: 0x06018729 RID: 100137 RVA: 0x006391A3 File Offset: 0x006373A3
	public override int GetRoleCreateTime()
	{
		return 0;
	}

	// Token: 0x0601872A RID: 100138 RVA: 0x006391A6 File Offset: 0x006373A6
	public override bool GetIsNew()
	{
		return false;
	}
}
