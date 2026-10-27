using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;
using CSharpScript.Core.Common;
using CSharpScript.Game.Ui;

// Token: 0x020017FE RID: 6142
[NullableContext(2)]
[Nullable(0)]
[Config(0)]
public class CommonConfig : ConfigBase
{
	// Token: 0x0600B3D9 RID: 46041 RVA: 0x0028A37B File Offset: 0x0028857B
	public int? GetSelectablePropItemTickMaxTime()
	{
		return ConfigCommonParamById.GetIntConfig("additem_accumulate_initialtime");
	}

	// Token: 0x0600B3DA RID: 46042 RVA: 0x0028A387 File Offset: 0x00288587
	public int? GetSelectablePropItemTickMinTime()
	{
		return ConfigCommonParamById.GetIntConfig("additem_accumulate_mintime");
	}

	// Token: 0x0600B3DB RID: 46043 RVA: 0x0028A393 File Offset: 0x00288593
	public int? GetSelectablePropItemTickIntervalTime()
	{
		return ConfigCommonParamById.GetIntConfig("additem_accumulate_deltaspeed");
	}

	// Token: 0x0600B3DC RID: 46044 RVA: 0x0028A39F File Offset: 0x0028859F
	public float? GetAutoAttachVelocityTime()
	{
		return ConfigCommonParamById.GetFloatConfig("AutoAttachVelocityTime");
	}

	// Token: 0x0600B3DD RID: 46045 RVA: 0x0028A3AB File Offset: 0x002885AB
	public float? GetAutoAttachInertiaTime()
	{
		return ConfigCommonParamById.GetFloatConfig("AutoAttachInertiaTime");
	}

	// Token: 0x0600B3DE RID: 46046 RVA: 0x0028A3B7 File Offset: 0x002885B7
	public string GetNetGoodSprite()
	{
		return ConfigCommonParamById.GetStringConfig("NetGood");
	}

	// Token: 0x0600B3DF RID: 46047 RVA: 0x0028A3C3 File Offset: 0x002885C3
	public string GetNetMiddleSprite()
	{
		return ConfigCommonParamById.GetStringConfig("NetMiddle");
	}

	// Token: 0x0600B3E0 RID: 46048 RVA: 0x0028A3CF File Offset: 0x002885CF
	public string GetNetBadSprite()
	{
		return ConfigCommonParamById.GetStringConfig("NetBad");
	}

	// Token: 0x0600B3E1 RID: 46049 RVA: 0x0028A3DB File Offset: 0x002885DB
	public string GetNetGoodSpriteMobile()
	{
		return ConfigCommonParamById.GetStringConfig("NetGoodMobile");
	}

	// Token: 0x0600B3E2 RID: 46050 RVA: 0x0028A3E7 File Offset: 0x002885E7
	public string GetNetMiddleSpriteMobile()
	{
		return ConfigCommonParamById.GetStringConfig("NetMiddleMobile");
	}

	// Token: 0x0600B3E3 RID: 46051 RVA: 0x0028A3F3 File Offset: 0x002885F3
	public string GetNetBadSpriteMobile()
	{
		return ConfigCommonParamById.GetStringConfig("NetBadMobile");
	}

	// Token: 0x0600B3E4 RID: 46052 RVA: 0x0028A400 File Offset: 0x00288600
	public List<QualityInfo> GetItemQualityList()
	{
		List<QualityInfo> list = ConfigCommon.ToList<QualityInfo>(ConfigQualityInfoAll.GetConfigList(true));
		if (list != null)
		{
			list.Sort((QualityInfo a, QualityInfo b) => a.Id - b.Id);
		}
		return list;
	}

	// Token: 0x0600B3E5 RID: 46053 RVA: 0x0028A442 File Offset: 0x00288642
	public QualityInfo? GetItemQualityById(int id)
	{
		return ConfigQualityInfoById.GetConfig(id, true);
	}

	// Token: 0x0600B3E6 RID: 46054 RVA: 0x0028A44C File Offset: 0x0028864C
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

	// Token: 0x0600B3E7 RID: 46055 RVA: 0x0028A4E2 File Offset: 0x002886E2
	public ElementInfo? GetElementConfig(int elementId)
	{
		return ConfigElementInfoById.GetConfig(elementId, true);
	}

