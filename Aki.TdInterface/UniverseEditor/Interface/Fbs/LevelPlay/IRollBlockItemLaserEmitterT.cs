using System;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200459A RID: 17818
	public class IRollBlockItemLaserEmitterT
	{
		// Token: 0x17007E97 RID: 32407
		// (get) Token: 0x0601AEBB RID: 110267 RVA: 0x003D72D2 File Offset: 0x003D54D2
		// (set) Token: 0x0601AEBC RID: 110268 RVA: 0x003D72DA File Offset: 0x003D54DA
		public ERollBlockItemType Type { get; set; }

		// Token: 0x17007E98 RID: 32408
		// (get) Token: 0x0601AEBD RID: 110269 RVA: 0x003D72E3 File Offset: 0x003D54E3
		// (set) Token: 0x0601AEBE RID: 110270 RVA: 0x003D72EB File Offset: 0x003D54EB
		public ERollBlockLayType Direction { get; set; }

		// Token: 0x17007E99 RID: 32409
		// (get) Token: 0x0601AEBF RID: 110271 RVA: 0x003D72F4 File Offset: 0x003D54F4
		// (set) Token: 0x0601AEC0 RID: 110272 RVA: 0x003D72FC File Offset: 0x003D54FC
		public int Length { get; set; }

		// Token: 0x17007E9A RID: 32410
		// (get) Token: 0x0601AEC1 RID: 110273 RVA: 0x003D7305 File Offset: 0x003D5505
		// (set) Token: 0x0601AEC2 RID: 110274 RVA: 0x003D730D File Offset: 0x003D550D
		public int Height { get; set; }

		// Token: 0x17007E9B RID: 32411
		// (get) Token: 0x0601AEC3 RID: 110275 RVA: 0x003D7316 File Offset: 0x003D5516
		// (set) Token: 0x0601AEC4 RID: 110276 RVA: 0x003D731E File Offset: 0x003D551E
		public byte NullMask { get; set; }

		// Token: 0x0601AEC5 RID: 110277 RVA: 0x003D7327 File Offset: 0x003D5527
		public IRollBlockItemLaserEmitterT()
		{
			this.Type = ERollBlockItemType.BreakableObstacle;
			this.Direction = ERollBlockLayType.Left;
			this.Length = 0;
			this.Height = 0;
			this.NullMask = 0;
		}
	}
}
