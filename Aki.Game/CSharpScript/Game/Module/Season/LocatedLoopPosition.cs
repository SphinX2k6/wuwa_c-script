using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02004C78 RID: 19576
	[RequiredMember]
	internal class LocatedLoopPosition : ILocatedLoopPosition
	{
		// Token: 0x17007CD4 RID: 31956
		// (get) Token: 0x0603298B RID: 207243 RVA: 0x00BCC546 File Offset: 0x00BCA746
		// (set) Token: 0x0603298C RID: 207244 RVA: 0x00BCC54E File Offset: 0x00BCA74E
		[RequiredMember]
		public ESeason Season { get; set; }

		// Token: 0x17007CD5 RID: 31957
		// (get) Token: 0x0603298D RID: 207245 RVA: 0x00BCC557 File Offset: 0x00BCA757
		// (set) Token: 0x0603298E RID: 207246 RVA: 0x00BCC55F File Offset: 0x00BCA75F
		[RequiredMember]
		public ESeasonLoopPhase Phase { get; set; }

		// Token: 0x0603298F RID: 207247 RVA: 0x00BCC568 File Offset: 0x00BCA768
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LocatedLoopPosition()
		{
		}
	}
}
