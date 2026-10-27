using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x0200260A RID: 9738
[NullableContext(2)]
[Nullable(0)]
public class CommonQteSelectOptionContext : CommonQteContextBase
{
	// Token: 0x06013DAD RID: 81325 RVA: 0x004FBE32 File Offset: 0x004FA032
	public CommonQteSelectOptionContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SelectOption);
	}

	// Token: 0x06013DAE RID: 81326 RVA: 0x004FBE5B File Offset: 0x004FA05B
	[NullableContext(1)]
	protected override void OnSetConfig(SCommonQte config)
	{
		this.TargetCount = 1;
		this.DefaultOption = config.BaseConfig.SelectOptionConfig.DefaultOption;
	}

	// Token: 0x06013DAF RID: 81327 RVA: 0x004FBE7C File Offset: 0x004FA07C
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
			this.ResponseCount++;
		}
		if (this.CheckQteConditionMatch())
		{
			if (this.PassTime < this.LeastDuration)
			{
				base.QtePendingSuccess();
				return;
			}
			base.QteSuccess();
		}
	}

	// Token: 0x06013DB0 RID: 81328 RVA: 0x004FBEE2 File Offset: 0x004FA0E2
	protected override void OnQteFail()
	{
		this.SelectOption = this.DefaultOption;
	}

	// Token: 0x06013DB1 RID: 81329 RVA: 0x004FBEF0 File Offset: 0x004FA0F0
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
		if (!this.CheckQteConditionMatch())
		{
			if (!this.IsPermanent && this.PassTime > this.Duration)
			{
				base.QteFail();
			}
			return;
		}
		if (this.PassTime < this.LeastDuration)
		{
			base.QtePendingSuccess();
			return;
		}
		base.QteSuccess();
	}

	// Token: 0x06013DB2 RID: 81330 RVA: 0x004FBF98 File Offset: 0x004FA198
	public override string GetAction(int? index = null)
	{
		return this.OnGetAction(index);
	}

	// Token: 0x06013DB3 RID: 81331 RVA: 0x004FBFA4 File Offset: 0x004FA1A4
	protected override string OnGetAction(int? index)
	{
		if (this.Config == null)
		{
			return null;
		}
		SCommonQteButton scommonQteButton = this.Config.BaseConfig.SelectOptionConfig.UIConfigList.Get(index.GetValueOrDefault());
		return CommonQteContextBase.GetQteActionNameByActionId((scommonQteButton.ActionId > 0) ? scommonQteButton.ActionId : ((int)scommonQteButton.Action), new int?(this.QteId));
	}

	// Token: 0x06013DB4 RID: 81332 RVA: 0x004FC00F File Offset: 0x004FA20F
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_SelectOption OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.SelectOptionConfig;
	}

	// Token: 0x06013DB5 RID: 81333 RVA: 0x004FC031 File Offset: 0x004FA231
	public override bool CheckQteConditionMatch()
	{
		return this.ResponseCount >= this.TargetCount;
	}

	// Token: 0x06013DB6 RID: 81334 RVA: 0x004FC044 File Offset: 0x004FA244
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.SelectOptionConfig.IsAttachToActor;
	}

	// Token: 0x06013DB7 RID: 81335 RVA: 0x004FC064 File Offset: 0x004FA264
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.SelectOptionConfig.AttachConfig);
	}

	// Token: 0x06013DB8 RID: 81336 RVA: 0x004FC099 File Offset: 0x004FA299
	public override bool VerifyConfig()
	{
		return true;
	}

	// Token: 0x04009598 RID: 38296
	public int ResponseCount;

	// Token: 0x04009599 RID: 38297
	public int TargetCount = -1;

	// Token: 0x0400959A RID: 38298
	public int SelectOption = -1;

	// Token: 0x0400959B RID: 38299
	public int DefaultOption = -1;
}