	// Token: 0x0600B3E8 RID: 46056 RVA: 0x0028A4EB File Offset: 0x002886EB
	public LongPressConfig? GetLongPressConfig(int configId)
	{
		return ConfigLongPressConfigById.GetConfig(configId, true);
	}

	// Token: 0x0600B3E9 RID: 46057 RVA: 0x0028A4F4 File Offset: 0x002886F4
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

	// Token: 0x0600B3EA RID: 46058 RVA: 0x0028A560 File Offset: 0x00288760
	public int? GetNewMailGap()
	{
		return ConfigCommonParamById.GetIntConfig("NewMailGap");
	}

	// Token: 0x0600B3EB RID: 46059 RVA: 0x0028A56C File Offset: 0x0028876C
	public int? GetPingUnChangeValue()
	{
		return ConfigCommonParamById.GetIntConfig("PingUnChangeValue");
	}

	// Token: 0x0600B3EC RID: 46060 RVA: 0x0028A578 File Offset: 0x00288778
	public bool? GetBetaBlockRecharge()
	{
		return ConfigCommonParamById.GetBoolConfig("BlockPay");
	}

	// Token: 0x0600B3ED RID: 46061 RVA: 0x0028A584 File Offset: 0x00288784
	public bool? GetPioneerFlag()
	{
		return ConfigCommonParamById.GetBoolConfig("PioneerFlag");
	}

	// Token: 0x0600B3EE RID: 46062 RVA: 0x0028A590 File Offset: 0x00288790
	public int? GetShareGap()
	{
		return ConfigCommonParamById.GetIntConfig("ShareGap");
	}

	// Token: 0x0600B3EF RID: 46063 RVA: 0x0028A59C File Offset: 0x0028879C
	public IReadOnlyList<int> GetIosReviewShieldMenuArray()
	{
		return ConfigCommonParamById.GetIntArrayConfig("BlockOnIosCheckServer");
	}

	// Token: 0x0600B3F0 RID: 46064 RVA: 0x0028A5A8 File Offset: 0x002887A8
	public string GetKoShopRuleUrl()
	{
		return ConfigCommonParamById.GetStringConfig("KoShopRuleUrl");
	}

	// Token: 0x0600B3F1 RID: 46065 RVA: 0x0028A5B4 File Offset: 0x002887B4
	public string GetJaShopRuleUrl()
	{
		return ConfigCommonParamById.GetStringConfig("JaShopRuleUrl");
	}

	// Token: 0x0600B3F2 RID: 46066 RVA: 0x0028A5C0 File Offset: 0x002887C0
	public int? GetReviewCd()
	{
		return ConfigCommonParamById.GetIntConfig("ReviewCd");
	}

	// Token: 0x0600B3F3 RID: 46067 RVA: 0x0028A5CC File Offset: 0x002887CC
	public int? OpenReviewDelay()
	{
		return ConfigCommonParamById.GetIntConfig("OpenReviewDelay");
	}

	// Token: 0x0600B3F4 RID: 46068 RVA: 0x0028A5D8 File Offset: 0x002887D8
	public float GetPlayPointTrackRange()
	{
		return ConfigCommonParamById.GetFloatConfig("PlayPointTrackExtraRadius").GetValueOrDefault();
	}

	// Token: 0x0600B3F5 RID: 46069 RVA: 0x0028A5F8 File Offset: 0x002887F8
	public int GetDiceItemId()
	{
		return ConfigCommonParamById.GetIntConfig("DangoMonopolyDiceItemId").GetValueOrDefault();
	}

	// Token: 0x0600B3F6 RID: 46070 RVA: 0x0028A617 File Offset: 0x00288817
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

	// Token: 0x0600B3F7 RID: 46071 RVA: 0x0028A644 File Offset: 0x00288844
	public int GetAutoOpenNoticePatchSize()
	{
		return ConfigCommonParamById.GetIntConfig("AutoOpenNotifyPatchSize").GetValueOrDefault();
	}

	// Token: 0x0600B3F8 RID: 46072 RVA: 0x0028A663 File Offset: 0x00288863
	[NullableContext(1)]
	public string GetGameIntroductionUrl()
	{
		return ConfigCommonParamById.GetStringConfig("GameIntroductionUrl") ?? string.Empty;
	}

