using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000E45 RID: 3653
	public class ISharingVehicleFeature : IVehicleFeature
	{
		// Token: 0x060052AF RID: 21167 RVA: 0x000CC585 File Offset: 0x000CA785
		public static ISharingVehicleFeature Create(ISharingVehicleFeature? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISharingVehicleFeature
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001A20 RID: 6688
		// (get) Token: 0x060052B0 RID: 21168 RVA: 0x000CC5A4 File Offset: 0x000CA7A4
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x17001A21 RID: 6689
		// (get) Token: 0x060052B1 RID: 21169 RVA: 0x000CC5B4 File Offset: 0x000CA7B4
		public virtual EAffectionDegreeSourceType? AffectionDegreeSourceType
		{
			get
			{
				if ((this.Instance.NullMask & 1) == 0)
				{
					return null;
				}
				return new EAffectionDegreeSourceType?((EAffectionDegreeSourceType)this.Instance.AffectionDegreeSourceType);
			}
		}

		// Token: 0x04002F38 RID: 12088
		private ISharingVehicleFeature Instance;
	}
}
