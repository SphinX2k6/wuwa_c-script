using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CE1 RID: 3297
public class FeatureRestrictionTemplate : IStaticVariableResetter
{
	// Token: 0x06008959 RID: 35161 RVA: 0x0029A133 File Offset: 0x00298333
	static FeatureRestrictionTemplate()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FeatureRestrictionTemplate.CreateStaticDefaultValue), new Action(FeatureRestrictionTemplate.ResetStaticDefaultValue));
	}

	// Token: 0x0600895A RID: 35162 RVA: 0x0029A152 File Offset: 0x00298352
	private FeatureRestrictionTemplate(EFeatureParseMode parseMode, EForceMode forceMode = EForceMode.None)
	{
		this.ParseMode = parseMode;
		this.ForceMode = forceMode;
	}

	// Token: 0x0600895B RID: 35163 RVA: 0x0029A16F File Offset: 0x0029836F
	private void AddClientMask(EClientFeature mask)
	{
		this.ClientFeatureMasks |= (int)mask;
	}

	// Token: 0x0600895C RID: 35164 RVA: 0x0029A17F File Offset: 0x0029837F
	private bool CheckByMask(int current, int mask)
	{
		return (current & mask) == mask;
	}

	// Token: 0x0600895D RID: 35165 RVA: 0x0029A188 File Offset: 0x00298388
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

	// Token: 0x0600895E RID: 35166 RVA: 0x0029A1B7 File Offset: 0x002983B7
	private int ParseCurrentServer()
	{
		return 0 | 0;
	}

	// Token: 0x0600895F RID: 35167 RVA: 0x0029A1BC File Offset: 0x002983BC
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

	// Token: 0x17000F4D RID: 3917
	// (get) Token: 0x06008960 RID: 35168 RVA: 0x0029A249 File Offset: 0x00298449
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

	// Token: 0x06008961 RID: 35169 RVA: 0x0029A26C File Offset: 0x0029846C
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06008962 RID: 35170 RVA: 0x0029A26E File Offset: 0x0029846E
	public static void ResetStaticDefaultValue()
	{
		FeatureRestrictionTemplate.TemplateForPioneerClientCore = null;
	}

	// Token: 0x040052AC RID: 21164
	private int ClientFeatureMasks;

	// Token: 0x040052AD RID: 21165
	private readonly int ServerFeatureMasks;

	// Token: 0x040052AE RID: 21166
	private readonly EFeatureParseMode ParseMode = EFeatureParseMode.All;

	// Token: 0x040052AF RID: 21167
	private readonly EForceMode ForceMode;

	// Token: 0x040052B0 RID: 21168
	[Nullable(2)]
	private static FeatureRestrictionTemplate TemplateForPioneerClientCore;
}
