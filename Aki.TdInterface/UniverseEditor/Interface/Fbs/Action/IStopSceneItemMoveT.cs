using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071F1 RID: 29169
	public class IStopSceneItemMoveT
	{
		// Token: 0x1700D89C RID: 55452
		// (get) Token: 0x06033BD8 RID: 211928 RVA: 0x006F71CD File Offset: 0x006F53CD
		// (set) Token: 0x06033BD9 RID: 211929 RVA: 0x006F71D5 File Offset: 0x006F53D5
		public List<int> EntityIds { get; set; }

		// Token: 0x1700D89D RID: 55453
		// (get) Token: 0x06033BDA RID: 211930 RVA: 0x006F71DE File Offset: 0x006F53DE
		// (set) Token: 0x06033BDB RID: 211931 RVA: 0x006F71E6 File Offset: 0x006F53E6
		public EStopSceneItemMoveType StopType { get; set; }

		// Token: 0x1700D89E RID: 55454
		// (get) Token: 0x06033BDC RID: 211932 RVA: 0x006F71EF File Offset: 0x006F53EF
		// (set) Token: 0x06033BDD RID: 211933 RVA: 0x006F71F7 File Offset: 0x006F53F7
		public byte NullMask { get; set; }

		// Token: 0x06033BDE RID: 211934 RVA: 0x006F7200 File Offset: 0x006F5400
		public IStopSceneItemMoveT()
		{
			this.EntityIds = null;
			this.StopType = EStopSceneItemMoveType.StopAtCurrentPos;
			this.NullMask = 0;
		}
	}
}
