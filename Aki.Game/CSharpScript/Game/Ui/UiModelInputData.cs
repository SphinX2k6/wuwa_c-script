using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003555 RID: 13653
	[NullableContext(1)]
	[Nullable(0)]
	public class UiModelInputData : IUiModelInputData
	{
		// Token: 0x1700489A RID: 18586
		// (get) Token: 0x06022B59 RID: 142169 RVA: 0x009DF074 File Offset: 0x009DD274
		// (set) Token: 0x06022B5A RID: 142170 RVA: 0x009DF07C File Offset: 0x009DD27C
		public UUIDraggableComponent DragComponent { get; set; }

		// Token: 0x1700489B RID: 18587
		// (get) Token: 0x06022B5B RID: 142171 RVA: 0x009DF085 File Offset: 0x009DD285
		// (set) Token: 0x06022B5C RID: 142172 RVA: 0x009DF08D File Offset: 0x009DD28D
		public UiModelBase ModelBase { get; set; }
	}
}
