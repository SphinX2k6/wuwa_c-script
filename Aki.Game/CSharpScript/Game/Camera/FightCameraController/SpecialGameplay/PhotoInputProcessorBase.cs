using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072EF RID: 29423
	[NullableContext(1)]
	[Nullable(0)]
	public class PhotoInputProcessorBase
	{
		// Token: 0x06048349 RID: 295753 RVA: 0x0128C875 File Offset: 0x0128AA75
		public virtual void OnEnter(IPhotoInputContext context)
		{
		}

		// Token: 0x0604834A RID: 295754 RVA: 0x0128C877 File Offset: 0x0128AA77
		public virtual void OnExit(IPhotoInputContext context)
		{
		}

		// Token: 0x0604834B RID: 295755 RVA: 0x0128C87C File Offset: 0x0128AA7C
		public virtual void Process(IPhotoInputSnapshot raw, IPhotoInputContext context, IPhotoInputSnapshot @out)
		{
			@out.MoveForward = raw.MoveForward;
			@out.MoveRight = raw.MoveRight;
			@out.MoveUp = raw.MoveUp;
			@out.Pitch = raw.Pitch;
			@out.Yaw = raw.Yaw;
			@out.Roll = raw.Roll;
			@out.Fov = raw.Fov;
		}
	}
}
