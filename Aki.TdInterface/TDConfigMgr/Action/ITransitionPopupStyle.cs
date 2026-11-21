using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002231 RID: 8753
	public class ITransitionPopupStyle
	{
		// Token: 0x0600BED2 RID: 48850 RVA: 0x001B8A3C File Offset: 0x001B6C3C
		private ITransitionPopupStyle_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupStyle 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupStyle_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupStyle_SetValue());
			}
			return result;
		}

		// Token: 0x0600BED3 RID: 48851 RVA: 0x001B8A74 File Offset: 0x001B6C74
		public static ITransitionPopupStyle Create([Nullable(2)] ITransitionPopupStyle instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupStyle
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600BED4 RID: 48852 RVA: 0x001B8A87 File Offset: 0x001B6C87
		public static ITransitionPopupStyle CreateFromSetValue([Nullable(2)] ITransitionPopupStyle_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupStyle
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600BED5 RID: 48853 RVA: 0x001B8A9A File Offset: 0x001B6C9A
		public ITransitionPopupStyle_SetValue ToSetValue()
		{
			return new ITransitionPopupStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003A2F RID: 14895
		// (get) Token: 0x0600BED6 RID: 48854 RVA: 0x001B8AAD File Offset: 0x001B6CAD
		// (set) Token: 0x0600BED7 RID: 48855 RVA: 0x001B8AD8 File Offset: 0x001B6CD8
		public virtual ETransitionPopupStyleType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return ETransitionPopupStyleType.LeftTopTip;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x0400726A RID: 29290
		[Nullable(2)]
		protected ITransitionPopupStyle FbInstance;

		// Token: 0x0400726B RID: 29291
		[Nullable(2)]
		protected ITransitionPopupStyle_SetValue PocoInterface;
	}
}
