using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A13 RID: 14867
	public class IBlackBoardEntityPosT
	{
		// Token: 0x170065E5 RID: 26085
		// (get) Token: 0x0601417F RID: 82303 RVA: 0x002F0E71 File Offset: 0x002EF071
		// (set) Token: 0x06014180 RID: 82304 RVA: 0x002F0E79 File Offset: 0x002EF079
		public EBlackBoardType Type { get; set; }

		// Token: 0x170065E6 RID: 26086
		// (get) Token: 0x06014181 RID: 82305 RVA: 0x002F0E82 File Offset: 0x002EF082
		// (set) Token: 0x06014182 RID: 82306 RVA: 0x002F0E8A File Offset: 0x002EF08A
		public string Key { get; set; }

		// Token: 0x170065E7 RID: 26087
		// (get) Token: 0x06014183 RID: 82307 RVA: 0x002F0E93 File Offset: 0x002EF093
		// (set) Token: 0x06014184 RID: 82308 RVA: 0x002F0E9B File Offset: 0x002EF09B
		public int EntityId { get; set; }

		// Token: 0x06014185 RID: 82309 RVA: 0x002F0EA4 File Offset: 0x002EF0A4
		public IBlackBoardEntityPosT()
		{
			this.Type = EBlackBoardType.Boolean;
			this.Key = null;
			this.EntityId = 0;
		}
	}
}
