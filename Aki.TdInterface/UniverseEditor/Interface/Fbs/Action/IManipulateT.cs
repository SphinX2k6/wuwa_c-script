using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200718E RID: 29070
	public class IManipulateT
	{
		// Token: 0x1700D4CC RID: 54476
		// (get) Token: 0x0603289A RID: 207002 RVA: 0x006D45A8 File Offset: 0x006D27A8
		// (set) Token: 0x0603289B RID: 207003 RVA: 0x006D45B0 File Offset: 0x006D27B0
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700D4CD RID: 54477
		// (get) Token: 0x0603289C RID: 207004 RVA: 0x006D45B9 File Offset: 0x006D27B9
		// (set) Token: 0x0603289D RID: 207005 RVA: 0x006D45C1 File Offset: 0x006D27C1
		public int TargetEntityId { get; set; }

		// Token: 0x0603289E RID: 207006 RVA: 0x006D45CA File Offset: 0x006D27CA
		public IManipulateT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.TargetEntityId = 0;
		}
	}
}
