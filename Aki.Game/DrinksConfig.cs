using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000F3A RID: 3898
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class DrinksConfig : ConfigBase
{
	// Token: 0x06006354 RID: 25428 RVA: 0x0013879C File Offset: 0x0013699C
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

	// Token: 0x06006355 RID: 25429 RVA: 0x001387F4 File Offset: 0x001369F4
	public IReadOnlyList<DrinksDrinkBase> GetAllDrinkBase()
	{
		IReadOnlyList<DrinksDrinkBase> configList = ConfigDrinksDrinkBaseAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<DrinksDrinkBase>();
		}
		return configList;
	}

	// Token: 0x06006356 RID: 25430 RVA: 0x00138814 File Offset: 0x00136A14
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

	// Token: 0x06006357 RID: 25431 RVA: 0x0013886C File Offset: 0x00136A6C
	public IReadOnlyList<DrinksBatching> GetAllBatching()
	{
		IReadOnlyList<DrinksBatching> configList = ConfigDrinksBatchingAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<DrinksBatching>();
		}
		return configList;
	}

	// Token: 0x06006358 RID: 25432 RVA: 0x0013888C File Offset: 0x00136A8C
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

	// Token: 0x06006359 RID: 25433 RVA: 0x001388E4 File Offset: 0x00136AE4
	public IReadOnlyList<DrinksOrnament> GetAllOrnament()
	{
		IReadOnlyList<DrinksOrnament> configList = ConfigDrinksOrnamentAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<DrinksOrnament>();
		}
		return configList;
	}

	// Token: 0x0600635A RID: 25434 RVA: 0x00138904 File Offset: 0x00136B04
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

	// Token: 0x0600635B RID: 25435 RVA: 0x0013895C File Offset: 0x00136B5C
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

	// Token: 0x0600635C RID: 25436 RVA: 0x001389B4 File Offset: 0x00136BB4
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

	// Token: 0x0600635D RID: 25437 RVA: 0x00138A0C File Offset: 0x00136C0C
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

	// Token: 0x0600635E RID: 25438 RVA: 0x00138A5C File Offset: 0x00136C5C
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

	// Token: 0x0600635F RID: 25439 RVA: 0x00138AB4 File Offset: 0x00136CB4
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

	// Token: 0x06006360 RID: 25440 RVA: 0x00138B0C File Offset: 0x00136D0C
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

	// Token: 0x06006361 RID: 25441 RVA: 0x00138B4C File Offset: 0x00136D4C
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

	// Token: 0x06006362 RID: 25442 RVA: 0x00138B9C File Offset: 0x00136D9C
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

	// Token: 0x06006363 RID: 25443 RVA: 0x00138BF4 File Offset: 0x00136DF4
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

	// Token: 0x06006364 RID: 25444 RVA: 0x00138C4C File Offset: 0x00136E4C
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

	// Token: 0x06006365 RID: 25445 RVA: 0x00138CC4 File Offset: 0x00136EC4
	public IReadOnlyList<DrinksRoleInvite> GetAllInvite()
	{
		IReadOnlyList<DrinksRoleInvite> configList = ConfigDrinksRoleInviteAll.GetConfigList(true);
		if (configList == null)
		{
			return new List<DrinksRoleInvite>();
		}
		return configList;
	}

	// Token: 0x06006366 RID: 25446 RVA: 0x00138CE4 File Offset: 0x00136EE4
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

	// Token: 0x06006367 RID: 25447 RVA: 0x00138D38 File Offset: 0x00136F38
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

	// Token: 0x06006368 RID: 25448 RVA: 0x00138D90 File Offset: 0x00136F90
	public int GetFlavorMax()
	{
		return ConfigCommonParamById.GetIntConfig("DrinksFlavorMax").GetValueOrDefault(10);
	}

	// Token: 0x06006369 RID: 25449 RVA: 0x00138DB4 File Offset: 0x00136FB4
	public int GetQTETimeLimit()
	{
		return ConfigCommonParamById.GetIntConfig("DrinksQTETimeLimit").GetValueOrDefault(9000);
	}

	// Token: 0x0600636A RID: 25450 RVA: 0x00138DD8 File Offset: 0x00136FD8
	public int GetQTESpeed()
	{
		return ConfigCommonParamById.GetIntConfig("DrinksQTETimeSpeed").GetValueOrDefault(1500);
	}

	// Token: 0x0600636B RID: 25451 RVA: 0x00138DFC File Offset: 0x00136FFC
	public int GetQTESeqTime()
	{
		return ConfigCommonParamById.GetIntConfig("DrinksQTESeqTime").GetValueOrDefault(500);
	}

	// Token: 0x0600636C RID: 25452 RVA: 0x00138E20 File Offset: 0x00137020
	public IReadOnlyList<int> GetNeedHideNpcId()
	{
		return ConfigCommonParamById.GetIntArrayConfig("DrinksNPCEntity") ?? new List<int>();
	}

	// Token: 0x1700079E RID: 1950
	// (get) Token: 0x0600636D RID: 25453 RVA: 0x00138E35 File Offset: 0x00137035
	public static DrinksConfig Instance
	{
		get
		{
			return DrinksConfig._Instance;
		}
	}

	// Token: 0x0600636E RID: 25454 RVA: 0x00138E3C File Offset: 0x0013703C
	public static DrinksConfig GetOrCreateInstance()
	{
		if (DrinksConfig._Instance == null)
		{
			DrinksConfig.CreateInstance();
		}
		return DrinksConfig._Instance;
	}

	// Token: 0x0600636F RID: 25455 RVA: 0x00138E50 File Offset: 0x00137050
	public static bool CreateInstance()
	{
		if (DrinksConfig._Instance != null)
		{
			return true;
		}
		DrinksConfig._Instance = new DrinksConfig();
		return true;
	}

	// Token: 0x06006370 RID: 25456 RVA: 0x00138E66 File Offset: 0x00137066
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06006371 RID: 25457 RVA: 0x00138E68 File Offset: 0x00137068
	public static void ResetStaticDefaultValue()
	{
		DrinksConfig._Instance = null;
	}

	// Token: 0x06006372 RID: 25458 RVA: 0x00138E70 File Offset: 0x00137070
	static DrinksConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(DrinksConfig.CreateStaticDefaultValue), new Action(DrinksConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04002D14 RID: 11540
	[Nullable(2)]
	private static DrinksConfig _Instance;
}
