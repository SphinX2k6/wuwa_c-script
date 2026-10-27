using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004B18 RID: 19224
	public class ICheckRogueStateTypeT
	{
		// Token: 0x17008B75 RID: 35701
		// (get) Token: 0x0601E3D4 RID: 123860 RVA: 0x0043D3D6 File Offset: 0x0043B5D6
		// (set) Token: 0x0601E3D5 RID: 123861 RVA: 0x0043D3DE File Offset: 0x0043B5DE
		public ERogueStateType Type { get; set; }

		// Token: 0x0601E3D6 RID: 123862 RVA: 0x0043D3E7 File Offset: 0x0043B5E7
		public ICheckRogueStateTypeT()
		{
			this.Type = ERogueStateType.Talent;
		}
	}
}
