using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065CB RID: 26059
	public class IDisableAlertAreaDungeonConditionT
	{
		// Token: 0x1700C165 RID: 49509
		// (get) Token: 0x0602D31C RID: 185116 RVA: 0x006320D4 File Offset: 0x006302D4
		// (set) Token: 0x0602D31D RID: 185117 RVA: 0x006320DC File Offset: 0x006302DC
		public EDisableAlertAreaCondition Type { get; set; }

		// Token: 0x1700C166 RID: 49510
		// (get) Token: 0x0602D31E RID: 185118 RVA: 0x006320E5 File Offset: 0x006302E5
		// (set) Token: 0x0602D31F RID: 185119 RVA: 0x006320ED File Offset: 0x006302ED
		public int RelatedDungeonId { get; set; }

		// Token: 0x0602D320 RID: 185120 RVA: 0x006320F6 File Offset: 0x006302F6
		public IDisableAlertAreaDungeonConditionT()
		{
			this.Type = EDisableAlertAreaCondition.DungeonCondition;
			this.RelatedDungeonId = 0;
		}
	}
}
