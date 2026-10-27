using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE2 RID: 3298
	public class INpcModelConfig
	{
		// Token: 0x06004B58 RID: 19288 RVA: 0x000BC3A2 File Offset: 0x000BA5A2
		[NullableContext(1)]
		public static INpcModelConfig Create(INpcModelConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new INpcModelConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06004B59 RID: 19289 RVA: 0x000BC3C1 File Offset: 0x000BA5C1
		public virtual ENpcModelType Type
		{
			get
			{
				return (ENpcModelType)this.Instance.Type;
			}
		}

		// Token: 0x04002B19 RID: 11033
		private INpcModelConfig Instance;
	}
}
