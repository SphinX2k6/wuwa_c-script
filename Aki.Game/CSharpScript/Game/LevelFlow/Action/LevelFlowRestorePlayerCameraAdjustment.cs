using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;
using CSharpScript.Game.Camera;
using CSharpScript.Game.Utils;

namespace CSharpScript.Game.LevelFlow.Action
{
	// Token: 0x0200611C RID: 24860
	[NullableContext(2)]
	[Nullable(0)]
	public class LevelFlowRestorePlayerCameraAdjustment : LevelFlowActionBase
	{
		// Token: 0x0603B912 RID: 243986 RVA: 0x010E471F File Offset: 0x010E291F
		[NullableContext(1)]
		public LevelFlowRestorePlayerCameraAdjustment Init(RestorePlayerCameraAdjustment param)
		{
			this.Params = param;
			return this;
		}

		// Token: 0x0603B913 RID: 243987 RVA: 0x010E472C File Offset: 0x010E292C
		protected override void OnExecute()
		{
			if (this.Params == null)
			{
				base.FinishExecute(false);
			}
			TsBaseCharacter baseCharacter = Global.BaseCharacter;
			if (baseCharacter != null)
			{
				RestorePlayerCameraAdjustment @params = this.Params;
				if (((@params != null) ? @params.ResetFocus : null) != null)
				{
					float fadeInTime = this.Params.ResetFocus.FadeInTime;
					CurveBase curve = ConfigCurveUtils.CreateCurveByBaseCurve(this.Params.ResetFocus.FadeInCurve, null);
					baseCharacter.GetEntityNoBlueprint().GetComponent<CharacterLockOnComponent>().ResetPitch(fadeInTime, curve, true, 0f, "MainCamera");
				}
			}
			global::Log.Instance.Info(ELogModule.LevelFlow, ELogAuthor.ZWY, "离开相机调整", default(ReadOnlySpan<ValueTuple<string, object>>));
			RestorePlayerCameraAdjustment params2 = this.Params;
			float? num;
			if (params2 == null)
			{
				num = null;
			}
			else
			{
				IResetFocusConfig resetFocus = params2.ResetFocus;
				num = ((resetFocus != null) ? new float?(resetFocus.FadeInTime) : null);
			}
			float? num2 = num;
			CameraController.Instance.MainModel.FightCamera.LogicComponent.RestoreCameraFromAdjust(num2, null, true);
			if (num2 != null)
			{
				float? num3 = num2;
				float num4 = 0f;
				if (num3.GetValueOrDefault() > num4 & num3 != null)
				{
					this.TimerHandle = TimerSystem.GameplayTimeInstance.Delay(delegate(float _)
					{
						base.FinishExecute(true);
					}, (float)((int)(num2.Value * 1000f)), null, null, true, 1f);
					return;
				}
			}
			base.FinishExecute(true);
		}

		// Token: 0x0603B914 RID: 243988 RVA: 0x010E487F File Offset: 0x010E2A7F
		protected override void OnComplete(bool isSuccess)
		{
			if (this.TimerHandle != null)
			{
				TimerSystem.GameplayTimeInstance.Remove(this.TimerHandle);
				this.TimerHandle = null;
			}
		}

		// Token: 0x0401F69E RID: 128670
		private RestorePlayerCameraAdjustment Params;

		// Token: 0x0401F69F RID: 128671
		private TimerHandle TimerHandle;
	}
}
