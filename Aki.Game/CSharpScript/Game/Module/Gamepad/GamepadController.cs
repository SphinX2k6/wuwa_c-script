using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using Aki.TDConfigMgr.Action;
using CSharpScript.Core.Common;
using CSharpScript.Game.InputSetting;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Module.Gamepad
{
	// Token: 0x020049CD RID: 18893
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadController : ControllerBase
	{
		// Token: 0x0602F4FA RID: 193786 RVA: 0x00D32DF0 File Offset: 0x00D30FF0
		protected override bool OnInit()
		{
			this.HitForceFeedbackPaths.Add(ConfigCommonParamById.GetStringConfig("FKHitForceFeedbackPath"));
			this.HitForceFeedbackPaths.Add(ConfigCommonParamById.GetStringConfig("LightHitForceFeedbackPath"));
			this.HitForceFeedbackPaths.Add(ConfigCommonParamById.GetStringConfig("HeavyHitForceFeedbackPath"));
			this.GamepadPsFeedbackListenTagModule.Init();
			this.LightBarListenTagModule.Init();
			return true;
		}

		// Token: 0x0602F4FB RID: 193787 RVA: 0x00D32E53 File Offset: 0x00D31053
		protected override bool OnClear()
		{
			this.ClearFeedbackReason();
			this.GamepadPsFeedbackLoadModule.Clear();
			this.GamepadPsFeedbackListenTagModule.Clear();
			this.LightBarListenTagModule.Clear();
			this.LightBarModule.ClearAll(true);
			return true;
		}

		// Token: 0x0602F4FC RID: 193788 RVA: 0x00D32E89 File Offset: 0x00D31089
		public bool SetLightBar(string id)
		{
			return this.LightBarModule.Set(id);
		}

		// Token: 0x0602F4FD RID: 193789 RVA: 0x00D32E97 File Offset: 0x00D31097
		public bool RemoveLightBar(string id)
		{
			return this.LightBarModule.Remove(id);
		}

		// Token: 0x0602F4FE RID: 193790 RVA: 0x00D32EA5 File Offset: 0x00D310A5
		public void ClearLightBar()
		{
			this.LightBarModule.ClearAll(true);
		}

		// Token: 0x0602F4FF RID: 193791 RVA: 0x00D32EB4 File Offset: 0x00D310B4
		public void PlayForceFeedbackByHit(EHitFeedbackType type)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return;
			}
			if (type < (EHitFeedbackType)this.HitForceFeedbackEffects.Count)
			{
				UKuroForceFeedbackEffect ukuroForceFeedbackEffect;
				this.HitForceFeedbackEffects.TryGetValue((int)type, out ukuroForceFeedbackEffect);
				if (ukuroForceFeedbackEffect != null)
				{
					this.PlayKuroForceFeedback(ukuroForceFeedbackEffect, null, false, false, false, "Hit");
					return;
				}
			}
			if (type < (EHitFeedbackType)this.HitForceFeedbackPaths.Count)
			{
				string path = this.HitForceFeedbackPaths[(int)type];
				ResourceSystem.Instance.LoadAsync<UKuroForceFeedbackEffect>(path, delegate([Nullable(2)] UKuroForceFeedbackEffect result, string loadPath)
				{
					if (result != null)
					{
						this.PlayKuroForceFeedback(result, null, false, false, false, "Hit");
					}
				}, ResourceSystem.EResourceLoadPriority.Default, "Ui.GamepadUi");
			}
		}

		// Token: 0x0602F500 RID: 193792 RVA: 0x00D32F44 File Offset: 0x00D31144
		private void RefreshPsFeedbackMode()
		{
			GamepadPsFeedbackData.FeedbackInfo lastFeedbackInfo = this.GamepadPsFeedbackData.GetLastFeedbackInfo();
			if (lastFeedbackInfo != null)
			{
				this.GamepadPsFeedbackLoadModule.PlayFeedback(lastFeedbackInfo.Mode, lastFeedbackInfo.Path);
				return;
			}
			this.GamepadPsFeedbackLoadModule.StopFeedback();
		}

		// Token: 0x0602F501 RID: 193793 RVA: 0x00D32F84 File Offset: 0x00D31184
		private ETriggerEffectSide? GetActionNameMode(string actionName)
		{
			TArray<FInputActionKeyMapping> actionMappings = InputSettings.Instance.GetActionMappings(actionName);
			if (actionMappings.Num() <= 0)
			{
				return null;
			}
			bool flag = false;
			bool flag2 = false;
			for (int i = actionMappings.Num() - 1; i >= 0; i--)
			{
				FInputActionKeyMapping finputActionKeyMapping = actionMappings.Get(i);
				string text = (finputActionKeyMapping != null) ? finputActionKeyMapping.Key.KeyName.ToString() : null;
				InputKey key = InputSettings.Instance.GetKey(text);
				if (key != null && key.IsGamepadKey)
				{
					if (text == EKey.Gamepad_LeftTrigger)
					{
						flag = true;
					}
					else if (text == EKey.Gamepad_RightTrigger)
					{
						flag2 = true;
					}
				}
			}
			if (flag && flag2)
			{
				return new ETriggerEffectSide?(ETriggerEffectSide.Both);
			}
			if (flag)
			{
				return new ETriggerEffectSide?(ETriggerEffectSide.Left);
			}
			if (flag2)
			{
				return new ETriggerEffectSide?(ETriggerEffectSide.Right);
			}
			return null;
		}

		// Token: 0x0602F502 RID: 193794 RVA: 0x00D33068 File Offset: 0x00D31268
		private static ETriggerEffectSide? GetAxisNameMode(string axisName)
		{
			TArray<FInputAxisKeyMapping> axisMappings = InputSettings.Instance.GetAxisMappings(axisName);
			if (axisMappings.Num() <= 0)
			{
				return null;
			}
			bool flag = false;
			bool flag2 = false;
			for (int i = axisMappings.Num() - 1; i >= 0; i--)
			{
				string text = axisMappings.Get(i).Key.KeyName.ToString();
				InputKey key = InputSettings.Instance.GetKey(text);
				if (key != null && key.IsGamepadKey)
				{
					if (text == EKey.Gamepad_LeftTriggerAxis)
					{
						if (key.IsInputKeyDown())
						{
							flag = true;
						}
					}
					else if (text == EKey.Gamepad_RightTriggerAxis && key.IsInputKeyDown())
					{
						flag2 = true;
					}
				}
			}
			if (flag && flag2)
			{
				return new ETriggerEffectSide?(ETriggerEffectSide.Both);
			}
			if (flag)
			{
				return new ETriggerEffectSide?(ETriggerEffectSide.Left);
			}
			if (flag2)
			{
				return new ETriggerEffectSide?(ETriggerEffectSide.Right);
			}
			return null;
		}

		// Token: 0x0602F503 RID: 193795 RVA: 0x00D3315C File Offset: 0x00D3135C
		private ETriggerEffectSide? GetOperationNameMode(string operationName, bool isAxis)
		{
			if (!Info.Instance.IsInGamepad())
			{
				return null;
			}
			if (isAxis)
			{
				return GamepadController.GetAxisNameMode(operationName);
			}
			return this.GetActionNameMode(operationName);
		}

		// Token: 0x0602F504 RID: 193796 RVA: 0x00D33190 File Offset: 0x00D31390
		public void TryAddFeedbackReason(EGamepadPsFeedbackReason reason, string feedbackId)
		{
			PsFeedback? psFeedbackReason = GamepadConfig.Instance.GetPsFeedbackReason(feedbackId);
			if (psFeedbackReason == null)
			{
				return;
			}
			ETriggerEffectSide? operationNameMode = this.GetOperationNameMode(psFeedbackReason.Value.ActionName, psFeedbackReason.Value.IsAxis);
			if (operationNameMode == null)
			{
				this.RemoveFeedbackReason(reason);
				return;
			}
			this.AddFeedbackReason(reason, operationNameMode.Value, psFeedbackReason.Value.FeedbackPath);
		}

		// Token: 0x0602F505 RID: 193797 RVA: 0x00D33206 File Offset: 0x00D31406
		private void AddFeedbackReason(EGamepadPsFeedbackReason reason, ETriggerEffectSide mode, string path)
		{
			this.GamepadPsFeedbackData.AddFeedbackReason(reason, mode, path);
			this.RefreshPsFeedbackMode();
		}

		// Token: 0x0602F506 RID: 193798 RVA: 0x00D3321C File Offset: 0x00D3141C
		public void RemoveFeedbackReason(EGamepadPsFeedbackReason reason)
		{
			if (this.GamepadPsFeedbackData.RemoveFeedbackReason(reason))
			{
				this.RefreshPsFeedbackMode();
			}
		}

		// Token: 0x0602F507 RID: 193799 RVA: 0x00D33232 File Offset: 0x00D31432
		private void ClearFeedbackReason()
		{
			this.GamepadPsFeedbackData.ClearFeedbackReason();
			this.RefreshPsFeedbackMode();
		}

		// Token: 0x0602F508 RID: 193800 RVA: 0x00D33248 File Offset: 0x00D31448
		[NullableContext(2)]
		public void PlayKuroForceFeedback(UKuroForceFeedbackEffect forceFeedbackEffect, FName? tag, bool bLooping, bool bIgnoreTimeDilation, bool bPlayWhilePaused, string reason = null)
		{
			if (Global.PlayerController != null)
			{
				FName tag2 = tag ?? FNameUtil.NONE;
				TsCharacterController tsCharacterController = Global.PlayerController as TsCharacterController;
				if (tsCharacterController == null)
				{
					return;
				}
				tsCharacterController.PlayKuroForceFeedback(forceFeedbackEffect, tag2, bLooping, bIgnoreTimeDilation, bPlayWhilePaused);
			}
		}

		// Token: 0x0602F509 RID: 193801 RVA: 0x00D33294 File Offset: 0x00D31494
		public void TriggerGamepadShakeByQte(ECommonQteContextType qteType, UKuroForceFeedbackEffect gamepadShakeAsset)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName("Qte_GamepadShake");
			if (dynamicFName == null)
			{
				return;
			}
			if (qteType <= ECommonQteContextType.SingleButtonContinuousClick)
			{
				this.PlayKuroForceFeedback(gamepadShakeAsset, new FName?(dynamicFName.Value), false, true, false, null);
				return;
			}
			if (qteType - ECommonQteContextType.SingleButtonLongPress > 1)
			{
				return;
			}
			this.PlayKuroForceFeedback(gamepadShakeAsset, new FName?(dynamicFName.Value), false, false, false, null);
		}

		// Token: 0x0602F50A RID: 193802 RVA: 0x00D332F0 File Offset: 0x00D314F0
		public void StopQteGamepadShake(ECommonQteContextType qteType, UKuroForceFeedbackEffect gamepadShakeAsset)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName("Qte_GamepadShake");
			if (dynamicFName == null)
			{
				return;
			}
			GamepadController.StopKuroForceFeedback(gamepadShakeAsset, dynamicFName.Value);
		}

		// Token: 0x0602F50B RID: 193803 RVA: 0x00D33320 File Offset: 0x00D31520
		public void TriggerGamepadShakeByManipulatable(UKuroForceFeedbackEffect gamepadShakeAsset)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName("Manipulatable_GamepadShake");
			if (dynamicFName == null)
			{
				return;
			}
			this.PlayKuroForceFeedback(gamepadShakeAsset, new FName?(dynamicFName.Value), false, false, false, null);
		}

		// Token: 0x0602F50C RID: 193804 RVA: 0x00D3335C File Offset: 0x00D3155C
		public void StopManipulatableGamepadShake(UKuroForceFeedbackEffect gamepadShakeAsset)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName("Manipulatable_GamepadShake");
			if (dynamicFName == null)
			{
				return;
			}
			GamepadController.StopKuroForceFeedback(gamepadShakeAsset, dynamicFName.Value);
		}

		// Token: 0x0602F50D RID: 193805 RVA: 0x00D3338C File Offset: 0x00D3158C
		[NullableContext(2)]
		public static void StopKuroForceFeedback(UKuroForceFeedbackEffect forceFeedbackEffect, FName tag)
		{
			TsCharacterController tsCharacterController = Global.PlayerController as TsCharacterController;
			if (tsCharacterController != null)
			{
				tsCharacterController.StopKuroForceFeedback(forceFeedbackEffect, tag);
			}
		}

		// Token: 0x0602F50E RID: 193806 RVA: 0x00D333B0 File Offset: 0x00D315B0
		public UniTask TriggerGamepadShakeEvent(IGamepadShakeOptions config, [Nullable(2)] IStopGamepadShake stopGamepadShakeParam = null)
		{
			GamepadController.<TriggerGamepadShakeEvent>d__32 <TriggerGamepadShakeEvent>d__;
			<TriggerGamepadShakeEvent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TriggerGamepadShakeEvent>d__.<>4__this = this;
			<TriggerGamepadShakeEvent>d__.config = config;
			<TriggerGamepadShakeEvent>d__.stopGamepadShakeParam = stopGamepadShakeParam;
			<TriggerGamepadShakeEvent>d__.<>1__state = -1;
			<TriggerGamepadShakeEvent>d__.<>t__builder.Start<GamepadController.<TriggerGamepadShakeEvent>d__32>(ref <TriggerGamepadShakeEvent>d__);
			return <TriggerGamepadShakeEvent>d__.<>t__builder.Task;
		}

		// Token: 0x0602F50F RID: 193807 RVA: 0x00D33404 File Offset: 0x00D31604
		private void TriggerMp4GamepadShake(UKuroForceFeedbackEffect asset, IMp4GamepadShake mp4Config, IStopGamepadShake stopGamepadShake)
		{
			GamepadController.<>c__DisplayClass33_0 CS$<>8__locals1 = new GamepadController.<>c__DisplayClass33_0();
			CS$<>8__locals1.<>4__this = this;
			stopGamepadShake.Tag = FNameUtil.GetDynamicFName("LevelEventTriggerGamepadShake").Value;
			CS$<>8__locals1.shakeScale = mp4Config.ShakeScale.GetValueOrDefault(1f);
			CS$<>8__locals1.assetDuration = asset.Duration;
			GamepadController.<>c__DisplayClass33_0 CS$<>8__locals2 = CS$<>8__locals1;
			IMp4GamepadShakeFadeInConfig fadeInConfig = mp4Config.FadeInConfig;
			CS$<>8__locals2.fadeInTime = ((fadeInConfig != null) ? fadeInConfig.FadeInTime : null).GetValueOrDefault();
			GamepadController.<>c__DisplayClass33_0 CS$<>8__locals3 = CS$<>8__locals1;
			IMp4GamepadShakeFadeOutConfig fadeOutConfig = mp4Config.FadeOutConfig;
			CS$<>8__locals3.fadeOutTime = ((fadeOutConfig != null) ? fadeOutConfig.FadeOutTime : null).GetValueOrDefault();
			GamepadController.<>c__DisplayClass33_0 CS$<>8__locals4 = CS$<>8__locals1;
			IMp4GamepadShakeFadeInConfig fadeInConfig2 = mp4Config.FadeInConfig;
			CS$<>8__locals4.fadeInCurve = ((fadeInConfig2 != null) ? fadeInConfig2.FadeInCurve : null).GetValueOrDefault(EMp4GamepadShakeCurve.InSine);
			GamepadController.<>c__DisplayClass33_0 CS$<>8__locals5 = CS$<>8__locals1;
			IMp4GamepadShakeFadeOutConfig fadeOutConfig2 = mp4Config.FadeOutConfig;
			CS$<>8__locals5.fadeOutCurve = ((fadeOutConfig2 != null) ? fadeOutConfig2.FadeOutCurve : null).GetValueOrDefault(EMp4GamepadShakeCurve.OutSine);
			bool flag = (CS$<>8__locals1.fadeInTime > 0f || CS$<>8__locals1.fadeOutTime > 0f) && CS$<>8__locals1.assetDuration > 0f;
			stopGamepadShake.FeedbackComponent = UGameplayStatics.D_SpawnForceFeedbackAtLocation(GlobalData.World, asset, global::Vector.ZeroVectorDouble, Rotator.ZeroRotator, false, (flag && CS$<>8__locals1.fadeInTime > 0f) ? 0f : CS$<>8__locals1.shakeScale, 0f, null, true);
			UForceFeedbackComponent feedbackComponent = stopGamepadShake.FeedbackComponent;
			if (feedbackComponent == null || !feedbackComponent.IsValid())
			{
				global::Log.Instance.Error(ELogModule.LevelEvent, ELogAuthor.YSQ, "执行行为LevelEventTriggerGamepadShake失败，MP4手柄震动创建FeedbackComponent失败", default(ReadOnlySpan<ValueTuple<string, object>>));
				return;
			}
			if (!flag)
			{
				return;
			}
			CS$<>8__locals1.component = stopGamepadShake.FeedbackComponent;
			CS$<>8__locals1.startMs = TimerSystem.Instance.Now;
			TimerSystem.Instance.Delay(new TTimerAction(CS$<>8__locals1.<TriggerMp4GamepadShake>g__tick|0), 50f, null, null, true, 1f);
		}

		// Token: 0x0602F510 RID: 193808 RVA: 0x00D335E8 File Offset: 0x00D317E8
		private float GetMp4FadeEasedValue(EMp4GamepadShakeCurve curve, float t)
		{
			float num = Math.Clamp(t, 0f, 1f);
			switch (curve)
			{
			case EMp4GamepadShakeCurve.InSine:
				return 1f - MathF.Cos(num * 3.1415927f / 2f);
			case EMp4GamepadShakeCurve.OutSine:
				return MathF.Sin(num * 3.1415927f / 2f);
			}
			return num;
		}

		// Token: 0x0602F511 RID: 193809 RVA: 0x00D33648 File Offset: 0x00D31848
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UKuroForceFeedbackEffect> LoadGamepadShakeAsset(string path)
		{
			GamepadController.<LoadGamepadShakeAsset>d__35 <LoadGamepadShakeAsset>d__;
			<LoadGamepadShakeAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<UKuroForceFeedbackEffect>.Create();
			<LoadGamepadShakeAsset>d__.path = path;
			<LoadGamepadShakeAsset>d__.<>1__state = -1;
			<LoadGamepadShakeAsset>d__.<>t__builder.Start<GamepadController.<LoadGamepadShakeAsset>d__35>(ref <LoadGamepadShakeAsset>d__);
			return <LoadGamepadShakeAsset>d__.<>t__builder.Task;
		}

		// Token: 0x0602F512 RID: 193810 RVA: 0x00D3368C File Offset: 0x00D3188C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<UForceFeedbackAttenuation> LoadFeedbackAttenuationAsset(string path)
		{
			GamepadController.<LoadFeedbackAttenuationAsset>d__36 <LoadFeedbackAttenuationAsset>d__;
			<LoadFeedbackAttenuationAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<UForceFeedbackAttenuation>.Create();
			<LoadFeedbackAttenuationAsset>d__.path = path;
			<LoadFeedbackAttenuationAsset>d__.<>1__state = -1;
			<LoadFeedbackAttenuationAsset>d__.<>t__builder.Start<GamepadController.<LoadFeedbackAttenuationAsset>d__36>(ref <LoadFeedbackAttenuationAsset>d__);
			return <LoadFeedbackAttenuationAsset>d__.<>t__builder.Task;
		}

		// Token: 0x17005F72 RID: 24434
		// (get) Token: 0x0602F513 RID: 193811 RVA: 0x00D336CF File Offset: 0x00D318CF
		public static GamepadController Instance
		{
			get
			{
				return GamepadController._Instance;
			}
		}

		// Token: 0x0602F514 RID: 193812 RVA: 0x00D336D6 File Offset: 0x00D318D6
		public static GamepadController GetOrCreateInstance()
		{
			if (GamepadController._Instance == null)
			{
				GamepadController.CreateInstance();
			}
			return GamepadController._Instance;
		}

		// Token: 0x0602F515 RID: 193813 RVA: 0x00D336EA File Offset: 0x00D318EA
		public static bool CreateInstance()
		{
			if (GamepadController._Instance != null)
			{
				return true;
			}
			GamepadController._Instance = new GamepadController();
			return true;
		}

		// Token: 0x0602F516 RID: 193814 RVA: 0x00D33700 File Offset: 0x00D31900
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0602F517 RID: 193815 RVA: 0x00D33702 File Offset: 0x00D31902
		public static void ResetStaticDefaultValue()
		{
			GamepadController._Instance = null;
		}

		// Token: 0x0602F518 RID: 193816 RVA: 0x00D3370A File Offset: 0x00D3190A
		static GamepadController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GamepadController.CreateStaticDefaultValue), new Action(GamepadController.ResetStaticDefaultValue));
		}

		// Token: 0x04019168 RID: 102760
		private const string QTE_GAMEPAD_SHAKE = "Qte_GamepadShake";

		// Token: 0x04019169 RID: 102761
		private const string MANIPULATABLE_GAMEPAD_SHAKE = "Manipulatable_GamepadShake";

		// Token: 0x0401916A RID: 102762
		private const string LEVELEVENT_GAMEPAD_SHAKE = "LevelEventTriggerGamepadShake";

		// Token: 0x0401916B RID: 102763
		private const float MP4_GAMEPAD_SHAKE_TICK_MS = 50f;

		// Token: 0x0401916C RID: 102764
		private List<string> HitForceFeedbackPaths = new List<string>();

		// Token: 0x0401916D RID: 102765
		private List<UKuroForceFeedbackEffect> HitForceFeedbackEffects = new List<UKuroForceFeedbackEffect>();

		// Token: 0x0401916E RID: 102766
		private GamepadPsFeedbackData GamepadPsFeedbackData = new GamepadPsFeedbackData();

		// Token: 0x0401916F RID: 102767
		private GamepadPsFeedbackModule GamepadPsFeedbackLoadModule = new GamepadPsFeedbackModule();

		// Token: 0x04019170 RID: 102768
		private GamepadPsFeedbackListenTagModule GamepadPsFeedbackListenTagModule = new GamepadPsFeedbackListenTagModule();

		// Token: 0x04019171 RID: 102769
		private DualSenseLightBarModule LightBarModule = new DualSenseLightBarModule();

		// Token: 0x04019172 RID: 102770
		private GamepadLightBarListenTagModule LightBarListenTagModule = new GamepadLightBarListenTagModule();

		// Token: 0x04019173 RID: 102771
		private int GamepadActorIndex;

		// Token: 0x04019174 RID: 102772
		[Nullable(2)]
		private static GamepadController _Instance;
	}
}
