using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005572 RID: 21874
	public class IConnectorPathAdvanceVasePlantVisualT
	{
		// Token: 0x17009C7E RID: 40062
		// (get) Token: 0x06022BF7 RID: 142327 RVA: 0x004C9361 File Offset: 0x004C7561
		// (set) Token: 0x06022BF8 RID: 142328 RVA: 0x004C9369 File Offset: 0x004C7569
		public EConnectorPathAdvanceVisualType Type { get; set; }

		// Token: 0x17009C7F RID: 40063
		// (get) Token: 0x06022BF9 RID: 142329 RVA: 0x004C9372 File Offset: 0x004C7572
		// (set) Token: 0x06022BFA RID: 142330 RVA: 0x004C937A File Offset: 0x004C757A
		public float ScatterWidth { get; set; }

		// Token: 0x17009C80 RID: 40064
		// (get) Token: 0x06022BFB RID: 142331 RVA: 0x004C9383 File Offset: 0x004C7583
		// (set) Token: 0x06022BFC RID: 142332 RVA: 0x004C938B File Offset: 0x004C758B
		public float ScatterDensity { get; set; }

		// Token: 0x17009C81 RID: 40065
		// (get) Token: 0x06022BFD RID: 142333 RVA: 0x004C9394 File Offset: 0x004C7594
		// (set) Token: 0x06022BFE RID: 142334 RVA: 0x004C939C File Offset: 0x004C759C
		public float Scale { get; set; }

		// Token: 0x17009C82 RID: 40066
		// (get) Token: 0x06022BFF RID: 142335 RVA: 0x004C93A5 File Offset: 0x004C75A5
		// (set) Token: 0x06022C00 RID: 142336 RVA: 0x004C93AD File Offset: 0x004C75AD
		public bool SnapToSurface { get; set; }

		// Token: 0x17009C83 RID: 40067
		// (get) Token: 0x06022C01 RID: 142337 RVA: 0x004C93B6 File Offset: 0x004C75B6
		// (set) Token: 0x06022C02 RID: 142338 RVA: 0x004C93BE File Offset: 0x004C75BE
		public List<string> PathRtList { get; set; }

		// Token: 0x17009C84 RID: 40068
		// (get) Token: 0x06022C03 RID: 142339 RVA: 0x004C93C7 File Offset: 0x004C75C7
		// (set) Token: 0x06022C04 RID: 142340 RVA: 0x004C93CF File Offset: 0x004C75CF
		public byte NullMask { get; set; }

		// Token: 0x06022C05 RID: 142341 RVA: 0x004C93D8 File Offset: 0x004C75D8
		public IConnectorPathAdvanceVasePlantVisualT()
		{
			this.Type = EConnectorPathAdvanceVisualType.VasePlant;
			this.ScatterWidth = 0f;
			this.ScatterDensity = 0f;
			this.Scale = 0f;
			this.SnapToSurface = false;
			this.PathRtList = null;
			this.NullMask = 0;
		}
	}
}
