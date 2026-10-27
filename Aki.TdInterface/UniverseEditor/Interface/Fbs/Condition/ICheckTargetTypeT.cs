using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B54 RID: 19284
	public class ICheckTargetTypeT
	{
		// Token: 0x17008BE9 RID: 35817
		// (get) Token: 0x0601E5F7 RID: 124407 RVA: 0x004415C2 File Offset: 0x0043F7C2
		// (set) Token: 0x0601E5F8 RID: 124408 RVA: 0x004415CA File Offset: 0x0043F7CA
		public ECheckTargetType Type { get; set; }

		// Token: 0x0601E5F9 RID: 124409 RVA: 0x004415D3 File Offset: 0x0043F7D3
		public ICheckTargetTypeT()
		{
			this.Type = ECheckTargetType.AllPlayer;
		}
	}
}
