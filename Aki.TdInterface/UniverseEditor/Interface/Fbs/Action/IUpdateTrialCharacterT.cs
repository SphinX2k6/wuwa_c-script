using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020074EB RID: 29931
	public class IUpdateTrialCharacterT
	{
		// Token: 0x1700E319 RID: 58137
		// (get) Token: 0x060366C5 RID: 222917 RVA: 0x00764F63 File Offset: 0x00763163
		// (set) Token: 0x060366C6 RID: 222918 RVA: 0x00764F6B File Offset: 0x0076316B
		public List<ICharacterGroupNewT> CharacterGroupNew { get; set; }

		// Token: 0x1700E31A RID: 58138
		// (get) Token: 0x060366C7 RID: 222919 RVA: 0x00764F74 File Offset: 0x00763174
		// (set) Token: 0x060366C8 RID: 222920 RVA: 0x00764F7C File Offset: 0x0076317C
		public bool AutoChange { get; set; }

		// Token: 0x1700E31B RID: 58139
		// (get) Token: 0x060366C9 RID: 222921 RVA: 0x00764F85 File Offset: 0x00763185
		// (set) Token: 0x060366CA RID: 222922 RVA: 0x00764F8D File Offset: 0x0076318D
		public bool CreateTempTeam { get; set; }

		// Token: 0x1700E31C RID: 58140
		// (get) Token: 0x060366CB RID: 222923 RVA: 0x00764F96 File Offset: 0x00763196
		// (set) Token: 0x060366CC RID: 222924 RVA: 0x00764F9E File Offset: 0x0076319E
		public IActiveRangeT ActiveRange { get; set; }

		// Token: 0x1700E31D RID: 58141
		// (get) Token: 0x060366CD RID: 222925 RVA: 0x00764FA7 File Offset: 0x007631A7
		// (set) Token: 0x060366CE RID: 222926 RVA: 0x00764FAF File Offset: 0x007631AF
		public List<int> EnterRangeEntities { get; set; }

		// Token: 0x1700E31E RID: 58142
		// (get) Token: 0x060366CF RID: 222927 RVA: 0x00764FB8 File Offset: 0x007631B8
		// (set) Token: 0x060366D0 RID: 222928 RVA: 0x00764FC0 File Offset: 0x007631C0
		public bool EnableMapAndTeleport { get; set; }

		// Token: 0x1700E31F RID: 58143
		// (get) Token: 0x060366D1 RID: 222929 RVA: 0x00764FC9 File Offset: 0x007631C9
		// (set) Token: 0x060366D2 RID: 222930 RVA: 0x00764FD1 File Offset: 0x007631D1
		public List<int> DungeonList { get; set; }

		// Token: 0x1700E320 RID: 58144
		// (get) Token: 0x060366D3 RID: 222931 RVA: 0x00764FDA File Offset: 0x007631DA
		// (set) Token: 0x060366D4 RID: 222932 RVA: 0x00764FE2 File Offset: 0x007631E2
		public bool IsRemoveTips { get; set; }

		// Token: 0x1700E321 RID: 58145
		// (get) Token: 0x060366D5 RID: 222933 RVA: 0x00764FEB File Offset: 0x007631EB
		// (set) Token: 0x060366D6 RID: 222934 RVA: 0x00764FF3 File Offset: 0x007631F3
		public TVarRefUnion IsDisableRollBackRestoreCharacter { get; set; }

		// Token: 0x1700E322 RID: 58146
		// (get) Token: 0x060366D7 RID: 222935 RVA: 0x00764FFC File Offset: 0x007631FC
		// (set) Token: 0x060366D8 RID: 222936 RVA: 0x00765004 File Offset: 0x00763204
		public byte NullMask { get; set; }

		// Token: 0x060366D9 RID: 222937 RVA: 0x00765010 File Offset: 0x00763210
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
