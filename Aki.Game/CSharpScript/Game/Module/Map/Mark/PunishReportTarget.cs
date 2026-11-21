using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x02004498 RID: 17560
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class PunishReportTarget
	{
		// Token: 0x0602C5A0 RID: 181664 RVA: 0x00C778EB File Offset: 0x00C75AEB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public PunishReportTarget()
		{
		}

		// Token: 0x04017D81 RID: 97665
		[RequiredMember]
		public List<EPunishReportTargetState> States;

		// Token: 0x04017D82 RID: 97666
		[RequiredMember]
		public List<string> ConditionTxtIds;

		// Token: 0x04017D83 RID: 97667
		[RequiredMember]
		public long GetBoxNum;
	}
}
