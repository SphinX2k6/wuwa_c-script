using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02004C2B RID: 19499
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleLinkView : UiViewBase
	{
		// Token: 0x06030A91 RID: 199313 RVA: 0x00D925A9 File Offset: 0x00D907A9
		public BattleLinkView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x06030A92 RID: 199314 RVA: 0x00D925C8 File Offset: 0x00D907C8
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnBattleLinkStop, new Action(this.OnBattleLinkStop));
			EventSystem.Instance.Add<double>(EEventName.OnBattleLinkRestart, new Action<double>(this.OnRestart));
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnUiTimeDilation));
		}

		// Token: 0x06030A93 RID: 199315 RVA: 0x00D92628 File Offset: 0x00D90828
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnBattleLinkStop, new Action(this.OnBattleLinkStop));
			EventSystem.Instance.Remove(EEventName.OnBattleLinkRestart, new Action<double>(this.OnRestart));
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnUiTimeDilation));
		}

		// Token: 0x06030A94 RID: 199316 RVA: 0x00D92688 File Offset: 0x00D90888
		protected override void OnStart()
		{
			if (this.OpenParam != null)
			{
				this.StartTime = (double)this.OpenParam;
			}
			this.IsInRestart = false;
			this.LinkDuration = (float)(BattleLinkModel.Instance.GetLinkDuration() / TimeUtil.Instance.InverseMillisecond);
			this.DefaultPlayRate = 1f / this.LinkDuration;
			this.RootActor.OnSequencePlayEvent.Bind(new Action<string, string>(this.OnSequencePlayEvent));
			this.SequencePlayer = new LevelSequencePlayer(base.GetRootItem());
			this.SequencePlayer.BindSequenceStartEvent(new TSequenceStartEvent(this.OnSequenceStart));
			this.SequencePlayer.BindSequenceCloseEvent(new TSequenceEndEvent(this.OnSequenceEnd), false);
		}

		// Token: 0x06030A95 RID: 199317 RVA: 0x00D9273F File Offset: 0x00D9093F
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer = null;
		}

		// Token: 0x06030A96 RID: 199318 RVA: 0x00D92748 File Offset: 0x00D90948
		protected override void OnAfterShow()
		{
			this.IsInRestart = false;
			this.OpenViewTime = (int)Time.Instance.Now;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("StartLink", false, null, false);
		}

		// Token: 0x06030A97 RID: 199319 RVA: 0x00D92790 File Offset: 0x00D90990
		protected override void OnBeforeHide()
		{
			ACameraActor cameraActor = CameraModel.Instance.MainModel.FightCamera.DisplayComponent.CameraActor;
			if (cameraActor != null)
			{
				this.RecoverCameraSettings(cameraActor);
			}
		}

		// Token: 0x06030A98 RID: 199320 RVA: 0x00D927C1 File Offset: 0x00D909C1
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (eventName == "PlayProgress")
			{
				this.AnimDelay = Math.Max(0f, (float)Time.Instance.Now - (float)this.OpenViewTime);
				this.PlayProgressAnim();
			}
		}

		// Token: 0x06030A99 RID: 199321 RVA: 0x00D927F9 File Offset: 0x00D909F9
		private void OnBattleLinkStop()
		{
			this.IsInRestart = false;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence != null)
			{
				uiViewSequence.StopSequenceByKey("Progress", false, false);
			}
			base.CloseMe(null);
		}

		// Token: 0x06030A9A RID: 199322 RVA: 0x00D92824 File Offset: 0x00D90A24
		private void Close()
		{
			if (!this.IsInRestart)
			{
				base.CloseMe(null);
				return;
			}
			this.IsInRestart = false;
			LevelSequencePlayer sequencePlayer = this.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.PlayLevelSequenceByName("StartLink", false, null, false);
		}

		// Token: 0x06030A9B RID: 199323 RVA: 0x00D92868 File Offset: 0x00D90A68
		private void OnSequenceStart(string sequenceName)
		{
			if (sequenceName == "StartLink")
			{
				ACameraActor cameraActor = CameraModel.Instance.MainModel.FightCamera.DisplayComponent.CameraActor;
				if (cameraActor != null)
				{
					this.SaveCameraSettings(cameraActor);
					this.ModifyCameraSettings(cameraActor);
					this.SequencePlayer.SetActorTag(sequenceName, new FName("CameraActor"), cameraActor);
				}
			}
		}

		// Token: 0x06030A9C RID: 199324 RVA: 0x00D928C4 File Offset: 0x00D90AC4
		private void OnSequenceEnd(string sequenceName)
		{
			if (sequenceName == "StartLink")
			{
				ACameraActor cameraActor = CameraModel.Instance.MainModel.FightCamera.DisplayComponent.CameraActor;
				if (cameraActor != null)
				{
					this.RecoverCameraSettings(cameraActor);
				}
			}
		}

		// Token: 0x06030A9D RID: 199325 RVA: 0x00D92904 File Offset: 0x00D90B04
		private void SaveCameraSettings(ACameraActor camera)
		{
			UCameraComponent cameraComponent = camera.CameraComponent;
			if (cameraComponent != null)
			{
				this.RadialBlurIntensityOverrideTemp = cameraComponent.PostProcessSettings.bOverride_KuroRadialBlurIntensity;
				this.RadialBlurIntensityTemp = cameraComponent.PostProcessSettings.KuroRadialBlurIntensity;
			}
		}

		// Token: 0x06030A9E RID: 199326 RVA: 0x00D92940 File Offset: 0x00D90B40
		private void ModifyCameraSettings(ACameraActor camera)
		{
			if (this.IsCameraModify)
			{
				return;
			}
			this.IsCameraModify = true;
			UCameraComponent cameraComponent = camera.CameraComponent;
			if (cameraComponent != null)
			{
				cameraComponent.PostProcessSettings.bOverride_KuroRadialBlurIntensity = true;
			}
		}

		// Token: 0x06030A9F RID: 199327 RVA: 0x00D92974 File Offset: 0x00D90B74
		private void RecoverCameraSettings(ACameraActor camera)
		{
			if (!this.IsCameraModify)
			{
				return;
			}
			this.IsCameraModify = false;
			UCameraComponent cameraComponent = camera.CameraComponent;
			if (cameraComponent != null)
			{
				cameraComponent.PostProcessSettings.bOverride_KuroRadialBlurIntensity = this.RadialBlurIntensityOverrideTemp;
				cameraComponent.PostProcessSettings.KuroRadialBlurIntensity = this.RadialBlurIntensityTemp;
			}
		}

		// Token: 0x06030AA0 RID: 199328 RVA: 0x00D929BD File Offset: 0x00D90BBD
		private void OnRestart(double startTime)
		{
			this.IsInRestart = true;
			this.StartTime = startTime;
			UiBehaviorLevelSequence uiViewSequence = this.UiViewSequence;
			if (uiViewSequence == null)
			{
				return;
			}
			uiViewSequence.StopSequenceByKey("Progress", false, false);
		}

		// Token: 0x06030AA1 RID: 199329 RVA: 0x00D929E4 File Offset: 0x00D90BE4
		private void OnUiTimeDilation()
		{
			float playRate = this.PlayRate * Time.Instance.TimeDilation;
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			ALevelSequenceActor sequencePlayerByKey = rootActor.GetSequencePlayerByKey("Progress");
			if (sequencePlayerByKey == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.SetPlayRate(playRate);
		}

		// Token: 0x06030AA2 RID: 199330 RVA: 0x00D92A30 File Offset: 0x00D90C30
		private void UpdatePlayRate()
		{
			this.PlayRate = this.DefaultPlayRate;
			float playRate = this.DefaultPlayRate * Time.Instance.TimeDilation;
			if (this.StartTime != 0.0)
			{
				float num = (float)TimeUtil.Instance.GetServerTimeStamp();
				double num2 = Math.Max(0.0, (double)num - this.StartTime) + (double)this.AnimDelay;
				double num3 = Math.Max(1.0, (double)this.LinkDuration - num2 / (double)TimeUtil.Instance.InverseMillisecond - 0.20000000298023224);
				this.PlayRate = (float)(1.0 / num3);
				playRate = this.PlayRate * Time.Instance.TimeDilation;
			}
			AUIBaseActor rootActor = this.RootActor;
			if (rootActor == null)
			{
				return;
			}
			ALevelSequenceActor sequencePlayerByKey = rootActor.GetSequencePlayerByKey("Progress");
			if (sequencePlayerByKey == null)
			{
				return;
			}
			ULevelSequencePlayer sequencePlayer = sequencePlayerByKey.SequencePlayer;
			if (sequencePlayer == null)
			{
				return;
			}
			sequencePlayer.SetPlayRate(playRate);
		}

		// Token: 0x06030AA3 RID: 199331 RVA: 0x00D92B14 File Offset: 0x00D90D14
		private void PlayProgressAnim()
		{
			base.PlaySequence("Progress", new Action(this.Close), false);
			this.UpdatePlayRate();
		}

		// Token: 0x04019C0D RID: 105485
		private const float PROGRESS_SEQ_DURATION = 1f;

		// Token: 0x04019C0E RID: 105486
		private bool IsInRestart;

		// Token: 0x04019C0F RID: 105487
		private float LinkDuration;

		// Token: 0x04019C10 RID: 105488
		private float DefaultPlayRate = 1f;

		// Token: 0x04019C11 RID: 105489
		private double StartTime;

		// Token: 0x04019C12 RID: 105490
		private int OpenViewTime;

		// Token: 0x04019C13 RID: 105491
		private float AnimDelay;

		// Token: 0x04019C14 RID: 105492
		private float PlayRate = 1f;

		// Token: 0x04019C15 RID: 105493
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x04019C16 RID: 105494
		private bool IsCameraModify;

		// Token: 0x04019C17 RID: 105495
		private bool RadialBlurIntensityOverrideTemp;

		// Token: 0x04019C18 RID: 105496
		private float RadialBlurIntensityTemp;
	}
}
