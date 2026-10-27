using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02000005 RID: 5
[NullableContext(1)]
[Nullable(0)]
public static class CommonDefine
{
	// Token: 0x04000001 RID: 1
	public const int MILLIONSECOND_PER_SECOND = 1000;

	// Token: 0x04000002 RID: 2
	public const float SECOND_PER_MILLIONSECOND = 0.001f;

	// Token: 0x04000003 RID: 3
	public const int SECOND_PER_MINUTE = 60;

	// Token: 0x04000004 RID: 4
	public const int MINUTE_PER_HOUR = 60;

	// Token: 0x04000005 RID: 5
	public const int HOUR_PER_DAY = 24;

	// Token: 0x04000006 RID: 6
	public const int MINUTE_PER_DAY = 1440;

	// Token: 0x04000007 RID: 7
	public const int SECOND_PER_HOUR = 3600;

	// Token: 0x04000008 RID: 8
	public const int SECOND_PER_DAY = 86400;

	// Token: 0x04000009 RID: 9
	public const int DAY_PER_WEEK = 7;

	// Token: 0x0400000A RID: 10
	public const int DAY_PER_MONTH = 30;

	// Token: 0x0400000B RID: 11
	public const int MTOCM = 100;

	// Token: 0x0400000C RID: 12
	public const int PERCENTAGE_FACTOR = 100;

	// Token: 0x0400000D RID: 13
	public const string PACKAGE_LANGUAGE = "PackageLanguage";

	// Token: 0x0400000E RID: 14
	public const string CHS = "zh-Hans";

	// Token: 0x0400000F RID: 15
	public const string CHT = "zh-Hant";

	// Token: 0x04000010 RID: 16
	public const string CHINESE_ISO639_1 = "zh";

	// Token: 0x04000011 RID: 17
	public const string ENGLISH_ISO639_1 = "en";

	// Token: 0x04000012 RID: 18
	public const string JAPANESE_ISO639_1 = "ja";

	// Token: 0x04000013 RID: 19
	public const string KOREAN_ISO639_1 = "ko";

	// Token: 0x04000014 RID: 20
	public const string RUSSIA_ISO639_1 = "ru";

	// Token: 0x04000015 RID: 21
	public const string GERMANY_ISO639_1 = "de";

	// Token: 0x04000016 RID: 22
	public const string SPAIN_ISO639_1 = "es";

	// Token: 0x04000017 RID: 23
	public const string PORTUGAL_ISO639_1 = "pt";

	// Token: 0x04000018 RID: 24
	public const string INDONESIA_ISO639_1 = "id";

	// Token: 0x04000019 RID: 25
	public const string FRANCE_ISO639_1 = "fr";

	// Token: 0x0400001A RID: 26
	public const string VIETNAM_ISO639_1 = "vi";

	// Token: 0x0400001B RID: 27
	public const string THAILAND_ISO639_1 = "th";

	// Token: 0x0400001C RID: 28
	public const string CHS_AUDIO = "zh";

	// Token: 0x0400001D RID: 29
	public const string PUBLICATION_TYPE = "Publication";

	// Token: 0x0400001E RID: 30
	[StaticVariableRuleIgnore]
	public static readonly string[] AVAILABLE_LANGUAGES = new string[]
	{
		"zh-Hans",
		"en",
		"ja",
		"ko",
		"ru",
		"zh-Hant",
		"de",
		"es",
		"pt",
		"id",
		"fr",
		"vi",
		"th"
	};

	// Token: 0x0400001F RID: 31
	public const int INVALID_VALUE = -1;

	// Token: 0x04000020 RID: 32
	public const int RATE_10000 = 10000;

	// Token: 0x04000021 RID: 33
	public const string MATERIAL_NOT_ENOUGHT_TEXT_PATTERN = "<color=#f55e66>{0}</color>/{1}";

	// Token: 0x04000022 RID: 34
	public const string MATERIAL_ENOUGHT_TEXT_PATTERN = "<color=#f7eba6>{0}</color>/{1}";

	// Token: 0x04000023 RID: 35
	public const string MATERIAL_NEED_SELECT_TEXT_PATTERN = "--/{0}";

	// Token: 0x04000024 RID: 36
	public const int INDEX_NONE = -1;

	// Token: 0x04000025 RID: 37
	public const int NEGATIVEONE = -1;

	// Token: 0x04000026 RID: 38
	public const int ZERO = 0;

	// Token: 0x04000027 RID: 39
	public const int ONE = 1;

	// Token: 0x04000028 RID: 40
	public const int TWO = 2;

	// Token: 0x04000029 RID: 41
	public const int THREE = 3;

	// Token: 0x0400002A RID: 42
	public const int FOUR = 4;

	// Token: 0x0400002B RID: 43
	public const int THOUSAND = 1000;

	// Token: 0x0400002C RID: 44
	public const int MILLION = 1000000;

	// Token: 0x0400002D RID: 45
	public const int BILLION = 1000000000;

	// Token: 0x0400002E RID: 46
	public const long TRILLION = 1000000000000L;

	// Token: 0x0400002F RID: 47
	public const int PATH_SPLIT_LENGTH = 3;

