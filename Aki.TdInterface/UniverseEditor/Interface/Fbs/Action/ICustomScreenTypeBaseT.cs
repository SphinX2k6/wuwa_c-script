using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7F RID: 27519
	public class ICustomScreenTypeBaseT
	{
		// Token: 0x1700C9F5 RID: 51701
		// (get) Token: 0x0602F5B7 RID: 193975 RVA: 0x0067640A File Offset: 0x0067460A
		// (set) Token: 0x0602F5B8 RID: 193976 RVA: 0x00676412 File Offset: 0x00674612
		public ECustomScreenType Type { get; set; }

		// Token: 0x0602F5B9 RID: 193977 RVA: 0x0067641B File Offset: 0x0067461B
		public ICustomScreenTypeBaseT()
		{
			this.Type = ECustomScreenType.Spine;
		}
	}
}
