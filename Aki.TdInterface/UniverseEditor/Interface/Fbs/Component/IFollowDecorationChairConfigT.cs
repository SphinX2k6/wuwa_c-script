using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200528C RID: 21132
	public class IFollowDecorationChairConfigT
	{
		// Token: 0x17009AF3 RID: 39667
		// (get) Token: 0x060226FE RID: 141054 RVA: 0x004C6535 File Offset: 0x004C4735
		// (set) Token: 0x060226FF RID: 141055 RVA: 0x004C653D File Offset: 0x004C473D
		public EFollowDecorationType Type { get; set; }

		// Token: 0x17009AF4 RID: 39668
		// (get) Token: 0x06022700 RID: 141056 RVA: 0x004C6546 File Offset: 0x004C4746
		// (set) Token: 0x06022701 RID: 141057 RVA: 0x004C654E File Offset: 0x004C474E
		public string Config { get; set; }

		// Token: 0x17009AF5 RID: 39669
		// (get) Token: 0x06022702 RID: 141058 RVA: 0x004C6557 File Offset: 0x004C4757
		// (set) Token: 0x06022703 RID: 141059 RVA: 0x004C655F File Offset: 0x004C475F
		public TTriggerShapeUnion CollisionDetectionRange { get; set; }

		// Token: 0x06022704 RID: 141060 RVA: 0x004C6568 File Offset: 0x004C4768
		public IFollowDecorationChairConfigT()
		{
			this.Type = EFollowDecorationType.Chair;
			this.Config = null;
			this.CollisionDetectionRange = null;
		}
	}
}
