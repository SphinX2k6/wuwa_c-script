using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200462A RID: 17962
	[NullableContext(1)]
	public interface IUiModelInputData
	{
		// Token: 0x170075DE RID: 30174
		// (get) Token: 0x0602E442 RID: 189506
		// (set) Token: 0x0602E443 RID: 189507
		UUIDraggableComponent DragComponent { get; set; }

		// Token: 0x170075DF RID: 30175
		// (get) Token: 0x0602E444 RID: 189508
		// (set) Token: 0x0602E445 RID: 189509
		UiModelBase ModelBase { get; set; }
	}
}
