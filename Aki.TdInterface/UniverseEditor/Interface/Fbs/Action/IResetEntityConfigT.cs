using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E80 RID: 28288
	public class IResetEntityConfigT
	{
		// Token: 0x1700D2AE RID: 53934
		// (get) Token: 0x06031FF7 RID: 204791 RVA: 0x006C3676 File Offset: 0x006C1876
		// (set) Token: 0x06031FF8 RID: 204792 RVA: 0x006C367E File Offset: 0x006C187E
		public EResetEntityType Type { get; set; }

		// Token: 0x06031FF9 RID: 204793 RVA: 0x006C3687 File Offset: 0x006C1887
		public IResetEntityConfigT()
		{
			this.Type = EResetEntityType.TeleControl;
		}
	}
}
