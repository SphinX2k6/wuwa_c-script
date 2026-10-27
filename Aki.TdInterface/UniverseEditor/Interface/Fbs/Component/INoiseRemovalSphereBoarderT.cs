using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200560C RID: 22028
	public class INoiseRemovalSphereBoarderT
	{
		// Token: 0x1700A303 RID: 41731
		// (get) Token: 0x060248F1 RID: 149745 RVA: 0x0050B854 File Offset: 0x00509A54
		// (set) Token: 0x060248F2 RID: 149746 RVA: 0x0050B85C File Offset: 0x00509A5C
		public ENoiseRemovalBoarderShape Type { get; set; }

		// Token: 0x1700A304 RID: 41732
		// (get) Token: 0x060248F3 RID: 149747 RVA: 0x0050B865 File Offset: 0x00509A65
		// (set) Token: 0x060248F4 RID: 149748 RVA: 0x0050B86D File Offset: 0x00509A6D
		public float Radius { get; set; }

		// Token: 0x060248F5 RID: 149749 RVA: 0x0050B876 File Offset: 0x00509A76
		public INoiseRemovalSphereBoarderT()
		{
			this.Type = ENoiseRemovalBoarderShape.Box;
			this.Radius = 0f;
		}
	}
}
