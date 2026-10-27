using System;

namespace Aki.UniverseEditor.Interface.Fbs.Level
{
	// Token: 0x02004419 RID: 17433
	public class ISubWpMapConfigT
	{
		// Token: 0x17007AFE RID: 31486
		// (get) Token: 0x06019F78 RID: 106360 RVA: 0x003B69EA File Offset: 0x003B4BEA
		// (set) Token: 0x06019F79 RID: 106361 RVA: 0x003B69F2 File Offset: 0x003B4BF2
		public int Id { get; set; }

		// Token: 0x17007AFF RID: 31487
		// (get) Token: 0x06019F7A RID: 106362 RVA: 0x003B69FB File Offset: 0x003B4BFB
		// (set) Token: 0x06019F7B RID: 106363 RVA: 0x003B6A03 File Offset: 0x003B4C03
		public string Name { get; set; }

		// Token: 0x17007B00 RID: 31488
		// (get) Token: 0x06019F7C RID: 106364 RVA: 0x003B6A0C File Offset: 0x003B4C0C
		// (set) Token: 0x06019F7D RID: 106365 RVA: 0x003B6A14 File Offset: 0x003B4C14
		public string ContentPath { get; set; }

		// Token: 0x17007B01 RID: 31489
		// (get) Token: 0x06019F7E RID: 106366 RVA: 0x003B6A1D File Offset: 0x003B4C1D
		// (set) Token: 0x06019F7F RID: 106367 RVA: 0x003B6A25 File Offset: 0x003B4C25
		public bool IsTest { get; set; }

		// Token: 0x06019F80 RID: 106368 RVA: 0x003B6A2E File Offset: 0x003B4C2E
		public ISubWpMapConfigT()
		{
			this.Id = 0;
			this.Name = null;
			this.ContentPath = null;
			this.IsTest = false;
		}
	}
}
