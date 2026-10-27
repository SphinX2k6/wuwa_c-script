using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CDC RID: 3292
	public class IModelConfig
	{
		// Token: 0x06004B3D RID: 19261 RVA: 0x000BC0EB File Offset: 0x000BA2EB
		[NullableContext(1)]
		public static IModelConfig Create(IModelConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModelConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06004B3E RID: 19262 RVA: 0x000BC10A File Offset: 0x000BA30A
		public virtual EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x04002B0D RID: 11021
		private IModelConfig Instance;
	}
}
