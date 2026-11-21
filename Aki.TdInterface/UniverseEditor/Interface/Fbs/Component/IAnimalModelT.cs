using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053D4 RID: 21460
	public class IAnimalModelT
	{
		// Token: 0x170097E0 RID: 38880
		// (get) Token: 0x0602186F RID: 137327 RVA: 0x0049FBEC File Offset: 0x0049DDEC
		// (set) Token: 0x06021870 RID: 137328 RVA: 0x0049FBF4 File Offset: 0x0049DDF4
		public EModelType Type { get; set; }

		// Token: 0x170097E1 RID: 38881
		// (get) Token: 0x06021871 RID: 137329 RVA: 0x0049FBFD File Offset: 0x0049DDFD
		// (set) Token: 0x06021872 RID: 137330 RVA: 0x0049FC05 File Offset: 0x0049DE05
		public string BlueprintPath { get; set; }

		// Token: 0x170097E2 RID: 38882
		// (get) Token: 0x06021873 RID: 137331 RVA: 0x0049FC0E File Offset: 0x0049DE0E
		// (set) Token: 0x06021874 RID: 137332 RVA: 0x0049FC16 File Offset: 0x0049DE16
		public IMeshAnimalModelT AnimalModel { get; set; }

		// Token: 0x170097E3 RID: 38883
		// (get) Token: 0x06021875 RID: 137333 RVA: 0x0049FC1F File Offset: 0x0049DE1F
		// (set) Token: 0x06021876 RID: 137334 RVA: 0x0049FC27 File Offset: 0x0049DE27
		public string Abp { get; set; }

		// Token: 0x06021877 RID: 137335 RVA: 0x0049FC30 File Offset: 0x0049DE30
		public IAnimalModelT()
		{
			this.Type = EModelType.LevelPrefab;
			this.BlueprintPath = null;
			this.AnimalModel = null;
			this.Abp = null;
		}
	}
}
