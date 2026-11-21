using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CDB RID: 3291
	public class IGuideLineCreatorScanOption
	{
		// Token: 0x06004B29 RID: 19241 RVA: 0x000BCAED File Offset: 0x000BACED
		public static IGuideLineCreatorScanOption Create(IGuideLineCreatorScanOption? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGuideLineCreatorScanOption
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700156E RID: 5486
		// (get) Token: 0x06004B2A RID: 19242 RVA: 0x000BCB0C File Offset: 0x000BAD0C
		public virtual int ResponseRange
		{
			get
			{
				return this.Instance.ResponseRange;
			}
		}

		// Token: 0x04002A86 RID: 10886
		private IGuideLineCreatorScanOption Instance;
	}
}
