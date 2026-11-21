using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002720 RID: 10016
[NullableContext(1)]
[Nullable(0)]
public class WeaponComponentConfig : ConfigBase
{
	// Token: 0x06019205 RID: 102917 RVA: 0x007A8EC8 File Offset: 0x007A70C8
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

	// Token: 0x06019206 RID: 102918 RVA: 0x007A8EF7 File Offset: 0x007A70F7
	public WeaponVisibleConfig? GetWeaponVisibleConfigById(int configId)
	{
		return ConfigWeaponVisibleConfigByIdWithZero.GetConfig(configId, configId, configId, true);
	}

	// Token: 0x06019207 RID: 102919 RVA: 0x007A8F04 File Offset: 0x007A7104
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

	// Token: 0x170027E7 RID: 10215
	// (get) Token: 0x06019208 RID: 102920 RVA: 0x007A8F58 File Offset: 0x007A7158
	public static WeaponComponentConfig Instance
	{
		get
		{
			return WeaponComponentConfig._Instance;
		}
	}

	// Token: 0x06019209 RID: 102921 RVA: 0x007A8F5F File Offset: 0x007A715F
	public static WeaponComponentConfig GetOrCreateInstance()
	{
		if (WeaponComponentConfig._Instance == null)
		{
			WeaponComponentConfig.CreateInstance();
		}
		return WeaponComponentConfig._Instance;
	}

	// Token: 0x0601920A RID: 102922 RVA: 0x007A8F73 File Offset: 0x007A7173
	public static bool CreateInstance()
	{
		if (WeaponComponentConfig._Instance != null)
		{
			return true;
		}
		WeaponComponentConfig._Instance = new WeaponComponentConfig();
		return true;
	}

	// Token: 0x0601920B RID: 102923 RVA: 0x007A8F89 File Offset: 0x007A7189
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0601920C RID: 102924 RVA: 0x007A8F8B File Offset: 0x007A718B
	public static void ResetStaticDefaultValue()
	{
		WeaponComponentConfig._Instance = null;
	}

	// Token: 0x0601920D RID: 102925 RVA: 0x007A8F93 File Offset: 0x007A7193
	static WeaponComponentConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(WeaponComponentConfig.CreateStaticDefaultValue), new Action(WeaponComponentConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400DB76 RID: 56182
	[Nullable(2)]
	private static WeaponComponentConfig _Instance;
}
