using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200205B RID: 8283
	[NullableContext(1)]
	[Nullable(0)]
	public class IVisualNovelBackgroundClean : IVisualNovelBackgroundBase
	{
		// Token: 0x0600B600 RID: 46592 RVA: 0x001A6384 File Offset: 0x001A4584
		private IVisualNovelBackgroundClean_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IVisualNovelBackgroundClean 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IVisualNovelBackgroundClean_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IVisualNovelBackgroundClean_SetValue());
			}
			return result;
		}

		// Token: 0x0600B601 RID: 46593 RVA: 0x001A63BC File Offset: 0x001A45BC
		public static IVisualNovelBackgroundClean Create([Nullable(2)] IVisualNovelBackgroundClean instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundClean
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B602 RID: 46594 RVA: 0x001A63CF File Offset: 0x001A45CF
		public static IVisualNovelBackgroundClean CreateFromSetValue([Nullable(2)] IVisualNovelBackgroundClean_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IVisualNovelBackgroundClean
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B603 RID: 46595 RVA: 0x001A63E2 File Offset: 0x001A45E2
		public new IVisualNovelBackgroundClean_SetValue ToSetValue()
		{
			return new IVisualNovelBackgroundClean_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600B604 RID: 46596 RVA: 0x001A63F5 File Offset: 0x001A45F5
		// (set) Token: 0x0600B605 RID: 46597 RVA: 0x001A6420 File Offset: 0x001A4620
		public override EVisualNovelBackgroundType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EVisualNovelBackgroundType.Load;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006D67 RID: 28007
		[Nullable(2)]
		protected new IVisualNovelBackgroundClean FbInstance;

		// Token: 0x04006D68 RID: 28008
		[Nullable(2)]
		protected new IVisualNovelBackgroundClean_SetValue PocoInterface;
	}
}
