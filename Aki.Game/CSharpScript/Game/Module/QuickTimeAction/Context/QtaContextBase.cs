using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Data.QuickTimeAction;
using AkiClient.Game.Aki.Data.QuickTimeAction.Customization;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Module.QuickTimeAction.Condition;
using CSharpScript.Game.Ui;
using UnrealEngine;

namespace CSharpScript.Game.Module.QuickTimeAction.Context
{
	// Token: 0x02003F13 RID: 16147
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaContextBase : IQtaContext, IUiProhibitRefreshData
	{
		// Token: 0x170052FA RID: 21242
		// (get) Token: 0x06028F18 RID: 167704 RVA: 0x00B7DFD9 File Offset: 0x00B7C1D9
		// (set) Token: 0x06028F19 RID: 167705 RVA: 0x00B7DFE1 File Offset: 0x00B7C1E1
		public int HandleId { get; set; } = -1;

		// Token: 0x170052FB RID: 21243
		// (get) Token: 0x06028F1A RID: 167706 RVA: 0x00B7DFEA File Offset: 0x00B7C1EA
		// (set) Token: 0x06028F1B RID: 167707 RVA: 0x00B7DFF2 File Offset: 0x00B7C1F2
		public int QtaId { get; set; }

		// Token: 0x170052FC RID: 21244
		// (get) Token: 0x06028F1C RID: 167708 RVA: 0x00B7DFFB File Offset: 0x00B7C1FB
		public EQtaState State
		{
			get
			{
				return this.StateInner;
			}
		}

		// Token: 0x170052FD RID: 21245
		// (get) Token: 0x06028F1D RID: 167709 RVA: 0x00B7E003 File Offset: 0x00B7C203
		public EQtaResult ResultType
		{
			get
			{
				if (!this.IsEnd())
				{
					return EQtaResult.None;
				}
				return this.ResultTypeInner;
			}
		}

		// Token: 0x170052FE RID: 21246
		// (get) Token: 0x06028F1E RID: 167710 RVA: 0x00B7E015 File Offset: 0x00B7C215
		public EQtaResult PendingResultType
		{
			get
			{
				return this.ResultTypeInner;
			}
		}

		// Token: 0x06028F1F RID: 167711 RVA: 0x00B7E01D File Offset: 0x00B7C21D
		public bool IsInvalid()
		{
			return this.StateInner == EQtaState.Invalid;
		}

		// Token: 0x06028F20 RID: 167712 RVA: 0x00B7E028 File Offset: 0x00B7C228
		public bool IsPending()
		{
			return this.StateInner == EQtaState.Pending;
		}

		// Token: 0x06028F21 RID: 167713 RVA: 0x00B7E033 File Offset: 0x00B7C233
		public bool IsPendingSuccess()
		{
			return this.StateInner == EQtaState.PendingSuccess;
		}

		// Token: 0x06028F22 RID: 167714 RVA: 0x00B7E03E File Offset: 0x00B7C23E
		public bool IsEnd()
		{
			return this.StateInner == EQtaState.Ended;
		}

		// Token: 0x06028F23 RID: 167715 RVA: 0x00B7E049 File Offset: 0x00B7C249
		public bool HasResult()
		{
			return this.ResultTypeInner > EQtaResult.None;
		}

		// Token: 0x06028F24 RID: 167716 RVA: 0x00B7E054 File Offset: 0x00B7C254
		public bool IsSuccess()
		{
			return this.IsEnd() && this.ResultTypeInner == EQtaResult.Success;
		}

		// Token: 0x06028F25 RID: 167717 RVA: 0x00B7E069 File Offset: 0x00B7C269
		public bool IsFail()
		{
			return this.IsEnd() && this.ResultTypeInner != EQtaResult.Success;
		}

		// Token: 0x06028F26 RID: 167718 RVA: 0x00B7E084 File Offset: 0x00B7C284
		public bool IsActive()
		{
			int qtaHandleId = QtaModel.Instance.GetQtaHandleId();
			return this.HandleId == qtaHandleId;
		}

		// Token: 0x06028F27 RID: 167719 RVA: 0x00B7E0A8 File Offset: 0x00B7C2A8
		[NullableContext(1)]
		public void SetConfig(SQta config)
		{
			this.Config = config;
			this.QtaPriority = config.Priority;
			if (config.BaseConfig.Duration < 0f)
			{
				this.IsPermanent = true;
			}
			else
			{
				this.Duration = config.BaseConfig.Duration * (float)TimeUtil.Instance.InverseMillisecond;
			}
			this.LeastDuration = config.BaseConfig.LeastDuration * (float)TimeUtil.Instance.InverseMillisecond;
			if (config.DeactiveCondition.Contents.Num() > 0)
			{
				this.LazyCondition = new LazyConditionQta(new TLazyConditionResultCallback(this.OnConditionResultCallback));
				LazyConditionBase lazyCondition = this.LazyCondition;
				IQtaExtraParams extraParams = this.ExtraParams;
				Entity paramWithEntity;
				if (extraParams == null)
				{
					paramWithEntity = null;
				}
				else
				{
					EntityHandle entityHandle = extraParams.EntityHandle;
					paramWithEntity = ((entityHandle != null) ? entityHandle.Entity : null);
				}
				lazyCondition.SetParamWithEntity(paramWithEntity);
				this.LazyCondition.SetQtaCondition(config.DeactiveCondition, config, 1, false);
			}
			this.ApplyTagsToEntity(true);
			this.SetUiProhibitRefresh(true);
			InputDistributeController.Instance.RefreshInputTag();
			this.OnSetConfig(config);
			this.NeedStopWhenFightInputBlocked = config.StopWhenFightInputBlocked;
			if (this.NeedStopWhenFightInputBlocked)
			{
				EventSystem.Instance.Add<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			}
		}

		// Token: 0x06028F28 RID: 167720 RVA: 0x00B7E1D3 File Offset: 0x00B7C3D3
		private void OnConditionResultCallback(bool met, int payloadId)
		{
			if (this.IsEnd())
			{
				return;
			}
			if (met && payloadId == 1)
			{
				this.SetQtaResult(EQtaResult.DeactiveConditionMet);
			}
		}

		// Token: 0x06028F29 RID: 167721 RVA: 0x00B7E1EC File Offset: 0x00B7C3EC
		private void ApplyTagsToEntity(bool add)
		{
			IQtaExtraParams extraParams = this.ExtraParams;
			BaseTagComponent baseTagComponent;
			if (extraParams == null)
			{
				baseTagComponent = null;
			}
			else
			{
				EntityHandle entityHandle = extraParams.EntityHandle;
				if (entityHandle == null)
				{
					baseTagComponent = null;
				}
				else
				{
					WorldEntity entity = entityHandle.Entity;
					baseTagComponent = ((entity != null) ? entity.GetComponent<BaseTagComponent>() : null);
				}
			}
			BaseTagComponent baseTagComponent2 = baseTagComponent;
			if (baseTagComponent2 == null)
			{
				return;
			}
			if (this.AppliedTagIds.Count > 0)
			{
				for (int i = this.AppliedTagIds.Count - 1; i >= 0; i--)
				{
					baseTagComponent2.RemoveTag(new int?(this.AppliedTagIds[i]));
				}
				this.AppliedTagIds.Clear();
			}
			if (add)
			{
				if (this.Config == null)
				{
					return;
				}
				TArray<FGameplayTag> gameplayTags = this.Config.BaseConfig.ActiveTags.GameplayTags;
				if (gameplayTags.Num() > 0)
				{
					for (int j = 0; j < gameplayTags.Num(); j++)
					{
						FGameplayTag tag = gameplayTags.Get(j);
						this.AppliedTagIds.Add(tag.TagId());
						baseTagComponent2.AddTag(new int?(tag.TagId()));
					}
				}
			}
		}

		// Token: 0x06028F2A RID: 167722 RVA: 0x00B7E2E0 File Offset: 0x00B7C4E0
		[NullableContext(1)]
		protected virtual void OnSetConfig(SQta config)
		{
		}

		// Token: 0x06028F2B RID: 167723 RVA: 0x00B7E2E2 File Offset: 0x00B7C4E2
		public virtual void OnResourceReady()
		{
		}

		// Token: 0x06028F2C RID: 167724 RVA: 0x00B7E2E4 File Offset: 0x00B7C4E4
		public virtual void OnQtaReady()
		{
			LazyConditionQta lazyCondition = this.LazyCondition;
			if (lazyCondition != null)
			{
				lazyCondition.ForceCheckOnce();
			}
			if (!this.IsEnd() && this.NeedStopWhenFightInputBlocked && this.HasOtherNotAllowFightInputView())
			{
				this.SetQtaFailWhenFightInputBlocked();
			}
		}

		// Token: 0x06028F2D RID: 167725 RVA: 0x00B7E315 File Offset: 0x00B7C515
		public SQta GetConfig()
		{
			return this.Config;
		}

		// Token: 0x06028F2E RID: 167726 RVA: 0x00B7E320 File Offset: 0x00B7C520
		public bool IsNoUi()
		{
			SQta config = this.Config;
			SQtaBase sqtaBase = (config != null) ? config.BaseConfig : null;
			return sqtaBase != null && sqtaBase.QtaType == EQtaType.定制型 && sqtaBase.CustomizationConfig.ViewType == EQtaCustomizationViewType.无界面;
		}

		// Token: 0x06028F2F RID: 167727 RVA: 0x00B7E378 File Offset: 0x00B7C578
		public bool IsQtaView()
		{
			SQta config = this.Config;
			SQtaBase sqtaBase = (config != null) ? config.BaseConfig : null;
			return sqtaBase != null && sqtaBase.QtaType == EQtaType.定制型 && (sqtaBase.CustomizationConfig.ViewType == EQtaCustomizationViewType.拍照并收集物品 || sqtaBase.CustomizationConfig.ViewType == EQtaCustomizationViewType.打开指定界面);
		}

		// Token: 0x06028F30 RID: 167728 RVA: 0x00B7E3E7 File Offset: 0x00B7C5E7
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> GetActions()
		{
			return this.OnGetActions();
		}

		// Token: 0x06028F31 RID: 167729 RVA: 0x00B7E3EF File Offset: 0x00B7C5EF
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		protected virtual List<string> OnGetActions()
		{
			return null;
		}

		// Token: 0x06028F32 RID: 167730 RVA: 0x00B7E3F2 File Offset: 0x00B7C5F2
		public IQtaPromptResource GetPromptResource(EQtaPromptType promptType)
		{
			return QtaModel.Instance.GetQtaPromptResource(this.QtaId, promptType, false);
		}

		// Token: 0x06028F33 RID: 167731 RVA: 0x00B7E408 File Offset: 0x00B7C608
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public TArray<SBattleQteAction> GetResultActions(EQtaResult resultType)
		{
			if (this.Config == null)
			{
				return null;
			}
			for (int i = 0; i < this.Config.ResultAction.Num(); i++)
			{
				SQtaResultAction sqtaResultAction = this.Config.ResultAction.Get(i);
				if ((EQtaResult)sqtaResultAction.ResultType == resultType)
				{
					return sqtaResultAction.Actions;
				}
			}
			return null;
		}

		// Token: 0x06028F34 RID: 167732 RVA: 0x00B7E468 File Offset: 0x00B7C668
		public virtual void UpdateTime(float delta)
		{
			if (this.StateInner == EQtaState.PendingSuccess)
			{
				if (this.PassTime > this.LeastDuration)
				{
					this.SetQtaResult(EQtaResult.Success);
				}
				return;
			}
			this.OnUpdateTime(delta);
		}

		// Token: 0x06028F35 RID: 167733 RVA: 0x00B7E490 File Offset: 0x00B7C690
		protected virtual void OnUpdateTime(float delta)
		{
		}

		// Token: 0x06028F36 RID: 167734 RVA: 0x00B7E492 File Offset: 0x00B7C692
		public void QtaResponse(bool press)
		{
			this.OnQtaResponse(press);
		}

		// Token: 0x06028F37 RID: 167735 RVA: 0x00B7E49B File Offset: 0x00B7C69B
		protected virtual void OnQtaResponse(bool press)
		{
		}

		// Token: 0x06028F38 RID: 167736 RVA: 0x00B7E4A0 File Offset: 0x00B7C6A0
		public void SetQtaResult(EQtaResult qtaResult)
		{
			if (this.IsEnd())
			{
				return;
			}
			if (this.IsStoppingByFightInputBlocked)
			{
				this.StateInner = EQtaState.Ended;
				this.ResultTypeInner = qtaResult;
			}
			else if (this.IsPendingExternalCompletion)
			{
				if (this.StateInner == EQtaState.PendingEnd)
				{
					return;
				}
				this.StateInner = EQtaState.PendingEnd;
				this.ResultTypeInner = qtaResult;
				return;
			}
			else if (qtaResult == EQtaResult.Success && this.PassTime < this.LeastDuration)
			{
				this.StateInner = EQtaState.PendingSuccess;
				this.ResultTypeInner = qtaResult;
				this.OnQtaPendingSuccess();
				return;
			}
			this.StateInner = EQtaState.Ended;
			this.ResultTypeInner = qtaResult;
			this.OnQtaResult(qtaResult);
			TQtaCallback resultCallback = this.ResultCallback;
			if (resultCallback != null)
			{
				resultCallback(this, qtaResult);
			}
			this.ResultCallback = null;
			QtaController.Instance.StopQta(this.HandleId, false);
		}

		// Token: 0x06028F39 RID: 167737 RVA: 0x00B7E556 File Offset: 0x00B7C756
		public void ForceEnd()
		{
			this.StateInner = EQtaState.Ended;
			this.ResultTypeInner = EQtaResult.Fail;
		}

		// Token: 0x06028F3A RID: 167738 RVA: 0x00B7E566 File Offset: 0x00B7C766
		protected virtual void OnQtaPendingSuccess()
		{
		}

		// Token: 0x06028F3B RID: 167739 RVA: 0x00B7E568 File Offset: 0x00B7C768
		protected virtual void OnQtaResult(EQtaResult qtaResult)
		{
		}

		// Token: 0x06028F3C RID: 167740 RVA: 0x00B7E56A File Offset: 0x00B7C76A
		protected virtual bool CheckQtaCanEnd()
		{
			return false;
		}

		// Token: 0x06028F3D RID: 167741 RVA: 0x00B7E570 File Offset: 0x00B7C770
		public void EnableExternalConditionMet(EQtaExternalReason reason)
		{
			string message = "启用等待外部条件达成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			QtaLog.Info(this, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.IsPendingExternalCompletion = true;
		}

		// Token: 0x06028F3E RID: 167742 RVA: 0x00B7E5A8 File Offset: 0x00B7C7A8
		public void OnExternalConditionMet(EQtaExternalReason reason)
		{
			string message = "外部条件已达成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			QtaLog.Info(this, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.IsPendingExternalCompletion = false;
			if (this.PendingResultType != EQtaResult.None)
			{
				this.SetQtaResult(this.PendingResultType);
			}
		}

		// Token: 0x06028F3F RID: 167743 RVA: 0x00B7E5F4 File Offset: 0x00B7C7F4
		public virtual void OnPreEndQta()
		{
		}

		// Token: 0x06028F40 RID: 167744 RVA: 0x00B7E5F6 File Offset: 0x00B7C7F6
		public float GetRemainingTime()
		{
			return Math.Max(0f, this.Duration - this.PassTime);
		}

		// Token: 0x06028F41 RID: 167745 RVA: 0x00B7E60F File Offset: 0x00B7C80F
		public float GetRemainingTimeProgress()
		{
			if (this.Duration <= 0f)
			{
				return 1f;
			}
			return this.GetRemainingTime() / this.Duration;
		}

		// Token: 0x06028F42 RID: 167746 RVA: 0x00B7E631 File Offset: 0x00B7C831
		public virtual float GetProgress()
		{
			return 0f;
		}

		// Token: 0x06028F43 RID: 167747 RVA: 0x00B7E638 File Offset: 0x00B7C838
		private void SetUiProhibitRefresh(bool reg)
		{
			SQta config = this.Config;
			if (config != null && !config.BaseConfig.EnableInputDistributeFilter)
			{
				return;
			}
			if (this.InputDistributeFilterTags.Length == 0)
			{
				List<string> list = new List<string>();
				SQtaInputDistribute inputDistributeFilterConfig = this.Config.BaseConfig.InputDistributeFilterConfig;
				if (inputDistributeFilterConfig.FightInputRoot)
				{
					list.Add("FightInputRoot");
				}
				if (inputDistributeFilterConfig.FightActionInput)
				{
					list.Add("FightInputRoot.FightInput.ActionInput");
				}
				if (inputDistributeFilterConfig.FightAxisInput)
				{
					list.Add("FightInputRoot.FightInput.AxisInput");
				}
				if (inputDistributeFilterConfig.InteractionRoot)
				{
					list.Add("InteractionRoot");
				}
				if (inputDistributeFilterConfig.UiInputRoot)
				{
					list.Add("UiInputRoot");
				}
				this.InputDistributeFilterTags = list.ToArray();
			}
			if (reg)
			{
				UiProhibitFightInputCenter.Instance.RegisterExtraRefreshData(EUiViewName.QtaView, this);
				return;
			}
			UiProhibitFightInputCenter.Instance.UnRegisterExtraRefreshData(EUiViewName.QtaView);
		}

		// Token: 0x06028F44 RID: 167748 RVA: 0x00B7E71B File Offset: 0x00B7C91B
		public bool CheckCondition()
		{
			return true;
		}

		// Token: 0x06028F45 RID: 167749 RVA: 0x00B7E71E File Offset: 0x00B7C91E
		[NullableContext(1)]
		public string[] GetDistributeTags()
		{
			return this.InputDistributeFilterTags;
		}

		// Token: 0x06028F46 RID: 167750 RVA: 0x00B7E728 File Offset: 0x00B7C928
		public void Clear()
		{
			if (EventSystem.Instance.Has<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged)))
			{
				EventSystem.Instance.Remove<IReadOnlyList<InputDistributeTag>>(EEventName.OnInputDistributeTagChanged, new Action<IReadOnlyList<InputDistributeTag>>(this.OnInputDistributeTagChanged));
			}
			this.SetUiProhibitRefresh(false);
			InputDistributeController.Instance.RefreshInputTag();
			if (this.IsPending())
			{
				this.StateInner = EQtaState.Invalid;
			}
			this.ApplyTagsToEntity(false);
			LazyConditionQta lazyCondition = this.LazyCondition;
			if (lazyCondition != null)
			{
				lazyCondition.Clear();
			}
			this.ResultCallback = null;
			this.Resource = null;
			this.UiActor = null;
			this.InputDistributeFilterTags = Array.Empty<string>();
			this.OnClear();
		}

		// Token: 0x06028F47 RID: 167751 RVA: 0x00B7E7CC File Offset: 0x00B7C9CC
		protected virtual void OnClear()
		{
		}

		// Token: 0x06028F48 RID: 167752 RVA: 0x00B7E7CE File Offset: 0x00B7C9CE
		[NullableContext(1)]
		private void OnInputDistributeTagChanged(IReadOnlyList<InputDistributeTag> inputDistributeTags)
		{
			if (this.HasOtherNotAllowFightInputView())
			{
				this.SetQtaFailWhenFightInputBlocked();
			}
		}

		// Token: 0x06028F49 RID: 167753 RVA: 0x00B7E7E0 File Offset: 0x00B7C9E0
		private bool HasOtherNotAllowFightInputView()
		{
			HashSet<EUiViewName> notAllowFightInputViewNameSet = InputDistributeModel.Instance.GetNotAllowFightInputViewNameSet();
			if (notAllowFightInputViewNameSet.Contains(EUiViewName.QtaView))
			{
				if (notAllowFightInputViewNameSet.Count > 1)
				{
					return true;
				}
			}
			else if (notAllowFightInputViewNameSet.Count > 0)
			{
				return true;
			}
			return false;
		}

		// Token: 0x06028F4A RID: 167754 RVA: 0x00B7E81C File Offset: 0x00B7CA1C
		private void SetQtaFailWhenFightInputBlocked()
		{
			if (this.IsStoppingByFightInputBlocked)
			{
				return;
			}
			this.IsStoppingByFightInputBlocked = true;
			TimerSystem.GameplayTimeInstance.Next(delegate(float _)
			{
				if (this.IsActive())
				{
					this.SetQtaResult(EQtaResult.Fail);
				}
			}, null, null);
		}

		// Token: 0x0401641E RID: 91166
		public EQtaContextType? Type;

		// Token: 0x04016421 RID: 91169
		public int QtaPriority;

		// Token: 0x04016422 RID: 91170
		public SQta Config;

		// Token: 0x04016423 RID: 91171
		protected EQtaState StateInner;

		// Token: 0x04016424 RID: 91172
		protected EQtaResult ResultTypeInner;

		// Token: 0x04016425 RID: 91173
		public IQtaExtraParams ExtraParams;

		// Token: 0x04016426 RID: 91174
		public TQtaCallback ResultCallback;

		// Token: 0x04016427 RID: 91175
		public EQtaSource? Source;

		// Token: 0x04016428 RID: 91176
		public float Duration;

		// Token: 0x04016429 RID: 91177
		public float LeastDuration;

		// Token: 0x0401642A RID: 91178
		public float PassTime;

		// Token: 0x0401642B RID: 91179
		public bool IsPermanent;

		// Token: 0x0401642C RID: 91180
		private bool IsPendingExternalCompletion;

		// Token: 0x0401642D RID: 91181
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IQtaPromptResource> Resource;

		// Token: 0x0401642E RID: 91182
		public AActor UiActor;

		// Token: 0x0401642F RID: 91183
		public EUiViewName? QtaViewName;

		// Token: 0x04016430 RID: 91184
		private bool NeedStopWhenFightInputBlocked;

		// Token: 0x04016431 RID: 91185
		private bool IsStoppingByFightInputBlocked;

		// Token: 0x04016432 RID: 91186
		private LazyConditionQta LazyCondition;

		// Token: 0x04016433 RID: 91187
		[Nullable(1)]
		private List<int> AppliedTagIds = new List<int>();

		// Token: 0x04016434 RID: 91188
		[Nullable(1)]
		private string[] InputDistributeFilterTags = Array.Empty<string>();
	}
}
