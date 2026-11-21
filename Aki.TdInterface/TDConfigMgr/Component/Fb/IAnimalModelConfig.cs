using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDE RID: 3550
	public class IAnimalModelConfig
	{
		// Token: 0x0600507B RID: 20603 RVA: 0x000C7B23 File Offset: 0x000C5D23
		public static IAnimalModelConfig Create(IAnimalModelConfig? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnimalModelConfig
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018BA RID: 6330
		// (get) Token: 0x0600507C RID: 20604 RVA: 0x000C7B42 File Offset: 0x000C5D42
		public virtual EAnimalModelType Type
		{
			get
			{
				return (EAnimalModelType)this.Instance.Type;
			}
		}

		// Token: 0x04002DDB RID: 11739
		private IAnimalModelConfig Instance;
	}
}
