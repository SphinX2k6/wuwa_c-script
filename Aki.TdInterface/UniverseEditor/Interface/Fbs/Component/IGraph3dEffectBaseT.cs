using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005310 RID: 21264
	public class IGraph3dEffectBaseT
	{
		// Token: 0x17009C25 RID: 39973
		// (get) Token: 0x06022BD4 RID: 142292 RVA: 0x004D0342 File Offset: 0x004CE542
		// (set) Token: 0x06022BD5 RID: 142293 RVA: 0x004D034A File Offset: 0x004CE54A
		public EGraph3dEffectType Type { get; set; }

		// Token: 0x06022BD6 RID: 142294 RVA: 0x004D0353 File Offset: 0x004CE553
		public IGraph3dEffectBaseT()
		{
			this.Type = EGraph3dEffectType.FireBoxFish;
		}
	}
}
