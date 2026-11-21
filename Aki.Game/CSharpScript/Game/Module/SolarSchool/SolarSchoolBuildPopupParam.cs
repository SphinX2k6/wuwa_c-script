using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x020059CF RID: 22991
	[NullableContext(1)]
	[Nullable(0)]
	public class SolarSchoolBuildPopupParam
	{
		// Token: 0x0401DD52 RID: 122194
		public string TipsKey = string.Empty;

		// Token: 0x0401DD53 RID: 122195
		[Nullable(new byte[]
		{
			1,
			2
		})]
		public object[] TipsArgs = Array.Empty<object>();

		// Token: 0x0401DD54 RID: 122196
		public string IconPath = string.Empty;

		// Token: 0x0401DD55 RID: 122197
		[Nullable(2)]
		public Action OnConfirm;

		// Token: 0x0401DD56 RID: 122198
		[Nullable(2)]
		public Action CloseCallback;
	}
}
