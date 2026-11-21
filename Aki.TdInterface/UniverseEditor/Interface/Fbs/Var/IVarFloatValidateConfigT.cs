using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F08 RID: 16136
	public class IVarFloatValidateConfigT
	{
		// Token: 0x17006D43 RID: 27971
		// (get) Token: 0x06015E77 RID: 89719 RVA: 0x0032668D File Offset: 0x0032488D
		// (set) Token: 0x06015E78 RID: 89720 RVA: 0x00326695 File Offset: 0x00324895
		public EVar Type { get; set; }

		// Token: 0x17006D44 RID: 27972
		// (get) Token: 0x06015E79 RID: 89721 RVA: 0x0032669E File Offset: 0x0032489E
		// (set) Token: 0x06015E7A RID: 89722 RVA: 0x003266A6 File Offset: 0x003248A6
		public List<float> ValidList { get; set; }

		// Token: 0x17006D45 RID: 27973
		// (get) Token: 0x06015E7B RID: 89723 RVA: 0x003266AF File Offset: 0x003248AF
		// (set) Token: 0x06015E7C RID: 89724 RVA: 0x003266B7 File Offset: 0x003248B7
		public float MinValue { get; set; }

		// Token: 0x17006D46 RID: 27974
		// (get) Token: 0x06015E7D RID: 89725 RVA: 0x003266C0 File Offset: 0x003248C0
		// (set) Token: 0x06015E7E RID: 89726 RVA: 0x003266C8 File Offset: 0x003248C8
		public float MaxValue { get; set; }

		// Token: 0x17006D47 RID: 27975
		// (get) Token: 0x06015E7F RID: 89727 RVA: 0x003266D1 File Offset: 0x003248D1
		// (set) Token: 0x06015E80 RID: 89728 RVA: 0x003266D9 File Offset: 0x003248D9
		public byte NullMask { get; set; }

		// Token: 0x06015E81 RID: 89729 RVA: 0x003266E2 File Offset: 0x003248E2
		public IVarFloatValidateConfigT()
		{
			this.Type = EVar.Boolean;
			this.ValidList = null;
			this.MinValue = 0f;
			this.MaxValue = 0f;
			this.NullMask = 0;
		}
	}
}
