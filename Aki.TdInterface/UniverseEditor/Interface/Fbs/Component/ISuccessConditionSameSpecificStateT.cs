using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059EA RID: 23018
	public class ISuccessConditionSameSpecificStateT
	{
		// Token: 0x1700ACEA RID: 44266
		// (get) Token: 0x060270D4 RID: 159956 RVA: 0x0055F59B File Offset: 0x0055D79B
		// (set) Token: 0x060270D5 RID: 159957 RVA: 0x0055F5A3 File Offset: 0x0055D7A3
		public ETargetGearGroupSuccessCondition Type { get; set; }

		// Token: 0x1700ACEB RID: 44267
		// (get) Token: 0x060270D6 RID: 159958 RVA: 0x0055F5AC File Offset: 0x0055D7AC
		// (set) Token: 0x060270D7 RID: 159959 RVA: 0x0055F5B4 File Offset: 0x0055D7B4
		public string State { get; set; }

		// Token: 0x060270D8 RID: 159960 RVA: 0x0055F5BD File Offset: 0x0055D7BD
		public ISuccessConditionSameSpecificStateT()
		{
			this.Type = ETargetGearGroupSuccessCondition.SameSpecificState;
			this.State = null;
		}
	}
}
