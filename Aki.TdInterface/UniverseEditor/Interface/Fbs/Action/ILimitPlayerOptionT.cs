using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A27 RID: 27175
	public class ILimitPlayerOptionT
	{
		// Token: 0x1700C997 RID: 51607
		// (get) Token: 0x0602F8EA RID: 194794 RVA: 0x0067964A File Offset: 0x0067784A
		// (set) Token: 0x0602F8EB RID: 194795 RVA: 0x00679652 File Offset: 0x00677852
		public ELimitPlayOperation Type { get; set; }

		// Token: 0x0602F8EC RID: 194796 RVA: 0x0067965B File Offset: 0x0067785B
		public ILimitPlayerOptionT()
		{
			this.Type = ELimitPlayOperation.AllowCamera;
		}
	}
}
