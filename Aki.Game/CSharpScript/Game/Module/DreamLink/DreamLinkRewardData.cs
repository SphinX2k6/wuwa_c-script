using System;

namespace CSharpScript.Game.Module.DreamLink
{
	// Token: 0x02004A7A RID: 19066
	public class DreamLinkRewardData
	{
		// Token: 0x0602FB79 RID: 195449 RVA: 0x00D4F6B9 File Offset: 0x00D4D8B9
		public DreamLinkRewardData(int id)
		{
			this.Id = id;
		}

		// Token: 0x0401954B RID: 103755
		public int Id;

		// Token: 0x0401954C RID: 103756
		public EActivityTaskState Status = EActivityTaskState.Active;

		// Token: 0x0401954D RID: 103757
		public int Current;

		// Token: 0x0401954E RID: 103758
		public int Target = 1;
	}
}
