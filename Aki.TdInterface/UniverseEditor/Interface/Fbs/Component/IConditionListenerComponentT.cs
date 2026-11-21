using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005557 RID: 21847
	public class IConditionListenerComponentT
	{
		// Token: 0x17009C32 RID: 39986
		// (get) Token: 0x06022ABF RID: 142015 RVA: 0x004C6959 File Offset: 0x004C4B59
		// (set) Token: 0x06022AC0 RID: 142016 RVA: 0x004C6961 File Offset: 0x004C4B61
		public bool Disabled { get; set; }

		// Token: 0x17009C33 RID: 39987
		// (get) Token: 0x06022AC1 RID: 142017 RVA: 0x004C696A File Offset: 0x004C4B6A
		// (set) Token: 0x06022AC2 RID: 142018 RVA: 0x004C6972 File Offset: 0x004C4B72
		public List<ICondtionListenerT> Listeners { get; set; }

		// Token: 0x17009C34 RID: 39988
		// (get) Token: 0x06022AC3 RID: 142019 RVA: 0x004C697B File Offset: 0x004C4B7B
		// (set) Token: 0x06022AC4 RID: 142020 RVA: 0x004C6983 File Offset: 0x004C4B83
		public byte NullMask { get; set; }

		// Token: 0x06022AC5 RID: 142021 RVA: 0x004C698C File Offset: 0x004C4B8C
		public IConditionListenerComponentT()
		{
			this.Disabled = false;
			this.Listeners = null;
			this.NullMask = 0;
		}
	}
}
