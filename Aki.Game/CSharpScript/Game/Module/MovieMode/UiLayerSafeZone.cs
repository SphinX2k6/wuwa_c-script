using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200436F RID: 17263
	[RequiredMember]
	public class UiLayerSafeZone : IUiLayerSafeZone
	{
		// Token: 0x17005767 RID: 22375
		// (get) Token: 0x0602B974 RID: 178548 RVA: 0x00C3D7E3 File Offset: 0x00C3B9E3
		// (set) Token: 0x0602B975 RID: 178549 RVA: 0x00C3D7EB File Offset: 0x00C3B9EB
		[RequiredMember]
		public float StretchLeft { get; set; }

		// Token: 0x17005768 RID: 22376
		// (get) Token: 0x0602B976 RID: 178550 RVA: 0x00C3D7F4 File Offset: 0x00C3B9F4
		// (set) Token: 0x0602B977 RID: 178551 RVA: 0x00C3D7FC File Offset: 0x00C3B9FC
		[RequiredMember]
		public float StretchRight { get; set; }

		// Token: 0x17005769 RID: 22377
		// (get) Token: 0x0602B978 RID: 178552 RVA: 0x00C3D805 File Offset: 0x00C3BA05
		// (set) Token: 0x0602B979 RID: 178553 RVA: 0x00C3D80D File Offset: 0x00C3BA0D
		[RequiredMember]
		public float StretchTop { get; set; }

		// Token: 0x1700576A RID: 22378
		// (get) Token: 0x0602B97A RID: 178554 RVA: 0x00C3D816 File Offset: 0x00C3BA16
		// (set) Token: 0x0602B97B RID: 178555 RVA: 0x00C3D81E File Offset: 0x00C3BA1E
		[RequiredMember]
		public float StretchBottom { get; set; }

		// Token: 0x0602B97C RID: 178556 RVA: 0x00C3D827 File Offset: 0x00C3BA27
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public UiLayerSafeZone()
		{
		}
	}
}
