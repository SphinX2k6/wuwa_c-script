using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232C RID: 9004
	public class Log : ActionParams
	{
		// Token: 0x0600C40A RID: 50186 RVA: 0x001C1EDC File Offset: 0x001C00DC
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

		// Token: 0x0600C40B RID: 50187 RVA: 0x001C1F14 File Offset: 0x001C0114
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

		// Token: 0x0600C40C RID: 50188 RVA: 0x001C1F27 File Offset: 0x001C0127
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

		// Token: 0x0600C40D RID: 50189 RVA: 0x001C1F3A File Offset: 0x001C013A
		public Log_SetValue ToSetValue()
		{
			return new Log_SetValue
			{
				Level = this.Level,
				Content = this.Content
			};
		}

		// Token: 0x17003B53 RID: 15187
		// (get) Token: 0x0600C40E RID: 50190 RVA: 0x001C1F59 File Offset: 0x001C0159
		// (set) Token: 0x0600C40F RID: 50191 RVA: 0x001C1F84 File Offset: 0x001C0184
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

		// Token: 0x17003B54 RID: 15188
		// (get) Token: 0x0600C410 RID: 50192 RVA: 0x001C1F92 File Offset: 0x001C0192
		// (set) Token: 0x0600C411 RID: 50193 RVA: 0x001C1FBD File Offset: 0x001C01BD
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

		// Token: 0x040074C2 RID: 29890
		[Nullable(2)]
		protected new Log FbInstance;

		// Token: 0x040074C3 RID: 29891
		[Nullable(2)]
		protected Log_SetValue PocoInterface;
	}
}
