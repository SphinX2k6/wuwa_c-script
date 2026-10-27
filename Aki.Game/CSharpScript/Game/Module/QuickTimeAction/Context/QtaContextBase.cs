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
	// Token: 0x02004F4A RID: 20298
	[NullableContext(2)]
	[Nullable(0)]
	public class QtaContextBase : IQtaContext, IUiProhibitRefreshData
	{
		// Token: 0x17007F4A RID: 32586
		// (get) Token: 0x060340AA RID: 213162 RVA: 0x00C34839 File Offset: 0x00C32A39
		// (set) Token: 0x060340AB RID: 213163 RVA: 0x00C34841 File Offset: 0x00C32A41
		public int HandleId { get; set; } = -1;

		// Token: 0x17007F4B RID: 32587
		// (get) Token: 0x060340AC RID: 213164 RVA: 0x00C3484A File Offset: 0x00C32A4A
		// (set) Token: 0x060340AD RID: 213165 RVA: 0x00C34852 File Offset: 0x00C32A52
		public int QtaId { get; set; }

		// Token: 0x17007F4C RID: 32588
		// (get) Token: 0x060340AE RID: 213166 RVA: 0x00C3485B File Offset: 0x00C32A5B
		public EQtaState State
		{
			get
			{
				return this.StateInner;
			}
		}

		// Token: 0x17007F4D RID: 32589
		// (get) Token: 0x060340AF RID: 213167 RVA: 0x00C34863 File Offset: 0x00C32A63
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

		// Token: 0x17007F4E RID: 32590
		// (get) Token: 0x060340B0 RID: 213168 RVA: 0x00C34875 File Offset: 0x00C32A75
		public EQtaResult PendingResultType
		{
			get
			{
				return this.ResultTypeInner;
			}
		}

		// Token: 0x060340B1 RID: 213169 RVA: 0x00C3487D File Offset: 0x00C32A7D
		public bool IsInvalid()
		{
			return this.StateInner == EQtaState.Invalid;
		}

		// Token: 0x060340B2 RID: 213170 RVA: 0x00C34888 File Offset: 0x00C32A88
		public bool IsPending()
		{
			return this.StateInner == EQtaState.Pending;
		}

		// Token: 0x060340B3 RID: 213171 RVA: 0x00C34893 File Offset: 0x00C32A93
		public bool IsPendingSuccess()
		{
			return this.StateInner == EQtaState.PendingSuccess;
		}

		// Token: 0x060340B4 RID: 213172 RVA: 0x00C3489E File Offset: 0x00C32A9E
		public bool IsEnd()
		{
			return this.StateInner == EQtaState.Ended;
		}

		// Token: 0x060340B5 RID: 213173 RVA: 0x00C348A9 File Offset: 0x00C32AA9
		public bool HasResult()
		{
			return this.ResultTypeInner > EQtaResult.None;
		}

		// Token: 0x060340B6 RID: 213174 RVA: 0x00C348B4 File Offset: 0x00C32AB4
		public bool IsSuccess()
		{
			return this.IsEnd() && this.ResultTypeInner == EQtaResult.Success;
		}

		// Token: 0x060340B7 RID: 213175 RVA: 0x00C348C9 File Offset: 0x00C32AC9
		public bool IsFail()
		{
			return this.IsEnd() && this.ResultTypeInner != EQtaResult.Success;
		}

		// Token: 0x060340B8 RID: 213176 RVA: 0x00C348E4 File Offset: 0x00C32AE4
		public bool IsActive()
		{
			int qtaHandleId = QtaModel.Instance.GetQtaHandleId();
			return this.HandleId == qtaHandleId;
		}

		// Token: 0x060340B9 RID: 213177 RVA: 0x00C34908 File Offset: 0x00C32B08
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

		// Token: 0x060340BA RID: 213178 RVA: 0x00C34A33 File Offset: 0x00C32C33
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

		// Token: 0x060340BB RID: 213179 RVA: 0x00C34A4C File Offset: 0x00C32C4C
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

		// Token: 0x060340BC RID: 213180 RVA: 0x00C34B40 File Offset: 0x00C32D40
		[NullableContext(1)]
		protected virtual void OnSetConfig(SQta config)
		{
		}

		// Token: 0x060340BD RID: 213181 RVA: 0x00C34B42 File Offset: 0x00C32D42
		public virtual void OnResourceReady()
		{
		}

		// Token: 0x060340BE RID: 213182 RVA: 0x00C34B44 File Offset: 0x00C32D44
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

		// Token: 0x060340BF RID: 213183 RVA: 0x00C34B75 File Offset: 0x00C32D75
		public SQta GetConfig()
		{
			return this.Config;
		}

		// Token: 0x060340C0 RID: 213184 RVA: 0x00C34B80 File Offset: 0x00C32D80
		public bool IsNoUi()
		{
			SQta config = this.Config;
			SQtaBase sqtaBase = (config != null) ? config.BaseConfig : null;
			return sqtaBase != null && sqtaBase.QtaType == EQtaType.定制型 && sqtaBase.CustomizationConfig.ViewType == EQtaCustomizationViewType.无界面;
		}

		// Token: 0x060340C1 RID: 213185 RVA: 0x00C34BD8 File Offset: 0x00C32DD8
		public bool IsQtaView()
		{
			SQta config = this.Config;
			SQtaBase sqtaBase = (config != null) ? config.BaseConfig : null;
			return sqtaBase != null && sqtaBase.QtaType == EQtaType.定制型 && (sqtaBase.CustomizationConfig.ViewType == EQtaCustomizationViewType.拍照并收集物品 || sqtaBase.CustomizationConfig.ViewType == EQtaCustomizationViewType.打开指定界面);
		}

		// Token: 0x060340C2 RID: 213186 RVA: 0x00C34C47 File Offset: 0x00C32E47
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public List<string> GetActions()
		{
			return this.OnGetActions();
		}

		// Token: 0x060340C3 RID: 213187 RVA: 0x00C34C4F File Offset: 0x00C32E4F
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		protected virtual List<string> OnGetActions()
		{
			return null;
		}

		// Token: 0x060340C4 RID: 213188 RVA: 0x00C34C52 File Offset: 0x00C32E52
		public IQtaPromptResource GetPromptResource(EQtaPromptType promptType)
		{
			return QtaModel.Instance.GetQtaPromptResource(this.QtaId, promptType, false);
		}

		// Token: 0x060340C5 RID: 213189 RVA: 0x00C34C68 File Offset: 0x00C32E68
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

		// Token: 0x060340C6 RID: 213190 RVA: 0x00C34CC8 File Offset: 0x00C32EC8
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

		// Token: 0x060340C7 RID: 213191 RVA: 0x00C34CF0 File Offset: 0x00C32EF0
		protected virtual void OnUpdateTime(float delta)
		{
		}

		// Token: 0x060340C8 RID: 213192 RVA: 0x00C34CF2 File Offset: 0x00C32EF2
		public void QtaResponse(bool press)
		{
			this.OnQtaResponse(press);
		}

		// Token: 0x060340C9 RID: 213193 RVA: 0x00C34CFB File Offset: 0x00C32EFB
		protected virtual void OnQtaResponse(bool press)
		{
		}

		// Token: 0x060340CA RID: 213194 RVA: 0x00C34D00 File Offset: 0x00C32F00
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

		// Token: 0x060340CB RID: 213195 RVA: 0x00C34DB6 File Offset: 0x00C32FB6
		public void ForceEnd()
		{
			this.StateInner = EQtaState.Ended;
			this.ResultTypeInner = EQtaResult.Fail;
		}

		// Token: 0x060340CC RID: 213196 RVA: 0x00C34DC6 File Offset: 0x00C32FC6
		protected virtual void OnQtaPendingSuccess()
		{
		}

		// Token: 0x060340CD RID: 213197 RVA: 0x00C34DC8 File Offset: 0x00C32FC8
		protected virtual void OnQtaResult(EQtaResult qtaResult)
		{
		}

		// Token: 0x060340CE RID: 213198 RVA: 0x00C34DCA File Offset: 0x00C32FCA
		protected virtual bool CheckQtaCanEnd()
		{
			return false;
		}

		// Token: 0x060340CF RID: 213199 RVA: 0x00C34DD0 File Offset: 0x00C32FD0
		public void EnableExternalConditionMet(EQtaExternalReason reason)
		{
			string message = "启用等待外部条件达成";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("reason", reason);
			QtaLog.Info(this, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			this.IsPendingExternalCompletion = true;
		}

		// Token: 0x060340D0 RID: 213200 RVA: 0x00C34E08 File Offset: 0x00C33008
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

		// Token: 0x060340D1 RID: 213201 RVA: 0x00C34E54 File Offset: 0x00C33054
		public virtual void OnPreEndQta()
		{
		}

		// Token: 0x060340D2 RID: 213202 RVA: 0x00C34E56 File Offset: 0x00C33056
		public float GetRemainingTime()
		{
			return Math.Max(0f, this.Duration - this.PassTime);
		}

		// Token: 0x060340D3 RID: 213203 RVA: 0x00C34E6F File Offset: 0x00C3306F
		public float GetRemainingTimeProgress()
		{
			if (this.Duration <= 0f)
			{
				return 1f;
			}
			return this.GetRemainingTime() / this.Duration;
		}

		// Token: 0x060340D4 RID: 213204 RVA: 0x00C34E91 File Offset: 0x00C33091
		public virtual float GetProgress()
		{
			return 0f;
		}

		// Token: 0x060340D5 RID: 213205 RVA: 0x00C34E98 File Offset: 0x00C33098
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

		// Token: 0x060340D6 RID: 213206 RVA: 0x00C34F7B File Offset: 0x00C3317B
		public bool CheckCondition()
		{
			return true;
		}

		// Token: 0x060340D7 RID: 213207 RVA: 0x00C34F7E File Offset: 0x00C3317E
		[NullableContext(1)]
		public string[] GetDistributeTags()
		{
			return this.InputDistributeFilterTags;
		}

		// Token: 0x060340D8 RID: 213208 RVA: 0x00C34F88 File Offset: 0x00C33188
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

		// Token: 0x060340D9 RID: 213209 RVA: 0x00C3502C File Offset: 0x00C3322C
		protected virtual void OnClear()
		{
		}

		// Token: 0x060340DA RID: 213210 RVA: 0x00C3502E File Offset: 0x00C3322E
		[NullableContext(1)]
		private void OnInputDistributeTagChanged(IReadOnlyList<InputDistributeTag> inputDistributeTags)
		{
			if (this.HasOtherNotAllowFightInputView())
			{
				this.SetQtaFailWhenFightInputBlocked();
			}
		}

		// Token: 0x060340DB RID: 213211 RVA: 0x00C35040 File Offset: 0x00C33240
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

		// Token: 0x060340DC RID: 213212 RVA: 0x00C3507C File Offset: 0x00C3327C
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

		// Token: 0x0401BA49 RID: 113225
		public EQtaContextType? Type;

		// Token: 0x0401BA4C RID: 113228
		public int QtaPriority;

		// Token: 0x0401BA4D RID: 113229
		public SQta Config;

		// Token: 0x0401BA4E RID: 113230
		protected EQtaState StateInner;

		// Token: 0x0401BA4F RID: 113231
		protected EQtaResult ResultTypeInner;

		// Token: 0x0401BA50 RID: 113232
		public IQtaExtraParams ExtraParams;

		// Token: 0x0401BA51 RID: 113233
		public TQtaCallback ResultCallback;

		// Token: 0x0401BA52 RID: 113234
		public EQtaSource? Source;

		// Token: 0x0401BA53 RID: 113235
		public float Duration;

		// Token: 0x0401BA54 RID: 113236
		public float LeastDuration;

		// Token: 0x0401BA55 RID: 113237
		public float PassTime;

		// Token: 0x0401BA56 RID: 113238
		public bool IsPermanent;

		// Token: 0x0401BA57 RID: 113239
		private bool IsPendingExternalCompletion;

		// Token: 0x0401BA58 RID: 113240
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Dictionary<int, IQtaPromptResource> Resource;

		// Token: 0x0401BA59 RID: 113241
		public AActor UiActor;

		// Token: 0x0401BA5A RID: 113242
		public EUiViewName? QtaViewName;

		// Token: 0x0401BA5B RID: 113243
		private bool NeedStopWhenFightInputBlocked;

		// Token: 0x0401BA5C RID: 113244
		private bool IsStoppingByFightInputBlocked;

		// Token: 0x0401BA5D RID: 113245
		private LazyConditionQta LazyCondition;

		// Token: 0x0401BA5E RID: 113246
		[Nullable(1)]
		private List<int> AppliedTagIds = new List<int>();

		// Token: 0x0401BA5F RID: 113247
		[Nullable(1)]
		private string[] InputDistributeFilterTags = Array.Empty<string>();
	}
}
