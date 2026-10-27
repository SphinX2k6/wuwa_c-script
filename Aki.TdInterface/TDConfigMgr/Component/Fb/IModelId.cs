using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE1 RID: 3297
	public class IModelId : IModelConfig
	{
		// Token: 0x06004B54 RID: 19284 RVA: 0x000BC361 File Offset: 0x000BA561
		[NullableContext(1)]
		public static IModelId Create(IModelId? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IModelId
			{
				Instance = instance.Value
			};
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06004B55 RID: 19285 RVA: 0x000BC380 File Offset: 0x000BA580
		public override EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06004B56 RID: 19286 RVA: 0x000BC38D File Offset: 0x000BA58D
		public virtual int ModelId
		{
			get
			{
				return this.Instance.ModelId;
			}
		}

		// Token: 0x04002B18 RID: 11032
		private IModelId Instance;
	}
}
