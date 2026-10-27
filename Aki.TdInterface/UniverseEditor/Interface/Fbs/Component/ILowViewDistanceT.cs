using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200551C RID: 21788
	public class ILowViewDistanceT
	{
		// Token: 0x1700A0D6 RID: 41174
		// (get) Token: 0x06023FCB RID: 147403 RVA: 0x004F92A2 File Offset: 0x004F74A2
		// (set) Token: 0x06023FCC RID: 147404 RVA: 0x004F92AA File Offset: 0x004F74AA
		public EViewDistanceType Type { get; set; }

		// Token: 0x06023FCD RID: 147405 RVA: 0x004F92B3 File Offset: 0x004F74B3
		public ILowViewDistanceT()
		{
			this.Type = EViewDistanceType.Low;
		}
	}
}
