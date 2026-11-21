using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02006487 RID: 25735
	[NullableContext(2)]
	public interface IPhotoCameraHost
	{
		// Token: 0x1700770D RID: 30477
		// (get) Token: 0x0603E8A4 RID: 256164
		ACameraActor CameraActor { get; }

		// Token: 0x1700770E RID: 30478
		// (get) Token: 0x0603E8A5 RID: 256165
		CameraModelInstance CameraModel { get; }

		// Token: 0x1700770F RID: 30479
		// (get) Token: 0x0603E8A6 RID: 256166
		TsBaseCharacter Character { get; }

		// Token: 0x17007710 RID: 30480
		// (get) Token: 0x0603E8A7 RID: 256167
		PhotoCameraType? DefaultMode { get; }

		// Token: 0x17007711 RID: 30481
		// (get) Token: 0x0603E8A8 RID: 256168
		PhotoCameraType? CurrentMode { get; }

		// Token: 0x17007712 RID: 30482
		// (get) Token: 0x0603E8A9 RID: 256169
		BP_PhotoCameraConfig_C CurrentConfig { get; }

		// Token: 0x17007713 RID: 30483
		// (get) Token: 0x0603E8AA RID: 256170
		[Nullable(1)]
		VirtualPhotoCamera VirtualCamera { [NullableContext(1)] get; }

		// Token: 0x17007714 RID: 30484
		// (get) Token: 0x0603E8AB RID: 256171
		PhotoCameraLensState PendingLens { get; }

		// Token: 0x17007715 RID: 30485
		// (get) Token: 0x0603E8AC RID: 256172
		PhotoCameraEntryPose InheritedEntryPose { get; }

		// Token: 0x17007716 RID: 30486
		// (get) Token: 0x0603E8AD RID: 256173
		Vector PendingInheritWorldLocation { get; }

		// Token: 0x17007717 RID: 30487
		// (get) Token: 0x0603E8AE RID: 256174
		bool IsDebugEnable { get; }

		// Token: 0x0603E8AF RID: 256175
		[NullableContext(0)]
		[return: Nullable(2)]
		T GetComponent<T>(EPhotoCameraComponent id) where T : PhotoCameraComponentBase;

		// Token: 0x0603E8B0 RID: 256176
		[NullableContext(0)]
		UniTask<bool> SwitchMode(PhotoCameraType target, [Nullable(2)] string templateDaPath = null);

		// Token: 0x0603E8B1 RID: 256177
		void NotifyTiltRollChanged(float roll);

		// Token: 0x0603E8B2 RID: 256178
		[NullableContext(1)]
		void SetInheritedEntryPose(PhotoCameraEntryPose pose);
	}
}
