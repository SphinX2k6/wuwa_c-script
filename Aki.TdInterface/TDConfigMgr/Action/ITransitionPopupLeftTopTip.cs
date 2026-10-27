using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE8 RID: 8168
	[NullableContext(2)]
	[Nullable(0)]
	public class ITransitionPopupLeftTopTip : ITransitionPopupStyle
	{
		// Token: 0x0600B3B0 RID: 46000 RVA: 0x001A2394 File Offset: 0x001A0594
		[NullableContext(1)]
		private ITransitionPopupLeftTopTip_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupLeftTopTip 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupLeftTopTip_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupLeftTopTip_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3B1 RID: 46001 RVA: 0x001A23CC File Offset: 0x001A05CC
		[NullableContext(1)]
		public static ITransitionPopupLeftTopTip Create([Nullable(2)] ITransitionPopupLeftTopTip instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupLeftTopTip
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3B2 RID: 46002 RVA: 0x001A23DF File Offset: 0x001A05DF
		[NullableContext(1)]
		public static ITransitionPopupLeftTopTip CreateFromSetValue([Nullable(2)] ITransitionPopupLeftTopTip_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupLeftTopTip
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3B3 RID: 46003 RVA: 0x001A23F2 File Offset: 0x001A05F2
		[NullableContext(1)]
		public new ITransitionPopupLeftTopTip_SetValue ToSetValue()
		{
			return new ITransitionPopupLeftTopTip_SetValue
			{
				Type = this.Type,
				TitleText = this.TitleText,
				ContentText = this.ContentText
			};
		}

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600B3B4 RID: 46004 RVA: 0x001A241D File Offset: 0x001A061D
		// (set) Token: 0x0600B3B5 RID: 46005 RVA: 0x001A2448 File Offset: 0x001A0648
		public override ETransitionPopupStyleType Type
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

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0600B3B6 RID: 46006 RVA: 0x001A2456 File Offset: 0x001A0656
		// (set) Token: 0x0600B3B7 RID: 46007 RVA: 0x001A247D File Offset: 0x001A067D
		public virtual string TitleText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TitleText;
				}
				ITransitionPopupLeftTopTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.TitleText;
			}
			set
			{
				this.GetOrCreatePoco().TitleText = value;
			}
		}

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0600B3B8 RID: 46008 RVA: 0x001A248B File Offset: 0x001A068B
		// (set) Token: 0x0600B3B9 RID: 46009 RVA: 0x001A24B2 File Offset: 0x001A06B2
		public virtual string ContentText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ContentText;
				}
				ITransitionPopupLeftTopTip_SetValue pocoInterface = this.PocoInterface;
				if (pocoInterface == null)
				{
					return null;
				}
				return pocoInterface.ContentText;
			}
			set
			{
				this.GetOrCreatePoco().ContentText = value;
			}
		}

		// Token: 0x04006C63 RID: 27747
		protected new ITransitionPopupLeftTopTip FbInstance;

		// Token: 0x04006C64 RID: 27748
		protected new ITransitionPopupLeftTopTip_SetValue PocoInterface;
	}
}
