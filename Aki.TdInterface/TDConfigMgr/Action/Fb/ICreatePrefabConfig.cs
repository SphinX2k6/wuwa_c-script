using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002923 RID: 10531
	public class ICreatePrefabConfig
	{
		// Token: 0x0600E9BF RID: 59839 RVA: 0x0022425F File Offset: 0x0022245F
		[NullableContext(1)]
		public static ICreatePrefabConfig Create(ICreatePrefabConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ICreatePrefabConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700493B RID: 18747
		// (get) Token: 0x0600E9C0 RID: 59840 RVA: 0x0022427E File Offset: 0x0022247E
		public virtual ECreatePrefabType Type
		{
			get
			{
				return (ECreatePrefabType)this.Instance.Type;
			}
		}

		// Token: 0x040080F5 RID: 33013
		private ICreatePrefabConfig Instance;
	}
}
