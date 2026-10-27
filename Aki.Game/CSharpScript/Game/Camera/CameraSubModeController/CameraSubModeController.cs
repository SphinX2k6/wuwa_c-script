using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.CameraSubModeController
{
	// Token: 0x0200730F RID: 29455
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraSubModeController
	{
		// Token: 0x060484A6 RID: 296102 RVA: 0x01294720 File Offset: 0x01292920
		public void Start(CameraModelInstance cameraModelInstance)
		{
			this.OnStart(cameraModelInstance);
		}

		// Token: 0x060484A7 RID: 296103 RVA: 0x01294729 File Offset: 0x01292929
		public void Tick(float deltaTime)
		{
			this.OnTick(deltaTime);
		}

		// Token: 0x060484A8 RID: 296104 RVA: 0x01294732 File Offset: 0x01292932
		public void AfterTick(float deltaTime)
		{
			this.OnAfterTick(deltaTime);
		}

		// Token: 0x060484A9 RID: 296105 RVA: 0x0129473B File Offset: 0x0129293B
		public void End()
		{
			this.OnEnd();
		}

		// Token: 0x060484AA RID: 296106 RVA: 0x01294743 File Offset: 0x01292943
		protected virtual void OnStart(CameraModelInstance cameraModelInstance)
		{
		}

		// Token: 0x060484AB RID: 296107 RVA: 0x01294745 File Offset: 0x01292945
		protected virtual void OnTick(float deltaTime)
		{
		}

		// Token: 0x060484AC RID: 296108 RVA: 0x01294747 File Offset: 0x01292947
		protected virtual void OnAfterTick(float deltaTime)
		{
		}

		// Token: 0x060484AD RID: 296109 RVA: 0x01294749 File Offset: 0x01292949
		protected virtual void OnEnd()
		{
		}
	}
}
