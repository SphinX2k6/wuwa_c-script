using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x0200260B RID: 9739
[NullableContext(2)]
[Nullable(0)]
public class CommonQteSingleClickContext : CommonQteContextBase
{
	// Token: 0x06013DB9 RID: 81337 RVA: 0x004FC09C File Offset: 0x004FA29C
	public CommonQteSingleClickContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SingleButtonSingleClick);
	}

	// Token: 0x06013DBA RID: 81338 RVA: 0x004FC0B7 File Offset: 0x004FA2B7
	[NullableContext(1)]
	protected override void OnSetConfig(SCommonQte config)
	{
		this.TargetCount = 1;
	}

	// Token: 0x06013DBB RID: 81339 RVA: 0x004FC0C0 File Offset: 0x004FA2C0
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

	// Token: 0x06013DBC RID: 81340 RVA: 0x004FC114 File Offset: 0x004FA314
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

	// Token: 0x06013DBD RID: 81341 RVA: 0x004FC1A4 File Offset: 0x004FA3A4
	protected override string OnGetAction(int? index = null)
	{
		if (this.Config == null)
		{
			return null;
		}
		SCommonQteButton uiconfig = this.Config.BaseConfig.SingleClickConfig.UIConfig;
		return CommonQteContextBase.GetQteActionNameByActionId((uiconfig.ActionId > 0) ? uiconfig.ActionId : ((int)uiconfig.Action), new int?(this.QteId));
	}

	// Token: 0x06013DBE RID: 81342 RVA: 0x004FC203 File Offset: 0x004FA403
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_SingleClick OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.SingleClickConfig;
	}

	// Token: 0x06013DBF RID: 81343 RVA: 0x004FC225 File Offset: 0x004FA425
	protected override SCommonQteButton GetUiButtonConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.SingleClickConfig.UIConfig;
	}

	// Token: 0x06013DC0 RID: 81344 RVA: 0x004FC24C File Offset: 0x004FA44C
	public override bool CheckQteConditionMatch()
	{
		return this.ResponseCount >= this.TargetCount;
	}

	// Token: 0x06013DC1 RID: 81345 RVA: 0x004FC25F File Offset: 0x004FA45F
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.SingleClickConfig.IsAttachToActor;
	}

	// Token: 0x06013DC2 RID: 81346 RVA: 0x004FC27C File Offset: 0x004FA47C
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.SingleClickConfig.AttachConfig);
	}

	// Token: 0x0400959C RID: 38300
	public int ResponseCount;

	// Token: 0x0400959D RID: 38301
	public int TargetCount = -1;
}
