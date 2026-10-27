using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE3 RID: 3299
	[NullableContext(1)]
	[Nullable(0)]
	public class IMeshNpcModel : INpcModelConfig
	{
		// Token: 0x06004B5B RID: 19291 RVA: 0x000BC3D6 File Offset: 0x000BA5D6
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

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06004B5C RID: 19292 RVA: 0x000BC3F5 File Offset: 0x000BA5F5
		public override ENpcModelType Type
		{
			get
			{
				return (ENpcModelType)this.Instance.Type;
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x06004B5D RID: 19293 RVA: 0x000BC402 File Offset: 0x000BA602
		public virtual string Mesh
		{
			get
			{
				return this.Instance.Mesh;
			}
		}

		// Token: 0x04002B1A RID: 11034
		private IMeshNpcModel Instance;
	}
}
