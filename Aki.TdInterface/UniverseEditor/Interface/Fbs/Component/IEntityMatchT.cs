using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056F5 RID: 22261
	public class IEntityMatchT
	{
		// Token: 0x1700A07E RID: 41086
		// (get) Token: 0x06023BC5 RID: 146373 RVA: 0x004E9C2F File Offset: 0x004E7E2F
		// (set) Token: 0x06023BC6 RID: 146374 RVA: 0x004E9C37 File Offset: 0x004E7E37
		public bool AllCharacter { get; set; }

		// Token: 0x1700A07F RID: 41087
		// (get) Token: 0x06023BC7 RID: 146375 RVA: 0x004E9C40 File Offset: 0x004E7E40
		// (set) Token: 0x06023BC8 RID: 146376 RVA: 0x004E9C48 File Offset: 0x004E7E48
		public bool OnlyPlayer { get; set; }

		// Token: 0x1700A080 RID: 41088
		// (get) Token: 0x06023BC9 RID: 146377 RVA: 0x004E9C51 File Offset: 0x004E7E51
		// (set) Token: 0x06023BCA RID: 146378 RVA: 0x004E9C59 File Offset: 0x004E7E59
		public List<IEntityCategoryT> Categories { get; set; }

		// Token: 0x1700A081 RID: 41089
		// (get) Token: 0x06023BCB RID: 146379 RVA: 0x004E9C62 File Offset: 0x004E7E62
		// (set) Token: 0x06023BCC RID: 146380 RVA: 0x004E9C6A File Offset: 0x004E7E6A
		public List<int> EntityIds { get; set; }

		// Token: 0x1700A082 RID: 41090
		// (get) Token: 0x06023BCD RID: 146381 RVA: 0x004E9C73 File Offset: 0x004E7E73
		// (set) Token: 0x06023BCE RID: 146382 RVA: 0x004E9C7B File Offset: 0x004E7E7B
		public List<IEntityStateT> States { get; set; }

		// Token: 0x1700A083 RID: 41091
		// (get) Token: 0x06023BCF RID: 146383 RVA: 0x004E9C84 File Offset: 0x004E7E84
		// (set) Token: 0x06023BD0 RID: 146384 RVA: 0x004E9C8C File Offset: 0x004E7E8C
		public List<string> PerformanceStates { get; set; }

		// Token: 0x1700A084 RID: 41092
		// (get) Token: 0x06023BD1 RID: 146385 RVA: 0x004E9C95 File Offset: 0x004E7E95
		// (set) Token: 0x06023BD2 RID: 146386 RVA: 0x004E9C9D File Offset: 0x004E7E9D
		public byte NullMask { get; set; }

		// Token: 0x06023BD3 RID: 146387 RVA: 0x004E9CA6 File Offset: 0x004E7EA6
		public IEntityMatchT()
		{
			this.AllCharacter = false;
			this.OnlyPlayer = false;
			this.Categories = null;
			this.EntityIds = null;
			this.States = null;
			this.PerformanceStates = null;
			this.NullMask = 0;
		}
	}
}