	// Token: 0x04000030 RID: 48
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<CommonDefine.ETimeType, string> remainTimeTextId = new Dictionary<CommonDefine.ETimeType, string>
	{
		{
			CommonDefine.ETimeType.Day,
			"ShopDayText"
		},
		{
			CommonDefine.ETimeType.Hour,
			"ShopHourText"
		},
		{
			CommonDefine.ETimeType.Minute,
			"ShopMinuteText"
		},
		{
			CommonDefine.ETimeType.Second,
			"ShopSecondText"
		}
	};

	// Token: 0x04000031 RID: 49
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<CommonDefine.ETimeType, string> remainTimeTextIdFormat2 = new Dictionary<CommonDefine.ETimeType, string>
	{
		{
			CommonDefine.ETimeType.Day,
			"ShopDayText"
		},
		{
			CommonDefine.ETimeType.Hour,
			"ShopHourText2"
		},
		{
			CommonDefine.ETimeType.Minute,
			"ShopMinuteText2"
		},
		{
			CommonDefine.ETimeType.Second,
			"ShopSecondText"
		}
	};

	// Token: 0x04000032 RID: 50
	[StaticVariableRuleIgnore]
	public static readonly Dictionary<CommonDefine.ETimeType, string> remainTimeTextIdFormat3 = new Dictionary<CommonDefine.ETimeType, string>
	{
		{
			CommonDefine.ETimeType.Day,
			"UnitTimeText_1"
		},
		{
			CommonDefine.ETimeType.Hour,
			"UnitTimeText_2"
		},
		{
			CommonDefine.ETimeType.Minute,
			"UnitTimeText_3"
		},
		{
			CommonDefine.ETimeType.Second,
			"UnitTimeText_4"
		}
	};

	// Token: 0x0200002C RID: 44
	[NullableContext(0)]
	public enum ETimeType
	{
		// Token: 0x0400023E RID: 574
		Second,
		// Token: 0x0400023F RID: 575
		Minute,
		// Token: 0x04000240 RID: 576
		Hour,
		// Token: 0x04000241 RID: 577
		Day
	}

	// Token: 0x0200002D RID: 45
	public interface IRemainTime
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000106 RID: 262
		// (set) Token: 0x06000107 RID: 263
		int TimeValue { get; set; }

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000108 RID: 264
		// (set) Token: 0x06000109 RID: 265
		double RemainingTime { get; set; }

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600010A RID: 266
		// (set) Token: 0x0600010B RID: 267
		string TextId { get; set; }
	}

	// Token: 0x0200002E RID: 46
	[Nullable(0)]
	public class RemainTime : CommonDefine.IRemainTime
	{
		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000B5D2 File Offset: 0x000097D2
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000B5DA File Offset: 0x000097DA
		public int TimeValue { get; set; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600010E RID: 270 RVA: 0x0000B5E3 File Offset: 0x000097E3
		// (set) Token: 0x0600010F RID: 271 RVA: 0x0000B5EB File Offset: 0x000097EB
		public double RemainingTime { get; set; }

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0000B5F4 File Offset: 0x000097F4
		// (set) Token: 0x06000111 RID: 273 RVA: 0x0000B5FC File Offset: 0x000097FC
		public string TextId { get; set; }
	}

	// Token: 0x0200002F RID: 47
	public interface IPayShowCountDownRemainTime
	{
	}

	// Token: 0x02000030 RID: 48
	[NullableContext(0)]
	public class PayShowCountDownRemainTime<[Nullable(2)] T> : CommonDefine.IPayShowCountDownRemainTime
	{
		// Token: 0x04000245 RID: 581
		[Nullable(1)]
		public T Value;
	}

	// Token: 0x02000031 RID: 49
	[NullableContext(2)]
	public interface ICountDown
	{
		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06000114 RID: 276
		// (set) Token: 0x06000115 RID: 277
		string CountDownText { get; set; }

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000116 RID: 278
		// (set) Token: 0x06000117 RID: 279
		double RemainingTime { get; set; }
	}

	// Token: 0x02000032 RID: 50
	[NullableContext(2)]
	[Nullable(0)]
	public class CountDown : CommonDefine.ICountDown
	{
		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000B615 File Offset: 0x00009815
		// (set) Token: 0x06000119 RID: 281 RVA: 0x0000B61D File Offset: 0x0000981D
		public string CountDownText { get; set; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600011A RID: 282 RVA: 0x0000B626 File Offset: 0x00009826
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000B62E File Offset: 0x0000982E
		public double RemainingTime { get; set; }
	}

	// Token: 0x02000033 RID: 51
	[NullableContext(0)]
	public enum ETimeTextType
	{
		// Token: 0x04000249 RID: 585
		TimeType1,
		// Token: 0x0400024A RID: 586
		TimeType2
	}

	// Token: 0x02000034 RID: 52
	[NullableContext(0)]
	public enum ESkillType
	{
		// Token: 0x0400024C RID: 588
		ExploreType = 1,
		// Token: 0x0400024D RID: 589
		BattleType
	}

	// Token: 0x02000035 RID: 53
	[NullableContext(0)]
	public enum EQualityIconType
	{
		// Token: 0x0400024F RID: 591
		BackgroundSprite,
		// Token: 0x04000250 RID: 592
		VerticalGradientSprite,
		// Token: 0x04000251 RID: 593
		TipsSprite,
		// Token: 0x04000252 RID: 594
		MediumItemGridQualitySpritePath,
		// Token: 0x04000253 RID: 595
		TypeAGridQualitySpritePath
	}
}
