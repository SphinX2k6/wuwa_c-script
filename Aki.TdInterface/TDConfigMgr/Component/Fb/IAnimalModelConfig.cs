using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE6 RID: 3302
	public class IAnimalModelConfig
	{
		// Token: 0x06004B6E RID: 19310 RVA: 0x000BC66F File Offset: 0x000BA86F
		[NullableContext(1)]
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

		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x06004B6F RID: 19311 RVA: 0x000BC68E File Offset: 0x000BA88E
		public virtual EAnimalModelType Type
		{
			get
			{
				return (EAnimalModelType)this.Instance.Type;
			}
		}

		// Token: 0x04002B23 RID: 11043
		private IAnimalModelConfig Instance;
	}
}
