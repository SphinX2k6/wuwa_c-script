using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200209D RID: 8349
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowTalkOutline
	{
		// Token: 0x0600B155 RID: 45397 RVA: 0x0018ED14 File Offset: 0x0018CF14
		[NullableContext(0)]
		private IShowTalkOutline_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IShowTalkOutline 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IShowTalkOutline_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IShowTalkOutline_SetValue());
			}
			return result;
		}

		// Token: 0x0600B156 RID: 45398 RVA: 0x0018ED4C File Offset: 0x0018CF4C
		[NullableContext(0)]
		public static IShowTalkOutline Create([Nullable(2)] IShowTalkOutline instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IShowTalkOutline
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B157 RID: 45399 RVA: 0x0018ED5F File Offset: 0x0018CF5F
		[NullableContext(0)]
		public static IShowTalkOutline CreateFromSetValue([Nullable(2)] IShowTalkOutline_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IShowTalkOutline
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B158 RID: 45400 RVA: 0x0018ED72 File Offset: 0x0018CF72
		[NullableContext(0)]
		public IShowTalkOutline_SetValue ToSetValue()
		{
			return new IShowTalkOutline_SetValue
			{
				TextId = this.TextId,
				TidOutline = this.TidOutline,
				PlotLineKey = this.PlotLineKey
			};
		}

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0600B159 RID: 45401 RVA: 0x0018ED9D File Offset: 0x0018CF9D
		// (set) Token: 0x0600B15A RID: 45402 RVA: 0x0018EDC8 File Offset: 0x0018CFC8
		public virtual int TextId
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TextId;
				}
				if (this.PocoInterface == null)
				{
					return 0;
				}
				return this.PocoInterface.TextId;
			}
			set
			{
				this.GetOrCreatePoco().TextId = value;
			}
		}

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0600B15B RID: 45403 RVA: 0x0018EDD6 File Offset: 0x0018CFD6
		// (set) Token: 0x0600B15C RID: 45404 RVA: 0x0018EDFD File Offset: 0x0018CFFD
		public virtual string TidOutline
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TidOutline;
				}
				IShowTalkOutline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TidOutline;
			}
			set
			{
				this.GetOrCreatePoco().TidOutline = value;
			}
		}

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0600B15D RID: 45405 RVA: 0x0018EE0B File Offset: 0x0018D00B
		// (set) Token: 0x0600B15E RID: 45406 RVA: 0x0018EE32 File Offset: 0x0018D032
		public virtual string PlotLineKey
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.PlotLineKey;
				}
				IShowTalkOutline_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.PlotLineKey;
			}
			set
			{
				this.GetOrCreatePoco().PlotLineKey = value;
			}
		}

		// Token: 0x04006968 RID: 26984
		protected IShowTalkOutline FbInstance;

		// Token: 0x04006969 RID: 26985
		protected IShowTalkOutline_SetValue PocoInterface;
	}
}
