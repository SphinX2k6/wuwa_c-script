using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005BAA RID: 23466
	public class INoiseRemovalSphereBoarderT
	{
		// Token: 0x1700AB8B RID: 43915
		// (get) Token: 0x06026B01 RID: 158465 RVA: 0x0054BE6C File Offset: 0x0054A06C
		// (set) Token: 0x06026B02 RID: 158466 RVA: 0x0054BE74 File Offset: 0x0054A074
		public ENoiseRemovalBoarderShape Type { get; set; }

		// Token: 0x1700AB8C RID: 43916
		// (get) Token: 0x06026B03 RID: 158467 RVA: 0x0054BE7D File Offset: 0x0054A07D
		// (set) Token: 0x06026B04 RID: 158468 RVA: 0x0054BE85 File Offset: 0x0054A085
		public float Radius { get; set; }

		// Token: 0x06026B05 RID: 158469 RVA: 0x0054BE8E File Offset: 0x0054A08E
		public INoiseRemovalSphereBoarderT()
		{
			this.Type = ENoiseRemovalBoarderShape.Box;
			this.Radius = 0f;
		}
	}
}
