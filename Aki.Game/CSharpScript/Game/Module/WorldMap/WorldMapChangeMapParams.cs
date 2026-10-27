using System;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.WorldMap
{
	// Token: 0x02004798 RID: 18328
	public class WorldMapChangeMapParams
	{
		// Token: 0x04019DE9 RID: 105961
		public int MarkId;

		// Token: 0x04019DEA RID: 105962
		public EMarkType MarkType;

		// Token: 0x04019DEB RID: 105963
		public int MapId;

		// Token: 0x04019DEC RID: 105964
		public bool? Focal;

		// Token: 0x04019DED RID: 105965
		public bool? FocusTween;

		// Token: 0x04019DEE RID: 105966
		public EMapGravityDirection? Gravity;

		// Token: 0x04019DEF RID: 105967
		public bool? NeedTempShow;
	}
}
