using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000450 RID: 1104
	[NullableContext(1)]
	[Nullable(0)]
	public class IImmediateAddBuff : IAddBuffMode
	{
		// Token: 0x06001659 RID: 5721 RVA: 0x000451F4 File Offset: 0x000433F4
		private IImmediateAddBuff_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IImmediateAddBuff 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IImmediateAddBuff_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IImmediateAddBuff_SetValue());
			}
			return result;
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x0004522C File Offset: 0x0004342C
		public static IImmediateAddBuff Create([Nullable(2)] IImmediateAddBuff instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IImmediateAddBuff
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x0004523F File Offset: 0x0004343F
		public static IImmediateAddBuff CreateFromSetValue([Nullable(2)] IImmediateAddBuff_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IImmediateAddBuff
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600165C RID: 5724 RVA: 0x00045252 File Offset: 0x00043452
		public new IImmediateAddBuff_SetValue ToSetValue()
		{
			return new IImmediateAddBuff_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000612 RID: 1554
		// (get) Token: 0x0600165D RID: 5725 RVA: 0x00045265 File Offset: 0x00043465
		// (set) Token: 0x0600165E RID: 5726 RVA: 0x00045290 File Offset: 0x00043490
		public override EBuffProducerMode Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EBuffProducerMode.Immediate;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04001115 RID: 4373
		[Nullable(2)]
		protected new IImmediateAddBuff FbInstance;

		// Token: 0x04001116 RID: 4374
		[Nullable(2)]
		protected new IImmediateAddBuff_SetValue PocoInterface;
	}
}
