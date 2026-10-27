using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace CSharpScript.Game.Module.Plot.Avg
{
	// Token: 0x020050E5 RID: 20709
	[NullableContext(1)]
	[Nullable(0)]
	[RequiredMember]
	public class AvgTalkerMoveActionContext
	{
		// Token: 0x17008094 RID: 32916
		// (get) Token: 0x06034F8F RID: 216975 RVA: 0x00C8C5FB File Offset: 0x00C8A7FB
		// (set) Token: 0x06034F90 RID: 216976 RVA: 0x00C8C603 File Offset: 0x00C8A803
		public int CharacterId { get; set; }

		// Token: 0x17008095 RID: 32917
		// (get) Token: 0x06034F91 RID: 216977 RVA: 0x00C8C60C File Offset: 0x00C8A80C
		// (set) Token: 0x06034F92 RID: 216978 RVA: 0x00C8C614 File Offset: 0x00C8A814
		public EAvgRoleAnimationType AnimationType { get; set; }

		// Token: 0x17008096 RID: 32918
		// (get) Token: 0x06034F93 RID: 216979 RVA: 0x00C8C61D File Offset: 0x00C8A81D
		// (set) Token: 0x06034F94 RID: 216980 RVA: 0x00C8C625 File Offset: 0x00C8A825
		public EAvgRolePosition TargetPosition { get; set; }

		// Token: 0x17008097 RID: 32919
		// (get) Token: 0x06034F95 RID: 216981 RVA: 0x00C8C62E File Offset: 0x00C8A82E
		// (set) Token: 0x06034F96 RID: 216982 RVA: 0x00C8C636 File Offset: 0x00C8A836
		[RequiredMember]
		public IEaseData EaseCurve { get; set; }

		// Token: 0x06034F97 RID: 216983 RVA: 0x00C8C63F File Offset: 0x00C8A83F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public AvgTalkerMoveActionContext()
		{
		}
	}
}
