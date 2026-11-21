using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B3C RID: 19260
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17006081 RID: 24705
		// (get) Token: 0x060302CE RID: 197326 RVA: 0x00D6F26F File Offset: 0x00D6D46F
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Phantom;
			}
		}

		// Token: 0x04019881 RID: 104577
		public bool? IsRedDotVisible;

		// Token: 0x04019882 RID: 104578
		public string QualityIconResourceId;

		// Token: 0x04019883 RID: 104579
		public int? Level;

		// Token: 0x04019884 RID: 104580
		public bool? IsLevelTextUseChangeColor;

		// Token: 0x04019885 RID: 104581
		public int? MonsterId;

		// Token: 0x04019886 RID: 104582
		public int? StarLevel;

		// Token: 0x04019887 RID: 104583
		public bool? IsMainVisionVisible;

		// Token: 0x04019888 RID: 104584
		public RoleHeadInfo RoleHeadInfo;

		// Token: 0x04019889 RID: 104585
		public int[] VisionSlotStateList;

		// Token: 0x0401988A RID: 104586
		public bool? IsNewVisible;

		// Token: 0x0401988B RID: 104587
		public bool? IsLockVisible;

		// Token: 0x0401988C RID: 104588
		public bool? IsDeprecate;

		// Token: 0x0401988D RID: 104589
		public bool? IsPhantomLock;

		// Token: 0x0401988E RID: 104590
		public DevelopRewardInfo DevelopRewardInfo;

		// Token: 0x0401988F RID: 104591
		public int? FetterGroupId;

		// Token: 0x04019890 RID: 104592
		public VisionRoleHeadInfo VisionRoleHeadInfo;

		// Token: 0x04019891 RID: 104593
		public EMediumItemGridPhantomSpecialSkill? SpecialSkill;

		// Token: 0x04019892 RID: 104594
		public int? SortNum;

		// Token: 0x04019893 RID: 104595
		public bool? IsDisable;

		// Token: 0x04019894 RID: 104596
		public MediumWarningPanelInfo WarningPanelInfo;

		// Token: 0x04019895 RID: 104597
		public PhantomStackDisplay StackDisplayInfo;

		// Token: 0x04019896 RID: 104598
		public int? RoleTowerEnemyLevel;

		// Token: 0x04019897 RID: 104599
		public int? RoleTowerElementId;
	}
}
