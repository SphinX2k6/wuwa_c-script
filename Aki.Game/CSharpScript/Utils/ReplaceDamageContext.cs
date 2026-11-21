using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003439 RID: 13369
	public class ReplaceDamageContext : BaseContext, IExpressionContext
	{
		// Token: 0x170046AB RID: 18091
		// (get) Token: 0x06021F0B RID: 139019 RVA: 0x00971B5B File Offset: 0x0096FD5B
		// (set) Token: 0x06021F0C RID: 139020 RVA: 0x00971B63 File Offset: 0x0096FD63
		public EContextType ContextType { get; set; }

		// Token: 0x04012B85 RID: 76677
		[Nullable(1)]
		public Action<long> DamageCb;
	}
}
