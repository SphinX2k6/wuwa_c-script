using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001A7 RID: 423
	[NullableContext(1)]
	[Nullable(0)]
	public class IAddBuffMode
	{
		// Token: 0x06000678 RID: 1656 RVA: 0x00023038 File Offset: 0x00021238
		private IAddBuffMode_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAddBuffMode 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAddBuffMode_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAddBuffMode_SetValue());
			}
			return result;
		}

		// Token: 0x06000679 RID: 1657 RVA: 0x00023070 File Offset: 0x00021270
		public static IAddBuffMode Create([Nullable(2)] IAddBuffMode instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAddBuffMode
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x00023083 File Offset: 0x00021283
		public static IAddBuffMode CreateFromSetValue([Nullable(2)] IAddBuffMode_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAddBuffMode
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x00023096 File Offset: 0x00021296
		public IAddBuffMode_SetValue ToSetValue()
		{
			return new IAddBuffMode_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x0600067C RID: 1660 RVA: 0x000230A9 File Offset: 0x000212A9
		// (set) Token: 0x0600067D RID: 1661 RVA: 0x000230D4 File Offset: 0x000212D4
		public virtual EBuffProducerMode Type
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

		// Token: 0x0400081B RID: 2075
		[Nullable(2)]
		protected IAddBuffMode FbInstance;

		// Token: 0x0400081C RID: 2076
		[Nullable(2)]
		protected IAddBuffMode_SetValue PocoInterface;
	}
}
