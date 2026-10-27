using System;

namespace CSharpScript.Game.Module.Roguelike
{
	// Token: 0x02004D97 RID: 19863
	public class PhantomSelectItemData : IPhantomSelectItemData
	{
		// Token: 0x17007E99 RID: 32409
		// (get) Token: 0x06033510 RID: 210192 RVA: 0x00BFA0F6 File Offset: 0x00BF82F6
		// (set) Token: 0x06033511 RID: 210193 RVA: 0x00BFA0FE File Offset: 0x00BF82FE
		public int PhantomId { get; set; }

		// Token: 0x17007E9A RID: 32410
		// (get) Token: 0x06033512 RID: 210194 RVA: 0x00BFA107 File Offset: 0x00BF8307
		// (set) Token: 0x06033513 RID: 210195 RVA: 0x00BFA10F File Offset: 0x00BF830F
		public int Index { get; set; }

		// Token: 0x17007E9B RID: 32411
		// (get) Token: 0x06033514 RID: 210196 RVA: 0x00BFA118 File Offset: 0x00BF8318
		// (set) Token: 0x06033515 RID: 210197 RVA: 0x00BFA120 File Offset: 0x00BF8320
		public bool IsLock { get; set; }
	}
}
