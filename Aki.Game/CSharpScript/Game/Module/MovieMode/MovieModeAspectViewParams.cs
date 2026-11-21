using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200436D RID: 17261
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class MovieModeAspectViewParams : IMovieModeAspectViewParams
	{
		// Token: 0x17005760 RID: 22368
		// (get) Token: 0x0602B965 RID: 178533 RVA: 0x00C3D7A8 File Offset: 0x00C3B9A8
		// (set) Token: 0x0602B966 RID: 178534 RVA: 0x00C3D7B0 File Offset: 0x00C3B9B0
		[RequiredMember]
		public bool IsBanAdaptation { get; set; }

		// Token: 0x17005761 RID: 22369
		// (get) Token: 0x0602B967 RID: 178535 RVA: 0x00C3D7B9 File Offset: 0x00C3B9B9
		// (set) Token: 0x0602B968 RID: 178536 RVA: 0x00C3D7C1 File Offset: 0x00C3B9C1
		[RequiredMember]
		public ELayerType[] AdaptUiLayers { get; set; }

		// Token: 0x17005762 RID: 22370
		// (get) Token: 0x0602B969 RID: 178537 RVA: 0x00C3D7CA File Offset: 0x00C3B9CA
		// (set) Token: 0x0602B96A RID: 178538 RVA: 0x00C3D7D2 File Offset: 0x00C3B9D2
		[RequiredMember]
		public bool? IsIgnoreUiLayerVisible { get; set; }

		// Token: 0x0602B96B RID: 178539 RVA: 0x00C3D7DB File Offset: 0x00C3B9DB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MovieModeAspectViewParams()
		{
		}
	}
}
