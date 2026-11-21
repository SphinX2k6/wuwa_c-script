using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap.SubViews.WorldMapQuickNavigate
{
	// Token: 0x02003708 RID: 14088
	public class QuickNavigateLoopScrollAreaGridItemData
	{
		// Token: 0x040145DF RID: 83423
		public int Index;

		// Token: 0x040145E0 RID: 83424
		[Nullable(2)]
		public IWorldMapNavigate AreaNavigateInfo;

		// Token: 0x040145E1 RID: 83425
		public bool IsSelected;

		// Token: 0x040145E2 RID: 83426
		public ERefreshNavigateType RefreshType;
	}
}
