using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020010D8 RID: 4312
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FragmentMemoryConfig : ConfigBase
{
	// Token: 0x0600ABD2 RID: 43986 RVA: 0x0032A429 File Offset: 0x00328629
	public PhotoMemoryTopic? GetPhotoMemoryTopicById(int id)
	{
		return ConfigPhotoMemoryTopicById.GetConfig(id, true);
	}

	// Token: 0x0600ABD3 RID: 43987 RVA: 0x0032A432 File Offset: 0x00328632
	[NullableContext(2)]
	public IReadOnlyList<PhotoMemoryTopic> GetAllPhotoMemoryTopic()
	{
		return ConfigPhotoMemoryTopicAll.GetConfigList(true);
	}

	// Token: 0x0600ABD4 RID: 43988 RVA: 0x0032A43A File Offset: 0x0032863A
	[NullableContext(2)]
	public IReadOnlyList<PhotoMemoryCollect> GetPhotoMemoryCollectConfigListByTopicId(int topicId)
	{
		return ConfigPhotoMemoryCollectByTopicID.GetConfigList(topicId, true);
	}

	// Token: 0x0600ABD5 RID: 43989 RVA: 0x0032A443 File Offset: 0x00328643
	public PhotoMemoryCollect? GetPhotoMemoryCollectById(int id)
	{
		return ConfigPhotoMemoryCollectById.GetConfig(id, true);
	}

	// Token: 0x0600ABD6 RID: 43990 RVA: 0x0032A44C File Offset: 0x0032864C
	public PhotoMemoryActivity? GetPhotoMemoryActivityById(int id)
	{
		return ConfigPhotoMemoryActivityById.GetConfig(id, true);
	}

	// Token: 0x0600ABD7 RID: 43991 RVA: 0x0032A455 File Offset: 0x00328655
	public ClueEntrance? GetClueEntrance(int id)
	{
		return ConfigClueEntranceById.GetConfig(id, true);
	}

	// Token: 0x0600ABD8 RID: 43992 RVA: 0x0032A45E File Offset: 0x0032865E
	[NullableContext(2)]
	public IReadOnlyList<ClueContent> GetClueContent(int id)
	{
		return ConfigClueContentByGroupId.GetConfigList(id, true);
	}

	// Token: 0x0600ABD9 RID: 43993 RVA: 0x0032A467 File Offset: 0x00328667
	public string GetTopicNotOpenTexturePath()
	{
		return ConfigCommonParamById.GetStringConfig("FragmentMemoryNotOpenTexture");
	}

	// Token: 0x0600ABDA RID: 43994 RVA: 0x0032A473 File Offset: 0x00328673
	public string GetTopicNotOpenTextureLightPath()
	{
		return ConfigCommonParamById.GetStringConfig("FragmentMemoryNotOpenLightTexture");
	}

	// Token: 0x0600ABDB RID: 43995 RVA: 0x0032A480 File Offset: 0x00328680
	public int GetFragmentMemoryPreNeedItemId()
	{
		return ConfigCommonParamById.GetIntConfig("OpenFragmentNeedItem").Value;
	}

	// Token: 0x170011DA RID: 4570
	// (get) Token: 0x0600ABDC RID: 43996 RVA: 0x0032A49F File Offset: 0x0032869F
	public static FragmentMemoryConfig Instance
	{
		get
		{
			return FragmentMemoryConfig._Instance;
		}
	}

	// Token: 0x0600ABDD RID: 43997 RVA: 0x0032A4A6 File Offset: 0x003286A6
	public static FragmentMemoryConfig GetOrCreateInstance()
	{
		if (FragmentMemoryConfig._Instance == null)
		{
			FragmentMemoryConfig.CreateInstance();
		}
		return FragmentMemoryConfig._Instance;
	}

	// Token: 0x0600ABDE RID: 43998 RVA: 0x0032A4BA File Offset: 0x003286BA
	public static bool CreateInstance()
	{
		if (FragmentMemoryConfig._Instance != null)
		{
			return true;
		}
		FragmentMemoryConfig._Instance = new FragmentMemoryConfig();
		return true;
	}

	// Token: 0x0600ABDF RID: 43999 RVA: 0x0032A4D0 File Offset: 0x003286D0
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600ABE0 RID: 44000 RVA: 0x0032A4D2 File Offset: 0x003286D2
	public static void ResetStaticDefaultValue()
	{
		FragmentMemoryConfig._Instance = null;
	}

	// Token: 0x0600ABE1 RID: 44001 RVA: 0x0032A4DA File Offset: 0x003286DA
	static FragmentMemoryConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FragmentMemoryConfig.CreateStaticDefaultValue), new Action(FragmentMemoryConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006352 RID: 25426
	[Nullable(2)]
	private static FragmentMemoryConfig _Instance;
}
