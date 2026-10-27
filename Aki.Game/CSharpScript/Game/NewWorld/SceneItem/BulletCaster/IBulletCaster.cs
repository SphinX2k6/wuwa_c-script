using System;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x02007232 RID: 29234
	public interface IBulletCaster
	{
		// Token: 0x06047A5D RID: 293469
		void Start();

		// Token: 0x06047A5E RID: 293470
		void Stop();

		// Token: 0x06047A5F RID: 293471
		void SetTimeDilationRespectOwnerEntity();

		// Token: 0x06047A60 RID: 293472
		void SetTimeDilation(float timeDilation);
	}
}
