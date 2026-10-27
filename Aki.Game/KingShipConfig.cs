using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02002038 RID: 8248
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class KingShipConfig : ConfigBase
{
	// Token: 0x06010320 RID: 66336 RVA: 0x003F2C00 File Offset: 0x003F0E00
	public KingShipAttribute GetKingShipAttribute(int id)
	{
		return ConfigKingShipAttributeById.GetConfig(id, true).Value;
	}

	// Token: 0x06010321 RID: 66337 RVA: 0x003F2C1C File Offset: 0x003F0E1C
	public KingShipBuff GetKingShipBuff(int id)
	{
		return ConfigKingShipBuffById.GetConfig(id, true).Value;
	}

	// Token: 0x06010322 RID: 66338 RVA: 0x003F2C38 File Offset: 0x003F0E38
	public Reigns GetReigns(int id)
	{
		return ConfigReignsById.GetConfig(id, true).Value;
	}

	// Token: 0x06010323 RID: 66339 RVA: 0x003F2C54 File Offset: 0x003F0E54
	public Reigns? TryGetReigns(int id)
	{
		return ConfigReignsById.GetConfig(id, true);
	}

	// Token: 0x06010324 RID: 66340 RVA: 0x003F2C60 File Offset: 0x003F0E60
	public ReignsCard GetReignsCallCard(int id)
	{
		return ConfigReignsCardById.GetConfig(id, true).Value;
	}

	// Token: 0x170013C3 RID: 5059
	// (get) Token: 0x06010325 RID: 66341 RVA: 0x003F2C7C File Offset: 0x003F0E7C
	public static KingShipConfig Instance
	{
		get
		{
			return KingShipConfig._Instance;
		}
	}

	// Token: 0x06010326 RID: 66342 RVA: 0x003F2C83 File Offset: 0x003F0E83
	public static KingShipConfig GetOrCreateInstance()
	{
		if (KingShipConfig._Instance == null)
		{
			KingShipConfig.CreateInstance();
		}
		return KingShipConfig._Instance;
	}

	// Token: 0x06010327 RID: 66343 RVA: 0x003F2C97 File Offset: 0x003F0E97
	public static bool CreateInstance()
	{
		if (KingShipConfig._Instance != null)
		{
			return true;
		}
		KingShipConfig._Instance = new KingShipConfig();
		return true;
	}

	// Token: 0x06010328 RID: 66344 RVA: 0x003F2CAD File Offset: 0x003F0EAD
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010329 RID: 66345 RVA: 0x003F2CAF File Offset: 0x003F0EAF
	public static void ResetStaticDefaultValue()
	{
		KingShipConfig._Instance = null;
	}

	// Token: 0x0601032A RID: 66346 RVA: 0x003F2CB7 File Offset: 0x003F0EB7
	static KingShipConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KingShipConfig.CreateStaticDefaultValue), new Action(KingShipConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040077DA RID: 30682
	[Nullable(2)]
	private static KingShipConfig _Instance;
}
