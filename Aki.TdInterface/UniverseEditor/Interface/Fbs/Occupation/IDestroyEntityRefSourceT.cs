using System;

namespace Aki.UniverseEditor.Interface.Fbs.Occupation
{
	// Token: 0x020047FB RID: 18427
	public class IDestroyEntityRefSourceT
	{
		// Token: 0x17008086 RID: 32902
		// (get) Token: 0x0601B391 RID: 111505 RVA: 0x003DB6C4 File Offset: 0x003D98C4
		// (set) Token: 0x0601B392 RID: 111506 RVA: 0x003DB6CC File Offset: 0x003D98CC
		public ERefSourceType Type { get; set; }

		// Token: 0x17008087 RID: 32903
		// (get) Token: 0x0601B393 RID: 111507 RVA: 0x003DB6D5 File Offset: 0x003D98D5
		// (set) Token: 0x0601B394 RID: 111508 RVA: 0x003DB6DD File Offset: 0x003D98DD
		public int EntityId { get; set; }

		// Token: 0x0601B395 RID: 111509 RVA: 0x003DB6E6 File Offset: 0x003D98E6
		public IDestroyEntityRefSourceT()
		{
			this.Type = ERefSourceType.AwakeEntity;
			this.EntityId = 0;
		}
	}
}
