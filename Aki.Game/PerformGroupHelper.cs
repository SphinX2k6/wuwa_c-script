using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x02003124 RID: 12580
public class PerformGroupHelper : IStaticVariableResetter
{
	// Token: 0x0601B081 RID: 110721 RVA: 0x00756422 File Offset: 0x00754622
	static PerformGroupHelper()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(PerformGroupHelper.CreateStaticDefaultValue), new Action(PerformGroupHelper.ResetStaticDefaultValue));
	}

	// Token: 0x0601B082 RID: 110722 RVA: 0x00756444 File Offset: 0x00754644
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

	// Token: 0x0601B083 RID: 110723 RVA: 0x00756495 File Offset: 0x00754695
	public static void ResetStaticDefaultValue()
	{
		PerformGroupHelper._performGroupToSlotGroupName = null;
		PerformGroupHelper._slotGroupNameToPerformGroup = null;
	}

	// Token: 0x0601B084 RID: 110724 RVA: 0x007564A4 File Offset: 0x007546A4
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

	// Token: 0x0601B085 RID: 110725 RVA: 0x007564C4 File Offset: 0x007546C4
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

	// Token: 0x0400D232 RID: 53810
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<EPerformGroup, string> _performGroupToSlotGroupName;

	// Token: 0x0400D233 RID: 53811
	[Nullable(new byte[]
	{
		2,
		1
	})]
	private static Dictionary<string, EPerformGroup> _slotGroupNameToPerformGroup;
}
