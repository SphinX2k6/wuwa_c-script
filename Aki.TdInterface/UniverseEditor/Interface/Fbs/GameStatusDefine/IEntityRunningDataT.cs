using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x020046EC RID: 18156
	public class IEntityRunningDataT
	{
		// Token: 0x170081BB RID: 33211
		// (get) Token: 0x0601BC73 RID: 113779 RVA: 0x003F039D File Offset: 0x003EE59D
		// (set) Token: 0x0601BC74 RID: 113780 RVA: 0x003F03A5 File Offset: 0x003EE5A5
		public int InstId { get; set; }

		// Token: 0x170081BC RID: 33212
		// (get) Token: 0x0601BC75 RID: 113781 RVA: 0x003F03AE File Offset: 0x003EE5AE
		// (set) Token: 0x0601BC76 RID: 113782 RVA: 0x003F03B6 File Offset: 0x003EE5B6
		public int ConfigID { get; set; }

		// Token: 0x170081BD RID: 33213
		// (get) Token: 0x0601BC77 RID: 113783 RVA: 0x003F03BF File Offset: 0x003EE5BF
		// (set) Token: 0x0601BC78 RID: 113784 RVA: 0x003F03C7 File Offset: 0x003EE5C7
		public bool IsProxy { get; set; }

		// Token: 0x170081BE RID: 33214
		// (get) Token: 0x0601BC79 RID: 113785 RVA: 0x003F03D0 File Offset: 0x003EE5D0
		// (set) Token: 0x0601BC7A RID: 113786 RVA: 0x003F03D8 File Offset: 0x003EE5D8
		public EEntityProxyType ProxyState { get; set; }

		// Token: 0x170081BF RID: 33215
		// (get) Token: 0x0601BC7B RID: 113787 RVA: 0x003F03E1 File Offset: 0x003EE5E1
		// (set) Token: 0x0601BC7C RID: 113788 RVA: 0x003F03E9 File Offset: 0x003EE5E9
		public bool IsAwake { get; set; }

		// Token: 0x170081C0 RID: 33216
		// (get) Token: 0x0601BC7D RID: 113789 RVA: 0x003F03F2 File Offset: 0x003EE5F2
		// (set) Token: 0x0601BC7E RID: 113790 RVA: 0x003F03FA File Offset: 0x003EE5FA
		public bool IsVisable { get; set; }

		// Token: 0x170081C1 RID: 33217
		// (get) Token: 0x0601BC7F RID: 113791 RVA: 0x003F0403 File Offset: 0x003EE603
		// (set) Token: 0x0601BC80 RID: 113792 RVA: 0x003F040B File Offset: 0x003EE60B
		public bool IsLock { get; set; }

		// Token: 0x170081C2 RID: 33218
		// (get) Token: 0x0601BC81 RID: 113793 RVA: 0x003F0414 File Offset: 0x003EE614
		// (set) Token: 0x0601BC82 RID: 113794 RVA: 0x003F041C File Offset: 0x003EE61C
		public bool IsInAOI { get; set; }

		// Token: 0x170081C3 RID: 33219
		// (get) Token: 0x0601BC83 RID: 113795 RVA: 0x003F0425 File Offset: 0x003EE625
		// (set) Token: 0x0601BC84 RID: 113796 RVA: 0x003F042D File Offset: 0x003EE62D
		public bool IsInRange { get; set; }

		// Token: 0x170081C4 RID: 33220
		// (get) Token: 0x0601BC85 RID: 113797 RVA: 0x003F0436 File Offset: 0x003EE636
		// (set) Token: 0x0601BC86 RID: 113798 RVA: 0x003F043E File Offset: 0x003EE63E
		public string State { get; set; }

		// Token: 0x170081C5 RID: 33221
		// (get) Token: 0x0601BC87 RID: 113799 RVA: 0x003F0447 File Offset: 0x003EE647
		// (set) Token: 0x0601BC88 RID: 113800 RVA: 0x003F044F File Offset: 0x003EE64F
		public List<Record_String_StringT> Vars { get; set; }

		// Token: 0x170081C6 RID: 33222
		// (get) Token: 0x0601BC89 RID: 113801 RVA: 0x003F0458 File Offset: 0x003EE658
		// (set) Token: 0x0601BC8A RID: 113802 RVA: 0x003F0460 File Offset: 0x003EE660
		public List<int> Options { get; set; }

		// Token: 0x170081C7 RID: 33223
		// (get) Token: 0x0601BC8B RID: 113803 RVA: 0x003F0469 File Offset: 0x003EE669
		// (set) Token: 0x0601BC8C RID: 113804 RVA: 0x003F0471 File Offset: 0x003EE671
		public List<Record_Int_EActionStateT> AllActions { get; set; }

		// Token: 0x170081C8 RID: 33224
		// (get) Token: 0x0601BC8D RID: 113805 RVA: 0x003F047A File Offset: 0x003EE67A
		// (set) Token: 0x0601BC8E RID: 113806 RVA: 0x003F0482 File Offset: 0x003EE682
		public List<Record_Int_IntT> InRangeEntityStateInfo { get; set; }

		// Token: 0x170081C9 RID: 33225
		// (get) Token: 0x0601BC8F RID: 113807 RVA: 0x003F048B File Offset: 0x003EE68B
		// (set) Token: 0x0601BC90 RID: 113808 RVA: 0x003F0493 File Offset: 0x003EE693
		public byte NullMask { get; set; }

		// Token: 0x0601BC91 RID: 113809 RVA: 0x003F049C File Offset: 0x003EE69C
		public IEntityRunningDataT()
		{
			this.InstId = 0;
			this.ConfigID = 0;
			this.IsProxy = false;
			this.ProxyState = EEntityProxyType.None;
			this.IsAwake = false;
			this.IsVisable = false;
			this.IsLock = false;
			this.IsInAOI = false;
			this.IsInRange = false;
			this.State = null;
			this.Vars = null;
			this.Options = null;
			this.AllActions = null;
			this.InRangeEntityStateInfo = null;
			this.NullMask = 0;
		}
	}
}
