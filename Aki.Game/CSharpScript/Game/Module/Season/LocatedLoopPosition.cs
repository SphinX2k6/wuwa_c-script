using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Season
{
	// Token: 0x02003C29 RID: 15401
	[RequiredMember]
	internal class LocatedLoopPosition : ILocatedLoopPosition
	{
		// Token: 0x1700507E RID: 20606
		// (get) Token: 0x0602773E RID: 161598 RVA: 0x00B111AA File Offset: 0x00B0F3AA
		// (set) Token: 0x0602773F RID: 161599 RVA: 0x00B111B2 File Offset: 0x00B0F3B2
		[RequiredMember]
		public ESeason Season { get; set; }

		// Token: 0x1700507F RID: 20607
		// (get) Token: 0x06027740 RID: 161600 RVA: 0x00B111BB File Offset: 0x00B0F3BB
		// (set) Token: 0x06027741 RID: 161601 RVA: 0x00B111C3 File Offset: 0x00B0F3C3
		[RequiredMember]
		public ESeasonLoopPhase Phase { get; set; }

		// Token: 0x06027742 RID: 161602 RVA: 0x00B111CC File Offset: 0x00B0F3CC
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public LocatedLoopPosition()
		{
		}
	}
}
