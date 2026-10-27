using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004CE0 RID: 19680
	public class ITargetAttributeT
	{
		// Token: 0x17008EDC RID: 36572
		// (get) Token: 0x0601F3D2 RID: 127954 RVA: 0x0045C35E File Offset: 0x0045A55E
		// (set) Token: 0x0601F3D3 RID: 127955 RVA: 0x0045C366 File Offset: 0x0045A566
		public ETargetType Type { get; set; }

		// Token: 0x0601F3D4 RID: 127956 RVA: 0x0045C36F File Offset: 0x0045A56F
		public ITargetAttributeT()
		{
			this.Type = ETargetType.Player;
		}
	}
}
