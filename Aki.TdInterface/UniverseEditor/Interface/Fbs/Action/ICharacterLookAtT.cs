using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069AC RID: 27052
	public class ICharacterLookAtT
	{
		// Token: 0x1700C71E RID: 50974
		// (get) Token: 0x0602E684 RID: 190084 RVA: 0x0065561B File Offset: 0x0065381B
		// (set) Token: 0x0602E685 RID: 190085 RVA: 0x00655623 File Offset: 0x00653823
		public int CharEntityId { get; set; }

		// Token: 0x1700C71F RID: 50975
		// (get) Token: 0x0602E686 RID: 190086 RVA: 0x0065562C File Offset: 0x0065382C
		// (set) Token: 0x0602E687 RID: 190087 RVA: 0x00655634 File Offset: 0x00653834
		public TCharacterLookAtDataUnion Target { get; set; }

		// Token: 0x0602E688 RID: 190088 RVA: 0x0065563D File Offset: 0x0065383D
		public ICharacterLookAtT()
		{
			this.CharEntityId = 0;
			this.Target = null;
		}
	}
}
