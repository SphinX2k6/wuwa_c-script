using System;
using System.Collections.Generic;

namespace Aki.UniverseEditor.Interface.Fbs.GameStatusDefine
{
	// Token: 0x02004B54 RID: 19284
	public class IEntityRunningDataT
	{
		// Token: 0x170087FC RID: 34812
		// (get) Token: 0x0601D448 RID: 119880 RVA: 0x0041C639 File Offset: 0x0041A839
		// (set) Token: 0x0601D449 RID: 119881 RVA: 0x0041C641 File Offset: 0x0041A841
		public int InstId { get; set; }

		// Token: 0x170087FD RID: 34813
		// (get) Token: 0x0601D44A RID: 119882 RVA: 0x0041C64A File Offset: 0x0041A84A
		// (set) Token: 0x0601D44B RID: 119883 RVA: 0x0041C652 File Offset: 0x0041A852
		public int ConfigID { get; set; }

		// Token: 0x170087FE RID: 34814
		// (get) Token: 0x0601D44C RID: 119884 RVA: 0x0041C65B File Offset: 0x0041A85B
		// (set) Token: 0x0601D44D RID: 119885 RVA: 0x0041C663 File Offset: 0x0041A863
		public bool IsProxy { get; set; }

		// Token: 0x170087FF RID: 34815
		// (get) Token: 0x0601D44E RID: 119886 RVA: 0x0041C66C File Offset: 0x0041A86C
		// (set) Token: 0x0601D44F RID: 119887 RVA: 0x0041C674 File Offset: 0x0041A874
		public EEntityProxyType ProxyState { get; set; }

		// Token: 0x17008800 RID: 34816
		// (get) Token: 0x0601D450 RID: 119888 RVA: 0x0041C67D File Offset: 0x0041A87D
		// (set) Token: 0x0601D451 RID: 119889 RVA: 0x0041C685 File Offset: 0x0041A885
		public bool IsAwake { get; set; }

		// Token: 0x17008801 RID: 34817
		// (get) Token: 0x0601D452 RID: 119890 RVA: 0x0041C68E File Offset: 0x0041A88E
		// (set) Token: 0x0601D453 RID: 119891 RVA: 0x0041C696 File Offset: 0x0041A896
		public bool IsVisable { get; set; }

		// Token: 0x17008802 RID: 34818
		// (get) Token: 0x0601D454 RID: 119892 RVA: 0x0041C69F File Offset: 0x0041A89F
		// (set) Token: 0x0601D455 RID: 119893 RVA: 0x0041C6A7 File Offset: 0x0041A8A7
		public bool IsLock { get; set; }

		// Token: 0x17008803 RID: 34819
		// (get) Token: 0x0601D456 RID: 119894 RVA: 0x0041C6B0 File Offset: 0x0041A8B0
		// (set) Token: 0x0601D457 RID: 119895 RVA: 0x0041C6B8 File Offset: 0x0041A8B8
		public bool IsInAOI { get; set; }

		// Token: 0x17008804 RID: 34820
		// (get) Token: 0x0601D458 RID: 119896 RVA: 0x0041C6C1 File Offset: 0x0041A8C1
		// (set) Token: 0x0601D459 RID: 119897 RVA: 0x0041C6C9 File Offset: 0x0041A8C9
		public bool IsInRange { get; set; }

		// Token: 0x17008805 RID: 34821
		// (get) Token: 0x0601D45A RID: 119898 RVA: 0x0041C6D2 File Offset: 0x0041A8D2
		// (set) Token: 0x0601D45B RID: 119899 RVA: 0x0041C6DA File Offset: 0x0041A8DA
		public string State { get; set; }

		// Token: 0x17008806 RID: 34822
		// (get) Token: 0x0601D45C RID: 119900 RVA: 0x0041C6E3 File Offset: 0x0041A8E3
		// (set) Token: 0x0601D45D RID: 119901 RVA: 0x0041C6EB File Offset: 0x0041A8EB
		public List<Record_String_StringT> Vars { get; set; }

		// Token: 0x17008807 RID: 34823
		// (get) Token: 0x0601D45E RID: 119902 RVA: 0x0041C6F4 File Offset: 0x0041A8F4
		// (set) Token: 0x0601D45F RID: 119903 RVA: 0x0041C6FC File Offset: 0x0041A8FC
		public List<int> Options { get; set; }

		// Token: 0x17008808 RID: 34824
		// (get) Token: 0x0601D460 RID: 119904 RVA: 0x0041C705 File Offset: 0x0041A905
		// (set) Token: 0x0601D461 RID: 119905 RVA: 0x0041C70D File Offset: 0x0041A90D
		public List<Record_Int_EActionStateT> AllActions { get; set; }

		// Token: 0x17008809 RID: 34825
		// (get) Token: 0x0601D462 RID: 119906 RVA: 0x0041C716 File Offset: 0x0041A916
		// (set) Token: 0x0601D463 RID: 119907 RVA: 0x0041C71E File Offset: 0x0041A91E
		public List<Record_Int_IntT> InRangeEntityStateInfo { get; set; }

		// Token: 0x1700880A RID: 34826
		// (get) Token: 0x0601D464 RID: 119908 RVA: 0x0041C727 File Offset: 0x0041A927
		// (set) Token: 0x0601D465 RID: 119909 RVA: 0x0041C72F File Offset: 0x0041A92F
		public byte NullMask { get; set; }

		// Token: 0x0601D466 RID: 119910 RVA: 0x0041C738 File Offset: 0x0041A938
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
