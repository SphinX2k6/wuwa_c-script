using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02001AF2 RID: 6898
[NullableContext(2)]
[Nullable(0)]
public class CommonQteGroupContext : CommonQteContextBase
{
	// Token: 0x06011255 RID: 70229 RVA: 0x005092A1 File Offset: 0x005074A1
	public CommonQteGroupContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.QteGroup);
	}

	// Token: 0x06011256 RID: 70230 RVA: 0x005092B8 File Offset: 0x005074B8
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

	// Token: 0x06011257 RID: 70231 RVA: 0x00509324 File Offset: 0x00507524
	public override SCommonQte GetConfig()
	{
		if (this.MainQteContext != null)
		{
			return this.MainQteContext.Config;
		}
		return this.Config;
	}

	// Token: 0x06011258 RID: 70232 RVA: 0x00509340 File Offset: 0x00507540
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

	// Token: 0x06011259 RID: 70233 RVA: 0x005093A0 File Offset: 0x005075A0
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

	// Token: 0x0601125A RID: 70234 RVA: 0x00509400 File Offset: 0x00507600
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

	// Token: 0x0601125B RID: 70235 RVA: 0x00509498 File Offset: 0x00507698
	public override bool CheckQteConditionAndDoSuccess()
	{
		if (this.CheckQteConditionMatch())
		{
			base.QteSuccess();
			return true;
		}
		return false;
	}

	// Token: 0x0601125C RID: 70236 RVA: 0x005094AB File Offset: 0x005076AB
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

	// Token: 0x0601125D RID: 70237 RVA: 0x005094D7 File Offset: 0x005076D7
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

	// Token: 0x040096D3 RID: 38611
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public Dictionary<int, CommonQteContextBase> ContextMap;

	// Token: 0x040096D4 RID: 38612
	public CommonQteContextBase MainQteContext;
}
