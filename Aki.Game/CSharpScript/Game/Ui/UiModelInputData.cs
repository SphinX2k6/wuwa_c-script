using System;
using System.Runtime.CompilerServices;
using UnrealEngine;

namespace CSharpScript.Game.Ui
{
	// Token: 0x0200462B RID: 17963
	[NullableContext(1)]
	[Nullable(0)]
	public class UiModelInputData : IUiModelInputData
	{
		// Token: 0x170075E0 RID: 30176
		// (get) Token: 0x0602E446 RID: 189510 RVA: 0x00AB22E4 File Offset: 0x00AB04E4
		// (set) Token: 0x0602E447 RID: 189511 RVA: 0x00AB22EC File Offset: 0x00AB04EC
		public UUIDraggableComponent DragComponent { get; set; }

		// Token: 0x170075E1 RID: 30177
		// (get) Token: 0x0602E448 RID: 189512 RVA: 0x00AB22F5 File Offset: 0x00AB04F5
		// (set) Token: 0x0602E449 RID: 189513 RVA: 0x00AB22FD File Offset: 0x00AB04FD
		public UiModelBase ModelBase { get; set; }
	}
}
