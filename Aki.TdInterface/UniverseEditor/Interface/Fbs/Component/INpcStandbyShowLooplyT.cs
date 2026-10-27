using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005660 RID: 22112
	public class INpcStandbyShowLooplyT
	{
		// Token: 0x1700A3D3 RID: 41939
		// (get) Token: 0x06024C63 RID: 150627 RVA: 0x0051304E File Offset: 0x0051124E
		// (set) Token: 0x06024C64 RID: 150628 RVA: 0x00513056 File Offset: 0x00511256
		public ENpcStandbyShowMode Type { get; set; }

		// Token: 0x1700A3D4 RID: 41940
		// (get) Token: 0x06024C65 RID: 150629 RVA: 0x0051305F File Offset: 0x0051125F
		// (set) Token: 0x06024C66 RID: 150630 RVA: 0x00513067 File Offset: 0x00511267
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x1700A3D5 RID: 41941
		// (get) Token: 0x06024C67 RID: 150631 RVA: 0x00513070 File Offset: 0x00511270
		// (set) Token: 0x06024C68 RID: 150632 RVA: 0x00513078 File Offset: 0x00511278
		public string Montage { get; set; }

		// Token: 0x1700A3D6 RID: 41942
		// (get) Token: 0x06024C69 RID: 150633 RVA: 0x00513081 File Offset: 0x00511281
		// (set) Token: 0x06024C6A RID: 150634 RVA: 0x00513089 File Offset: 0x00511289
		public IMontageIdT RegisteredMontageId { get; set; }

		// Token: 0x1700A3D7 RID: 41943
		// (get) Token: 0x06024C6B RID: 150635 RVA: 0x00513092 File Offset: 0x00511292
		// (set) Token: 0x06024C6C RID: 150636 RVA: 0x0051309A File Offset: 0x0051129A
		public int FaceExpressionId { get; set; }

		// Token: 0x1700A3D8 RID: 41944
		// (get) Token: 0x06024C6D RID: 150637 RVA: 0x005130A3 File Offset: 0x005112A3
		// (set) Token: 0x06024C6E RID: 150638 RVA: 0x005130AB File Offset: 0x005112AB
		public IIgnoreEntityIdsCollisionT IgnoreEntityCollision { get; set; }

		// Token: 0x1700A3D9 RID: 41945
		// (get) Token: 0x06024C6F RID: 150639 RVA: 0x005130B4 File Offset: 0x005112B4
		// (set) Token: 0x06024C70 RID: 150640 RVA: 0x005130BC File Offset: 0x005112BC
		public bool SetFadeInTimeToZero { get; set; }

		// Token: 0x1700A3DA RID: 41946
		// (get) Token: 0x06024C71 RID: 150641 RVA: 0x005130C5 File Offset: 0x005112C5
		// (set) Token: 0x06024C72 RID: 150642 RVA: 0x005130CD File Offset: 0x005112CD
		public byte NullMask { get; set; }

		// Token: 0x06024C73 RID: 150643 RVA: 0x005130D6 File Offset: 0x005112D6
		public INpcStandbyShowLooplyT()
		{
			this.Type = ENpcStandbyShowMode.Finite;
			this.LookAtConfigs = null;
			this.Montage = null;
			this.RegisteredMontageId = null;
			this.FaceExpressionId = 0;
			this.IgnoreEntityCollision = null;
			this.SetFadeInTimeToZero = false;
			this.NullMask = 0;
		}
	}
}
