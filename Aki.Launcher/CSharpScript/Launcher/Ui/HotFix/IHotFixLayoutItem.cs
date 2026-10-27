using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D6 RID: 214
	[NullableContext(1)]
	public interface IHotFixLayoutItem
	{
		// Token: 0x060006FF RID: 1791
		void SetRootActor(AActor actor);

		// Token: 0x06000700 RID: 1792
		void Refresh(IHotFixLayoutData data);

		// Token: 0x06000701 RID: 1793
		void SetActive(bool active);

		// Token: 0x06000702 RID: 1794
		void Destroy();
	}
}
