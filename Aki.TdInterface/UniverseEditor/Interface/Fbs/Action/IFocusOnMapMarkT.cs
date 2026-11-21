using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006ECA RID: 28362
	public class IFocusOnMapMarkT
	{
		// Token: 0x1700D00E RID: 53262
		// (get) Token: 0x06031131 RID: 201009 RVA: 0x006A792A File Offset: 0x006A5B2A
		// (set) Token: 0x06031132 RID: 201010 RVA: 0x006A7932 File Offset: 0x006A5B32
		public EMapMarkType Type { get; set; }

		// Token: 0x06031133 RID: 201011 RVA: 0x006A793B File Offset: 0x006A5B3B
		public IFocusOnMapMarkT()
		{
			this.Type = EMapMarkType.Custom;
		}
	}
}
