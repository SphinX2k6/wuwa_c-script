using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006472 RID: 25714
	[NullableContext(1)]
	[Nullable(0)]
	public class PhotoInputProcessorBase
	{
		// Token: 0x0603E795 RID: 255893 RVA: 0x0122F229 File Offset: 0x0122D429
		public virtual void OnEnter(IPhotoInputContext context)
		{
		}

		// Token: 0x0603E796 RID: 255894 RVA: 0x0122F22B File Offset: 0x0122D42B
		public virtual void OnExit(IPhotoInputContext context)
		{
		}

		// Token: 0x0603E797 RID: 255895 RVA: 0x0122F230 File Offset: 0x0122D430
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
