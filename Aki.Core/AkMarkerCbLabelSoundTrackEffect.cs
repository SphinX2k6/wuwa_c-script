using System;
using System.Runtime.CompilerServices;

// Token: 0x02000012 RID: 18
[RequiredMember]
public class AkMarkerCbLabelSoundTrackEffect : AkMarkerCbLabel
{
	// Token: 0x0600008B RID: 139 RVA: 0x00005A6D File Offset: 0x00003C6D
	[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
	[CompilerFeatureRequired("RequiredMembers")]
	public AkMarkerCbLabelSoundTrackEffect()
	{
	}

	// Token: 0x04000072 RID: 114
	[Nullable(1)]
	[RequiredMember]
	public string Action;

	// Token: 0x04000073 RID: 115
	public int? Length;

	// Token: 0x04000074 RID: 116
	public double? MaxDistance;
}
