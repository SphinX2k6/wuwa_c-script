using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054B8 RID: 21688
	[RequiredMember]
	public class MarkData
	{
		// Token: 0x0603764B RID: 226891 RVA: 0x00D27B77 File Offset: 0x00D25D77
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MarkData()
		{
		}

		// Token: 0x0401D2EE RID: 119534
		[Nullable(1)]
		[RequiredMember]
		public string Icon;

		// Token: 0x0401D2EF RID: 119535
		[Nullable(2)]
		public TTrackTarget TrackTarget;

		// Token: 0x0401D2F0 RID: 119536
		public bool? TrackHudEnable;

		// Token: 0x0401D2F1 RID: 119537
		public float? TrackAutoCancelDistance;

		// Token: 0x0401D2F2 RID: 119538
		public int TargetInstanceOrMapId;

		// Token: 0x0401D2F3 RID: 119539
		public int? MultiMapId;

		// Token: 0x0401D2F4 RID: 119540
		public int? AreaId;
	}
}
