using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x0200201F RID: 8223
public class SpecialItemDefine : IStaticVariableResetter
{
	// Token: 0x060101EA RID: 66026 RVA: 0x003ECE31 File Offset: 0x003EB031
	static SpecialItemDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialItemDefine.CreateStaticDefaultValue), new Action(SpecialItemDefine.ResetStaticDefaultValue));
	}

	// Token: 0x060101EB RID: 66027 RVA: 0x003ECE50 File Offset: 0x003EB050
	public static void CreateStaticDefaultValue()
	{
		SpecialItemDefine.specialItemLogic = new Dictionary<SpecialItemDefine.ESpecialItemType, Type>
		{
			{
				SpecialItemDefine.ESpecialItemType.EntityCamera,
				typeof(SpecialItemLogicEntityCamera)
			}
		};
		SpecialItemDefine.SpecialItemIdSet = new HashSet<SpecialItemDefine.ESpecialItemType>
		{
			SpecialItemDefine.ESpecialItemType.EntityCamera
		};
	}

	// Token: 0x060101EC RID: 66028 RVA: 0x003ECE87 File Offset: 0x003EB087
	public static void ResetStaticDefaultValue()
	{
		SpecialItemDefine.specialItemLogic = null;
		SpecialItemDefine.SpecialItemIdSet = null;
	}

	// Token: 0x04007748 RID: 30536
	[Nullable(1)]
	public static Dictionary<SpecialItemDefine.ESpecialItemType, Type> specialItemLogic;

	// Token: 0x04007749 RID: 30537
	[Nullable(1)]
	public static HashSet<SpecialItemDefine.ESpecialItemType> SpecialItemIdSet;

	// Token: 0x02008615 RID: 34325
	public enum ESpecialItemEquipType
	{
		// Token: 0x0402BA26 RID: 178726
		Equipped,
		// Token: 0x0402BA27 RID: 178727
		Portable,
		// Token: 0x0402BA28 RID: 178728
		FragmentMemory
	}

	// Token: 0x02008616 RID: 34326
	public enum ESpecialItemType
	{
		// Token: 0x0402BA2A RID: 178730
		EntityCamera = 70140001
	}
}
