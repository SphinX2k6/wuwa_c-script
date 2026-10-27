using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.RogueBattle
{
	// Token: 0x02004EDF RID: 20191
	[NullableContext(1)]
	[Nullable(0)]
	public class RogueBattleRoleData : RoleDataBase
	{
		// Token: 0x06033D36 RID: 212278 RVA: 0x00C23513 File Offset: 0x00C21713
		public RogueBattleRoleData(int id) : base(id)
		{
		}

		// Token: 0x06033D37 RID: 212279 RVA: 0x00C2351C File Offset: 0x00C2171C
		public override bool IsTrialRole()
		{
			return false;
		}

		// Token: 0x06033D38 RID: 212280 RVA: 0x00C2351F File Offset: 0x00C2171F
		public override string GetName(int? playerId = null)
		{
			return this.GetRoleInstanceData().GetName(playerId);
		}

		// Token: 0x06033D39 RID: 212281 RVA: 0x00C2352D File Offset: 0x00C2172D
		public override int GetRoleId()
		{
			return this.Id;
		}

		// Token: 0x06033D3A RID: 212282 RVA: 0x00C23535 File Offset: 0x00C21735
		public override bool IsOnlineRole()
		{
			return false;
		}

		// Token: 0x06033D3B RID: 212283 RVA: 0x00C23538 File Offset: 0x00C21738
		public override bool CanChangeName()
		{
			return false;
		}

		// Token: 0x06033D3C RID: 212284 RVA: 0x00C2353B File Offset: 0x00C2173B
		public override int GetRoleCreateTime()
		{
			return 0;
		}

		// Token: 0x06033D3D RID: 212285 RVA: 0x00C2353E File Offset: 0x00C2173E
		public override bool GetIsNew()
		{
			return false;
		}

		// Token: 0x06033D3E RID: 212286 RVA: 0x00C23541 File Offset: 0x00C21741
		public override int GetRoleSkinId()
		{
			return this.GetRoleInstanceData().GetRoleSkinId();
		}

		// Token: 0x06033D3F RID: 212287 RVA: 0x00C2354E File Offset: 0x00C2174E
		protected RoleDataBase GetRoleInstanceData()
		{
			return RoleModel.Instance.GetRoleDataById(this.GetRoleId(), true);
		}
	}
}
