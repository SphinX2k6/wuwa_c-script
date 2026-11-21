using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x0200366D RID: 13933
	public class WuWaGoMainControlRole : WuWaGoRole
	{
		// Token: 0x06024264 RID: 148068 RVA: 0x00A3C21C File Offset: 0x00A3A41C
		[NullableContext(1)]
		public WuWaGoMainControlRole(Vector coordinate, Rotator rotator) : base(EWuWaGoRoleType.AircraftSoldiers, coordinate, rotator)
		{
		}

		// Token: 0x170049D0 RID: 18896
		// (get) Token: 0x06024265 RID: 148069 RVA: 0x00A3C227 File Offset: 0x00A3A427
		public override bool Actionable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170049D1 RID: 18897
		// (get) Token: 0x06024266 RID: 148070 RVA: 0x00A3C22A File Offset: 0x00A3A42A
		public override bool MoveAbility
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04014277 RID: 82551
		public bool IsAcceptingInput;

		// Token: 0x04014278 RID: 82552
		public int DeathCount;
	}
}
