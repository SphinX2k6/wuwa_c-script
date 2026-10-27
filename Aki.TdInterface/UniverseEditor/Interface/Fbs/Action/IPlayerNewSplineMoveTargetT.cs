using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D06 RID: 27910
	public class IPlayerNewSplineMoveTargetT
	{
		// Token: 0x1700CFDB RID: 53211
		// (get) Token: 0x06031380 RID: 201600 RVA: 0x006AD3E2 File Offset: 0x006AB5E2
		// (set) Token: 0x06031381 RID: 201601 RVA: 0x006AD3EA File Offset: 0x006AB5EA
		public ENewSplineMoveTargetType Type { get; set; }

		// Token: 0x06031382 RID: 201602 RVA: 0x006AD3F3 File Offset: 0x006AB5F3
		public IPlayerNewSplineMoveTargetT()
		{
			this.Type = ENewSplineMoveTargetType.Player;
		}
	}
}
