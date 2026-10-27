using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001E68 RID: 7784
	[NullableContext(2)]
	[Nullable(0)]
	public class IShowTalkOutline
	{
		// Token: 0x0600A69D RID: 42653 RVA: 0x00179014 File Offset: 0x00177214
		[NullableContext(1)]
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

		// Token: 0x0600A69E RID: 42654 RVA: 0x0017904C File Offset: 0x0017724C
		[NullableContext(1)]
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

		// Token: 0x0600A69F RID: 42655 RVA: 0x0017905F File Offset: 0x0017725F
		[NullableContext(1)]
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

		// Token: 0x0600A6A0 RID: 42656 RVA: 0x00179072 File Offset: 0x00177272
		[NullableContext(1)]
		public IShowTalkOutline_SetValue ToSetValue()
		{
			return new IShowTalkOutline_SetValue
			{
				TextId = this.TextId,
				TidOutline = this.TidOutline,
				PlotLineKey = this.PlotLineKey
			};
		}

		// Token: 0x17003309 RID: 13065
		// (get) Token: 0x0600A6A1 RID: 42657 RVA: 0x0017909D File Offset: 0x0017729D
		// (set) Token: 0x0600A6A2 RID: 42658 RVA: 0x001790C8 File Offset: 0x001772C8
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

		// Token: 0x1700330A RID: 13066
		// (get) Token: 0x0600A6A3 RID: 42659 RVA: 0x001790D6 File Offset: 0x001772D6
		// (set) Token: 0x0600A6A4 RID: 42660 RVA: 0x001790FD File Offset: 0x001772FD
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

		// Token: 0x1700330B RID: 13067
		// (get) Token: 0x0600A6A5 RID: 42661 RVA: 0x0017910B File Offset: 0x0017730B
		// (set) Token: 0x0600A6A6 RID: 42662 RVA: 0x00179132 File Offset: 0x00177332
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

		// Token: 0x04006384 RID: 25476
		protected IShowTalkOutline FbInstance;

		// Token: 0x04006385 RID: 25477
		protected IShowTalkOutline_SetValue PocoInterface;
	}
}
