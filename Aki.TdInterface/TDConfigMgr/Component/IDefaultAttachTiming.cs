using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020002F6 RID: 758
	public class IDefaultAttachTiming : IAttachTiming
	{
		// Token: 0x06000E09 RID: 3593 RVA: 0x00033D68 File Offset: 0x00031F68
		private IDefaultAttachTiming_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IDefaultAttachTiming 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IDefaultAttachTiming_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IDefaultAttachTiming_SetValue());
			}
			return result;
		}

		// Token: 0x06000E0A RID: 3594 RVA: 0x00033DA0 File Offset: 0x00031FA0
		public static IDefaultAttachTiming Create([Nullable(2)] IDefaultAttachTiming instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IDefaultAttachTiming
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000E0B RID: 3595 RVA: 0x00033DB3 File Offset: 0x00031FB3
		public static IDefaultAttachTiming CreateFromSetValue([Nullable(2)] IDefaultAttachTiming_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IDefaultAttachTiming
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000E0C RID: 3596 RVA: 0x00033DC6 File Offset: 0x00031FC6
		public new IDefaultAttachTiming_SetValue ToSetValue()
		{
			return new IDefaultAttachTiming_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06000E0D RID: 3597 RVA: 0x00033DD9 File Offset: 0x00031FD9
		// (set) Token: 0x06000E0E RID: 3598 RVA: 0x00033E04 File Offset: 0x00032004
		public override EAttachTimingType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EAttachTimingType.Default;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04000CC4 RID: 3268
		[Nullable(2)]
		protected new IDefaultAttachTiming FbInstance;

		// Token: 0x04000CC5 RID: 3269
		[Nullable(2)]
		protected new IDefaultAttachTiming_SetValue PocoInterface;
	}
}
