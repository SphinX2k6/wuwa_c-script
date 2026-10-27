using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Character.BaseCharacter.Camera;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Module.Plot.Sequence;
using UnrealEngine;

namespace CSharpScript.Game.Module.Plot
{
	// Token: 0x02004FD3 RID: 20435
	[NullableContext(1)]
	[Nullable(0)]
	public class CameraSequencePlayer
	{
		// Token: 0x060344B5 RID: 214197 RVA: 0x00C479D4 File Offset: 0x00C45BD4
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

		// Token: 0x060344B6 RID: 214198 RVA: 0x00C47A24 File Offset: 0x00C45C24
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
				this.CurLevelSeqActor.ResetBindings();
				ActorSystem.Instance.Put("CameraSequencePlayer.Stop", this.CurLevelSeqActor, null);
			}
			this.CurLevelSeqActor = null;
		}

		// Token: 0x060344B7 RID: 214199 RVA: 0x00C47AB8 File Offset: 0x00C45CB8
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

		// Token: 0x060344B8 RID: 214200 RVA: 0x00C47BBB File Offset: 0x00C45DBB
		private void OnStop()
		{
			this.Stop();
		}

		// Token: 0x0401BCFF RID: 113919
		[Nullable(2)]
		private ALevelSequenceActor CurLevelSeqActor;

		// Token: 0x0401BD00 RID: 113920
		private int LoadId = -1;

		// Token: 0x0401BD01 RID: 113921
		private bool IsPlaying;

		// Token: 0x0401BD02 RID: 113922
		private bool IsRelative;
	}
}
