using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200686E RID: 26734
	public class IGamepadShakeConfigT
	{
		// Token: 0x1700C697 RID: 50839
		// (get) Token: 0x0602EA03 RID: 190979 RVA: 0x0065BE22 File Offset: 0x0065A022
		// (set) Token: 0x0602EA04 RID: 190980 RVA: 0x0065BE2A File Offset: 0x0065A02A
		public EGamepadShakeType Type { get; set; }

		// Token: 0x0602EA05 RID: 190981 RVA: 0x0065BE33 File Offset: 0x0065A033
		public IGamepadShakeConfigT()
		{
			this.Type = EGamepadShakeType.Onetime;
		}
	}
}
