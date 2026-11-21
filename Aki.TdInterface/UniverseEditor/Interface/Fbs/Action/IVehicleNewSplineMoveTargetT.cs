using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D1A RID: 32026
	public class IVehicleNewSplineMoveTargetT
	{
		// Token: 0x1700EFBB RID: 61371
		// (get) Token: 0x06039CF8 RID: 236792 RVA: 0x007CCBE3 File Offset: 0x007CADE3
		// (set) Token: 0x06039CF9 RID: 236793 RVA: 0x007CCBEB File Offset: 0x007CADEB
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x1700EFBC RID: 61372
		// (get) Token: 0x06039CFA RID: 236794 RVA: 0x007CCBF4 File Offset: 0x007CADF4
		// (set) Token: 0x06039CFB RID: 236795 RVA: 0x007CCBFC File Offset: 0x007CADFC
		public TTargetVehicleUnion TargetVehicle { get; set; }

		// Token: 0x1700EFBD RID: 61373
		// (get) Token: 0x06039CFC RID: 236796 RVA: 0x007CCC05 File Offset: 0x007CAE05
		// (set) Token: 0x06039CFD RID: 236797 RVA: 0x007CCC0D File Offset: 0x007CAE0D
		public bool IsLookDir { get; set; }

		// Token: 0x1700EFBE RID: 61374
		// (get) Token: 0x06039CFE RID: 236798 RVA: 0x007CCC16 File Offset: 0x007CAE16
		// (set) Token: 0x06039CFF RID: 236799 RVA: 0x007CCC1E File Offset: 0x007CAE1E
		public byte NullMask { get; set; }

		// Token: 0x06039D00 RID: 236800 RVA: 0x007CCC27 File Offset: 0x007CAE27
		public IVehicleNewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
			this.TargetVehicle = null;
			this.IsLookDir = false;
			this.NullMask = 0;
		}
	}
}
