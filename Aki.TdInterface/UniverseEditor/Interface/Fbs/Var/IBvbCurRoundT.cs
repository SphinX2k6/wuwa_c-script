using System;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A49 RID: 14921
	public class IBvbCurRoundT
	{
		// Token: 0x1700664A RID: 26186
		// (get) Token: 0x06014358 RID: 82776 RVA: 0x002F4262 File Offset: 0x002F2462
		// (set) Token: 0x06014359 RID: 82777 RVA: 0x002F426A File Offset: 0x002F246A
		public ESystemVarName Type { get; set; }

		// Token: 0x0601435A RID: 82778 RVA: 0x002F4273 File Offset: 0x002F2473
		public IBvbCurRoundT()
		{
			this.Type = ESystemVarName.CommonHotFixVar;
		}
	}
}
