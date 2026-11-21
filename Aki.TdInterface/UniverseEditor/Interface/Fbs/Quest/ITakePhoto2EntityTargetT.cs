using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045C9 RID: 17865
	public class ITakePhoto2EntityTargetT
	{
		// Token: 0x17007CF1 RID: 31985
		// (get) Token: 0x0601A16B RID: 106859 RVA: 0x003B7F31 File Offset: 0x003B6131
		// (set) Token: 0x0601A16C RID: 106860 RVA: 0x003B7F39 File Offset: 0x003B6139
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x17007CF2 RID: 31986
		// (get) Token: 0x0601A16D RID: 106861 RVA: 0x003B7F42 File Offset: 0x003B6142
		// (set) Token: 0x0601A16E RID: 106862 RVA: 0x003B7F4A File Offset: 0x003B614A
		public bool IsOptionalTarget { get; set; }

		// Token: 0x17007CF3 RID: 31987
		// (get) Token: 0x0601A16F RID: 106863 RVA: 0x003B7F53 File Offset: 0x003B6153
		// (set) Token: 0x0601A170 RID: 106864 RVA: 0x003B7F5B File Offset: 0x003B615B
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x17007CF4 RID: 31988
		// (get) Token: 0x0601A171 RID: 106865 RVA: 0x003B7F64 File Offset: 0x003B6164
		// (set) Token: 0x0601A172 RID: 106866 RVA: 0x003B7F6C File Offset: 0x003B616C
		public int EntityId { get; set; }

		// Token: 0x17007CF5 RID: 31989
		// (get) Token: 0x0601A173 RID: 106867 RVA: 0x003B7F75 File Offset: 0x003B6175
		// (set) Token: 0x0601A174 RID: 106868 RVA: 0x003B7F7D File Offset: 0x003B617D
		public ITakePhoto2TargetPosByRangeConditionT TargetPosCondition { get; set; }

		// Token: 0x17007CF6 RID: 31990
		// (get) Token: 0x0601A175 RID: 106869 RVA: 0x003B7F86 File Offset: 0x003B6186
		// (set) Token: 0x0601A176 RID: 106870 RVA: 0x003B7F8E File Offset: 0x003B618E
		public ITakePhoto2TargetPlayMontageConditionT TargetPlayMontageCondition { get; set; }

		// Token: 0x17007CF7 RID: 31991
		// (get) Token: 0x0601A177 RID: 106871 RVA: 0x003B7F97 File Offset: 0x003B6197
		// (set) Token: 0x0601A178 RID: 106872 RVA: 0x003B7F9F File Offset: 0x003B619F
		public ITakePhoto2TargetAnsTagConditionT TargetAnsTagCondition { get; set; }

		// Token: 0x17007CF8 RID: 31992
		// (get) Token: 0x0601A179 RID: 106873 RVA: 0x003B7FA8 File Offset: 0x003B61A8
		// (set) Token: 0x0601A17A RID: 106874 RVA: 0x003B7FB0 File Offset: 0x003B61B0
		public ITakePhoto2TargetPartConditionT TargetPartCondition { get; set; }

		// Token: 0x17007CF9 RID: 31993
		// (get) Token: 0x0601A17B RID: 106875 RVA: 0x003B7FB9 File Offset: 0x003B61B9
		// (set) Token: 0x0601A17C RID: 106876 RVA: 0x003B7FC1 File Offset: 0x003B61C1
		public byte NullMask { get; set; }

		// Token: 0x0601A17D RID: 106877 RVA: 0x003B7FCC File Offset: 0x003B61CC
		public ITakePhoto2EntityTargetT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.EntityId = 0;
			this.TargetPosCondition = null;
			this.TargetPlayMontageCondition = null;
			this.TargetAnsTagCondition = null;
			this.TargetPartCondition = null;
			this.NullMask = 0;
		}
	}
}
