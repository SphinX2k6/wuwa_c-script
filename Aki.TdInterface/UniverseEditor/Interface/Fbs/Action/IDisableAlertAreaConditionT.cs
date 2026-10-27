using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065C5 RID: 26053
	public class IDisableAlertAreaConditionT
	{
		// Token: 0x1700C15F RID: 49503
		// (get) Token: 0x0602D2FA RID: 185082 RVA: 0x00631DB2 File Offset: 0x0062FFB2
		// (set) Token: 0x0602D2FB RID: 185083 RVA: 0x00631DBA File Offset: 0x0062FFBA
		public EDisableAlertAreaCondition Type { get; set; }

		// Token: 0x0602D2FC RID: 185084 RVA: 0x00631DC3 File Offset: 0x0062FFC3
		public IDisableAlertAreaConditionT()
		{
			this.Type = EDisableAlertAreaCondition.DungeonCondition;
		}
	}
}
