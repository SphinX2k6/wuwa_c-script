using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C4E RID: 11342
	public class ISetRegionMpc : SetRegionConfig
	{
		// Token: 0x0600F96B RID: 63851 RVA: 0x00243A8D File Offset: 0x00241C8D
		public static ISetRegionMpc Create(ISetRegionMpc? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISetRegionMpc
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004D7D RID: 19837
		// (get) Token: 0x0600F96C RID: 63852 RVA: 0x00243AAC File Offset: 0x00241CAC
		public override ERegionConfigType Type
		{
			get
			{
				return (ERegionConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004D7E RID: 19838
		// (get) Token: 0x0600F96D RID: 63853 RVA: 0x00243AB9 File Offset: 0x00241CB9
		public virtual int RegionMpcId
		{
			get
			{
				return this.Instance.RegionMpcId;
			}
		}

		// Token: 0x04008854 RID: 34900
		private ISetRegionMpc Instance;
	}
}
