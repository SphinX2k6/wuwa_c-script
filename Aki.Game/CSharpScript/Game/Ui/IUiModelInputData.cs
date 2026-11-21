using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x02003554 RID: 13652
	[NullableContext(1)]
	public interface IUiModelInputData
	{
		// Token: 0x17004898 RID: 18584
		// (get) Token: 0x06022B55 RID: 142165
		// (set) Token: 0x06022B56 RID: 142166
		UUIDraggableComponent DragComponent { get; set; }

		// Token: 0x17004899 RID: 18585
		// (get) Token: 0x06022B57 RID: 142167
		// (set) Token: 0x06022B58 RID: 142168
		UiModelBase ModelBase { get; set; }
	}
}
