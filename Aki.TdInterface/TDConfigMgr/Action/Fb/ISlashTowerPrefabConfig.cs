using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C04 RID: 11268
	public class ISlashTowerPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600F824 RID: 63524 RVA: 0x002416EF File Offset: 0x0023F8EF
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

		// Token: 0x17004CCA RID: 19658
		// (get) Token: 0x0600F825 RID: 63525 RVA: 0x0024170E File Offset: 0x0023F90E
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004CCB RID: 19659
		// (get) Token: 0x0600F826 RID: 63526 RVA: 0x0024171B File Offset: 0x0023F91B
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x040087C8 RID: 34760
		private ISlashTowerPrefabConfig Instance;
	}
}
