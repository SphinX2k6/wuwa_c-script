using System;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x020043FE RID: 17406
	public class IMatchPlayerRoleT
	{
		// Token: 0x17007AD4 RID: 31444
		// (get) Token: 0x06019EA4 RID: 106148 RVA: 0x003B51C6 File Offset: 0x003B33C6
		// (set) Token: 0x06019EA5 RID: 106149 RVA: 0x003B51CE File Offset: 0x003B33CE
		public EMatchRoleType Type { get; set; }

		// Token: 0x17007AD5 RID: 31445
		// (get) Token: 0x06019EA6 RID: 106150 RVA: 0x003B51D7 File Offset: 0x003B33D7
		// (set) Token: 0x06019EA7 RID: 106151 RVA: 0x003B51DF File Offset: 0x003B33DF
		public bool MatchPhantomSkill { get; set; }

		// Token: 0x17007AD6 RID: 31446
		// (get) Token: 0x06019EA8 RID: 106152 RVA: 0x003B51E8 File Offset: 0x003B33E8
		// (set) Token: 0x06019EA9 RID: 106153 RVA: 0x003B51F0 File Offset: 0x003B33F0
		public byte NullMask { get; set; }

		// Token: 0x06019EAA RID: 106154 RVA: 0x003B51F9 File Offset: 0x003B33F9
		public IMatchPlayerRoleT()
		{
			this.Type = EMatchRoleType.Player;
			this.MatchPhantomSkill = false;
			this.NullMask = 0;
		}
	}
}
