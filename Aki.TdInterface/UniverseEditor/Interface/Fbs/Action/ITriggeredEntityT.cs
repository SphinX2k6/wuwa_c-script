using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200747C RID: 29820
	public class ITriggeredEntityT
	{
		// Token: 0x1700E266 RID: 57958
		// (get) Token: 0x06036314 RID: 221972 RVA: 0x0075E3CE File Offset: 0x0075C5CE
		// (set) Token: 0x06036315 RID: 221973 RVA: 0x0075E3D6 File Offset: 0x0075C5D6
		public ETargetEntityType Type { get; set; }

		// Token: 0x06036316 RID: 221974 RVA: 0x0075E3DF File Offset: 0x0075C5DF
		public ITriggeredEntityT()
		{
			this.Type = ETargetEntityType.Target;
		}
	}
}
