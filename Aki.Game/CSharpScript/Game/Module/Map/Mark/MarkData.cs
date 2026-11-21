using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x0200449B RID: 17563
	[RequiredMember]
	public class MarkData
	{
		// Token: 0x0602C5A1 RID: 181665 RVA: 0x00C778F3 File Offset: 0x00C75AF3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MarkData()
		{
		}

		// Token: 0x04017D8A RID: 97674
		[Nullable(1)]
		[RequiredMember]
		public string Icon;

		// Token: 0x04017D8B RID: 97675
		[Nullable(2)]
		public TTrackTarget TrackTarget;

		// Token: 0x04017D8C RID: 97676
		public bool? TrackHudEnable;

		// Token: 0x04017D8D RID: 97677
		public float? TrackAutoCancelDistance;

		// Token: 0x04017D8E RID: 97678
		public int TargetInstanceOrMapId;

		// Token: 0x04017D8F RID: 97679
		public int? MultiMapId;

		// Token: 0x04017D90 RID: 97680
		public int? AreaId;
	}
}
