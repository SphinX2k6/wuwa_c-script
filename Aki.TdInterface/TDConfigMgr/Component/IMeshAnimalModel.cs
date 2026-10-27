using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F2 RID: 1266
	[NullableContext(1)]
	[Nullable(0)]
	public class IMeshAnimalModel : IAnimalModelConfig
	{
		// Token: 0x060019CA RID: 6602 RVA: 0x0004BF90 File Offset: 0x0004A190
		private IMeshAnimalModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMeshAnimalModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMeshAnimalModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMeshAnimalModel_SetValue());
			}
			return result;
		}

		// Token: 0x060019CB RID: 6603 RVA: 0x0004BFC8 File Offset: 0x0004A1C8
		public static IMeshAnimalModel Create([Nullable(2)] IMeshAnimalModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMeshAnimalModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019CC RID: 6604 RVA: 0x0004BFDB File Offset: 0x0004A1DB
		public static IMeshAnimalModel CreateFromSetValue([Nullable(2)] IMeshAnimalModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMeshAnimalModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0004BFEE File Offset: 0x0004A1EE
		public new IMeshAnimalModel_SetValue ToSetValue()
		{
			return new IMeshAnimalModel_SetValue
			{
				Type = this.Type,
				Mesh = this.Mesh
			};
		}

		// Token: 0x170006D9 RID: 1753
		// (get) Token: 0x060019CE RID: 6606 RVA: 0x0004C00D File Offset: 0x0004A20D
		// (set) Token: 0x060019CF RID: 6607 RVA: 0x0004C038 File Offset: 0x0004A238
		public override EAnimalModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAnimalModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006DA RID: 1754
		// (get) Token: 0x060019D0 RID: 6608 RVA: 0x0004C046 File Offset: 0x0004A246
		// (set) Token: 0x060019D1 RID: 6609 RVA: 0x0004C071 File Offset: 0x0004A271
		public virtual string Mesh
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Mesh;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Mesh;
			}
			set
			{
				this.GetOrCreatePoco().Mesh = value;
			}
		}

		// Token: 0x040012DF RID: 4831
		[Nullable(2)]
		protected new IMeshAnimalModel FbInstance;

		// Token: 0x040012E0 RID: 4832
		[Nullable(2)]
		protected new IMeshAnimalModel_SetValue PocoInterface;
	}
}
