using System;

namespace CSharpScript.Game.LevelGamePlay.Common
{
	// Token: 0x0200609E RID: 24734
	public class ActorId
	{
		// Token: 0x0603B541 RID: 243009 RVA: 0x010CB534 File Offset: 0x010C9734
		public ActorId(int id, EIdType type)
		{
			this.Id = id;
			this.Type = type;
		}

		// Token: 0x0401F429 RID: 128041
		public int Id;

		// Token: 0x0401F42A RID: 128042
		public EIdType Type;
	}
}
