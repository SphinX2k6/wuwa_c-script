using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006EA7 RID: 28327
	public class IResetPosTypeT
	{
		// Token: 0x1700D2E7 RID: 53991
		// (get) Token: 0x06032111 RID: 205073 RVA: 0x006C548E File Offset: 0x006C368E
		// (set) Token: 0x06032112 RID: 205074 RVA: 0x006C5496 File Offset: 0x006C3696
		public EResetPosType Type { get; set; }

		// Token: 0x06032113 RID: 205075 RVA: 0x006C549F File Offset: 0x006C369F
		public IResetPosTypeT()
		{
			this.Type = EResetPosType.PosEntity;
		}
	}
}
