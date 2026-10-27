using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B58 RID: 23384
	[NullableContext(2)]
	[Nullable(0)]
	public class PropMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17008CAE RID: 36014
		// (get) Token: 0x0603B37E RID: 242558 RVA: 0x00E1ECE8 File Offset: 0x00E1CEE8
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Prop;
			}
		}

		// Token: 0x0401ED9F RID: 126367
		public bool? IsIconHide;

		// Token: 0x0401EDA0 RID: 126368
		public bool? IsRedDotVisible;

		// Token: 0x0401EDA1 RID: 126369
		public bool? IsNewVisible;

		// Token: 0x0401EDA2 RID: 126370
		public bool? IsNewOverRedDot;

		// Token: 0x0401EDA3 RID: 126371
		public EMediumItemGridBuffType? BuffIconType;

		// Token: 0x0401EDA4 RID: 126372
		public bool? IsLockVisible;

		// Token: 0x0401EDA5 RID: 126373
		public bool? IsDeprecate;

		// Token: 0x0401EDA6 RID: 126374
		public int? Level;

		// Token: 0x0401EDA7 RID: 126375
		public bool? IsLevelInfinite;

		// Token: 0x0401EDA8 RID: 126376
		public bool? IsLevelTextUseChangeColor;

		// Token: 0x0401EDA9 RID: 126377
		public int? StarLevel;

		// Token: 0x0401EDAA RID: 126378
		public float? CoolDown;

		// Token: 0x0401EDAB RID: 126379
		public float? TotalCoolDown;

		// Token: 0x0401EDAC RID: 126380
		public bool? IsProhibit;

		// Token: 0x0401EDAD RID: 126381
		public LongPressButton ReduceButtonInfo;

		// Token: 0x0401EDAE RID: 126382
		public bool? IsGreenSelected;

		// Token: 0x0401EDAF RID: 126383
		public bool? IsWarning;

		// Token: 0x0401EDB0 RID: 126384
		public bool? IsCheckTick;

		// Token: 0x0401EDB1 RID: 126385
		public bool? IsTimeFlagVisible;

		// Token: 0x0401EDB2 RID: 126386
		public bool? IsReceivedFlagVisible;

		// Token: 0x0401EDB3 RID: 126387
		public RoleHeadInfo RoleHeadInfo;

		// Token: 0x0401EDB4 RID: 126388
		public int? SortIndex;

		// Token: 0x0401EDB5 RID: 126389
		public bool? IsDisable;

		// Token: 0x0401EDB6 RID: 126390
		public bool? IsMainVisionVisible;

		// Token: 0x0401EDB7 RID: 126391
		public int[] VisionSlotStateList;

		// Token: 0x0401EDB8 RID: 126392
		public int? VisionFetterGroupId;

		// Token: 0x0401EDB9 RID: 126393
		public VisionRoleHeadInfo VisionRoleHeadInfo;

		// Token: 0x0401EDBA RID: 126394
		public MediumItemGridComposeTag ComposeIconTag;

		// Token: 0x0401EDBB RID: 126395
		public bool? ChangeAble;

		// Token: 0x0401EDBC RID: 126396
		public DangoRoleHeadInfo DangoRoleHeadInfo;

		// Token: 0x0401EDBD RID: 126397
		public bool? IsRogueFinish;

		// Token: 0x0401EDBE RID: 126398
		public IMediumItemPrice ItemPrice;

		// Token: 0x0401EDBF RID: 126399
		public bool? IsUpGrade;

		// Token: 0x0401EDC0 RID: 126400
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public string[] TagPathList;

		// Token: 0x0401EDC1 RID: 126401
		public string RightTopValue;

		// Token: 0x0401EDC2 RID: 126402
		public bool? IsBranchUpgrade;

		// Token: 0x0401EDC3 RID: 126403
		public string SubIconPath;

		// Token: 0x0401EDC4 RID: 126404
		public bool? IsRecommendVisible;

		// Token: 0x0401EDC5 RID: 126405
		public int? RoundCount;

		// Token: 0x0401EDC6 RID: 126406
		public MediumWarningPanelInfo WarningPanelInfo;

		// Token: 0x0401EDC7 RID: 126407
		public PhantomStackDisplay StackDisplayInfo;
	}
}
