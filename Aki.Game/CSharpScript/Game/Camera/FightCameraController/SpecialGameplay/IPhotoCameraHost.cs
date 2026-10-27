using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Camera.PhotoCamera;
using Cysharp.Threading.Tasks;
using UnrealEngine;

namespace CSharpScript.Game.Camera.FightCameraController.SpecialGameplay
{
	// Token: 0x02007304 RID: 29444
	[NullableContext(2)]
	public interface IPhotoCameraHost
	{
		// Token: 0x17009F6F RID: 40815
		// (get) Token: 0x06048457 RID: 296023
		ACameraActor CameraActor { get; }

		// Token: 0x17009F70 RID: 40816
		// (get) Token: 0x06048458 RID: 296024
		CameraModelInstance CameraModel { get; }

		// Token: 0x17009F71 RID: 40817
		// (get) Token: 0x06048459 RID: 296025
		TsBaseCharacter Character { get; }

		// Token: 0x17009F72 RID: 40818
		// (get) Token: 0x0604845A RID: 296026
		PhotoCameraType? DefaultMode { get; }

		// Token: 0x17009F73 RID: 40819
		// (get) Token: 0x0604845B RID: 296027
		PhotoCameraType? CurrentMode { get; }

		// Token: 0x17009F74 RID: 40820
		// (get) Token: 0x0604845C RID: 296028
		BP_PhotoCameraConfig_C CurrentConfig { get; }

		// Token: 0x17009F75 RID: 40821
		// (get) Token: 0x0604845D RID: 296029
		[Nullable(1)]
		VirtualPhotoCamera VirtualCamera { [NullableContext(1)] get; }

		// Token: 0x17009F76 RID: 40822
		// (get) Token: 0x0604845E RID: 296030
		PhotoCameraLensState PendingLens { get; }

		// Token: 0x17009F77 RID: 40823
		// (get) Token: 0x0604845F RID: 296031
		PhotoCameraEntryPose InheritedEntryPose { get; }

		// Token: 0x17009F78 RID: 40824
		// (get) Token: 0x06048460 RID: 296032
		Vector PendingInheritWorldLocation { get; }

		// Token: 0x17009F79 RID: 40825
		// (get) Token: 0x06048461 RID: 296033
		bool IsDebugEnable { get; }

		// Token: 0x06048462 RID: 296034
		[NullableContext(0)]
		[return: Nullable(2)]
		T GetComponent<T>(EPhotoCameraComponent id) where T : PhotoCameraComponentBase;

		// Token: 0x06048463 RID: 296035
		[NullableContext(0)]
		UniTask<bool> SwitchMode(PhotoCameraType target, [Nullable(2)] string templateDaPath = null);

		// Token: 0x06048464 RID: 296036
		void NotifyTiltRollChanged(float roll);

		// Token: 0x06048465 RID: 296037
		[NullableContext(1)]
		void SetInheritedEntryPose(PhotoCameraEntryPose pose);
	}
}
