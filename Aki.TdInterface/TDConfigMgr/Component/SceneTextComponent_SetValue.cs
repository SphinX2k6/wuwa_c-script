using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000939 RID: 2361
	public class SceneTextComponent_SetValue
	{
		// Token: 0x04002253 RID: 8787
		public bool? Disabled;

		// Token: 0x04002254 RID: 8788
		public bool? EdIsLocked;

		// Token: 0x04002255 RID: 8789
		public string DisplayState;

		// Token: 0x04002256 RID: 8790
		[Nullable(2)]
		public PosAndRot RelativeTransform;

		// Token: 0x04002257 RID: 8791
		public ISceneTextTypeBase TextConfig;
	}
}
