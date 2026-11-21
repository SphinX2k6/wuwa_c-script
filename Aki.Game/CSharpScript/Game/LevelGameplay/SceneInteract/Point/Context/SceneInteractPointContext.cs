using System;

namespace CSharpScript.Game.LevelGamePlay.SceneInteract.Point.Context
{
	// Token: 0x02005BED RID: 23533
	public abstract class SceneInteractPointContext
	{
		// Token: 0x06039CCB RID: 236747
		public abstract ESceneInteractType GetInteractType();

		// Token: 0x06039CCC RID: 236748
		public abstract ESceneInteractPointType GetInteractPointType();

		// Token: 0x06039CCD RID: 236749 RVA: 0x0103BA9D File Offset: 0x01039C9D
		public virtual bool IsValid()
		{
			return true;
		}

		// Token: 0x06039CCE RID: 236750 RVA: 0x0103BAA0 File Offset: 0x01039CA0
		public virtual void Dispose()
		{
		}
	}
}
