using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component;

namespace CSharpScript.Game.Module.WuwaGo.Model.Role
{
	// Token: 0x0200473C RID: 18236
	public class WuWaGoMainControlRole : WuWaGoRole
	{
		// Token: 0x0602FA9A RID: 195226 RVA: 0x00B0C250 File Offset: 0x00B0A450
		[NullableContext(1)]
		public WuWaGoMainControlRole(Vector coordinate, Rotator rotator) : base(EWuWaGoRoleType.AircraftSoldiers, coordinate, rotator)
		{
		}

		// Token: 0x17007714 RID: 30484
		// (get) Token: 0x0602FA9B RID: 195227 RVA: 0x00B0C25B File Offset: 0x00B0A45B
		public override bool Actionable
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17007715 RID: 30485
		// (get) Token: 0x0602FA9C RID: 195228 RVA: 0x00B0C25E File Offset: 0x00B0A45E
		public override bool MoveAbility
		{
			get
			{
				return true;
			}
		}

		// Token: 0x04019BC7 RID: 105415
		public bool IsAcceptingInput;

		// Token: 0x04019BC8 RID: 105416
		public int DeathCount;
	}
}
