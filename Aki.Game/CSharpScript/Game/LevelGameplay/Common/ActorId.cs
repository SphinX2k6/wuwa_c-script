using System;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x02006F1D RID: 28445
	public class ActorId
	{
		// Token: 0x06045393 RID: 283539 RVA: 0x01121588 File Offset: 0x0111F788
		public ActorId(int id, EIdType type)
		{
			this.Id = id;
			this.Type = type;
		}

		// Token: 0x04024174 RID: 147828
		public int Id;

		// Token: 0x04024175 RID: 147829
		public EIdType Type;
	}
}
