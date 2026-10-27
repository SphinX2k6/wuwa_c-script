using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005669 RID: 22121
	public class INpcStandbySitT
	{
		// Token: 0x1700A3EC RID: 41964
		// (get) Token: 0x06024CC7 RID: 150727 RVA: 0x00513D8F File Offset: 0x00511F8F
		// (set) Token: 0x06024CC8 RID: 150728 RVA: 0x00513D97 File Offset: 0x00511F97
		public ENpcStandbyShowMode Type { get; set; }

		// Token: 0x1700A3ED RID: 41965
		// (get) Token: 0x06024CC9 RID: 150729 RVA: 0x00513DA0 File Offset: 0x00511FA0
		// (set) Token: 0x06024CCA RID: 150730 RVA: 0x00513DA8 File Offset: 0x00511FA8
		public List<INpcLookAtConfigT> LookAtConfigs { get; set; }

		// Token: 0x1700A3EE RID: 41966
		// (get) Token: 0x06024CCB RID: 150731 RVA: 0x00513DB1 File Offset: 0x00511FB1
		// (set) Token: 0x06024CCC RID: 150732 RVA: 0x00513DB9 File Offset: 0x00511FB9
		public string Montage { get; set; }

		// Token: 0x1700A3EF RID: 41967
		// (get) Token: 0x06024CCD RID: 150733 RVA: 0x00513DC2 File Offset: 0x00511FC2
		// (set) Token: 0x06024CCE RID: 150734 RVA: 0x00513DCA File Offset: 0x00511FCA
		public IMontageIdT RegisteredMontageId { get; set; }

		// Token: 0x1700A3F0 RID: 41968
		// (get) Token: 0x06024CCF RID: 150735 RVA: 0x00513DD3 File Offset: 0x00511FD3
		// (set) Token: 0x06024CD0 RID: 150736 RVA: 0x00513DDB File Offset: 0x00511FDB
		public int FaceExpressionId { get; set; }

		// Token: 0x1700A3F1 RID: 41969
		// (get) Token: 0x06024CD1 RID: 150737 RVA: 0x00513DE4 File Offset: 0x00511FE4
		// (set) Token: 0x06024CD2 RID: 150738 RVA: 0x00513DEC File Offset: 0x00511FEC
		public int PosEntityId { get; set; }

		// Token: 0x1700A3F2 RID: 41970
		// (get) Token: 0x06024CD3 RID: 150739 RVA: 0x00513DF5 File Offset: 0x00511FF5
		// (set) Token: 0x06024CD4 RID: 150740 RVA: 0x00513DFD File Offset: 0x00511FFD
		public byte NullMask { get; set; }

		// Token: 0x06024CD5 RID: 150741 RVA: 0x00513E06 File Offset: 0x00512006
		public INpcStandbySitT()
		{
			this.Type = ENpcStandbyShowMode.Finite;
			this.LookAtConfigs = null;
			this.Montage = null;
			this.RegisteredMontageId = null;
			this.FaceExpressionId = 0;
			this.PosEntityId = 0;
			this.NullMask = 0;
		}
	}
}
