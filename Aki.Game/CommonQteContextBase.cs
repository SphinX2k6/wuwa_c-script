using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Qte;
using UnrealEngine;

// Token: 0x02002602 RID: 9730
[NullableContext(2)]
[Nullable(0)]
public abstract class CommonQteContextBase
{
	// Token: 0x06013CDE RID: 81118 RVA: 0x004F791A File Offset: 0x004F5B1A
	public bool IsPending()
	{
		return this.State == EQteState.Pending;
	}

	// Token: 0x06013CDF RID: 81119 RVA: 0x004F7925 File Offset: 0x004F5B25
	public bool IsPendingSuccess()
	{
		return this.State == EQteState.PendingSuccess;
	}

	// Token: 0x06013CE0 RID: 81120 RVA: 0x004F7930 File Offset: 0x004F5B30
	public bool IsSuccess()
	{
		return this.State == EQteState.Success;
	}

	// Token: 0x06013CE1 RID: 81121 RVA: 0x004F793B File Offset: 0x004F5B3B
	public bool IsFail()
	{
		return this.State == EQteState.Fail;
	}

	// Token: 0x06013CE2 RID: 81122 RVA: 0x004F7946 File Offset: 0x004F5B46
	public bool IsInvalid()
	{
		return this.State == EQteState.Invalid;
	}

	// Token: 0x06013CE3 RID: 81123 RVA: 0x004F7954 File Offset: 0x004F5B54
	public bool IsActive()
	{
		int qteHandleId = CommonQteModel.Instance.GetQteHandleId();
		return this.HandleId == qteHandleId || this.GroupHandleId == qteHandleId;
	}

	// Token: 0x06013CE4 RID: 81124 RVA: 0x004F7980 File Offset: 0x004F5B80
	public bool IsResponsible()
	{
		return this.IsActive() && this.IsPending();
	}

	// Token: 0x06013CE5 RID: 81125 RVA: 0x004F7992 File Offset: 0x004F5B92
	public void Response()
	{
		this.OnResponse();
	}

	// Token: 0x06013CE6 RID: 81126 RVA: 0x004F799A File Offset: 0x004F5B9A
	protected virtual void OnResponse()
	{
	}

	// Token: 0x06013CE7 RID: 81127 RVA: 0x004F799C File Offset: 0x004F5B9C
	public void ResponseEnd()
	{
		this.OnResponseEnd();
	}

	// Token: 0x06013CE8 RID: 81128 RVA: 0x004F79A4 File Offset: 0x004F5BA4
	protected virtual void OnResponseEnd()
	{
	}

	// Token: 0x06013CE9 RID: 81129 RVA: 0x004F79A6 File Offset: 0x004F5BA6
	public void QtePendingSuccess()
	{
		if (this.State == EQteState.PendingSuccess)
		{
			return;
		}
		this.State = EQteState.PendingSuccess;
		this.OnQtePendingSuccess();
	}

	// Token: 0x06013CEA RID: 81130 RVA: 0x004F79BF File Offset: 0x004F5BBF
	protected virtual void OnQtePendingSuccess()
	{
	}

	// Token: 0x06013CEB RID: 81131 RVA: 0x004F79C4 File Offset: 0x004F5BC4
	public void QteSuccess()
	{
		if (this.State == EQteState.Success)
		{
			return;
		}
		this.State = EQteState.Success;
		this.OnQteSuccess();
		if (this.SuccessCallback != null)
		{
			this.SuccessCallback(this);
		}
		this.SuccessCallback = null;
		if (this.GroupHandleId == -1)
		{
			CommonQteController.Instance.StopQte(this.HandleId);
		}
	}

	// Token: 0x06013CEC RID: 81132 RVA: 0x004F7A1C File Offset: 0x004F5C1C
	protected virtual void OnQteSuccess()
	{
	}

	// Token: 0x06013CED RID: 81133 RVA: 0x004F7A1E File Offset: 0x004F5C1E
	public void SetQteSuccess()
	{
		if (this.PassTime < this.LeastDuration)
		{
			this.QtePendingSuccess();
			return;
		}
		this.QteSuccess();
	}

