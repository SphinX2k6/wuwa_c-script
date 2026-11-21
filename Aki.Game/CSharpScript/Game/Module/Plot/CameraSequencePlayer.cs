using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Plot.Sequence;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02003F9D RID: 16285
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraSequencePlayer
	{
		// Token: 0x0602933A RID: 168762 RVA: 0x00B916F4 File Offset: 0x00B8F8F4
		public void Play(string path, bool isRelativeCamera)
		{
			if (this.IsPlaying)
			{
				this.Stop();
			}
			this.IsPlaying = true;
			this.IsRelative = isRelativeCamera;
			this.LoadId = ResourceSystem.Instance.LoadAsync<ULevelSequence>(path, new Action<ULevelSequence, string>(this.OnLoad), 100, "js_undefined");
		}

		// Token: 0x0602933B RID: 168763 RVA: 0x00B91744 File Offset: 0x00B8F944
		public void Stop()
		{
			if (!this.IsPlaying)
			{
				return;
			}
			this.IsPlaying = false;
			if (this.LoadId != -1)
			{
				ResourceSystem.Instance.CancelAsyncLoad(this.LoadId);
				this.LoadId = -1;
			}
			if (this.CurLevelSeqActor != null)
			{
				this.CurLevelSeqActor.SequencePlayer.OnStop.Clear();
				this.CurLevelSeqActor.SequencePlayer.Stop();
				CameraModel instance = CameraModel.Instance;
				if (instance != null)
				{
					SequenceCamera sequenceCamera = instance.MainModel.SequenceCamera;
					if (sequenceCamera != null)
					{
						sequenceCamera.UnregisterLevelSequenceActor(this.CurLevelSeqActor);
					}
				}
				this.CurLevelSeqActor.ResetBindings();
				ActorSystem.Instance.Put("MovingShotCameraSequencePlayer.Stop", this.CurLevelSeqActor, null);
			}
			this.CurLevelSeqActor = null;
		}

		// Token: 0x0602933C RID: 168764 RVA: 0x00B91800 File Offset: 0x00B8FA00
		private void OnLoad([Nullable(2)] ULevelSequence sequence, string _)
		{
			this.LoadId = -1;
			if (sequence == null || !ObjectUtils.IsValid(sequence))
			{
				return;
			}
			ALevelSequenceActor alevelSequenceActor = ActorSystem.Instance.Spawn<ALevelSequenceActor>(ALevelSequenceActor.StaticClass(), new FTransformDouble(), null);
			this.CurLevelSeqActor = alevelSequenceActor;
			this.CurLevelSeqActor.SetSequence(sequence);
			CameraModel.Instance.MainModel.SequenceCamera.RegisterLevelSequenceActor(alevelSequenceActor);
			if (this.IsRelative)
			{
				FTransformDouble inT = CameraController.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera.D_GetTransform();
				this.CurLevelSeqActor.bOverrideInstanceData = true;
				UDefaultLevelSequenceInstanceData udefaultLevelSequenceInstanceData = this.CurLevelSeqActor.DefaultInstanceData as UDefaultLevelSequenceInstanceData;
				FTransform transformOrigin = UKismetMathLibrary.Conv_TransformDoubleToTransform(inT);
				udefaultLevelSequenceInstanceData.TransformOrigin = transformOrigin;
			}
			TArray<AActor> tarray = new TArray<AActor>();
			BP_CineCamera_C cineCamera = CameraModel.Instance.MainModel.SequenceCamera.DisplayComponent.CineCamera;
			tarray.Add(cineCamera);
			cineCamera.ResetSeqCineCamSetting();
			this.CurLevelSeqActor.SetBindingByTag(SequenceDefine.CAMERA_TAG, tarray, false, true);
			alevelSequenceActor.SequencePlayer.OnStop.Add(new Action(this.OnStop));
			alevelSequenceActor.SequencePlayer.Play();
		}

		// Token: 0x0602933D RID: 168765 RVA: 0x00B91918 File Offset: 0x00B8FB18
		private void OnStop()
		{
			this.Stop();
		}

		// Token: 0x040166DA RID: 91866
		[Nullable(2)]
		private ALevelSequenceActor CurLevelSeqActor;

		// Token: 0x040166DB RID: 91867
		private int LoadId = -1;

		// Token: 0x040166DC RID: 91868
		private bool IsPlaying;

		// Token: 0x040166DD RID: 91869
		private bool IsRelative;
	}
}
