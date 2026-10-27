using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004FB6 RID: 20406
	public class ICollectComponentT
	{
		// Token: 0x170093CE RID: 37838
		// (get) Token: 0x060207C1 RID: 133057 RVA: 0x00484EF6 File Offset: 0x004830F6
		// (set) Token: 0x060207C2 RID: 133058 RVA: 0x00484EFE File Offset: 0x004830FE
		public bool Disabled { get; set; }

		// Token: 0x170093CF RID: 37839
		// (get) Token: 0x060207C3 RID: 133059 RVA: 0x00484F07 File Offset: 0x00483107
		// (set) Token: 0x060207C4 RID: 133060 RVA: 0x00484F0F File Offset: 0x0048310F
		public bool IsDisableOneClickCollection { get; set; }

		// Token: 0x170093D0 RID: 37840
		// (get) Token: 0x060207C5 RID: 133061 RVA: 0x00484F18 File Offset: 0x00483118
		// (set) Token: 0x060207C6 RID: 133062 RVA: 0x00484F20 File Offset: 0x00483120
		public byte NullMask { get; set; }

		// Token: 0x060207C7 RID: 133063 RVA: 0x00484F29 File Offset: 0x00483129
		public ICollectComponentT()
		{
			this.Disabled = false;
			this.IsDisableOneClickCollection = false;
			this.NullMask = 0;
		}
	}
}
