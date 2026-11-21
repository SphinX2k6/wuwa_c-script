using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x02003673 RID: 13939
	public class WuWaGoStaticMonster : WuWaGoRole
	{
		// Token: 0x060242A2 RID: 148130 RVA: 0x00A3CB10 File Offset: 0x00A3AD10
		[NullableContext(1)]
		public WuWaGoStaticMonster(Vector coordinate, Rotator rotator) : base(EWuWaGoRoleType.HeatFusionEnemy, coordinate, rotator)
		{
		}

		// Token: 0x170049E0 RID: 18912
		// (get) Token: 0x060242A3 RID: 148131 RVA: 0x00A3CB1B File Offset: 0x00A3AD1B
		public override bool Actionable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170049E1 RID: 18913
		// (get) Token: 0x060242A4 RID: 148132 RVA: 0x00A3CB1E File Offset: 0x00A3AD1E
		public override bool MoveAbility
		{
			get
			{
				return false;
			}
		}
	}
}
