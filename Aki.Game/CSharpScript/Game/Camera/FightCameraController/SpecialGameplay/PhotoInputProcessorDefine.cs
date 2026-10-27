using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x020072F4 RID: 29428
	public class PhotoInputProcessorDefine
	{
		// Token: 0x04026256 RID: 156246
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<PhotoCameraType, Func<PhotoInputProcessorBase>> PhotoInputProcessorMap = new Dictionary<PhotoCameraType, Func<PhotoInputProcessorBase>>
		{
			{
				PhotoCameraType.Normal,
				() => new PhotoInputProcessorBase()
			},
			{
				PhotoCameraType.Selfie,
				() => new PhotoInputProcessorSelfie()
			},
			{
				PhotoCameraType.FirstPerson,
				() => new PhotoInputProcessorFirstPerson()
			},
			{
				PhotoCameraType.Drone,
				() => new PhotoInputProcessorBase()
			}
		};
	}
}
