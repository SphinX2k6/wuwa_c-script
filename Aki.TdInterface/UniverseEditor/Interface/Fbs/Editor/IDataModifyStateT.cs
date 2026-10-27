using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x0200484E RID: 18510
	public class IDataModifyStateT
	{
		// Token: 0x170084E3 RID: 34019
		// (get) Token: 0x0601CA38 RID: 117304 RVA: 0x0040C607 File Offset: 0x0040A807
		// (set) Token: 0x0601CA39 RID: 117305 RVA: 0x0040C60F File Offset: 0x0040A80F
		public string Uid { get; set; }

		// Token: 0x170084E4 RID: 34020
		// (get) Token: 0x0601CA3A RID: 117306 RVA: 0x0040C618 File Offset: 0x0040A818
		// (set) Token: 0x0601CA3B RID: 117307 RVA: 0x0040C620 File Offset: 0x0040A820
		public EDataChangeType UpdateType { get; set; }

		// Token: 0x0601CA3C RID: 117308 RVA: 0x0040C629 File Offset: 0x0040A829
		public IDataModifyStateT()
		{
			this.Uid = null;
			this.UpdateType = EDataChangeType.None;
		}
	}
}
