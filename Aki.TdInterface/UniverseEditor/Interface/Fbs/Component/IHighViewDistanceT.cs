using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005369 RID: 21353
	public class IHighViewDistanceT
	{
		// Token: 0x17009CEC RID: 40172
		// (get) Token: 0x06022F16 RID: 143126 RVA: 0x004D6BC6 File Offset: 0x004D4DC6
		// (set) Token: 0x06022F17 RID: 143127 RVA: 0x004D6BCE File Offset: 0x004D4DCE
		public EViewDistanceType Type { get; set; }

		// Token: 0x06022F18 RID: 143128 RVA: 0x004D6BD7 File Offset: 0x004D4DD7
		public IHighViewDistanceT()
		{
			this.Type = EViewDistanceType.Low;
		}
	}
}
