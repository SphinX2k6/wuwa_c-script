using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B37 RID: 19255
	[NullableContext(2)]
	[Nullable(0)]
	public class PropMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17006080 RID: 24704
		// (get) Token: 0x060302CA RID: 197322 RVA: 0x00D6F254 File Offset: 0x00D6D454
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Prop;
			}
		}

		// Token: 0x0401984B RID: 104523
		public bool? IsIconHide;

		// Token: 0x0401984C RID: 104524
		public bool? IsRedDotVisible;

		// Token: 0x0401984D RID: 104525
		public bool? IsNewVisible;

		// Token: 0x0401984E RID: 104526
		public bool? IsNewOverRedDot;

		// Token: 0x0401984F RID: 104527
		public EMediumItemGridBuffType? BuffIconType;

		// Token: 0x04019850 RID: 104528
		public bool? IsLockVisible;

		// Token: 0x04019851 RID: 104529
		public bool? IsDeprecate;

		// Token: 0x04019852 RID: 104530
		public int? Level;

		// Token: 0x04019853 RID: 104531
		public bool? IsLevelInfinite;

		// Token: 0x04019854 RID: 104532
		public bool? IsLevelTextUseChangeColor;

		// Token: 0x04019855 RID: 104533
		public int? StarLevel;

		// Token: 0x04019856 RID: 104534
		public float? CoolDown;

		// Token: 0x04019857 RID: 104535
		public float? TotalCoolDown;

		// Token: 0x04019858 RID: 104536
		public bool? IsProhibit;

		// Token: 0x04019859 RID: 104537
		public LongPressButton ReduceButtonInfo;

		// Token: 0x0401985A RID: 104538
		public bool? IsGreenSelected;

		// Token: 0x0401985B RID: 104539
		public bool? IsWarning;

		// Token: 0x0401985C RID: 104540
		public bool? IsCheckTick;

		// Token: 0x0401985D RID: 104541
		public bool? IsTimeFlagVisible;

		// Token: 0x0401985E RID: 104542
		public bool? IsReceivedFlagVisible;

		// Token: 0x0401985F RID: 104543
		public RoleHeadInfo RoleHeadInfo;

		// Token: 0x04019860 RID: 104544
		public int? SortIndex;

		// Token: 0x04019861 RID: 104545
		public bool? IsDisable;

		// Token: 0x04019862 RID: 104546
		public bool? IsMainVisionVisible;

		// Token: 0x04019863 RID: 104547
		public int[] VisionSlotStateList;

		// Token: 0x04019864 RID: 104548
		public int? VisionFetterGroupId;

		// Token: 0x04019865 RID: 104549
		public VisionRoleHeadInfo VisionRoleHeadInfo;

		// Token: 0x04019866 RID: 104550
		public MediumItemGridComposeTag ComposeIconTag;

		// Token: 0x04019867 RID: 104551
		public bool? ChangeAble;

		// Token: 0x04019868 RID: 104552
		public DangoRoleHeadInfo DangoRoleHeadInfo;

		// Token: 0x04019869 RID: 104553
		public bool? IsRogueFinish;

		// Token: 0x0401986A RID: 104554
		public IMediumItemPrice ItemPrice;

		// Token: 0x0401986B RID: 104555
		public bool? IsUpGrade;

		// Token: 0x0401986C RID: 104556
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] TagPathList;

		// Token: 0x0401986D RID: 104557
		public string RightTopValue;

		// Token: 0x0401986E RID: 104558
		public bool? IsBranchUpgrade;

		// Token: 0x0401986F RID: 104559
		public string SubIconPath;

		// Token: 0x04019870 RID: 104560
		public bool? IsRecommendVisible;

		// Token: 0x04019871 RID: 104561
		public int? RoundCount;

		// Token: 0x04019872 RID: 104562
		public MediumWarningPanelInfo WarningPanelInfo;

		// Token: 0x04019873 RID: 104563
		public PhantomStackDisplay StackDisplayInfo;
	}
}
