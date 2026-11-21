using System;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B51 RID: 19281
	public class IEntityClientRunningDataT
	{
		// Token: 0x170087E5 RID: 34789
		// (get) Token: 0x0601D3F2 RID: 119794 RVA: 0x0041B814 File Offset: 0x00419A14
		// (set) Token: 0x0601D3F3 RID: 119795 RVA: 0x0041B81C File Offset: 0x00419A1C
		public int ConfigId { get; set; }

		// Token: 0x170087E6 RID: 34790
		// (get) Token: 0x0601D3F4 RID: 119796 RVA: 0x0041B825 File Offset: 0x00419A25
		// (set) Token: 0x0601D3F5 RID: 119797 RVA: 0x0041B82D File Offset: 0x00419A2D
		public EEntityClientCreateState CreateState { get; set; }

		// Token: 0x170087E7 RID: 34791
		// (get) Token: 0x0601D3F6 RID: 119798 RVA: 0x0041B836 File Offset: 0x00419A36
		// (set) Token: 0x0601D3F7 RID: 119799 RVA: 0x0041B83E File Offset: 0x00419A3E
		public string Reason { get; set; }

		// Token: 0x170087E8 RID: 34792
		// (get) Token: 0x0601D3F8 RID: 119800 RVA: 0x0041B847 File Offset: 0x00419A47
		// (set) Token: 0x0601D3F9 RID: 119801 RVA: 0x0041B84F File Offset: 0x00419A4F
		public bool IsClientVisible { get; set; }

		// Token: 0x170087E9 RID: 34793
		// (get) Token: 0x0601D3FA RID: 119802 RVA: 0x0041B858 File Offset: 0x00419A58
		// (set) Token: 0x0601D3FB RID: 119803 RVA: 0x0041B860 File Offset: 0x00419A60
		public bool IsInRange { get; set; }

		// Token: 0x170087EA RID: 34794
		// (get) Token: 0x0601D3FC RID: 119804 RVA: 0x0041B869 File Offset: 0x00419A69
		// (set) Token: 0x0601D3FD RID: 119805 RVA: 0x0041B871 File Offset: 0x00419A71
		public string Tags { get; set; }

		// Token: 0x170087EB RID: 34795
		// (get) Token: 0x0601D3FE RID: 119806 RVA: 0x0041B87A File Offset: 0x00419A7A
		// (set) Token: 0x0601D3FF RID: 119807 RVA: 0x0041B882 File Offset: 0x00419A82
		public byte NullMask { get; set; }

		// Token: 0x0601D400 RID: 119808 RVA: 0x0041B88B File Offset: 0x00419A8B
		public IEntityClientRunningDataT()
		{
			this.ConfigId = 0;
			this.CreateState = EEntityClientCreateState.None;
			this.Reason = null;
			this.IsClientVisible = false;
			this.IsInRange = false;
			this.Tags = null;
			this.NullMask = 0;
		}
	}
}
