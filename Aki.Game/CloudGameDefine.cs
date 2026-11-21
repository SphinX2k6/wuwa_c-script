using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Token: 0x0200024F RID: 591
[NullableContext(1)]
[Nullable(0)]
public class CloudGameDefine : IStaticVariableResetter
{
	// Token: 0x06002479 RID: 9337 RVA: 0x000E1155 File Offset: 0x000DF355
	static CloudGameDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CloudGameDefine.CreateStaticDefaultValue), new Action(CloudGameDefine.ResetStaticDefaultValue));
	}

	// Token: 0x170005AD RID: 1453
	// (get) Token: 0x0600247A RID: 9338 RVA: 0x000E1174 File Offset: 0x000DF374
	public static Regex CloudGamePlatformRegex
	{
		get
		{
			return CloudGameDefine._cloudGamePlatformRegex;
		}
	}

	// Token: 0x170005AE RID: 1454
	// (get) Token: 0x0600247B RID: 9339 RVA: 0x000E117B File Offset: 0x000DF37B
	public static Regex CloudGameDeviceRegex
	{
		get
		{
			return CloudGameDefine._cloudGameDeviceRegex;
		}
	}

	// Token: 0x170005AF RID: 1455
	// (get) Token: 0x0600247C RID: 9340 RVA: 0x000E1182 File Offset: 0x000DF382
	public static Regex CloudGameDpiRegex
	{
		get
		{
			return CloudGameDefine._cloudGameDpiRegex;
		}
	}

	// Token: 0x170005B0 RID: 1456
	// (get) Token: 0x0600247D RID: 9341 RVA: 0x000E1189 File Offset: 0x000DF389
	public static Regex CloudGameDeviceScreenResolution
	{
		get
		{
			return CloudGameDefine._cloudGameDeviceScreenResolution;
		}
	}

	// Token: 0x170005B1 RID: 1457
	// (get) Token: 0x0600247E RID: 9342 RVA: 0x000E1190 File Offset: 0x000DF390
	public static Regex CloudGameScreenResolution
	{
		get
		{
			return CloudGameDefine._cloudGameScreenResolution;
		}
	}

	// Token: 0x170005B2 RID: 1458
	// (get) Token: 0x0600247F RID: 9343 RVA: 0x000E1197 File Offset: 0x000DF397
	public static Regex CloudGameIsWeb
	{
		get
		{
			return CloudGameDefine._cloudGameIsWeb;
		}
	}

	// Token: 0x170005B3 RID: 1459
	// (get) Token: 0x06002480 RID: 9344 RVA: 0x000E119E File Offset: 0x000DF39E
	public static Dictionary<string, float[]> DeviceMarginMap
	{
		get
		{
			return CloudGameDefine._deviceMarginMap;
		}
	}

	// Token: 0x170005B4 RID: 1460
	// (get) Token: 0x06002481 RID: 9345 RVA: 0x000E11A5 File Offset: 0x000DF3A5
	public static IReadOnlyList<float> DefaultDeviceMargin
	{
		get
		{
			return CloudGameDefine._defaultDeviceMargin;
		}
	}

	// Token: 0x06002482 RID: 9346 RVA: 0x000E11AC File Offset: 0x000DF3AC
	public static void CreateStaticDefaultValue()
	{
		CloudGameDefine._cloudGamePlatformRegex = new Regex("-CloudGamePlatform=([^\\s]+)");
		CloudGameDefine._cloudGameDeviceRegex = new Regex("-Device=([^\\s]+)");
		CloudGameDefine._cloudGameDpiRegex = new Regex("-Dpi=([^\\s]+)");
		CloudGameDefine._cloudGameDeviceScreenResolution = new Regex("-DeviceScreenResolution=(\\d+)x(\\d+)");
		CloudGameDefine._cloudGameScreenResolution = new Regex("Res=(\\d+)x(\\d+)");
		CloudGameDefine._cloudGameIsWeb = new Regex("-IsWeb=([^\\s]+)");
		Dictionary<string, float[]> dictionary = new Dictionary<string, float[]>();
		dictionary["iPhone15,2"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["iPhone15,3"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["ELS-AN00"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["PGU110"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["iPhone16,1"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["iPhone16,2"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["ANA-AN00"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["ELS-AN10"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["JER-TN20"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["WLZ-AN00"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["OXF-AN00"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["OXF-AN10"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["iPhone17,1"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["iPhone17,2"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["iPhone17,3"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["iPhone17,4"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		dictionary["iPhone17,5"] = new float[]
		{
			5.4f,
			0f,
			4f,
			0.8f
		};
		CloudGameDefine._deviceMarginMap = dictionary;
		CloudGameDefine._defaultDeviceMargin = new <>z__ReadOnlyArray<float>(new float[]
		{
			3f,
			0f,
			2.7f,
			0.8f
		});
	}

	// Token: 0x06002483 RID: 9347 RVA: 0x000E1416 File Offset: 0x000DF616
	public static void ResetStaticDefaultValue()
	{
		CloudGameDefine._cloudGamePlatformRegex = null;
		CloudGameDefine._cloudGameDeviceRegex = null;
		CloudGameDefine._cloudGameDpiRegex = null;
		CloudGameDefine._cloudGameDeviceScreenResolution = null;
		CloudGameDefine._cloudGameScreenResolution = null;
		CloudGameDefine._cloudGameIsWeb = null;
		CloudGameDefine._deviceMarginMap = null;
		CloudGameDefine._defaultDeviceMargin = null;
	}

	// Token: 0x04001866 RID: 6246
	[Nullable(2)]
	private static Regex _cloudGamePlatformRegex;

	// Token: 0x04001867 RID: 6247
	[Nullable(2)]
	private static Regex _cloudGameDeviceRegex;

	// Token: 0x04001868 RID: 6248
	[Nullable(2)]
	private static Regex _cloudGameDpiRegex;

	// Token: 0x04001869 RID: 6249
	[Nullable(2)]
	private static Regex _cloudGameDeviceScreenResolution;

	// Token: 0x0400186A RID: 6250
	[Nullable(2)]
	private static Regex _cloudGameScreenResolution;

	// Token: 0x0400186B RID: 6251
	[Nullable(2)]
	private static Regex _cloudGameIsWeb;

	// Token: 0x0400186C RID: 6252
	public const int CLOUD_GAME_DEFAULT_DPI = 180;

	// Token: 0x0400186D RID: 6253
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, float[]> _deviceMarginMap;

	// Token: 0x0400186E RID: 6254
	[Nullable(2)]
	private static IReadOnlyList<float> _defaultDeviceMargin;

	// Token: 0x0400186F RID: 6255
	public const int CLOUD_GAME_DEFAULT_SCREEN_WIDTH = 1920;

	// Token: 0x04001870 RID: 6256
	public const int CLOUD_GAME_DEFAULT_SCREEN_HEIGHT = 1080;
}
