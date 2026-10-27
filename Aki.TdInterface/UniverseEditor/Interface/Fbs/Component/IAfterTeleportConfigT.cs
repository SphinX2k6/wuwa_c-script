using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004E6F RID: 20079
	public class IAfterTeleportConfigT
	{
		// Token: 0x17008FC0 RID: 36800
		// (get) Token: 0x0601F8A0 RID: 129184 RVA: 0x004647DA File Offset: 0x004629DA
		// (set) Token: 0x0601F8A1 RID: 129185 RVA: 0x004647E2 File Offset: 0x004629E2
		public IVectorInfoT Direction { get; set; }

		// Token: 0x17008FC1 RID: 36801
		// (get) Token: 0x0601F8A2 RID: 129186 RVA: 0x004647EB File Offset: 0x004629EB
		// (set) Token: 0x0601F8A3 RID: 129187 RVA: 0x004647F3 File Offset: 0x004629F3
		public List<int> BuffEffectIds { get; set; }

		// Token: 0x17008FC2 RID: 36802
		// (get) Token: 0x0601F8A4 RID: 129188 RVA: 0x004647FC File Offset: 0x004629FC
		// (set) Token: 0x0601F8A5 RID: 129189 RVA: 0x00464804 File Offset: 0x00462A04
		public IVectorInfoT TeleportToSelfPos { get; set; }

		// Token: 0x17008FC3 RID: 36803
		// (get) Token: 0x0601F8A6 RID: 129190 RVA: 0x0046480D File Offset: 0x00462A0D
		// (set) Token: 0x0601F8A7 RID: 129191 RVA: 0x00464815 File Offset: 0x00462A15
		public int RailEntityId { get; set; }

		// Token: 0x17008FC4 RID: 36804
		// (get) Token: 0x0601F8A8 RID: 129192 RVA: 0x0046481E File Offset: 0x00462A1E
		// (set) Token: 0x0601F8A9 RID: 129193 RVA: 0x00464826 File Offset: 0x00462A26
		public string SlidePerformDaPath { get; set; }

		// Token: 0x17008FC5 RID: 36805
		// (get) Token: 0x0601F8AA RID: 129194 RVA: 0x0046482F File Offset: 0x00462A2F
		// (set) Token: 0x0601F8AB RID: 129195 RVA: 0x00464837 File Offset: 0x00462A37
		public byte NullMask { get; set; }

		// Token: 0x0601F8AC RID: 129196 RVA: 0x00464840 File Offset: 0x00462A40
		public IAfterTeleportConfigT()
		{
			this.Direction = null;
			this.BuffEffectIds = null;
			this.TeleportToSelfPos = null;
			this.RailEntityId = 0;
			this.SlidePerformDaPath = null;
			this.NullMask = 0;
		}
	}
}
