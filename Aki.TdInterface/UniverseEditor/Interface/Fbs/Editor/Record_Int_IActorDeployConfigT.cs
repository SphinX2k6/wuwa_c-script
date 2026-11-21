using System;

namespace Aki.UniverseEditor.Interface.Fbs.Editor
{
	// Token: 0x02004D31 RID: 19761
	public class Record_Int_IActorDeployConfigT
	{
		// Token: 0x17008D96 RID: 36246
		// (get) Token: 0x0601EA37 RID: 125495 RVA: 0x00449C77 File Offset: 0x00447E77
		// (set) Token: 0x0601EA38 RID: 125496 RVA: 0x00449C7F File Offset: 0x00447E7F
		public int Key { get; set; }

		// Token: 0x17008D97 RID: 36247
		// (get) Token: 0x0601EA39 RID: 125497 RVA: 0x00449C88 File Offset: 0x00447E88
		// (set) Token: 0x0601EA3A RID: 125498 RVA: 0x00449C90 File Offset: 0x00447E90
		public IActorDeployConfigT Value { get; set; }

		// Token: 0x0601EA3B RID: 125499 RVA: 0x00449C99 File Offset: 0x00447E99
		public Record_Int_IActorDeployConfigT()
		{
			this.Key = 0;
			this.Value = null;
		}
	}
}
