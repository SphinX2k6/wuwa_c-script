using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.Battle
{
	// Token: 0x02005C4B RID: 23627
	[NullableContext(1)]
	[Nullable(0)]
	public class BattleLinkView : UiViewBase
	{
		// Token: 0x0603BB46 RID: 244550 RVA: 0x00E421DD File Offset: 0x00E403DD
		public BattleLinkView(UiViewInfo viewInfo) : base(viewInfo)
		{
		}

		// Token: 0x0603BB47 RID: 244551 RVA: 0x00E421FC File Offset: 0x00E403FC
		protected override void OnAddEventListener()
		{
			EventSystem.Instance.Add(EEventName.OnBattleLinkStop, new Action(this.OnBattleLinkStop));
			EventSystem.Instance.Add<double>(EEventName.OnBattleLinkRestart, new Action<double>(this.OnRestart));
			EventSystem.Instance.Add(EEventName.TriggerUiTimeDilation, new Action(this.OnUiTimeDilation));
		}

		// Token: 0x0603BB48 RID: 244552 RVA: 0x00E4225C File Offset: 0x00E4045C
		protected override void OnRemoveEventListener()
		{
			EventSystem.Instance.Remove(EEventName.OnBattleLinkStop, new Action(this.OnBattleLinkStop));
			EventSystem.Instance.Remove(EEventName.OnBattleLinkRestart, new Action<double>(this.OnRestart));
			EventSystem.Instance.Remove(EEventName.TriggerUiTimeDilation, new Action(this.OnUiTimeDilation));
		}

		// Token: 0x0603BB49 RID: 244553 RVA: 0x00E422BC File Offset: 0x00E404BC
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

		// Token: 0x0603BB4A RID: 244554 RVA: 0x00E42373 File Offset: 0x00E40573
		protected override void OnBeforeDestroy()
		{
			this.SequencePlayer = null;
		}

		// Token: 0x0603BB4B RID: 244555 RVA: 0x00E4237C File Offset: 0x00E4057C
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

		// Token: 0x0603BB4C RID: 244556 RVA: 0x00E423C4 File Offset: 0x00E405C4
		protected override void OnBeforeHide()
		{
			ACameraActor cameraActor = CameraModel.Instance.MainModel.FightCamera.DisplayComponent.CameraActor;
			if (cameraActor != null)
			{
				this.RecoverCameraSettings(cameraActor);
			}
		}

		// Token: 0x0603BB4D RID: 244557 RVA: 0x00E423F5 File Offset: 0x00E405F5
		private void OnSequencePlayEvent(string sequenceName, string eventName)
		{
			if (eventName == "PlayProgress")
			{
				this.AnimDelay = Math.Max(0f, (float)Time.Instance.Now - (float)this.OpenViewTime);
				this.PlayProgressAnim();
			}
		}

		// Token: 0x0603BB4E RID: 244558 RVA: 0x00E4242D File Offset: 0x00E4062D
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

		// Token: 0x0603BB4F RID: 244559 RVA: 0x00E42458 File Offset: 0x00E40658
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

		// Token: 0x0603BB50 RID: 244560 RVA: 0x00E4249C File Offset: 0x00E4069C
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

		// Token: 0x0603BB51 RID: 244561 RVA: 0x00E424F8 File Offset: 0x00E406F8
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

		// Token: 0x0603BB52 RID: 244562 RVA: 0x00E42538 File Offset: 0x00E40738
		private void SaveCameraSettings(ACameraActor camera)
		{
			UCameraComponent cameraComponent = camera.CameraComponent;
			if (cameraComponent != null)
			{
				this.RadialBlurIntensityOverrideTemp = cameraComponent.PostProcessSettings.bOverride_KuroRadialBlurIntensity;
				this.RadialBlurIntensityTemp = cameraComponent.PostProcessSettings.KuroRadialBlurIntensity;
			}
		}

		// Token: 0x0603BB53 RID: 244563 RVA: 0x00E42574 File Offset: 0x00E40774
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

		// Token: 0x0603BB54 RID: 244564 RVA: 0x00E425A8 File Offset: 0x00E407A8
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

		// Token: 0x0603BB55 RID: 244565 RVA: 0x00E425F1 File Offset: 0x00E407F1
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

		// Token: 0x0603BB56 RID: 244566 RVA: 0x00E42618 File Offset: 0x00E40818
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

		// Token: 0x0603BB57 RID: 244567 RVA: 0x00E42664 File Offset: 0x00E40864
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

		// Token: 0x0603BB58 RID: 244568 RVA: 0x00E42748 File Offset: 0x00E40948
		private void PlayProgressAnim()
		{
			base.PlaySequence("Progress", new Action(this.Close), false);
			this.UpdatePlayRate();
		}

		// Token: 0x0401F15C RID: 127324
		private const float PROGRESS_SEQ_DURATION = 1f;

		// Token: 0x0401F15D RID: 127325
		private bool IsInRestart;

		// Token: 0x0401F15E RID: 127326
		private float LinkDuration;

		// Token: 0x0401F15F RID: 127327
		private float DefaultPlayRate = 1f;

		// Token: 0x0401F160 RID: 127328
		private double StartTime;

		// Token: 0x0401F161 RID: 127329
		private int OpenViewTime;

		// Token: 0x0401F162 RID: 127330
		private float AnimDelay;

		// Token: 0x0401F163 RID: 127331
		private float PlayRate = 1f;

		// Token: 0x0401F164 RID: 127332
		[Nullable(2)]
		private LevelSequencePlayer SequencePlayer;

		// Token: 0x0401F165 RID: 127333
		private bool IsCameraModify;

		// Token: 0x0401F166 RID: 127334
		private bool RadialBlurIntensityOverrideTemp;

		// Token: 0x0401F167 RID: 127335
		private float RadialBlurIntensityTemp;
	}
}
