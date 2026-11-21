using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C38 RID: 19512
	public class IEntityPrefabElementT
	{
		// Token: 0x17008A5C RID: 35420
		// (get) Token: 0x0601DE70 RID: 122480 RVA: 0x004317F2 File Offset: 0x0042F9F2
		// (set) Token: 0x0601DE71 RID: 122481 RVA: 0x004317FA File Offset: 0x0042F9FA
		public string ObjType { get; set; }

		// Token: 0x17008A5D RID: 35421
		// (get) Token: 0x0601DE72 RID: 122482 RVA: 0x00431803 File Offset: 0x0042FA03
		// (set) Token: 0x0601DE73 RID: 122483 RVA: 0x0043180B File Offset: 0x0042FA0B
		public List<string> Children { get; set; }

		// Token: 0x17008A5E RID: 35422
		// (get) Token: 0x0601DE74 RID: 122484 RVA: 0x00431814 File Offset: 0x0042FA14
		// (set) Token: 0x0601DE75 RID: 122485 RVA: 0x0043181C File Offset: 0x0042FA1C
		public List<string> Reference { get; set; }

		// Token: 0x17008A5F RID: 35423
		// (get) Token: 0x0601DE76 RID: 122486 RVA: 0x00431825 File Offset: 0x0042FA25
		// (set) Token: 0x0601DE77 RID: 122487 RVA: 0x0043182D File Offset: 0x0042FA2D
		public List<string> WeakReference { get; set; }

		// Token: 0x17008A60 RID: 35424
		// (get) Token: 0x0601DE78 RID: 122488 RVA: 0x00431836 File Offset: 0x0042FA36
		// (set) Token: 0x0601DE79 RID: 122489 RVA: 0x0043183E File Offset: 0x0042FA3E
		public IEntityDataT EntityData { get; set; }

		// Token: 0x17008A61 RID: 35425
		// (get) Token: 0x0601DE7A RID: 122490 RVA: 0x00431847 File Offset: 0x0042FA47
		// (set) Token: 0x0601DE7B RID: 122491 RVA: 0x0043184F File Offset: 0x0042FA4F
		public byte NullMask { get; set; }

		// Token: 0x0601DE7C RID: 122492 RVA: 0x00431858 File Offset: 0x0042FA58
		public IEntityPrefabElementT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.EntityData = null;
			this.NullMask = 0;
		}
	}
}
