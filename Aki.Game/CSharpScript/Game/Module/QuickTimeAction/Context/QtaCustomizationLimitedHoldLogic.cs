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
	// Token: 0x02003F0C RID: 16140
	[NullableContext(1)]
	[Nullable(0)]
	public class QtaCustomizationLimitedHoldLogic : QtaCustomizationBaseLogic
	{
		// Token: 0x06028EE3 RID: 167651 RVA: 0x00B7CDB8 File Offset: 0x00B7AFB8
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

		// Token: 0x06028EE4 RID: 167652 RVA: 0x00B7D00C File Offset: 0x00B7B20C
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

		// Token: 0x06028EE5 RID: 167653 RVA: 0x00B7D060 File Offset: 0x00B7B260
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

		// Token: 0x06028EE6 RID: 167654 RVA: 0x00B7D157 File Offset: 0x00B7B357
		private void RemoveEvents()
		{
			if (EventSystem.Instance.Has(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent)))
			{
				EventSystem.Instance.Remove(EEventName.CheckClientEvent, new Action<FGameplayTag>(this.OnCheckClientEvent));
			}
		}

		// Token: 0x06028EE7 RID: 167655 RVA: 0x00B7D194 File Offset: 0x00B7B394
		private void OnCheckClientEvent(FGameplayTag tag)
		{
			List<float> list;
			if (this.EventParamMap.TryGetValue(tag.TagId(), out list))
			{
				this.SetSpeed(list[0], list[1]);
			}
		}

		// Token: 0x06028EE8 RID: 167656 RVA: 0x00B7D1CA File Offset: 0x00B7B3CA
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public override List<string> OnGetActions()
		{
			return this.Actions;
		}

		// Token: 0x06028EE9 RID: 167657 RVA: 0x00B7D1D4 File Offset: 0x00B7B3D4
		private void SetSpeed(float frontSpeed, float bgSpeed)
		{
			this.MainProgress.SetSpeed(frontSpeed);
			foreach (QtaCzBgBar qtaCzBgBar in this.BgBarList)
			{
				qtaCzBgBar.CzProgress.SetSpeed(bgSpeed);
			}
		}

		// Token: 0x06028EEA RID: 167658 RVA: 0x00B7D238 File Offset: 0x00B7B438
		public override void OnQtaResponse(bool press = true)
		{
			if (press)
			{
				this.OnResponseStart();
				return;
			}
			this.OnResponseEnd();
		}

		// Token: 0x06028EEB RID: 167659 RVA: 0x00B7D24C File Offset: 0x00B7B44C
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

		// Token: 0x06028EEC RID: 167660 RVA: 0x00B7D2CB File Offset: 0x00B7B4CB
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

		// Token: 0x06028EED RID: 167661 RVA: 0x00B7D308 File Offset: 0x00B7B508
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

		// Token: 0x06028EEE RID: 167662 RVA: 0x00B7D41C File Offset: 0x00B7B61C
		public override float GetProgress()
		{
			return this.MainProgress.Progress;
		}

		// Token: 0x06028EEF RID: 167663 RVA: 0x00B7D429 File Offset: 0x00B7B629
		public override float GetBgProgress(int index = 0)
		{
			if (index >= 0 && index < this.BgBarList.Count)
			{
				return this.BgBarList[index].CzProgress.Progress;
			}
			return 0f;
		}

		// Token: 0x06028EF0 RID: 167664 RVA: 0x00B7D45C File Offset: 0x00B7B65C
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

		// Token: 0x06028EF1 RID: 167665 RVA: 0x00B7D4CC File Offset: 0x00B7B6CC
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

		// Token: 0x06028EF2 RID: 167666 RVA: 0x00B7D56C File Offset: 0x00B7B76C
		public bool IsWithinRange()
		{
			return this.CheckIsValid();
		}

		// Token: 0x06028EF3 RID: 167667 RVA: 0x00B7D574 File Offset: 0x00B7B774
		protected override bool CheckIsValid()
		{
			float mainPct = 1f - this.GetProgress();
			float bgProgress = this.GetBgProgress(0);
			return this.BgAnchor.CheckIsValid(mainPct, bgProgress);
		}

		// Token: 0x06028EF4 RID: 167668 RVA: 0x00B7D5A3 File Offset: 0x00B7B7A3
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

		// Token: 0x06028EF5 RID: 167669 RVA: 0x00B7D5D8 File Offset: 0x00B7B7D8
		private bool CheckCanEndInner()
		{
			return this.TimesRelease >= this.TimesLimit || (this.IsPressing && this.TimeoutOnPressCheck > 0f && this.PassTimeWithDilation > this.TimeoutOnPressCheck) || (!this.IsPressing && this.TimeoutOnIdleCheck > 0f && this.PassTimeWithDilation > this.TimeoutOnIdleCheck) || this.MainProgress.IsFinish;
		}

		// Token: 0x06028EF6 RID: 167670 RVA: 0x00B7D648 File Offset: 0x00B7B848
		public override void OnQtaEnd(bool success = false)
		{
			this.RemoveEvents();
			QtaLog.Info(this.QtaContext, "OnQtaEnd:定制型-限次长按型", default(ReadOnlySpan<ValueTuple<string, object>>));
		}

		// Token: 0x040163F8 RID: 91128
		[Nullable(2)]
		private SQtaCustomization_LimitedHold SubConfig;

		// Token: 0x040163F9 RID: 91129
		private readonly QtaCzProgress MainProgress = new QtaCzProgress();

		// Token: 0x040163FA RID: 91130
		private readonly List<QtaCzBgBar> BgBarList = new List<QtaCzBgBar>();

		// Token: 0x040163FB RID: 91131
		private int TimesRelease;

		// Token: 0x040163FC RID: 91132
		private int TimesLimit;

		// Token: 0x040163FD RID: 91133
		private float TimeoutOnPressCheck;

		// Token: 0x040163FE RID: 91134
		private float TimeoutOnIdleCheck;

		// Token: 0x040163FF RID: 91135
		private float PassTimeWithDilation;

		// Token: 0x04016400 RID: 91136
		private readonly QtaCzBgAnchor BgAnchor = new QtaCzBgAnchor();

		// Token: 0x04016401 RID: 91137
		private readonly List<string> Actions = new List<string>();

		// Token: 0x04016402 RID: 91138
		private bool IsPressing;

		// Token: 0x04016403 RID: 91139
		private readonly Dictionary<int, List<float>> EventParamMap = new Dictionary<int, List<float>>();

		// Token: 0x04016404 RID: 91140
		private bool IsEnterFxPlayed;

		// Token: 0x04016405 RID: 91141
		private bool IsValidState;
	}
}
