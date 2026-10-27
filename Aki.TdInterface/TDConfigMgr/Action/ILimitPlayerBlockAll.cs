using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001B8C RID: 7052
	[NullableContext(1)]
	[Nullable(0)]
	public class ILimitPlayerBlockAll : ILimitPlayerOption
	{
		// Token: 0x06009701 RID: 38657 RVA: 0x0015C82C File Offset: 0x0015AA2C
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

		// Token: 0x06009702 RID: 38658 RVA: 0x0015C864 File Offset: 0x0015AA64
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

		// Token: 0x06009703 RID: 38659 RVA: 0x0015C877 File Offset: 0x0015AA77
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

		// Token: 0x06009704 RID: 38660 RVA: 0x0015C88A File Offset: 0x0015AA8A
		public new ILimitPlayerBlockAll_SetValue ToSetValue()
		{
			return new ILimitPlayerBlockAll_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17002F85 RID: 12165
		// (get) Token: 0x06009705 RID: 38661 RVA: 0x0015C89D File Offset: 0x0015AA9D
		// (set) Token: 0x06009706 RID: 38662 RVA: 0x0015C8C8 File Offset: 0x0015AAC8
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

		// Token: 0x04005C3C RID: 23612
		[Nullable(2)]
		protected new ILimitPlayerBlockAll FbInstance;

		// Token: 0x04005C3D RID: 23613
		[Nullable(2)]
		protected new ILimitPlayerBlockAll_SetValue PocoInterface;
	}
}
