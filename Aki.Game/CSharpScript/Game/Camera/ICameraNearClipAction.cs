using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x020072BF RID: 29375
	[NullableContext(1)]
	public interface ICameraNearClipAction<[Nullable(0)] out T> where T : CameraBaseNearClipConfig
	{
		// Token: 0x17009F2C RID: 40748
		// (get) Token: 0x0604810D RID: 295181
		T NearClipConfig { get; }

		// Token: 0x0604810E RID: 295182
		void Start();

		// Token: 0x0604810F RID: 295183
		bool IsPause();

		// Token: 0x06048110 RID: 295184
		void Pause();

		// Token: 0x06048111 RID: 295185
		void Resume();

		// Token: 0x06048112 RID: 295186
		void End();
	}
}
