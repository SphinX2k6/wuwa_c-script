using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007CE1 RID: 31969
	public class IUpdateTrialCharacterT
	{
		// Token: 0x1700EF43 RID: 61251
		// (get) Token: 0x06039ADA RID: 236250 RVA: 0x007C81B3 File Offset: 0x007C63B3
		// (set) Token: 0x06039ADB RID: 236251 RVA: 0x007C81BB File Offset: 0x007C63BB
		public List<ICharacterGroupNewT> CharacterGroupNew { get; set; }

		// Token: 0x1700EF44 RID: 61252
		// (get) Token: 0x06039ADC RID: 236252 RVA: 0x007C81C4 File Offset: 0x007C63C4
		// (set) Token: 0x06039ADD RID: 236253 RVA: 0x007C81CC File Offset: 0x007C63CC
		public bool AutoChange { get; set; }

		// Token: 0x1700EF45 RID: 61253
		// (get) Token: 0x06039ADE RID: 236254 RVA: 0x007C81D5 File Offset: 0x007C63D5
		// (set) Token: 0x06039ADF RID: 236255 RVA: 0x007C81DD File Offset: 0x007C63DD
		public bool CreateTempTeam { get; set; }

		// Token: 0x1700EF46 RID: 61254
		// (get) Token: 0x06039AE0 RID: 236256 RVA: 0x007C81E6 File Offset: 0x007C63E6
		// (set) Token: 0x06039AE1 RID: 236257 RVA: 0x007C81EE File Offset: 0x007C63EE
		public IActiveRangeT ActiveRange { get; set; }

		// Token: 0x1700EF47 RID: 61255
		// (get) Token: 0x06039AE2 RID: 236258 RVA: 0x007C81F7 File Offset: 0x007C63F7
		// (set) Token: 0x06039AE3 RID: 236259 RVA: 0x007C81FF File Offset: 0x007C63FF
		public List<int> EnterRangeEntities { get; set; }

		// Token: 0x1700EF48 RID: 61256
		// (get) Token: 0x06039AE4 RID: 236260 RVA: 0x007C8208 File Offset: 0x007C6408
		// (set) Token: 0x06039AE5 RID: 236261 RVA: 0x007C8210 File Offset: 0x007C6410
		public bool EnableMapAndTeleport { get; set; }

		// Token: 0x1700EF49 RID: 61257
		// (get) Token: 0x06039AE6 RID: 236262 RVA: 0x007C8219 File Offset: 0x007C6419
		// (set) Token: 0x06039AE7 RID: 236263 RVA: 0x007C8221 File Offset: 0x007C6421
		public List<int> DungeonList { get; set; }

		// Token: 0x1700EF4A RID: 61258
		// (get) Token: 0x06039AE8 RID: 236264 RVA: 0x007C822A File Offset: 0x007C642A
		// (set) Token: 0x06039AE9 RID: 236265 RVA: 0x007C8232 File Offset: 0x007C6432
		public bool IsRemoveTips { get; set; }

		// Token: 0x1700EF4B RID: 61259
		// (get) Token: 0x06039AEA RID: 236266 RVA: 0x007C823B File Offset: 0x007C643B
		// (set) Token: 0x06039AEB RID: 236267 RVA: 0x007C8243 File Offset: 0x007C6443
		public TVarRefUnion IsDisableRollBackRestoreCharacter { get; set; }

		// Token: 0x1700EF4C RID: 61260
		// (get) Token: 0x06039AEC RID: 236268 RVA: 0x007C824C File Offset: 0x007C644C
		// (set) Token: 0x06039AED RID: 236269 RVA: 0x007C8254 File Offset: 0x007C6454
		public byte NullMask { get; set; }

		// Token: 0x06039AEE RID: 236270 RVA: 0x007C8260 File Offset: 0x007C6460
		public IUpdateTrialCharacterT()
		{
			this.CharacterGroupNew = null;
			this.AutoChange = false;
			this.CreateTempTeam = false;
			this.ActiveRange = null;
			this.EnterRangeEntities = null;
			this.EnableMapAndTeleport = false;
			this.DungeonList = null;
			this.IsRemoveTips = false;
			this.IsDisableRollBackRestoreCharacter = null;
			this.NullMask = 0;
		}
	}
}
