using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B3D RID: 27453
	public class IMotorSoarInWindFieldEnterWindFieldT
	{
		// Token: 0x1700CBFC RID: 52220
		// (get) Token: 0x060302FB RID: 197371 RVA: 0x0068C8E2 File Offset: 0x0068AAE2
		// (set) Token: 0x060302FC RID: 197372 RVA: 0x0068C8EA File Offset: 0x0068AAEA
		public EMotorSoarInWindFieldControlType Type { get; set; }

		// Token: 0x1700CBFD RID: 52221
		// (get) Token: 0x060302FD RID: 197373 RVA: 0x0068C8F3 File Offset: 0x0068AAF3
		// (set) Token: 0x060302FE RID: 197374 RVA: 0x0068C8FB File Offset: 0x0068AAFB
		public IVectorInfoT Direction { get; set; }

		// Token: 0x1700CBFE RID: 52222
		// (get) Token: 0x060302FF RID: 197375 RVA: 0x0068C904 File Offset: 0x0068AB04
		// (set) Token: 0x06030300 RID: 197376 RVA: 0x0068C90C File Offset: 0x0068AB0C
		public IVectorInfoT Offset { get; set; }

		// Token: 0x1700CBFF RID: 52223
		// (get) Token: 0x06030301 RID: 197377 RVA: 0x0068C915 File Offset: 0x0068AB15
		// (set) Token: 0x06030302 RID: 197378 RVA: 0x0068C91D File Offset: 0x0068AB1D
		public float WindFieldDepth { get; set; }

		// Token: 0x1700CC00 RID: 52224
		// (get) Token: 0x06030303 RID: 197379 RVA: 0x0068C926 File Offset: 0x0068AB26
		// (set) Token: 0x06030304 RID: 197380 RVA: 0x0068C92E File Offset: 0x0068AB2E
		public float MaxAdditionalSpeed { get; set; }

		// Token: 0x1700CC01 RID: 52225
		// (get) Token: 0x06030305 RID: 197381 RVA: 0x0068C937 File Offset: 0x0068AB37
		// (set) Token: 0x06030306 RID: 197382 RVA: 0x0068C93F File Offset: 0x0068AB3F
		public string SpeedCurve { get; set; }

		// Token: 0x1700CC02 RID: 52226
		// (get) Token: 0x06030307 RID: 197383 RVA: 0x0068C948 File Offset: 0x0068AB48
		// (set) Token: 0x06030308 RID: 197384 RVA: 0x0068C950 File Offset: 0x0068AB50
		public float SpeedTolerance { get; set; }

		// Token: 0x06030309 RID: 197385 RVA: 0x0068C95C File Offset: 0x0068AB5C
		public IMotorSoarInWindFieldEnterWindFieldT()
		{
			this.Type = EMotorSoarInWindFieldControlType.EnterWindField;
			this.Direction = null;
			this.Offset = null;
			this.WindFieldDepth = 0f;
			this.MaxAdditionalSpeed = 0f;
			this.SpeedCurve = null;
			this.SpeedTolerance = 0f;
		}
	}
}
