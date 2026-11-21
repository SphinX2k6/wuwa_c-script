using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F4A RID: 16202
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class QuickHackLockTargetInfo : IQuickHackLockTargetInfo
	{
		// Token: 0x1700530D RID: 21261
		// (get) Token: 0x06029055 RID: 168021 RVA: 0x00B84C21 File Offset: 0x00B82E21
		// (set) Token: 0x06029056 RID: 168022 RVA: 0x00B84C29 File Offset: 0x00B82E29
		public EQuickHackTargetType? HackType { get; set; }

		// Token: 0x1700530E RID: 21262
		// (get) Token: 0x06029057 RID: 168023 RVA: 0x00B84C32 File Offset: 0x00B82E32
		// (set) Token: 0x06029058 RID: 168024 RVA: 0x00B84C3A File Offset: 0x00B82E3A
		[RequiredMember]
		public IEnumerable<EntityHandle> Targets { get; set; }

		// Token: 0x06029059 RID: 168025 RVA: 0x00B84C43 File Offset: 0x00B82E43
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public QuickHackLockTargetInfo()
		{
		}
	}
}
