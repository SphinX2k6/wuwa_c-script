using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068FC RID: 26876
	public class ICameraLockTargetPositionT
	{
		// Token: 0x1700C5A8 RID: 50600
		// (get) Token: 0x0602E05E RID: 188510 RVA: 0x0064A2B7 File Offset: 0x006484B7
		// (set) Token: 0x0602E05F RID: 188511 RVA: 0x0064A2BF File Offset: 0x006484BF
		public ECameraLockTargetType Type { get; set; }

		// Token: 0x1700C5A9 RID: 50601
		// (get) Token: 0x0602E060 RID: 188512 RVA: 0x0064A2C8 File Offset: 0x006484C8
		// (set) Token: 0x0602E061 RID: 188513 RVA: 0x0064A2D0 File Offset: 0x006484D0
		public IVectorInfoT Pos { get; set; }

		// Token: 0x0602E062 RID: 188514 RVA: 0x0064A2D9 File Offset: 0x006484D9
		public ICameraLockTargetPositionT()
		{
			this.Type = ECameraLockTargetType.TargetPosition;
			this.Pos = null;
		}
	}
}
