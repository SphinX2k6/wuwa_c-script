using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006488 RID: 25736
	public class PhotoCameraDefine
	{
		// Token: 0x040215EB RID: 136683
		[Nullable(1)]
		[StaticVariableRuleIgnore]
		public static readonly IReadOnlyDictionary<PhotoCameraType, string> PhotoModeConfigPathMap = new Dictionary<PhotoCameraType, string>
		{
			{
				PhotoCameraType.Normal,
				"/Game/Aki/Data/Camera/PhotoCamera/DA/DA_Normal_PhotoCameraConfig.DA_Normal_PhotoCameraConfig"
			},
			{
				PhotoCameraType.Selfie,
				"/Game/Aki/Data/Camera/PhotoCamera/DA/DA_Selfie_PhotoCameraConfig.DA_Selfie_PhotoCameraConfig"
			},
			{
				PhotoCameraType.FirstPerson,
				"/Game/Aki/Data/Camera/PhotoCamera/DA/DA_FirstPerson_PhotoCameraConfig.DA_FirstPerson_PhotoCameraConfig"
			},
			{
				PhotoCameraType.Drone,
				"/Game/Aki/Data/Camera/PhotoCamera/DA/DA_Drone_PhotoCameraConfig.DA_Drone_PhotoCameraConfig"
			}
		};
	}
}
