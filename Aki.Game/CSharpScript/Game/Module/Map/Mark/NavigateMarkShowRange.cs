using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x020054BB RID: 21691
	public class NavigateMarkShowRange : NavigateMark
	{
		// Token: 0x0603764C RID: 226892 RVA: 0x00D27B7F File Offset: 0x00D25D7F
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public NavigateMarkShowRange()
		{
		}

		// Token: 0x0401D306 RID: 119558
		public float? Width;

		// Token: 0x0401D307 RID: 119559
		[Nullable(2)]
		public string Tips;

		// Token: 0x0401D308 RID: 119560
		public bool? IsDiscover;
	}
}
