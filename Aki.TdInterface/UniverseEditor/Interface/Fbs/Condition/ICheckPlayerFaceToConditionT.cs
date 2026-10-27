using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004AE8 RID: 19176
	public class ICheckPlayerFaceToConditionT
	{
		// Token: 0x17008B0D RID: 35597
		// (get) Token: 0x0601E220 RID: 123424 RVA: 0x0043A0E5 File Offset: 0x004382E5
		// (set) Token: 0x0601E221 RID: 123425 RVA: 0x0043A0ED File Offset: 0x004382ED
		public ECondition Type { get; set; }

		// Token: 0x17008B0E RID: 35598
		// (get) Token: 0x0601E222 RID: 123426 RVA: 0x0043A0F6 File Offset: 0x004382F6
		// (set) Token: 0x0601E223 RID: 123427 RVA: 0x0043A0FE File Offset: 0x004382FE
		public TTargetEntityUnion Target { get; set; }

		// Token: 0x17008B0F RID: 35599
		// (get) Token: 0x0601E224 RID: 123428 RVA: 0x0043A107 File Offset: 0x00438307
		// (set) Token: 0x0601E225 RID: 123429 RVA: 0x0043A10F File Offset: 0x0043830F
		public float AngleInterval { get; set; }

		// Token: 0x0601E226 RID: 123430 RVA: 0x0043A118 File Offset: 0x00438318
		public ICheckPlayerFaceToConditionT()
		{
			this.Type = ECondition.CompareVar;
			this.Target = null;
			this.AngleInterval = 0f;
		}
	}
}
