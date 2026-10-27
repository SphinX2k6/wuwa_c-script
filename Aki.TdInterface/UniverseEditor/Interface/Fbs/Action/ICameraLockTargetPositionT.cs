using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200628B RID: 25227
	public class ICameraLockTargetPositionT
	{
		// Token: 0x1700BC20 RID: 48160
		// (get) Token: 0x0602B8FD RID: 178429 RVA: 0x005FF4AF File Offset: 0x005FD6AF
		// (set) Token: 0x0602B8FE RID: 178430 RVA: 0x005FF4B7 File Offset: 0x005FD6B7
		public ECameraLockTargetType Type { get; set; }

		// Token: 0x1700BC21 RID: 48161
		// (get) Token: 0x0602B8FF RID: 178431 RVA: 0x005FF4C0 File Offset: 0x005FD6C0
		// (set) Token: 0x0602B900 RID: 178432 RVA: 0x005FF4C8 File Offset: 0x005FD6C8
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0602B901 RID: 178433 RVA: 0x005FF4D1 File Offset: 0x005FD6D1
		public ICameraLockTargetPositionT()
		{
			this.Type = ECameraLockTargetType.TargetPosition;
			this.Pos = null;
		}
	}
}
