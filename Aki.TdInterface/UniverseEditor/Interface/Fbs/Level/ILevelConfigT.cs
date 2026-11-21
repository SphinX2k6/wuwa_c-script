using System;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004872 RID: 18546
	public class ILevelConfigT
	{
		// Token: 0x17008124 RID: 33060
		// (get) Token: 0x0601B6C5 RID: 112325 RVA: 0x003E1C2C File Offset: 0x003DFE2C
		// (set) Token: 0x0601B6C6 RID: 112326 RVA: 0x003E1C34 File Offset: 0x003DFE34
		public int Id { get; set; }

		// Token: 0x17008125 RID: 33061
		// (get) Token: 0x0601B6C7 RID: 112327 RVA: 0x003E1C3D File Offset: 0x003DFE3D
		// (set) Token: 0x0601B6C8 RID: 112328 RVA: 0x003E1C45 File Offset: 0x003DFE45
		public string Name { get; set; }

		// Token: 0x17008126 RID: 33062
		// (get) Token: 0x0601B6C9 RID: 112329 RVA: 0x003E1C4E File Offset: 0x003DFE4E
		// (set) Token: 0x0601B6CA RID: 112330 RVA: 0x003E1C56 File Offset: 0x003DFE56
		public string ContentPath { get; set; }

		// Token: 0x17008127 RID: 33063
		// (get) Token: 0x0601B6CB RID: 112331 RVA: 0x003E1C5F File Offset: 0x003DFE5F
		// (set) Token: 0x0601B6CC RID: 112332 RVA: 0x003E1C67 File Offset: 0x003DFE67
		public bool IsPartition { get; set; }

		// Token: 0x17008128 RID: 33064
		// (get) Token: 0x0601B6CD RID: 112333 RVA: 0x003E1C70 File Offset: 0x003DFE70
		// (set) Token: 0x0601B6CE RID: 112334 RVA: 0x003E1C78 File Offset: 0x003DFE78
		public IMainWpPartitionDataT PartitionData { get; set; }

		// Token: 0x17008129 RID: 33065
		// (get) Token: 0x0601B6CF RID: 112335 RVA: 0x003E1C81 File Offset: 0x003DFE81
		// (set) Token: 0x0601B6D0 RID: 112336 RVA: 0x003E1C89 File Offset: 0x003DFE89
		public bool IsTest { get; set; }

		// Token: 0x0601B6D1 RID: 112337 RVA: 0x003E1C92 File Offset: 0x003DFE92
		public ILevelConfigT()
		{
			this.Id = 0;
			this.Name = null;
			this.ContentPath = null;
			this.IsPartition = false;
			this.PartitionData = null;
			this.IsTest = false;
		}
	}
}
