using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001EA RID: 490
	public class IAnimalModel : IModelConfig
	{
		// Token: 0x06000794 RID: 1940 RVA: 0x00025CD0 File Offset: 0x00023ED0
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

		// Token: 0x06000795 RID: 1941 RVA: 0x00025D08 File Offset: 0x00023F08
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

		// Token: 0x06000796 RID: 1942 RVA: 0x00025D1B File Offset: 0x00023F1B
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

		// Token: 0x06000797 RID: 1943 RVA: 0x00025D2E File Offset: 0x00023F2E
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000798 RID: 1944 RVA: 0x00025D65 File Offset: 0x00023F65
		// (set) Token: 0x06000799 RID: 1945 RVA: 0x00025D90 File Offset: 0x00023F90
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x00025D9E File Offset: 0x00023F9E
		// (set) Token: 0x0600079B RID: 1947 RVA: 0x00025DC9 File Offset: 0x00023FC9
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x00025DD8 File Offset: 0x00023FD8
		// (set) Token: 0x0600079D RID: 1949 RVA: 0x00025E39 File Offset: 0x00024039
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

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x0600079E RID: 1950 RVA: 0x00025E4E File Offset: 0x0002404E
		// (set) Token: 0x0600079F RID: 1951 RVA: 0x00025E79 File Offset: 0x00024079
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

		// Token: 0x040008FF RID: 2303
		[Nullable(2)]
		protected new IAnimalModel FbInstance;

		// Token: 0x04000900 RID: 2304
		[Nullable(2)]
		protected new IAnimalModel_SetValue PocoInterface;

		// Token: 0x04000901 RID: 2305
		private IMeshAnimalModel _AnimalModelCache;

		// Token: 0x04000902 RID: 2306
		private bool _AnimalModelInited;
	}
}
