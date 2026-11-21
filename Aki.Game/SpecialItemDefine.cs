using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

// Token: 0x020014F2 RID: 5362
public class SpecialItemDefine : IStaticVariableResetter
{
	// Token: 0x0600D652 RID: 54866 RVA: 0x003F9429 File Offset: 0x003F7629
	static SpecialItemDefine()
	{
		StaticVariableRegister.RegisterAndExecute(new Action(SpecialItemDefine.CreateStaticDefaultValue), new Action(SpecialItemDefine.ResetStaticDefaultValue));
	}

	// Token: 0x0600D653 RID: 54867 RVA: 0x003F9448 File Offset: 0x003F7648
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

	// Token: 0x0600D654 RID: 54868 RVA: 0x003F947F File Offset: 0x003F767F
	public static void ResetStaticDefaultValue()
	{
		SpecialItemDefine.specialItemLogic = null;
		SpecialItemDefine.SpecialItemIdSet = null;
	}

	// Token: 0x04007831 RID: 30769
	[Nullable(1)]
	public static Dictionary<SpecialItemDefine.ESpecialItemType, Type> specialItemLogic;

	// Token: 0x04007832 RID: 30770
	[Nullable(1)]
	public static HashSet<SpecialItemDefine.ESpecialItemType> SpecialItemIdSet;

	// Token: 0x0200779C RID: 30620
	public enum ESpecialItemEquipType
	{
		// Token: 0x04026D35 RID: 159029
		Equipped,
		// Token: 0x04026D36 RID: 159030
		Portable,
		// Token: 0x04026D37 RID: 159031
		FragmentMemory
	}

	// Token: 0x0200779D RID: 30621
	public enum ESpecialItemType
	{
		// Token: 0x04026D39 RID: 159033
		EntityCamera = 70140001
	}
}
