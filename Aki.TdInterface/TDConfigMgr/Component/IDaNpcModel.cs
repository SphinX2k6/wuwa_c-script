using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002EE RID: 750
	public class IDaNpcModel : INpcModelConfig
	{
		// Token: 0x06000DDF RID: 3551 RVA: 0x00033928 File Offset: 0x00031B28
		private IDaNpcModel_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDaNpcModel 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDaNpcModel_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDaNpcModel_SetValue());
			}
			return result;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00033960 File Offset: 0x00031B60
		public static IDaNpcModel Create([Nullable(2)] IDaNpcModel instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDaNpcModel
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00033973 File Offset: 0x00031B73
		public static IDaNpcModel CreateFromSetValue([Nullable(2)] IDaNpcModel_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDaNpcModel
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00033986 File Offset: 0x00031B86
		public new IDaNpcModel_SetValue ToSetValue()
		{
			return new IDaNpcModel_SetValue
			{
				Type = this.Type,
				Da = this.Da
			};
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000DE3 RID: 3555 RVA: 0x000339A5 File Offset: 0x00031BA5
		// (set) Token: 0x06000DE4 RID: 3556 RVA: 0x000339D0 File Offset: 0x00031BD0
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

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x000339DE File Offset: 0x00031BDE
		// (set) Token: 0x06000DE6 RID: 3558 RVA: 0x00033A09 File Offset: 0x00031C09
		public virtual string Da
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Da;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Da;
			}
			set
			{
				this.GetOrCreatePoco().Da = value;
			}
		}

		// Token: 0x04000CB3 RID: 3251
		[Nullable(2)]
		protected new IDaNpcModel FbInstance;

		// Token: 0x04000CB4 RID: 3252
		[Nullable(2)]
		protected new IDaNpcModel_SetValue PocoInterface;
	}
}
