using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02005B5E RID: 23390
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class CharacterMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17008CB0 RID: 36016
		// (get) Token: 0x0603B384 RID: 242564 RVA: 0x00E1ED0E File Offset: 0x00E1CF0E
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Character;
			}
		}

		// Token: 0x0603B385 RID: 242565 RVA: 0x00E1ED11 File Offset: 0x00E1CF11
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CharacterMediumItemGrid()
		{
		}

		// Token: 0x0401EDEA RID: 126442
		[RequiredMember]
		public int SkinId;

		// Token: 0x0401EDEB RID: 126443
		public int? ElementId;

		// Token: 0x0401EDEC RID: 126444
		public bool? IsTrialRoleVisible;

		// Token: 0x0401EDED RID: 126445
		public int? Level;

		// Token: 0x0401EDEE RID: 126446
		public bool? IsLevelTextUseChangeColor;

		// Token: 0x0401EDEF RID: 126447
		public int? Index;

		// Token: 0x0401EDF0 RID: 126448
		public bool? IsInTeam;

		// Token: 0x0401EDF1 RID: 126449
		public bool? HighlightIndex;

		// Token: 0x0401EDF2 RID: 126450
		public bool? IsRecommendVisible;

		// Token: 0x0401EDF3 RID: 126451
		public bool? IsDisable;

		// Token: 0x0401EDF4 RID: 126452
		public bool? IsNewVisible;

		// Token: 0x0401EDF5 RID: 126453
		public MediumItemGridCostComponentData ShowCostData;

		// Token: 0x0401EDF6 RID: 126454
		public bool? IsShowLock;

		// Token: 0x0401EDF7 RID: 126455
		public bool? IsShowWeeklyRogueTag;

		// Token: 0x0401EDF8 RID: 126456
		public HaveAreaInfo HalfAreaInfo;

		// Token: 0x0401EDF9 RID: 126457
		public bool? IsUnRecommendVisible;

		// Token: 0x0401EDFA RID: 126458
		public bool? FrameEffect;

		// Token: 0x0401EDFB RID: 126459
		public IMediumLevelAndStar LvAndStar;

		// Token: 0x0401EDFC RID: 126460
		public ERoleDevelopHotRoleTag? RoleDevTag;

		// Token: 0x0401EDFD RID: 126461
		public bool? IsRecommendBottomVisible;

		// Token: 0x0401EDFE RID: 126462
		public bool? IsTrialBottomVisible;

		// Token: 0x0401EDFF RID: 126463
		public bool? IsRoleDevelopTagMark;

		// Token: 0x0401EE00 RID: 126464
		public int? AddLevel;

		// Token: 0x0401EE01 RID: 126465
		public int? SkillBranchIndex;

		// Token: 0x0401EE02 RID: 126466
		public bool? IsShowArchive;
	}
}
