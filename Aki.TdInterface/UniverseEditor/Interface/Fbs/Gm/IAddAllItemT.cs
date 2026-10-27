using System;

namespace Aki.UniverseEditor.Interface.Fbs.Gm
{
	// Token: 0x0200462E RID: 17966
	public class IAddAllItemT
	{
		// Token: 0x17007F83 RID: 32643
		// (get) Token: 0x0601B35F RID: 111455 RVA: 0x003DFD3A File Offset: 0x003DDF3A
		// (set) Token: 0x0601B360 RID: 111456 RVA: 0x003DFD42 File Offset: 0x003DDF42
		public EGmCommand Type { get; set; }

		// Token: 0x0601B361 RID: 111457 RVA: 0x003DFD4B File Offset: 0x003DDF4B
		public IAddAllItemT()
		{
			this.Type = EGmCommand.SkipToLevelPlayNode;
		}
	}
}
