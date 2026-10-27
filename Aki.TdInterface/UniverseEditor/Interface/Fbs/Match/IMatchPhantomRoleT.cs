using System;
using Aki.UniverseEditor.Interface.Fbs.Condition;

namespace Aki.UniverseEditor.Interface.Fbs.Match
{
	// Token: 0x020043FB RID: 17403
	public class IMatchPhantomRoleT
	{
		// Token: 0x17007ACC RID: 31436
		// (get) Token: 0x06019E88 RID: 106120 RVA: 0x003B4F0C File Offset: 0x003B310C
		// (set) Token: 0x06019E89 RID: 106121 RVA: 0x003B4F14 File Offset: 0x003B3114
		public EMatchRoleType Type { get; set; }

		// Token: 0x17007ACD RID: 31437
		// (get) Token: 0x06019E8A RID: 106122 RVA: 0x003B4F1D File Offset: 0x003B311D
		// (set) Token: 0x06019E8B RID: 106123 RVA: 0x003B4F25 File Offset: 0x003B3125
		public int Id { get; set; }

		// Token: 0x17007ACE RID: 31438
		// (get) Token: 0x06019E8C RID: 106124 RVA: 0x003B4F2E File Offset: 0x003B312E
		// (set) Token: 0x06019E8D RID: 106125 RVA: 0x003B4F36 File Offset: 0x003B3136
		public ECompare Compare { get; set; }

		// Token: 0x17007ACF RID: 31439
		// (get) Token: 0x06019E8E RID: 106126 RVA: 0x003B4F3F File Offset: 0x003B313F
		// (set) Token: 0x06019E8F RID: 106127 RVA: 0x003B4F47 File Offset: 0x003B3147
		public byte NullMask { get; set; }

		// Token: 0x06019E90 RID: 106128 RVA: 0x003B4F50 File Offset: 0x003B3150
		public IMatchPhantomRoleT()
		{
			this.Type = EMatchRoleType.Player;
			this.Id = 0;
			this.Compare = ECompare.Eq;
			this.NullMask = 0;
		}
	}
}
