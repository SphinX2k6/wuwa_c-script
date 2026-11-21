using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020067A0 RID: 26528
	public class IAddTrialCharacterT
	{
		// Token: 0x1700C109 RID: 49417
		// (get) Token: 0x0602D050 RID: 184400 RVA: 0x006277CE File Offset: 0x006259CE
		// (set) Token: 0x0602D051 RID: 184401 RVA: 0x006277D6 File Offset: 0x006259D6
		public bool UseUpdateTrialCharacterLogic { get; set; }

		// Token: 0x1700C10A RID: 49418
		// (get) Token: 0x0602D052 RID: 184402 RVA: 0x006277DF File Offset: 0x006259DF
		// (set) Token: 0x0602D053 RID: 184403 RVA: 0x006277E7 File Offset: 0x006259E7
		public int CharacterId { get; set; }

		// Token: 0x1700C10B RID: 49419
		// (get) Token: 0x0602D054 RID: 184404 RVA: 0x006277F0 File Offset: 0x006259F0
		// (set) Token: 0x0602D055 RID: 184405 RVA: 0x006277F8 File Offset: 0x006259F8
		public List<int> CharacterGroup { get; set; }

		// Token: 0x1700C10C RID: 49420
		// (get) Token: 0x0602D056 RID: 184406 RVA: 0x00627801 File Offset: 0x00625A01
		// (set) Token: 0x0602D057 RID: 184407 RVA: 0x00627809 File Offset: 0x00625A09
		public List<ICharacterGroupNewT> CharacterGroupNew { get; set; }

		// Token: 0x1700C10D RID: 49421
		// (get) Token: 0x0602D058 RID: 184408 RVA: 0x00627812 File Offset: 0x00625A12
		// (set) Token: 0x0602D059 RID: 184409 RVA: 0x0062781A File Offset: 0x00625A1A
		public bool AutoChange { get; set; }

		// Token: 0x1700C10E RID: 49422
		// (get) Token: 0x0602D05A RID: 184410 RVA: 0x00627823 File Offset: 0x00625A23
		// (set) Token: 0x0602D05B RID: 184411 RVA: 0x0062782B File Offset: 0x00625A2B
		public bool CreateTempTeam { get; set; }

		// Token: 0x1700C10F RID: 49423
		// (get) Token: 0x0602D05C RID: 184412 RVA: 0x00627834 File Offset: 0x00625A34
		// (set) Token: 0x0602D05D RID: 184413 RVA: 0x0062783C File Offset: 0x00625A3C
		public bool CreateAiCharacter { get; set; }

		// Token: 0x1700C110 RID: 49424
		// (get) Token: 0x0602D05E RID: 184414 RVA: 0x00627845 File Offset: 0x00625A45
		// (set) Token: 0x0602D05F RID: 184415 RVA: 0x0062784D File Offset: 0x00625A4D
		public IActiveRangeT ActiveRange { get; set; }

		// Token: 0x1700C111 RID: 49425
		// (get) Token: 0x0602D060 RID: 184416 RVA: 0x00627856 File Offset: 0x00625A56
		// (set) Token: 0x0602D061 RID: 184417 RVA: 0x0062785E File Offset: 0x00625A5E
		public List<int> EnterRangeEntities { get; set; }

		// Token: 0x1700C112 RID: 49426
		// (get) Token: 0x0602D062 RID: 184418 RVA: 0x00627867 File Offset: 0x00625A67
		// (set) Token: 0x0602D063 RID: 184419 RVA: 0x0062786F File Offset: 0x00625A6F
		public bool EnableMapAndTeleport { get; set; }

		// Token: 0x1700C113 RID: 49427
		// (get) Token: 0x0602D064 RID: 184420 RVA: 0x00627878 File Offset: 0x00625A78
		// (set) Token: 0x0602D065 RID: 184421 RVA: 0x00627880 File Offset: 0x00625A80
		public List<int> DungeonList { get; set; }

		// Token: 0x1700C114 RID: 49428
		// (get) Token: 0x0602D066 RID: 184422 RVA: 0x00627889 File Offset: 0x00625A89
		// (set) Token: 0x0602D067 RID: 184423 RVA: 0x00627891 File Offset: 0x00625A91
		public bool IsRemoveTips { get; set; }

		// Token: 0x1700C115 RID: 49429
		// (get) Token: 0x0602D068 RID: 184424 RVA: 0x0062789A File Offset: 0x00625A9A
		// (set) Token: 0x0602D069 RID: 184425 RVA: 0x006278A2 File Offset: 0x00625AA2
		public TVarRefUnion IsDisableRollBackRestoreCharacter { get; set; }

		// Token: 0x1700C116 RID: 49430
		// (get) Token: 0x0602D06A RID: 184426 RVA: 0x006278AB File Offset: 0x00625AAB
		// (set) Token: 0x0602D06B RID: 184427 RVA: 0x006278B3 File Offset: 0x00625AB3
		public bool EnableSeamlessTeamSwitch { get; set; }

		// Token: 0x1700C117 RID: 49431
		// (get) Token: 0x0602D06C RID: 184428 RVA: 0x006278BC File Offset: 0x00625ABC
		// (set) Token: 0x0602D06D RID: 184429 RVA: 0x006278C4 File Offset: 0x00625AC4
		public bool OnlyLowMemoryDeviceExecute { get; set; }

		// Token: 0x1700C118 RID: 49432
		// (get) Token: 0x0602D06E RID: 184430 RVA: 0x006278CD File Offset: 0x00625ACD
		// (set) Token: 0x0602D06F RID: 184431 RVA: 0x006278D5 File Offset: 0x00625AD5
		public ushort NullMask { get; set; }

		// Token: 0x0602D070 RID: 184432 RVA: 0x006278E0 File Offset: 0x00625AE0
		public IAddTrialCharacterT()
		{
			this.UseUpdateTrialCharacterLogic = false;
			this.CharacterId = 0;
			this.CharacterGroup = null;
			this.CharacterGroupNew = null;
			this.AutoChange = false;
			this.CreateTempTeam = false;
			this.CreateAiCharacter = false;
			this.ActiveRange = null;
			this.EnterRangeEntities = null;
			this.EnableMapAndTeleport = false;
			this.DungeonList = null;
			this.IsRemoveTips = false;
			this.IsDisableRollBackRestoreCharacter = null;
			this.EnableSeamlessTeamSwitch = false;
			this.OnlyLowMemoryDeviceExecute = false;
			this.NullMask = 0;
		}
	}
}
