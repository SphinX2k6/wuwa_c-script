using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020059F1 RID: 23025
	public class IInteractScreenDetectShapeBaseT
	{
		// Token: 0x1700A753 RID: 42835
		// (get) Token: 0x06025991 RID: 154001 RVA: 0x00527DF2 File Offset: 0x00525FF2
		// (set) Token: 0x06025992 RID: 154002 RVA: 0x00527DFA File Offset: 0x00525FFA
		public EInteractScreenDetectShape Type { get; set; }

		// Token: 0x06025993 RID: 154003 RVA: 0x00527E03 File Offset: 0x00526003
		public IInteractScreenDetectShapeBaseT()
		{
			this.Type = EInteractScreenDetectShape.Circle;
		}
	}
}
