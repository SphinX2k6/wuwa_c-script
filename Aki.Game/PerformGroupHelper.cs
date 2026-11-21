using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200267F RID: 9855
public class PerformGroupHelper : IStaticVariableResetter
{
	// Token: 0x06018ADC RID: 101084 RVA: 0x0077C48E File Offset: 0x0077A68E
	static PerformGroupHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformGroupHelper.CreateStaticDefaultValue), new Action(PerformGroupHelper.ResetStaticDefaultValue));
	}

	// Token: 0x06018ADD RID: 101085 RVA: 0x0077C4B0 File Offset: 0x0077A6B0
	public static void CreateStaticDefaultValue()
	{
		Dictionary<EPerformGroup, string> dictionary = new Dictionary<EPerformGroup, string>();
		dictionary[EPerformGroup.DefaultGroup] = "DefaultGroup";
		dictionary[EPerformGroup.KuroPerformSubGroup] = "Kuro表演子状态";
		PerformGroupHelper._performGroupToSlotGroupName = dictionary;
		Dictionary<string, EPerformGroup> dictionary2 = new Dictionary<string, EPerformGroup>();
		dictionary2["DefaultGroup"] = EPerformGroup.DefaultGroup;
		dictionary2["Kuro表演子状态"] = EPerformGroup.KuroPerformSubGroup;
		PerformGroupHelper._slotGroupNameToPerformGroup = dictionary2;
	}

	// Token: 0x06018ADE RID: 101086 RVA: 0x0077C501 File Offset: 0x0077A701
	public static void ResetStaticDefaultValue()
	{
		PerformGroupHelper._performGroupToSlotGroupName = null;
		PerformGroupHelper._slotGroupNameToPerformGroup = null;
	}

	// Token: 0x06018ADF RID: 101087 RVA: 0x0077C510 File Offset: 0x0077A710
	[NullableContext(2)]
	public static string GetSlotGroupName(EPerformGroup group)
	{
		string result;
		if (!PerformGroupHelper._performGroupToSlotGroupName.TryGetValue(group, out result))
		{
			return null;
		}
		return result;
	}

	// Token: 0x06018AE0 RID: 101088 RVA: 0x0077C530 File Offset: 0x0077A730
	[NullableContext(1)]
	public static EPerformGroup GetPerformGroup(string slotGroupName)
	{
		EPerformGroup result;
		if (!PerformGroupHelper._slotGroupNameToPerformGroup.TryGetValue(slotGroupName, out result))
		{
			return EPerformGroup.DefaultGroup;
		}
		return result;
	}

	// Token: 0x0400D654 RID: 54868
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<EPerformGroup, string> _performGroupToSlotGroupName;

	// Token: 0x0400D655 RID: 54869
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<string, EPerformGroup> _slotGroupNameToPerformGroup;
}
