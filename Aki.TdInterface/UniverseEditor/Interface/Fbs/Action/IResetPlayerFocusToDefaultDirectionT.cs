using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006E92 RID: 28306
	public class IResetPlayerFocusToDefaultDirectionT
	{
		// Token: 0x1700D2C9 RID: 53961
		// (get) Token: 0x0603207F RID: 204927 RVA: 0x006C4536 File Offset: 0x006C2736
		// (set) Token: 0x06032080 RID: 204928 RVA: 0x006C453E File Offset: 0x006C273E
		public EResetPlayerFocusType Type { get; set; }

		// Token: 0x06032081 RID: 204929 RVA: 0x006C4547 File Offset: 0x006C2747
		public IResetPlayerFocusToDefaultDirectionT()
		{
			this.Type = EResetPlayerFocusType.ResetToDefaultDirection;
		}
	}
}
