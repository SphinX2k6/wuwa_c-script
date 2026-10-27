using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200461E RID: 17950
	[NullableContext(2)]
	public interface IUiPanelBase
	{
		// Token: 0x170075D9 RID: 30169
		// (get) Token: 0x0602E418 RID: 189464
		// (set) Token: 0x0602E419 RID: 189465
		bool SkipDestroyActor { get; set; }

		// Token: 0x0602E41A RID: 189466
		void SetUiActive(bool visibility);

		// Token: 0x0602E41B RID: 189467
		UUIItem GetRootItem();
	}
}
