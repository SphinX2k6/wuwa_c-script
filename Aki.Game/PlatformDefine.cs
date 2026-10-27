using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020025E7 RID: 9703
[NullableContext(1)]
[Nullable(0)]
public class PlatformDefine
{
	// Token: 0x06013BB2 RID: 80818 RVA: 0x004F2AA4 File Offset: 0x004F0CA4
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

	// Token: 0x040094A0 RID: 38048
	private const string DualSenseWirelessController = "1356_3302";

	// Token: 0x040094A1 RID: 38049
	private const string DualSenseEdgeWirelessController = "1356_3570";

	// Token: 0x040094A2 RID: 38050
	private const string DualShock4_Cuhzct1x = "1356_1476";

	// Token: 0x040094A3 RID: 38051
	private const string DualShock4_Cuhzct2x = "1356_2508";

	// Token: 0x040094A4 RID: 38052
	private const string XboxController = "1118_2834";

	// Token: 0x040094A5 RID: 38053
	private const string XboxEliteSeriersController = "1118_2835";

	// Token: 0x040094A6 RID: 38054
	private const string XboxEliteSeries2Controller = "1118_2816";

	// Token: 0x040094A7 RID: 38055
	private const string XboxOneController2015 = "1118_733";

	// Token: 0x040094A8 RID: 38056
	private const string XboxOneWirelessController = "1118_736";

	// Token: 0x040094A9 RID: 38057
	private const string XboxOneEliteController = "1118_739";

	// Token: 0x040094AA RID: 38058
	private const string XboxOneController = "1118_746";

	// Token: 0x040094AB RID: 38059
	private const string XboxOneSController = "1118_765";

	// Token: 0x040094AC RID: 38060
	private const string XboxWirelessAdapterForWindows = "1118_766";

	// Token: 0x040094AD RID: 38061
	private const string BackboneOne = "13706_*";

	// Token: 0x040094AE RID: 38062
	private const string NsPro = "1406_8201";

	// Token: 0x040094AF RID: 38063
	private const string RazerDefault = "5426_*";

	// Token: 0x040094B0 RID: 38064
	private const string Razer_DualShock4 = "5426_4103";

	// Token: 0x040094B1 RID: 38065
	private const string RazerWolverineV2Pro = "5426_4112";

	// Token: 0x040094B2 RID: 38066
	public static readonly IReadOnlyDictionary<string, EInputControllerType> DeviceIdMap;
}
