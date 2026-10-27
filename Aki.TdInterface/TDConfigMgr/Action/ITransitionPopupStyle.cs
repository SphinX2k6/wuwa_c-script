using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FEA RID: 8170
	[NullableContext(1)]
	[Nullable(0)]
	public class ITransitionPopupStyle
	{
		// Token: 0x0600B3BC RID: 46012 RVA: 0x001A24D0 File Offset: 0x001A06D0
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

		// Token: 0x0600B3BD RID: 46013 RVA: 0x001A2508 File Offset: 0x001A0708
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

		// Token: 0x0600B3BE RID: 46014 RVA: 0x001A251B File Offset: 0x001A071B
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

		// Token: 0x0600B3BF RID: 46015 RVA: 0x001A252E File Offset: 0x001A072E
		public ITransitionPopupStyle_SetValue ToSetValue()
		{
			return new ITransitionPopupStyle_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0600B3C0 RID: 46016 RVA: 0x001A2541 File Offset: 0x001A0741
		// (set) Token: 0x0600B3C1 RID: 46017 RVA: 0x001A256C File Offset: 0x001A076C
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

		// Token: 0x04006C68 RID: 27752
		[Nullable(2)]
		protected ITransitionPopupStyle FbInstance;

		// Token: 0x04006C69 RID: 27753
		[Nullable(2)]
		protected ITransitionPopupStyle_SetValue PocoInterface;
	}
}
