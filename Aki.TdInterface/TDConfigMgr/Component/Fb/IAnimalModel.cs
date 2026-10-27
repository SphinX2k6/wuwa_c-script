using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000CE8 RID: 3304
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnimalModel : IModelConfig
	{
		// Token: 0x06004B75 RID: 19317 RVA: 0x000BC6E4 File Offset: 0x000BA8E4
		public static IAnimalModel Create(IAnimalModel? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnimalModel
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17001762 RID: 5986
		// (get) Token: 0x06004B76 RID: 19318 RVA: 0x000BC703 File Offset: 0x000BA903
		public override EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x17001763 RID: 5987
		// (get) Token: 0x06004B77 RID: 19319 RVA: 0x000BC710 File Offset: 0x000BA910
		public virtual string BlueprintPath
		{
			get
			{
				return this.Instance.BlueprintPath;
			}
		}

		// Token: 0x17001764 RID: 5988
		// (get) Token: 0x06004B78 RID: 19320 RVA: 0x000BC71D File Offset: 0x000BA91D
		[Nullable(2)]
		public virtual IMeshAnimalModel AnimalModel
		{
			[NullableContext(2)]
			get
			{
				if (this._AnimalModelInited)
				{
					return this._AnimalModelCache;
				}
				this._AnimalModelInited = true;
				this._AnimalModelCache = IMeshAnimalModel.Create(this.Instance.AnimalModel);
				return this._AnimalModelCache;
			}
		}

		// Token: 0x17001765 RID: 5989
		// (get) Token: 0x06004B79 RID: 19321 RVA: 0x000BC751 File Offset: 0x000BA951
		public virtual string Abp
		{
			get
			{
				return this.Instance.Abp;
			}
		}

		// Token: 0x04002B25 RID: 11045
		private IAnimalModel Instance;

		// Token: 0x04002B26 RID: 11046
		[Nullable(2)]
		private IMeshAnimalModel _AnimalModelCache;

		// Token: 0x04002B27 RID: 11047
		private bool _AnimalModelInited;
	}
}
