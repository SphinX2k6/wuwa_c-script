using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EF1 RID: 28401
	public class IFoxPickUpT
	{
		// Token: 0x1700D042 RID: 53314
		// (get) Token: 0x0603123F RID: 201279 RVA: 0x006A9504 File Offset: 0x006A7704
		// (set) Token: 0x06031240 RID: 201280 RVA: 0x006A950C File Offset: 0x006A770C
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D043 RID: 53315
		// (get) Token: 0x06031241 RID: 201281 RVA: 0x006A9515 File Offset: 0x006A7715
		// (set) Token: 0x06031242 RID: 201282 RVA: 0x006A951D File Offset: 0x006A771D
		public int DataTableIndex { get; set; }

		// Token: 0x1700D044 RID: 53316
		// (get) Token: 0x06031243 RID: 201283 RVA: 0x006A9526 File Offset: 0x006A7726
		// (set) Token: 0x06031244 RID: 201284 RVA: 0x006A952E File Offset: 0x006A772E
		public bool MouthOpen { get; set; }

		// Token: 0x1700D045 RID: 53317
		// (get) Token: 0x06031245 RID: 201285 RVA: 0x006A9537 File Offset: 0x006A7737
		// (set) Token: 0x06031246 RID: 201286 RVA: 0x006A953F File Offset: 0x006A773F
		public byte NullMask { get; set; }

		// Token: 0x06031247 RID: 201287 RVA: 0x006A9548 File Offset: 0x006A7748
		public IFoxPickUpT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.DataTableIndex = 0;
			this.MouthOpen = false;
			this.NullMask = 0;
		}
	}
}