	// Token: 0x06013CEE RID: 81134 RVA: 0x004F7A3C File Offset: 0x004F5C3C
	public void QteFail()
	{
		if (this.State == EQteState.Fail)
		{
			return;
		}
		this.State = EQteState.Fail;
		this.OnQteFail();
		if (this.FailCallback != null)
		{
			this.FailCallback(this);
		}
		this.FailCallback = null;
		if (this.GroupHandleId == -1)
		{
			CommonQteController.Instance.StopQte(this.HandleId);
		}
	}

	// Token: 0x06013CEF RID: 81135 RVA: 0x004F7A94 File Offset: 0x004F5C94
	protected virtual void OnQteFail()
	{
	}

	// Token: 0x06013CF0 RID: 81136 RVA: 0x004F7A96 File Offset: 0x004F5C96
	public void UpdateTime(float delta)
	{
		this.OnUpdateTime(delta);
	}

	// Token: 0x06013CF1 RID: 81137 RVA: 0x004F7A9F File Offset: 0x004F5C9F
	protected virtual void OnUpdateTime(float delta)
	{
	}

	// Token: 0x06013CF2 RID: 81138 RVA: 0x004F7AA1 File Offset: 0x004F5CA1
	public void Clear()
	{
		if (this.IsPending())
		{
			this.State = EQteState.Invalid;
		}
		this.OnResponseEnd();
		this.OnClear();
		this.SuccessCallback = null;
		this.FailCallback = null;
		this.Resource = null;
		this.UiActor = null;
	}

	// Token: 0x06013CF3 RID: 81139 RVA: 0x004F7ADA File Offset: 0x004F5CDA
	protected virtual void OnClear()
	{
	}

	// Token: 0x06013CF4 RID: 81140 RVA: 0x004F7ADC File Offset: 0x004F5CDC
	public virtual SCommonQte GetConfig()
	{
		return this.Config;
	}

	// Token: 0x06013CF5 RID: 81141 RVA: 0x004F7AE4 File Offset: 0x004F5CE4
	public virtual string GetAction(int? index = null)
	{
		return this.OnGetAction(index);
	}

	// Token: 0x06013CF6 RID: 81142 RVA: 0x004F7AED File Offset: 0x004F5CED
	protected virtual string OnGetAction(int? index = null)
	{
		return null;
	}

	// Token: 0x06013CF7 RID: 81143 RVA: 0x004F7AF0 File Offset: 0x004F5CF0
	[NullableContext(1)]
	public void SetConfig(SCommonQte config)
	{
		this.Config = config;
		if (config.BaseConfig.Duration < 0f)
		{
			this.IsPermanent = true;
		}
		else
		{
			this.Duration = config.BaseConfig.Duration * (float)TimeUtil.Instance.InverseMillisecond;
		}
		this.LeastDuration = config.BaseConfig.LeastDuration * (float)TimeUtil.Instance.InverseMillisecond;
		this.OnSetConfig(config);
	}

	// Token: 0x06013CF8 RID: 81144 RVA: 0x004F7B60 File Offset: 0x004F5D60
	[NullableContext(1)]
	protected virtual void OnSetConfig(SCommonQte config)
	{
	}

	// Token: 0x06013CF9 RID: 81145 RVA: 0x004F7B64 File Offset: 0x004F5D64
	[NullableContext(1)]
	public void SetGroupConfig(SCommonQteGroup groupConfig)
	{
		this.GroupConfig = groupConfig;
		if (groupConfig.Duration < 0f)
		{
			this.IsPermanent = true;
		}
		else
		{
			this.IsPermanent = false;
			this.Duration = groupConfig.Duration * (float)TimeUtil.Instance.InverseMillisecond;
		}
		this.LeastDuration = groupConfig.LeastDuration * (float)TimeUtil.Instance.InverseMillisecond;
		this.OnSetGroupConfig(groupConfig);
	}

	// Token: 0x06013CFA RID: 81146 RVA: 0x004F7BCC File Offset: 0x004F5DCC
	[NullableContext(1)]
	protected virtual void OnSetGroupConfig(SCommonQteGroup config)
	{
	}

