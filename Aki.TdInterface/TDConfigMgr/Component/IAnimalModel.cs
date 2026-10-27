using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001C7 RID: 455
	[NullableContext(1)]
	[Nullable(0)]
	public class IAnimalModel : IModelConfig
	{
		// Token: 0x06000740 RID: 1856 RVA: 0x000249CC File Offset: 0x00022BCC
		private IAnimalModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAnimalModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAnimalModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAnimalModel_SetValue());
			}
			return result;
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x00024A04 File Offset: 0x00022C04
		public static IAnimalModel Create([Nullable(2)] IAnimalModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAnimalModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00024A17 File Offset: 0x00022C17
		public static IAnimalModel CreateFromSetValue([Nullable(2)] IAnimalModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAnimalModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00024A2A File Offset: 0x00022C2A
		public new IAnimalModel_SetValue ToSetValue()
		{
			return new IAnimalModel_SetValue
			{
				Type = this.Type,
				BlueprintPath = this.BlueprintPath,
				AnimalModel = this.AnimalModel,
				Abp = this.Abp
			};
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00024A61 File Offset: 0x00022C61
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00024A8C File Offset: 0x00022C8C
		public override EModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EModelType.LevelPrefab;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x00024A9A File Offset: 0x00022C9A
		// (set) Token: 0x06000747 RID: 1863 RVA: 0x00024AC5 File Offset: 0x00022CC5
		public virtual string BlueprintPath
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.BlueprintPath;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.BlueprintPath;
			}
			set
			{
				this.GetOrCreatePoco().BlueprintPath = value;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00024AD4 File Offset: 0x00022CD4
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00024B35 File Offset: 0x00022D35
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
				if (this.FbInstance != null)
				{
					this._AnimalModelCache = IMeshAnimalModel.Create(this.FbInstance.AnimalModel);
				}
				else
				{
					IAnimalModel_SetValue pocoInterface = this.PocoInterface;
					this._AnimalModelCache = ((pocoInterface != null) ? pocoInterface.AnimalModel : null);
				}
				return this._AnimalModelCache;
			}
			[NullableContext(2)]
			set
			{
				this.GetOrCreatePoco().AnimalModel = value;
				this._AnimalModelInited = false;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x0600074A RID: 1866 RVA: 0x00024B4A File Offset: 0x00022D4A
		// (set) Token: 0x0600074B RID: 1867 RVA: 0x00024B75 File Offset: 0x00022D75
		public virtual string Abp
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Abp;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Abp;
			}
			set
			{
				this.GetOrCreatePoco().Abp = value;
			}
		}

		// Token: 0x0400088B RID: 2187
		[Nullable(2)]
		protected new IAnimalModel FbInstance;

		// Token: 0x0400088C RID: 2188
		[Nullable(2)]
		protected new IAnimalModel_SetValue PocoInterface;

		// Token: 0x0400088D RID: 2189
		private IMeshAnimalModel _AnimalModelCache;

		// Token: 0x0400088E RID: 2190
		private bool _AnimalModelInited;
	}
}
