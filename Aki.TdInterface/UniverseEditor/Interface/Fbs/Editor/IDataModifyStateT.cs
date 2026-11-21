using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004CB6 RID: 19638
	public class IDataModifyStateT
	{
		// Token: 0x17008B2E RID: 35630
		// (get) Token: 0x0601E235 RID: 123445 RVA: 0x00438F57 File Offset: 0x00437157
		// (set) Token: 0x0601E236 RID: 123446 RVA: 0x00438F5F File Offset: 0x0043715F
		public string Uid { get; set; }

		// Token: 0x17008B2F RID: 35631
		// (get) Token: 0x0601E237 RID: 123447 RVA: 0x00438F68 File Offset: 0x00437168
		// (set) Token: 0x0601E238 RID: 123448 RVA: 0x00438F70 File Offset: 0x00437170
		public EDataChangeType UpdateType { get; set; }

		// Token: 0x0601E239 RID: 123449 RVA: 0x00438F79 File Offset: 0x00437179
		public IDataModifyStateT()
		{
			this.Uid = null;
			this.UpdateType = EDataChangeType.None;
		}
	}
}
