using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.UniverseEditor.Interface.Fbs.Entity
{
	// Token: 0x02004C0B RID: 19467
	public class IEntityDataT
	{
		// Token: 0x170089E6 RID: 35302
		// (get) Token: 0x0601DC62 RID: 121954 RVA: 0x0042D662 File Offset: 0x0042B862
		// (set) Token: 0x0601DC63 RID: 121955 RVA: 0x0042D66A File Offset: 0x0042B86A
		public string ObjType { get; set; }

		// Token: 0x170089E7 RID: 35303
		// (get) Token: 0x0601DC64 RID: 121956 RVA: 0x0042D673 File Offset: 0x0042B873
		// (set) Token: 0x0601DC65 RID: 121957 RVA: 0x0042D67B File Offset: 0x0042B87B
		public List<string> Children { get; set; }

		// Token: 0x170089E8 RID: 35304
		// (get) Token: 0x0601DC66 RID: 121958 RVA: 0x0042D684 File Offset: 0x0042B884
		// (set) Token: 0x0601DC67 RID: 121959 RVA: 0x0042D68C File Offset: 0x0042B88C
		public List<string> Reference { get; set; }

		// Token: 0x170089E9 RID: 35305
		// (get) Token: 0x0601DC68 RID: 121960 RVA: 0x0042D695 File Offset: 0x0042B895
		// (set) Token: 0x0601DC69 RID: 121961 RVA: 0x0042D69D File Offset: 0x0042B89D
		public List<string> WeakReference { get; set; }

		// Token: 0x170089EA RID: 35306
		// (get) Token: 0x0601DC6A RID: 121962 RVA: 0x0042D6A6 File Offset: 0x0042B8A6
		// (set) Token: 0x0601DC6B RID: 121963 RVA: 0x0042D6AE File Offset: 0x0042B8AE
		public string Name { get; set; }

		// Token: 0x170089EB RID: 35307
		// (get) Token: 0x0601DC6C RID: 121964 RVA: 0x0042D6B7 File Offset: 0x0042B8B7
		// (set) Token: 0x0601DC6D RID: 121965 RVA: 0x0042D6BF File Offset: 0x0042B8BF
		public string BlueprintType { get; set; }

		// Token: 0x170089EC RID: 35308
		// (get) Token: 0x0601DC6E RID: 121966 RVA: 0x0042D6C8 File Offset: 0x0042B8C8
		// (set) Token: 0x0601DC6F RID: 121967 RVA: 0x0042D6D0 File Offset: 0x0042B8D0
		public TComponentsDataT ComponentsData { get; set; }

		// Token: 0x170089ED RID: 35309
		// (get) Token: 0x0601DC70 RID: 121968 RVA: 0x0042D6D9 File Offset: 0x0042B8D9
		// (set) Token: 0x0601DC71 RID: 121969 RVA: 0x0042D6E1 File Offset: 0x0042B8E1
		public int Id { get; set; }

		// Token: 0x170089EE RID: 35310
		// (get) Token: 0x0601DC72 RID: 121970 RVA: 0x0042D6EA File Offset: 0x0042B8EA
		// (set) Token: 0x0601DC73 RID: 121971 RVA: 0x0042D6F2 File Offset: 0x0042B8F2
		public bool InSleep { get; set; }

		// Token: 0x170089EF RID: 35311
		// (get) Token: 0x0601DC74 RID: 121972 RVA: 0x0042D6FB File Offset: 0x0042B8FB
		// (set) Token: 0x0601DC75 RID: 121973 RVA: 0x0042D703 File Offset: 0x0042B903
		public bool IsHidden { get; set; }

		// Token: 0x170089F0 RID: 35312
		// (get) Token: 0x0601DC76 RID: 121974 RVA: 0x0042D70C File Offset: 0x0042B90C
		// (set) Token: 0x0601DC77 RID: 121975 RVA: 0x0042D714 File Offset: 0x0042B914
		public bool IsClientHidden { get; set; }

		// Token: 0x170089F1 RID: 35313
		// (get) Token: 0x0601DC78 RID: 121976 RVA: 0x0042D71D File Offset: 0x0042B91D
		// (set) Token: 0x0601DC79 RID: 121977 RVA: 0x0042D725 File Offset: 0x0042B925
		public bool IsAlwaysLoad { get; set; }

		// Token: 0x170089F2 RID: 35314
		// (get) Token: 0x0601DC7A RID: 121978 RVA: 0x0042D72E File Offset: 0x0042B92E
		// (set) Token: 0x0601DC7B RID: 121979 RVA: 0x0042D736 File Offset: 0x0042B936
		public bool IsClientAlwaysLoad { get; set; }

		// Token: 0x170089F3 RID: 35315
		// (get) Token: 0x0601DC7C RID: 121980 RVA: 0x0042D73F File Offset: 0x0042B93F
		// (set) Token: 0x0601DC7D RID: 121981 RVA: 0x0042D747 File Offset: 0x0042B947
		public bool IsDeprecated { get; set; }

		// Token: 0x170089F4 RID: 35316
		// (get) Token: 0x0601DC7E RID: 121982 RVA: 0x0042D750 File Offset: 0x0042B950
		// (set) Token: 0x0601DC7F RID: 121983 RVA: 0x0042D758 File Offset: 0x0042B958
		public int _PrevTemplateId { get; set; }

		// Token: 0x170089F5 RID: 35317
		// (get) Token: 0x0601DC80 RID: 121984 RVA: 0x0042D761 File Offset: 0x0042B961
		// (set) Token: 0x0601DC81 RID: 121985 RVA: 0x0042D769 File Offset: 0x0042B969
		public ITransformT Transform { get; set; }

		// Token: 0x170089F6 RID: 35318
		// (get) Token: 0x0601DC82 RID: 121986 RVA: 0x0042D772 File Offset: 0x0042B972
		// (set) Token: 0x0601DC83 RID: 121987 RVA: 0x0042D77A File Offset: 0x0042B97A
		public bool IsScaleEnabled { get; set; }

		// Token: 0x170089F7 RID: 35319
		// (get) Token: 0x0601DC84 RID: 121988 RVA: 0x0042D783 File Offset: 0x0042B983
		// (set) Token: 0x0601DC85 RID: 121989 RVA: 0x0042D78B File Offset: 0x0042B98B
		public int AreaId { get; set; }

		// Token: 0x170089F8 RID: 35320
		// (get) Token: 0x0601DC86 RID: 121990 RVA: 0x0042D794 File Offset: 0x0042B994
		// (set) Token: 0x0601DC87 RID: 121991 RVA: 0x0042D79C File Offset: 0x0042B99C
		public ushort NullMask { get; set; }

		// Token: 0x0601DC88 RID: 121992 RVA: 0x0042D7A8 File Offset: 0x0042B9A8
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
