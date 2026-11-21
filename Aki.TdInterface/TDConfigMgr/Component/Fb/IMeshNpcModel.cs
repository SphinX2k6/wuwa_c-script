using System;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DDA RID: 3546
	public class IMeshNpcModel : INpcModelConfig
	{
		// Token: 0x06005063 RID: 20579 RVA: 0x000C77D2 File Offset: 0x000C59D2
		public static IMeshNpcModel Create(IMeshNpcModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMeshNpcModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x170018AA RID: 6314
		// (get) Token: 0x06005064 RID: 20580 RVA: 0x000C77F1 File Offset: 0x000C59F1
		public override ENpcModelType Type
		{
			get
			{
				return (ENpcModelType)this.Instance.Type;
			}
		}

		// Token: 0x170018AB RID: 6315
		// (get) Token: 0x06005065 RID: 20581 RVA: 0x000C77FE File Offset: 0x000C59FE
		public virtual string Mesh
		{
			get
			{
				return this.Instance.Mesh;
			}
		}

		// Token: 0x04002DCF RID: 11727
		private IMeshNpcModel Instance;
	}
}
