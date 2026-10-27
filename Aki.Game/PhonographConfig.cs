using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x0200254C RID: 9548
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class PhonographConfig : ConfigBase
{
	// Token: 0x060133A8 RID: 78760 RVA: 0x004C8537 File Offset: 0x004C6737
	[NullableContext(2)]
	public IReadOnlyList<PhonographMusic> GetMusicList()
	{
		return ConfigPhonographMusicAll.GetConfigList(true);
	}

	// Token: 0x060133A9 RID: 78761 RVA: 0x004C853F File Offset: 0x004C673F
	public PhonographMusic? GetMusicById(int id)
	{
		return ConfigPhonographMusicById.GetConfig(id, true);
	}

	// Token: 0x060133AA RID: 78762 RVA: 0x004C8548 File Offset: 0x004C6748
	[NullableContext(2)]
	public IReadOnlyList<PhonographAlbum> GetMusicAlbumList()
	{
		return ConfigPhonographAlbumAll.GetConfigList(true);
	}

	// Token: 0x060133AB RID: 78763 RVA: 0x004C8550 File Offset: 0x004C6750
	public PhonographAlbum? GetMusicAlbumById(int id)
	{
		return ConfigPhonographAlbumById.GetConfig(id, true);
	}

	// Token: 0x170018D8 RID: 6360
	// (get) Token: 0x060133AC RID: 78764 RVA: 0x004C8559 File Offset: 0x004C6759
	public static PhonographConfig Instance
	{
		get
		{
			return PhonographConfig._Instance;
		}
	}

	// Token: 0x060133AD RID: 78765 RVA: 0x004C8560 File Offset: 0x004C6760
	public static PhonographConfig GetOrCreateInstance()
	{
		if (PhonographConfig._Instance == null)
		{
			PhonographConfig.CreateInstance();
		}
		return PhonographConfig._Instance;
	}

	// Token: 0x060133AE RID: 78766 RVA: 0x004C8574 File Offset: 0x004C6774
	public static bool CreateInstance()
	{
		if (PhonographConfig._Instance != null)
		{
			return true;
		}
		PhonographConfig._Instance = new PhonographConfig();
		return true;
	}

	// Token: 0x060133AF RID: 78767 RVA: 0x004C858A File Offset: 0x004C678A
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060133B0 RID: 78768 RVA: 0x004C858C File Offset: 0x004C678C
	public static void ResetStaticDefaultValue()
	{
		PhonographConfig._Instance = null;
	}

	// Token: 0x060133B1 RID: 78769 RVA: 0x004C8594 File Offset: 0x004C6794
	static PhonographConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PhonographConfig.CreateStaticDefaultValue), new Action(PhonographConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04009136 RID: 37174
	[Nullable(2)]
	private static PhonographConfig _Instance;
}
