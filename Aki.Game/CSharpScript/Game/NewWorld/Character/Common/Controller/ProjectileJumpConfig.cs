using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B6 RID: 28854
	[RequiredMember]
	public class ProjectileJumpConfig : IProjectileJumpConfig
	{
		// Token: 0x17009C6C RID: 40044
		// (get) Token: 0x06046590 RID: 288144 RVA: 0x011A1D58 File Offset: 0x0119FF58
		// (set) Token: 0x06046591 RID: 288145 RVA: 0x011A1D60 File Offset: 0x0119FF60
		[RequiredMember]
		public float BaseJumpHeight { get; set; }

		// Token: 0x17009C6D RID: 40045
		// (get) Token: 0x06046592 RID: 288146 RVA: 0x011A1D69 File Offset: 0x0119FF69
		// (set) Token: 0x06046593 RID: 288147 RVA: 0x011A1D71 File Offset: 0x0119FF71
		[RequiredMember]
		public float BaseJumpDistanceRate { get; set; }

		// Token: 0x17009C6E RID: 40046
		// (get) Token: 0x06046594 RID: 288148 RVA: 0x011A1D7A File Offset: 0x0119FF7A
		// (set) Token: 0x06046595 RID: 288149 RVA: 0x011A1D82 File Offset: 0x0119FF82
		[RequiredMember]
		public float MaxJumpDistance { get; set; }

		// Token: 0x17009C6F RID: 40047
		// (get) Token: 0x06046596 RID: 288150 RVA: 0x011A1D8B File Offset: 0x0119FF8B
		// (set) Token: 0x06046597 RID: 288151 RVA: 0x011A1D93 File Offset: 0x0119FF93
		[RequiredMember]
		public float MaxJumpHeight { get; set; }

		// Token: 0x17009C70 RID: 40048
		// (get) Token: 0x06046598 RID: 288152 RVA: 0x011A1D9C File Offset: 0x0119FF9C
		// (set) Token: 0x06046599 RID: 288153 RVA: 0x011A1DA4 File Offset: 0x0119FFA4
		[RequiredMember]
		public float JumpAcceleration { get; set; }

		// Token: 0x17009C71 RID: 40049
		// (get) Token: 0x0604659A RID: 288154 RVA: 0x011A1DAD File Offset: 0x0119FFAD
		// (set) Token: 0x0604659B RID: 288155 RVA: 0x011A1DB5 File Offset: 0x0119FFB5
		[RequiredMember]
		public float TargetSpeedForJump { get; set; }

		// Token: 0x17009C72 RID: 40050
		// (get) Token: 0x0604659C RID: 288156 RVA: 0x011A1DBE File Offset: 0x0119FFBE
		// (set) Token: 0x0604659D RID: 288157 RVA: 0x011A1DC6 File Offset: 0x0119FFC6
		[RequiredMember]
		public float AllTimeForJump { get; set; }

		// Token: 0x17009C73 RID: 40051
		// (get) Token: 0x0604659E RID: 288158 RVA: 0x011A1DCF File Offset: 0x0119FFCF
		// (set) Token: 0x0604659F RID: 288159 RVA: 0x011A1DD7 File Offset: 0x0119FFD7
		[RequiredMember]
		public float JumpBlendTime { get; set; }

		// Token: 0x060465A0 RID: 288160 RVA: 0x011A1DE0 File Offset: 0x0119FFE0
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public ProjectileJumpConfig()
		{
		}
	}
}
