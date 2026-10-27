using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000D4B RID: 3403
	public class ISharingVehicleFeature : IVehicleFeature
	{
		// Token: 0x06004D93 RID: 19859 RVA: 0x000C0E41 File Offset: 0x000BF041
		[NullableContext(1)]
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

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x06004D94 RID: 19860 RVA: 0x000C0E60 File Offset: 0x000BF060
		public override EVehicleFeatureFlag Type
		{
			get
			{
				return (EVehicleFeatureFlag)this.Instance.Type;
			}
		}

		// Token: 0x170018BB RID: 6331
		// (get) Token: 0x06004D95 RID: 19861 RVA: 0x000C0E70 File Offset: 0x000BF070
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

		// Token: 0x04002C78 RID: 11384
		private ISharingVehicleFeature Instance;
	}
}
