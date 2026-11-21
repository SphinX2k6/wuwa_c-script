using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003FC3 RID: 16323
	[NullableContext(1)]
	[Nullable(0)]
	public class AbpStateConfig : IAbpStateConfig
	{
		// Token: 0x17005391 RID: 21393
		// (get) Token: 0x06029477 RID: 169079 RVA: 0x00B98AB9 File Offset: 0x00B96CB9
		// (set) Token: 0x06029478 RID: 169080 RVA: 0x00B98AC1 File Offset: 0x00B96CC1
		public string Abp { get; set; }

		// Token: 0x17005392 RID: 21394
		// (get) Token: 0x06029479 RID: 169081 RVA: 0x00B98ACA File Offset: 0x00B96CCA
		// (set) Token: 0x0602947A RID: 169082 RVA: 0x00B98AD2 File Offset: 0x00B96CD2
		public string State1 { get; set; }

		// Token: 0x17005393 RID: 21395
		// (get) Token: 0x0602947B RID: 169083 RVA: 0x00B98ADB File Offset: 0x00B96CDB
		// (set) Token: 0x0602947C RID: 169084 RVA: 0x00B98AE3 File Offset: 0x00B96CE3
		public string State2 { get; set; }
	}
}
