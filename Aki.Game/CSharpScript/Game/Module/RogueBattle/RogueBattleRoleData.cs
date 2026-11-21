using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02003EA8 RID: 16040
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleData : RoleDataBase
	{
		// Token: 0x06028BA1 RID: 166817 RVA: 0x00B6CA87 File Offset: 0x00B6AC87
		public RogueBattleRoleData(int id) : base(id)
		{
		}

		// Token: 0x06028BA2 RID: 166818 RVA: 0x00B6CA90 File Offset: 0x00B6AC90
		public override bool IsTrialRole()
		{
			return false;
		}

		// Token: 0x06028BA3 RID: 166819 RVA: 0x00B6CA93 File Offset: 0x00B6AC93
		public override string GetName(int? playerId = null)
		{
			return this.GetRoleInstanceData().GetName(playerId);
		}

		// Token: 0x06028BA4 RID: 166820 RVA: 0x00B6CAA1 File Offset: 0x00B6ACA1
		public override int GetRoleId()
		{
			return this.Id;
		}

		// Token: 0x06028BA5 RID: 166821 RVA: 0x00B6CAA9 File Offset: 0x00B6ACA9
		public override bool IsOnlineRole()
		{
			return false;
		}

		// Token: 0x06028BA6 RID: 166822 RVA: 0x00B6CAAC File Offset: 0x00B6ACAC
		public override bool CanChangeName()
		{
			return false;
		}

		// Token: 0x06028BA7 RID: 166823 RVA: 0x00B6CAAF File Offset: 0x00B6ACAF
		public override int GetRoleCreateTime()
		{
			return 0;
		}

		// Token: 0x06028BA8 RID: 166824 RVA: 0x00B6CAB2 File Offset: 0x00B6ACB2
		public override bool GetIsNew()
		{
			return false;
		}

		// Token: 0x06028BA9 RID: 166825 RVA: 0x00B6CAB5 File Offset: 0x00B6ACB5
		public override int GetRoleSkinId()
		{
			return this.GetRoleInstanceData().GetRoleSkinId();
		}

		// Token: 0x06028BAA RID: 166826 RVA: 0x00B6CAC2 File Offset: 0x00B6ACC2
		protected RoleDataBase GetRoleInstanceData()
		{
			return RoleModel.Instance.GetRoleDataById(this.GetRoleId(), true);
		}
	}
}
