using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA2 RID: 23202
	public class ILowViewDistanceT
	{
		// Token: 0x1700A910 RID: 43280
		// (get) Token: 0x06026085 RID: 155781 RVA: 0x005363C6 File Offset: 0x005345C6
		// (set) Token: 0x06026086 RID: 155782 RVA: 0x005363CE File Offset: 0x005345CE
		public EViewDistanceType Type { get; set; }

		// Token: 0x06026087 RID: 155783 RVA: 0x005363D7 File Offset: 0x005345D7
		public ILowViewDistanceT()
		{
			this.Type = EViewDistanceType.Low;
		}
	}
}
