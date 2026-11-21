using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000D9 RID: 217
	[NullableContext(1)]
	public interface IHotFixLayoutItem
	{
		// Token: 0x0600071B RID: 1819
		void SetRootActor(AActor actor);

		// Token: 0x0600071C RID: 1820
		void Refresh(IHotFixLayoutData data);

		// Token: 0x0600071D RID: 1821
		void SetActive(bool active);

		// Token: 0x0600071E RID: 1822
		void Destroy();
	}
}
