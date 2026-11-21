using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006479 RID: 25721
	public class PhotoInputProcessorSelfie : PhotoInputProcessorBase
	{
		// Token: 0x0603E7C1 RID: 255937 RVA: 0x0122F3F3 File Offset: 0x0122D5F3
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
