using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DD9 RID: 3545
	public class INpcModelConfig
	{
		// Token: 0x06005060 RID: 20576 RVA: 0x000C779E File Offset: 0x000C599E
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

		// Token: 0x170018A9 RID: 6313
		// (get) Token: 0x06005061 RID: 20577 RVA: 0x000C77BD File Offset: 0x000C59BD
		public virtual ENpcModelType Type
		{
			get
			{
				return (ENpcModelType)this.Instance.Type;
			}
		}

		// Token: 0x04002DCE RID: 11726
		private INpcModelConfig Instance;
	}
}
