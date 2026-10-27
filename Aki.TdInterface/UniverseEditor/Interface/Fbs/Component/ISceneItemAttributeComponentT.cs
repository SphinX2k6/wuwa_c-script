using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058BC RID: 22716
	public class ISceneItemAttributeComponentT
	{
		// Token: 0x1700AA14 RID: 43540
		// (get) Token: 0x06026544 RID: 156996 RVA: 0x00548618 File Offset: 0x00546818
		// (set) Token: 0x06026545 RID: 156997 RVA: 0x00548620 File Offset: 0x00546820
		public bool Disabled { get; set; }

		// Token: 0x1700AA15 RID: 43541
		// (get) Token: 0x06026546 RID: 156998 RVA: 0x00548629 File Offset: 0x00546829
		// (set) Token: 0x06026547 RID: 156999 RVA: 0x00548631 File Offset: 0x00546831
		public string AttributeType { get; set; }

		// Token: 0x1700AA16 RID: 43542
		// (get) Token: 0x06026548 RID: 157000 RVA: 0x0054863A File Offset: 0x0054683A
		// (set) Token: 0x06026549 RID: 157001 RVA: 0x00548642 File Offset: 0x00546842
		public List<int> DefaultTags { get; set; }

		// Token: 0x1700AA17 RID: 43543
		// (get) Token: 0x0602654A RID: 157002 RVA: 0x0054864B File Offset: 0x0054684B
		// (set) Token: 0x0602654B RID: 157003 RVA: 0x00548653 File Offset: 0x00546853
		public byte NullMask { get; set; }

		// Token: 0x0602654C RID: 157004 RVA: 0x0054865C File Offset: 0x0054685C
		public ISceneItemAttributeComponentT()
		{
			this.Disabled = false;
			this.AttributeType = null;
			this.DefaultTags = null;
			this.NullMask = 0;
		}
	}
}
