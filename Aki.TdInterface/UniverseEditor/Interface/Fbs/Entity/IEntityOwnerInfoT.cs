using System;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C26 RID: 19494
	public class IEntityOwnerInfoT
	{
		// Token: 0x17008A30 RID: 35376
		// (get) Token: 0x0601DD98 RID: 122264 RVA: 0x0042FACA File Offset: 0x0042DCCA
		// (set) Token: 0x0601DD99 RID: 122265 RVA: 0x0042FAD2 File Offset: 0x0042DCD2
		public EEntityOwnerType Type { get; set; }

		// Token: 0x0601DD9A RID: 122266 RVA: 0x0042FADB File Offset: 0x0042DCDB
		public IEntityOwnerInfoT()
		{
			this.Type = EEntityOwnerType.Quest;
		}
	}
}
