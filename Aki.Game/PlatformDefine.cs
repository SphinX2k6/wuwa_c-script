using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02001AD2 RID: 6866
[NullableContext(1)]
[Nullable(0)]
public class PlatformDefine
{
	// Token: 0x06011094 RID: 69780 RVA: 0x005017F0 File Offset: 0x004FF9F0
	// Note: this type is marked as 'beforefieldinit'.
	static PlatformDefine()
	{
		Dictionary<string, EInputControllerType> dictionary = new Dictionary<string, EInputControllerType>();
		dictionary["1356_3302"] = EInputControllerType.PS4;
		dictionary["1356_3570"] = EInputControllerType.PS4;
		dictionary["1356_1476"] = EInputControllerType.PS4;
		dictionary["1356_2508"] = EInputControllerType.PS4;
		dictionary["1118_2834"] = EInputControllerType.XboxOne;
		dictionary["1118_2835"] = EInputControllerType.XboxOne;
		dictionary["1118_2816"] = EInputControllerType.XboxOne;
		dictionary["1118_733"] = EInputControllerType.XboxOne;
		dictionary["1118_736"] = EInputControllerType.XboxOne;
		dictionary["1118_739"] = EInputControllerType.XboxOne;
		dictionary["1118_746"] = EInputControllerType.XboxOne;
		dictionary["1118_765"] = EInputControllerType.XboxOne;
		dictionary["1118_766"] = EInputControllerType.XboxOne;
		dictionary["13706_*"] = EInputControllerType.BackBone;
		dictionary["1406_8201"] = EInputControllerType.NsPro;
		dictionary["5426_*"] = EInputControllerType.XboxOne;
		dictionary["5426_4103"] = EInputControllerType.PS4;
		dictionary["5426_4112"] = EInputControllerType.PS5;
		PlatformDefine.DeviceIdMap = dictionary;
	}

	// Token: 0x040095F7 RID: 38391
	private const string DualSenseWirelessController = "1356_3302";

	// Token: 0x040095F8 RID: 38392
	private const string DualSenseEdgeWirelessController = "1356_3570";

	// Token: 0x040095F9 RID: 38393
	private const string DualShock4_Cuhzct1x = "1356_1476";

	// Token: 0x040095FA RID: 38394
	private const string DualShock4_Cuhzct2x = "1356_2508";

	// Token: 0x040095FB RID: 38395
	private const string XboxController = "1118_2834";

	// Token: 0x040095FC RID: 38396
	private const string XboxEliteSeriersController = "1118_2835";

	// Token: 0x040095FD RID: 38397
	private const string XboxEliteSeries2Controller = "1118_2816";

	// Token: 0x040095FE RID: 38398
	private const string XboxOneController2015 = "1118_733";

	// Token: 0x040095FF RID: 38399
	private const string XboxOneWirelessController = "1118_736";

	// Token: 0x04009600 RID: 38400
	private const string XboxOneEliteController = "1118_739";

	// Token: 0x04009601 RID: 38401
	private const string XboxOneController = "1118_746";

	// Token: 0x04009602 RID: 38402
	private const string XboxOneSController = "1118_765";

	// Token: 0x04009603 RID: 38403
	private const string XboxWirelessAdapterForWindows = "1118_766";

	// Token: 0x04009604 RID: 38404
	private const string BackboneOne = "13706_*";

	// Token: 0x04009605 RID: 38405
	private const string NsPro = "1406_8201";

	// Token: 0x04009606 RID: 38406
	private const string RazerDefault = "5426_*";

	// Token: 0x04009607 RID: 38407
	private const string Razer_DualShock4 = "5426_4103";

	// Token: 0x04009608 RID: 38408
	private const string RazerWolverineV2Pro = "5426_4112";

	// Token: 0x04009609 RID: 38409
	public static readonly IReadOnlyDictionary<string, EInputControllerType> DeviceIdMap;
}
