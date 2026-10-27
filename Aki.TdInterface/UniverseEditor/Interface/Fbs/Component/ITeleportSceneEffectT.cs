using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A50 RID: 23120
	public class ITeleportSceneEffectT
	{
		// Token: 0x1700ADEC RID: 44524
		// (get) Token: 0x0602751A RID: 161050 RVA: 0x00568F1A File Offset: 0x0056711A
		// (set) Token: 0x0602751B RID: 161051 RVA: 0x00568F22 File Offset: 0x00567122
		public string WorldEffectPath { get; set; }

		// Token: 0x1700ADED RID: 44525
		// (get) Token: 0x0602751C RID: 161052 RVA: 0x00568F2B File Offset: 0x0056712B
		// (set) Token: 0x0602751D RID: 161053 RVA: 0x00568F33 File Offset: 0x00567133
		public string ScreenEffectPath { get; set; }

		// Token: 0x0602751E RID: 161054 RVA: 0x00568F3C File Offset: 0x0056713C
		public ITeleportSceneEffectT()
		{
			this.WorldEffectPath = null;
			this.ScreenEffectPath = null;
		}
	}
}
