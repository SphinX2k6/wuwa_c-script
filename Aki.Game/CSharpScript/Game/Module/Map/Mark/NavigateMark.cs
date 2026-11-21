using System;
using System.Runtime.CompilerServices;
using CSharpScript.Game.Module.Map.MapDefine;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x0200449E RID: 17566
	[RequiredMember]
	public class NavigateMark
	{
		// Token: 0x0602C5A3 RID: 181667 RVA: 0x00C77903 File Offset: 0x00C75B03
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public NavigateMark()
		{
		}

		// Token: 0x04017DA0 RID: 97696
		[RequiredMember]
		public int MarkId;

		// Token: 0x04017DA1 RID: 97697
		[RequiredMember]
		public EMarkType MarkType;

		// Token: 0x04017DA2 RID: 97698
		public float? Height;

		// Token: 0x04017DA3 RID: 97699
		public bool? Focal;

		// Token: 0x04017DA4 RID: 97700
		public bool? FocusTween;

		// Token: 0x04017DA5 RID: 97701
		public int? GamePlayId;

		// Token: 0x04017DA6 RID: 97702
		[Nullable(2)]
		public string ExploreTypeName;

		// Token: 0x04017DA7 RID: 97703
		public bool? NeedTempShow;
	}
}
