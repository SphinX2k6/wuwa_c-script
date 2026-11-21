using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Input;

// Token: 0x02000C9A RID: 3226
public class ComboTeachingNodeDefine : IStaticVariableResetter
{
	// Token: 0x0600868E RID: 34446 RVA: 0x0028F911 File Offset: 0x0028DB11
	static ComboTeachingNodeDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(ComboTeachingNodeDefine.CreateStaticDefaultValue), new Action(ComboTeachingNodeDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600868F RID: 34447 RVA: 0x0028F930 File Offset: 0x0028DB30
	public static void CreateStaticDefaultValue()
	{
		Dictionary<string, EInputAction> dictionary = new Dictionary<string, EInputAction>();
		dictionary["攻击"] = EInputAction.攻击;
		dictionary["技能"] = EInputAction.技能1;
		dictionary["大招"] = EInputAction.大招;
		dictionary["跳跃"] = EInputAction.跳跃;
		dictionary["瞄准"] = EInputAction.瞄准;
		dictionary["闪避"] = EInputAction.闪避;
		dictionary["普通#1"] = EInputAction.攻击;
		dictionary["技能#1"] = EInputAction.技能1;
		dictionary["大招#1"] = EInputAction.大招;
		dictionary["跳跃#1"] = EInputAction.跳跃;
		dictionary["瞄准#1"] = EInputAction.瞄准;
		dictionary["闪避#1"] = EInputAction.闪避;
		ComboTeachingNodeDefine.KeyMap = dictionary;
		Dictionary<string, string> dictionary2 = new Dictionary<string, string>();
		dictionary2["攻击"] = "攻击";
		dictionary2["技能"] = "技能1";
		dictionary2["大招"] = "大招";
		dictionary2["跳跃"] = "跳跃";
		dictionary2["瞄准"] = "瞄准";
		dictionary2["闪避"] = "闪避";
		dictionary2["普通#1"] = "攻击";
		dictionary2["技能#1"] = "技能1";
		dictionary2["大招#1"] = "大招";
		dictionary2["跳跃#1"] = "跳跃";
		dictionary2["瞄准#1"] = "瞄准";
		dictionary2["闪避#1"] = "闪避";
		ComboTeachingNodeDefine.ActionMap = dictionary2;
	}

	// Token: 0x06008690 RID: 34448 RVA: 0x0028FAD1 File Offset: 0x0028DCD1
	public static void ResetStaticDefaultValue()
	{
		ComboTeachingNodeDefine.KeyMap = null;
		ComboTeachingNodeDefine.ActionMap = null;
	}

	// Token: 0x040051A9 RID: 20905
	[Nullable(new byte[]
	{
		2,
		1
	})]
	public static Dictionary<string, EInputAction> KeyMap;

	// Token: 0x040051AA RID: 20906
	[Nullable(new byte[]
	{
		2,
		1,
		1
	})]
	public static Dictionary<string, string> ActionMap;
}
