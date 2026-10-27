using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006CAF RID: 27823
	public class IPhoneSystemInteractBaseT
	{
		// Token: 0x1700CF29 RID: 53033
		// (get) Token: 0x06031089 RID: 200841 RVA: 0x006A7BEA File Offset: 0x006A5DEA
		// (set) Token: 0x0603108A RID: 200842 RVA: 0x006A7BF2 File Offset: 0x006A5DF2
		public EPhoneSystemInteractType Type { get; set; }

		// Token: 0x0603108B RID: 200843 RVA: 0x006A7BFB File Offset: 0x006A5DFB
		public IPhoneSystemInteractBaseT()
		{
			this.Type = EPhoneSystemInteractType.SendPhoneMessage;
		}
	}
}
