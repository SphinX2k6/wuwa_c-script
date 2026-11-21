using System;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057F4 RID: 22516
	public class IFollowDecorationChairConfigT
	{
		// Token: 0x1700A2F1 RID: 41713
		// (get) Token: 0x06024698 RID: 149144 RVA: 0x005010A5 File Offset: 0x004FF2A5
		// (set) Token: 0x06024699 RID: 149145 RVA: 0x005010AD File Offset: 0x004FF2AD
		public EFollowDecorationType Type { get; set; }

		// Token: 0x1700A2F2 RID: 41714
		// (get) Token: 0x0602469A RID: 149146 RVA: 0x005010B6 File Offset: 0x004FF2B6
		// (set) Token: 0x0602469B RID: 149147 RVA: 0x005010BE File Offset: 0x004FF2BE
		public string Config { get; set; }

		// Token: 0x1700A2F3 RID: 41715
		// (get) Token: 0x0602469C RID: 149148 RVA: 0x005010C7 File Offset: 0x004FF2C7
		// (set) Token: 0x0602469D RID: 149149 RVA: 0x005010CF File Offset: 0x004FF2CF
		public TTriggerShapeUnion CollisionDetectionRange { get; set; }

		// Token: 0x0602469E RID: 149150 RVA: 0x005010D8 File Offset: 0x004FF2D8
		public IFollowDecorationChairConfigT()
		{
			this.Type = EFollowDecorationType.Chair;
			this.Config = null;
			this.CollisionDetectionRange = null;
		}
	}
}
