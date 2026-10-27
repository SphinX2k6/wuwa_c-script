using System;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02006A90 RID: 27280
	public abstract class SceneInteractPointContext
	{
		// Token: 0x06043C7D RID: 277629
		public abstract ESceneInteractType GetInteractType();

		// Token: 0x06043C7E RID: 277630
		public abstract ESceneInteractPointType GetInteractPointType();

		// Token: 0x06043C7F RID: 277631 RVA: 0x01097249 File Offset: 0x01095449
		public virtual bool IsValid()
		{
			return true;
		}

		// Token: 0x06043C80 RID: 277632 RVA: 0x0109724C File Offset: 0x0109544C
		public virtual void Dispose()
		{
		}
	}
}
