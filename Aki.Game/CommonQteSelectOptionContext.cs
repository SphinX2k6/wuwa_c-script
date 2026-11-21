using System;
using System.Runtime.CompilerServices;
using AkiClient.Game.Aki.Data.Qte;

// Token: 0x02001AF5 RID: 6901
[NullableContext(2)]
[Nullable(0)]
public class CommonQteSelectOptionContext : CommonQteContextBase
{
	// Token: 0x0601128F RID: 70287 RVA: 0x0050AC6E File Offset: 0x00508E6E
	public CommonQteSelectOptionContext()
	{
		this.Type = new ECommonQteContextType?(ECommonQteContextType.SelectOption);
	}

	// Token: 0x06011290 RID: 70288 RVA: 0x0050AC97 File Offset: 0x00508E97
	[NullableContext(1)]
	protected override void OnSetConfig(SCommonQte config)
	{
		this.TargetCount = 1;
		this.DefaultOption = config.BaseConfig.SelectOptionConfig.DefaultOption;
	}

	// Token: 0x06011291 RID: 70289 RVA: 0x0050ACB8 File Offset: 0x00508EB8
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

	// Token: 0x06011292 RID: 70290 RVA: 0x0050AD1E File Offset: 0x00508F1E
	protected override void OnQteFail()
	{
		this.SelectOption = this.DefaultOption;
	}

	// Token: 0x06011293 RID: 70291 RVA: 0x0050AD2C File Offset: 0x00508F2C
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

	// Token: 0x06011294 RID: 70292 RVA: 0x0050ADD4 File Offset: 0x00508FD4
	public override string GetAction(int? index = null)
	{
		return this.OnGetAction(index);
	}

	// Token: 0x06011295 RID: 70293 RVA: 0x0050ADE0 File Offset: 0x00508FE0
	protected override string OnGetAction(int? index)
	{
		if (this.Config == null)
		{
			return null;
		}
		SCommonQteButton scommonQteButton = this.Config.BaseConfig.SelectOptionConfig.UIConfigList.Get(index.GetValueOrDefault());
		return CommonQteContextBase.GetQteActionNameByActionId((scommonQteButton.ActionId > 0) ? scommonQteButton.ActionId : ((int)scommonQteButton.Action), new int?(this.QteId));
	}

	// Token: 0x06011296 RID: 70294 RVA: 0x0050AE4B File Offset: 0x0050904B
	[PreserveBaseOverrides]
	protected new virtual SCommonQte_SelectOption OnGetUiConfig()
	{
		if (this.Config == null)
		{
			return null;
		}
		return this.Config.BaseConfig.SelectOptionConfig;
	}

	// Token: 0x06011297 RID: 70295 RVA: 0x0050AE6D File Offset: 0x0050906D
	public override bool CheckQteConditionMatch()
	{
		return this.ResponseCount >= this.TargetCount;
	}

	// Token: 0x06011298 RID: 70296 RVA: 0x0050AE80 File Offset: 0x00509080
	public override bool IsAttachToActor()
	{
		SCommonQte config = this.Config;
		return config != null && config.BaseConfig.SelectOptionConfig.IsAttachToActor;
	}

	// Token: 0x06011299 RID: 70297 RVA: 0x0050AEA0 File Offset: 0x005090A0
	public override SCommonQte_Attach? GetAttachConfig()
	{
		SCommonQte config = this.Config;
		if (config == null)
		{
			return null;
		}
		return new SCommonQte_Attach?(config.BaseConfig.SelectOptionConfig.AttachConfig);
	}

	// Token: 0x0601129A RID: 70298 RVA: 0x0050AED5 File Offset: 0x005090D5
	public override bool VerifyConfig()
	{
		return true;
	}

	// Token: 0x040096EF RID: 38639
	public int ResponseCount;

	// Token: 0x040096F0 RID: 38640
	public int TargetCount = -1;

	// Token: 0x040096F1 RID: 38641
	public int SelectOption = -1;

	// Token: 0x040096F2 RID: 38642
	public int DefaultOption = -1;
}
