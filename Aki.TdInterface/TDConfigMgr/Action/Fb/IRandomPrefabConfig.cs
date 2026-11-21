using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C01 RID: 11265
	public class IRandomPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600F818 RID: 63512 RVA: 0x0024162C File Offset: 0x0023F82C
		public static IRandomPrefabConfig Create(IRandomPrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRandomPrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CC4 RID: 19652
		// (get) Token: 0x0600F819 RID: 63513 RVA: 0x0024164B File Offset: 0x0023F84B
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004CC5 RID: 19653
		// (get) Token: 0x0600F81A RID: 63514 RVA: 0x00241658 File Offset: 0x0023F858
		public virtual int RandomPrefabId
		{
			get
			{
				return this.Instance.RandomPrefabId;
			}
		}

		// Token: 0x040087C5 RID: 34757
		private IRandomPrefabConfig Instance;
	}
}
