using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Utils.Priority
{
	// Token: 0x0200455D RID: 17757
	[RequiredMember]
	public class CustomPriorityCallbackParam : ICustomPriorityCallbackParam
	{
		// Token: 0x17007557 RID: 30039
		// (get) Token: 0x0602DDC6 RID: 187846 RVA: 0x00A8C1CF File Offset: 0x00A8A3CF
		// (set) Token: 0x0602DDC7 RID: 187847 RVA: 0x00A8C1D7 File Offset: 0x00A8A3D7
		public bool? IsReentrant { get; set; }

		// Token: 0x17007558 RID: 30040
		// (get) Token: 0x0602DDC8 RID: 187848 RVA: 0x00A8C1E0 File Offset: 0x00A8A3E0
		// (set) Token: 0x0602DDC9 RID: 187849 RVA: 0x00A8C1E8 File Offset: 0x00A8A3E8
		[RequiredMember]
		public bool IsForce { get; set; }

		// Token: 0x0602DDCA RID: 187850 RVA: 0x00A8C1F1 File Offset: 0x00A8A3F1
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CustomPriorityCallbackParam()
		{
		}
	}
}
