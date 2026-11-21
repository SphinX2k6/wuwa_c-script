using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020045F0 RID: 17904
	public class ITakePhoto2TargetEntityTypeT
	{
		// Token: 0x17007D42 RID: 32066
		// (get) Token: 0x0601A2A9 RID: 107177 RVA: 0x003BA3AD File Offset: 0x003B85AD
		// (set) Token: 0x0601A2AA RID: 107178 RVA: 0x003BA3B5 File Offset: 0x003B85B5
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x17007D43 RID: 32067
		// (get) Token: 0x0601A2AB RID: 107179 RVA: 0x003BA3BE File Offset: 0x003B85BE
		// (set) Token: 0x0601A2AC RID: 107180 RVA: 0x003BA3C6 File Offset: 0x003B85C6
		public bool IsOptionalTarget { get; set; }

		// Token: 0x17007D44 RID: 32068
		// (get) Token: 0x0601A2AD RID: 107181 RVA: 0x003BA3CF File Offset: 0x003B85CF
		// (set) Token: 0x0601A2AE RID: 107182 RVA: 0x003BA3D7 File Offset: 0x003B85D7
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x17007D45 RID: 32069
		// (get) Token: 0x0601A2AF RID: 107183 RVA: 0x003BA3E0 File Offset: 0x003B85E0
		// (set) Token: 0x0601A2B0 RID: 107184 RVA: 0x003BA3E8 File Offset: 0x003B85E8
		public IEntityCategoryT EntityCategory { get; set; }

		// Token: 0x17007D46 RID: 32070
		// (get) Token: 0x0601A2B1 RID: 107185 RVA: 0x003BA3F1 File Offset: 0x003B85F1
		// (set) Token: 0x0601A2B2 RID: 107186 RVA: 0x003BA3F9 File Offset: 0x003B85F9
		public ITakePhoto2TargetPosByRangeConditionT TargetPosCondition { get; set; }

		// Token: 0x17007D47 RID: 32071
		// (get) Token: 0x0601A2B3 RID: 107187 RVA: 0x003BA402 File Offset: 0x003B8602
		// (set) Token: 0x0601A2B4 RID: 107188 RVA: 0x003BA40A File Offset: 0x003B860A
		public ITakePhoto2TargetPlayMontageConditionT TargetPlayMontageCondition { get; set; }

		// Token: 0x17007D48 RID: 32072
		// (get) Token: 0x0601A2B5 RID: 107189 RVA: 0x003BA413 File Offset: 0x003B8613
		// (set) Token: 0x0601A2B6 RID: 107190 RVA: 0x003BA41B File Offset: 0x003B861B
		public ITakePhoto2TargetAnsTagConditionT TargetAnsTagCondition { get; set; }

		// Token: 0x17007D49 RID: 32073
		// (get) Token: 0x0601A2B7 RID: 107191 RVA: 0x003BA424 File Offset: 0x003B8624
		// (set) Token: 0x0601A2B8 RID: 107192 RVA: 0x003BA42C File Offset: 0x003B862C
		public int TargetSatisfiedCount { get; set; }

		// Token: 0x17007D4A RID: 32074
		// (get) Token: 0x0601A2B9 RID: 107193 RVA: 0x003BA435 File Offset: 0x003B8635
		// (set) Token: 0x0601A2BA RID: 107194 RVA: 0x003BA43D File Offset: 0x003B863D
		public byte NullMask { get; set; }

		// Token: 0x0601A2BB RID: 107195 RVA: 0x003BA448 File Offset: 0x003B8648
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
