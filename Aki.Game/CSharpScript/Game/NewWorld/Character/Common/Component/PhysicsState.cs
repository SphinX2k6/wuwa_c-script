using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x020070D0 RID: 28880
	public class PhysicsState
	{
		// Token: 0x06046789 RID: 288649 RVA: 0x011B21CA File Offset: 0x011B03CA
		public void InitBaseState(bool active)
		{
			this.Active = active;
			this.QuitCache = false;
		}

		// Token: 0x0604678A RID: 288650 RVA: 0x011B21DA File Offset: 0x011B03DA
		public void ClearAnimState()
		{
			this.QuitCache = false;
		}

		// Token: 0x0604678B RID: 288651 RVA: 0x011B21E3 File Offset: 0x011B03E3
		public void SetNewState(bool active)
		{
			if (this.Active && !active)
			{
				this.QuitCache = true;
			}
			this.Active = active;
		}

		// Token: 0x0604678C RID: 288652 RVA: 0x011B21FE File Offset: 0x011B03FE
		[NullableContext(1)]
		public void StateInherit(PhysicsState preState)
		{
			this.Active = preState.Active;
			this.QuitCache = preState.QuitCache;
		}

		// Token: 0x04024EFC RID: 151292
		public bool Active;

		// Token: 0x04024EFD RID: 151293
		public bool QuitCache;
	}
}
