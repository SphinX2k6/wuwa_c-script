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
	// Token: 0x020059F2 RID: 23026
	[NullableContext(1)]
	[Nullable(0)]
	public class GamepadController : ControllerBase
	{
		// Token: 0x0603A5BF RID: 239039 RVA: 0x00DE2D94 File Offset: 0x00DE0F94
		protected override bool OnInit()
		{
			this.HitForceFeedbackPaths.Add(ConfigCommonParamById.GetStringConfig("FKHitForceFeedbackPath"));
			this.HitForceFeedbackPaths.Add(ConfigCommonParamById.GetStringConfig("LightHitForceFeedbackPath"));
			this.HitForceFeedbackPaths.Add(ConfigCommonParamById.GetStringConfig("HeavyHitForceFeedbackPath"));
			this.GamepadPsFeedbackListenTagModule.Init();
			return true;
		}

		// Token: 0x0603A5C0 RID: 239040 RVA: 0x00DE2DEC File Offset: 0x00DE0FEC
		protected override bool OnClear()
		{
			this.ClearFeedbackReason();
			this.GamepadPsFeedbackLoadModule.Clear();
			this.GamepadPsFeedbackListenTagModule.Clear();
			return true;
		}

		// Token: 0x0603A5C1 RID: 239041 RVA: 0x00DE2E0C File Offset: 0x00DE100C
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

		// Token: 0x0603A5C2 RID: 239042 RVA: 0x00DE2E9C File Offset: 0x00DE109C
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

		// Token: 0x0603A5C3 RID: 239043 RVA: 0x00DE2EDC File Offset: 0x00DE10DC
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

		// Token: 0x0603A5C4 RID: 239044 RVA: 0x00DE2FC0 File Offset: 0x00DE11C0
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

		// Token: 0x0603A5C5 RID: 239045 RVA: 0x00DE30B4 File Offset: 0x00DE12B4
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

		// Token: 0x0603A5C6 RID: 239046 RVA: 0x00DE30E8 File Offset: 0x00DE12E8
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

		// Token: 0x0603A5C7 RID: 239047 RVA: 0x00DE315E File Offset: 0x00DE135E
		private void AddFeedbackReason(EGamepadPsFeedbackReason reason, ETriggerEffectSide mode, string path)
		{
			this.GamepadPsFeedbackData.AddFeedbackReason(reason, mode, path);
			this.RefreshPsFeedbackMode();
		}

		// Token: 0x0603A5C8 RID: 239048 RVA: 0x00DE3174 File Offset: 0x00DE1374
		public void RemoveFeedbackReason(EGamepadPsFeedbackReason reason)
		{
			if (this.GamepadPsFeedbackData.RemoveFeedbackReason(reason))
			{
				this.RefreshPsFeedbackMode();
			}
		}

		// Token: 0x0603A5C9 RID: 239049 RVA: 0x00DE318A File Offset: 0x00DE138A
		private void ClearFeedbackReason()
		{
			this.GamepadPsFeedbackData.ClearFeedbackReason();
			this.RefreshPsFeedbackMode();
		}

		// Token: 0x0603A5CA RID: 239050 RVA: 0x00DE31A0 File Offset: 0x00DE13A0
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

		// Token: 0x0603A5CB RID: 239051 RVA: 0x00DE31EC File Offset: 0x00DE13EC
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

		// Token: 0x0603A5CC RID: 239052 RVA: 0x00DE3248 File Offset: 0x00DE1448
		public void StopQteGamepadShake(ECommonQteContextType qteType, UKuroForceFeedbackEffect gamepadShakeAsset)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName("Qte_GamepadShake");
			if (dynamicFName == null)
			{
				return;
			}
			GamepadController.StopKuroForceFeedback(gamepadShakeAsset, dynamicFName.Value);
		}

		// Token: 0x0603A5CD RID: 239053 RVA: 0x00DE3278 File Offset: 0x00DE1478
		public void TriggerGamepadShakeByManipulatable(UKuroForceFeedbackEffect gamepadShakeAsset)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName("Manipulatable_GamepadShake");
			if (dynamicFName == null)
			{
				return;
			}
			this.PlayKuroForceFeedback(gamepadShakeAsset, new FName?(dynamicFName.Value), false, false, false, null);
		}

		// Token: 0x0603A5CE RID: 239054 RVA: 0x00DE32B4 File Offset: 0x00DE14B4
		public void StopManipulatableGamepadShake(UKuroForceFeedbackEffect gamepadShakeAsset)
		{
			FName? dynamicFName = FNameUtil.GetDynamicFName("Manipulatable_GamepadShake");
			if (dynamicFName == null)
			{
				return;
			}
			GamepadController.StopKuroForceFeedback(gamepadShakeAsset, dynamicFName.Value);
		}

		// Token: 0x0603A5CF RID: 239055 RVA: 0x00DE32E4 File Offset: 0x00DE14E4
		[NullableContext(2)]
		public static void StopKuroForceFeedback(UKuroForceFeedbackEffect forceFeedbackEffect, FName tag)
		{
			TsCharacterController tsCharacterController = Global.PlayerController as TsCharacterController;
			if (tsCharacterController != null)
			{
				tsCharacterController.StopKuroForceFeedback(forceFeedbackEffect, tag);
			}
		}

		// Token: 0x0603A5D0 RID: 239056 RVA: 0x00DE3308 File Offset: 0x00DE1508
		public UniTask TriggerGamepadShakeEvent(IGamepadShakeOptions config, [Nullable(2)] IStopGamepadShake stopGamepadShakeParam = null)
		{
			GamepadController.<TriggerGamepadShakeEvent>d__27 <TriggerGamepadShakeEvent>d__;
			<TriggerGamepadShakeEvent>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
			<TriggerGamepadShakeEvent>d__.<>4__this = this;
			<TriggerGamepadShakeEvent>d__.config = config;
			<TriggerGamepadShakeEvent>d__.stopGamepadShakeParam = stopGamepadShakeParam;
			<TriggerGamepadShakeEvent>d__.<>1__state = -1;
			<TriggerGamepadShakeEvent>d__.<>t__builder.Start<GamepadController.<TriggerGamepadShakeEvent>d__27>(ref <TriggerGamepadShakeEvent>d__);
			return <TriggerGamepadShakeEvent>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5D1 RID: 239057 RVA: 0x00DE335C File Offset: 0x00DE155C
		private void TriggerMp4GamepadShake(UKuroForceFeedbackEffect asset, IMp4GamepadShake mp4Config, IStopGamepadShake stopGamepadShake)
		{
			GamepadController.<>c__DisplayClass28_0 CS$<>8__locals1 = new GamepadController.<>c__DisplayClass28_0();
			CS$<>8__locals1.<>4__this = this;
			stopGamepadShake.Tag = FNameUtil.GetDynamicFName("LevelEventTriggerGamepadShake").Value;
			CS$<>8__locals1.shakeScale = mp4Config.ShakeScale.GetValueOrDefault(1f);
			CS$<>8__locals1.assetDuration = asset.Duration;
			GamepadController.<>c__DisplayClass28_0 CS$<>8__locals2 = CS$<>8__locals1;
			IMp4GamepadShakeFadeInConfig fadeInConfig = mp4Config.FadeInConfig;
			CS$<>8__locals2.fadeInTime = ((fadeInConfig != null) ? fadeInConfig.FadeInTime : null).GetValueOrDefault();
			GamepadController.<>c__DisplayClass28_0 CS$<>8__locals3 = CS$<>8__locals1;
			IMp4GamepadShakeFadeOutConfig fadeOutConfig = mp4Config.FadeOutConfig;
			CS$<>8__locals3.fadeOutTime = ((fadeOutConfig != null) ? fadeOutConfig.FadeOutTime : null).GetValueOrDefault();
			GamepadController.<>c__DisplayClass28_0 CS$<>8__locals4 = CS$<>8__locals1;
			IMp4GamepadShakeFadeInConfig fadeInConfig2 = mp4Config.FadeInConfig;
			CS$<>8__locals4.fadeInCurve = ((fadeInConfig2 != null) ? fadeInConfig2.FadeInCurve : null).GetValueOrDefault(EMp4GamepadShakeCurve.InSine);
			GamepadController.<>c__DisplayClass28_0 CS$<>8__locals5 = CS$<>8__locals1;
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

		// Token: 0x0603A5D2 RID: 239058 RVA: 0x00DE3540 File Offset: 0x00DE1740
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

		// Token: 0x0603A5D3 RID: 239059 RVA: 0x00DE35A0 File Offset: 0x00DE17A0
		[return: Nullable(new byte[]
		{
			0,
			2
		})]
		public UniTask<UKuroForceFeedbackEffect> LoadGamepadShakeAsset(string path)
		{
			GamepadController.<LoadGamepadShakeAsset>d__30 <LoadGamepadShakeAsset>d__;
			<LoadGamepadShakeAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<UKuroForceFeedbackEffect>.Create();
			<LoadGamepadShakeAsset>d__.path = path;
			<LoadGamepadShakeAsset>d__.<>1__state = -1;
			<LoadGamepadShakeAsset>d__.<>t__builder.Start<GamepadController.<LoadGamepadShakeAsset>d__30>(ref <LoadGamepadShakeAsset>d__);
			return <LoadGamepadShakeAsset>d__.<>t__builder.Task;
		}

		// Token: 0x0603A5D4 RID: 239060 RVA: 0x00DE35E4 File Offset: 0x00DE17E4
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		private UniTask<UForceFeedbackAttenuation> LoadFeedbackAttenuationAsset(string path)
		{
			GamepadController.<LoadFeedbackAttenuationAsset>d__31 <LoadFeedbackAttenuationAsset>d__;
			<LoadFeedbackAttenuationAsset>d__.<>t__builder = AsyncUniTaskMethodBuilder<UForceFeedbackAttenuation>.Create();
			<LoadFeedbackAttenuationAsset>d__.path = path;
			<LoadFeedbackAttenuationAsset>d__.<>1__state = -1;
			<LoadFeedbackAttenuationAsset>d__.<>t__builder.Start<GamepadController.<LoadFeedbackAttenuationAsset>d__31>(ref <LoadFeedbackAttenuationAsset>d__);
			return <LoadFeedbackAttenuationAsset>d__.<>t__builder.Task;
		}

		// Token: 0x17008BA4 RID: 35748
		// (get) Token: 0x0603A5D5 RID: 239061 RVA: 0x00DE3627 File Offset: 0x00DE1827
		public static GamepadController Instance
		{
			get
			{
				return GamepadController._Instance;
			}
		}

		// Token: 0x0603A5D6 RID: 239062 RVA: 0x00DE362E File Offset: 0x00DE182E
		public static GamepadController GetOrCreateInstance()
		{
			if (GamepadController._Instance == null)
			{
				GamepadController.CreateInstance();
			}
			return GamepadController._Instance;
		}

		// Token: 0x0603A5D7 RID: 239063 RVA: 0x00DE3642 File Offset: 0x00DE1842
		public static bool CreateInstance()
		{
			if (GamepadController._Instance != null)
			{
				return true;
			}
			GamepadController._Instance = new GamepadController();
			return true;
		}

		// Token: 0x0603A5D8 RID: 239064 RVA: 0x00DE3658 File Offset: 0x00DE1858
		public static void CreateStaticDefaultValue()
		{
		}

		// Token: 0x0603A5D9 RID: 239065 RVA: 0x00DE365A File Offset: 0x00DE185A
		public static void ResetStaticDefaultValue()
		{
			GamepadController._Instance = null;
		}

		// Token: 0x0603A5DA RID: 239066 RVA: 0x00DE3662 File Offset: 0x00DE1862
		static GamepadController()
		{
			StaticVariableRegister.RegisterAndExecute(new Action(GamepadController.CreateStaticDefaultValue), new Action(GamepadController.ResetStaticDefaultValue));
		}

		// Token: 0x0401E6C6 RID: 124614
		private const string QTE_GAMEPAD_SHAKE = "Qte_GamepadShake";

		// Token: 0x0401E6C7 RID: 124615
		private const string MANIPULATABLE_GAMEPAD_SHAKE = "Manipulatable_GamepadShake";

		// Token: 0x0401E6C8 RID: 124616
		private const string LEVELEVENT_GAMEPAD_SHAKE = "LevelEventTriggerGamepadShake";

		// Token: 0x0401E6C9 RID: 124617
		private const float MP4_GAMEPAD_SHAKE_TICK_MS = 50f;

		// Token: 0x0401E6CA RID: 124618
		private List<string> HitForceFeedbackPaths = new List<string>();

		// Token: 0x0401E6CB RID: 124619
		private List<UKuroForceFeedbackEffect> HitForceFeedbackEffects = new List<UKuroForceFeedbackEffect>();

		// Token: 0x0401E6CC RID: 124620
		private GamepadPsFeedbackData GamepadPsFeedbackData = new GamepadPsFeedbackData();

		// Token: 0x0401E6CD RID: 124621
		private GamepadPsFeedbackModule GamepadPsFeedbackLoadModule = new GamepadPsFeedbackModule();

		// Token: 0x0401E6CE RID: 124622
		private GamepadPsFeedbackListenTagModule GamepadPsFeedbackListenTagModule = new GamepadPsFeedbackListenTagModule();

		// Token: 0x0401E6CF RID: 124623
		private int GamepadActorIndex;

		// Token: 0x0401E6D0 RID: 124624
		[Nullable(2)]
		private static GamepadController _Instance;
	}
}
