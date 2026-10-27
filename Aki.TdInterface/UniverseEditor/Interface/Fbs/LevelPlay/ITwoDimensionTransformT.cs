using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045E5 RID: 17893
	public class ITwoDimensionTransformT
	{
		// Token: 0x17007F37 RID: 32567
		// (get) Token: 0x0601B17B RID: 110971 RVA: 0x003DC60B File Offset: 0x003DA80B
		// (set) Token: 0x0601B17C RID: 110972 RVA: 0x003DC613 File Offset: 0x003DA813
		public IVector2T Position { get; set; }

		// Token: 0x17007F38 RID: 32568
		// (get) Token: 0x0601B17D RID: 110973 RVA: 0x003DC61C File Offset: 0x003DA81C
		// (set) Token: 0x0601B17E RID: 110974 RVA: 0x003DC624 File Offset: 0x003DA824
		public float Rotation { get; set; }

		// Token: 0x0601B17F RID: 110975 RVA: 0x003DC62D File Offset: 0x003DA82D
		public ITwoDimensionTransformT()
		{
			this.Position = null;
			this.Rotation = 0f;
		}
	}
}
