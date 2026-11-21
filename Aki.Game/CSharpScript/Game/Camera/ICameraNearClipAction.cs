using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera
{
	// Token: 0x02006441 RID: 25665
	[NullableContext(1)]
	public interface ICameraNearClipAction<[Nullable(0)] out T> where T : CameraBaseNearClipConfig
	{
		// Token: 0x17007693 RID: 30355
		// (get) Token: 0x0603E501 RID: 255233
		T NearClipConfig { get; }

		// Token: 0x0603E502 RID: 255234
		void Start();

		// Token: 0x0603E503 RID: 255235
		bool IsPause();

		// Token: 0x0603E504 RID: 255236
		void Pause();

		// Token: 0x0603E505 RID: 255237
		void Resume();

		// Token: 0x0603E506 RID: 255238
		void End();
	}
}
