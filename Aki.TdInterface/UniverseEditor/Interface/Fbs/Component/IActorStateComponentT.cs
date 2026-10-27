using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E57 RID: 20055
	public class IActorStateComponentT
	{
		// Token: 0x17008F8A RID: 36746
		// (get) Token: 0x0601F7C6 RID: 128966 RVA: 0x00462DB1 File Offset: 0x00460FB1
		// (set) Token: 0x0601F7C7 RID: 128967 RVA: 0x00462DB9 File Offset: 0x00460FB9
		public bool Disabled { get; set; }

		// Token: 0x17008F8B RID: 36747
		// (get) Token: 0x0601F7C8 RID: 128968 RVA: 0x00462DC2 File Offset: 0x00460FC2
		// (set) Token: 0x0601F7C9 RID: 128969 RVA: 0x00462DCA File Offset: 0x00460FCA
		public string InitState { get; set; }

		// Token: 0x17008F8C RID: 36748
		// (get) Token: 0x0601F7CA RID: 128970 RVA: 0x00462DD3 File Offset: 0x00460FD3
		// (set) Token: 0x0601F7CB RID: 128971 RVA: 0x00462DDB File Offset: 0x00460FDB
		public byte NullMask { get; set; }

		// Token: 0x0601F7CC RID: 128972 RVA: 0x00462DE4 File Offset: 0x00460FE4
		public IActorStateComponentT()
		{
			this.Disabled = false;
			this.InitState = null;
			this.NullMask = 0;
		}
	}
}
