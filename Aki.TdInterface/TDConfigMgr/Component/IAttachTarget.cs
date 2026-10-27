using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001CF RID: 463
	[NullableContext(1)]
	[Nullable(0)]
	public class IAttachTarget
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x00024ED8 File Offset: 0x000230D8
		private IAttachTarget_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAttachTarget 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAttachTarget_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAttachTarget_SetValue());
			}
			return result;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00024F10 File Offset: 0x00023110
		public static IAttachTarget Create([Nullable(2)] IAttachTarget instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttachTarget
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00024F23 File Offset: 0x00023123
		public static IAttachTarget CreateFromSetValue([Nullable(2)] IAttachTarget_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAttachTarget
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00024F36 File Offset: 0x00023136
		public IAttachTarget_SetValue ToSetValue()
		{
			return new IAttachTarget_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x00024F49 File Offset: 0x00023149
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x00024F74 File Offset: 0x00023174
		public virtual EAttachType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachType.Actor;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x040008A1 RID: 2209
		[Nullable(2)]
		protected IAttachTarget FbInstance;

		// Token: 0x040008A2 RID: 2210
		[Nullable(2)]
		protected IAttachTarget_SetValue PocoInterface;
	}
}
