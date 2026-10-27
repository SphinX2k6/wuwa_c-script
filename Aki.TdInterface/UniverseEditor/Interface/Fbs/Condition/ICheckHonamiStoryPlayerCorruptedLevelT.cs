using System;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A61 RID: 19041
	public class ICheckHonamiStoryPlayerCorruptedLevelT
	{
		// Token: 0x170089DE RID: 35294
		// (get) Token: 0x0601DD40 RID: 122176 RVA: 0x0043109A File Offset: 0x0042F29A
		// (set) Token: 0x0601DD41 RID: 122177 RVA: 0x004310A2 File Offset: 0x0042F2A2
		public ECondition Type { get; set; }

		// Token: 0x170089DF RID: 35295
		// (get) Token: 0x0601DD42 RID: 122178 RVA: 0x004310AB File Offset: 0x0042F2AB
		// (set) Token: 0x0601DD43 RID: 122179 RVA: 0x004310B3 File Offset: 0x0042F2B3
		public ECompare Compare { get; set; }

		// Token: 0x170089E0 RID: 35296
		// (get) Token: 0x0601DD44 RID: 122180 RVA: 0x004310BC File Offset: 0x0042F2BC
		// (set) Token: 0x0601DD45 RID: 122181 RVA: 0x004310C4 File Offset: 0x0042F2C4
		public int Level { get; set; }

		// Token: 0x0601DD46 RID: 122182 RVA: 0x004310CD File Offset: 0x0042F2CD
		public ICheckHonamiStoryPlayerCorruptedLevelT()
		{
			this.Type = ECondition.CompareVar;
			this.Compare = ECompare.Eq;
			this.Level = 0;
		}
	}
}
