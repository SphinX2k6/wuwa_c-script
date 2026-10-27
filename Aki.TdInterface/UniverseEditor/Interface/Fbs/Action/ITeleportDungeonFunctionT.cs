using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007380 RID: 29568
	public class ITeleportDungeonFunctionT
	{
		// Token: 0x1700E080 RID: 57472
		// (get) Token: 0x06035AC9 RID: 219849 RVA: 0x0074EF17 File Offset: 0x0074D117
		// (set) Token: 0x06035ACA RID: 219850 RVA: 0x0074EF1F File Offset: 0x0074D11F
		public EEnableFunctionType Type { get; set; }

		// Token: 0x1700E081 RID: 57473
		// (get) Token: 0x06035ACB RID: 219851 RVA: 0x0074EF28 File Offset: 0x0074D128
		// (set) Token: 0x06035ACC RID: 219852 RVA: 0x0074EF30 File Offset: 0x0074D130
		public bool Enable { get; set; }

		// Token: 0x1700E082 RID: 57474
		// (get) Token: 0x06035ACD RID: 219853 RVA: 0x0074EF39 File Offset: 0x0074D139
		// (set) Token: 0x06035ACE RID: 219854 RVA: 0x0074EF41 File Offset: 0x0074D141
		public List<int> DungeonList { get; set; }

		// Token: 0x1700E083 RID: 57475
		// (get) Token: 0x06035ACF RID: 219855 RVA: 0x0074EF4A File Offset: 0x0074D14A
		// (set) Token: 0x06035AD0 RID: 219856 RVA: 0x0074EF52 File Offset: 0x0074D152
		public byte NullMask { get; set; }

		// Token: 0x06035AD1 RID: 219857 RVA: 0x0074EF5B File Offset: 0x0074D15B
		public ITeleportDungeonFunctionT()
		{
			this.Type = EEnableFunctionType.TeleportDungeon;
			this.Enable = false;
			this.DungeonList = null;
			this.NullMask = 0;
		}
	}
}
