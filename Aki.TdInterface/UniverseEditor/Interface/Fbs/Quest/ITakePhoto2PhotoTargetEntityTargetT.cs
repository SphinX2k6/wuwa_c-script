using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045D5 RID: 17877
	public class ITakePhoto2PhotoTargetEntityTargetT
	{
		// Token: 0x17007D09 RID: 32009
		// (get) Token: 0x0601A1C7 RID: 106951 RVA: 0x003B8937 File Offset: 0x003B6B37
		// (set) Token: 0x0601A1C8 RID: 106952 RVA: 0x003B893F File Offset: 0x003B6B3F
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x17007D0A RID: 32010
		// (get) Token: 0x0601A1C9 RID: 106953 RVA: 0x003B8948 File Offset: 0x003B6B48
		// (set) Token: 0x0601A1CA RID: 106954 RVA: 0x003B8950 File Offset: 0x003B6B50
		public bool IsOptionalTarget { get; set; }

		// Token: 0x17007D0B RID: 32011
		// (get) Token: 0x0601A1CB RID: 106955 RVA: 0x003B8959 File Offset: 0x003B6B59
		// (set) Token: 0x0601A1CC RID: 106956 RVA: 0x003B8961 File Offset: 0x003B6B61
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x17007D0C RID: 32012
		// (get) Token: 0x0601A1CD RID: 106957 RVA: 0x003B896A File Offset: 0x003B6B6A
		// (set) Token: 0x0601A1CE RID: 106958 RVA: 0x003B8972 File Offset: 0x003B6B72
		public int EntityId { get; set; }

		// Token: 0x17007D0D RID: 32013
		// (get) Token: 0x0601A1CF RID: 106959 RVA: 0x003B897B File Offset: 0x003B6B7B
		// (set) Token: 0x0601A1D0 RID: 106960 RVA: 0x003B8983 File Offset: 0x003B6B83
		public ITakePhoto2TargetPosByRangeConditionT TargetPosCondition { get; set; }

		// Token: 0x17007D0E RID: 32014
		// (get) Token: 0x0601A1D1 RID: 106961 RVA: 0x003B898C File Offset: 0x003B6B8C
		// (set) Token: 0x0601A1D2 RID: 106962 RVA: 0x003B8994 File Offset: 0x003B6B94
		public byte NullMask { get; set; }

		// Token: 0x0601A1D3 RID: 106963 RVA: 0x003B899D File Offset: 0x003B6B9D
		public ITakePhoto2PhotoTargetEntityTargetT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.EntityId = 0;
			this.TargetPosCondition = null;
			this.NullMask = 0;
		}
	}
}
