using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Input;
using CSharpScript.Game.Input.BattleInputData;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02004F43 RID: 20291
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCustomizationLimitedHoldLogic : QtaCustomizationBaseLogic
	{
		// Token: 0x06034075 RID: 213109 RVA: 0x00C33618 File Offset: 0x00C31818
		public override void OnSetConfig(QtaCustomizationContext qtaContext, SQta qtaConfig, BP_QtaCustomizationBase_C daConfig)
		{
			if (qtaConfig == null || daConfig == null)
			{
				QtaLog.Error(qtaContext, "限次长按Qta初始化：缺少配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			BP_QtaCustomization_LimitedHold_C bp_QtaCustomization_LimitedHold_C = daConfig as BP_QtaCustomization_LimitedHold_C;
			if (bp_QtaCustomization_LimitedHold_C == null)
			{
				QtaLog.Error(qtaContext, "限次长按Qta初始化：配置的DA类型不正确", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			SQtaCustomization_LimitedHold config = bp_QtaCustomization_LimitedHold_C.Config;
			if (config.ProgressList.Num() < 1)
			{
				QtaLog.Error(qtaContext, "限次长按Qta初始化：缺少副(背景)进度条配置", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			this.QtaConfig = qtaConfig;
			this.SubConfig = config;
			this.QtaContext = qtaContext;
			this.MainProgress.InitByConfig(config.MainProgress, config.MainProgressResetType);
			for (int i = 0; i < config.ProgressList.Num(); i++)
			{
				QtaCzBgBar qtaCzBgBar = new QtaCzBgBar();
				qtaCzBgBar.InitByConfig(config.ProgressList.Get(i));
				this.BgBarList.Add(qtaCzBgBar);
			}
			this.TimesLimit = config.TimesLimit;
			this.TimeoutOnPressCheck = config.TimeoutOnPress * (float)TimeUtil.Instance.InverseMillisecond;
			this.TimeoutOnIdleCheck = config.TimeoutOnIdle * (float)TimeUtil.Instance.InverseMillisecond;
			this.Actions.Clear();
			for (int j = 0; j < qtaConfig.BaseConfig.InputConfig.Num(); j++)
			{
				SCommonQteButton scommonQteButton = qtaConfig.BaseConfig.InputConfig.Get(j);
				TEnumAsByte<ECommonQteInputAction>? tenumAsByte = (scommonQteButton != null) ? new TEnumAsByte<ECommonQteInputAction>?(scommonQteButton.Action) : null;
				int index = (int)((tenumAsByte != null) ? tenumAsByte.GetValueOrDefault() : 0);
				if (QtaActionNames.Has(index))
				{
					this.Actions.Add(QtaActionNames.Get(index));
				}
			}
			foreach (string actionName in this.Actions)
			{
				InputModel instance = InputModel.Instance;
				BattleInputData battleInputData = (instance != null) ? instance.GetCurrentInputData() : null;
				if (battleInputData != null)
				{
					EInputAction? action = battleInputData.GetAction(actionName);
					if (action != null && InputController.Instance.IsKeyDown(action.Value))
					{
						this.IsPressing = true;
						break;
					}
				}
			}
		}

		// Token: 0x06034076 RID: 213110 RVA: 0x00C3386C File Offset: 0x00C31A6C
		public override void OnQtaStart()
		{
			if (this.SubConfig == null || this.QtaContext == null)
			{
				return;
			}
			QtaCustomizationLimitedHoldLogic qtaCustomizationLimitedHoldLogic = (QtaCustomizationLimitedHoldLogic)this.QtaContext.QtaCustomizationLogic;
			this.BgAnchor.InitParam(qtaCustomizationLimitedHoldLogic.GetBgValue(0), 1f);
			this.AddEvents();
		}

		// Token: 0x06034077 RID: 213111 RVA: 0x00C338C0 File Offset: 0x00C31AC0
		private void AddEvents()
		{
			SQtaCustomization_LimitedHold subConfig = this.SubConfig;
			int num = (subConfig != null) ? subConfig.SpeedTriggerList.Num() : 0;
			if (num > 0)
			{
				this.EventParamMap.Clear();
				for (int i = 0; i < num; i++)
				{
					SQtaCustomizationParam_Event sqtaCustomizationParam_Event = this.SubConfig.SpeedTriggerList.Get(i);
					if (sqtaCustomizationParam_Event.EventTag.TagId() == 0)
					{
						QtaLog.Error(this.QtaContext, "限次长按Qta初始化：事件触发配置缺少tag", default(ReadOnlySpan<ValueTuple<string, object>>));
					}
					else
					{
						this.EventParamMap[sqtaCustomizationParam_Event.EventTag.TagId()] = new List<float>
						{
							sqtaCustomizationParam_Event.Param1,
							sqtaCustomizationParam_Event.Param2
						};
					}
				}
				if (this.EventParamMap.Count > 0 && !EventSystem.Instance.Has(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent)))
				{
					EventSystem.Instance.Add(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent));
				}
			}
		}

		// Token: 0x06034078 RID: 213112 RVA: 0x00C339B7 File Offset: 0x00C31BB7
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent)))
			{
				EventSystem.Instance.Remove(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent));
			}
		}

		// Token: 0x06034079 RID: 213113 RVA: 0x00C339F4 File Offset: 0x00C31BF4
		private void OnCheckClientEvent(FGameplayTag tag)
		{
			List<float> list;
			if (this.EventParamMap.TryGetValue(tag.TagId(), out list))
			{
				this.SetSpeed(list[0], list[1]);
			}
		}

		// Token: 0x0603407A RID: 213114 RVA: 0x00C33A2A File Offset: 0x00C31C2A
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> OnGetActions()
		{
			return this.Actions;
		}

		// Token: 0x0603407B RID: 213115 RVA: 0x00C33A34 File Offset: 0x00C31C34
		private void SetSpeed(float frontSpeed, float bgSpeed)
		{
			this.MainProgress.SetSpeed(frontSpeed);
			foreach (QtaCzBgBar qtaCzBgBar in this.BgBarList)
			{
				qtaCzBgBar.CzProgress.SetSpeed(bgSpeed);
			}
		}

		// Token: 0x0603407C RID: 213116 RVA: 0x00C33A98 File Offset: 0x00C31C98
		public override void OnQtaResponse(bool press = true)
		{
			if (press)
			{
				this.OnResponseStart();
				return;
			}
			this.OnResponseEnd();
		}

		// Token: 0x0603407D RID: 213117 RVA: 0x00C33AAC File Offset: 0x00C31CAC
		private void OnResponseStart()
		{
			if (this.SubConfig == null || this.QtaConfig == null)
			{
				return;
			}
			if (this.QtaContext == null)
			{
				return;
			}
			if (!this.QtaContext.IsPending() && !this.QtaContext.IsPendingSuccess())
			{
				return;
			}
			if (this.QtaContext.IsPending())
			{
				this.IsPressing = true;
				QtaController.Instance.PlayEffect(EQtaPromptType.按下提示, this.QtaContext.HandleId);
			}
			this.CheckCanEnd();
		}

		// Token: 0x0603407E RID: 213118 RVA: 0x00C33B2B File Offset: 0x00C31D2B
		private void OnResponseEnd()
		{
			this.IsPressing = false;
			this.TimesRelease++;
			if (this.QtaContext != null)
			{
				QtaController.Instance.PlayEffect(EQtaPromptType.抬起提示, this.QtaContext.HandleId);
				this.CheckCanEnd();
			}
		}

		// Token: 0x0603407F RID: 213119 RVA: 0x00C33B68 File Offset: 0x00C31D68
		public override void OnUpdateTime(float delta)
		{
			if (this.SubConfig == null)
			{
				QtaLog.Error(this.QtaContext, "Context中获取不到Config", default(ReadOnlySpan<ValueTuple<string, object>>));
				QtaController.Instance.StopCurrentQta();
				return;
			}
			if (this.QtaContext == null)
			{
				return;
			}
			this.PassTime += delta;
			this.PassTimeWithDilation += delta * Time.Instance.TimeDilation * Time.Instance.FlowTimeDilation;
			this.MainProgress.Update(delta, this.IsPressing);
			foreach (QtaCzBgBar qtaCzBgBar in this.BgBarList)
			{
				qtaCzBgBar.CzProgress.Update(delta, false);
			}
			if (this.CheckCanEnd())
			{
				return;
			}
			this.CheckEnterValidRange();
			if (!this.QtaContext.IsPermanent && this.PassTime > this.QtaContext.Duration)
			{
				this.QtaContext.SetQtaResult(EQtaResult.Timeout);
			}
		}

		// Token: 0x06034080 RID: 213120 RVA: 0x00C33C7C File Offset: 0x00C31E7C
		public override float GetProgress()
		{
			return this.MainProgress.Progress;
		}

		// Token: 0x06034081 RID: 213121 RVA: 0x00C33C89 File Offset: 0x00C31E89
		public override float GetBgProgress(int index = 0)
		{
			if (index >= 0 && index < this.BgBarList.Count)
			{
				return this.BgBarList[index].CzProgress.Progress;
			}
			return 0f;
		}

		// Token: 0x06034082 RID: 213122 RVA: 0x00C33CBC File Offset: 0x00C31EBC
		public QtaCzBgBarValue GetBgValue(int index = 0)
		{
			QtaCzBgBarValue qtaCzBgBarValue = new QtaCzBgBarValue();
			if (index >= 0 && index < this.BgBarList.Count)
			{
				qtaCzBgBarValue.Anchor = this.BgBarList[index].Anchor;
				qtaCzBgBarValue.Angle = this.BgBarList[index].Angle;
				qtaCzBgBarValue.Progress = this.BgBarList[index].CzProgress.Progress;
			}
			return qtaCzBgBarValue;
		}

		// Token: 0x06034083 RID: 213123 RVA: 0x00C33D2C File Offset: 0x00C31F2C
		private void CheckEnterValidRange()
		{
			bool flag = this.CheckIsValid();
			if (this.IsValidState == flag)
			{
				return;
			}
			if (flag)
			{
				if (!this.IsEnterFxPlayed)
				{
					this.IsEnterFxPlayed = true;
					QtaController.Instance.PlayEffect(EQtaPromptType.进入有效范围提示, this.QtaContext.HandleId);
					QtaController.Instance.OnQtaMoment(this.QtaContext.HandleId, EQtaMomentName.EnterValidRange);
				}
			}
			else if (this.IsEnterFxPlayed)
			{
				this.IsEnterFxPlayed = false;
				QtaController.Instance.PlayEffect(EQtaPromptType.离开有效范围提示, this.QtaContext.HandleId);
				QtaController.Instance.OnQtaMoment(this.QtaContext.HandleId, EQtaMomentName.ExitValidRange);
			}
			this.IsValidState = flag;
		}

		// Token: 0x06034084 RID: 213124 RVA: 0x00C33DCC File Offset: 0x00C31FCC
		public bool IsWithinRange()
		{
			return this.CheckIsValid();
		}

		// Token: 0x06034085 RID: 213125 RVA: 0x00C33DD4 File Offset: 0x00C31FD4
		protected override bool CheckIsValid()
		{
			float mainPct = 1f - this.GetProgress();
			float bgProgress = this.GetBgProgress(0);
			return this.BgAnchor.CheckIsValid(mainPct, bgProgress);
		}

		// Token: 0x06034086 RID: 213126 RVA: 0x00C33E03 File Offset: 0x00C32003
		private bool CheckCanEnd()
		{
			if (this.QtaContext.State != EQtaState.Pending)
			{
				return true;
			}
			if (this.CheckCanEndInner())
			{
				this.QtaContext.SetQtaResult(this.CheckIsValid() ? EQtaResult.Success : EQtaResult.Fail);
				return true;
			}
			return false;
		}

		// Token: 0x06034087 RID: 213127 RVA: 0x00C33E38 File Offset: 0x00C32038
		private bool CheckCanEndInner()
		{
			return this.TimesRelease >= this.TimesLimit || (this.IsPressing && this.TimeoutOnPressCheck > 0f && this.PassTimeWithDilation > this.TimeoutOnPressCheck) || (!this.IsPressing && this.TimeoutOnIdleCheck > 0f && this.PassTimeWithDilation > this.TimeoutOnIdleCheck) || this.MainProgress.IsFinish;
		}

		// Token: 0x06034088 RID: 213128 RVA: 0x00C33EA8 File Offset: 0x00C320A8
		public override void OnQtaEnd(bool success = false)
		{
			this.RemoveEvents();
			QtaLog.Info(this.QtaContext, "OnQtaEnd:定制型-限次长按型", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x0401BA23 RID: 113187
		[Nullable(2)]
		private SQtaCustomization_LimitedHold SubConfig;

		// Token: 0x0401BA24 RID: 113188
		private readonly QtaCzProgress MainProgress = new QtaCzProgress();

		// Token: 0x0401BA25 RID: 113189
		private readonly List<QtaCzBgBar> BgBarList = new List<QtaCzBgBar>();

		// Token: 0x0401BA26 RID: 113190
		private int TimesRelease;

		// Token: 0x0401BA27 RID: 113191
		private int TimesLimit;

		// Token: 0x0401BA28 RID: 113192
		private float TimeoutOnPressCheck;

		// Token: 0x0401BA29 RID: 113193
		private float TimeoutOnIdleCheck;

		// Token: 0x0401BA2A RID: 113194
		private float PassTimeWithDilation;

		// Token: 0x0401BA2B RID: 113195
		private readonly QtaCzBgAnchor BgAnchor = new QtaCzBgAnchor();

		// Token: 0x0401BA2C RID: 113196
		private readonly List<string> Actions = new List<string>();

		// Token: 0x0401BA2D RID: 113197
		private bool IsPressing;

		// Token: 0x0401BA2E RID: 113198
		private readonly Dictionary<int, List<float>> EventParamMap = new Dictionary<int, List<float>>();

		// Token: 0x0401BA2F RID: 113199
		private bool IsEnterFxPlayed;

		// Token: 0x0401BA30 RID: 113200
		private bool IsValidState;
	}
}
