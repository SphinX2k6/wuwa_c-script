using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A42 RID: 23106
	public class ILetGoDestroyConditionT
	{
		// Token: 0x1700A817 RID: 43031
		// (get) Token: 0x06025CAC RID: 154796 RVA: 0x0052E642 File Offset: 0x0052C842
		// (set) Token: 0x06025CAD RID: 154797 RVA: 0x0052E64A File Offset: 0x0052C84A
		public ETeleControlDestroyCondition Type { get; set; }

		// Token: 0x06025CAE RID: 154798 RVA: 0x0052E653 File Offset: 0x0052C853
		public ILetGoDestroyConditionT()
		{
			this.Type = ETeleControlDestroyCondition.LetGo;
		}
	}
}
