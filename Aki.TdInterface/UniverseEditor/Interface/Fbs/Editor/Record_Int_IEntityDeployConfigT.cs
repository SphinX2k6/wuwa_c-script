using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D37 RID: 19767
	public class Record_Int_IEntityDeployConfigT
	{
		// Token: 0x17008DA0 RID: 36256
		// (get) Token: 0x0601EA63 RID: 125539 RVA: 0x0044A18F File Offset: 0x0044838F
		// (set) Token: 0x0601EA64 RID: 125540 RVA: 0x0044A197 File Offset: 0x00448397
		public int Key { get; set; }

		// Token: 0x17008DA1 RID: 36257
		// (get) Token: 0x0601EA65 RID: 125541 RVA: 0x0044A1A0 File Offset: 0x004483A0
		// (set) Token: 0x0601EA66 RID: 125542 RVA: 0x0044A1A8 File Offset: 0x004483A8
		public IEntityDeployConfigT Value { get; set; }

		// Token: 0x0601EA67 RID: 125543 RVA: 0x0044A1B1 File Offset: 0x004483B1
		public Record_Int_IEntityDeployConfigT()
		{
			this.Key = 0;
			this.Value = null;
		}
	}
}
