using System;
using Aki.UniverseEditor.Interface.Fbs.Var;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004404 RID: 17412
	public class IProgressCalculateT
	{
		// Token: 0x170077F9 RID: 30713
		// (get) Token: 0x06018C12 RID: 101394 RVA: 0x003872AB File Offset: 0x003854AB
		// (set) Token: 0x06018C13 RID: 101395 RVA: 0x003872B3 File Offset: 0x003854B3
		public TProgressBarLeftTypeUnion VarLeft { get; set; }

		// Token: 0x170077FA RID: 30714
		// (get) Token: 0x06018C14 RID: 101396 RVA: 0x003872BC File Offset: 0x003854BC
		// (set) Token: 0x06018C15 RID: 101397 RVA: 0x003872C4 File Offset: 0x003854C4
		public TVarRefUnion VarRight { get; set; }

		// Token: 0x06018C16 RID: 101398 RVA: 0x003872CD File Offset: 0x003854CD
		public IProgressCalculateT()
		{
			this.VarLeft = null;
			this.VarRight = null;
		}
	}
}
