using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020035ED RID: 13805
	public class SceneUiInfo
	{
		// Token: 0x04013D7A RID: 81274
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<SceneUiView> CreateView;

		// Token: 0x04013D7B RID: 81275
		[Nullable(1)]
		public string ResourceId = string.Empty;
	}
}
