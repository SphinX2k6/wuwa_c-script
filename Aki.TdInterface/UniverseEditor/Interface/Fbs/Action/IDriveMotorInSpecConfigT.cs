using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C84 RID: 27780
	public class IDriveMotorInSpecConfigT
	{
		// Token: 0x1700CBCC RID: 52172
		// (get) Token: 0x0602FDE8 RID: 196072 RVA: 0x00684BBA File Offset: 0x00682DBA
		// (set) Token: 0x0602FDE9 RID: 196073 RVA: 0x00684BC2 File Offset: 0x00682DC2
		public TMotorParamsChangeConfigUnion MotorParamsChangeConfig { get; set; }

		// Token: 0x1700CBCD RID: 52173
		// (get) Token: 0x0602FDEA RID: 196074 RVA: 0x00684BCB File Offset: 0x00682DCB
		// (set) Token: 0x0602FDEB RID: 196075 RVA: 0x00684BD3 File Offset: 0x00682DD3
		public bool IsEnableNitrogen { get; set; }

		// Token: 0x1700CBCE RID: 52174
		// (get) Token: 0x0602FDEC RID: 196076 RVA: 0x00684BDC File Offset: 0x00682DDC
		// (set) Token: 0x0602FDED RID: 196077 RVA: 0x00684BE4 File Offset: 0x00682DE4
		public List<EPlayerInputConstraintType> DisableInput { get; set; }

		// Token: 0x1700CBCF RID: 52175
		// (get) Token: 0x0602FDEE RID: 196078 RVA: 0x00684BED File Offset: 0x00682DED
		// (set) Token: 0x0602FDEF RID: 196079 RVA: 0x00684BF5 File Offset: 0x00682DF5
		public float Duration { get; set; }

		// Token: 0x1700CBD0 RID: 52176
		// (get) Token: 0x0602FDF0 RID: 196080 RVA: 0x00684BFE File Offset: 0x00682DFE
		// (set) Token: 0x0602FDF1 RID: 196081 RVA: 0x00684C06 File Offset: 0x00682E06
		public bool IsAffectedByTimeStop { get; set; }

		// Token: 0x1700CBD1 RID: 52177
		// (get) Token: 0x0602FDF2 RID: 196082 RVA: 0x00684C0F File Offset: 0x00682E0F
		// (set) Token: 0x0602FDF3 RID: 196083 RVA: 0x00684C17 File Offset: 0x00682E17
		public bool CanBeInterrupted { get; set; }

		// Token: 0x1700CBD2 RID: 52178
		// (get) Token: 0x0602FDF4 RID: 196084 RVA: 0x00684C20 File Offset: 0x00682E20
		// (set) Token: 0x0602FDF5 RID: 196085 RVA: 0x00684C28 File Offset: 0x00682E28
		public byte NullMask { get; set; }

		// Token: 0x0602FDF6 RID: 196086 RVA: 0x00684C31 File Offset: 0x00682E31
		public IDriveMotorInSpecConfigT()
		{
			this.MotorParamsChangeConfig = null;
			this.IsEnableNitrogen = false;
			this.DisableInput = null;
			this.Duration = 0f;
			this.IsAffectedByTimeStop = false;
			this.CanBeInterrupted = false;
			this.NullMask = 0;
		}
	}
}
