using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EA8 RID: 20136
	public class IAnimalEmotionBubbleEntryT
	{
		// Token: 0x17009078 RID: 36984
		// (get) Token: 0x0601FB50 RID: 129872 RVA: 0x0046A3D6 File Offset: 0x004685D6
		// (set) Token: 0x0601FB51 RID: 129873 RVA: 0x0046A3DE File Offset: 0x004685DE
		public string MontagePath { get; set; }

		// Token: 0x17009079 RID: 36985
		// (get) Token: 0x0601FB52 RID: 129874 RVA: 0x0046A3E7 File Offset: 0x004685E7
		// (set) Token: 0x0601FB53 RID: 129875 RVA: 0x0046A3EF File Offset: 0x004685EF
		public string EmotionName { get; set; }

		// Token: 0x0601FB54 RID: 129876 RVA: 0x0046A3F8 File Offset: 0x004685F8
		public IAnimalEmotionBubbleEntryT()
		{
			this.MontagePath = null;
			this.EmotionName = null;
		}
	}
}
