using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE4 RID: 3300
	[NullableContext(1)]
	[Nullable(0)]
	public class IDaNpcModel : INpcModelConfig
	{
		// Token: 0x06004B5F RID: 19295 RVA: 0x000BC417 File Offset: 0x000BA617
		public static IDaNpcModel Create(IDaNpcModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaNpcModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x06004B60 RID: 19296 RVA: 0x000BC436 File Offset: 0x000BA636
		public override ENpcModelType Type
		{
			get
			{
				return (ENpcModelType)this.Instance.Type;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x06004B61 RID: 19297 RVA: 0x000BC443 File Offset: 0x000BA643
		public virtual string Da
		{
			get
			{
				return this.Instance.Da;
			}
		}

		// Token: 0x04002B1B RID: 11035
		private IDaNpcModel Instance;
	}
}
