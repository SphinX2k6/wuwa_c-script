using System;
using System.Runtime.CompilerServices;
using Aki.Config;
using AkiClient.Game.Aki.Data.Qte;
using UnrealEngine;

// Token: 0x02001AED RID: 6893
[NullableContext(2)]
[Nullable(0)]
public abstract class CommonQteContextBase
{
	// Token: 0x060111C0 RID: 70080 RVA: 0x005066F6 File Offset: 0x005048F6
	public bool IsPending()
	{
		return this.State == EQteState.Pending;
	}

	// Token: 0x060111C1 RID: 70081 RVA: 0x00506701 File Offset: 0x00504901
	public bool IsPendingSuccess()
	{
		return this.State == EQteState.PendingSuccess;
	}

	// Token: 0x060111C2 RID: 70082 RVA: 0x0050670C File Offset: 0x0050490C
	public bool IsSuccess()
	{
		return this.State == EQteState.Success;
	}

	// Token: 0x060111C3 RID: 70083 RVA: 0x00506717 File Offset: 0x00504917
	public bool IsFail()
	{
		return this.State == EQteState.Fail;
	}

	// Token: 0x060111C4 RID: 70084 RVA: 0x00506722 File Offset: 0x00504922
	public bool IsInvalid()
	{
		return this.State == EQteState.Invalid;
	}

	// Token: 0x060111C5 RID: 70085 RVA: 0x00506730 File Offset: 0x00504930
	public bool IsActive()
	{
		int qteHandleId = CommonQteModel.Instance.GetQteHandleId();
		return this.HandleId == qteHandleId || this.GroupHandleId == qteHandleId;
	}

	// Token: 0x060111C6 RID: 70086 RVA: 0x0050675C File Offset: 0x0050495C
	public bool IsResponsible()
	{
		return this.IsActive() && this.IsPending();
	}

	// Token: 0x060111C7 RID: 70087 RVA: 0x0050676E File Offset: 0x0050496E
	public void Response()
	{
		this.OnResponse();
	}

	// Token: 0x060111C8 RID: 70088 RVA: 0x00506776 File Offset: 0x00504976
	protected virtual void OnResponse()
	{
	}

	// Token: 0x060111C9 RID: 70089 RVA: 0x00506778 File Offset: 0x00504978
	public void ResponseEnd()
	{
		this.OnResponseEnd();
	}

	// Token: 0x060111CA RID: 70090 RVA: 0x00506780 File Offset: 0x00504980
	protected virtual void OnResponseEnd()
	{
	}

	// Token: 0x060111CB RID: 70091 RVA: 0x00506782 File Offset: 0x00504982
	public void QtePendingSuccess()
	{
		if (this.State == EQteState.PendingSuccess)
		{
			return;
		}
		this.State = EQteState.PendingSuccess;
		this.OnQtePendingSuccess();
	}

	// Token: 0x060111CC RID: 70092 RVA: 0x0050679B File Offset: 0x0050499B
	protected virtual void OnQtePendingSuccess()
	{
	}

	// Token: 0x060111CD RID: 70093 RVA: 0x005067A0 File Offset: 0x005049A0
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

	// Token: 0x060111CE RID: 70094 RVA: 0x005067F8 File Offset: 0x005049F8
	protected virtual void OnQteSuccess()
	{
	}

	// Token: 0x060111CF RID: 70095 RVA: 0x005067FA File Offset: 0x005049FA
	public void SetQteSuccess()
	{
		if (this.PassTime < this.LeastDuration)
		{
			this.QtePendingSuccess();
			return;
		}
		this.QteSuccess();
	}

	// Token: 0x060111D0 RID: 70096 RVA: 0x00506818 File Offset: 0x00504A18
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

	// Token: 0x060111D1 RID: 70097 RVA: 0x00506870 File Offset: 0x00504A70
	protected virtual void OnQteFail()
	{
	}

	// Token: 0x060111D2 RID: 70098 RVA: 0x00506872 File Offset: 0x00504A72
	public void UpdateTime(float delta)
	{
		this.OnUpdateTime(delta);
	}

	// Token: 0x060111D3 RID: 70099 RVA: 0x0050687B File Offset: 0x00504A7B
	protected virtual void OnUpdateTime(float delta)
	{
	}

	// Token: 0x060111D4 RID: 70100 RVA: 0x0050687D File Offset: 0x00504A7D
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

	// Token: 0x060111D5 RID: 70101 RVA: 0x005068B6 File Offset: 0x00504AB6
	protected virtual void OnClear()
	{
	}

	// Token: 0x060111D6 RID: 70102 RVA: 0x005068B8 File Offset: 0x00504AB8
	public virtual SCommonQte GetConfig()
	{
		return this.Config;
	}

	// Token: 0x060111D7 RID: 70103 RVA: 0x005068C0 File Offset: 0x00504AC0
	public virtual string GetAction(int? index = null)
	{
		return this.OnGetAction(index);
	}

	// Token: 0x060111D8 RID: 70104 RVA: 0x005068C9 File Offset: 0x00504AC9
	protected virtual string OnGetAction(int? index = null)
	{
		return null;
	}

	// Token: 0x060111D9 RID: 70105 RVA: 0x005068CC File Offset: 0x00504ACC
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

	// Token: 0x060111DA RID: 70106 RVA: 0x0050693C File Offset: 0x00504B3C
	[NullableContext(1)]
	protected virtual void OnSetConfig(SCommonQte config)
	{
	}

