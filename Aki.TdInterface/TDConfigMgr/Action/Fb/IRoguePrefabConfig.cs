using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002927 RID: 10535
	public class IRoguePrefabConfig : ICreatePrefabConfig
	{
		// Token: 0x0600E9CE RID: 59854 RVA: 0x00224356 File Offset: 0x00222556
		[NullableContext(1)]
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

		// Token: 0x17004942 RID: 18754
		// (get) Token: 0x0600E9CF RID: 59855 RVA: 0x00224375 File Offset: 0x00222575
		public override ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x17004943 RID: 18755
		// (get) Token: 0x0600E9D0 RID: 59856 RVA: 0x00224382 File Offset: 0x00222582
		public virtual int Index
		{
			get
			{
				return this.Instance.Index;
			}
		}

		// Token: 0x040080F9 RID: 33017
		private IRoguePrefabConfig Instance;
	}
}
