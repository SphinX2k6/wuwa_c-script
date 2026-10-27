using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE7 RID: 3303
	[NullableContext(1)]
	[Nullable(0)]
	public class IMeshAnimalModel : IAnimalModelConfig
	{
		// Token: 0x06004B71 RID: 19313 RVA: 0x000BC6A3 File Offset: 0x000BA8A3
		public static IMeshAnimalModel Create(IMeshAnimalModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMeshAnimalModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001760 RID: 5984
		// (get) Token: 0x06004B72 RID: 19314 RVA: 0x000BC6C2 File Offset: 0x000BA8C2
		public override EAnimalModelType Type
		{
			get
			{
				return (EAnimalModelType)this.Instance.Type;
			}
		}

		// Token: 0x17001761 RID: 5985
		// (get) Token: 0x06004B73 RID: 19315 RVA: 0x000BC6CF File Offset: 0x000BA8CF
		public virtual string Mesh
		{
			get
			{
				return this.Instance.Mesh;
			}
		}

		// Token: 0x04002B24 RID: 11044
		private IMeshAnimalModel Instance;
	}
}
