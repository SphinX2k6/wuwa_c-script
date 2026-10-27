using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E9C RID: 20124
	public class IAnEventT
	{
		// Token: 0x17009051 RID: 36945
		// (get) Token: 0x0601FAC2 RID: 129730 RVA: 0x00469091 File Offset: 0x00467291
		// (set) Token: 0x0601FAC3 RID: 129731 RVA: 0x00469099 File Offset: 0x00467299
		public ESceneItemSeqEventCbType Type { get; set; }

		// Token: 0x17009052 RID: 36946
		// (get) Token: 0x0601FAC4 RID: 129732 RVA: 0x004690A2 File Offset: 0x004672A2
		// (set) Token: 0x0601FAC5 RID: 129733 RVA: 0x004690AA File Offset: 0x004672AA
		public string EventName { get; set; }

		// Token: 0x17009053 RID: 36947
		// (get) Token: 0x0601FAC6 RID: 129734 RVA: 0x004690B3 File Offset: 0x004672B3
		// (set) Token: 0x0601FAC7 RID: 129735 RVA: 0x004690BB File Offset: 0x004672BB
		public IActionInfoT Action { get; set; }

		// Token: 0x0601FAC8 RID: 129736 RVA: 0x004690C4 File Offset: 0x004672C4
		public IAnEventT()
		{
			this.Type = ESceneItemSeqEventCbType.ANS;
			this.EventName = null;
			this.Action = null;
		}
	}
}
