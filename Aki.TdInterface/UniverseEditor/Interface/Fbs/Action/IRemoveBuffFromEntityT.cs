using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E3B RID: 28219
	public class IRemoveBuffFromEntityT
	{
		// Token: 0x1700D248 RID: 53832
		// (get) Token: 0x06031DD8 RID: 204248 RVA: 0x006BFA64 File Offset: 0x006BDC64
		// (set) Token: 0x06031DD9 RID: 204249 RVA: 0x006BFA6C File Offset: 0x006BDC6C
		public int EntityId { get; set; }

		// Token: 0x1700D249 RID: 53833
		// (get) Token: 0x06031DDA RID: 204250 RVA: 0x006BFA75 File Offset: 0x006BDC75
		// (set) Token: 0x06031DDB RID: 204251 RVA: 0x006BFA7D File Offset: 0x006BDC7D
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D24A RID: 53834
		// (get) Token: 0x06031DDC RID: 204252 RVA: 0x006BFA86 File Offset: 0x006BDC86
		// (set) Token: 0x06031DDD RID: 204253 RVA: 0x006BFA8E File Offset: 0x006BDC8E
		public List<long> BuffIds { get; set; }

		// Token: 0x1700D24B RID: 53835
		// (get) Token: 0x06031DDE RID: 204254 RVA: 0x006BFA97 File Offset: 0x006BDC97
		// (set) Token: 0x06031DDF RID: 204255 RVA: 0x006BFA9F File Offset: 0x006BDC9F
		public byte NullMask { get; set; }

		// Token: 0x06031DE0 RID: 204256 RVA: 0x006BFAA8 File Offset: 0x006BDCA8
		public IRemoveBuffFromEntityT()
		{
			this.EntityId = 0;
			this.EntityIds = null;
			this.BuffIds = null;
			this.NullMask = 0;
		}
	}
}
