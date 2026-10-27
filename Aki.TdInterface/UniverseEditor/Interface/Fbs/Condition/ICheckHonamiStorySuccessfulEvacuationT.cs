using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A64 RID: 19044
	public class ICheckHonamiStorySuccessfulEvacuationT
	{
		// Token: 0x170089E4 RID: 35300
		// (get) Token: 0x0601DD58 RID: 122200 RVA: 0x004312CC File Offset: 0x0042F4CC
		// (set) Token: 0x0601DD59 RID: 122201 RVA: 0x004312D4 File Offset: 0x0042F4D4
		public ECondition Type { get; set; }

		// Token: 0x170089E5 RID: 35301
		// (get) Token: 0x0601DD5A RID: 122202 RVA: 0x004312DD File Offset: 0x0042F4DD
		// (set) Token: 0x0601DD5B RID: 122203 RVA: 0x004312E5 File Offset: 0x0042F4E5
		public bool IsSuccessful { get; set; }

		// Token: 0x0601DD5C RID: 122204 RVA: 0x004312EE File Offset: 0x0042F4EE
		public ICheckHonamiStorySuccessfulEvacuationT()
		{
			this.Type = ECondition.CompareVar;
			this.IsSuccessful = false;
		}
	}
}
