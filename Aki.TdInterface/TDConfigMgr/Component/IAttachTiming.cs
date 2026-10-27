using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Component.Fb;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020001D1 RID: 465
	[NullableContext(1)]
	[Nullable(0)]
	public class IAttachTiming
	{
		// Token: 0x06000774 RID: 1908 RVA: 0x00024F94 File Offset: 0x00023194
		private IAttachTiming_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IAttachTiming 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IAttachTiming_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IAttachTiming_SetValue());
			}
			return result;
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x00024FCC File Offset: 0x000231CC
		public static IAttachTiming Create([Nullable(2)] IAttachTiming instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IAttachTiming
			{
				FbInstance = instance
			};
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x00024FDF File Offset: 0x000231DF
		public static IAttachTiming CreateFromSetValue([Nullable(2)] IAttachTiming_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IAttachTiming
			{
				PocoInterface = value
			};
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x00024FF2 File Offset: 0x000231F2
		public IAttachTiming_SetValue ToSetValue()
		{
			return new IAttachTiming_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x00025005 File Offset: 0x00023205
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x00025030 File Offset: 0x00023230
		public virtual EAttachTimingType Type
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

		// Token: 0x040008A4 RID: 2212
		[Nullable(2)]
		protected IAttachTiming FbInstance;

		// Token: 0x040008A5 RID: 2213
		[Nullable(2)]
		protected IAttachTiming_SetValue PocoInterface;
	}
}
