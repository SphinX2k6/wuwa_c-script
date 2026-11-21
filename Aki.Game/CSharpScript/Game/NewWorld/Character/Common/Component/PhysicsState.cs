using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Component
{
	// Token: 0x02006334 RID: 25396
	public class PhysicsState
	{
		// Token: 0x0603D887 RID: 252039 RVA: 0x011D13A2 File Offset: 0x011CF5A2
		public void InitBaseState(bool active)
		{
			this.Active = active;
			this.QuitCache = false;
		}

		// Token: 0x0603D888 RID: 252040 RVA: 0x011D13B2 File Offset: 0x011CF5B2
		public void ClearAnimState()
		{
			this.QuitCache = false;
		}

		// Token: 0x0603D889 RID: 252041 RVA: 0x011D13BB File Offset: 0x011CF5BB
		public void SetNewState(bool active)
		{
			if (this.Active && !active)
			{
				this.QuitCache = true;
			}
			this.Active = active;
		}

		// Token: 0x0603D88A RID: 252042 RVA: 0x011D13D6 File Offset: 0x011CF5D6
		[NullableContext(1)]
		public void StateInherit(PhysicsState preState)
		{
			this.Active = preState.Active;
			this.QuitCache = preState.QuitCache;
		}

		// Token: 0x04020A3B RID: 133691
		public bool Active;

		// Token: 0x04020A3C RID: 133692
		public bool QuitCache;
	}
}
