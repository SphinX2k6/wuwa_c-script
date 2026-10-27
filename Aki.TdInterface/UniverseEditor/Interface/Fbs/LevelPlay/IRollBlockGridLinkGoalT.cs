using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004579 RID: 17785
	public class IRollBlockGridLinkGoalT
	{
		// Token: 0x17007E5B RID: 32347
		// (get) Token: 0x0601ADAB RID: 109995 RVA: 0x003D546D File Offset: 0x003D366D
		// (set) Token: 0x0601ADAC RID: 109996 RVA: 0x003D5475 File Offset: 0x003D3675
		public ERollBlockGridType Type { get; set; }

		// Token: 0x17007E5C RID: 32348
		// (get) Token: 0x0601ADAD RID: 109997 RVA: 0x003D547E File Offset: 0x003D367E
		// (set) Token: 0x0601ADAE RID: 109998 RVA: 0x003D5486 File Offset: 0x003D3686
		public TRollBlockUnion Block { get; set; }

		// Token: 0x17007E5D RID: 32349
		// (get) Token: 0x0601ADAF RID: 109999 RVA: 0x003D548F File Offset: 0x003D368F
		// (set) Token: 0x0601ADB0 RID: 110000 RVA: 0x003D5497 File Offset: 0x003D3697
		public List<TRollBlockItemUnion> Items { get; set; }

		// Token: 0x17007E5E RID: 32350
		// (get) Token: 0x0601ADB1 RID: 110001 RVA: 0x003D54A0 File Offset: 0x003D36A0
		// (set) Token: 0x0601ADB2 RID: 110002 RVA: 0x003D54A8 File Offset: 0x003D36A8
		public ERollBlockLayType LinkDirection { get; set; }

		// Token: 0x17007E5F RID: 32351
		// (get) Token: 0x0601ADB3 RID: 110003 RVA: 0x003D54B1 File Offset: 0x003D36B1
		// (set) Token: 0x0601ADB4 RID: 110004 RVA: 0x003D54B9 File Offset: 0x003D36B9
		public byte NullMask { get; set; }

		// Token: 0x0601ADB5 RID: 110005 RVA: 0x003D54C2 File Offset: 0x003D36C2
		public IRollBlockGridLinkGoalT()
		{
			this.Type = ERollBlockGridType.Empty;
			this.Block = null;
			this.Items = null;
			this.LinkDirection = ERollBlockLayType.Left;
			this.NullMask = 0;
		}
	}
}
