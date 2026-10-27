using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054B5 RID: 21685
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PunishReportTarget
	{
		// Token: 0x0603764A RID: 226890 RVA: 0x00D27B6F File Offset: 0x00D25D6F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PunishReportTarget()
		{
		}

		// Token: 0x0401D2E5 RID: 119525
		[RequiredMember]
		public List<EPunishReportTargetState> States;

		// Token: 0x0401D2E6 RID: 119526
		[RequiredMember]
		public List<string> ConditionTxtIds;

		// Token: 0x0401D2E7 RID: 119527
		[RequiredMember]
		public long GetBoxNum;
	}
}
