using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x020047A3 RID: 18339
	public class IEntityDataT
	{
		// Token: 0x170083A5 RID: 33701
		// (get) Token: 0x0601C48D RID: 115853 RVA: 0x004013C6 File Offset: 0x003FF5C6
		// (set) Token: 0x0601C48E RID: 115854 RVA: 0x004013CE File Offset: 0x003FF5CE
		public string ObjType { get; set; }

		// Token: 0x170083A6 RID: 33702
		// (get) Token: 0x0601C48F RID: 115855 RVA: 0x004013D7 File Offset: 0x003FF5D7
		// (set) Token: 0x0601C490 RID: 115856 RVA: 0x004013DF File Offset: 0x003FF5DF
		public List<string> Children { get; set; }

		// Token: 0x170083A7 RID: 33703
		// (get) Token: 0x0601C491 RID: 115857 RVA: 0x004013E8 File Offset: 0x003FF5E8
		// (set) Token: 0x0601C492 RID: 115858 RVA: 0x004013F0 File Offset: 0x003FF5F0
		public List<string> Reference { get; set; }

		// Token: 0x170083A8 RID: 33704
		// (get) Token: 0x0601C493 RID: 115859 RVA: 0x004013F9 File Offset: 0x003FF5F9
		// (set) Token: 0x0601C494 RID: 115860 RVA: 0x00401401 File Offset: 0x003FF601
		public List<string> WeakReference { get; set; }

		// Token: 0x170083A9 RID: 33705
		// (get) Token: 0x0601C495 RID: 115861 RVA: 0x0040140A File Offset: 0x003FF60A
		// (set) Token: 0x0601C496 RID: 115862 RVA: 0x00401412 File Offset: 0x003FF612
		public string Name { get; set; }

		// Token: 0x170083AA RID: 33706
		// (get) Token: 0x0601C497 RID: 115863 RVA: 0x0040141B File Offset: 0x003FF61B
		// (set) Token: 0x0601C498 RID: 115864 RVA: 0x00401423 File Offset: 0x003FF623
		public string BlueprintType { get; set; }

		// Token: 0x170083AB RID: 33707
		// (get) Token: 0x0601C499 RID: 115865 RVA: 0x0040142C File Offset: 0x003FF62C
		// (set) Token: 0x0601C49A RID: 115866 RVA: 0x00401434 File Offset: 0x003FF634
		public TComponentsDataT ComponentsData { get; set; }

		// Token: 0x170083AC RID: 33708
		// (get) Token: 0x0601C49B RID: 115867 RVA: 0x0040143D File Offset: 0x003FF63D
		// (set) Token: 0x0601C49C RID: 115868 RVA: 0x00401445 File Offset: 0x003FF645
		public int Id { get; set; }

		// Token: 0x170083AD RID: 33709
		// (get) Token: 0x0601C49D RID: 115869 RVA: 0x0040144E File Offset: 0x003FF64E
		// (set) Token: 0x0601C49E RID: 115870 RVA: 0x00401456 File Offset: 0x003FF656
		public bool InSleep { get; set; }

		// Token: 0x170083AE RID: 33710
		// (get) Token: 0x0601C49F RID: 115871 RVA: 0x0040145F File Offset: 0x003FF65F
		// (set) Token: 0x0601C4A0 RID: 115872 RVA: 0x00401467 File Offset: 0x003FF667
		public bool IsHidden { get; set; }

		// Token: 0x170083AF RID: 33711
		// (get) Token: 0x0601C4A1 RID: 115873 RVA: 0x00401470 File Offset: 0x003FF670
		// (set) Token: 0x0601C4A2 RID: 115874 RVA: 0x00401478 File Offset: 0x003FF678
		public bool IsClientHidden { get; set; }

		// Token: 0x170083B0 RID: 33712
		// (get) Token: 0x0601C4A3 RID: 115875 RVA: 0x00401481 File Offset: 0x003FF681
		// (set) Token: 0x0601C4A4 RID: 115876 RVA: 0x00401489 File Offset: 0x003FF689
		public bool IsAlwaysLoad { get; set; }

		// Token: 0x170083B1 RID: 33713
		// (get) Token: 0x0601C4A5 RID: 115877 RVA: 0x00401492 File Offset: 0x003FF692
		// (set) Token: 0x0601C4A6 RID: 115878 RVA: 0x0040149A File Offset: 0x003FF69A
		public bool IsClientAlwaysLoad { get; set; }

		// Token: 0x170083B2 RID: 33714
		// (get) Token: 0x0601C4A7 RID: 115879 RVA: 0x004014A3 File Offset: 0x003FF6A3
		// (set) Token: 0x0601C4A8 RID: 115880 RVA: 0x004014AB File Offset: 0x003FF6AB
		public bool IsDeprecated { get; set; }

		// Token: 0x170083B3 RID: 33715
		// (get) Token: 0x0601C4A9 RID: 115881 RVA: 0x004014B4 File Offset: 0x003FF6B4
		// (set) Token: 0x0601C4AA RID: 115882 RVA: 0x004014BC File Offset: 0x003FF6BC
		public int _PrevTemplateId { get; set; }

		// Token: 0x170083B4 RID: 33716
		// (get) Token: 0x0601C4AB RID: 115883 RVA: 0x004014C5 File Offset: 0x003FF6C5
		// (set) Token: 0x0601C4AC RID: 115884 RVA: 0x004014CD File Offset: 0x003FF6CD
		public ITransformT Transform { get; set; }

		// Token: 0x170083B5 RID: 33717
		// (get) Token: 0x0601C4AD RID: 115885 RVA: 0x004014D6 File Offset: 0x003FF6D6
		// (set) Token: 0x0601C4AE RID: 115886 RVA: 0x004014DE File Offset: 0x003FF6DE
		public bool IsScaleEnabled { get; set; }

		// Token: 0x170083B6 RID: 33718
		// (get) Token: 0x0601C4AF RID: 115887 RVA: 0x004014E7 File Offset: 0x003FF6E7
		// (set) Token: 0x0601C4B0 RID: 115888 RVA: 0x004014EF File Offset: 0x003FF6EF
		public int AreaId { get; set; }

		// Token: 0x170083B7 RID: 33719
		// (get) Token: 0x0601C4B1 RID: 115889 RVA: 0x004014F8 File Offset: 0x003FF6F8
		// (set) Token: 0x0601C4B2 RID: 115890 RVA: 0x00401500 File Offset: 0x003FF700
		public ushort NullMask { get; set; }

		// Token: 0x0601C4B3 RID: 115891 RVA: 0x0040150C File Offset: 0x003FF70C
		public IEntityDataT()
		{
			this.ObjType = null;
			this.Children = null;
			this.Reference = null;
			this.WeakReference = null;
			this.Name = null;
			this.BlueprintType = null;
			this.ComponentsData = null;
			this.Id = 0;
			this.InSleep = false;
			this.IsHidden = false;
			this.IsClientHidden = false;
			this.IsAlwaysLoad = false;
			this.IsClientAlwaysLoad = false;
			this.IsDeprecated = false;
			this._PrevTemplateId = 0;
			this.Transform = null;
			this.IsScaleEnabled = false;
			this.AreaId = 0;
			this.NullMask = 0;
		}
	}
}
