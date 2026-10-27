using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200667F RID: 26239
	public class IEnableSectionalCameraOperationT
	{
		// Token: 0x1700C2E8 RID: 49896
		// (get) Token: 0x0602D967 RID: 186727 RVA: 0x0063D984 File Offset: 0x0063BB84
		// (set) Token: 0x0602D968 RID: 186728 RVA: 0x0063D98C File Offset: 0x0063BB8C
		public ECameraOperationType Type { get; set; }

		// Token: 0x1700C2E9 RID: 49897
		// (get) Token: 0x0602D969 RID: 186729 RVA: 0x0063D995 File Offset: 0x0063BB95
		// (set) Token: 0x0602D96A RID: 186730 RVA: 0x0063D99D File Offset: 0x0063BB9D
		public bool EnableRotate { get; set; }

		// Token: 0x1700C2EA RID: 49898
		// (get) Token: 0x0602D96B RID: 186731 RVA: 0x0063D9A6 File Offset: 0x0063BBA6
		// (set) Token: 0x0602D96C RID: 186732 RVA: 0x0063D9AE File Offset: 0x0063BBAE
		public bool EnableZoom { get; set; }

		// Token: 0x1700C2EB RID: 49899
		// (get) Token: 0x0602D96D RID: 186733 RVA: 0x0063D9B7 File Offset: 0x0063BBB7
		// (set) Token: 0x0602D96E RID: 186734 RVA: 0x0063D9BF File Offset: 0x0063BBBF
		public byte NullMask { get; set; }

		// Token: 0x0602D96F RID: 186735 RVA: 0x0063D9C8 File Offset: 0x0063BBC8
		public IEnableSectionalCameraOperationT()
		{
			this.Type = ECameraOperationType.Enable;
			this.EnableRotate = false;
			this.EnableZoom = false;
			this.NullMask = 0;
		}
	}
}
