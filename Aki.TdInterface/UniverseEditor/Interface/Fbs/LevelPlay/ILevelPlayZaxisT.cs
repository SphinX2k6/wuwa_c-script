using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004987 RID: 18823
	public class ILevelPlayZaxisT
	{
		// Token: 0x170083B2 RID: 33714
		// (get) Token: 0x0601C15E RID: 115038 RVA: 0x003F82FA File Offset: 0x003F64FA
		// (set) Token: 0x0601C15F RID: 115039 RVA: 0x003F8302 File Offset: 0x003F6502
		public int Up { get; set; }

		// Token: 0x170083B3 RID: 33715
		// (get) Token: 0x0601C160 RID: 115040 RVA: 0x003F830B File Offset: 0x003F650B
		// (set) Token: 0x0601C161 RID: 115041 RVA: 0x003F8313 File Offset: 0x003F6513
		public int Down { get; set; }

		// Token: 0x170083B4 RID: 33716
		// (get) Token: 0x0601C162 RID: 115042 RVA: 0x003F831C File Offset: 0x003F651C
		// (set) Token: 0x0601C163 RID: 115043 RVA: 0x003F8324 File Offset: 0x003F6524
		public byte NullMask { get; set; }

		// Token: 0x0601C164 RID: 115044 RVA: 0x003F832D File Offset: 0x003F652D
		public ILevelPlayZaxisT()
		{
			this.Up = 0;
			this.Down = 0;
			this.NullMask = 0;
		}
	}
}
