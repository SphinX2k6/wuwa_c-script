using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C7 RID: 30407
	public class ISceneItemNewSplineMoveTargetT
	{
		// Token: 0x1700DF02 RID: 57090
		// (get) Token: 0x0603556B RID: 218475 RVA: 0x007279A8 File Offset: 0x00725BA8
		// (set) Token: 0x0603556C RID: 218476 RVA: 0x007279B0 File Offset: 0x00725BB0
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700DF03 RID: 57091
		// (get) Token: 0x0603556D RID: 218477 RVA: 0x007279B9 File Offset: 0x00725BB9
		// (set) Token: 0x0603556E RID: 218478 RVA: 0x007279C1 File Offset: 0x00725BC1
		public int EntityId { get; set; }

		// Token: 0x1700DF04 RID: 57092
		// (get) Token: 0x0603556F RID: 218479 RVA: 0x007279CA File Offset: 0x00725BCA
		// (set) Token: 0x06035570 RID: 218480 RVA: 0x007279D2 File Offset: 0x00725BD2
		public bool IsLookDir { get; set; }

		// Token: 0x1700DF05 RID: 57093
		// (get) Token: 0x06035571 RID: 218481 RVA: 0x007279DB File Offset: 0x00725BDB
		// (set) Token: 0x06035572 RID: 218482 RVA: 0x007279E3 File Offset: 0x00725BE3
		public byte NullMask { get; set; }

		// Token: 0x06035573 RID: 218483 RVA: 0x007279EC File Offset: 0x00725BEC
		public ISceneItemNewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.EntityId = 0;
			this.IsLookDir = false;
			this.NullMask = 0;
		}
	}
}
