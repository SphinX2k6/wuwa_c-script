using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Utils
{
	// Token: 0x02004514 RID: 17684
	[NullableContext(1)]
	[Nullable(0)]
	public class BulletDamageContext : BaseContext, IExpressionContext
	{
		// Token: 0x170073F0 RID: 29680
		// (get) Token: 0x0602D832 RID: 186418 RVA: 0x00A45D00 File Offset: 0x00A43F00
		// (set) Token: 0x0602D833 RID: 186419 RVA: 0x00A45D08 File Offset: 0x00A43F08
		public EContextType ContextType { get; set; }

		// Token: 0x0401854C RID: 99660
		public IBulletDamageParam DamageParam;

		// Token: 0x0401854D RID: 99661
		public int BulletEntityId;

		// Token: 0x0401854E RID: 99662
		public long ContextId;

		// Token: 0x0401854F RID: 99663
		public BulletDamageResult Result;

		// Token: 0x04018550 RID: 99664
		public BaseDamageComponent Victim;
	}
}
