using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004197 RID: 16791
	public class ITakePhoto2TargetEntityTypeT
	{
		// Token: 0x17007716 RID: 30486
		// (get) Token: 0x06018B53 RID: 101203 RVA: 0x0038EF59 File Offset: 0x0038D159
		// (set) Token: 0x06018B54 RID: 101204 RVA: 0x0038EF61 File Offset: 0x0038D161
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x17007717 RID: 30487
		// (get) Token: 0x06018B55 RID: 101205 RVA: 0x0038EF6A File Offset: 0x0038D16A
		// (set) Token: 0x06018B56 RID: 101206 RVA: 0x0038EF72 File Offset: 0x0038D172
		public bool IsOptionalTarget { get; set; }

		// Token: 0x17007718 RID: 30488
		// (get) Token: 0x06018B57 RID: 101207 RVA: 0x0038EF7B File Offset: 0x0038D17B
		// (set) Token: 0x06018B58 RID: 101208 RVA: 0x0038EF83 File Offset: 0x0038D183
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x17007719 RID: 30489
		// (get) Token: 0x06018B59 RID: 101209 RVA: 0x0038EF8C File Offset: 0x0038D18C
		// (set) Token: 0x06018B5A RID: 101210 RVA: 0x0038EF94 File Offset: 0x0038D194
		public IEntityCategoryT EntityCategory { get; set; }

		// Token: 0x1700771A RID: 30490
		// (get) Token: 0x06018B5B RID: 101211 RVA: 0x0038EF9D File Offset: 0x0038D19D
		// (set) Token: 0x06018B5C RID: 101212 RVA: 0x0038EFA5 File Offset: 0x0038D1A5
		public ITakePhoto2TargetPosByRangeConditionT TargetPosCondition { get; set; }

		// Token: 0x1700771B RID: 30491
		// (get) Token: 0x06018B5D RID: 101213 RVA: 0x0038EFAE File Offset: 0x0038D1AE
		// (set) Token: 0x06018B5E RID: 101214 RVA: 0x0038EFB6 File Offset: 0x0038D1B6
		public ITakePhoto2TargetPlayMontageConditionT TargetPlayMontageCondition { get; set; }

		// Token: 0x1700771C RID: 30492
		// (get) Token: 0x06018B5F RID: 101215 RVA: 0x0038EFBF File Offset: 0x0038D1BF
		// (set) Token: 0x06018B60 RID: 101216 RVA: 0x0038EFC7 File Offset: 0x0038D1C7
		public ITakePhoto2TargetAnsTagConditionT TargetAnsTagCondition { get; set; }

		// Token: 0x1700771D RID: 30493
		// (get) Token: 0x06018B61 RID: 101217 RVA: 0x0038EFD0 File Offset: 0x0038D1D0
		// (set) Token: 0x06018B62 RID: 101218 RVA: 0x0038EFD8 File Offset: 0x0038D1D8
		public int TargetSatisfiedCount { get; set; }

		// Token: 0x1700771E RID: 30494
		// (get) Token: 0x06018B63 RID: 101219 RVA: 0x0038EFE1 File Offset: 0x0038D1E1
		// (set) Token: 0x06018B64 RID: 101220 RVA: 0x0038EFE9 File Offset: 0x0038D1E9
		public byte NullMask { get; set; }

		// Token: 0x06018B65 RID: 101221 RVA: 0x0038EFF4 File Offset: 0x0038D1F4
		public ITakePhoto2TargetEntityTypeT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.EntityCategory = null;
			this.TargetPosCondition = null;
			this.TargetPlayMontageCondition = null;
			this.TargetAnsTagCondition = null;
			this.TargetSatisfiedCount = 0;
			this.NullMask = 0;
		}
	}
}
