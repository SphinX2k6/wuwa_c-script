using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007173 RID: 29043
	public class ISpecialCustomLoadingOptionT
	{
		// Token: 0x1700D7C9 RID: 55241
		// (get) Token: 0x060337F5 RID: 210933 RVA: 0x006F0026 File Offset: 0x006EE226
		// (set) Token: 0x060337F6 RID: 210934 RVA: 0x006F002E File Offset: 0x006EE22E
		public ESpecialCustomLoadingType Type { get; set; }

		// Token: 0x060337F7 RID: 210935 RVA: 0x006F0037 File Offset: 0x006EE237
		public ISpecialCustomLoadingOptionT()
		{
			this.Type = ESpecialCustomLoadingType.HonamiStory;
		}
	}
}
