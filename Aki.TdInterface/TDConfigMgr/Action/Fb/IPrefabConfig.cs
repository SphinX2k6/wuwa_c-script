using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C00 RID: 11264
	public class IPrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600F814 RID: 63508 RVA: 0x002415EB File Offset: 0x0023F7EB
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

		// Token: 0x17004CC2 RID: 19650
		// (get) Token: 0x0600F815 RID: 63509 RVA: 0x0024160A File Offset: 0x0023F80A
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004CC3 RID: 19651
		// (get) Token: 0x0600F816 RID: 63510 RVA: 0x00241617 File Offset: 0x0023F817
		public virtual int PrefabId
		{
			get
			{
				return this.Instance.PrefabId;
			}
		}

		// Token: 0x040087C4 RID: 34756
		private IPrefabConfig Instance;
	}
}
