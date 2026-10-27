using System;
using System.Runtime.CompilerServices;

// Token: 0x02001828 RID: 6184
public class FeatureRestrictionTemplate : IStaticVariableResetter
{
	// Token: 0x0600B56E RID: 46446 RVA: 0x0028FA13 File Offset: 0x0028DC13
	static FeatureRestrictionTemplate()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FeatureRestrictionTemplate.CreateStaticDefaultValue), new Action(FeatureRestrictionTemplate.ResetStaticDefaultValue));
	}

	// Token: 0x0600B56F RID: 46447 RVA: 0x0028FA32 File Offset: 0x0028DC32
	private FeatureRestrictionTemplate(EFeatureParseMode parseMode, EForceMode forceMode = EForceMode.None)
	{
		this.ParseMode = parseMode;
		this.ForceMode = forceMode;
	}

	// Token: 0x0600B570 RID: 46448 RVA: 0x0028FA4F File Offset: 0x0028DC4F
	private void AddClientMask(EClientFeature mask)
	{
		this.ClientFeatureMasks |= (int)mask;
	}

	// Token: 0x0600B571 RID: 46449 RVA: 0x0028FA5F File Offset: 0x0028DC5F
	private bool CheckByMask(int current, int mask)
	{
		return (current & mask) == mask;
	}

	// Token: 0x0600B572 RID: 46450 RVA: 0x0028FA68 File Offset: 0x0028DC68
	private int ParseCurrentClient()
	{
		int num = 0;
		CommonConfig instance = CommonConfig.Instance;
		if (instance != null && instance.GetPioneerFlag().GetValueOrDefault())
		{
			num |= 8;
		}
		return num;
	}

	// Token: 0x0600B573 RID: 46451 RVA: 0x0028FA97 File Offset: 0x0028DC97
	private int ParseCurrentServer()
	{
		return 0 | 0;
	}

	// Token: 0x0600B574 RID: 46452 RVA: 0x0028FA9C File Offset: 0x0028DC9C
	public bool Check()
	{
		EForceMode forceMode = this.ForceMode;
		if (forceMode == EForceMode.White)
		{
			return true;
		}
		if (forceMode == EForceMode.Black)
		{
			return false;
		}
		switch (this.ParseMode)
		{
		case EFeatureParseMode.ClientOnly:
			return this.CheckByMask(this.ParseCurrentClient(), this.ClientFeatureMasks);
		case EFeatureParseMode.ServerOnly:
			return this.CheckByMask(this.ParseCurrentServer(), this.ServerFeatureMasks);
		case EFeatureParseMode.All:
			return this.CheckByMask(this.ParseCurrentClient(), this.ClientFeatureMasks) && this.CheckByMask(this.ParseCurrentServer(), this.ServerFeatureMasks);
		default:
			return false;
		}
	}

	// Token: 0x17000F2A RID: 3882
	// (get) Token: 0x0600B575 RID: 46453 RVA: 0x0028FB29 File Offset: 0x0028DD29
	[Nullable(1)]
	public static FeatureRestrictionTemplate TemplateForPioneerClient
	{
		[NullableContext(1)]
		get
		{
			if (FeatureRestrictionTemplate.TemplateForPioneerClientCore != null)
			{
				return FeatureRestrictionTemplate.TemplateForPioneerClientCore;
			}
			FeatureRestrictionTemplate featureRestrictionTemplate = new FeatureRestrictionTemplate(EFeatureParseMode.ClientOnly, EForceMode.None);
			featureRestrictionTemplate.AddClientMask(EClientFeature.Pioneer);
			FeatureRestrictionTemplate.TemplateForPioneerClientCore = featureRestrictionTemplate;
			return featureRestrictionTemplate;
		}
	}

	// Token: 0x0600B576 RID: 46454 RVA: 0x0028FB4C File Offset: 0x0028DD4C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B577 RID: 46455 RVA: 0x0028FB4E File Offset: 0x0028DD4E
	public static void ResetStaticDefaultValue()
	{
		FeatureRestrictionTemplate.TemplateForPioneerClientCore = null;
	}

	// Token: 0x04005201 RID: 20993
	private int ClientFeatureMasks;

	// Token: 0x04005202 RID: 20994
	private readonly int ServerFeatureMasks;

	// Token: 0x04005203 RID: 20995
	private readonly EFeatureParseMode ParseMode = EFeatureParseMode.All;

	// Token: 0x04005204 RID: 20996
	private readonly EForceMode ForceMode;

	// Token: 0x04005205 RID: 20997
	[Nullable(2)]
	private static FeatureRestrictionTemplate TemplateForPioneerClientCore;
}
