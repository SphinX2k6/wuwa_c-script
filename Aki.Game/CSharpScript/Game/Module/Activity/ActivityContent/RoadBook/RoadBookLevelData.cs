using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x02005143 RID: 20803
	public class RoadBookLevelData : IRoadBookLevelData
	{
		// Token: 0x17006584 RID: 25988
		// (get) Token: 0x06034065 RID: 213093 RVA: 0x00E8DFFF File Offset: 0x00E8C1FF
		// (set) Token: 0x06034066 RID: 213094 RVA: 0x00E8E007 File Offset: 0x00E8C207
		public int Id { get; set; }

		// Token: 0x17006585 RID: 25989
		// (get) Token: 0x06034067 RID: 213095 RVA: 0x00E8E010 File Offset: 0x00E8C210
		// (set) Token: 0x06034068 RID: 213096 RVA: 0x00E8E018 File Offset: 0x00E8C218
		public int Level { get; set; }

		// Token: 0x17006586 RID: 25990
		// (get) Token: 0x06034069 RID: 213097 RVA: 0x00E8E021 File Offset: 0x00E8C221
		// (set) Token: 0x0603406A RID: 213098 RVA: 0x00E8E029 File Offset: 0x00E8C229
		public int AccumulateExp { get; set; }

		// Token: 0x17006587 RID: 25991
		// (get) Token: 0x0603406B RID: 213099 RVA: 0x00E8E032 File Offset: 0x00E8C232
		// (set) Token: 0x0603406C RID: 213100 RVA: 0x00E8E03A File Offset: 0x00E8C23A
		public int TargetExp { get; set; }
	}
}
