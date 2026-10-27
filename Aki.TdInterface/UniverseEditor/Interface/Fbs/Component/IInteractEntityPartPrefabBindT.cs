using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005450 RID: 21584
	public class IInteractEntityPartPrefabBindT
	{
		// Token: 0x17009EEA RID: 40682
		// (get) Token: 0x06023809 RID: 145417 RVA: 0x004E9933 File Offset: 0x004E7B33
		// (set) Token: 0x0602380A RID: 145418 RVA: 0x004E993B File Offset: 0x004E7B3B
		public EInteractEntityPartBindType Type { get; set; }

		// Token: 0x17009EEB RID: 40683
		// (get) Token: 0x0602380B RID: 145419 RVA: 0x004E9944 File Offset: 0x004E7B44
		// (set) Token: 0x0602380C RID: 145420 RVA: 0x004E994C File Offset: 0x004E7B4C
		public List<IInteractEntityPartPrefabOptionPointT> OptionPoints { get; set; }

		// Token: 0x0602380D RID: 145421 RVA: 0x004E9955 File Offset: 0x004E7B55
		public IInteractEntityPartPrefabBindT()
		{
			this.Type = EInteractEntityPartBindType.Prefab;
			this.OptionPoints = null;
		}
	}
}