	// Token: 0x06013CFB RID: 81147 RVA: 0x004F7BCE File Offset: 0x004F5DCE
	public object GetUiConfig()
	{
		return this.OnGetUiConfig();
	}

	// Token: 0x06013CFC RID: 81148 RVA: 0x004F7BD6 File Offset: 0x004F5DD6
	protected virtual object OnGetUiConfig()
	{
		return null;
	}

	// Token: 0x06013CFD RID: 81149 RVA: 0x004F7BD9 File Offset: 0x004F5DD9
	protected virtual SCommonQteButton GetUiButtonConfig()
	{
		return null;
	}

	// Token: 0x06013CFE RID: 81150 RVA: 0x004F7BDC File Offset: 0x004F5DDC
	public unsafe virtual bool VerifyConfig()
	{
		SCommonQteButton uiButtonConfig = this.GetUiButtonConfig();
		if (uiButtonConfig == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonQte;
			ELogAuthor author = ELogAuthor.HYJ;
			string message = "通用Qte触发失败 没有button config";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("HandleId", this.HandleId);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("Id", this.QteId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return false;
		}
		int? qteActionTypeByActionId = CommonQteContextBase.GetQteActionTypeByActionId((uiButtonConfig.ActionId > 0) ? uiButtonConfig.ActionId : ((int)uiButtonConfig.Action), new int?(this.QteId));
		int num = (int)uiButtonConfig.ActionType;
		if (num != 0)
		{
			int? num2 = qteActionTypeByActionId;
			int num3 = num;
			if (!(num2.GetValueOrDefault() == num3 & num2 != null))
			{
				Log instance2 = Log.Instance;
				ELogModule module2 = ELogModule.CommonQte;
				ELogAuthor author2 = ELogAuthor.HYJ;
				string message2 = "通用Qte触发失败 行为与行为类型不匹配";
				<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray2 = default(<>y__InlineArray2<ValueTuple<string, object>>);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 0) = new ValueTuple<string, object>("HandleId", this.HandleId);
				*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray2, 1) = new ValueTuple<string, object>("Id", this.QteId);
				instance2.Error(module2, author2, message2, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray2, 2));
				return false;
			}
		}
		return true;
	}

	// Token: 0x06013CFF RID: 81151 RVA: 0x004F7D2C File Offset: 0x004F5F2C
	public virtual bool ShouldShowMouseCursor()
	{
		SCommonQte config = this.Config;
		SCommonQte_Extra scommonQte_Extra = (config != null) ? config.ExtraConfig : null;
		return !(scommonQte_Extra == null) && scommonQte_Extra.ShowMouseCursor;
	}

	// Token: 0x06013D00 RID: 81152 RVA: 0x004F7D60 File Offset: 0x004F5F60
	public virtual bool CheckQteConditionAndDoSuccess()
	{
		if (this.CheckQteConditionMatch())
		{
			if (this.GroupContext != null)
			{
				this.CheckSuccessTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
				CommonQteGroupContext groupContext = this.GroupContext;
				if (groupContext != null)
				{
					groupContext.CheckQteConditionAndDoSuccess();
				}
			}
			else
			{
				this.SetQteSuccess();
			}
			return true;
		}
		return false;
	}

	// Token: 0x06013D01 RID: 81153 RVA: 0x004F7DAD File Offset: 0x004F5FAD
	public virtual bool CheckQteConditionMatch()
	{
		return false;
	}

	// Token: 0x06013D02 RID: 81154 RVA: 0x004F7DB0 File Offset: 0x004F5FB0
	public bool CheckQteSuccessInTime(float toleranceTime)
	{
		return this.CheckSuccessTime != 0L && (float)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - this.CheckSuccessTime) < toleranceTime;
	}

	// Token: 0x06013D03 RID: 81155 RVA: 0x004F7DDF File Offset: 0x004F5FDF
	public float GetRemainingTime()
	{
		return Math.Max(0f, this.Duration - this.PassTime);
	}

	// Token: 0x06013D04 RID: 81156 RVA: 0x004F7DF8 File Offset: 0x004F5FF8
	public float GetRemainingTimeProgress()
	{
		if (this.Duration <= 0f)
		{
			return 1f;
		}
		return this.GetRemainingTime() / this.Duration;
	}

	// Token: 0x06013D05 RID: 81157 RVA: 0x004F7E1A File Offset: 0x004F601A
	public virtual float GetProgress()
	{
		return 0f;
	}

	// Token: 0x06013D06 RID: 81158 RVA: 0x004F7E21 File Offset: 0x004F6021
	public virtual bool IsAttachToActor()
	{
		return false;
	}

	// Token: 0x06013D07 RID: 81159 RVA: 0x004F7E24 File Offset: 0x004F6024
	public virtual SCommonQte_Attach? GetAttachConfig()
	{
		return null;
	}

	// Token: 0x06013D08 RID: 81160 RVA: 0x004F7E3A File Offset: 0x004F603A
	public AActor GetAttachTarget()
	{
		IQteExtraParams extraParams = this.ExtraParams;
		if (extraParams == null)
		{
			return null;
		}
		return extraParams.AttachTarget;
	}

	// Token: 0x06013D09 RID: 81161 RVA: 0x004F7E50 File Offset: 0x004F6050
	public unsafe static string GetQteActionNameByActionId(int action, int? qteId = null)
	{
		QteInputActionMapping? config = ConfigQteInputActionMappingByQteInputActionId.GetConfig(action, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonQte;
			ELogAuthor author = ELogAuthor.HYJ;
			string message = "QTE输入行为映射不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("action", action);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("QteId", qteId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return config.Value.QteInputActionName;
	}

	// Token: 0x06013D0A RID: 81162 RVA: 0x004F7EE0 File Offset: 0x004F60E0
	public unsafe static int? GetQteActionTypeByActionId(int action, int? qteId = null)
	{
		QteInputActionMapping? config = ConfigQteInputActionMappingByQteInputActionId.GetConfig(action, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonQte;
			ELogAuthor author = ELogAuthor.HYJ;
			string message = "QTE输入行为映射不存在";
			<>y__InlineArray2<ValueTuple<string, object>> <>y__InlineArray = default(<>y__InlineArray2<ValueTuple<string, object>>);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 0) = new ValueTuple<string, object>("action", action);
			*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(ref <>y__InlineArray, 1) = new ValueTuple<string, object>("QteId", qteId);
			instance.Error(module, author, message, <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<ValueTuple<string, object>>, ValueTuple<string, object>>(<>y__InlineArray, 2));
			return null;
		}
		return new int?(config.Value.QteInputActionType);
	}

	// Token: 0x04009536 RID: 38198
	public ECommonQteContextType? Type;

	// Token: 0x04009537 RID: 38199
	public int HandleId = -1;

	// Token: 0x04009538 RID: 38200
	public int QteId;

	// Token: 0x04009539 RID: 38201
	public EQteSource? Source;

	// Token: 0x0400953A RID: 38202
	public EQteState State;

	// Token: 0x0400953B RID: 38203
	public SCommonQte Config;

	// Token: 0x0400953C RID: 38204
	public float Duration;

	// Token: 0x0400953D RID: 38205
	public float LeastDuration;

	// Token: 0x0400953E RID: 38206
	public float PassTime;

	// Token: 0x0400953F RID: 38207
	public bool IsPermanent;

	// Token: 0x04009540 RID: 38208
	public TCommonQteCallback SuccessCallback;

	// Token: 0x04009541 RID: 38209
	public TCommonQteCallback FailCallback;

	// Token: 0x04009542 RID: 38210
	public IQteExtraParams ExtraParams;

	// Token: 0x04009543 RID: 38211
	public IQteResource Resource;

	// Token: 0x04009544 RID: 38212
	public AActor UiActor;

	// Token: 0x04009545 RID: 38213
	public int AudioHandle;

	// Token: 0x04009546 RID: 38214
	public int GroupHandleId = -1;

	// Token: 0x04009547 RID: 38215
	public int QteGroupId;

	// Token: 0x04009548 RID: 38216
	public SCommonQteGroup GroupConfig;

	// Token: 0x04009549 RID: 38217
	public CommonQteGroupContext GroupContext;

	// Token: 0x0400954A RID: 38218
	public long CheckSuccessTime;
}
