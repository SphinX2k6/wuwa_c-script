using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F81 RID: 20353
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class QuickHackLockTargetInfo : IQuickHackLockTargetInfo
	{
		// Token: 0x17007F5D RID: 32605
		// (get) Token: 0x060341E7 RID: 213479 RVA: 0x00C3B475 File Offset: 0x00C39675
		// (set) Token: 0x060341E8 RID: 213480 RVA: 0x00C3B47D File Offset: 0x00C3967D
		public EQuickHackTargetType? HackType { get; set; }

		// Token: 0x17007F5E RID: 32606
		// (get) Token: 0x060341E9 RID: 213481 RVA: 0x00C3B486 File Offset: 0x00C39686
		// (set) Token: 0x060341EA RID: 213482 RVA: 0x00C3B48E File Offset: 0x00C3968E
		[RequiredMember]
		public IEnumerable<EntityHandle> Targets { get; set; }

		// Token: 0x060341EB RID: 213483 RVA: 0x00C3B497 File Offset: 0x00C39697
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public QuickHackLockTargetInfo()
		{
		}
	}
}
