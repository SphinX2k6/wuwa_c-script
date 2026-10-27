using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004EAB RID: 20139
	public class IAnimalModelT
	{
		// Token: 0x1700907F RID: 36991
		// (get) Token: 0x0601FB6E RID: 129902 RVA: 0x0046A770 File Offset: 0x00468970
		// (set) Token: 0x0601FB6F RID: 129903 RVA: 0x0046A778 File Offset: 0x00468978
		public EModelType Type { get; set; }

		// Token: 0x17009080 RID: 36992
		// (get) Token: 0x0601FB70 RID: 129904 RVA: 0x0046A781 File Offset: 0x00468981
		// (set) Token: 0x0601FB71 RID: 129905 RVA: 0x0046A789 File Offset: 0x00468989
		public string BlueprintPath { get; set; }

		// Token: 0x17009081 RID: 36993
		// (get) Token: 0x0601FB72 RID: 129906 RVA: 0x0046A792 File Offset: 0x00468992
		// (set) Token: 0x0601FB73 RID: 129907 RVA: 0x0046A79A File Offset: 0x0046899A
		public IMeshAnimalModelT AnimalModel { get; set; }

		// Token: 0x17009082 RID: 36994
		// (get) Token: 0x0601FB74 RID: 129908 RVA: 0x0046A7A3 File Offset: 0x004689A3
		// (set) Token: 0x0601FB75 RID: 129909 RVA: 0x0046A7AB File Offset: 0x004689AB
		public string Abp { get; set; }

		// Token: 0x0601FB76 RID: 129910 RVA: 0x0046A7B4 File Offset: 0x004689B4
		public IAnimalModelT()
		{
			this.Type = EModelType.LevelPrefab;
			this.BlueprintPath = null;
			this.AnimalModel = null;
			this.Abp = null;
		}
	}
}
