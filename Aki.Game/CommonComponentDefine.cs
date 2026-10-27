using System;
using System.Runtime.CompilerServices;

// Token: 0x020017F0 RID: 6128
public class CommonComponentDefine
{
	// Token: 0x04005138 RID: 20792
	public const int WEAPON_ITEMTYPE = 2;

	// Token: 0x04005139 RID: 20793
	public const int WEAPONMATERIAL_ITEMTYPE = 4;

	// Token: 0x0400513A RID: 20794
	public const float UNPHANTOMTYPEALPHA = 0.5f;

	// Token: 0x0400513B RID: 20795
	public const int PHANTOMTYPEALPHA = 1;

	// Token: 0x0400513C RID: 20796
	public const int MINLEVEL = 5;

	// Token: 0x0400513D RID: 20797
	public const int RATIO = 2;

	// Token: 0x0400513E RID: 20798
	public const int FIXED = 1;

	// Token: 0x02007DDE RID: 32222
	public enum ECommonTipsType
	{
		// Token: 0x04029324 RID: 168740
		Weapon = 2,
		// Token: 0x04029325 RID: 168741
		Phantom = 9
	}

	// Token: 0x02007DDF RID: 32223
	public enum ECommonTipsHighType
	{
		// Token: 0x04029327 RID: 168743
		WeaponType,
		// Token: 0x04029328 RID: 168744
		PhantomType
	}

	// Token: 0x02007DE0 RID: 32224
	public enum ENurturePropType
	{
		// Token: 0x0402932A RID: 168746
		Weapon = 2,
		// Token: 0x0402932B RID: 168747
		WeaponMaterial = 4
	}

	// Token: 0x02007DE1 RID: 32225
	public enum ENurturePropUseType
	{
		// Token: 0x0402932D RID: 168749
		UseItemId,
		// Token: 0x0402932E RID: 168750
		UseIncId
	}

	// Token: 0x02007DE2 RID: 32226
	public class TipsAttributeData
	{
		// Token: 0x06049AFA RID: 301818 RVA: 0x013168C2 File Offset: 0x01314AC2
		public TipsAttributeData(int id, double value, bool isRatio)
		{
			this.Id = id;
			this.Value = value;
			this.IsRatio = isRatio;
		}

		// Token: 0x0402932F RID: 168751
		public int Id;

		// Token: 0x04029330 RID: 168752
		public double Value;

		// Token: 0x04029331 RID: 168753
		public bool IsRatio;
	}

	// Token: 0x02007DE3 RID: 32227
	[NullableContext(1)]
	[Nullable(0)]
	public class NurturePropItemData
	{
		// Token: 0x04029332 RID: 168754
		public int Id;

		// Token: 0x04029333 RID: 168755
		public int Count;

		// Token: 0x04029334 RID: 168756
		public CommonComponentDefine.ENurturePropType ItemType = CommonComponentDefine.ENurturePropType.Weapon;

		// Token: 0x04029335 RID: 168757
		public string BottomText = "";

		// Token: 0x04029336 RID: 168758
		public string TopText = "";

		// Token: 0x04029337 RID: 168759
		public int RoleId;

		// Token: 0x04029338 RID: 168760
		public bool IsSingle;

		// Token: 0x04029339 RID: 168761
		public int? HoleId;
	}

	// Token: 0x02007DE4 RID: 32228
	public enum EAttributeType
	{
		// Token: 0x0402933B RID: 168763
		NormalType,
		// Token: 0x0402933C RID: 168764
		PhantomType,
		// Token: 0x0402933D RID: 168765
		VisionLevelUp,
		// Token: 0x0402933E RID: 168766
		VisionSlotLevelUp,
		// Token: 0x0402933F RID: 168767
		VisionSlot
	}
}
