using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071CF RID: 29135
	public class IModifyActorMaterialParamByEntitySplineProgressT
	{
		// Token: 0x1700D555 RID: 54613
		// (get) Token: 0x06032AE2 RID: 207586 RVA: 0x006D8B90 File Offset: 0x006D6D90
		// (set) Token: 0x06032AE3 RID: 207587 RVA: 0x006D8B98 File Offset: 0x006D6D98
		public ECommonTargetType Type { get; set; }

		// Token: 0x1700D556 RID: 54614
		// (get) Token: 0x06032AE4 RID: 207588 RVA: 0x006D8BA1 File Offset: 0x006D6DA1
		// (set) Token: 0x06032AE5 RID: 207589 RVA: 0x006D8BA9 File Offset: 0x006D6DA9
		public int Id { get; set; }

		// Token: 0x06032AE6 RID: 207590 RVA: 0x006D8BB2 File Offset: 0x006D6DB2
		public IModifyActorMaterialParamByEntitySplineProgressT()
		{
			this.Type = ECommonTargetType.Player;
			this.Id = 0;
		}
	}
}
