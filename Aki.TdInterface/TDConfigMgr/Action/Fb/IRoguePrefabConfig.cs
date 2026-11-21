using System;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002C03 RID: 11267
	public class IRoguePrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600F820 RID: 63520 RVA: 0x002416AE File Offset: 0x0023F8AE
		public static IRoguePrefabConfig Create(IRoguePrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IRoguePrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004CC8 RID: 19656
		// (get) Token: 0x0600F821 RID: 63521 RVA: 0x002416CD File Offset: 0x0023F8CD
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004CC9 RID: 19657
		// (get) Token: 0x0600F822 RID: 63522 RVA: 0x002416DA File Offset: 0x0023F8DA
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x040087C7 RID: 34759
		private IRoguePrefabConfig Instance;
	}
}
