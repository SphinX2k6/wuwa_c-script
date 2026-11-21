using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059C4 RID: 22980
	public class IInteractCameraOffsetConfigT
	{
		// Token: 0x1700A6D5 RID: 42709
		// (get) Token: 0x060257A1 RID: 153505 RVA: 0x00523C46 File Offset: 0x00521E46
		// (set) Token: 0x060257A2 RID: 153506 RVA: 0x00523C4E File Offset: 0x00521E4E
		public int CenterOffsetPercent { get; set; }

		// Token: 0x1700A6D6 RID: 42710
		// (get) Token: 0x060257A3 RID: 153507 RVA: 0x00523C57 File Offset: 0x00521E57
		// (set) Token: 0x060257A4 RID: 153508 RVA: 0x00523C5F File Offset: 0x00521E5F
		public float OffsetZ { get; set; }

		// Token: 0x1700A6D7 RID: 42711
		// (get) Token: 0x060257A5 RID: 153509 RVA: 0x00523C68 File Offset: 0x00521E68
		// (set) Token: 0x060257A6 RID: 153510 RVA: 0x00523C70 File Offset: 0x00521E70
		public byte NullMask { get; set; }

		// Token: 0x060257A7 RID: 153511 RVA: 0x00523C79 File Offset: 0x00521E79
		public IInteractCameraOffsetConfigT()
		{
			this.CenterOffsetPercent = 0;
			this.OffsetZ = 0f;
			this.NullMask = 0;
		}
	}
}
