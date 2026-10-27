using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004086 RID: 16518
	public class IRecallDataT
	{
		// Token: 0x17007493 RID: 29843
		// (get) Token: 0x0601807D RID: 98429 RVA: 0x00377644 File Offset: 0x00375844
		// (set) Token: 0x0601807E RID: 98430 RVA: 0x0037764C File Offset: 0x0037584C
		public ERecallDataType Type { get; set; }

		// Token: 0x17007494 RID: 29844
		// (get) Token: 0x0601807F RID: 98431 RVA: 0x00377655 File Offset: 0x00375855
		// (set) Token: 0x06018080 RID: 98432 RVA: 0x0037765D File Offset: 0x0037585D
		public int Id { get; set; }

		// Token: 0x06018081 RID: 98433 RVA: 0x00377666 File Offset: 0x00375866
		public IRecallDataT()
		{
			this.Type = ERecallDataType.LevelPlay;
			this.Id = 0;
		}
	}
}
