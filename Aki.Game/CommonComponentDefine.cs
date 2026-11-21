using System;
using System.Runtime.CompilerServices;

// Token: 0x02000CA9 RID: 3241
public class CommonComponentDefine
{
	// Token: 0x040051E3 RID: 20963
	public const int WEAPON_ITEMTYPE = 2;

	// Token: 0x040051E4 RID: 20964
	public const int WEAPONMATERIAL_ITEMTYPE = 4;

	// Token: 0x040051E5 RID: 20965
	public const float UNPHANTOMTYPEALPHA = 0.5f;

	// Token: 0x040051E6 RID: 20966
	public const int PHANTOMTYPEALPHA = 1;

	// Token: 0x040051E7 RID: 20967
	public const int MINLEVEL = 5;

	// Token: 0x040051E8 RID: 20968
	public const int RATIO = 2;

	// Token: 0x040051E9 RID: 20969
	public const int FIXED = 1;

	// Token: 0x02006F64 RID: 28516
	public enum ECommonTipsType
	{
		// Token: 0x0402464F RID: 149071
		Weapon = 2,
		// Token: 0x04024650 RID: 149072
		Phantom = 9
	}

	// Token: 0x02006F65 RID: 28517
	public enum ECommonTipsHighType
	{
		// Token: 0x04024652 RID: 149074
		WeaponType,
		// Token: 0x04024653 RID: 149075
		PhantomType
	}

	// Token: 0x02006F66 RID: 28518
	public enum ENurturePropType
	{
		// Token: 0x04024655 RID: 149077
		Weapon = 2,
		// Token: 0x04024656 RID: 149078
		WeaponMaterial = 4
	}

	// Token: 0x02006F67 RID: 28519
	public enum ENurturePropUseType
	{
		// Token: 0x04024658 RID: 149080
		UseItemId,
		// Token: 0x04024659 RID: 149081
		UseIncId
	}

	// Token: 0x02006F68 RID: 28520
	public class TipsAttributeData
	{
		// Token: 0x0603FF09 RID: 261897 RVA: 0x012B9A92 File Offset: 0x012B7C92
		public TipsAttributeData(int id, double value, bool isRatio)
		{
			this.Id = id;
			this.Value = value;
			this.IsRatio = isRatio;
		}

		// Token: 0x0402465A RID: 149082
		public int Id;

		// Token: 0x0402465B RID: 149083
		public double Value;

		// Token: 0x0402465C RID: 149084
		public bool IsRatio;
	}

	// Token: 0x02006F69 RID: 28521
	[NullableContext(1)]
	[Nullable(0)]
	public class NurturePropItemData
	{
		// Token: 0x0402465D RID: 149085
		public int Id;

		// Token: 0x0402465E RID: 149086
		public int Count;

		// Token: 0x0402465F RID: 149087
		public CommonComponentDefine.ENurturePropType ItemType = CommonComponentDefine.ENurturePropType.Weapon;

		// Token: 0x04024660 RID: 149088
		public string BottomText = "";

		// Token: 0x04024661 RID: 149089
		public string TopText = "";

		// Token: 0x04024662 RID: 149090
		public int RoleId;

		// Token: 0x04024663 RID: 149091
		public bool IsSingle;

		// Token: 0x04024664 RID: 149092
		public int? HoleId;
	}

	// Token: 0x02006F6A RID: 28522
	public enum EAttributeType
	{
		// Token: 0x04024666 RID: 149094
		NormalType,
		// Token: 0x04024667 RID: 149095
		PhantomType,
		// Token: 0x04024668 RID: 149096
		VisionLevelUp,
		// Token: 0x04024669 RID: 149097
		VisionSlotLevelUp,
		// Token: 0x0402466A RID: 149098
		VisionSlot
	}
}
