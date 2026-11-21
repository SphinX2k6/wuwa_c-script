using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004E9A RID: 20122
	public class ICheckDungeonFinishT
	{
		// Token: 0x17008F89 RID: 36745
		// (get) Token: 0x0601F2ED RID: 127725 RVA: 0x004592A4 File Offset: 0x004574A4
		// (set) Token: 0x0601F2EE RID: 127726 RVA: 0x004592AC File Offset: 0x004574AC
		public ECondition Type { get; set; }

		// Token: 0x17008F8A RID: 36746
		// (get) Token: 0x0601F2EF RID: 127727 RVA: 0x004592B5 File Offset: 0x004574B5
		// (set) Token: 0x0601F2F0 RID: 127728 RVA: 0x004592BD File Offset: 0x004574BD
		public int DungeonId { get; set; }

		// Token: 0x17008F8B RID: 36747
		// (get) Token: 0x0601F2F1 RID: 127729 RVA: 0x004592C6 File Offset: 0x004574C6
		// (set) Token: 0x0601F2F2 RID: 127730 RVA: 0x004592CE File Offset: 0x004574CE
		public bool IsFinished { get; set; }

		// Token: 0x17008F8C RID: 36748
		// (get) Token: 0x0601F2F3 RID: 127731 RVA: 0x004592D7 File Offset: 0x004574D7
		// (set) Token: 0x0601F2F4 RID: 127732 RVA: 0x004592DF File Offset: 0x004574DF
		public byte NullMask { get; set; }

		// Token: 0x0601F2F5 RID: 127733 RVA: 0x004592E8 File Offset: 0x004574E8
		public ICheckDungeonFinishT()
		{
			this.Type = ECondition.CompareVar;
			this.DungeonId = 0;
			this.IsFinished = false;
			this.NullMask = 0;
		}
	}
}
