using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A03 RID: 27139
	public class ILiftMoveTypeCircularT
	{
		// Token: 0x1700C95C RID: 51548
		// (get) Token: 0x0602F7D7 RID: 194519 RVA: 0x00677A0E File Offset: 0x00675C0E
		// (set) Token: 0x0602F7D8 RID: 194520 RVA: 0x00677A16 File Offset: 0x00675C16
		public ELiftMoveType Type { get; set; }

		// Token: 0x0602F7D9 RID: 194521 RVA: 0x00677A1F File Offset: 0x00675C1F
		public ILiftMoveTypeCircularT()
		{
			this.Type = ELiftMoveType.Default;
		}
	}
}
