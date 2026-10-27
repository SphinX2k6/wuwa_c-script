using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002924 RID: 10532
	public class IPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600E9C2 RID: 59842 RVA: 0x00224293 File Offset: 0x00222493
		[NullableContext(1)]
		public static IPrefabConfig Create(IPrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700493C RID: 18748
		// (get) Token: 0x0600E9C3 RID: 59843 RVA: 0x002242B2 File Offset: 0x002224B2
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x1700493D RID: 18749
		// (get) Token: 0x0600E9C4 RID: 59844 RVA: 0x002242BF File Offset: 0x002224BF
		public virtual int PrefabId
		{
			get
			{
				return this.Instance.PrefabId;
			}
		}

		// Token: 0x040080F6 RID: 33014
		private IPrefabConfig Instance;
	}
}
