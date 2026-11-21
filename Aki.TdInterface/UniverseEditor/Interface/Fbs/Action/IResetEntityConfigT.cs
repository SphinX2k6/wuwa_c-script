using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007604 RID: 30212
	public class IResetEntityConfigT
	{
		// Token: 0x1700DE05 RID: 56837
		// (get) Token: 0x06035037 RID: 217143 RVA: 0x0071F3AA File Offset: 0x0071D5AA
		// (set) Token: 0x06035038 RID: 217144 RVA: 0x0071F3B2 File Offset: 0x0071D5B2
		public EResetEntityType Type { get; set; }

		// Token: 0x06035039 RID: 217145 RVA: 0x0071F3BB File Offset: 0x0071D5BB
		public IResetEntityConfigT()
		{
			this.Type = EResetEntityType.TeleControl;
		}
	}
}
