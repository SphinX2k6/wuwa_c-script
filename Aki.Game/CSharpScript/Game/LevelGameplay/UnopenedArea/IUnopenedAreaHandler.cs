using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.UnopenedArea
{
	// Token: 0x02005B12 RID: 23314
	[NullableContext(1)]
	public interface IUnopenedAreaHandler
	{
		// Token: 0x17006D3B RID: 27963
		// (get) Token: 0x06039589 RID: 234889
		bool ForbidVehicleOnEnter { get; }

		// Token: 0x0603958A RID: 234890
		bool OnEnter();

		// Token: 0x0603958B RID: 234891
		void OnExit();

		// Token: 0x0603958C RID: 234892
		void Tick(float delta);

		// Token: 0x0603958D RID: 234893
		void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle);

		// Token: 0x0603958E RID: 234894
		void Clear();
	}
}
