using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi;

// Token: 0x020022C1 RID: 8897
public class WeeklyRoguePreviewRoleData : RoleDataBase
{
	// Token: 0x06015FC5 RID: 90053 RVA: 0x0065F17A File Offset: 0x0065D37A
	public WeeklyRoguePreviewRoleData(int id) : base(id)
	{
	}

	// Token: 0x06015FC6 RID: 90054 RVA: 0x0065F183 File Offset: 0x0065D383
	public override bool IsTrialRole()
	{
		return true;
	}

	// Token: 0x06015FC7 RID: 90055 RVA: 0x0065F188 File Offset: 0x0065D388
	[NullableContext(1)]
	public override string GetName(int? playerId = null)
	{
		return RoleConfig.Instance.GetRoleName(base.GetRoleConfig().Name);
	}

	// Token: 0x06015FC8 RID: 90056 RVA: 0x0065F1AD File Offset: 0x0065D3AD
	public override int GetRoleId()
	{
		return this.Id;
	}

	// Token: 0x06015FC9 RID: 90057 RVA: 0x0065F1B5 File Offset: 0x0065D3B5
	public override bool IsOnlineRole()
	{
		return false;
	}

	// Token: 0x06015FCA RID: 90058 RVA: 0x0065F1B8 File Offset: 0x0065D3B8
	public override bool CanChangeName()
	{
		return false;
	}

	// Token: 0x06015FCB RID: 90059 RVA: 0x0065F1BB File Offset: 0x0065D3BB
	public override int GetRoleCreateTime()
	{
		return 0;
	}

	// Token: 0x06015FCC RID: 90060 RVA: 0x0065F1BE File Offset: 0x0065D3BE
	public override bool GetIsNew()
	{
		return false;
	}
}
