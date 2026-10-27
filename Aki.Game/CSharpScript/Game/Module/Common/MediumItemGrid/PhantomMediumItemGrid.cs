using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B5D RID: 23389
	[NullableContext(2)]
	[Nullable(0)]
	public class PhantomMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17008CAF RID: 36015
		// (get) Token: 0x0603B382 RID: 242562 RVA: 0x00E1ED03 File Offset: 0x00E1CF03
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Phantom;
			}
		}

		// Token: 0x0401EDD5 RID: 126421
		public bool? IsRedDotVisible;

		// Token: 0x0401EDD6 RID: 126422
		public string QualityIconResourceId;

		// Token: 0x0401EDD7 RID: 126423
		public int? Level;

		// Token: 0x0401EDD8 RID: 126424
		public bool? IsLevelTextUseChangeColor;

		// Token: 0x0401EDD9 RID: 126425
		public int? MonsterId;

		// Token: 0x0401EDDA RID: 126426
		public int? StarLevel;

		// Token: 0x0401EDDB RID: 126427
		public bool? IsMainVisionVisible;

		// Token: 0x0401EDDC RID: 126428
		public RoleHeadInfo RoleHeadInfo;

		// Token: 0x0401EDDD RID: 126429
		public int[] VisionSlotStateList;

		// Token: 0x0401EDDE RID: 126430
		public bool? IsNewVisible;

		// Token: 0x0401EDDF RID: 126431
		public bool? IsLockVisible;

		// Token: 0x0401EDE0 RID: 126432
		public bool? IsDeprecate;

		// Token: 0x0401EDE1 RID: 126433
		public bool? IsPhantomLock;

		// Token: 0x0401EDE2 RID: 126434
		public DevelopRewardInfo DevelopRewardInfo;

		// Token: 0x0401EDE3 RID: 126435
		public int? FetterGroupId;

		// Token: 0x0401EDE4 RID: 126436
		public VisionRoleHeadInfo VisionRoleHeadInfo;

		// Token: 0x0401EDE5 RID: 126437
		public EMediumItemGridPhantomSpecialSkill? SpecialSkill;

		// Token: 0x0401EDE6 RID: 126438
		public int? SortNum;

		// Token: 0x0401EDE7 RID: 126439
		public bool? IsDisable;

		// Token: 0x0401EDE8 RID: 126440
		public MediumWarningPanelInfo WarningPanelInfo;

		// Token: 0x0401EDE9 RID: 126441
		public PhantomStackDisplay StackDisplayInfo;
	}
}
