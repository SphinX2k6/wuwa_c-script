using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD3 RID: 3539
	public class IModelConfig
	{
		// Token: 0x06005045 RID: 20549 RVA: 0x000C74E9 File Offset: 0x000C56E9
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

		// Token: 0x1700189A RID: 6298
		// (get) Token: 0x06005046 RID: 20550 RVA: 0x000C7508 File Offset: 0x000C5708
		public virtual EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x04002DC2 RID: 11714
		private IModelConfig Instance;
	}
}
