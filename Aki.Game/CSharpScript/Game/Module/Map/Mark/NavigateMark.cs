using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054BC RID: 21692
	[RequiredMember]
	public class NavigateMark
	{
		// Token: 0x0603764D RID: 226893 RVA: 0x00D27B87 File Offset: 0x00D25D87
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public NavigateMark()
		{
		}

		// Token: 0x0401D309 RID: 119561
		[RequiredMember]
		public int MarkId;

		// Token: 0x0401D30A RID: 119562
		[RequiredMember]
		public EMarkType MarkType;

		// Token: 0x0401D30B RID: 119563
		public float? Height;

		// Token: 0x0401D30C RID: 119564
		public bool? Focal;

		// Token: 0x0401D30D RID: 119565
		public bool? FocusTween;

		// Token: 0x0401D30E RID: 119566
		public int? GamePlayId;

		// Token: 0x0401D30F RID: 119567
		[Nullable(2)]
		public string ExploreTypeName;

		// Token: 0x0401D310 RID: 119568
		public bool? NeedTempShow;
	}
}
