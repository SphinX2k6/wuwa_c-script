using System;
using Aki.UniverseEditor.Interface.Fbs.Common;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B88 RID: 27528
	public class ICustomSkillT
	{
		// Token: 0x1700CA03 RID: 51715
		// (get) Token: 0x0602F5FB RID: 194043 RVA: 0x00676C3D File Offset: 0x00674E3D
		// (set) Token: 0x0602F5FC RID: 194044 RVA: 0x00676C45 File Offset: 0x00674E45
		public ELeisureInteract Type { get; set; }

		// Token: 0x1700CA04 RID: 51716
		// (get) Token: 0x0602F5FD RID: 194045 RVA: 0x00676C4E File Offset: 0x00674E4E
		// (set) Token: 0x0602F5FE RID: 194046 RVA: 0x00676C56 File Offset: 0x00674E56
		public TCommonTargetUnion Target { get; set; }

		// Token: 0x1700CA05 RID: 51717
		// (get) Token: 0x0602F5FF RID: 194047 RVA: 0x00676C5F File Offset: 0x00674E5F
		// (set) Token: 0x0602F600 RID: 194048 RVA: 0x00676C67 File Offset: 0x00674E67
		public int SkillId { get; set; }

		// Token: 0x0602F601 RID: 194049 RVA: 0x00676C70 File Offset: 0x00674E70
		public ICustomSkillT()
		{
			this.Type = ELeisureInteract.CustomSkill;
			this.Target = null;
			this.SkillId = 0;
		}
	}
}
