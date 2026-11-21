using System;

namespace CSharpScript.Game.NewWorld.SceneItem.BulletCaster
{
	// Token: 0x020062E7 RID: 25319
	public interface IBulletCaster
	{
		// Token: 0x0603D3BE RID: 250814
		void Start();

		// Token: 0x0603D3BF RID: 250815
		void Stop();

		// Token: 0x0603D3C0 RID: 250816
		void SetTimeDilationRespectOwnerEntity();

		// Token: 0x0603D3C1 RID: 250817
		void SetTimeDilation(float timeDilation);
	}
}
