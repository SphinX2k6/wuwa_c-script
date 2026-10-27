using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002928 RID: 10536
	public class ISlashTowerPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600E9D2 RID: 59858 RVA: 0x00224397 File Offset: 0x00222597
		[NullableContext(1)]
		public static ISlashTowerPrefabConfig Create(ISlashTowerPrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ISlashTowerPrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004944 RID: 18756
		// (get) Token: 0x0600E9D3 RID: 59859 RVA: 0x002243B6 File Offset: 0x002225B6
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004945 RID: 18757
		// (get) Token: 0x0600E9D4 RID: 59860 RVA: 0x002243C3 File Offset: 0x002225C3
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x040080FA RID: 33018
		private ISlashTowerPrefabConfig Instance;
	}
}
