using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004FFC RID: 20476
	public class ICheckRogueStateT
	{
		// Token: 0x17009281 RID: 37505
		// (get) Token: 0x0601FF4B RID: 130891 RVA: 0x0046F9B3 File Offset: 0x0046DBB3
		// (set) Token: 0x0601FF4C RID: 130892 RVA: 0x0046F9BB File Offset: 0x0046DBBB
		public ECheckSystemStateType Type { get; set; }

		// Token: 0x17009282 RID: 37506
		// (get) Token: 0x0601FF4D RID: 130893 RVA: 0x0046F9C4 File Offset: 0x0046DBC4
		// (set) Token: 0x0601FF4E RID: 130894 RVA: 0x0046F9CC File Offset: 0x0046DBCC
		public TRogueStateTypeUnion Config { get; set; }

		// Token: 0x0601FF4F RID: 130895 RVA: 0x0046F9D5 File Offset: 0x0046DBD5
		public ICheckRogueStateT()
		{
			this.Type = ECheckSystemStateType.TrackMoonBuilding;
			this.Config = null;
		}
	}
}
