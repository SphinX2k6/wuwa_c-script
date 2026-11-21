using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003438 RID: 13368
	[NullableContext(1)]
	[Nullable(0)]
	public class BuffShareDamageContext : BaseContext, IExpressionContext
	{
		// Token: 0x170046AA RID: 18090
		// (get) Token: 0x06021F08 RID: 139016 RVA: 0x00971B42 File Offset: 0x0096FD42
		// (set) Token: 0x06021F09 RID: 139017 RVA: 0x00971B4A File Offset: 0x0096FD4A
		public EContextType ContextType { get; set; }

		// Token: 0x04012B7F RID: 76671
		public IBuffDamageParam DamageParam;

		// Token: 0x04012B80 RID: 76672
		public Partial_RequirementPayload Payload;

		// Token: 0x04012B81 RID: 76673
		public float ExtraRate;

		// Token: 0x04012B82 RID: 76674
		public long ContextId;

		// Token: 0x04012B83 RID: 76675
		public BaseDamageComponent Victim;
	}
}
