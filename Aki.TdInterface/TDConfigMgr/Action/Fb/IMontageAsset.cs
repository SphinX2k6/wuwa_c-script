using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002B5E RID: 11102
	public class IMontageAsset : IMontageConfig
	{
		// Token: 0x0600F412 RID: 62482 RVA: 0x00239A83 File Offset: 0x00237C83
		public static IMontageAsset Create(IMontageAsset? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMontageAsset
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004A04 RID: 18948
		// (get) Token: 0x0600F413 RID: 62483 RVA: 0x00239AA2 File Offset: 0x00237CA2
		public override EMontageConfigType Type
		{
			get
			{
				return (EMontageConfigType)this.Instance.Type;
			}
		}

		// Token: 0x17004A05 RID: 18949
		// (get) Token: 0x0600F414 RID: 62484 RVA: 0x00239AAF File Offset: 0x00237CAF
		public virtual string Asset
		{
			get
			{
				return this.Instance.Asset;
			}
		}

		// Token: 0x040085D8 RID: 34264
		private IMontageAsset Instance;
	}
}
