using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058CB RID: 22731
	public class IGroupAiMonsterMemberActionTagAttachT
	{
		// Token: 0x1700A4CF RID: 42191
		// (get) Token: 0x06024E84 RID: 151172 RVA: 0x0051159D File Offset: 0x0050F79D
		// (set) Token: 0x06024E85 RID: 151173 RVA: 0x005115A5 File Offset: 0x0050F7A5
		public string ActionTag { get; set; }

		// Token: 0x1700A4D0 RID: 42192
		// (get) Token: 0x06024E86 RID: 151174 RVA: 0x005115AE File Offset: 0x0050F7AE
		// (set) Token: 0x06024E87 RID: 151175 RVA: 0x005115B6 File Offset: 0x0050F7B6
		public int AttachEntityId { get; set; }

		// Token: 0x1700A4D1 RID: 42193
		// (get) Token: 0x06024E88 RID: 151176 RVA: 0x005115BF File Offset: 0x0050F7BF
		// (set) Token: 0x06024E89 RID: 151177 RVA: 0x005115C7 File Offset: 0x0050F7C7
		public byte NullMask { get; set; }

		// Token: 0x06024E8A RID: 151178 RVA: 0x005115D0 File Offset: 0x0050F7D0
		public IGroupAiMonsterMemberActionTagAttachT()
		{
			this.ActionTag = null;
			this.AttachEntityId = 0;
			this.NullMask = 0;
		}
	}
}
