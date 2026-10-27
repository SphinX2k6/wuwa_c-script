using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x02006EC7 RID: 28359
	[RequiredMember]
	public class DollCollectData : IDollCollectData
	{
		// Token: 0x17009ABC RID: 39612
		// (get) Token: 0x060450DB RID: 282843 RVA: 0x0110EFF6 File Offset: 0x0110D1F6
		// (set) Token: 0x060450DC RID: 282844 RVA: 0x0110EFFE File Offset: 0x0110D1FE
		[RequiredMember]
		public int CurrentCollectCount { get; set; }

		// Token: 0x17009ABD RID: 39613
		// (get) Token: 0x060450DD RID: 282845 RVA: 0x0110F007 File Offset: 0x0110D207
		// (set) Token: 0x060450DE RID: 282846 RVA: 0x0110F00F File Offset: 0x0110D20F
		[RequiredMember]
		public int TotalCollectCount { get; set; }

		// Token: 0x17009ABE RID: 39614
		// (get) Token: 0x060450DF RID: 282847 RVA: 0x0110F018 File Offset: 0x0110D218
		// (set) Token: 0x060450E0 RID: 282848 RVA: 0x0110F020 File Offset: 0x0110D220
		[RequiredMember]
		public int CurrentCollectItemCount { get; set; }

		// Token: 0x17009ABF RID: 39615
		// (get) Token: 0x060450E1 RID: 282849 RVA: 0x0110F029 File Offset: 0x0110D229
		// (set) Token: 0x060450E2 RID: 282850 RVA: 0x0110F031 File Offset: 0x0110D231
		[RequiredMember]
		public int TotalCollectItemCount { get; set; }

		// Token: 0x060450E3 RID: 282851 RVA: 0x0110F03A File Offset: 0x0110D23A
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public DollCollectData()
		{
		}
	}
}
