using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020040B5 RID: 16565
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class AvgTalkerMoveActionContext
	{
		// Token: 0x17005454 RID: 21588
		// (get) Token: 0x06029E88 RID: 171656 RVA: 0x00BD98E3 File Offset: 0x00BD7AE3
		// (set) Token: 0x06029E89 RID: 171657 RVA: 0x00BD98EB File Offset: 0x00BD7AEB
		public int CharacterId { get; set; }

		// Token: 0x17005455 RID: 21589
		// (get) Token: 0x06029E8A RID: 171658 RVA: 0x00BD98F4 File Offset: 0x00BD7AF4
		// (set) Token: 0x06029E8B RID: 171659 RVA: 0x00BD98FC File Offset: 0x00BD7AFC
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x17005456 RID: 21590
		// (get) Token: 0x06029E8C RID: 171660 RVA: 0x00BD9905 File Offset: 0x00BD7B05
		// (set) Token: 0x06029E8D RID: 171661 RVA: 0x00BD990D File Offset: 0x00BD7B0D
		public EAvgRolePosition TargetPosition { get; set; }

		// Token: 0x17005457 RID: 21591
		// (get) Token: 0x06029E8E RID: 171662 RVA: 0x00BD9916 File Offset: 0x00BD7B16
		// (set) Token: 0x06029E8F RID: 171663 RVA: 0x00BD991E File Offset: 0x00BD7B1E
		[RequiredMember]
		public IEaseData EaseCurve { get; set; }

		// Token: 0x06029E90 RID: 171664 RVA: 0x00BD9927 File Offset: 0x00BD7B27
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AvgTalkerMoveActionContext()
		{
		}
	}
}
