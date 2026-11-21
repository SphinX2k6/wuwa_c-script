using System;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x020036C9 RID: 14025
	public class WorldMapChangeMapParams
	{
		// Token: 0x04014499 RID: 83097
		public int MarkId;

		// Token: 0x0401449A RID: 83098
		public EMarkType MarkType;

		// Token: 0x0401449B RID: 83099
		public int MapId;

		// Token: 0x0401449C RID: 83100
		public bool? Focal;

		// Token: 0x0401449D RID: 83101
		public bool? FocusTween;

		// Token: 0x0401449E RID: 83102
		public EMapGravityDirection? Gravity;

		// Token: 0x0401449F RID: 83103
		public bool? NeedTempShow;
	}
}
