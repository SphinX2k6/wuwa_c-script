using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

// Token: 0x02000CB7 RID: 3255
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class CommonConfig : ConfigBase
{
	// Token: 0x060087C3 RID: 34755 RVA: 0x00294A77 File Offset: 0x00292C77
	public int? GetSelectablePropItemTickMaxTime()
	{
		return ConfigCommonParamById.GetIntConfig("additem_accumulate_initialtime");
	}

	// Token: 0x060087C4 RID: 34756 RVA: 0x00294A83 File Offset: 0x00292C83
	public int? GetSelectablePropItemTickMinTime()
	{
		return ConfigCommonParamById.GetIntConfig("additem_accumulate_mintime");
	}

	// Token: 0x060087C5 RID: 34757 RVA: 0x00294A8F File Offset: 0x00292C8F
	public int? GetSelectablePropItemTickIntervalTime()
	{
		return ConfigCommonParamById.GetIntConfig("additem_accumulate_deltaspeed");
	}

	// Token: 0x060087C6 RID: 34758 RVA: 0x00294A9B File Offset: 0x00292C9B
	public float? GetAutoAttachVelocityTime()
	{
		return ConfigCommonParamById.GetFloatConfig("AutoAttachVelocityTime");
	}

	// Token: 0x060087C7 RID: 34759 RVA: 0x00294AA7 File Offset: 0x00292CA7
	public float? GetAutoAttachInertiaTime()
	{
		return ConfigCommonParamById.GetFloatConfig("AutoAttachInertiaTime");
	}

	// Token: 0x060087C8 RID: 34760 RVA: 0x00294AB3 File Offset: 0x00292CB3
	public string GetNetGoodSprite()
	{
		return ConfigCommonParamById.GetStringConfig("NetGood");
	}

	// Token: 0x060087C9 RID: 34761 RVA: 0x00294ABF File Offset: 0x00292CBF
	public string GetNetMiddleSprite()
	{
		return ConfigCommonParamById.GetStringConfig("NetMiddle");
	}

	// Token: 0x060087CA RID: 34762 RVA: 0x00294ACB File Offset: 0x00292CCB
	public string GetNetBadSprite()
	{
		return ConfigCommonParamById.GetStringConfig("NetBad");
	}

	// Token: 0x060087CB RID: 34763 RVA: 0x00294AD7 File Offset: 0x00292CD7
	public string GetNetGoodSpriteMobile()
	{
		return ConfigCommonParamById.GetStringConfig("NetGoodMobile");
	}

	// Token: 0x060087CC RID: 34764 RVA: 0x00294AE3 File Offset: 0x00292CE3
	public string GetNetMiddleSpriteMobile()
	{
		return ConfigCommonParamById.GetStringConfig("NetMiddleMobile");
	}

	// Token: 0x060087CD RID: 34765 RVA: 0x00294AEF File Offset: 0x00292CEF
	public string GetNetBadSpriteMobile()
	{
		return ConfigCommonParamById.GetStringConfig("NetBadMobile");
	}

	// Token: 0x060087CE RID: 34766 RVA: 0x00294AFC File Offset: 0x00292CFC
	public List<QualityInfo> GetItemQualityList()
	{
		List<QualityInfo> list = ConfigCommon.ToList<QualityInfo>(ConfigQualityInfoAll.GetConfigList(true));
		if (list != null)
		{
			list.Sort((QualityInfo a, QualityInfo b) => a.Id - b.Id);
		}
		return list;
	}

	// Token: 0x060087CF RID: 34767 RVA: 0x00294B3E File Offset: 0x00292D3E
	public QualityInfo? GetItemQualityById(int id)
	{
		return ConfigQualityInfoById.GetConfig(id, true);
	}

	// Token: 0x060087D0 RID: 34768 RVA: 0x00294B48 File Offset: 0x00292D48
	public string GetItemQualityValueByParam(QualityInfo? config, CommonDefine.EQualityIconType? param)
	{
		if (config == null)
		{
			return null;
		}
		if (param != null)
		{
			switch (param.GetValueOrDefault())
			{
			case CommonDefine.EQualityIconType.BackgroundSprite:
				return config.Value.BackgroundSprite;
			case CommonDefine.EQualityIconType.VerticalGradientSprite:
				return config.Value.VerticalGradientSprite;
			case CommonDefine.EQualityIconType.TipsSprite:
				return config.Value.TipsSprite;
			case CommonDefine.EQualityIconType.MediumItemGridQualitySpritePath:
				return config.Value.MediumItemGridQualitySpritePath;
			case CommonDefine.EQualityIconType.TypeAGridQualitySpritePath:
				return config.Value.TypeAGridQualitySpritePath;
			}
		}
		return null;
	}

	// Token: 0x060087D1 RID: 34769 RVA: 0x00294BDE File Offset: 0x00292DDE
	public ElementInfo? GetElementConfig(int elementId)
	{
		return ConfigElementInfoById.GetConfig(elementId, true);
	}

	// Token: 0x060087D2 RID: 34770 RVA: 0x00294BE7 File Offset: 0x00292DE7
	public LongPressConfig? GetLongPressConfig(int configId)
	{
		return ConfigLongPressConfigById.GetConfig(configId, true);
	}

	// Token: 0x060087D3 RID: 34771 RVA: 0x00294BF0 File Offset: 0x00292DF0
	public string GetDebugGmViewPath(EUiViewName name)
	{
		if (name == EUiViewName.GmView)
		{
			if (Info.Instance.IsInTouch())
			{
				return ConfigCommonParamById.GetStringConfig("GmViewPath");
			}
			return ConfigCommonParamById.GetStringConfig("GmPcViewPath");
		}
		else
		{
			if (!(name == EUiViewName.LoginDebugView))
			{
				return null;
			}
			if (Info.Instance.IsInTouch())
			{
				return ConfigCommonParamById.GetStringConfig("GmLoginViewPath");
			}
			return ConfigCommonParamById.GetStringConfig("GmPcLoginViewPath");
		}
	}

	// Token: 0x060087D4 RID: 34772 RVA: 0x00294C5C File Offset: 0x00292E5C
	public int? GetNewMailGap()
	{
		return ConfigCommonParamById.GetIntConfig("NewMailGap");
	}

	// Token: 0x060087D5 RID: 34773 RVA: 0x00294C68 File Offset: 0x00292E68
	public int? GetPingUnChangeValue()
	{
		return ConfigCommonParamById.GetIntConfig("PingUnChangeValue");
	}

	// Token: 0x060087D6 RID: 34774 RVA: 0x00294C74 File Offset: 0x00292E74
	public bool? GetBetaBlockRecharge()
	{
		return ConfigCommonParamById.GetBoolConfig("BlockPay");
	}

	// Token: 0x060087D7 RID: 34775 RVA: 0x00294C80 File Offset: 0x00292E80
	public bool? GetPioneerFlag()
	{
		return ConfigCommonParamById.GetBoolConfig("PioneerFlag");
	}

	// Token: 0x060087D8 RID: 34776 RVA: 0x00294C8C File Offset: 0x00292E8C
	public int? GetShareGap()
	{
		return ConfigCommonParamById.GetIntConfig("ShareGap");
	}

	// Token: 0x060087D9 RID: 34777 RVA: 0x00294C98 File Offset: 0x00292E98
	public IReadOnlyList<int> GetIosReviewShieldMenuArray()
	{
		return ConfigCommonParamById.GetIntArrayConfig("BlockOnIosCheckServer");
	}

	// Token: 0x060087DA RID: 34778 RVA: 0x00294CA4 File Offset: 0x00292EA4
	public string GetKoShopRuleUrl()
	{
		return ConfigCommonParamById.GetStringConfig("KoShopRuleUrl");
	}

	// Token: 0x060087DB RID: 34779 RVA: 0x00294CB0 File Offset: 0x00292EB0
	public string GetJaShopRuleUrl()
	{
		return ConfigCommonParamById.GetStringConfig("JaShopRuleUrl");
	}

	// Token: 0x060087DC RID: 34780 RVA: 0x00294CBC File Offset: 0x00292EBC
	public int? GetReviewCd()
	{
		return ConfigCommonParamById.GetIntConfig("ReviewCd");
	}

	// Token: 0x060087DD RID: 34781 RVA: 0x00294CC8 File Offset: 0x00292EC8
	public int? OpenReviewDelay()
	{
		return ConfigCommonParamById.GetIntConfig("OpenReviewDelay");
	}

	// Token: 0x060087DE RID: 34782 RVA: 0x00294CD4 File Offset: 0x00292ED4
	public float GetPlayPointTrackRange()
	{
		return ConfigCommonParamById.GetFloatConfig("PlayPointTrackExtraRadius").GetValueOrDefault();
	}

	// Token: 0x060087DF RID: 34783 RVA: 0x00294CF4 File Offset: 0x00292EF4
	public int GetDiceItemId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoMonopolyDiceItemId").GetValueOrDefault();
	}

	// Token: 0x060087E0 RID: 34784 RVA: 0x00294D13 File Offset: 0x00292F13
	[NullableContext(1)]
	public IReadOnlyList<float> GetDangoMonopolyRangeSpeed()
	{
		IReadOnlyList<float> result;
		if ((result = ConfigCommonParamById.GetFloatArrayConfig("DangoMonopolySpeed")) == null)
		{
			result = new <>z__ReadOnlyArray<float>(new float[]
			{
				1f,
				2f
			});
		}
		return result;
	}

	// Token: 0x060087E1 RID: 34785 RVA: 0x00294D40 File Offset: 0x00292F40
	public int GetAutoOpenNoticePatchSize()
	{
		return ConfigCommonParamById.GetIntConfig("AutoOpenNotifyPatchSize").GetValueOrDefault();
	}

	// Token: 0x060087E2 RID: 34786 RVA: 0x00294D5F File Offset: 0x00292F5F
	[NullableContext(1)]
	public string GetGameIntroductionUrl()
	{
		return ConfigCommonParamById.GetStringConfig("GameIntroductionUrl") ?? string.Empty;
	}

	// Token: 0x060087E3 RID: 34787 RVA: 0x00294D74 File Offset: 0x00292F74
	[NullableContext(1)]
	public string GetGameIntroductionGlobalUrl()
	{
		return ConfigCommonParamById.GetStringConfig("GameIntroductionGlobalUrl") ?? string.Empty;
	}

	// Token: 0x060087E4 RID: 34788 RVA: 0x00294D89 File Offset: 0x00292F89
	[NullableContext(1)]
	public string GetGuideMainlandLinkUrl()
	{
		return ConfigCommonParamById.GetStringConfig("GuideMainlandLink") ?? string.Empty;
	}

	// Token: 0x060087E5 RID: 34789 RVA: 0x00294D9E File Offset: 0x00292F9E
	[NullableContext(1)]
	public string GetGuideOverseaLinkUrl()
	{
		return ConfigCommonParamById.GetStringConfig("GuideOverseaLink") ?? string.Empty;
	}

	// Token: 0x060087E6 RID: 34790 RVA: 0x00294DB3 File Offset: 0x00292FB3
	[NullableContext(1)]
	public IReadOnlyList<float> GetPhantomArenaBattleSpeed()
	{
		IReadOnlyList<float> result;
		if ((result = ConfigCommonParamById.GetFloatArrayConfig("PhantomArenaBattleSpeed")) == null)
		{
			result = new <>z__ReadOnlyArray<float>(new float[]
			{
				1f,
				1.5f,
				2f
			});
		}
		return result;
	}

	// Token: 0x060087E7 RID: 34791 RVA: 0x00294DDC File Offset: 0x00292FDC
	public int GetGiftMaxNineNineNine()
	{
		return ConfigCommonParamById.GetIntConfig("GiftMaxNineNineNine").GetValueOrDefault();
	}

	// Token: 0x060087E8 RID: 34792 RVA: 0x00294DFB File Offset: 0x00292FFB
	[NullableContext(1)]
	public IReadOnlyList<string> GetPioneerPkgIdList()
	{
		return ConfigCommonParamById.GetStringArrayConfig("PioneerPkgIdList");
	}

	// Token: 0x060087E9 RID: 34793 RVA: 0x00294E08 File Offset: 0x00293008
	public int GetGachaJumpShopTabId()
	{
		return ConfigCommonParamById.GetIntConfig("GachaJumpShopTabId").GetValueOrDefault();
	}

	// Token: 0x060087EA RID: 34794 RVA: 0x00294E28 File Offset: 0x00293028
	[NullableContext(1)]
	public IReadOnlySet<string> GetUiModelEffectReflectionBlacklist()
	{
		IReadOnlySet<string> result;
		if ((result = this.UiModelEffectReflectionBlacklist) == null)
		{
			result = (this.UiModelEffectReflectionBlacklist = new HashSet<string>(ConfigCommonParamById.GetStringArrayConfig("UiModelEffectReflectionBlacklist") ?? Array.Empty<string>()));
		}
		return result;
	}

	// Token: 0x060087EB RID: 34795 RVA: 0x00294E60 File Offset: 0x00293060
	[NullableContext(1)]
	public IReadOnlyList<string> GetPanoramicUiDeferWhiteList()
	{
		return ConfigCommonParamById.GetStringArrayConfig("PanoramicUiDeferWhiteList") ?? Array.Empty<string>();
	}

	// Token: 0x060087EC RID: 34796 RVA: 0x00294E78 File Offset: 0x00293078
	public int GetConsoleParallelPackageGap()
	{
		return ConfigCommonParamById.GetIntConfig("ConsoleParallelPackageGap").GetValueOrDefault();
	}

	// Token: 0x17000F41 RID: 3905
	// (get) Token: 0x060087ED RID: 34797 RVA: 0x00294E97 File Offset: 0x00293097
	[Nullable(1)]
	public static CommonConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return CommonConfig._Instance;
		}
	}

	// Token: 0x060087EE RID: 34798 RVA: 0x00294E9E File Offset: 0x0029309E
	[NullableContext(1)]
	public static CommonConfig GetOrCreateInstance()
	{
		if (CommonConfig._Instance == null)
		{
			CommonConfig.CreateInstance();
		}
		return CommonConfig._Instance;
	}

	// Token: 0x060087EF RID: 34799 RVA: 0x00294EB2 File Offset: 0x002930B2
	public static bool CreateInstance()
	{
		if (CommonConfig._Instance != null)
		{
			return true;
		}
		CommonConfig._Instance = new CommonConfig();
		return true;
	}

	// Token: 0x060087F0 RID: 34800 RVA: 0x00294EC8 File Offset: 0x002930C8
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060087F1 RID: 34801 RVA: 0x00294ECA File Offset: 0x002930CA
	public static void ResetStaticDefaultValue()
	{
		CommonConfig._Instance = null;
	}

	// Token: 0x060087F2 RID: 34802 RVA: 0x00294ED2 File Offset: 0x002930D2
	static CommonConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CommonConfig.CreateStaticDefaultValue), new Action(CommonConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400520F RID: 21007
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IReadOnlySet<string> UiModelEffectReflectionBlacklist;

	// Token: 0x04005210 RID: 21008
	private static CommonConfig _Instance;
}
