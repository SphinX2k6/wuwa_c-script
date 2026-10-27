using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02002607 RID: 9735
[NullableContext(2)]
[Nullable(0)]
public class CommonQteGroupContext : CommonQteContextBase
{
	// Token: 0x06013D73 RID: 81267 RVA: 0x004FA495 File Offset: 0x004F8695
	public CommonQteGroupContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.QteGroup);
	}

	// Token: 0x06013D74 RID: 81268 RVA: 0x004FA4AC File Offset: 0x004F86AC
	protected override void OnClear()
	{
		if (this.ContextMap != null)
		{
			foreach (CommonQteContextBase commonQteContextBase in this.ContextMap.Values)
			{
				commonQteContextBase.Clear();
			}
			this.ContextMap = null;
		}
		this.MainQteContext = null;
	}

	// Token: 0x06013D75 RID: 81269 RVA: 0x004FA518 File Offset: 0x004F8718
	public override SCommonQte GetConfig()
	{
		if (this.MainQteContext != null)
		{
			return this.MainQteContext.Config;
		}
		return this.Config;
	}

	// Token: 0x06013D76 RID: 81270 RVA: 0x004FA534 File Offset: 0x004F8734
	protected override void OnQteSuccess()
	{
		if (this.ContextMap != null)
		{
			foreach (CommonQteContextBase commonQteContextBase in this.ContextMap.Values)
			{
				commonQteContextBase.QteSuccess();
			}
		}
	}

	// Token: 0x06013D77 RID: 81271 RVA: 0x004FA594 File Offset: 0x004F8794
	protected override void OnQteFail()
	{
		if (this.ContextMap != null)
		{
			foreach (CommonQteContextBase commonQteContextBase in this.ContextMap.Values)
			{
				commonQteContextBase.QteFail();
			}
		}
	}

	// Token: 0x06013D78 RID: 81272 RVA: 0x004FA5F4 File Offset: 0x004F87F4
	public override bool CheckQteConditionMatch()
	{
		if (this.ContextMap == null)
		{
			return true;
		}
		bool result = true;
		SCommonQteGroup groupConfig = this.GroupConfig;
		float toleranceTime = ((groupConfig != null) ? groupConfig.ToleranceTime : 0f) * (float)TimeUtil.Instance.InverseMillisecond;
		foreach (CommonQteContextBase commonQteContextBase in this.ContextMap.Values)
		{
			if (!commonQteContextBase.CheckQteConditionMatch() || !commonQteContextBase.CheckQteSuccessInTime(toleranceTime))
			{
				result = false;
				break;
			}
		}
		return result;
	}

	// Token: 0x06013D79 RID: 81273 RVA: 0x004FA68C File Offset: 0x004F888C
	public override bool CheckQteConditionAndDoSuccess()
	{
		if (this.CheckQteConditionMatch())
		{
			base.QteSuccess();
			return true;
		}
		return false;
	}

	// Token: 0x06013D7A RID: 81274 RVA: 0x004FA69F File Offset: 0x004F889F
	[NullableContext(1)]
	public void AddContext(int qteId, CommonQteContextBase context, bool isMainQte)
	{
		if (this.ContextMap == null)
		{
			this.ContextMap = new Dictionary<int, CommonQteContextBase>();
		}
		this.ContextMap[qteId] = context;
		if (isMainQte)
		{
			this.MainQteContext = context;
		}
	}

	// Token: 0x06013D7B RID: 81275 RVA: 0x004FA6CB File Offset: 0x004F88CB
	public void OnContextFail(CommonQteContextBase context)
	{
		if (base.IsPending() && context != null)
		{
			Dictionary<int, CommonQteContextBase> contextMap = this.ContextMap;
			if (contextMap != null && contextMap.ContainsKey(context.QteId))
			{
				base.QteFail();
			}
		}
	}

	// Token: 0x0400957C RID: 38268
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, CommonQteContextBase> ContextMap;

	// Token: 0x0400957D RID: 38269
	public CommonQteContextBase MainQteContext;
}
