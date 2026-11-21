using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020004A9 RID: 1193
	public class IImmediateAddBuff : IAddBuffMode
	{
		// Token: 0x060017F3 RID: 6131 RVA: 0x00048F3C File Offset: 0x0004713C
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

		// Token: 0x060017F4 RID: 6132 RVA: 0x00048F74 File Offset: 0x00047174
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

		// Token: 0x060017F5 RID: 6133 RVA: 0x00048F87 File Offset: 0x00047187
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

		// Token: 0x060017F6 RID: 6134 RVA: 0x00048F9A File Offset: 0x0004719A
		public new IImmediateAddBuff_SetValue ToSetValue()
		{
			return new IImmediateAddBuff_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000679 RID: 1657
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x00048FAD File Offset: 0x000471AD
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x00048FD8 File Offset: 0x000471D8
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

		// Token: 0x04001237 RID: 4663
		[Nullable(2)]
		protected new IImmediateAddBuff FbInstance;

		// Token: 0x04001238 RID: 4664
		[Nullable(2)]
		protected new IImmediateAddBuff_SetValue PocoInterface;
	}
}
