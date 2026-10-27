using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004517 RID: 17687
	public class ReplaceDamageContext : BaseContext, IExpressionContext
	{
		// Token: 0x170073F3 RID: 29683
		// (get) Token: 0x0602D83B RID: 186427 RVA: 0x00A45D4B File Offset: 0x00A43F4B
		// (set) Token: 0x0602D83C RID: 186428 RVA: 0x00A45D53 File Offset: 0x00A43F53
		public EContextType ContextType { get; set; }

		// Token: 0x0401855D RID: 99677
		[Nullable(1)]
		public Action<long> DamageCb;
	}
}