	// Token: 0x060111DB RID: 70107 RVA: 0x00506940 File Offset: 0x00504B40
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

	// Token: 0x060111DC RID: 70108 RVA: 0x005069A8 File Offset: 0x00504BA8
	[NullableContext(1)]
	protected virtual void OnSetGroupConfig(SCommonQteGroup config)
	{
	}

	// Token: 0x060111DD RID: 70109 RVA: 0x005069AA File Offset: 0x00504BAA
	public object GetUiConfig()
	{
		return this.OnGetUiConfig();
	}

	// Token: 0x060111DE RID: 70110 RVA: 0x005069B2 File Offset: 0x00504BB2
	protected virtual object OnGetUiConfig()
	{
		return null;
	}

	// Token: 0x060111DF RID: 70111 RVA: 0x005069B5 File Offset: 0x00504BB5
	protected virtual SCommonQteButton GetUiButtonConfig()
	{
		return null;
	}

	// Token: 0x060111E0 RID: 70112 RVA: 0x005069B8 File Offset: 0x00504BB8
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

	// Token: 0x060111E1 RID: 70113 RVA: 0x00506B08 File Offset: 0x00504D08
	public virtual bool ShouldShowMouseCursor()
	{
		SCommonQte config = this.Config;
		SCommonQte_Extra scommonQte_Extra = (config != null) ? config.ExtraConfig : null;
		return !(scommonQte_Extra == null) && scommonQte_Extra.ShowMouseCursor;
	}

	// Token: 0x060111E2 RID: 70114 RVA: 0x00506B3C File Offset: 0x00504D3C
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

	// Token: 0x060111E3 RID: 70115 RVA: 0x00506B89 File Offset: 0x00504D89
	public virtual bool CheckQteConditionMatch()
	{
		return false;
	}

	// Token: 0x060111E4 RID: 70116 RVA: 0x00506B8C File Offset: 0x00504D8C
	public bool CheckQteSuccessInTime(float toleranceTime)
	{
		return this.CheckSuccessTime != 0L && (float)(DateTimeOffset.Now.ToUnixTimeMilliseconds() - this.CheckSuccessTime) < toleranceTime;
	}

	// Token: 0x060111E5 RID: 70117 RVA: 0x00506BBB File Offset: 0x00504DBB
	public float GetRemainingTime()
	{
		return Math.Max(0f, this.Duration - this.PassTime);
	}

	// Token: 0x060111E6 RID: 70118 RVA: 0x00506BD4 File Offset: 0x00504DD4
	public float GetRemainingTimeProgress()
	{
		if (this.Duration <= 0f)
		{
			return 1f;
		}
		return this.GetRemainingTime() / this.Duration;
	}

	// Token: 0x060111E7 RID: 70119 RVA: 0x00506BF6 File Offset: 0x00504DF6
	public virtual float GetProgress()
	{
		return 0f;
	}

	// Token: 0x060111E8 RID: 70120 RVA: 0x00506BFD File Offset: 0x00504DFD
	public virtual bool IsAttachToActor()
	{
		return false;
	}

	// Token: 0x060111E9 RID: 70121 RVA: 0x00506C00 File Offset: 0x00504E00
	public virtual SCommonQte_Attach? GetAttachConfig()
	{
		return null;
	}

	// Token: 0x060111EA RID: 70122 RVA: 0x00506C16 File Offset: 0x00504E16
	public AActor GetAttachTarget()
	{
		IQteExtraParams extraParams = this.ExtraParams;
		if (extraParams == null)
		{
			return null;
		}
		return extraParams.AttachTarget;
	}

	// Token: 0x060111EB RID: 70123 RVA: 0x00506C2C File Offset: 0x00504E2C
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

	// Token: 0x060111EC RID: 70124 RVA: 0x00506CBC File Offset: 0x00504EBC
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

	// Token: 0x0400968D RID: 38541
	public ECommonQteContextType? Type;

	// Token: 0x0400968E RID: 38542
	public int HandleId = -1;

	// Token: 0x0400968F RID: 38543
	public int QteId;

	// Token: 0x04009690 RID: 38544
	public EQteSource? Source;

	// Token: 0x04009691 RID: 38545
	public EQteState State;

	// Token: 0x04009692 RID: 38546
	public SCommonQte Config;

	// Token: 0x04009693 RID: 38547
	public float Duration;

	// Token: 0x04009694 RID: 38548
	public float LeastDuration;

	// Token: 0x04009695 RID: 38549
	public float PassTime;

	// Token: 0x04009696 RID: 38550
	public bool IsPermanent;

	// Token: 0x04009697 RID: 38551
	public TCommonQteCallback SuccessCallback;

	// Token: 0x04009698 RID: 38552
	public TCommonQteCallback FailCallback;

	// Token: 0x04009699 RID: 38553
	public IQteExtraParams ExtraParams;

	// Token: 0x0400969A RID: 38554
	public IQteResource Resource;

	// Token: 0x0400969B RID: 38555
	public AActor UiActor;

	// Token: 0x0400969C RID: 38556
	public int AudioHandle;

	// Token: 0x0400969D RID: 38557
	public int GroupHandleId = -1;

	// Token: 0x0400969E RID: 38558
	public int QteGroupId;

	// Token: 0x0400969F RID: 38559
	public SCommonQteGroup GroupConfig;

	// Token: 0x040096A0 RID: 38560
	public CommonQteGroupContext GroupContext;

	// Token: 0x040096A1 RID: 38561
	public long CheckSuccessTime;
}
