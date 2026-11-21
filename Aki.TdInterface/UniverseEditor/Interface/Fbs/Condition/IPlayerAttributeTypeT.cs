using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x0200517F RID: 20863
	public class IPlayerAttributeTypeT
	{
		// Token: 0x17009573 RID: 38259
		// (get) Token: 0x06020D4D RID: 134477 RVA: 0x0048B6C6 File Offset: 0x004898C6
		// (set) Token: 0x06020D4E RID: 134478 RVA: 0x0048B6CE File Offset: 0x004898CE
		public EPlayerAttributeType Type { get; set; }

		// Token: 0x06020D4F RID: 134479 RVA: 0x0048B6D7 File Offset: 0x004898D7
		public IPlayerAttributeTypeT()
		{
			this.Type = EPlayerAttributeType.Health;
		}
	}
}
