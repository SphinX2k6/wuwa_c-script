using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.Map.Mark
{
	// Token: 0x0200449D RID: 17565
	public class NavigateMarkShowRange : NavigateMark
	{
		// Token: 0x0602C5A2 RID: 181666 RVA: 0x00C778FB File Offset: 0x00C75AFB
		[Obsolete("Constructors of types with required members are not supported in this version of your compiler.", true)]
		[CompilerFeatureRequired("RequiredMembers")]
		public NavigateMarkShowRange()
		{
		}

		// Token: 0x04017D9D RID: 97693
		public float? Width;

		// Token: 0x04017D9E RID: 97694
		[Nullable(2)]
		public string Tips;

		// Token: 0x04017D9F RID: 97695
		public bool? IsDiscover;
	}
}
