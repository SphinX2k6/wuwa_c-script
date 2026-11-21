using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005503 RID: 21763
	public class IClientConditionListenerComponentT
	{
		// Token: 0x17009B7F RID: 39807
		// (get) Token: 0x06022611 RID: 140817 RVA: 0x004BCD75 File Offset: 0x004BAF75
		// (set) Token: 0x06022612 RID: 140818 RVA: 0x004BCD7D File Offset: 0x004BAF7D
		public bool Disabled { get; set; }

		// Token: 0x17009B80 RID: 39808
		// (get) Token: 0x06022613 RID: 140819 RVA: 0x004BCD86 File Offset: 0x004BAF86
		// (set) Token: 0x06022614 RID: 140820 RVA: 0x004BCD8E File Offset: 0x004BAF8E
		public List<IClientConditionListenerT> Listeners { get; set; }

		// Token: 0x17009B81 RID: 39809
		// (get) Token: 0x06022615 RID: 140821 RVA: 0x004BCD97 File Offset: 0x004BAF97
		// (set) Token: 0x06022616 RID: 140822 RVA: 0x004BCD9F File Offset: 0x004BAF9F
		public byte NullMask { get; set; }

		// Token: 0x06022617 RID: 140823 RVA: 0x004BCDA8 File Offset: 0x004BAFA8
		public IClientConditionListenerComponentT()
		{
			this.Disabled = false;
			this.Listeners = null;
			this.NullMask = 0;
		}
	}
}
