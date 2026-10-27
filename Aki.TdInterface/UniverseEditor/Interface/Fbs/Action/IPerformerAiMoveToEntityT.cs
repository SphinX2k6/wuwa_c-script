using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C85 RID: 27781
	public class IPerformerAiMoveToEntityT
	{
		// Token: 0x1700CEE5 RID: 52965
		// (get) Token: 0x06030F4B RID: 200523 RVA: 0x006A5A90 File Offset: 0x006A3C90
		// (set) Token: 0x06030F4C RID: 200524 RVA: 0x006A5A98 File Offset: 0x006A3C98
		public EPerformerAiMoveToType Type { get; set; }

		// Token: 0x1700CEE6 RID: 52966
		// (get) Token: 0x06030F4D RID: 200525 RVA: 0x006A5AA1 File Offset: 0x006A3CA1
		// (set) Token: 0x06030F4E RID: 200526 RVA: 0x006A5AA9 File Offset: 0x006A3CA9
		public int EntityId { get; set; }

		// Token: 0x06030F4F RID: 200527 RVA: 0x006A5AB2 File Offset: 0x006A3CB2
		public IPerformerAiMoveToEntityT()
		{
			this.Type = EPerformerAiMoveToType.Position;
			this.EntityId = 0;
		}
	}
}
