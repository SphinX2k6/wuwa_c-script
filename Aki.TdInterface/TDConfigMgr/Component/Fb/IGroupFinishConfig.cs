using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000BA6 RID: 2982
	public class IGroupFinishConfig
	{
		// Token: 0x06004472 RID: 17522 RVA: 0x000ADD9D File Offset: 0x000ABF9D
		[NullableContext(1)]
		public static IGroupFinishConfig Create(IGroupFinishConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IGroupFinishConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170012E3 RID: 4835
		// (get) Token: 0x06004473 RID: 17523 RVA: 0x000ADDBC File Offset: 0x000ABFBC
		public virtual EGroupFinishConfig Type
		{
			get
			{
				return (EGroupFinishConfig)this.Instance.Type;
			}
		}

		// Token: 0x040026A5 RID: 9893
		private IGroupFinishConfig Instance;
	}
}
