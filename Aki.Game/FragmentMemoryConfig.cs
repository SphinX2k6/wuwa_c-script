using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02001C19 RID: 7193
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class FragmentMemoryConfig : ConfigBase
{
	// Token: 0x0600D7BE RID: 55230 RVA: 0x0031F0D9 File Offset: 0x0031D2D9
	public PhotoMemoryTopic? GetPhotoMemoryTopicById(int id)
	{
		return ConfigPhotoMemoryTopicById.GetConfig(id, true);
	}

	// Token: 0x0600D7BF RID: 55231 RVA: 0x0031F0E2 File Offset: 0x0031D2E2
	[NullableContext(2)]
	public IReadOnlyList<PhotoMemoryTopic> GetAllPhotoMemoryTopic()
	{
		return ConfigPhotoMemoryTopicAll.GetConfigList(true);
	}

	// Token: 0x0600D7C0 RID: 55232 RVA: 0x0031F0EA File Offset: 0x0031D2EA
	[NullableContext(2)]
	public IReadOnlyList<PhotoMemoryCollect> GetPhotoMemoryCollectConfigListByTopicId(int topicId)
	{
		return ConfigPhotoMemoryCollectByTopicID.GetConfigList(topicId, true);
	}

	// Token: 0x0600D7C1 RID: 55233 RVA: 0x0031F0F3 File Offset: 0x0031D2F3
	public PhotoMemoryCollect? GetPhotoMemoryCollectById(int id)
	{
		return ConfigPhotoMemoryCollectById.GetConfig(id, true);
	}

	// Token: 0x0600D7C2 RID: 55234 RVA: 0x0031F0FC File Offset: 0x0031D2FC
	public PhotoMemoryActivity? GetPhotoMemoryActivityById(int id)
	{
		return ConfigPhotoMemoryActivityById.GetConfig(id, true);
	}

	// Token: 0x0600D7C3 RID: 55235 RVA: 0x0031F105 File Offset: 0x0031D305
	public ClueEntrance? GetClueEntrance(int id)
	{
		return ConfigClueEntranceById.GetConfig(id, true);
	}

	// Token: 0x0600D7C4 RID: 55236 RVA: 0x0031F10E File Offset: 0x0031D30E
	[NullableContext(2)]
	public IReadOnlyList<ClueContent> GetClueContent(int id)
	{
		return ConfigClueContentByGroupId.GetConfigList(id, true);
	}

	// Token: 0x0600D7C5 RID: 55237 RVA: 0x0031F117 File Offset: 0x0031D317
	public string GetTopicNotOpenTexturePath()
	{
		return ConfigCommonParamById.GetStringConfig("FragmentMemoryNotOpenTexture");
	}

	// Token: 0x0600D7C6 RID: 55238 RVA: 0x0031F123 File Offset: 0x0031D323
	public string GetTopicNotOpenTextureLightPath()
	{
		return ConfigCommonParamById.GetStringConfig("FragmentMemoryNotOpenLightTexture");
	}

	// Token: 0x0600D7C7 RID: 55239 RVA: 0x0031F130 File Offset: 0x0031D330
	public int GetFragmentMemoryPreNeedItemId()
	{
		return ConfigCommonParamById.GetIntConfig("OpenFragmentNeedItem").Value;
	}

	// Token: 0x170011B4 RID: 4532
	// (get) Token: 0x0600D7C8 RID: 55240 RVA: 0x0031F14F File Offset: 0x0031D34F
	public static FragmentMemoryConfig Instance
	{
		get
		{
			return FragmentMemoryConfig._Instance;
		}
	}

	// Token: 0x0600D7C9 RID: 55241 RVA: 0x0031F156 File Offset: 0x0031D356
	public static FragmentMemoryConfig GetOrCreateInstance()
	{
		if (FragmentMemoryConfig._Instance == null)
		{
			FragmentMemoryConfig.CreateInstance();
		}
		return FragmentMemoryConfig._Instance;
	}

	// Token: 0x0600D7CA RID: 55242 RVA: 0x0031F16A File Offset: 0x0031D36A
	public static bool CreateInstance()
	{
		if (FragmentMemoryConfig._Instance != null)
		{
			return true;
		}
		FragmentMemoryConfig._Instance = new FragmentMemoryConfig();
		return true;
	}

	// Token: 0x0600D7CB RID: 55243 RVA: 0x0031F180 File Offset: 0x0031D380
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600D7CC RID: 55244 RVA: 0x0031F182 File Offset: 0x0031D382
	public static void ResetStaticDefaultValue()
	{
		FragmentMemoryConfig._Instance = null;
	}

	// Token: 0x0600D7CD RID: 55245 RVA: 0x0031F18A File Offset: 0x0031D38A
	static FragmentMemoryConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(FragmentMemoryConfig.CreateStaticDefaultValue), new Action(FragmentMemoryConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04006280 RID: 25216
	[Nullable(2)]
	private static FragmentMemoryConfig _Instance;
}
