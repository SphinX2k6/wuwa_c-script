using System;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200418E RID: 16782
	public class ITakePhoto2TargetT
	{
		// Token: 0x17007702 RID: 30466
		// (get) Token: 0x06018B05 RID: 101125 RVA: 0x0038E4EB File Offset: 0x0038C6EB
		// (set) Token: 0x06018B06 RID: 101126 RVA: 0x0038E4F3 File Offset: 0x0038C6F3
		public ETakePhoto2TargetType Type { get; set; }

		// Token: 0x17007703 RID: 30467
		// (get) Token: 0x06018B07 RID: 101127 RVA: 0x0038E4FC File Offset: 0x0038C6FC
		// (set) Token: 0x06018B08 RID: 101128 RVA: 0x0038E504 File Offset: 0x0038C704
		public bool IsOptionalTarget { get; set; }

		// Token: 0x17007704 RID: 30468
		// (get) Token: 0x06018B09 RID: 101129 RVA: 0x0038E50D File Offset: 0x0038C70D
		// (set) Token: 0x06018B0A RID: 101130 RVA: 0x0038E515 File Offset: 0x0038C715
		public ITakePhoto2TargetCameraDistanceConditionT TargetCameraDistanceCondition { get; set; }

		// Token: 0x17007705 RID: 30469
		// (get) Token: 0x06018B0B RID: 101131 RVA: 0x0038E51E File Offset: 0x0038C71E
		// (set) Token: 0x06018B0C RID: 101132 RVA: 0x0038E526 File Offset: 0x0038C726
		public byte NullMask { get; set; }

		// Token: 0x06018B0D RID: 101133 RVA: 0x0038E52F File Offset: 0x0038C72F
		public ITakePhoto2TargetT()
		{
			this.Type = ETakePhoto2TargetType.Entity;
			this.IsOptionalTarget = false;
			this.TargetCameraDistanceCondition = null;
			this.NullMask = 0;
		}
	}
}
