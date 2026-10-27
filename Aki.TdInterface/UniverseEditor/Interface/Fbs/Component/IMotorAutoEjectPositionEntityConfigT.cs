using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020055AF RID: 21935
	public class IMotorAutoEjectPositionEntityConfigT
	{
		// Token: 0x1700A1FE RID: 41470
		// (get) Token: 0x06024503 RID: 148739 RVA: 0x005031F0 File Offset: 0x005013F0
		// (set) Token: 0x06024504 RID: 148740 RVA: 0x005031F8 File Offset: 0x005013F8
		public EMotorAutoEjectType Type { get; set; }

		// Token: 0x1700A1FF RID: 41471
		// (get) Token: 0x06024505 RID: 148741 RVA: 0x00503201 File Offset: 0x00501401
		// (set) Token: 0x06024506 RID: 148742 RVA: 0x00503209 File Offset: 0x00501409
		public int EntityId { get; set; }

		// Token: 0x06024507 RID: 148743 RVA: 0x00503212 File Offset: 0x00501412
		public IMotorAutoEjectPositionEntityConfigT()
		{
			this.Type = EMotorAutoEjectType.NextHook;
			this.EntityId = 0;
		}
	}
}
