using System;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x0200440A RID: 17418
	public class ILevelConfigT
	{
		// Token: 0x17007AE5 RID: 31461
		// (get) Token: 0x06019EF4 RID: 106228 RVA: 0x003B5A20 File Offset: 0x003B3C20
		// (set) Token: 0x06019EF5 RID: 106229 RVA: 0x003B5A28 File Offset: 0x003B3C28
		public int Id { get; set; }

		// Token: 0x17007AE6 RID: 31462
		// (get) Token: 0x06019EF6 RID: 106230 RVA: 0x003B5A31 File Offset: 0x003B3C31
		// (set) Token: 0x06019EF7 RID: 106231 RVA: 0x003B5A39 File Offset: 0x003B3C39
		public string Name { get; set; }

		// Token: 0x17007AE7 RID: 31463
		// (get) Token: 0x06019EF8 RID: 106232 RVA: 0x003B5A42 File Offset: 0x003B3C42
		// (set) Token: 0x06019EF9 RID: 106233 RVA: 0x003B5A4A File Offset: 0x003B3C4A
		public string ContentPath { get; set; }

		// Token: 0x17007AE8 RID: 31464
		// (get) Token: 0x06019EFA RID: 106234 RVA: 0x003B5A53 File Offset: 0x003B3C53
		// (set) Token: 0x06019EFB RID: 106235 RVA: 0x003B5A5B File Offset: 0x003B3C5B
		public bool IsPartition { get; set; }

		// Token: 0x17007AE9 RID: 31465
		// (get) Token: 0x06019EFC RID: 106236 RVA: 0x003B5A64 File Offset: 0x003B3C64
		// (set) Token: 0x06019EFD RID: 106237 RVA: 0x003B5A6C File Offset: 0x003B3C6C
		public IMainWpPartitionDataT PartitionData { get; set; }

		// Token: 0x17007AEA RID: 31466
		// (get) Token: 0x06019EFE RID: 106238 RVA: 0x003B5A75 File Offset: 0x003B3C75
		// (set) Token: 0x06019EFF RID: 106239 RVA: 0x003B5A7D File Offset: 0x003B3C7D
		public bool IsTest { get; set; }

		// Token: 0x06019F00 RID: 106240 RVA: 0x003B5A86 File Offset: 0x003B3C86
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
