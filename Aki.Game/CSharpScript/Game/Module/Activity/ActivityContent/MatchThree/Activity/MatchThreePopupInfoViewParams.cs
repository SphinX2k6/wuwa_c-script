using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x02006549 RID: 25929
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreePopupInfoViewParams
	{
		// Token: 0x1700953B RID: 38203
		// (get) Token: 0x06040FD0 RID: 266192 RVA: 0x00FBF9D4 File Offset: 0x00FBDBD4
		public bool HasTile
		{
			get
			{
				return this.TileList.Count > 0;
			}
		}

		// Token: 0x1700953C RID: 38204
		// (get) Token: 0x06040FD1 RID: 266193 RVA: 0x00FBF9E4 File Offset: 0x00FBDBE4
		public bool HasEnv
		{
			get
			{
				return this.EnvList.Count > 0;
			}
		}

		// Token: 0x1700953D RID: 38205
		// (get) Token: 0x06040FD2 RID: 266194 RVA: 0x00FBF9F4 File Offset: 0x00FBDBF4
		public bool HasAny
		{
			get
			{
				return this.HasTile || this.HasEnv;
			}
		}

		// Token: 0x1700953E RID: 38206
		// (get) Token: 0x06040FD3 RID: 266195 RVA: 0x00FBFA06 File Offset: 0x00FBDC06
		public bool HasFocus
		{
			get
			{
				return this.FocusTileIndex >= 0 || this.FocusEnvIndex >= 0;
			}
		}

		// Token: 0x04021E29 RID: 138793
		public List<MatchThreeInfoItemData> TileList = new List<MatchThreeInfoItemData>();

		// Token: 0x04021E2A RID: 138794
		public List<MatchThreeInfoItemData> EnvList = new List<MatchThreeInfoItemData>();

		// Token: 0x04021E2B RID: 138795
		public int FocusTileIndex = -1;

		// Token: 0x04021E2C RID: 138796
		public int FocusEnvIndex = -1;
	}
}
