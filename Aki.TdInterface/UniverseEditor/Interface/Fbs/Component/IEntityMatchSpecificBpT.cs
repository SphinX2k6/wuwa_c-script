using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020051A2 RID: 20898
	public class IEntityMatchSpecificBpT
	{
		// Token: 0x170098B0 RID: 39088
		// (get) Token: 0x06021D13 RID: 138515 RVA: 0x004B0F97 File Offset: 0x004AF197
		// (set) Token: 0x06021D14 RID: 138516 RVA: 0x004B0F9F File Offset: 0x004AF19F
		public EEntityMatchType Type { get; set; }

		// Token: 0x170098B1 RID: 39089
		// (get) Token: 0x06021D15 RID: 138517 RVA: 0x004B0FA8 File Offset: 0x004AF1A8
		// (set) Token: 0x06021D16 RID: 138518 RVA: 0x004B0FB0 File Offset: 0x004AF1B0
		public List<string> SpecificBpList { get; set; }

		// Token: 0x06021D17 RID: 138519 RVA: 0x004B0FB9 File Offset: 0x004AF1B9
		public IEntityMatchSpecificBpT()
		{
			this.Type = EEntityMatchType.Player;
			this.SpecificBpList = null;
		}
	}
}