	// Token: 0x0600B3F9 RID: 46073 RVA: 0x0028A678 File Offset: 0x00288878
	[NullableContext(1)]
	public string GetGameIntroductionGlobalUrl()
	{
		return ConfigCommonParamById.GetStringConfig("GameIntroductionGlobalUrl") ?? string.Empty;
	}

	// Token: 0x0600B3FA RID: 46074 RVA: 0x0028A68D File Offset: 0x0028888D
	[NullableContext(1)]
	public string GetGuideMainlandLinkUrl()
	{
		return ConfigCommonParamById.GetStringConfig("GuideMainlandLink") ?? string.Empty;
	}

	// Token: 0x0600B3FB RID: 46075 RVA: 0x0028A6A2 File Offset: 0x002888A2
	[NullableContext(1)]
	public string GetGuideOverseaLinkUrl()
	{
		return ConfigCommonParamById.GetStringConfig("GuideOverseaLink") ?? string.Empty;
	}

	// Token: 0x0600B3FC RID: 46076 RVA: 0x0028A6B7 File Offset: 0x002888B7
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

	// Token: 0x0600B3FD RID: 46077 RVA: 0x0028A6E0 File Offset: 0x002888E0
	public int GetGiftMaxNineNineNine()
	{
		return ConfigCommonParamById.GetIntConfig("GiftMaxNineNineNine").GetValueOrDefault();
	}

	// Token: 0x0600B3FE RID: 46078 RVA: 0x0028A6FF File Offset: 0x002888FF
	[NullableContext(1)]
	public IReadOnlyList<string> GetPioneerPkgIdList()
	{
		return ConfigCommonParamById.GetStringArrayConfig("PioneerPkgIdList");
	}

	// Token: 0x0600B3FF RID: 46079 RVA: 0x0028A70C File Offset: 0x0028890C
	public int GetGachaJumpShopTabId()
	{
		return ConfigCommonParamById.GetIntConfig("GachaJumpShopTabId").GetValueOrDefault();
	}

	// Token: 0x0600B400 RID: 46080 RVA: 0x0028A72C File Offset: 0x0028892C
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

	// Token: 0x0600B401 RID: 46081 RVA: 0x0028A764 File Offset: 0x00288964
	[NullableContext(1)]
	public IReadOnlyList<string> GetPanoramicUiDeferWhiteList()
	{
		return ConfigCommonParamById.GetStringArrayConfig("PanoramicUiDeferWhiteList") ?? Array.Empty<string>();
	}

	// Token: 0x17000F1E RID: 3870
	// (get) Token: 0x0600B402 RID: 46082 RVA: 0x0028A779 File Offset: 0x00288979
	[Nullable(1)]
	public static CommonConfig Instance
	{
		[NullableContext(1)]
		get
		{
			return CommonConfig._Instance;
		}
	}

	// Token: 0x0600B403 RID: 46083 RVA: 0x0028A780 File Offset: 0x00288980
	[NullableContext(1)]
	public static CommonConfig GetOrCreateInstance()
	{
		if (CommonConfig._Instance == null)
		{
			CommonConfig.CreateInstance();
		}
		return CommonConfig._Instance;
	}

	// Token: 0x0600B404 RID: 46084 RVA: 0x0028A794 File Offset: 0x00288994
	public static bool CreateInstance()
	{
		if (CommonConfig._Instance != null)
		{
			return true;
		}
		CommonConfig._Instance = new CommonConfig();
		return true;
	}

	// Token: 0x0600B405 RID: 46085 RVA: 0x0028A7AA File Offset: 0x002889AA
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600B406 RID: 46086 RVA: 0x0028A7AC File Offset: 0x002889AC
	public static void ResetStaticDefaultValue()
	{
		CommonConfig._Instance = null;
	}

	// Token: 0x0600B407 RID: 46087 RVA: 0x0028A7B4 File Offset: 0x002889B4
	static CommonConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CommonConfig.CreateStaticDefaultValue), new Action(CommonConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005164 RID: 20836
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private IReadOnlySet<string> UiModelEffectReflectionBlacklist;

	// Token: 0x04005165 RID: 20837
	private static CommonConfig _Instance;
}
