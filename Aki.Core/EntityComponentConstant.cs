using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200007C RID: 124
public class EntityComponentConstant : IStaticVariableResetter
{
	// Token: 0x060003A2 RID: 930 RVA: 0x00016761 File Offset: 0x00014961
	static EntityComponentConstant()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(EntityComponentConstant.CreateStaticDefaultValue), new Action(EntityComponentConstant.ResetStaticDefaultValue));
	}

	// Token: 0x17000087 RID: 135
	// (get) Token: 0x060003A3 RID: 931 RVA: 0x00016780 File Offset: 0x00014980
	[Nullable(new byte[]
	{
		1,
		1,
		1,
		2
	})]
	public static Dictionary<string, Stat[]> StatMap
	{
		[return: Nullable(new byte[]
		{
			1,
			1,
			1,
			2
		})]
		get
		{
			Dictionary<string, Stat[]> result;
			if ((result = EntityComponentConstant._statMap) == null)
			{
				result = (EntityComponentConstant._statMap = new Dictionary<string, Stat[]>());
			}
			return result;
		}
	}

	// Token: 0x060003A4 RID: 932 RVA: 0x00016796 File Offset: 0x00014996
	public static void CreateStaticDefaultValue()
	{
		EntityComponentConstant._statMap = new Dictionary<string, Stat[]>();
	}

	// Token: 0x060003A5 RID: 933 RVA: 0x000167A2 File Offset: 0x000149A2
	public static void ResetStaticDefaultValue()
	{
		EntityComponentConstant._statMap = null;
		EntityComponentConstant.ComponentTypeToIndexHook = null;
	}

	// Token: 0x0400038E RID: 910
	[Nullable(new byte[]
	{
		2,
		1,
		1,
		2
	})]
	private static Dictionary<string, Stat[]> _statMap;

	// Token: 0x0400038F RID: 911
	[Nullable(1)]
	public static Func<string, int> ComponentTypeToIndexHook;
}
