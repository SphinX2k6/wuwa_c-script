using System;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02005A9E RID: 23198
	public class DreamLinkRewardData
	{
		// Token: 0x0603AC30 RID: 240688 RVA: 0x00DFF151 File Offset: 0x00DFD351
		public DreamLinkRewardData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0401EAA4 RID: 125604
		public int Id;

		// Token: 0x0401EAA5 RID: 125605
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x0401EAA6 RID: 125606
		public int Current;

		// Token: 0x0401EAA7 RID: 125607
		public int Target = 1;
	}
}
