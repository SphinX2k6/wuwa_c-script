using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CD3 RID: 3283
	public class IAddBuffMode
	{
		// Token: 0x06004B04 RID: 19204 RVA: 0x000BC79A File Offset: 0x000BA99A
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

		// Token: 0x17001559 RID: 5465
		// (get) Token: 0x06004B05 RID: 19205 RVA: 0x000BC7B9 File Offset: 0x000BA9B9
		public virtual EBuffProducerMode Type
		{
			get
			{
				return (EBuffProducerMode)this.Instance.Type;
			}
		}

		// Token: 0x04002A7A RID: 10874
		private IAddBuffMode Instance;
	}
}
