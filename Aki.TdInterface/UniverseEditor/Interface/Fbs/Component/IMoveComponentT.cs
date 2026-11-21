using System;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005B74 RID: 23412
	public class IMoveComponentT
	{
		// Token: 0x1700AB17 RID: 43799
		// (get) Token: 0x0602690A RID: 157962 RVA: 0x00547F92 File Offset: 0x00546192
		// (set) Token: 0x0602690B RID: 157963 RVA: 0x00547F9A File Offset: 0x0054619A
		public bool Disabled { get; set; }

		// Token: 0x1700AB18 RID: 43800
		// (get) Token: 0x0602690C RID: 157964 RVA: 0x00547FA3 File Offset: 0x005461A3
		// (set) Token: 0x0602690D RID: 157965 RVA: 0x00547FAB File Offset: 0x005461AB
		public float InitSpeed { get; set; }

		// Token: 0x1700AB19 RID: 43801
		// (get) Token: 0x0602690E RID: 157966 RVA: 0x00547FB4 File Offset: 0x005461B4
		// (set) Token: 0x0602690F RID: 157967 RVA: 0x00547FBC File Offset: 0x005461BC
		public byte NullMask { get; set; }

		// Token: 0x06026910 RID: 157968 RVA: 0x00547FC5 File Offset: 0x005461C5
		public IMoveComponentT()
		{
			this.Disabled = false;
			this.InitSpeed = 0f;
			this.NullMask = 0;
		}
	}
}
