using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020049B4 RID: 18868
	public class IRollBlock2T
	{
		// Token: 0x17008418 RID: 33816
		// (get) Token: 0x0601C2FE RID: 115454 RVA: 0x003FAF00 File Offset: 0x003F9100
		// (set) Token: 0x0601C2FF RID: 115455 RVA: 0x003FAF08 File Offset: 0x003F9108
		public ERollBlockBlockType Type { get; set; }

		// Token: 0x17008419 RID: 33817
		// (get) Token: 0x0601C300 RID: 115456 RVA: 0x003FAF11 File Offset: 0x003F9111
		// (set) Token: 0x0601C301 RID: 115457 RVA: 0x003FAF19 File Offset: 0x003F9119
		public int BlockId { get; set; }

		// Token: 0x1700841A RID: 33818
		// (get) Token: 0x0601C302 RID: 115458 RVA: 0x003FAF22 File Offset: 0x003F9122
		// (set) Token: 0x0601C303 RID: 115459 RVA: 0x003FAF2A File Offset: 0x003F912A
		public ERollBlockLayType LayType { get; set; }

		// Token: 0x1700841B RID: 33819
		// (get) Token: 0x0601C304 RID: 115460 RVA: 0x003FAF33 File Offset: 0x003F9133
		// (set) Token: 0x0601C305 RID: 115461 RVA: 0x003FAF3B File Offset: 0x003F913B
		public byte NullMask { get; set; }

		// Token: 0x0601C306 RID: 115462 RVA: 0x003FAF44 File Offset: 0x003F9144
		public IRollBlock2T()
		{
			this.Type = ERollBlockBlockType.Block1;
			this.BlockId = 0;
			this.LayType = ERollBlockLayType.Left;
			this.NullMask = 0;
		}
	}
}
