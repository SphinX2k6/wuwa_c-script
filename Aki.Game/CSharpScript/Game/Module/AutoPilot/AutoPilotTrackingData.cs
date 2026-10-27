using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.AutoPilot
{
	// Token: 0x02005E73 RID: 24179
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class AutoPilotTrackingData : AutoPilotDefine.IAutoPilotTrackingData
	{
		// Token: 0x17008E82 RID: 36482
		// (get) Token: 0x0603D7EC RID: 251884 RVA: 0x00ED74D1 File Offset: 0x00ED56D1
		// (set) Token: 0x0603D7ED RID: 251885 RVA: 0x00ED74D9 File Offset: 0x00ED56D9
		[RequiredMember]
		public Vector TargetPos { get; set; }

		// Token: 0x17008E83 RID: 36483
		// (get) Token: 0x0603D7EE RID: 251886 RVA: 0x00ED74E2 File Offset: 0x00ED56E2
		// (set) Token: 0x0603D7EF RID: 251887 RVA: 0x00ED74EA File Offset: 0x00ED56EA
		public int MapId { get; set; }

		// Token: 0x0603D7F0 RID: 251888 RVA: 0x00ED74F3 File Offset: 0x00ED56F3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AutoPilotTrackingData()
		{
		}
	}
}
