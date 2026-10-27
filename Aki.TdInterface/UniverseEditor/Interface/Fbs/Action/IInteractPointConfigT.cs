using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200699D RID: 27037
	public class IInteractPointConfigT
	{
		// Token: 0x1700C89D RID: 51357
		// (get) Token: 0x0602F3EB RID: 193515 RVA: 0x0066F9D6 File Offset: 0x0066DBD6
		// (set) Token: 0x0602F3EC RID: 193516 RVA: 0x0066F9DE File Offset: 0x0066DBDE
		public EInteractUnlockType Type { get; set; }

		// Token: 0x0602F3ED RID: 193517 RVA: 0x0066F9E7 File Offset: 0x0066DBE7
		public IInteractPointConfigT()
		{
			this.Type = EInteractUnlockType.Sequence;
		}
	}
}
