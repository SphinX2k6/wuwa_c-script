using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045E7 RID: 17895
	public class ITakePhoto2TargetT
	{
		// Token: 0x17007D2E RID: 32046
		// (get) Token: 0x0601A25B RID: 107099 RVA: 0x003B993F File Offset: 0x003B7B3F
		// (set) Token: 0x0601A25C RID: 107100 RVA: 0x003B9947 File Offset: 0x003B7B47
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x17007D2F RID: 32047
		// (get) Token: 0x0601A25D RID: 107101 RVA: 0x003B9950 File Offset: 0x003B7B50
		// (set) Token: 0x0601A25E RID: 107102 RVA: 0x003B9958 File Offset: 0x003B7B58
		public bool IsOptionalTarget { get; set; }

		// Token: 0x17007D30 RID: 32048
		// (get) Token: 0x0601A25F RID: 107103 RVA: 0x003B9961 File Offset: 0x003B7B61
		// (set) Token: 0x0601A260 RID: 107104 RVA: 0x003B9969 File Offset: 0x003B7B69
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x17007D31 RID: 32049
		// (get) Token: 0x0601A261 RID: 107105 RVA: 0x003B9972 File Offset: 0x003B7B72
		// (set) Token: 0x0601A262 RID: 107106 RVA: 0x003B997A File Offset: 0x003B7B7A
		public byte NullMask { get; set; }

		// Token: 0x0601A263 RID: 107107 RVA: 0x003B9983 File Offset: 0x003B7B83
		public ITakePhoto2TargetT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.NullMask = 0;
		}
	}
}
