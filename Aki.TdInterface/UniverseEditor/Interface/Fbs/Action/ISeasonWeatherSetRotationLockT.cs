using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007712 RID: 30482
	public class ISeasonWeatherSetRotationLockT
	{
		// Token: 0x1700DF8D RID: 57229
		// (get) Token: 0x060357C1 RID: 219073 RVA: 0x0072BCFA File Offset: 0x00729EFA
		// (set) Token: 0x060357C2 RID: 219074 RVA: 0x0072BD02 File Offset: 0x00729F02
		public bool IsLocked { get; set; }

		// Token: 0x060357C3 RID: 219075 RVA: 0x0072BD0B File Offset: 0x00729F0B
		public ISeasonWeatherSetRotationLockT()
		{
			this.IsLocked = false;
		}
	}
}
