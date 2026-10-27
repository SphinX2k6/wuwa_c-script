using System;
using System.Runtime.CompilerServices;

namespace CSharpScript.Game.Ui
{
	// Token: 0x020046E1 RID: 18145
	[NullableContext(1)]
	public interface IUiTabViewTsInfo
	{
		// Token: 0x17007680 RID: 30336
		// (get) Token: 0x0602ECB4 RID: 191668
		TCreateUiTabViewBase CreateUiTabView { get; }

		// Token: 0x17007681 RID: 30337
		// (get) Token: 0x0602ECB5 RID: 191669
		string ResourceId { get; }
	}
}
