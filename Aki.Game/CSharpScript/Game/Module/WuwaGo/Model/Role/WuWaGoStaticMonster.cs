using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x02004742 RID: 18242
	public class WuWaGoStaticMonster : WuWaGoRole
	{
		// Token: 0x0602FAD8 RID: 195288 RVA: 0x00B0CB44 File Offset: 0x00B0AD44
		[NullableContext(1)]
		public WuWaGoStaticMonster(Vector coordinate, Rotator rotator) : base(EWuWaGoRoleType.HeatFusionEnemy, coordinate, rotator)
		{
		}

		// Token: 0x17007724 RID: 30500
		// (get) Token: 0x0602FAD9 RID: 195289 RVA: 0x00B0CB4F File Offset: 0x00B0AD4F
		public override bool Actionable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007725 RID: 30501
		// (get) Token: 0x0602FADA RID: 195290 RVA: 0x00B0CB52 File Offset: 0x00B0AD52
		public override bool MoveAbility
		{
			get
			{
				return false;
			}
		}
	}
}
