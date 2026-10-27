using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.TowerDefence
{
	// Token: 0x02004B30 RID: 19248
	[NullableContext(1)]
	[Nullable(0)]
	public class TowerDefensePhantomSkillItemInBattleData : ITowerDefensePhantomSkillItemInBattleData
	{
		// Token: 0x17007B6A RID: 31594
		// (get) Token: 0x06031D8F RID: 204175 RVA: 0x00B926AF File Offset: 0x00B908AF
		// (set) Token: 0x06031D90 RID: 204176 RVA: 0x00B926B7 File Offset: 0x00B908B7
		public string Skill { get; set; }

		// Token: 0x17007B6B RID: 31595
		// (get) Token: 0x06031D91 RID: 204177 RVA: 0x00B926C0 File Offset: 0x00B908C0
		// (set) Token: 0x06031D92 RID: 204178 RVA: 0x00B926C8 File Offset: 0x00B908C8
		public string Description { get; set; }

		// Token: 0x17007B6C RID: 31596
		// (get) Token: 0x06031D93 RID: 204179 RVA: 0x00B926D1 File Offset: 0x00B908D1
		// (set) Token: 0x06031D94 RID: 204180 RVA: 0x00B926D9 File Offset: 0x00B908D9
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> DescriptionArgs { [return: Nullable(new byte[]
		{
			2,
			1
		})] get; [param: Nullable(new byte[]
		{
			2,
			1
		})] set; }

		// Token: 0x17007B6D RID: 31597
		// (get) Token: 0x06031D95 RID: 204181 RVA: 0x00B926E2 File Offset: 0x00B908E2
		// (set) Token: 0x06031D96 RID: 204182 RVA: 0x00B926EA File Offset: 0x00B908EA
		public bool IsUnlock { get; set; }

		// Token: 0x17007B6E RID: 31598
		// (get) Token: 0x06031D97 RID: 204183 RVA: 0x00B926F3 File Offset: 0x00B908F3
		// (set) Token: 0x06031D98 RID: 204184 RVA: 0x00B926FB File Offset: 0x00B908FB
		public bool IsCurrent { get; set; }
	}
}
