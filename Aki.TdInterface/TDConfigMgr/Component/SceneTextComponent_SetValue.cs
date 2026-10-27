using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000896 RID: 2198
	[NullableContext(1)]
	[Nullable(0)]
	public class SceneTextComponent_SetValue
	{
		// Token: 0x04002041 RID: 8257
		public bool? Disabled;

		// Token: 0x04002042 RID: 8258
		public bool? EdIsLocked;

		// Token: 0x04002043 RID: 8259
		public string DisplayState;

		// Token: 0x04002044 RID: 8260
		[Nullable(2)]
		public PosAndRot RelativeTransform;

		// Token: 0x04002045 RID: 8261
		public ISceneTextTypeBase TextConfig;
	}
}
