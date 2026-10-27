using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x020047D7 RID: 18391
	public class QuickNavigateLoopScrollAreaGridItemData
	{
		// Token: 0x04019F2B RID: 106283
		public int Index;

		// Token: 0x04019F2C RID: 106284
		[Nullable(2)]
		public IWorldMapNavigate AreaNavigateInfo;

		// Token: 0x04019F2D RID: 106285
		public bool IsSelected;

		// Token: 0x04019F2E RID: 106286
		public ERefreshNavigateType RefreshType;
	}
}
