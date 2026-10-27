using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x020049F8 RID: 18936
	public class ICheckEntitiesExistT
	{
		// Token: 0x170088F3 RID: 35059
		// (get) Token: 0x0601D976 RID: 121206 RVA: 0x0042A1A9 File Offset: 0x004283A9
		// (set) Token: 0x0601D977 RID: 121207 RVA: 0x0042A1B1 File Offset: 0x004283B1
		public ECondition Type { get; set; }

		// Token: 0x170088F4 RID: 35060
		// (get) Token: 0x0601D978 RID: 121208 RVA: 0x0042A1BA File Offset: 0x004283BA
		// (set) Token: 0x0601D979 RID: 121209 RVA: 0x0042A1C2 File Offset: 0x004283C2
		public List<int> EntityIds { get; set; }

		// Token: 0x170088F5 RID: 35061
		// (get) Token: 0x0601D97A RID: 121210 RVA: 0x0042A1CB File Offset: 0x004283CB
		// (set) Token: 0x0601D97B RID: 121211 RVA: 0x0042A1D3 File Offset: 0x004283D3
		public bool IsExist { get; set; }

		// Token: 0x170088F6 RID: 35062
		// (get) Token: 0x0601D97C RID: 121212 RVA: 0x0042A1DC File Offset: 0x004283DC
		// (set) Token: 0x0601D97D RID: 121213 RVA: 0x0042A1E4 File Offset: 0x004283E4
		public bool IsFinishLoading { get; set; }

		// Token: 0x170088F7 RID: 35063
		// (get) Token: 0x0601D97E RID: 121214 RVA: 0x0042A1ED File Offset: 0x004283ED
		// (set) Token: 0x0601D97F RID: 121215 RVA: 0x0042A1F5 File Offset: 0x004283F5
		public byte NullMask { get; set; }

		// Token: 0x0601D980 RID: 121216 RVA: 0x0042A1FE File Offset: 0x004283FE
		public ICheckEntitiesExistT()
		{
			this.Type = ECondition.CompareVar;
			this.EntityIds = null;
			this.IsExist = false;
			this.IsFinishLoading = false;
			this.NullMask = 0;
		}
	}
}
