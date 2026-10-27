using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Shape;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020057FD RID: 22525
	public class IRangeComponentT
	{
		// Token: 0x1700A849 RID: 43081
		// (get) Token: 0x06025DE7 RID: 155111 RVA: 0x00539268 File Offset: 0x00537468
		// (set) Token: 0x06025DE8 RID: 155112 RVA: 0x00539270 File Offset: 0x00537470
		public bool Disabled { get; set; }

		// Token: 0x1700A84A RID: 43082
		// (get) Token: 0x06025DE9 RID: 155113 RVA: 0x00539279 File Offset: 0x00537479
		// (set) Token: 0x06025DEA RID: 155114 RVA: 0x00539281 File Offset: 0x00537481
		public List<ISetRangeActorCollisionResponseToChannelsT> SetRangeActorCollisionResponseToChannels { get; set; }

		// Token: 0x1700A84B RID: 43083
		// (get) Token: 0x06025DEB RID: 155115 RVA: 0x0053928A File Offset: 0x0053748A
		// (set) Token: 0x06025DEC RID: 155116 RVA: 0x00539292 File Offset: 0x00537492
		public TTriggerShapeUnion Shape { get; set; }

		// Token: 0x1700A84C RID: 43084
		// (get) Token: 0x06025DED RID: 155117 RVA: 0x0053929B File Offset: 0x0053749B
		// (set) Token: 0x06025DEE RID: 155118 RVA: 0x005392A3 File Offset: 0x005374A3
		public int ExtraRange { get; set; }

		// Token: 0x1700A84D RID: 43085
		// (get) Token: 0x06025DEF RID: 155119 RVA: 0x005392AC File Offset: 0x005374AC
		// (set) Token: 0x06025DF0 RID: 155120 RVA: 0x005392B4 File Offset: 0x005374B4
		public byte NullMask { get; set; }

		// Token: 0x06025DF1 RID: 155121 RVA: 0x005392BD File Offset: 0x005374BD
		public IRangeComponentT()
		{
			this.Disabled = false;
			this.SetRangeActorCollisionResponseToChannels = null;
			this.Shape = null;
			this.ExtraRange = 0;
			this.NullMask = 0;
		}
	}
}
