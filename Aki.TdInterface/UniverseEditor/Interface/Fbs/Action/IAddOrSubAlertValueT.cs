using System;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006794 RID: 26516
	public class IAddOrSubAlertValueT
	{
		// Token: 0x1700C0CF RID: 49359
		// (get) Token: 0x0602CF78 RID: 184184 RVA: 0x0062562C File Offset: 0x0062382C
		// (set) Token: 0x0602CF79 RID: 184185 RVA: 0x00625634 File Offset: 0x00623834
		public EValueChangeType Type { get; set; }

		// Token: 0x1700C0D0 RID: 49360
		// (get) Token: 0x0602CF7A RID: 184186 RVA: 0x0062563D File Offset: 0x0062383D
		// (set) Token: 0x0602CF7B RID: 184187 RVA: 0x00625645 File Offset: 0x00623845
		public float DeltaValue { get; set; }

		// Token: 0x0602CF7C RID: 184188 RVA: 0x0062564E File Offset: 0x0062384E
		public IAddOrSubAlertValueT()
		{
			this.Type = EValueChangeType.AddOrSub;
			this.DeltaValue = 0f;
		}
	}
}
