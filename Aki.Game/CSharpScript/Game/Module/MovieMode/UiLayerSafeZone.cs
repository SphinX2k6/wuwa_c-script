using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200538C RID: 21388
	[RequiredMember]
	public class UiLayerSafeZone : IUiLayerSafeZone
	{
		// Token: 0x1700839B RID: 33691
		// (get) Token: 0x06036A2E RID: 223790 RVA: 0x00CEE8BB File Offset: 0x00CECABB
		// (set) Token: 0x06036A2F RID: 223791 RVA: 0x00CEE8C3 File Offset: 0x00CECAC3
		[RequiredMember]
		public float StretchLeft { get; set; }

		// Token: 0x1700839C RID: 33692
		// (get) Token: 0x06036A30 RID: 223792 RVA: 0x00CEE8CC File Offset: 0x00CECACC
		// (set) Token: 0x06036A31 RID: 223793 RVA: 0x00CEE8D4 File Offset: 0x00CECAD4
		[RequiredMember]
		public float StretchRight { get; set; }

		// Token: 0x1700839D RID: 33693
		// (get) Token: 0x06036A32 RID: 223794 RVA: 0x00CEE8DD File Offset: 0x00CECADD
		// (set) Token: 0x06036A33 RID: 223795 RVA: 0x00CEE8E5 File Offset: 0x00CECAE5
		[RequiredMember]
		public float StretchTop { get; set; }

		// Token: 0x1700839E RID: 33694
		// (get) Token: 0x06036A34 RID: 223796 RVA: 0x00CEE8EE File Offset: 0x00CECAEE
		// (set) Token: 0x06036A35 RID: 223797 RVA: 0x00CEE8F6 File Offset: 0x00CECAF6
		[RequiredMember]
		public float StretchBottom { get; set; }

		// Token: 0x06036A36 RID: 223798 RVA: 0x00CEE8FF File Offset: 0x00CECAFF
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UiLayerSafeZone()
		{
		}
	}
}
