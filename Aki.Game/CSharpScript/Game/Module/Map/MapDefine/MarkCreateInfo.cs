using System;

namespace CSharpScript.Game.Module.Map.MapDefine
{
	// Token: 0x02005582 RID: 21890
	public class MarkCreateInfo
	{
		// Token: 0x17008657 RID: 34391
		// (get) Token: 0x06037CBC RID: 228540 RVA: 0x00D394E4 File Offset: 0x00D376E4
		// (set) Token: 0x06037CBD RID: 228541 RVA: 0x00D394EC File Offset: 0x00D376EC
		public virtual EMarkCreateType CreateType { get; protected set; }

		// Token: 0x06037CBE RID: 228542 RVA: 0x00D394F5 File Offset: 0x00D376F5
		public MarkCreateInfo(EMarkCreateType createType)
		{
			this.CreateType = createType;
		}
	}
}
