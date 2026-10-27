using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002925 RID: 10533
	public class IRandomPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600E9C6 RID: 59846 RVA: 0x002242D4 File Offset: 0x002224D4
		[NullableContext(1)]
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

		// Token: 0x1700493E RID: 18750
		// (get) Token: 0x0600E9C7 RID: 59847 RVA: 0x002242F3 File Offset: 0x002224F3
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x1700493F RID: 18751
		// (get) Token: 0x0600E9C8 RID: 59848 RVA: 0x00224300 File Offset: 0x00222500
		public virtual int RandomPrefabId
		{
			get
			{
				return this.Instance.RandomPrefabId;
			}
		}

		// Token: 0x040080F7 RID: 33015
		private IRandomPrefabConfig Instance;
	}
}
