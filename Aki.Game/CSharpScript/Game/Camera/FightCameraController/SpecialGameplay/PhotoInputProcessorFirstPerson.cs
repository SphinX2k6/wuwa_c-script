using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006478 RID: 25720
	public class PhotoInputProcessorFirstPerson : PhotoInputProcessorBase
	{
		// Token: 0x0603E7BF RID: 255935 RVA: 0x0122F3BF File Offset: 0x0122D5BF
		[NullableContext(1)]
		public override void Process(IPhotoInputSnapshot raw, IPhotoInputContext context, IPhotoInputSnapshot @out)
		{
			base.Process(raw, context, @out);
			@out.MoveForward = 0f;
			@out.MoveRight = 0f;
			@out.MoveUp = 0f;
		}
	}
}
