using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020069B5 RID: 27061
	public class ICharacterLookAtEmptyDataT
	{
		// Token: 0x1700C727 RID: 50983
		// (get) Token: 0x0602E6BE RID: 190142 RVA: 0x00655B72 File Offset: 0x00653D72
		// (set) Token: 0x0602E6BF RID: 190143 RVA: 0x00655B7A File Offset: 0x00653D7A
		public ECharacterLookAt Type { get; set; }

		// Token: 0x0602E6C0 RID: 190144 RVA: 0x00655B83 File Offset: 0x00653D83
		public ICharacterLookAtEmptyDataT()
		{
			this.Type = ECharacterLookAt.Empty;
		}
	}
}
