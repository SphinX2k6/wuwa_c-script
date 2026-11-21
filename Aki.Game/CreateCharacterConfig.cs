using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x02000EA4 RID: 3748
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class CreateCharacterConfig : ConfigBase
{
	// Token: 0x060095E8 RID: 38376 RVA: 0x002C73B8 File Offset: 0x002C55B8
	public IReadOnlyList<int> GetInitialRoles()
	{
		IReadOnlyList<int> intArrayConfig = ConfigCommonParamById.GetIntArrayConfig("initial_role");
		if (intArrayConfig.Count != 2)
		{
			Log instance = Log.Instance;
			ELogModule module = ELogModule.CreateCharacter;
			ELogAuthor author = ELogAuthor.ZJC;
			string message = "初始化角色数量错误, 应该为2";
			ValueTuple<string, object> valueTuple = new ValueTuple<string, object>("count", intArrayConfig.Count);
			instance.Error(module, author, message, new ReadOnlySpan<ValueTuple<string, object>>(ref valueTuple));
		}
		return intArrayConfig;
	}

	// Token: 0x060095E9 RID: 38377 RVA: 0x002C740A File Offset: 0x002C560A
	public string GetInitName()
	{
		return ConfigCommonParamById.GetStringConfig("default_name_prefix");
	}

	// Token: 0x17001057 RID: 4183
	// (get) Token: 0x060095EA RID: 38378 RVA: 0x002C7416 File Offset: 0x002C5616
	public static CreateCharacterConfig Instance
	{
		get
		{
			return CreateCharacterConfig._Instance;
		}
	}

	// Token: 0x060095EB RID: 38379 RVA: 0x002C741D File Offset: 0x002C561D
	public static CreateCharacterConfig GetOrCreateInstance()
	{
		if (CreateCharacterConfig._Instance == null)
		{
			CreateCharacterConfig.CreateInstance();
		}
		return CreateCharacterConfig._Instance;
	}

	// Token: 0x060095EC RID: 38380 RVA: 0x002C7431 File Offset: 0x002C5631
	public static bool CreateInstance()
	{
		if (CreateCharacterConfig._Instance != null)
		{
			return true;
		}
		CreateCharacterConfig._Instance = new CreateCharacterConfig();
		return true;
	}

	// Token: 0x060095ED RID: 38381 RVA: 0x002C7447 File Offset: 0x002C5647
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x060095EE RID: 38382 RVA: 0x002C7449 File Offset: 0x002C5649
	public static void ResetStaticDefaultValue()
	{
		CreateCharacterConfig._Instance = null;
	}

	// Token: 0x060095EF RID: 38383 RVA: 0x002C7451 File Offset: 0x002C5651
	static CreateCharacterConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CreateCharacterConfig.CreateStaticDefaultValue), new Action(CreateCharacterConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005A1F RID: 23071
	[Nullable(2)]
	private static CreateCharacterConfig _Instance;
}
