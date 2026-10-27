using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

// Token: 0x0200024B RID: 587
[NullableContext(1)]
[Nullable(0)]
public class CloudGameDefine : IStaticVariableResetter
{
	// Token: 0x060023C1 RID: 9153 RVA: 0x000DAC0D File Offset: 0x000D8E0D
	static CloudGameDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CloudGameDefine.CreateStaticDefaultValue), new Action(CloudGameDefine.ResetStaticDefaultValue));
	}

	// Token: 0x17000586 RID: 1414
	// (get) Token: 0x060023C2 RID: 9154 RVA: 0x000DAC2C File Offset: 0x000D8E2C
	public static Regex CloudGamePlatformRegex
	{
		get
		{
			return CloudGameDefine._cloudGamePlatformRegex;
		}
	}

	// Token: 0x17000587 RID: 1415
	// (get) Token: 0x060023C3 RID: 9155 RVA: 0x000DAC33 File Offset: 0x000D8E33
	public static Regex CloudGameDeviceRegex
	{
		get
		{
			return CloudGameDefine._cloudGameDeviceRegex;
		}
	}

	// Token: 0x17000588 RID: 1416
	// (get) Token: 0x060023C4 RID: 9156 RVA: 0x000DAC3A File Offset: 0x000D8E3A
	public static Regex CloudGameDpiRegex
	{
		get
		{
			return CloudGameDefine._cloudGameDpiRegex;
		}
	}

	// Token: 0x17000589 RID: 1417
	// (get) Token: 0x060023C5 RID: 9157 RVA: 0x000DAC41 File Offset: 0x000D8E41
	public static Regex CloudGameDeviceScreenResolution
	{
		get
		{
			return CloudGameDefine._cloudGameDeviceScreenResolution;
		}
	}

	// Token: 0x1700058A RID: 1418
	// (get) Token: 0x060023C6 RID: 9158 RVA: 0x000DAC48 File Offset: 0x000D8E48
	public static Regex CloudGameScreenResolution
	{
		get
		{
			return CloudGameDefine._cloudGameScreenResolution;
		}
	}

	// Token: 0x1700058B RID: 1419
	// (get) Token: 0x060023C7 RID: 9159 RVA: 0x000DAC4F File Offset: 0x000D8E4F
	public static Regex CloudGameIsWeb
	{
		get
		{
			return CloudGameDefine._cloudGameIsWeb;
		}
	}

	// Token: 0x1700058C RID: 1420
	// (get) Token: 0x060023C8 RID: 9160 RVA: 0x000DAC56 File Offset: 0x000D8E56
	public static Dictionary<string, float[]> DeviceMarginMap
	{
		get
		{
			return CloudGameDefine._deviceMarginMap;
		}
	}

	// Token: 0x1700058D RID: 1421
	// (get) Token: 0x060023C9 RID: 9161 RVA: 0x000DAC5D File Offset: 0x000D8E5D
	public static IReadOnlyList<float> DefaultDeviceMargin
	{
		get
		{
			return CloudGameDefine._defaultDeviceMargin;
		}
	}

	// Token: 0x060023CA RID: 9162 RVA: 0x000DAC64 File Offset: 0x000D8E64
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

	// Token: 0x060023CB RID: 9163 RVA: 0x000DAECE File Offset: 0x000D90CE
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

	// Token: 0x04001822 RID: 6178
	[Nullable(2)]
	private static Regex _cloudGamePlatformRegex;

	// Token: 0x04001823 RID: 6179
	[Nullable(2)]
	private static Regex _cloudGameDeviceRegex;

	// Token: 0x04001824 RID: 6180
	[Nullable(2)]
	private static Regex _cloudGameDpiRegex;

	// Token: 0x04001825 RID: 6181
	[Nullable(2)]
	private static Regex _cloudGameDeviceScreenResolution;

	// Token: 0x04001826 RID: 6182
	[Nullable(2)]
	private static Regex _cloudGameScreenResolution;

	// Token: 0x04001827 RID: 6183
	[Nullable(2)]
	private static Regex _cloudGameIsWeb;

	// Token: 0x04001828 RID: 6184
	public const int CLOUD_GAME_DEFAULT_DPI = 180;

	// Token: 0x04001829 RID: 6185
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	private static Dictionary<string, float[]> _deviceMarginMap;

	// Token: 0x0400182A RID: 6186
	[Nullable(2)]
	private static IReadOnlyList<float> _defaultDeviceMargin;

	// Token: 0x0400182B RID: 6187
	public const int CLOUD_GAME_DEFAULT_SCREEN_WIDTH = 1920;

	// Token: 0x0400182C RID: 6188
	public const int CLOUD_GAME_DEFAULT_SCREEN_HEIGHT = 1080;
}
