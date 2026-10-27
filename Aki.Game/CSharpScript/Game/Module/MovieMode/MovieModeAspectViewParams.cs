using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Ui;

namespace CSharpScript.Game.Module.MovieMode
{
	// Token: 0x0200538A RID: 21386
	[NullableContext(2)]
	[Nullable(0)]
	[RequiredMember]
	public class MovieModeAspectViewParams : IMovieModeAspectViewParams
	{
		// Token: 0x17008394 RID: 33684
		// (get) Token: 0x06036A1F RID: 223775 RVA: 0x00CEE880 File Offset: 0x00CECA80
		// (set) Token: 0x06036A20 RID: 223776 RVA: 0x00CEE888 File Offset: 0x00CECA88
		[RequiredMember]
		public bool IsBanAdaptation { get; set; }

		// Token: 0x17008395 RID: 33685
		// (get) Token: 0x06036A21 RID: 223777 RVA: 0x00CEE891 File Offset: 0x00CECA91
		// (set) Token: 0x06036A22 RID: 223778 RVA: 0x00CEE899 File Offset: 0x00CECA99
		[RequiredMember]
		public ELayerType[] AdaptUiLayers { get; set; }

		// Token: 0x17008396 RID: 33686
		// (get) Token: 0x06036A23 RID: 223779 RVA: 0x00CEE8A2 File Offset: 0x00CECAA2
		// (set) Token: 0x06036A24 RID: 223780 RVA: 0x00CEE8AA File Offset: 0x00CECAAA
		[RequiredMember]
		public bool? IsIgnoreUiLayerVisible { get; set; }

		// Token: 0x06036A25 RID: 223781 RVA: 0x00CEE8B3 File Offset: 0x00CECAB3
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public MovieModeAspectViewParams()
		{
		}
	}
}
