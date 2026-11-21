using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x02003485 RID: 13445
	[RequiredMember]
	public class CustomPriorityCallbackParam : ICustomPriorityCallbackParam
	{
		// Token: 0x1700480E RID: 18446
		// (get) Token: 0x060224A8 RID: 140456 RVA: 0x009B78E7 File Offset: 0x009B5AE7
		// (set) Token: 0x060224A9 RID: 140457 RVA: 0x009B78EF File Offset: 0x009B5AEF
		public bool? IsReentrant { get; set; }

		// Token: 0x1700480F RID: 18447
		// (get) Token: 0x060224AA RID: 140458 RVA: 0x009B78F8 File Offset: 0x009B5AF8
		// (set) Token: 0x060224AB RID: 140459 RVA: 0x009B7900 File Offset: 0x009B5B00
		[RequiredMember]
		public bool IsForce { get; set; }

		// Token: 0x060224AC RID: 140460 RVA: 0x009B7909 File Offset: 0x009B5B09
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CustomPriorityCallbackParam()
		{
		}
	}
}
