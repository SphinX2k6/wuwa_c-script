using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004F4 RID: 1268
	[NullableContext(1)]
	[Nullable(0)]
	public class IMeshNpcModel : INpcModelConfig
	{
		// Token: 0x060019D4 RID: 6612 RVA: 0x0004C090 File Offset: 0x0004A290
		private IMeshNpcModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IMeshNpcModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IMeshNpcModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IMeshNpcModel_SetValue());
			}
			return result;
		}

		// Token: 0x060019D5 RID: 6613 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
		public static IMeshNpcModel Create([Nullable(2)] IMeshNpcModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IMeshNpcModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x060019D6 RID: 6614 RVA: 0x0004C0DB File Offset: 0x0004A2DB
		public static IMeshNpcModel CreateFromSetValue([Nullable(2)] IMeshNpcModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IMeshNpcModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x060019D7 RID: 6615 RVA: 0x0004C0EE File Offset: 0x0004A2EE
		public new IMeshNpcModel_SetValue ToSetValue()
		{
			return new IMeshNpcModel_SetValue
			{
				Type = this.Type,
				Mesh = this.Mesh
			};
		}

		// Token: 0x170006DB RID: 1755
		// (get) Token: 0x060019D8 RID: 6616 RVA: 0x0004C10D File Offset: 0x0004A30D
		// (set) Token: 0x060019D9 RID: 6617 RVA: 0x0004C138 File Offset: 0x0004A338
		public override ENpcModelType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ENpcModelType.Mesh;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x060019DA RID: 6618 RVA: 0x0004C146 File Offset: 0x0004A346
		// (set) Token: 0x060019DB RID: 6619 RVA: 0x0004C171 File Offset: 0x0004A371
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

		// Token: 0x040012E3 RID: 4835
		[Nullable(2)]
		protected new IMeshNpcModel FbInstance;

		// Token: 0x040012E4 RID: 4836
		[Nullable(2)]
		protected new IMeshNpcModel_SetValue PocoInterface;
	}
}
