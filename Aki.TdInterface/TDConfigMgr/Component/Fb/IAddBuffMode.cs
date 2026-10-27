using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000C03 RID: 3075
	public class IAddBuffMode
	{
		// Token: 0x060046A1 RID: 18081 RVA: 0x000B25CE File Offset: 0x000B07CE
		[NullableContext(1)]
		public static IAddBuffMode Create(IAddBuffMode? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddBuffMode
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x060046A2 RID: 18082 RVA: 0x000B25ED File Offset: 0x000B07ED
		public virtual EBuffProducerMode Type
		{
			get
			{
				return (EBuffProducerMode)this.Instance.Type;
			}
		}

		// Token: 0x0400282E RID: 10286
		private IAddBuffMode Instance;
	}
}
