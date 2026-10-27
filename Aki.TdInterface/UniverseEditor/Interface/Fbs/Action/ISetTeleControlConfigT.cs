using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200708C RID: 28812
	public class ISetTeleControlConfigT
	{
		// Token: 0x1700D61B RID: 54811
		// (get) Token: 0x06033051 RID: 208977 RVA: 0x006E1CFC File Offset: 0x006DFEFC
		// (set) Token: 0x06033052 RID: 208978 RVA: 0x006E1D04 File Offset: 0x006DFF04
		public ESetTeleControlType Type { get; set; }

		// Token: 0x1700D61C RID: 54812
		// (get) Token: 0x06033053 RID: 208979 RVA: 0x006E1D0D File Offset: 0x006DFF0D
		// (set) Token: 0x06033054 RID: 208980 RVA: 0x006E1D15 File Offset: 0x006DFF15
		public int EntityId { get; set; }

		// Token: 0x06033055 RID: 208981 RVA: 0x006E1D1E File Offset: 0x006DFF1E
		public ISetTeleControlConfigT()
		{
			this.Type = ESetTeleControlType.OpenGravity;
			this.EntityId = 0;
		}
	}
}
