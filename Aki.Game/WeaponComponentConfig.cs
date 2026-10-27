using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020031B1 RID: 12721
[NullableContext(1)]
[Nullable(0)]
public class WeaponComponentConfig : ConfigBase
{
	// Token: 0x0601B6D2 RID: 112338 RVA: 0x00780B48 File Offset: 0x0077ED48
	public WeaponVisibleConfig? GetWeaponVisibleConfig(Entity entity)
	{
		CreatureDataComponent component = entity.GetComponent<CreatureDataComponent>();
		if (component == null)
		{
			return null;
		}
		int pbDataId = component.GetPbDataId();
		return this.GetWeaponVisibleConfigById(pbDataId);
	}

	// Token: 0x0601B6D3 RID: 112339 RVA: 0x00780B77 File Offset: 0x0077ED77
	public WeaponVisibleConfig? GetWeaponVisibleConfigById(int configId)
	{
		return ConfigWeaponVisibleConfigByIdWithZero.GetConfig(configId, configId, configId, true);
	}

	// Token: 0x0601B6D4 RID: 112340 RVA: 0x00780B84 File Offset: 0x0077ED84
	public int[] GetHideWeaponTags(int configId)
	{
		string[] array = ConfigWeaponHideConfigByIdWithZero.GetConfig(configId, configId, configId, true).Value.HideWeaponTags();
		int[] array2 = new int[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			string tagName = array[i];
			array2[i] = GameplayTagUtils.GetTagIdByName(tagName);
		}
		return array2;
	}

	// Token: 0x170025EA RID: 9706
	// (get) Token: 0x0601B6D5 RID: 112341 RVA: 0x00780BD8 File Offset: 0x0077EDD8
	public static WeaponComponentConfig Instance
	{
		get
		{
			return WeaponComponentConfig._Instance;
		}
	}

	// Token: 0x0601B6D6 RID: 112342 RVA: 0x00780BDF File Offset: 0x0077EDDF
	public static WeaponComponentConfig GetOrCreateInstance()
	{
		if (WeaponComponentConfig._Instance == null)
		{
			WeaponComponentConfig.CreateInstance();
		}
		return WeaponComponentConfig._Instance;
	}

	// Token: 0x0601B6D7 RID: 112343 RVA: 0x00780BF3 File Offset: 0x0077EDF3
	public static bool CreateInstance()
	{
		if (WeaponComponentConfig._Instance != null)
		{
			return true;
		}
		WeaponComponentConfig._Instance = new WeaponComponentConfig();
		return true;
	}

	// Token: 0x0601B6D8 RID: 112344 RVA: 0x00780C09 File Offset: 0x0077EE09
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601B6D9 RID: 112345 RVA: 0x00780C0B File Offset: 0x0077EE0B
	public static void ResetStaticDefaultValue()
	{
		WeaponComponentConfig._Instance = null;
	}

	// Token: 0x0601B6DA RID: 112346 RVA: 0x00780C13 File Offset: 0x0077EE13
	static WeaponComponentConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponComponentConfig.CreateStaticDefaultValue), new Action(WeaponComponentConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400D6EF RID: 55023
	[Nullable(2)]
	private static WeaponComponentConfig _Instance;
}
