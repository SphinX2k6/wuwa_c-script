using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;
using AkiClient.Game.Aki.Render.RuntimeBP.ScreenEffect.Data;
using CSharpScript.Game;
using CSharpScript.Game.Common.Event;
using CSharpScript.Game.Effect;
using CSharpScript.Game.Module.BattleUi;
using CSharpScript.Game.Module.Gamepad;
using CSharpScript.Game.Module.Qte.View;
using CSharpScript.Game.Module.Teleport;
using CSharpScript.Game.Render.Effect.ScreenEffectSystem;
using CSharpScript.Game.Ui;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnrealEngine;

// Token: 0x02002605 RID: 9733
[NullableContext(2)]
[Nullable(0)]
[Controller(0)]
public class CommonQteController : ControllerBase
{
	// Token: 0x1700195D RID: 6493
	// (get) Token: 0x06013D1D RID: 81181 RVA: 0x004F8473 File Offset: 0x004F6673
	public CommonQteContextBase ContextProp
	{
		get
		{
			return this.Context;
		}
	}

	// Token: 0x06013D1E RID: 81182 RVA: 0x004F847B File Offset: 0x004F667B
	protected override bool OnInit()
	{
		EventSystem.Instance.Add<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		return true;
	}

	// Token: 0x06013D1F RID: 81183 RVA: 0x004F849A File Offset: 0x004F669A
	protected override bool OnClear()
	{
		EventSystem.Instance.Remove<TeleportContext>(EEventName.TeleportComplete, new Action<TeleportContext>(this.OnTeleportComplete));
		return true;
	}

	// Token: 0x06013D20 RID: 81184 RVA: 0x004F84B9 File Offset: 0x004F66B9
	protected override bool OnLeaveLevel()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x06013D21 RID: 81185 RVA: 0x004F84C2 File Offset: 0x004F66C2
	protected override bool OnChangeMode()
	{
		this.ClearAll();
		return true;
	}

	// Token: 0x06013D22 RID: 81186 RVA: 0x004F84CC File Offset: 0x004F66CC
	private void OnTeleportComplete(TeleportContext _)
	{
		if (this.IsInQte())
		{
			CommonQteContextBase context = this.Context;
			if (context != null && context.IsActive())
			{
				CommonQteContextBase context2 = this.Context;
				if (context2 != null && context2.IsPending())
				{
					this.SetQteTimeDilation(this.Context.Config.BaseConfig.TimeDilation);
				}
			}
		}
	}

	// Token: 0x06013D23 RID: 81187 RVA: 0x004F8524 File Offset: 0x004F6724
	public void RecoverTimeDilationAfterTeleport()
	{
		if (this.IsInQte())
		{
			CommonQteContextBase context = this.Context;
			if (context != null && context.IsActive())
			{
				CommonQteContextBase context2 = this.Context;
				if (context2 != null && context2.IsPending())
				{
					this.SetQteTimeDilation(this.Context.Config.BaseConfig.TimeDilation);
				}
			}
		}
	}

	// Token: 0x06013D24 RID: 81188 RVA: 0x004F857C File Offset: 0x004F677C
	private void ClearAll()
	{
		if (this.IsInQte())
		{
			this.ResetQteTimeDilation();
		}
		this.ClearQte();
	}

	// Token: 0x06013D25 RID: 81189 RVA: 0x004F8594 File Offset: 0x004F6794
	public CommonQteContextBase StartQte(int qteId, TCommonQteCallback onSuccess = null, TCommonQteCallback onFail = null, EQteSource source = EQteSource.Battle, IQteExtraParams extraParams = null)
	{
		string value = null;
		if (this.IsInQte())
		{
			value = "当前存在执行中的Qte, 无法开始新的Qte";
		}
		else if (this.IsPreloadingQte)
		{
			value = "Qte预加载中, 无法开始新的Qte";
		}
		if (!string.IsNullOrEmpty(value))
		{
			return null;
		}
		CommonQteModel instance = CommonQteModel.Instance;
		CommonQteContextBase commonQteContextBase = (instance != null) ? instance.CreateQteContext(qteId, onSuccess, onFail, source, extraParams) : null;
		if (commonQteContextBase == null)
		{
			return null;
		}
		if (!commonQteContextBase.VerifyConfig())
		{
			return null;
		}
		if (this.StartQteInternal(commonQteContextBase))
		{
			return commonQteContextBase;
		}
		return null;
	}

