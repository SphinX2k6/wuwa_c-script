using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.NewWorld.Character.Common.Controller
{
	// Token: 0x020070B4 RID: 28852
	[RequiredMember]
	public class JumpProjectileParams : IJumpProjectileParams
	{
		// Token: 0x17009C5F RID: 40031
		// (get) Token: 0x06046575 RID: 288117 RVA: 0x011A1CFB File Offset: 0x0119FEFB
		// (set) Token: 0x06046576 RID: 288118 RVA: 0x011A1D03 File Offset: 0x0119FF03
		[RequiredMember]
		public float Length { get; set; }

		// Token: 0x17009C60 RID: 40032
		// (get) Token: 0x06046577 RID: 288119 RVA: 0x011A1D0C File Offset: 0x0119FF0C
		// (set) Token: 0x06046578 RID: 288120 RVA: 0x011A1D14 File Offset: 0x0119FF14
		[RequiredMember]
		public float AllTime { get; set; }

		// Token: 0x17009C61 RID: 40033
		// (get) Token: 0x06046579 RID: 288121 RVA: 0x011A1D1D File Offset: 0x0119FF1D
		// (set) Token: 0x0604657A RID: 288122 RVA: 0x011A1D25 File Offset: 0x0119FF25
		[RequiredMember]
		public float Height0 { get; set; }

		// Token: 0x17009C62 RID: 40034
		// (get) Token: 0x0604657B RID: 288123 RVA: 0x011A1D2E File Offset: 0x0119FF2E
		// (set) Token: 0x0604657C RID: 288124 RVA: 0x011A1D36 File Offset: 0x0119FF36
		[RequiredMember]
		public float ProjectileA { get; set; }

		// Token: 0x17009C63 RID: 40035
		// (get) Token: 0x0604657D RID: 288125 RVA: 0x011A1D3F File Offset: 0x0119FF3F
		// (set) Token: 0x0604657E RID: 288126 RVA: 0x011A1D47 File Offset: 0x0119FF47
		[RequiredMember]
		public float ProjectileB { get; set; }

		// Token: 0x0604657F RID: 288127 RVA: 0x011A1D50 File Offset: 0x0119FF50
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public JumpProjectileParams()
		{
		}
	}
}
