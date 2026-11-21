using System;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200150B RID: 5387
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class KingShipConfig : ConfigBase
{
	// Token: 0x0600D788 RID: 55176 RVA: 0x003FF1F8 File Offset: 0x003FD3F8
	public KingShipAttribute GetKingShipAttribute(int id)
	{
		return ConfigKingShipAttributeById.GetConfig(id, true).Value;
	}

	// Token: 0x0600D789 RID: 55177 RVA: 0x003FF214 File Offset: 0x003FD414
	public KingShipBuff GetKingShipBuff(int id)
	{
		return ConfigKingShipBuffById.GetConfig(id, true).Value;
	}

	// Token: 0x0600D78A RID: 55178 RVA: 0x003FF230 File Offset: 0x003FD430
	public Reigns GetReigns(int id)
	{
		return ConfigReignsById.GetConfig(id, true).Value;
	}

	// Token: 0x0600D78B RID: 55179 RVA: 0x003FF24C File Offset: 0x003FD44C
	public Reigns? TryGetReigns(int id)
	{
		return ConfigReignsById.GetConfig(id, true);
	}

	// Token: 0x0600D78C RID: 55180 RVA: 0x003FF258 File Offset: 0x003FD458
	public ReignsCard GetReignsCallCard(int id)
	{
		return ConfigReignsCardById.GetConfig(id, true).Value;
	}

	// Token: 0x170013F0 RID: 5104
	// (get) Token: 0x0600D78D RID: 55181 RVA: 0x003FF274 File Offset: 0x003FD474
	public static KingShipConfig Instance
	{
		get
		{
			return KingShipConfig._Instance;
		}
	}

	// Token: 0x0600D78E RID: 55182 RVA: 0x003FF27B File Offset: 0x003FD47B
	public static KingShipConfig GetOrCreateInstance()
	{
		if (KingShipConfig._Instance == null)
		{
			KingShipConfig.CreateInstance();
		}
		return KingShipConfig._Instance;
	}

	// Token: 0x0600D78F RID: 55183 RVA: 0x003FF28F File Offset: 0x003FD48F
	public static bool CreateInstance()
	{
		if (KingShipConfig._Instance != null)
		{
			return true;
		}
		KingShipConfig._Instance = new KingShipConfig();
		return true;
	}

	// Token: 0x0600D790 RID: 55184 RVA: 0x003FF2A5 File Offset: 0x003FD4A5
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D791 RID: 55185 RVA: 0x003FF2A7 File Offset: 0x003FD4A7
	public static void ResetStaticDefaultValue()
	{
		KingShipConfig._Instance = null;
	}

	// Token: 0x0600D792 RID: 55186 RVA: 0x003FF2AF File Offset: 0x003FD4AF
	static KingShipConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(KingShipConfig.CreateStaticDefaultValue), new Action(KingShipConfig.ResetStaticDefaultValue));
	}

	// Token: 0x040078C3 RID: 30915
	[Nullable(2)]
	private static KingShipConfig _Instance;
}
