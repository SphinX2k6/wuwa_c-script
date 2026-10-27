using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Aki.Config;

// Token: 0x020019E5 RID: 6629
[NullableContext(1)]
[Nullable(0)]
[Config(0)]
public class CreateCharacterConfig : ConfigBase
{
	// Token: 0x0600C1DB RID: 49627 RVA: 0x002BC3E0 File Offset: 0x002BA5E0
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

	// Token: 0x0600C1DC RID: 49628 RVA: 0x002BC432 File Offset: 0x002BA632
	public string GetInitName()
	{
		return ConfigCommonParamById.GetStringConfig("default_name_prefix");
	}

	// Token: 0x17001032 RID: 4146
	// (get) Token: 0x0600C1DD RID: 49629 RVA: 0x002BC43E File Offset: 0x002BA63E
	public static CreateCharacterConfig Instance
	{
		get
		{
			return CreateCharacterConfig._Instance;
		}
	}

	// Token: 0x0600C1DE RID: 49630 RVA: 0x002BC445 File Offset: 0x002BA645
	public static CreateCharacterConfig GetOrCreateInstance()
	{
		if (CreateCharacterConfig._Instance == null)
		{
			CreateCharacterConfig.CreateInstance();
		}
		return CreateCharacterConfig._Instance;
	}

	// Token: 0x0600C1DF RID: 49631 RVA: 0x002BC459 File Offset: 0x002BA659
	public static bool CreateInstance()
	{
		if (CreateCharacterConfig._Instance != null)
		{
			return true;
		}
		CreateCharacterConfig._Instance = new CreateCharacterConfig();
		return true;
	}

	// Token: 0x0600C1E0 RID: 49632 RVA: 0x002BC46F File Offset: 0x002BA66F
	public static void CreateStaticDefaultValue()
	{
	}

	// Token: 0x0600C1E1 RID: 49633 RVA: 0x002BC471 File Offset: 0x002BA671
	public static void ResetStaticDefaultValue()
	{
		CreateCharacterConfig._Instance = null;
	}

	// Token: 0x0600C1E2 RID: 49634 RVA: 0x002BC479 File Offset: 0x002BA679
	static CreateCharacterConfig()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(CreateCharacterConfig.CreateStaticDefaultValue), new Action(CreateCharacterConfig.ResetStaticDefaultValue));
	}

	// Token: 0x04005950 RID: 22864
	[Nullable(2)]
	private static CreateCharacterConfig _Instance;
}
