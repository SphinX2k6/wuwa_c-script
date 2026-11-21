using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.DollGrabMachine
{
	// Token: 0x0200603F RID: 24639
	[RequiredMember]
	public class GrabItemData : IGrabItemData
	{
		// Token: 0x17006FD5 RID: 28629
		// (get) Token: 0x0603B23A RID: 242234 RVA: 0x010B8E81 File Offset: 0x010B7081
		// (set) Token: 0x0603B23B RID: 242235 RVA: 0x010B8E89 File Offset: 0x010B7089
		[RequiredMember]
		public int ItemId { get; set; }

		// Token: 0x17006FD6 RID: 28630
		// (get) Token: 0x0603B23C RID: 242236 RVA: 0x010B8E92 File Offset: 0x010B7092
		// (set) Token: 0x0603B23D RID: 242237 RVA: 0x010B8E9A File Offset: 0x010B709A
		[RequiredMember]
		public int Count { get; set; }

		// Token: 0x0603B23E RID: 242238 RVA: 0x010B8EA3 File Offset: 0x010B70A3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public GrabItemData()
		{
		}
	}
}
