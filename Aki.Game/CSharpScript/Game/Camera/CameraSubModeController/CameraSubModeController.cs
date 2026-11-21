using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.CameraSubModeController
{
	// Token: 0x02006492 RID: 25746
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraSubModeController
	{
		// Token: 0x0603E8F3 RID: 256243 RVA: 0x012371A0 File Offset: 0x012353A0
		public void Start(CameraModelInstance cameraModelInstance)
		{
			this.OnStart(cameraModelInstance);
		}

		// Token: 0x0603E8F4 RID: 256244 RVA: 0x012371A9 File Offset: 0x012353A9
		public void Tick(float deltaTime)
		{
			this.OnTick(deltaTime);
		}

		// Token: 0x0603E8F5 RID: 256245 RVA: 0x012371B2 File Offset: 0x012353B2
		public void AfterTick(float deltaTime)
		{
			this.OnAfterTick(deltaTime);
		}

		// Token: 0x0603E8F6 RID: 256246 RVA: 0x012371BB File Offset: 0x012353BB
		public void End()
		{
			this.OnEnd();
		}

		// Token: 0x0603E8F7 RID: 256247 RVA: 0x012371C3 File Offset: 0x012353C3
		protected virtual void OnStart(CameraModelInstance cameraModelInstance)
		{
		}

		// Token: 0x0603E8F8 RID: 256248 RVA: 0x012371C5 File Offset: 0x012353C5
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x0603E8F9 RID: 256249 RVA: 0x012371C7 File Offset: 0x012353C7
		protected virtual void OnAfterTick(float deltaTime)
		{
		}

		// Token: 0x0603E8FA RID: 256250 RVA: 0x012371C9 File Offset: 0x012353C9
		protected virtual void OnEnd()
		{
		}
	}
}
