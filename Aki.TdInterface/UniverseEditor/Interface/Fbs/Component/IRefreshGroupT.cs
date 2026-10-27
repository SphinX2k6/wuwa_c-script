using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005827 RID: 22567
	public class IRefreshGroupT
	{
		// Token: 0x1700A88E RID: 43150
		// (get) Token: 0x06025F2E RID: 155438 RVA: 0x0053B71F File Offset: 0x0053991F
		// (set) Token: 0x06025F2F RID: 155439 RVA: 0x0053B727 File Offset: 0x00539927
		public bool Disabled { get; set; }

		// Token: 0x1700A88F RID: 43151
		// (get) Token: 0x06025F30 RID: 155440 RVA: 0x0053B730 File Offset: 0x00539930
		// (set) Token: 0x06025F31 RID: 155441 RVA: 0x0053B738 File Offset: 0x00539938
		public int RefreshInterval { get; set; }

		// Token: 0x1700A890 RID: 43152
		// (get) Token: 0x06025F32 RID: 155442 RVA: 0x0053B741 File Offset: 0x00539941
		// (set) Token: 0x06025F33 RID: 155443 RVA: 0x0053B749 File Offset: 0x00539949
		public bool DelayRefresh { get; set; }

		// Token: 0x1700A891 RID: 43153
		// (get) Token: 0x06025F34 RID: 155444 RVA: 0x0053B752 File Offset: 0x00539952
		// (set) Token: 0x06025F35 RID: 155445 RVA: 0x0053B75A File Offset: 0x0053995A
		public List<int> EntityIdList { get; set; }

		// Token: 0x1700A892 RID: 43154
		// (get) Token: 0x06025F36 RID: 155446 RVA: 0x0053B763 File Offset: 0x00539963
		// (set) Token: 0x06025F37 RID: 155447 RVA: 0x0053B76B File Offset: 0x0053996B
		public ICylinderT IsUesCylinder { get; set; }

		// Token: 0x1700A893 RID: 43155
		// (get) Token: 0x06025F38 RID: 155448 RVA: 0x0053B774 File Offset: 0x00539974
		// (set) Token: 0x06025F39 RID: 155449 RVA: 0x0053B77C File Offset: 0x0053997C
		public byte NullMask { get; set; }

		// Token: 0x06025F3A RID: 155450 RVA: 0x0053B785 File Offset: 0x00539985
		public IRefreshGroupT()
		{
			this.Disabled = false;
			this.RefreshInterval = 0;
			this.DelayRefresh = false;
			this.EntityIdList = null;
			this.IsUesCylinder = null;
			this.NullMask = 0;
		}
	}
}
