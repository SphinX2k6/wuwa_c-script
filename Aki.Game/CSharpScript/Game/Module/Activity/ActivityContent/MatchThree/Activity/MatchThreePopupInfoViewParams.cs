using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Activity
{
	// Token: 0x020054C7 RID: 21703
	[NullableContext(1)]
	[Nullable(0)]
	public class MatchThreePopupInfoViewParams
	{
		// Token: 0x1700689D RID: 26781
		// (get) Token: 0x06035C95 RID: 220309 RVA: 0x00F069C4 File Offset: 0x00F04BC4
		public bool HasTile
		{
			get
			{
				return this.TileList.Count > 0;
			}
		}

		// Token: 0x1700689E RID: 26782
		// (get) Token: 0x06035C96 RID: 220310 RVA: 0x00F069D4 File Offset: 0x00F04BD4
		public bool HasEnv
		{
			get
			{
				return this.EnvList.Count > 0;
			}
		}

		// Token: 0x1700689F RID: 26783
		// (get) Token: 0x06035C97 RID: 220311 RVA: 0x00F069E4 File Offset: 0x00F04BE4
		public bool HasAny
		{
			get
			{
				return this.HasTile || this.HasEnv;
			}
		}

		// Token: 0x170068A0 RID: 26784
		// (get) Token: 0x06035C98 RID: 220312 RVA: 0x00F069F6 File Offset: 0x00F04BF6
		public bool HasFocus
		{
			get
			{
				return this.FocusTileIndex >= 0 || this.FocusEnvIndex >= 0;
			}
		}

		// Token: 0x0401C75A RID: 116570
		public List<MatchThreeInfoItemData> TileList = new List<MatchThreeInfoItemData>();

		// Token: 0x0401C75B RID: 116571
		public List<MatchThreeInfoItemData> EnvList = new List<MatchThreeInfoItemData>();

		// Token: 0x0401C75C RID: 116572
		public int FocusTileIndex = -1;

		// Token: 0x0401C75D RID: 116573
		public int FocusEnvIndex = -1;
	}
}
