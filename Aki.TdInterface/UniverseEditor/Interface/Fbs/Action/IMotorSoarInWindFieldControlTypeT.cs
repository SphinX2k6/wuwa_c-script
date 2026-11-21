using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200727D RID: 29309
	public class IMotorSoarInWindFieldControlTypeT
	{
		// Token: 0x1700D6D6 RID: 54998
		// (get) Token: 0x06033124 RID: 209188 RVA: 0x006E4846 File Offset: 0x006E2A46
		// (set) Token: 0x06033125 RID: 209189 RVA: 0x006E484E File Offset: 0x006E2A4E
		public EMotorSoarInWindFieldControlType Type { get; set; }

		// Token: 0x06033126 RID: 209190 RVA: 0x006E4857 File Offset: 0x006E2A57
		public IMotorSoarInWindFieldControlTypeT()
		{
			this.Type = EMotorSoarInWindFieldControlType.EnterWindField;
		}
	}
}
