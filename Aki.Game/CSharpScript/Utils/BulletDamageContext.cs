using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02003436 RID: 13366
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletDamageContext : BaseContext, IExpressionContext
	{
		// Token: 0x170046A8 RID: 18088
		// (get) Token: 0x06021F02 RID: 139010 RVA: 0x00971B10 File Offset: 0x0096FD10
		// (set) Token: 0x06021F03 RID: 139011 RVA: 0x00971B18 File Offset: 0x0096FD18
		public EContextType ContextType { get; set; }

		// Token: 0x04012B74 RID: 76660
		public IBulletDamageParam DamageParam;

		// Token: 0x04012B75 RID: 76661
		public int BulletEntityId;

		// Token: 0x04012B76 RID: 76662
		public long ContextId;

		// Token: 0x04012B77 RID: 76663
		public BulletDamageResult Result;

		// Token: 0x04012B78 RID: 76664
		public BaseDamageComponent Victim;
	}
}
