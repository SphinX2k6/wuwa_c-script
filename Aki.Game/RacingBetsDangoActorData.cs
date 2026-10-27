using System;
using System.Runtime.CompilerServices;

// Token: 0x020026F8 RID: 9976
[NullableContext(1)]
[Nullable(0)]
public class RacingBetsDangoActorData : IRacingBetsDangoActorData
{
	// Token: 0x17001AB3 RID: 6835
	// (get) Token: 0x0601473F RID: 83775 RVA: 0x0052BA95 File Offset: 0x00529C95
	// (set) Token: 0x06014740 RID: 83776 RVA: 0x0052BA9D File Offset: 0x00529C9D
	public EUiModelUseWay UiModelUseWay { get; set; }

	// Token: 0x17001AB4 RID: 6836
	// (get) Token: 0x06014741 RID: 83777 RVA: 0x0052BAA6 File Offset: 0x00529CA6
	// (set) Token: 0x06014742 RID: 83778 RVA: 0x0052BAAE File Offset: 0x00529CAE
	public int DangoId { get; set; }

	// Token: 0x17001AB5 RID: 6837
	// (get) Token: 0x06014743 RID: 83779 RVA: 0x0052BAB7 File Offset: 0x00529CB7
	// (set) Token: 0x06014744 RID: 83780 RVA: 0x0052BABF File Offset: 0x00529CBF
	public int Odds { get; set; }

	// Token: 0x17001AB6 RID: 6838
	// (get) Token: 0x06014745 RID: 83781 RVA: 0x0052BAC8 File Offset: 0x00529CC8
	// (set) Token: 0x06014746 RID: 83782 RVA: 0x0052BAD0 File Offset: 0x00529CD0
	public string DangoPointCase { get; set; }

	// Token: 0x17001AB7 RID: 6839
	// (get) Token: 0x06014747 RID: 83783 RVA: 0x0052BAD9 File Offset: 0x00529CD9
	// (set) Token: 0x06014748 RID: 83784 RVA: 0x0052BAE1 File Offset: 0x00529CE1
	public string DangoCamera { get; set; }

	// Token: 0x17001AB8 RID: 6840
	// (get) Token: 0x06014749 RID: 83785 RVA: 0x0052BAEA File Offset: 0x00529CEA
	// (set) Token: 0x0601474A RID: 83786 RVA: 0x0052BAF2 File Offset: 0x00529CF2
	public float DangoOffset { get; set; }

	// Token: 0x17001AB9 RID: 6841
	// (get) Token: 0x0601474B RID: 83787 RVA: 0x0052BAFB File Offset: 0x00529CFB
	// (set) Token: 0x0601474C RID: 83788 RVA: 0x0052BB03 File Offset: 0x00529D03
	public bool IsAbuDango { get; set; }
}