	// Token: 0x06013D26 RID: 81190 RVA: 0x004F8600 File Offset: 0x004F6800
	[NullableContext(1)]
	private unsafe bool StartQteInternal(CommonQteContextBase context)
	{
		CommonQteModel.Instance.SetCurrentCommonQte(context);
		int qteId = context.QteId;
		this.IsInQteInternal = true;
		this.Context = context;
		EUiViewName? viewName = CommonQteModel.Instance.GetCommonQteViewName(qteId);
		string itemName = null;
		if (viewName == null)
		{
			itemName = CommonQteModel.Instance.GetCommonQteItemName(qteId);
		}
		this.PreloadQteRes(new <>z__ReadOnlySingleElementList<int>(qteId), context.HandleId, false).ContinueWith(delegate(bool success)
		{
			bool flag;
			if (this.IsInQteInternal)
			{
				CommonQteContextBase context2 = this.Context;
				int? num = (context2 != null) ? new int?(context2.HandleId) : null;
				int handleId = context.HandleId;
				flag = (num.GetValueOrDefault() == handleId & num != null);
			}
			else
			{
				flag = false;
			}
			bool flag2 = flag;
			if (flag2)
			{
				if (success)
				{
					CommonQteViewBase commonQteViewBase;
					if (!string.IsNullOrEmpty(itemName))
					{
						CommonQteItemBase commonQteItemBase;
						if (this.CommonQteItemMap.TryGetValue(qteId, out commonQteItemBase))
						{
							CommonQteContextBase context3 = context;
							CommonQteModel instance = CommonQteModel.Instance;
							context3.Resource = ((instance != null) ? instance.GetQteResource(qteId, false) : null);
							context.UiActor = commonQteItemBase.GetRootActor();
							commonQteItemBase.SetQteContext(context);
							this.CommonQteItemMap.Remove(qteId);
							return;
						}
					}
					else if (viewName != null && this.CommonQteViewMap.TryGetValue(viewName.Value, out commonQteViewBase) && commonQteViewBase != null)
					{
						context.Resource = CommonQteModel.Instance.GetQteResource(qteId, false);
						commonQteViewBase.SetQteContext(context);
						this.CommonQteViewMap.Remove(viewName.Value);
						return;
					}
				}
				Log instance2 = Log.Instance;
				ELogModule module = ELogModule.CommonQte;
				ELogAuthor author = ELogAuthor.WWJ;
				string message = "Qte加载失败, 停止当前Qte";
				<>y__InlineArray5<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray5<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleId", context.HandleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("QteId", context.QteId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 2) = new ValueTuple<string, object>("ViewName", viewName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 3) = new ValueTuple<string, object>("ItemName", itemName);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 4) = new ValueTuple<string, object>("Success", success);
				instance2.Info(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray5<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 5));
				this.OnQteEnd();
				return;
			}
			Log instance3 = Log.Instance;
			ELogModule module2 = ELogModule.CommonQte;
			ELogAuthor author2 = ELogAuthor.WWJ;
			string message2 = "Qte预加载完成后, Qte已结束或已过期";
			<>y__InlineArray8<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray8<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("HandleId", context.HandleId);
			ref ValueTuple<string, object> ptr = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1);
			string item = "CurrentQteHandleId";
			CommonQteContextBase context4 = this.Context;
			ptr = new ValueTuple<string, object>(item, (context4 != null) ? new int?(context4.HandleId) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 2) = new ValueTuple<string, object>("QteId", context.QteId);
			ref ValueTuple<string, object> ptr2 = ref <PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 3);
			string item2 = "CurrentQteId";
			CommonQteContextBase context5 = this.Context;
			ptr2 = new ValueTuple<string, object>(item2, (context5 != null) ? new int?(context5.QteId) : null);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 4) = new ValueTuple<string, object>("IsInQte", this.IsInQteInternal);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 5) = new ValueTuple<string, object>("IsQteValid", flag2);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 6) = new ValueTuple<string, object>("ViewName", viewName);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 7) = new ValueTuple<string, object>("ItemName", itemName);
			instance3.Info(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray8<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 8));
			if (!string.IsNullOrEmpty(itemName))
			{
				CommonQteItemBase commonQteItemBase2;
				if (this.CommonQteItemMap.TryGetValue(qteId, out commonQteItemBase2))
				{
					CommonQteItemBase commonQteItemBase3 = commonQteItemBase2;
					if (!commonQteItemBase3.IsDestroyOrDestroying)
					{
						commonQteItemBase3.Destroy(null);
					}
				}
				this.CommonQteItemMap.Remove(qteId);
			}
			if (viewName != null)
			{
				UiManager.Instance.CloseView(viewName.Value, null);
				this.CommonQteViewMap.Remove(viewName.Value);
			}
			CommonQteModel instance4 = CommonQteModel.Instance;
			if (instance4 == null)
			{
				return;
			}
			instance4.ClearPreloadCache(new int?(qteId));
		}).Forget();
		SCommonQte config = context.Config;
		if (config != null)
		{
			if (config.ExtraConfig.IsBlockFightInput)
			{
				this.AddFightInputBlock(EUiViewName.CommonQteView);
			}
			this.PlayQteAudio(config.AudioConfig.AudioEventStart, null);
			this.AddExtraEffect(config.ExtraConfig);
			this.SetQteTimeDilation(config.BaseConfig.TimeDilation);
		}
		if (this.ShouldQteShowMouse(context))
		{
			this.ShowMouseCursor(EUiViewName.CommonQteView);
		}
		EventSystem.Instance.Emit<int?>(EEventName.CommonQteStart, new int?(this.Context.HandleId));
		return true;
	}

	// Token: 0x06013D27 RID: 81191 RVA: 0x004F8760 File Offset: 0x004F6960
	public CommonQteGroupContext StartQteGroup(int qteGroupId, TCommonQteCallback onSuccess = null, TCommonQteCallback onFail = null, EQteSource source = EQteSource.Battle, IQteExtraParams extraParams = null)
	{
		string value = null;
		if (this.IsInQte())
		{
			value = "当前存在执行中的Qte, 无法开始新的Qte";
		}
		else if (this.IsPreloadingQte)
		{
			value = "Qte预加载中, 无法开始新的Qte";
		}
		if (!string.IsNullOrEmpty(value))
		{
			return null;
		}
		CommonQteGroupContext commonQteGroupContext = CommonQteModel.Instance.CreateQteGroupContext(qteGroupId, onSuccess, onFail, source, extraParams);
		if (commonQteGroupContext == null)
		{
			return null;
		}
		if (this.StartQteGroupInternal(commonQteGroupContext))
		{
			return commonQteGroupContext;
		}
		return null;
	}

	// Token: 0x06013D28 RID: 81192 RVA: 0x004F87BC File Offset: 0x004F69BC
	[NullableContext(1)]
	private bool StartQteGroupInternal(CommonQteGroupContext groupContext)
	{
		Dictionary<int, CommonQteContextBase> contextMap = groupContext.ContextMap;
		if (contextMap == null || contextMap.Count == 0)
		{
			return false;
		}
		CommonQteModel instance = CommonQteModel.Instance;
		if (instance != null)
		{
			instance.SetCurrentCommonQte(groupContext);
		}
		this.IsInQteInternal = true;
		this.Context = groupContext;
		List<int> qteIdList = new List<int>(contextMap.Keys);
		this.PreloadQteRes(qteIdList, groupContext.HandleId, true).ContinueWith(delegate(bool success)
		{
			bool flag = true;
			if (success)
			{
				using (Dictionary<int, CommonQteContextBase>.Enumerator enumerator = contextMap.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<int, CommonQteContextBase> keyValuePair = enumerator.Current;
						int key = keyValuePair.Key;
						CommonQteContextBase value = keyValuePair.Value;
						CommonQteModel instance2 = CommonQteModel.Instance;
						if (!string.IsNullOrEmpty((instance2 != null) ? instance2.GetCommonQteItemName(key) : null))
						{
							CommonQteItemBase commonQteItemBase;
							if (this.CommonQteItemMap.TryGetValue(key, out commonQteItemBase))
							{
								CommonQteContextBase commonQteContextBase = value;
								CommonQteModel instance3 = CommonQteModel.Instance;
								commonQteContextBase.Resource = ((instance3 != null) ? instance3.GetQteResource(key, false) : null);
								value.UiActor = commonQteItemBase.GetRootActor();
								commonQteItemBase.SetQteContext(value);
								this.CommonQteItemMap.Remove(key);
							}
							else
							{
								flag = false;
							}
						}
						else
						{
							flag = false;
						}
					}
					goto IL_C9;
				}
			}
			flag = false;
			IL_C9:
			if (!flag)
			{
				this.OnQteEnd();
			}
		}).Forget();
		SCommonQte config = groupContext.GetConfig();
		if (config != null)
		{
			if (config.ExtraConfig.IsBlockFightInput)
			{
				this.AddFightInputBlock(EUiViewName.CommonQteView);
			}
			this.PlayQteAudio(config.AudioConfig.AudioEventStart, null);
			this.AddExtraEffect(config.ExtraConfig);
		}
		if (this.ShouldQteShowMouse(groupContext))
		{
			this.ShowMouseCursor(EUiViewName.CommonQteView);
		}
		this.SetQteTimeDilation(groupContext.GroupConfig.TimeDilation);
		EventSystem.Instance.Emit<int?>(EEventName.CommonQteStart, new int?(this.Context.HandleId));
		return true;
	}

	// Token: 0x06013D29 RID: 81193 RVA: 0x004F88DC File Offset: 0x004F6ADC
	[NullableContext(1)]
	public void SetExpiredTimer(CommonQteContextBase context)
	{
		if (context.Source.GetValueOrDefault() == EQteSource.Plot || context.Source.GetValueOrDefault() == EQteSource.CG)
		{
			return;
		}
		this.RemoveExpiredTimer();
		float currentValue = context.IsPermanent ? 60000f : (context.Duration + 5000f);
		this.ExpiredTimer = TimerSystem.Instance.Delay(delegate(float _)
		{
			if (!context.IsFail())
			{
				context.QteFail();
				return;
			}
			this.OnQteEnd();
		}, MathUtils.Instance.Clamp(currentValue, 20f, 180000f), null, null, true, 1f);
	}

	// Token: 0x06013D2A RID: 81194 RVA: 0x004F898C File Offset: 0x004F6B8C
	public void StopQte(int qteHandle)
	{
		CommonQteContextBase context = this.Context;
		int? num = (context != null) ? new int?(context.HandleId) : null;
		if (!(qteHandle == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.OnQteEnd();
	}

	// Token: 0x06013D2B RID: 81195 RVA: 0x004F89D4 File Offset: 0x004F6BD4
	public void StopCurrentQte()
	{
		this.OnQteEnd();
	}

	// Token: 0x06013D2C RID: 81196 RVA: 0x004F89DC File Offset: 0x004F6BDC
	public void WaitQteEnd(int qteHandle)
	{
		CommonQteContextBase context = this.Context;
		int? num = (context != null) ? new int?(context.HandleId) : null;
		if (!(qteHandle == num.GetValueOrDefault() & num != null))
		{
			return;
		}
		this.OnQteWaitEnd();
	}

	// Token: 0x06013D2D RID: 81197 RVA: 0x004F8A24 File Offset: 0x004F6C24
	private void OnQteWaitEnd()
	{
		CommonQteContextBase context = this.Context;
		if (((context != null) ? context.Config : null) != null && this.Context.IsPendingSuccess())
		{
			this.PlayQteAudio(this.Context.Config.AudioConfig.AudioEventPendingSuccess, null);
		}
	}

	// Token: 0x06013D2E RID: 81198 RVA: 0x004F8A75 File Offset: 0x004F6C75
	private bool ShouldQteShowMouse(CommonQteContextBase context)
	{
		return context == null || (!this.TempHideCursorQteSet.Contains(context.QteId) && context.ShouldShowMouseCursor());
	}

	// Token: 0x06013D2F RID: 81199 RVA: 0x004F8A98 File Offset: 0x004F6C98
	private void OnQteEnd()
	{
		this.ResetQteTimeDilation();
		CommonQteContextBase context = this.Context;
		SCommonQte scommonQte = (context != null) ? context.GetConfig() : null;
		if (scommonQte != null)
		{
			CommonQteContextBase context2 = this.Context;
			if (context2 != null && context2.IsSuccess())
			{
				this.PlayQteAudio(scommonQte.AudioConfig.AudioEventSuccess, null);
			}
			else
			{
				CommonQteContextBase context3 = this.Context;
				if (context3 != null && context3.IsFail())
				{
					this.PlayQteAudio(scommonQte.AudioConfig.AudioEventFail, null);
				}
			}
		}
		EventSystem instance = EventSystem.Instance;
		EEventName name = EEventName.CommonQteEnd;
		CommonQteContextBase context4 = this.Context;
		instance.Emit<int?>(name, (context4 != null) ? new int?(context4.HandleId) : null);
		CommonQteModel instance2 = CommonQteModel.Instance;
		if (instance2 != null)
		{
			instance2.ClearQteHandleId(null);
		}
		CommonQteGroupContext commonQteGroupContext = this.Context as CommonQteGroupContext;
		if (commonQteGroupContext != null)
		{
			Dictionary<int, CommonQteContextBase> contextMap = commonQteGroupContext.ContextMap;
			if (contextMap != null)
			{
				foreach (CommonQteContextBase commonQteContextBase in contextMap.Values)
				{
					EventSystem.Instance.Emit<int?>(EEventName.CommonQteEnd, new int?(commonQteContextBase.HandleId));
					CommonQteModel instance3 = CommonQteModel.Instance;
					if (instance3 != null)
					{
						instance3.ClearQteHandleId(new int?(commonQteContextBase.HandleId));
					}
				}
			}
		}
		this.ClearQte();
	}

	// Token: 0x06013D30 RID: 81200 RVA: 0x004F8BF8 File Offset: 0x004F6DF8
	public void PauseQte(int handleId)
	{
		if (this.Context == null || handleId != this.Context.HandleId)
		{
			return;
		}
		if (this.ExpiredTimer != null && !this.ExpiredTimer.IsPause())
		{
			this.ExpiredTimer.Pause();
		}
		this.ResetQteTimeDilation();
	}

	// Token: 0x06013D31 RID: 81201 RVA: 0x004F8C38 File Offset: 0x004F6E38
	public void ResumeQte(int handleId)
	{
		if (this.Context == null || handleId != this.Context.HandleId)
		{
			return;
		}
		if (this.ExpiredTimer != null && this.ExpiredTimer.IsPause())
		{
			this.ExpiredTimer.Resume();
		}
		this.SetQteTimeDilation(this.Context.Config.BaseConfig.TimeDilation);
		this.ResumeFightInputBlock();
	}

	// Token: 0x06013D32 RID: 81202 RVA: 0x004F8C9E File Offset: 0x004F6E9E
	public bool IsInQte()
	{
		return this.IsInQteInternal;
	}

	// Token: 0x06013D33 RID: 81203 RVA: 0x004F8CA6 File Offset: 0x004F6EA6
	public bool IsPreloading()
	{
		return this.IsPreloadingQte;
	}

	// Token: 0x06013D34 RID: 81204 RVA: 0x004F8CB0 File Offset: 0x004F6EB0
	public void ClearQte()
	{
		this.RemoveFightInputBlock();
		this.RemoveExtraEffect();
		this.RemoveExpiredTimer();
		this.HideMouseCursor();
		this.IsInQteInternal = false;
		this.IsPreloadingQte = false;
		this.IsSetQteTimeDilation = false;
		CommonQteContextBase context = this.Context;
		if (context != null)
		{
			context.Clear();
		}
		this.Context = null;
		this.ClearPreloadQteRes();
	}

	// Token: 0x06013D35 RID: 81205 RVA: 0x004F8D08 File Offset: 0x004F6F08
	private void RemoveExpiredTimer()
	{
		if (this.ExpiredTimer != null)
		{
			TimerSystem.Instance.Remove(this.ExpiredTimer);
		}
		this.ExpiredTimer = null;
	}

	// Token: 0x06013D36 RID: 81206 RVA: 0x004F8D2C File Offset: 0x004F6F2C
	public void SetQteTimeDilation(float timeDilation)
	{
		if (!this.IsInQte())
		{
			return;
		}
		GameModeModel instance = GameModeModel.Instance;
		if (instance != null && instance.IsMulti)
		{
			return;
		}
		if (timeDilation == 0f)
		{
			return;
		}
		TeleportModel instance2 = TeleportModel.Instance;
		if (instance2 != null && instance2.IsTeleport)
		{
			return;
		}
		if (Time.Instance.TimeDilation != 0f)
		{
			this.SetQteTimeDilationInternal(timeDilation);
		}
	}

	// Token: 0x06013D37 RID: 81207 RVA: 0x004F8D8B File Offset: 0x004F6F8B
	public void ResetQteTimeDilation()
	{
		this.SetQteTimeDilationInternal(1f);
	}

	// Token: 0x06013D38 RID: 81208 RVA: 0x004F8D98 File Offset: 0x004F6F98
	public bool IsSelfTriggeringTimeDilationChange()
	{
		return this.IsSelfTriggeringTimeDilation;
	}

	// Token: 0x06013D39 RID: 81209 RVA: 0x004F8DA0 File Offset: 0x004F6FA0
	private void SetQteTimeDilationInternal(float timeDilation)
	{
		bool flag = timeDilation != 1f;
		if (!flag && !this.IsSetQteTimeDilation)
		{
			return;
		}
		if (flag && this.IsSetQteTimeDilation)
		{
			return;
		}
		this.IsSetQteTimeDilation = flag;
		this.IsSelfTriggeringTimeDilation = true;
		GameModeController.Instance.SetTimeDilation(timeDilation, ETimeDilationType.CommonQte);
		this.IsSelfTriggeringTimeDilation = false;
	}

	// Token: 0x06013D3A RID: 81210 RVA: 0x004F8DF4 File Offset: 0x004F6FF4
	[NullableContext(1)]
	public void AddExtraEffect(SCommonQte_Extra config)
	{
		if (config.HideAllBattleUi)
		{
			this.IsHideAllBattleUi = true;
			BattleUiModel.Instance.ChildViewData.HideBattleView(EBattleUiVisibleReason.PanelQte, new List<EBattleUiChild>
			{
				EBattleUiChild.PanelQTE
			}, 0);
			return;
		}
		this.IsHideAllBattleUi = false;
		int num = config.HideUIElement.Num();
		if (num > 0)
		{
			List<int> list = new List<int>();
			for (int i = 0; i < num; i++)
			{
				list.Add((int)config.HideUIElement.Get(i));
			}
			BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.PanelQte, CommonQteController.ConvertToBattleUiChildren(list), false, true, 0);
			this.HideBattleUiChildren = list;
			return;
		}
		this.HideBattleUiChildren = null;
	}

	// Token: 0x06013D3B RID: 81211 RVA: 0x004F8E98 File Offset: 0x004F7098
	public void RemoveExtraEffect()
	{
		if (this.IsHideAllBattleUi)
		{
			BattleUiModel.Instance.ChildViewData.ShowBattleView(EBattleUiVisibleReason.PanelQte, 0);
			this.IsHideAllBattleUi = false;
		}
		else
		{
			List<int> hideBattleUiChildren = this.HideBattleUiChildren;
			if (hideBattleUiChildren != null)
			{
				BattleUiModel.Instance.ChildViewData.SetChildrenVisible(EBattleUiVisibleReason.PanelQte, CommonQteController.ConvertToBattleUiChildren(hideBattleUiChildren), true, true, 0);
				this.HideBattleUiChildren = null;
			}
		}
		this.RemoveScreenEffect();
		this.RemoveCameraShake(true);
	}

	// Token: 0x06013D3C RID: 81212 RVA: 0x004F8F00 File Offset: 0x004F7100
	private void RemoveScreenEffect()
	{
		if (this.ScreenEffectTimer != null)
		{
			TimerSystem.Instance.Remove(this.ScreenEffectTimer);
			this.ScreenEffectTimer = null;
		}
		if (this.ScreenEffect != null)
		{
			ScreenEffectSystem.GetInstance().EndScreenEffect(this.ScreenEffect);
			this.ScreenEffect = null;
		}
		if (this.ScreenEffectHandle != -1)
		{
			EffectSystem.Instance.StopEffectById(this.ScreenEffectHandle, "[CommonQteController.RemoveScreenEffect]", true, null);
			this.ScreenEffectHandle = -1;
		}
	}

	// Token: 0x06013D3D RID: 81213 RVA: 0x004F8F7C File Offset: 0x004F717C
	private void RemoveCameraShake(bool immediatly = true)
	{
		if (this.CameraShakeTimer != null)
		{
			TimerSystem.Instance.Remove(this.CameraShakeTimer);
			this.CameraShakeTimer = null;
		}
		if (this.CameraShake != null)
		{
			Global.CharacterCameraManager.StopCameraShake(this.CameraShake, immediatly);
			this.CameraShake = null;
		}
	}

	// Token: 0x06013D3E RID: 81214 RVA: 0x004F8FCC File Offset: 0x004F71CC
	public void PlayScreenEffect()
	{
		CommonQteController.<>c__DisplayClass57_0 CS$<>8__locals1 = new CommonQteController.<>c__DisplayClass57_0();
		CS$<>8__locals1.<>4__this = this;
		if (this.Context == null)
		{
			return;
		}
		if (this.IsPlayingScreenEffect())
		{
			return;
		}
		CommonQteController.<>c__DisplayClass57_0 CS$<>8__locals2 = CS$<>8__locals1;
		IQteResource resource = this.Context.Resource;
		CS$<>8__locals2.screenEffect = ((resource != null) ? resource.ScreenEffect1 : null);
		if (CS$<>8__locals1.screenEffect != null)
		{
			this.ScreenEffectType = EQteScreenEffectType.Type1;
			this.ScreenEffect = CS$<>8__locals1.screenEffect;
			ScreenEffectSystem.GetInstance().PlayScreenEffect(CS$<>8__locals1.screenEffect);
			if (CS$<>8__locals1.screenEffect.Loop == 0f)
			{
				float currentValue = (CS$<>8__locals1.screenEffect.Start + CS$<>8__locals1.screenEffect.End) * (float)TimeUtil.Instance.InverseMillisecond;
				this.ScreenEffectTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					ScreenEffectSystem.GetInstance().EndScreenEffect(CS$<>8__locals1.screenEffect);
					CS$<>8__locals1.<>4__this.ScreenEffect = null;
					CS$<>8__locals1.<>4__this.ScreenEffectTimer = null;
				}, MathUtils.Instance.Clamp(currentValue, 20f, 180000f), null, null, true, 1f);
			}
			return;
		}
		IQteResource resource2 = this.Context.Resource;
		EffectModelPostProcess effectModelPostProcess = (resource2 != null) ? resource2.ScreenEffect2 : null;
		if (effectModelPostProcess != null)
		{
			CommonQteModel instance = CommonQteModel.Instance;
			string text = (instance != null) ? instance.GetQteScreenEffectPath(this.Context.QteId, EQteScreenEffectType.Type2) : null;
			if (!string.IsNullOrEmpty(text))
			{
				this.ScreenEffectType = EQteScreenEffectType.Type2;
				EffectSystem instance2 = EffectSystem.Instance;
				UObject world = GlobalData.World;
				FTransformDouble? ftransformDouble = new FTransformDouble?(Transform.Create().ToUeTransform());
				this.ScreenEffectHandle = instance2.SpawnEffect(world, ftransformDouble, text, "[CommonQteController.PlayScreenEffect]", null, EEffectType.Scene, null, null, null, false, false);
				if (effectModelPostProcess.LoopTime == 0f)
				{
					float currentValue2 = (effectModelPostProcess.StartTime + effectModelPostProcess.EndTime) * (float)TimeUtil.Instance.InverseMillisecond;
					this.ScreenEffectTimer = TimerSystem.Instance.Delay(delegate(float _)
					{
						EffectSystem.Instance.StopEffectById(CS$<>8__locals1.<>4__this.ScreenEffectHandle, "[CommonQteController.ScreenEffectTimer]", true, null);
						CS$<>8__locals1.<>4__this.ScreenEffectHandle = -1;
						CS$<>8__locals1.<>4__this.ScreenEffectTimer = null;
					}, MathUtils.Instance.Clamp(currentValue2, 20f, 180000f), null, null, true, 1f);
				}
			}
		}
	}

	// Token: 0x06013D3F RID: 81215 RVA: 0x004F9198 File Offset: 0x004F7398
	public bool IsPlayingScreenEffect()
	{
		if (this.ScreenEffectType == EQteScreenEffectType.Type1)
		{
			return this.ScreenEffect != null;
		}
		return this.ScreenEffectType == EQteScreenEffectType.Type2 && this.ScreenEffectHandle != -1;
	}

	// Token: 0x06013D40 RID: 81216 RVA: 0x004F91C4 File Offset: 0x004F73C4
	public void PlayCameraShake()
	{
		if (this.Context == null)
		{
			return;
		}
		if (this.CameraShake != null)
		{
			return;
		}
		IQteResource resource = this.Context.Resource;
		UClass uclass = (resource != null) ? resource.CameraShake : null;
		if (uclass != null)
		{
			this.CameraShake = Global.CharacterCameraManager.StartMatineeCameraShake(uclass, 1f, ECameraShakePlaySpace.CameraLocal, default(FRotator), 1f);
			if (this.CameraShake != null)
			{
				float currentValue = this.CameraShake.OscillatorTimeRemaining * (float)TimeUtil.Instance.InverseMillisecond;
				this.CameraShakeTimer = TimerSystem.Instance.Delay(delegate(float _)
				{
					Global.CharacterCameraManager.StopCameraShake(this.CameraShake, false);
					this.CameraShake = null;
					this.CameraShakeTimer = null;
				}, MathUtils.Instance.Clamp(currentValue, 20f, 180000f), null, null, true, 1f);
			}
		}
	}

	// Token: 0x06013D41 RID: 81217 RVA: 0x004F9284 File Offset: 0x004F7484
	public void PlayGamepadShake()
	{
		if (this.Context == null)
		{
			return;
		}
		IQteResource resource = this.Context.Resource;
		UKuroForceFeedbackEffect ukuroForceFeedbackEffect = (resource != null) ? resource.GamepadShake : null;
		if (ukuroForceFeedbackEffect == null || this.Context.Type == null)
		{
			return;
		}
		GamepadController.Instance.TriggerGamepadShakeByQte(this.Context.Type.Value, ukuroForceFeedbackEffect);
	}

	// Token: 0x06013D42 RID: 81218 RVA: 0x004F92E4 File Offset: 0x004F74E4
	public void StopGamepadShake()
	{
		if (this.Context == null)
		{
			return;
		}
		IQteResource resource = this.Context.Resource;
		UKuroForceFeedbackEffect ukuroForceFeedbackEffect = (resource != null) ? resource.GamepadShake : null;
		if (ukuroForceFeedbackEffect == null || this.Context.Type == null)
		{
			return;
		}
		GamepadController.Instance.StopQteGamepadShake(this.Context.Type.Value, ukuroForceFeedbackEffect);
	}

	// Token: 0x06013D43 RID: 81219 RVA: 0x004F9343 File Offset: 0x004F7543
	public void PlayExtraEffect(int qteHandle)
	{
		if (this.Context == null || qteHandle != this.Context.HandleId)
		{
			return;
		}
		this.PlayScreenEffect();
		this.PlayCameraShake();
		this.PlayGamepadShake();
	}

	// Token: 0x06013D44 RID: 81220 RVA: 0x004F936E File Offset: 0x004F756E
	public void StopExtraEffect(int qteHandle)
	{
		if (this.Context == null || qteHandle != this.Context.HandleId)
		{
			return;
		}
		this.RemoveScreenEffect();
		this.RemoveCameraShake(false);
		this.StopGamepadShake();
	}

	// Token: 0x06013D45 RID: 81221 RVA: 0x004F939C File Offset: 0x004F759C
	public int PlayQteAudio([Nullable(new byte[]
	{
		2,
		1
	})] TSoftObjectPtr<UAkAudioEvent> audioEvent, AActor actor = null)
	{
		if (audioEvent == null)
		{
			return 0;
		}
		string text = AudioSystem.Instance.parseAudioEventPath(audioEvent.ToAssetPathName());
		if (string.IsNullOrEmpty(text))
		{
			return 0;
		}
		if (actor != null)
		{
			return AudioSystem.Instance.PostEvent(text, actor, null);
		}
		return AudioSystem.Instance.PostEvent(text);
	}

	// Token: 0x06013D46 RID: 81222 RVA: 0x004F93F4 File Offset: 0x004F75F4
	public void SeekAudio(Number position, [Nullable(new byte[]
	{
		2,
		1
	})] TSoftObjectPtr<UAkAudioEvent> audioEvent, AActor actor = null, int? handle = null)
	{
		if (audioEvent == null)
		{
			return;
		}
		string text = AudioSystem.Instance.parseAudioEventPath(audioEvent.ToAssetPathName());
		if (string.IsNullOrEmpty(text))
		{
			return;
		}
		AudioSystem.Instance.SeekOnEvent(text, position, new SeekOnEventArgs?(new SeekOnEventArgs(actor, handle, null)));
	}

	// Token: 0x06013D47 RID: 81223 RVA: 0x004F944C File Offset: 0x004F764C
	public void StopQteAudio(int handle, float? blendOutTime = null)
	{
		if (handle == 0)
		{
			return;
		}
		ExecuteActionArgs value = new ExecuteActionArgs(null, null, null);
		if (blendOutTime != null)
		{
			value.TransitionDuration = new int?((int)blendOutTime.Value);
		}
		AudioSystem.Instance.ExecuteAction(handle, EAudioActionType.Stop, new ExecuteActionArgs?(value));
	}

	// Token: 0x06013D48 RID: 81224 RVA: 0x004F94A8 File Offset: 0x004F76A8
	[NullableContext(0)]
	public UniTask<bool> PreloadQteRes([Nullable(1)] IReadOnlyList<int> qteIdList, int preloadHandleId = -1, bool isGroupQte = false)
	{
		CommonQteController.<PreloadQteRes>d__67 <PreloadQteRes>d__;
		<PreloadQteRes>d__.<>t__builder = AsyncUniTaskMethodBuilder<bool>.Create();
		<PreloadQteRes>d__.<>4__this = this;
		<PreloadQteRes>d__.qteIdList = qteIdList;
		<PreloadQteRes>d__.preloadHandleId = preloadHandleId;
		<PreloadQteRes>d__.isGroupQte = isGroupQte;
		<PreloadQteRes>d__.<>1__state = -1;
		<PreloadQteRes>d__.<>t__builder.Start<CommonQteController.<PreloadQteRes>d__67>(ref <PreloadQteRes>d__);
		return <PreloadQteRes>d__.<>t__builder.Task;
	}

	// Token: 0x06013D49 RID: 81225 RVA: 0x004F9504 File Offset: 0x004F7704
	public void ClearPreloadQteRes()
	{
		foreach (KeyValuePair<EUiViewName, CommonQteViewBase> keyValuePair in this.CommonQteViewMap)
		{
			UiManager.Instance.CloseView(keyValuePair.Key, null);
		}
		this.CommonQteViewMap.Clear();
		foreach (CommonQteItemBase commonQteItemBase in this.CommonQteItemMap.Values)
		{
			if (!commonQteItemBase.IsDestroyOrDestroying)
			{
				commonQteItemBase.Destroy(null);
			}
		}
		this.CommonQteItemMap.Clear();
		CommonQteModel.Instance.ClearPreloadCache(null);
		Dictionary<int, CommonQteItemBase> commonQteItemMapDebug = this.CommonQteItemMapDebug;
		if (commonQteItemMapDebug != null)
		{
			commonQteItemMapDebug.Clear();
		}
		Dictionary<EUiViewName, CommonQteViewBase> commonQteViewMapDebug = this.CommonQteViewMapDebug;
		if (commonQteViewMapDebug == null)
		{
			return;
		}
		commonQteViewMapDebug.Clear();
	}

	// Token: 0x06013D4A RID: 81226 RVA: 0x004F95FC File Offset: 0x004F77FC
	private void AddFightInputBlock(EUiViewName viewName)
	{
		if (this.FightInputBlockViewName != null)
		{
			return;
		}
		this.FightInputBlockViewName = new EUiViewName?(viewName);
		InputDistributeModel.Instance.AddNotAllowFightInputViewName(viewName);
		EventSystem.Instance.Emit(EEventName.OnAddNotAllowFightInputViewName);
	}

	// Token: 0x06013D4B RID: 81227 RVA: 0x004F9634 File Offset: 0x004F7834
	private void RemoveFightInputBlock()
	{
		if (this.FightInputBlockViewName == null)
		{
			return;
		}
		InputDistributeModel.Instance.RemoveNotAllowFightInputViewName(this.FightInputBlockViewName.Value);
		EventSystem.Instance.Emit(EEventName.OnRemoveNotAllowFightInputViewName);
		this.FightInputBlockViewName = null;
	}

	// Token: 0x06013D4C RID: 81228 RVA: 0x004F9680 File Offset: 0x004F7880
	private void ShowMouseCursor(EUiViewName viewName)
	{
		if (this.ShowMouseCursorName != null)
		{
			return;
		}
		this.ShowMouseCursorName = new EUiViewName?(viewName);
		InputManager.Instance.PauseImmersiveMouseMode(EImmersiveMouseModeReason.Qte, true, true, false);
		InputManager.Instance.AddDynamicShowMouseView(viewName);
	}

	// Token: 0x06013D4D RID: 81229 RVA: 0x004F96B9 File Offset: 0x004F78B9
	private void HideMouseCursor()
	{
		if (this.ShowMouseCursorName == null)
		{
			return;
		}
		InputManager.Instance.ResumeImmersiveMouseMode(EImmersiveMouseModeReason.Qte);
		InputManager.Instance.RemoveDynamicShowMouseView(this.ShowMouseCursorName.Value);
		this.ShowMouseCursorName = null;
	}

	// Token: 0x06013D4E RID: 81230 RVA: 0x004F96FC File Offset: 0x004F78FC
	private void ResumeFightInputBlock()
	{
		if (this.FightInputBlockViewName == null)
		{
			return;
		}
		if (!InputDistributeModel.Instance.HasNotAllowFightInputViewIsOpen(this.FightInputBlockViewName.Value))
		{
			InputDistributeModel.Instance.AddNotAllowFightInputViewName(this.FightInputBlockViewName.Value);
			EventSystem.Instance.Emit(EEventName.OnAddNotAllowFightInputViewName);
		}
	}

	// Token: 0x06013D4F RID: 81231 RVA: 0x004F9754 File Offset: 0x004F7954
	[NullableContext(1)]
	private static List<EBattleUiChild> ConvertToBattleUiChildren(List<int> hideBattleUiChildren)
	{
		List<EBattleUiChild> list = new List<EBattleUiChild>(hideBattleUiChildren.Count);
		for (int i = 0; i < hideBattleUiChildren.Count; i++)
		{
			list.Add((EBattleUiChild)hideBattleUiChildren[i]);
		}
		return list;
	}

	// Token: 0x06013D50 RID: 81232 RVA: 0x004F978C File Offset: 0x004F798C
	private UniTask CloseViewSafe(EUiViewName viewName)
	{
		CommonQteController.<CloseViewSafe>d__75 <CloseViewSafe>d__;
		<CloseViewSafe>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CloseViewSafe>d__.viewName = viewName;
		<CloseViewSafe>d__.<>1__state = -1;
		<CloseViewSafe>d__.<>t__builder.Start<CommonQteController.<CloseViewSafe>d__75>(ref <CloseViewSafe>d__);
		return <CloseViewSafe>d__.<>t__builder.Task;
	}

	// Token: 0x06013D51 RID: 81233 RVA: 0x004F97D0 File Offset: 0x004F79D0
	[NullableContext(0)]
	private UniTask<int?> OpenViewSafe(EUiViewName viewName)
	{
		CommonQteController.<OpenViewSafe>d__76 <OpenViewSafe>d__;
		<OpenViewSafe>d__.<>t__builder = AsyncUniTaskMethodBuilder<int?>.Create();
		<OpenViewSafe>d__.viewName = viewName;
		<OpenViewSafe>d__.<>1__state = -1;
		<OpenViewSafe>d__.<>t__builder.Start<CommonQteController.<OpenViewSafe>d__76>(ref <OpenViewSafe>d__);
		return <OpenViewSafe>d__.<>t__builder.Task;
	}

	// Token: 0x06013D52 RID: 81234 RVA: 0x004F9814 File Offset: 0x004F7A14
	[NullableContext(1)]
	private UniTask CreateItemSafe(CommonQteItemBase item, string itemName)
	{
		CommonQteController.<CreateItemSafe>d__77 <CreateItemSafe>d__;
		<CreateItemSafe>d__.<>t__builder = AsyncUniTaskMethodBuilder.Create();
		<CreateItemSafe>d__.item = item;
		<CreateItemSafe>d__.itemName = itemName;
		<CreateItemSafe>d__.<>1__state = -1;
		<CreateItemSafe>d__.<>t__builder.Start<CommonQteController.<CreateItemSafe>d__77>(ref <CreateItemSafe>d__);
		return <CreateItemSafe>d__.<>t__builder.Task;
	}

	// Token: 0x1700195E RID: 6494
	// (get) Token: 0x06013D53 RID: 81235 RVA: 0x004F985F File Offset: 0x004F7A5F
	[Nullable(1)]
	public static CommonQteController Instance
	{
		[NullableContext(1)]
		get
		{
			return CommonQteController._Instance;
		}
	}

	// Token: 0x06013D54 RID: 81236 RVA: 0x004F9866 File Offset: 0x004F7A66
	[NullableContext(1)]
	public static CommonQteController GetOrCreateInstance()
	{
		if (CommonQteController._Instance == null)
		{
			CommonQteController.CreateInstance();
		}
		return CommonQteController._Instance;
	}

	// Token: 0x06013D55 RID: 81237 RVA: 0x004F987A File Offset: 0x004F7A7A
	public static bool CreateInstance()
	{
		if (CommonQteController._Instance != null)
		{
			return true;
		}
		CommonQteController._Instance = new CommonQteController();
		return true;
	}

	// Token: 0x06013D56 RID: 81238 RVA: 0x004F9890 File Offset: 0x004F7A90
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06013D57 RID: 81239 RVA: 0x004F9892 File Offset: 0x004F7A92
	public static void ResetStaticDefaultValue()
	{
		CommonQteController._Instance = null;
	}

	// Token: 0x06013D58 RID: 81240 RVA: 0x004F989A File Offset: 0x004F7A9A
	static CommonQteController()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CommonQteController.CreateStaticDefaultValue), new Action(CommonQteController.ResetStaticDefaultValue));
	}

	// Token: 0x04009555 RID: 38229
	private const int EXTRA_EXPIRED_TIME = 5000;

	// Token: 0x04009556 RID: 38230
	private const int MAX_EXPIRED_TIME = 60000;

	// Token: 0x04009557 RID: 38231
	private CommonQteContextBase Context;

	// Token: 0x04009558 RID: 38232
	private bool IsInQteInternal;

	// Token: 0x04009559 RID: 38233
	private bool IsHideAllBattleUi;

	// Token: 0x0400955A RID: 38234
	private List<int> HideBattleUiChildren;

	// Token: 0x0400955B RID: 38235
	private TimerHandle ExpiredTimer;

	// Token: 0x0400955C RID: 38236
	private bool IsPreloadingQte;

	// Token: 0x0400955D RID: 38237
	[Nullable(new byte[]
	{
		1,
		2
	})]
	private readonly Dictionary<EUiViewName, CommonQteViewBase> CommonQteViewMap = new Dictionary<EUiViewName, CommonQteViewBase>();

	// Token: 0x0400955E RID: 38238
	[Nullable(1)]
	private readonly Dictionary<int, CommonQteItemBase> CommonQteItemMap = new Dictionary<int, CommonQteItemBase>();

	// Token: 0x0400955F RID: 38239
	private EUiViewName? FightInputBlockViewName;

	// Token: 0x04009560 RID: 38240
	private EUiViewName? ShowMouseCursorName;

	// Token: 0x04009561 RID: 38241
	private bool IsSetQteTimeDilation;

	// Token: 0x04009562 RID: 38242
	private EQteScreenEffectType ScreenEffectType;

	// Token: 0x04009563 RID: 38243
	private EffectScreenPlayData_C ScreenEffect;

	// Token: 0x04009564 RID: 38244
	private int ScreenEffectHandle = -1;

	// Token: 0x04009565 RID: 38245
	private TimerHandle ScreenEffectTimer;

	// Token: 0x04009566 RID: 38246
	private UMatineeCameraShake CameraShake;

	// Token: 0x04009567 RID: 38247
	private TimerHandle CameraShakeTimer;

	// Token: 0x04009568 RID: 38248
	public Dictionary<EUiViewName, CommonQteViewBase> CommonQteViewMapDebug;

	// Token: 0x04009569 RID: 38249
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, CommonQteItemBase> CommonQteItemMapDebug;

	// Token: 0x0400956A RID: 38250
	private bool IsSelfTriggeringTimeDilation;

	// Token: 0x0400956B RID: 38251
	[Nullable(1)]
	private readonly HashSet<int> TempHideCursorQteSet = new HashSet<int>
	{
		9035003,
		9035004,
		9035011,
		9035012,
		9035013,
		9035017,
		9035018
	};

	// Token: 0x0400956C RID: 38252
	private static CommonQteController _Instance;
}
