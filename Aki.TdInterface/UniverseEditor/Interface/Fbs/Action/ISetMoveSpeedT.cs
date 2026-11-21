using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077F5 RID: 30709
	public class ISetMoveSpeedT
	{
		// Token: 0x1700E112 RID: 57618
		// (get) Token: 0x06035F2B RID: 220971 RVA: 0x0073A02E File Offset: 0x0073822E
		// (set) Token: 0x06035F2C RID: 220972 RVA: 0x0073A036 File Offset: 0x00738236
		public float Speed { get; set; }

		// Token: 0x06035F2D RID: 220973 RVA: 0x0073A03F File Offset: 0x0073823F
		public ISetMoveSpeedT()
		{
			this.Speed = 0f;
		}
	}
}
