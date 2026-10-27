using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020CF RID: 8399
	[NullableContext(1)]
	[Nullable(0)]
	public class Log : ActionParams
	{
		// Token: 0x0600B892 RID: 47250 RVA: 0x001AAFB4 File Offset: 0x001A91B4
		private Log_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("Log 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			Log_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new Log_SetValue());
			}
			return result;
		}

		// Token: 0x0600B893 RID: 47251 RVA: 0x001AAFEC File Offset: 0x001A91EC
		public static Log Create([Nullable(2)] Log instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new Log
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B894 RID: 47252 RVA: 0x001AAFFF File Offset: 0x001A91FF
		public static Log CreateFromSetValue([Nullable(2)] Log_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new Log
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B895 RID: 47253 RVA: 0x001AB012 File Offset: 0x001A9212
		public Log_SetValue ToSetValue()
		{
			return new Log_SetValue
			{
				Level = this.Level,
				Content = this.Content
			};
		}

		// Token: 0x1700386B RID: 14443
		// (get) Token: 0x0600B896 RID: 47254 RVA: 0x001AB031 File Offset: 0x001A9231
		// (set) Token: 0x0600B897 RID: 47255 RVA: 0x001AB05C File Offset: 0x001A925C
		public virtual string Level
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Level;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Level;
			}
			set
			{
				this.GetOrCreatePoco().Level = value;
			}
		}

		// Token: 0x1700386C RID: 14444
		// (get) Token: 0x0600B898 RID: 47256 RVA: 0x001AB06A File Offset: 0x001A926A
		// (set) Token: 0x0600B899 RID: 47257 RVA: 0x001AB095 File Offset: 0x001A9295
		public virtual string Content
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Content;
				}
				if (this.PocoInterface == null)
				{
					return null;
				}
				return this.PocoInterface.Content;
			}
			set
			{
				this.GetOrCreatePoco().Content = value;
			}
		}

		// Token: 0x04006E98 RID: 28312
		[Nullable(2)]
		protected new Log FbInstance;

		// Token: 0x04006E99 RID: 28313
		[Nullable(2)]
		protected Log_SetValue PocoInterface;
	}
}
