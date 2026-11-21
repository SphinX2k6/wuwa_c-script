using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C05 RID: 11269
	public class IRoleTowerPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600F828 RID: 63528 RVA: 0x00241730 File Offset: 0x0023F930
		public static IRoleTowerPrefabConfig Create(IRoleTowerPrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoleTowerPrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CCC RID: 19660
		// (get) Token: 0x0600F829 RID: 63529 RVA: 0x0024174F File Offset: 0x0023F94F
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x040087C9 RID: 34761
		private IRoleTowerPrefabConfig Instance;
	}
}
