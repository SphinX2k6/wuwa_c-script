using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005859 RID: 22617
	public class IRenjuConfigT
	{
		// Token: 0x1700A907 RID: 43271
		// (get) Token: 0x0602612F RID: 155951 RVA: 0x0053FCF4 File Offset: 0x0053DEF4
		// (set) Token: 0x06026130 RID: 155952 RVA: 0x0053FCFC File Offset: 0x0053DEFC
		public ERenjuController Controller { get; set; }

		// Token: 0x1700A908 RID: 43272
		// (get) Token: 0x06026131 RID: 155953 RVA: 0x0053FD05 File Offset: 0x0053DF05
		// (set) Token: 0x06026132 RID: 155954 RVA: 0x0053FD0D File Offset: 0x0053DF0D
		public ERenjuOrder Order { get; set; }

		// Token: 0x1700A909 RID: 43273
		// (get) Token: 0x06026133 RID: 155955 RVA: 0x0053FD16 File Offset: 0x0053DF16
		// (set) Token: 0x06026134 RID: 155956 RVA: 0x0053FD1E File Offset: 0x0053DF1E
		public int RenjuCount { get; set; }

		// Token: 0x1700A90A RID: 43274
		// (get) Token: 0x06026135 RID: 155957 RVA: 0x0053FD27 File Offset: 0x0053DF27
		// (set) Token: 0x06026136 RID: 155958 RVA: 0x0053FD2F File Offset: 0x0053DF2F
		public List<int> EntityIds { get; set; }

		// Token: 0x1700A90B RID: 43275
		// (get) Token: 0x06026137 RID: 155959 RVA: 0x0053FD38 File Offset: 0x0053DF38
		// (set) Token: 0x06026138 RID: 155960 RVA: 0x0053FD40 File Offset: 0x0053DF40
		public List<IActionInfoT> Actions { get; set; }

		// Token: 0x1700A90C RID: 43276
		// (get) Token: 0x06026139 RID: 155961 RVA: 0x0053FD49 File Offset: 0x0053DF49
		// (set) Token: 0x0602613A RID: 155962 RVA: 0x0053FD51 File Offset: 0x0053DF51
		public byte NullMask { get; set; }

		// Token: 0x0602613B RID: 155963 RVA: 0x0053FD5A File Offset: 0x0053DF5A
		public IRenjuConfigT()
		{
			this.Controller = ERenjuController.Computer;
			this.Order = ERenjuOrder.Order0;
			this.RenjuCount = 0;
			this.EntityIds = null;
			this.Actions = null;
			this.NullMask = 0;
		}
	}
}
