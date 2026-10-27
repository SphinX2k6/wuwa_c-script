using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007209 RID: 29193
	public class ISubScreenInitDataT
	{
		// Token: 0x1700D8C2 RID: 55490
		// (get) Token: 0x06033C88 RID: 212104 RVA: 0x006F8363 File Offset: 0x006F6563
		// (set) Token: 0x06033C89 RID: 212105 RVA: 0x006F836B File Offset: 0x006F656B
		public ESubScreenInitDataType Type { get; set; }

		// Token: 0x1700D8C3 RID: 55491
		// (get) Token: 0x06033C8A RID: 212106 RVA: 0x006F8374 File Offset: 0x006F6574
		// (set) Token: 0x06033C8B RID: 212107 RVA: 0x006F837C File Offset: 0x006F657C
		public string SubScreenKey { get; set; }

		// Token: 0x06033C8C RID: 212108 RVA: 0x006F8385 File Offset: 0x006F6585
		public ISubScreenInitDataT()
		{
			this.Type = ESubScreenInitDataType.Preset;
			this.SubScreenKey = null;
		}
	}
}
