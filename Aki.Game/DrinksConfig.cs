using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020003EF RID: 1007
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class DrinksConfig : ConfigBase
{
	// Token: 0x060036EC RID: 14060 RVA: 0x00141068 File Offset: 0x0013F268
	public DrinksDrinkBase? GetDrinkBase(int id)
	{
		DrinksDrinkBase? config = ConfigDrinksDrinkBaseById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksDrinkBase表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036ED RID: 14061 RVA: 0x001410C0 File Offset: 0x0013F2C0
	public IReadOnlyList<DrinksDrinkBase> GetAllDrinkBase()
	{
		IReadOnlyList<DrinksDrinkBase> configList = ConfigDrinksDrinkBaseAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<DrinksDrinkBase>();
		}
		return configList;
	}

	// Token: 0x060036EE RID: 14062 RVA: 0x001410E0 File Offset: 0x0013F2E0
	public DrinksBatching? GetBatching(int id)
	{
		DrinksBatching? config = ConfigDrinksBatchingById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksBatching表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036EF RID: 14063 RVA: 0x00141138 File Offset: 0x0013F338
	public IReadOnlyList<DrinksBatching> GetAllBatching()
	{
		IReadOnlyList<DrinksBatching> configList = ConfigDrinksBatchingAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<DrinksBatching>();
		}
		return configList;
	}

	// Token: 0x060036F0 RID: 14064 RVA: 0x00141158 File Offset: 0x0013F358
	public DrinksOrnament? GetOrnament(int id)
	{
		DrinksOrnament? config = ConfigDrinksOrnamentById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksOrnament表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036F1 RID: 14065 RVA: 0x001411B0 File Offset: 0x0013F3B0
	public IReadOnlyList<DrinksOrnament> GetAllOrnament()
	{
		IReadOnlyList<DrinksOrnament> configList = ConfigDrinksOrnamentAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<DrinksOrnament>();
		}
		return configList;
	}

	// Token: 0x060036F2 RID: 14066 RVA: 0x001411D0 File Offset: 0x0013F3D0
	public DrinksRequireList? GetRequireList(int id)
	{
		DrinksRequireList? config = ConfigDrinksRequireListById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksRequireList表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036F3 RID: 14067 RVA: 0x00141228 File Offset: 0x0013F428
	public DrinksRoleLikeDrink? GetRoleLikeDrink(int id)
	{
		DrinksRoleLikeDrink? config = ConfigDrinksRoleLikeDrinkById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksRoleLikeDrink表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036F4 RID: 14068 RVA: 0x00141280 File Offset: 0x0013F480
	public DrinksFlavorRange? GetFlavorRange(int id)
	{
		DrinksFlavorRange? config = ConfigDrinksFlavorRangeById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksFlavorRange表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036F5 RID: 14069 RVA: 0x001412D8 File Offset: 0x0013F4D8
	public IReadOnlyList<DrinksFlavorRange> GetFlavorRangeGroup(int id)
	{
		IReadOnlyList<DrinksFlavorRange> configList = ConfigDrinksFlavorRangeByGroupId.GetConfigList(id, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksFlavorRange表无效Group";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("Group", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return new List<DrinksFlavorRange>();
		}
		return configList;
	}

	// Token: 0x060036F6 RID: 14070 RVA: 0x00141328 File Offset: 0x0013F528
	public DrinksFlavorType? GetFlavorType(EDrinksFlavorType id)
	{
		DrinksFlavorType? config = ConfigDrinksFlavorTypeById.GetConfig((int)id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksFlavorType表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036F7 RID: 14071 RVA: 0x00141380 File Offset: 0x0013F580
	public DrinksDrinkMix? GetDrinkMix(int id)
	{
		DrinksDrinkMix? config = ConfigDrinksDrinkMixById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksDrinkMix表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036F8 RID: 14072 RVA: 0x001413D8 File Offset: 0x0013F5D8
	public IReadOnlyList<DrinksDrinkMix> GetAllMix()
	{
		IReadOnlyList<DrinksDrinkMix> configList = ConfigDrinksDrinkMixAll.GetConfigList(true);
		if (configList == null)
		{
			Log.Instance.Error(ELogModule.Drinks, ELogAuthor.WHJ, "DrinksDrinkMix表无效", default(ReadOnlySpan<ValueTuple<string, object>>));
			return Array.Empty<DrinksDrinkMix>();
		}
		return configList;
	}

	// Token: 0x060036F9 RID: 14073 RVA: 0x00141418 File Offset: 0x0013F618
	public IReadOnlyList<DrinksRequireList> GetRequireListByRole(int roleId)
	{
		IReadOnlyList<DrinksRequireList> configList = ConfigDrinksRequireListByRoleId.GetConfigList(roleId, true);
		if (configList == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksRequireList表无效role";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("role", roleId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return Array.Empty<DrinksRequireList>();
		}
		return configList;
	}

	// Token: 0x060036FA RID: 14074 RVA: 0x00141468 File Offset: 0x0013F668
	public DrinksStepConfig? GetStepConfig(EDrinksPlayStep step)
	{
		DrinksStepConfig? config = ConfigDrinksStepConfigById.GetConfig((int)step, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksStepConfig表无效role";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("step", step);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036FB RID: 14075 RVA: 0x001414C0 File Offset: 0x0013F6C0
	public DrinksRoleInvite? GetInviteConfig(int configId)
	{
		DrinksRoleInvite? config = ConfigDrinksRoleInviteById.GetConfig(configId, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksRoleInvite表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("configId", configId);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036FC RID: 14076 RVA: 0x00141518 File Offset: 0x0013F718
	public DrinksRoleInvite? GetInviteConfigByRole(int id)
	{
		IReadOnlyList<DrinksRoleInvite> allInvite = this.GetAllInvite();
		for (int i = 0; i < allInvite.Count; i++)
		{
			DrinksRoleInvite value = allInvite[i];
			if (value.RoleId == id)
			{
				return new DrinksRoleInvite?(value);
			}
		}
		Log instance = Log.Instance;
		ELogModule module = ELogModule.Drinks;
		ELogAuthor author = ELogAuthor.WHJ;
		string message = "DrinksRoleInvite表无效roleId";
		ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("roleId", id);
		instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		return null;
	}

	// Token: 0x060036FD RID: 14077 RVA: 0x00141590 File Offset: 0x0013F790
	public IReadOnlyList<DrinksRoleInvite> GetAllInvite()
	{
		IReadOnlyList<DrinksRoleInvite> configList = ConfigDrinksRoleInviteAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<DrinksRoleInvite>();
		}
		return configList;
	}

	// Token: 0x060036FE RID: 14078 RVA: 0x001415B0 File Offset: 0x0013F7B0
	public DrinksDialog? GetDialog(string id)
	{
		DrinksDialog? config = ConfigDrinksDialogById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksDialog表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x060036FF RID: 14079 RVA: 0x00141604 File Offset: 0x0013F804
	public DrinksParam? GetParam(int id)
	{
		DrinksParam? config = ConfigDrinksParamById.GetConfig(id, true);
		if (config == null)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.Drinks;
			ELogAuthor author = ELogAuthor.WHJ;
			string message = "DrinksParam表无效id";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("id", id);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
			return null;
		}
		return config;
	}

	// Token: 0x06003700 RID: 14080 RVA: 0x0014165C File Offset: 0x0013F85C
	public int GetFlavorMax()
	{
		return ConfigCommonParamById.GetIntConfig("DrinksFlavorMax").GetValueOrDefault(10);
	}

	// Token: 0x06003701 RID: 14081 RVA: 0x00141680 File Offset: 0x0013F880
	public int GetQTETimeLimit()
	{
		return ConfigCommonParamById.GetIntConfig("DrinksQTETimeLimit").GetValueOrDefault(9000);
	}

	// Token: 0x06003702 RID: 14082 RVA: 0x001416A4 File Offset: 0x0013F8A4
	public int GetQTESpeed()
	{
		return ConfigCommonParamById.GetIntConfig("DrinksQTETimeSpeed").GetValueOrDefault(1500);
	}

	// Token: 0x06003703 RID: 14083 RVA: 0x001416C8 File Offset: 0x0013F8C8
	public int GetQTESeqTime()
	{
		return ConfigCommonParamById.GetIntConfig("DrinksQTESeqTime").GetValueOrDefault(500);
	}

	// Token: 0x06003704 RID: 14084 RVA: 0x001416EC File Offset: 0x0013F8EC
	public IReadOnlyList<int> GetNeedHideNpcId()
	{
		return ConfigCommonParamById.GetIntArrayConfig("DrinksNPCEntity") ?? new List<int>();
	}

	// Token: 0x170007C0 RID: 1984
	// (get) Token: 0x06003705 RID: 14085 RVA: 0x00141701 File Offset: 0x0013F901
	public static DrinksConfig Instance
	{
		get
		{
			return DrinksConfig._Instance;
		}
	}

	// Token: 0x06003706 RID: 14086 RVA: 0x00141708 File Offset: 0x0013F908
	public static DrinksConfig GetOrCreateInstance()
	{
		if (DrinksConfig._Instance == null)
		{
			DrinksConfig.CreateInstance();
		}
		return DrinksConfig._Instance;
	}

	// Token: 0x06003707 RID: 14087 RVA: 0x0014171C File Offset: 0x0013F91C
	public static bool CreateInstance()
	{
		if (DrinksConfig._Instance != null)
		{
			return true;
		}
		DrinksConfig._Instance = new DrinksConfig();
		return true;
	}

	// Token: 0x06003708 RID: 14088 RVA: 0x00141732 File Offset: 0x0013F932
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06003709 RID: 14089 RVA: 0x00141734 File Offset: 0x0013F934
	public static void ResetStaticDefaultValue()
	{
		DrinksConfig._Instance = null;
	}

	// Token: 0x0600370A RID: 14090 RVA: 0x0014173C File Offset: 0x0013F93C
	static DrinksConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DrinksConfig.CreateStaticDefaultValue), new Action(DrinksConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002DAD RID: 11693
	[Nullable(2)]
	private static DrinksConfig _Instance;
}
