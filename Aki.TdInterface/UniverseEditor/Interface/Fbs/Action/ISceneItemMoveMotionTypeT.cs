using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C1 RID: 30401
	public class ISceneItemMoveMotionTypeT
	{
		// Token: 0x1700DEFA RID: 57082
		// (get) Token: 0x06035545 RID: 218437 RVA: 0x007275C2 File Offset: 0x007257C2
		// (set) Token: 0x06035546 RID: 218438 RVA: 0x007275CA File Offset: 0x007257CA
		public EMoveMotion Type { get; set; }

		// Token: 0x06035547 RID: 218439 RVA: 0x007275D3 File Offset: 0x007257D3
		public ISceneItemMoveMotionTypeT()
		{
			this.Type = EMoveMotion.UniformMotion;
		}
	}
}
