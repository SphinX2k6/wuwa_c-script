using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200613B RID: 24891
	public class IAddTrialCharacterT
	{
		// Token: 0x1700B799 RID: 47001
		// (get) Token: 0x0602A957 RID: 174423 RVA: 0x005DD5F2 File Offset: 0x005DB7F2
		// (set) Token: 0x0602A958 RID: 174424 RVA: 0x005DD5FA File Offset: 0x005DB7FA
		public bool UseUpdateTrialCharacterLogic { get; set; }

		// Token: 0x1700B79A RID: 47002
		// (get) Token: 0x0602A959 RID: 174425 RVA: 0x005DD603 File Offset: 0x005DB803
		// (set) Token: 0x0602A95A RID: 174426 RVA: 0x005DD60B File Offset: 0x005DB80B
		public int CharacterId { get; set; }

		// Token: 0x1700B79B RID: 47003
		// (get) Token: 0x0602A95B RID: 174427 RVA: 0x005DD614 File Offset: 0x005DB814
		// (set) Token: 0x0602A95C RID: 174428 RVA: 0x005DD61C File Offset: 0x005DB81C
		public List<int> CharacterGroup { get; set; }

		// Token: 0x1700B79C RID: 47004
		// (get) Token: 0x0602A95D RID: 174429 RVA: 0x005DD625 File Offset: 0x005DB825
		// (set) Token: 0x0602A95E RID: 174430 RVA: 0x005DD62D File Offset: 0x005DB82D
		public List<ICharacterGroupNewT> CharacterGroupNew { get; set; }

		// Token: 0x1700B79D RID: 47005
		// (get) Token: 0x0602A95F RID: 174431 RVA: 0x005DD636 File Offset: 0x005DB836
		// (set) Token: 0x0602A960 RID: 174432 RVA: 0x005DD63E File Offset: 0x005DB83E
		public bool AutoChange { get; set; }

		// Token: 0x1700B79E RID: 47006
		// (get) Token: 0x0602A961 RID: 174433 RVA: 0x005DD647 File Offset: 0x005DB847
		// (set) Token: 0x0602A962 RID: 174434 RVA: 0x005DD64F File Offset: 0x005DB84F
		public bool CreateTempTeam { get; set; }

		// Token: 0x1700B79F RID: 47007
		// (get) Token: 0x0602A963 RID: 174435 RVA: 0x005DD658 File Offset: 0x005DB858
		// (set) Token: 0x0602A964 RID: 174436 RVA: 0x005DD660 File Offset: 0x005DB860
		public bool CreateAiCharacter { get; set; }

		// Token: 0x1700B7A0 RID: 47008
		// (get) Token: 0x0602A965 RID: 174437 RVA: 0x005DD669 File Offset: 0x005DB869
		// (set) Token: 0x0602A966 RID: 174438 RVA: 0x005DD671 File Offset: 0x005DB871
		public IActiveRangeT ActiveRange { get; set; }

		// Token: 0x1700B7A1 RID: 47009
		// (get) Token: 0x0602A967 RID: 174439 RVA: 0x005DD67A File Offset: 0x005DB87A
		// (set) Token: 0x0602A968 RID: 174440 RVA: 0x005DD682 File Offset: 0x005DB882
		public List<int> EnterRangeEntities { get; set; }

		// Token: 0x1700B7A2 RID: 47010
		// (get) Token: 0x0602A969 RID: 174441 RVA: 0x005DD68B File Offset: 0x005DB88B
		// (set) Token: 0x0602A96A RID: 174442 RVA: 0x005DD693 File Offset: 0x005DB893
		public bool EnableMapAndTeleport { get; set; }

		// Token: 0x1700B7A3 RID: 47011
		// (get) Token: 0x0602A96B RID: 174443 RVA: 0x005DD69C File Offset: 0x005DB89C
		// (set) Token: 0x0602A96C RID: 174444 RVA: 0x005DD6A4 File Offset: 0x005DB8A4
		public List<int> DungeonList { get; set; }

		// Token: 0x1700B7A4 RID: 47012
		// (get) Token: 0x0602A96D RID: 174445 RVA: 0x005DD6AD File Offset: 0x005DB8AD
		// (set) Token: 0x0602A96E RID: 174446 RVA: 0x005DD6B5 File Offset: 0x005DB8B5
		public bool IsRemoveTips { get; set; }

		// Token: 0x1700B7A5 RID: 47013
		// (get) Token: 0x0602A96F RID: 174447 RVA: 0x005DD6BE File Offset: 0x005DB8BE
		// (set) Token: 0x0602A970 RID: 174448 RVA: 0x005DD6C6 File Offset: 0x005DB8C6
		public TVarRefUnion IsDisableRollBackRestoreCharacter { get; set; }

		// Token: 0x1700B7A6 RID: 47014
		// (get) Token: 0x0602A971 RID: 174449 RVA: 0x005DD6CF File Offset: 0x005DB8CF
		// (set) Token: 0x0602A972 RID: 174450 RVA: 0x005DD6D7 File Offset: 0x005DB8D7
		public bool EnableSeamlessTeamSwitch { get; set; }

		// Token: 0x1700B7A7 RID: 47015
		// (get) Token: 0x0602A973 RID: 174451 RVA: 0x005DD6E0 File Offset: 0x005DB8E0
		// (set) Token: 0x0602A974 RID: 174452 RVA: 0x005DD6E8 File Offset: 0x005DB8E8
		public bool OnlyLowMemoryDeviceExecute { get; set; }

		// Token: 0x1700B7A8 RID: 47016
		// (get) Token: 0x0602A975 RID: 174453 RVA: 0x005DD6F1 File Offset: 0x005DB8F1
		// (set) Token: 0x0602A976 RID: 174454 RVA: 0x005DD6F9 File Offset: 0x005DB8F9
		public ushort NullMask { get; set; }

		// Token: 0x0602A977 RID: 174455 RVA: 0x005DD704 File Offset: 0x005DB904
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
