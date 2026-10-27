using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046BC RID: 18108
	public class SceneUiInfo
	{
		// Token: 0x040196D3 RID: 104147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		public Func<SceneUiView> CreateView;

		// Token: 0x040196D4 RID: 104148
		[Nullable(1)]
		public string ResourceId = string.Empty;
	}
}
