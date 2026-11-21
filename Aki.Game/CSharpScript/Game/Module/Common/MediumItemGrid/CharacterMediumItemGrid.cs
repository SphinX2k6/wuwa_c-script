using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.RoleUi.RoleDevelop;

namespace CSharpScript.Game.Module.Common.MediumItemGrid
{
	// Token: 0x02004B3D RID: 19261
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class CharacterMediumItemGrid : MediumItemGridBase
	{
		// Token: 0x17006082 RID: 24706
		// (get) Token: 0x060302D0 RID: 197328 RVA: 0x00D6F27A File Offset: 0x00D6D47A
		public override EMediumItemGridType Type
		{
			get
			{
				return EMediumItemGridType.Character;
			}
		}

		// Token: 0x060302D1 RID: 197329 RVA: 0x00D6F27D File Offset: 0x00D6D47D
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public CharacterMediumItemGrid()
		{
		}

		// Token: 0x04019898 RID: 104600
		[RequiredMember]
		public int SkinId;

		// Token: 0x04019899 RID: 104601
		public int? ElementId;

		// Token: 0x0401989A RID: 104602
		public bool? IsTrialRoleVisible;

		// Token: 0x0401989B RID: 104603
		public int? Level;

		// Token: 0x0401989C RID: 104604
		public bool? IsLevelTextUseChangeColor;

		// Token: 0x0401989D RID: 104605
		public int? Index;

		// Token: 0x0401989E RID: 104606
		public bool? IsInTeam;

		// Token: 0x0401989F RID: 104607
		public bool? HighlightIndex;

		// Token: 0x040198A0 RID: 104608
		public bool? IsRecommendVisible;

		// Token: 0x040198A1 RID: 104609
		public bool? IsDisable;

		// Token: 0x040198A2 RID: 104610
		public bool? IsNewVisible;

		// Token: 0x040198A3 RID: 104611
		public MediumItemGridCostComponentData ShowCostData;

		// Token: 0x040198A4 RID: 104612
		public bool? IsShowLock;

		// Token: 0x040198A5 RID: 104613
		public bool? IsShowWeeklyRogueTag;

		// Token: 0x040198A6 RID: 104614
		public HaveAreaInfo HalfAreaInfo;

		// Token: 0x040198A7 RID: 104615
		public bool? IsUnRecommendVisible;

		// Token: 0x040198A8 RID: 104616
		public bool? FrameEffect;

		// Token: 0x040198A9 RID: 104617
		public IMediumLevelAndStar LvAndStar;

		// Token: 0x040198AA RID: 104618
		public ERoleDevelopHotRoleTag? RoleDevTag;

		// Token: 0x040198AB RID: 104619
		public bool? IsRecommendBottomVisible;

		// Token: 0x040198AC RID: 104620
		public bool? IsTrialBottomVisible;

		// Token: 0x040198AD RID: 104621
		public bool? IsRoleDevelopTagMark;

		// Token: 0x040198AE RID: 104622
		public int? AddLevel;

		// Token: 0x040198AF RID: 104623
		public int? SkillBranchIndex;

		// Token: 0x040198B0 RID: 104624
		public bool? IsShowArchive;

		// Token: 0x040198B1 RID: 104625
		public bool UseRoleItemAddtion;
	}
}
