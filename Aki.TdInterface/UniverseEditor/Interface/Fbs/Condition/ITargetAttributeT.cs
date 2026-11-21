using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020051DC RID: 20956
	public class ITargetAttributeT
	{
		// Token: 0x17009615 RID: 38421
		// (get) Token: 0x06021017 RID: 135191 RVA: 0x004902AE File Offset: 0x0048E4AE
		// (set) Token: 0x06021018 RID: 135192 RVA: 0x004902B6 File Offset: 0x0048E4B6
		public ETargetType Type { get; set; }

		// Token: 0x06021019 RID: 135193 RVA: 0x004902BF File Offset: 0x0048E4BF
		public ITargetAttributeT()
		{
			this.Type = ETargetType.Player;
		}
	}
}
