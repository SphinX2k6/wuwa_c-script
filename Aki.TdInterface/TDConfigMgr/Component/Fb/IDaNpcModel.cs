using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDB RID: 3547
	public class IDaNpcModel : INpcModelConfig
	{
		// Token: 0x06005067 RID: 20583 RVA: 0x000C7813 File Offset: 0x000C5A13
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

		// Token: 0x170018AC RID: 6316
		// (get) Token: 0x06005068 RID: 20584 RVA: 0x000C7832 File Offset: 0x000C5A32
		public override ENpcModelType Type
		{
			get
			{
				return (ENpcModelType)this.Instance.Type;
			}
		}

		// Token: 0x170018AD RID: 6317
		// (get) Token: 0x06005069 RID: 20585 RVA: 0x000C783F File Offset: 0x000C5A3F
		public virtual string Da
		{
			get
			{
				return this.Instance.Da;
			}
		}

		// Token: 0x04002DD0 RID: 11728
		private IDaNpcModel Instance;
	}
}
