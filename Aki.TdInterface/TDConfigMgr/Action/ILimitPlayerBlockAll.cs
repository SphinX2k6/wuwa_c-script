using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D39 RID: 7481
	public class ILimitPlayerBlockAll : ILimitPlayerOption
	{
		// Token: 0x06009EE3 RID: 40675 RVA: 0x0016D3D8 File Offset: 0x0016B5D8
		private ILimitPlayerBlockAll_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ILimitPlayerBlockAll 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ILimitPlayerBlockAll_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ILimitPlayerBlockAll_SetValue());
			}
			return result;
		}

		// Token: 0x06009EE4 RID: 40676 RVA: 0x0016D410 File Offset: 0x0016B610
		public static ILimitPlayerBlockAll Create([Nullable(2)] ILimitPlayerBlockAll instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ILimitPlayerBlockAll
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009EE5 RID: 40677 RVA: 0x0016D423 File Offset: 0x0016B623
		public static ILimitPlayerBlockAll CreateFromSetValue([Nullable(2)] ILimitPlayerBlockAll_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ILimitPlayerBlockAll
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009EE6 RID: 40678 RVA: 0x0016D436 File Offset: 0x0016B636
		public new ILimitPlayerBlockAll_SetValue ToSetValue()
		{
			return new ILimitPlayerBlockAll_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170031AA RID: 12714
		// (get) Token: 0x06009EE7 RID: 40679 RVA: 0x0016D449 File Offset: 0x0016B649
		// (set) Token: 0x06009EE8 RID: 40680 RVA: 0x0016D474 File Offset: 0x0016B674
		public override ELimitPlayOperation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ELimitPlayOperation.AllowCamera;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040060D5 RID: 24789
		[Nullable(2)]
		protected new ILimitPlayerBlockAll FbInstance;

		// Token: 0x040060D6 RID: 24790
		[Nullable(2)]
		protected new ILimitPlayerBlockAll_SetValue PocoInterface;
	}
}
