using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067D0 RID: 26576
	public class IAdjustPlayerCameraGravityT
	{
		// Token: 0x1700C30D RID: 49933
		// (get) Token: 0x0602D577 RID: 185719 RVA: 0x006355CD File Offset: 0x006337CD
		// (set) Token: 0x0602D578 RID: 185720 RVA: 0x006355D5 File Offset: 0x006337D5
		public TGravityDirectionUnion GravityDirection { get; set; }

		// Token: 0x1700C30E RID: 49934
		// (get) Token: 0x0602D579 RID: 185721 RVA: 0x006355DE File Offset: 0x006337DE
		// (set) Token: 0x0602D57A RID: 185722 RVA: 0x006355E6 File Offset: 0x006337E6
		public float LerpTime { get; set; }

		// Token: 0x1700C30F RID: 49935
		// (get) Token: 0x0602D57B RID: 185723 RVA: 0x006355EF File Offset: 0x006337EF
		// (set) Token: 0x0602D57C RID: 185724 RVA: 0x006355F7 File Offset: 0x006337F7
		public string LerpCurve { get; set; }

		// Token: 0x0602D57D RID: 185725 RVA: 0x00635600 File Offset: 0x00633800
		public IAdjustPlayerCameraGravityT()
		{
			this.GravityDirection = null;
			this.LerpTime = 0f;
			this.LerpCurve = null;
		}
	}
}
