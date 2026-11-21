using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02001AF6 RID: 6902
[NullableContext(2)]
[Nullable(0)]
public class CommonQteSingleClickContext : CommonQteContextBase
{
	// Token: 0x0601129B RID: 70299 RVA: 0x0050AED8 File Offset: 0x005090D8
	public CommonQteSingleClickContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SingleButtonSingleClick);
	}

	// Token: 0x0601129C RID: 70300 RVA: 0x0050AEF3 File Offset: 0x005090F3
	[NullableContext(1)]
	protected override void OnSetConfig(SCommonQte config)
	{
		this.TargetCount = 1;
	}

	// Token: 0x0601129D RID: 70301 RVA: 0x0050AEFC File Offset: 0x005090FC
	protected override void OnResponse()
	{
		if (this.Config == null)
		{
			return;
		}
		if (!base.IsPending() && !base.IsPendingSuccess())
		{
			return;
		}
		if (base.IsPending())
		{
			CommonQteController.Instance.PlayGamepadShake();
			this.ResponseCount++;
		}
		this.CheckQteConditionAndDoSuccess();
	}

	// Token: 0x0601129E RID: 70302 RVA: 0x0050AF50 File Offset: 0x00509150
	protected override void OnUpdateTime(float delta)
	{
		if (this.Config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CommonQte;
			ELogAuthor author = ELogAuthor.WWJ;
			string message = "Context中获取不到Config";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("QteId", this.QteId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			CommonQteController.Instance.StopCurrentQte();
			return;
		}
		this.PassTime += delta;
		if (this.CheckQteConditionAndDoSuccess())
		{
			return;
		}
		if (!this.IsPermanent && this.PassTime > this.Duration)
		{
			base.QteFail();
		}
	}

	// Token: 0x0601129F RID: 70303 RVA: 0x0050AFE0 File Offset: 0x005091E0
	protected override string OnGetAction(int? index = null)
	{
		if (this.Config == null)
		{
			return null;
		}
		SCommonQteButton uiconfig = this.Config.BaseConfig.SingleClickConfig.UIConfig;
		return CommonQteContextBase.GetQteActionNameByActionId((uiconfig.ActionId > 0) ? uiconfig.ActionId : ((int)uiconfig.Action), new int?(this.QteId));
	}

	// Token: 0x060112A0 RID: 70304 RVA: 0x0050B03F File Offset: 0x0050923F
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_SingleClick OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.SingleClickConfig;
	}

	// Token: 0x060112A1 RID: 70305 RVA: 0x0050B061 File Offset: 0x00509261
	protected override SCommonQteButton GetUiButtonConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.SingleClickConfig.UIConfig;
	}

	// Token: 0x060112A2 RID: 70306 RVA: 0x0050B088 File Offset: 0x00509288
	public override bool CheckQteConditionMatch()
	{
		return this.ResponseCount >= this.TargetCount;
	}

	// Token: 0x060112A3 RID: 70307 RVA: 0x0050B09B File Offset: 0x0050929B
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.SingleClickConfig.IsAttachToActor;
	}

	// Token: 0x060112A4 RID: 70308 RVA: 0x0050B0B8 File Offset: 0x005092B8
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.SingleClickConfig.AttachConfig);
	}

	// Token: 0x040096F3 RID: 38643
	public int ResponseCount;

	// Token: 0x040096F4 RID: 38644
	public int TargetCount = -1;
}
