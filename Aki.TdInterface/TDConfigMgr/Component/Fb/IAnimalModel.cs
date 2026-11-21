using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Component;

namespace Aki.TDConfigMgr.Component.Fb
{
	// Token: 0x02000DE0 RID: 3552
	public class IAnimalModel : IModelConfig
	{
		// Token: 0x06005082 RID: 20610 RVA: 0x000C7B98 File Offset: 0x000C5D98
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

		// Token: 0x170018BD RID: 6333
		// (get) Token: 0x06005083 RID: 20611 RVA: 0x000C7BB7 File Offset: 0x000C5DB7
		public override EModelType Type
		{
			get
			{
				return (EModelType)this.Instance.Type;
			}
		}

		// Token: 0x170018BE RID: 6334
		// (get) Token: 0x06005084 RID: 20612 RVA: 0x000C7BC4 File Offset: 0x000C5DC4
		public virtual string BlueprintPath
		{
			get
			{
				return this.Instance.BlueprintPath;
			}
		}

		// Token: 0x170018BF RID: 6335
		// (get) Token: 0x06005085 RID: 20613 RVA: 0x000C7BD1 File Offset: 0x000C5DD1
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

		// Token: 0x170018C0 RID: 6336
		// (get) Token: 0x06005086 RID: 20614 RVA: 0x000C7C05 File Offset: 0x000C5E05
		public virtual string Abp
		{
			get
			{
				return this.Instance.Abp;
			}
		}

		// Token: 0x04002DDD RID: 11741
		private IAnimalModel Instance;

		// Token: 0x04002DDE RID: 11742
		[Nullable(2)]
		private IMeshAnimalModel _AnimalModelCache;

		// Token: 0x04002DDF RID: 11743
		private bool _AnimalModelInited;
	}
}
