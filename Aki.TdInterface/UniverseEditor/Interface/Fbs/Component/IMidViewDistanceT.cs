using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005552 RID: 21842
	public class IMidViewDistanceT
	{
		// Token: 0x1700A150 RID: 41296
		// (get) Token: 0x060241CD RID: 147917 RVA: 0x004FD1DE File Offset: 0x004FB3DE
		// (set) Token: 0x060241CE RID: 147918 RVA: 0x004FD1E6 File Offset: 0x004FB3E6
		public EViewDistanceType Type { get; set; }

		// Token: 0x060241CF RID: 147919 RVA: 0x004FD1EF File Offset: 0x004FB3EF
		public IMidViewDistanceT()
		{
			this.Type = EViewDistanceType.Low;
		}
	}
}
