using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x02004367 RID: 17255
	[RequiredMember]
	public class MovieModeAspectOffset : IMovieModeAspectOffset
	{
		// Token: 0x17005751 RID: 22353
		// (get) Token: 0x0602B945 RID: 178501 RVA: 0x00C3D710 File Offset: 0x00C3B910
		// (set) Token: 0x0602B946 RID: 178502 RVA: 0x00C3D718 File Offset: 0x00C3B918
		[RequiredMember]
		public bool IsFadeIn { get; set; }

		// Token: 0x17005752 RID: 22354
		// (get) Token: 0x0602B947 RID: 178503 RVA: 0x00C3D721 File Offset: 0x00C3B921
		// (set) Token: 0x0602B948 RID: 178504 RVA: 0x00C3D729 File Offset: 0x00C3B929
		[RequiredMember]
		public bool IsWidthBlend { get; set; }

		// Token: 0x17005753 RID: 22355
		// (get) Token: 0x0602B949 RID: 178505 RVA: 0x00C3D732 File Offset: 0x00C3B932
		// (set) Token: 0x0602B94A RID: 178506 RVA: 0x00C3D73A File Offset: 0x00C3B93A
		[RequiredMember]
		public float Offset { get; set; }

		// Token: 0x17005754 RID: 22356
		// (get) Token: 0x0602B94B RID: 178507 RVA: 0x00C3D743 File Offset: 0x00C3B943
		// (set) Token: 0x0602B94C RID: 178508 RVA: 0x00C3D74B File Offset: 0x00C3B94B
		[RequiredMember]
		public float Progress { get; set; }

		// Token: 0x0602B94D RID: 178509 RVA: 0x00C3D754 File Offset: 0x00C3B954
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MovieModeAspectOffset()
		{
		}
	}
}
