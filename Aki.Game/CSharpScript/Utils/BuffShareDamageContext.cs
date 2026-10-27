using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004516 RID: 17686
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffShareDamageContext : BaseContext, IExpressionContext
	{
		// Token: 0x170073F2 RID: 29682
		// (get) Token: 0x0602D838 RID: 186424 RVA: 0x00A45D32 File Offset: 0x00A43F32
		// (set) Token: 0x0602D839 RID: 186425 RVA: 0x00A45D3A File Offset: 0x00A43F3A
		public EContextType ContextType { get; set; }

		// Token: 0x04018557 RID: 99671
		public IBuffDamageParam DamageParam;

		// Token: 0x04018558 RID: 99672
		public Partial_RequirementPayload Payload;

		// Token: 0x04018559 RID: 99673
		public float ExtraRate;

		// Token: 0x0401855A RID: 99674
		public long ContextId;

		// Token: 0x0401855B RID: 99675
		public BaseDamageComponent Victim;
	}
}
