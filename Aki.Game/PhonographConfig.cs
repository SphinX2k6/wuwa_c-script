using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001A37 RID: 6711
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PhonographConfig : ConfigBase
{
	// Token: 0x06010888 RID: 67720 RVA: 0x004D70B3 File Offset: 0x004D52B3
	[NullableContext(2)]
	public IReadOnlyList<PhonographMusic> GetMusicList()
	{
		return ConfigPhonographMusicAll.GetConfigList(true);
	}

	// Token: 0x06010889 RID: 67721 RVA: 0x004D70BB File Offset: 0x004D52BB
	public PhonographMusic? GetMusicById(int id)
	{
		return ConfigPhonographMusicById.GetConfig(id, true);
	}

	// Token: 0x0601088A RID: 67722 RVA: 0x004D70C4 File Offset: 0x004D52C4
	[NullableContext(2)]
	public IReadOnlyList<PhonographAlbum> GetMusicAlbumList()
	{
		return ConfigPhonographAlbumAll.GetConfigList(true);
	}

	// Token: 0x0601088B RID: 67723 RVA: 0x004D70CC File Offset: 0x004D52CC
	public PhonographAlbum? GetMusicAlbumById(int id)
	{
		return ConfigPhonographAlbumById.GetConfig(id, true);
	}

	// Token: 0x17001911 RID: 6417
	// (get) Token: 0x0601088C RID: 67724 RVA: 0x004D70D5 File Offset: 0x004D52D5
	public static PhonographConfig Instance
	{
		get
		{
			return PhonographConfig._Instance;
		}
	}

	// Token: 0x0601088D RID: 67725 RVA: 0x004D70DC File Offset: 0x004D52DC
	public static PhonographConfig GetOrCreateInstance()
	{
		if (PhonographConfig._Instance == null)
		{
			PhonographConfig.CreateInstance();
		}
		return PhonographConfig._Instance;
	}

	// Token: 0x0601088E RID: 67726 RVA: 0x004D70F0 File Offset: 0x004D52F0
	public static bool CreateInstance()
	{
		if (PhonographConfig._Instance != null)
		{
			return true;
		}
		PhonographConfig._Instance = new PhonographConfig();
		return true;
	}

	// Token: 0x0601088F RID: 67727 RVA: 0x004D7106 File Offset: 0x004D5306
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x06010890 RID: 67728 RVA: 0x004D7108 File Offset: 0x004D5308
	public static void ResetStaticDefaultValue()
	{
		PhonographConfig._Instance = null;
	}

	// Token: 0x06010891 RID: 67729 RVA: 0x004D7110 File Offset: 0x004D5310
	static PhonographConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhonographConfig.CreateStaticDefaultValue), new Action(PhonographConfig.ResetStaticDefaultValue));
	}

	// Token: 0x0400928F RID: 37519
	[Nullable(2)]
	private static PhonographConfig _Instance;
}
