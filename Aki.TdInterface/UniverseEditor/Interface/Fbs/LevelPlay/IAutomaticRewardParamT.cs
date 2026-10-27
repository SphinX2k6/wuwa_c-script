using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004435 RID: 17461
	public class IAutomaticRewardParamT
	{
		// Token: 0x17007B07 RID: 31495
		// (get) Token: 0x06019F96 RID: 106390 RVA: 0x003B6CFC File Offset: 0x003B4EFC
		// (set) Token: 0x06019F97 RID: 106391 RVA: 0x003B6D04 File Offset: 0x003B4F04
		public ELevelPlayRewardType Type { get; set; }

		// Token: 0x17007B08 RID: 31496
		// (get) Token: 0x06019F98 RID: 106392 RVA: 0x003B6D0D File Offset: 0x003B4F0D
		// (set) Token: 0x06019F99 RID: 106393 RVA: 0x003B6D15 File Offset: 0x003B4F15
		public int RewardId { get; set; }

		// Token: 0x17007B09 RID: 31497
		// (get) Token: 0x06019F9A RID: 106394 RVA: 0x003B6D1E File Offset: 0x003B4F1E
		// (set) Token: 0x06019F9B RID: 106395 RVA: 0x003B6D26 File Offset: 0x003B4F26
		public int FirstRewardId { get; set; }

		// Token: 0x17007B0A RID: 31498
		// (get) Token: 0x06019F9C RID: 106396 RVA: 0x003B6D2F File Offset: 0x003B4F2F
		// (set) Token: 0x06019F9D RID: 106397 RVA: 0x003B6D37 File Offset: 0x003B4F37
		public byte NullMask { get; set; }

		// Token: 0x06019F9E RID: 106398 RVA: 0x003B6D40 File Offset: 0x003B4F40
		public IAutomaticRewardParamT()
		{
			this.Type = ELevelPlayRewardType.None;
			this.RewardId = 0;
			this.FirstRewardId = 0;
			this.NullMask = 0;
		}
	}
}
