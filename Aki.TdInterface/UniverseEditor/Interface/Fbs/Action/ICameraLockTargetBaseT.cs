using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068F6 RID: 26870
	public class ICameraLockTargetBaseT
	{
		// Token: 0x1700C5A2 RID: 50594
		// (get) Token: 0x0602E03E RID: 188478 RVA: 0x00649F76 File Offset: 0x00648176
		// (set) Token: 0x0602E03F RID: 188479 RVA: 0x00649F7E File Offset: 0x0064817E
		public ECameraLockTargetType Type { get; set; }

		// Token: 0x0602E040 RID: 188480 RVA: 0x00649F87 File Offset: 0x00648187
		public ICameraLockTargetBaseT()
		{
			this.Type = ECameraLockTargetType.TargetPosition;
		}
	}
}
