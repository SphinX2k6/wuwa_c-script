using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.LevelGamePlay.UnopenedArea
{
	// Token: 0x020069B6 RID: 27062
	[NullableContext(1)]
	public interface IUnopenedAreaHandler
	{
		// Token: 0x1700985B RID: 39003
		// (get) Token: 0x06043551 RID: 275793
		bool ForbidVehicleOnEnter { get; }

		// Token: 0x06043552 RID: 275794
		bool OnEnter();

		// Token: 0x06043553 RID: 275795
		void OnExit();

		// Token: 0x06043554 RID: 275796
		void Tick(float delta);

		// Token: 0x06043555 RID: 275797
		void OnChangeRole(EntityHandle newEntityHandle, [Nullable(2)] EntityHandle oldEntityHandle);

		// Token: 0x06043556 RID: 275798
		void Clear();
	}
}
