using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001FE6 RID: 8166
	[NullableContext(2)]
	[Nullable(0)]
	public class ITransitionPopupLeftBottomTransition : ITransitionPopupStyle
	{
		// Token: 0x0600B3A4 RID: 45988 RVA: 0x001A2258 File Offset: 0x001A0458
		[NullableContext(1)]
		private ITransitionPopupLeftBottomTransition_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("ITransitionPopupLeftBottomTransition 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			ITransitionPopupLeftBottomTransition_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new ITransitionPopupLeftBottomTransition_SetValue());
			}
			return result;
		}

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x001A2290 File Offset: 0x001A0490
		[NullableContext(1)]
		public static ITransitionPopupLeftBottomTransition Create([Nullable(2)] ITransitionPopupLeftBottomTransition instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new ITransitionPopupLeftBottomTransition
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x001A22A3 File Offset: 0x001A04A3
		[NullableContext(1)]
		public static ITransitionPopupLeftBottomTransition CreateFromSetValue([Nullable(2)] ITransitionPopupLeftBottomTransition_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new ITransitionPopupLeftBottomTransition
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B3A7 RID: 45991 RVA: 0x001A22B6 File Offset: 0x001A04B6
		[NullableContext(1)]
		public new ITransitionPopupLeftBottomTransition_SetValue ToSetValue()
		{
			return new ITransitionPopupLeftBottomTransition_SetValue
			{
				Type = this.Type,
				TitleText = this.TitleText,
				ContentText = this.ContentText
			};
		}

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600B3A8 RID: 45992 RVA: 0x001A22E1 File Offset: 0x001A04E1
		// (set) Token: 0x0600B3A9 RID: 45993 RVA: 0x001A230C File Offset: 0x001A050C
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

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600B3AA RID: 45994 RVA: 0x001A231A File Offset: 0x001A051A
		// (set) Token: 0x0600B3AB RID: 45995 RVA: 0x001A2341 File Offset: 0x001A0541
		public virtual string TitleText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.TitleText;
				}
				ITransitionPopupLeftBottomTransition_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600B3AC RID: 45996 RVA: 0x001A234F File Offset: 0x001A054F
		// (set) Token: 0x0600B3AD RID: 45997 RVA: 0x001A2376 File Offset: 0x001A0576
		public virtual string ContentText
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.ContentText;
				}
				ITransitionPopupLeftBottomTransition_SetValue pocoInterface = this.PocoInterface;
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

		// Token: 0x04006C5E RID: 27742
		protected new ITransitionPopupLeftBottomTransition FbInstance;

		// Token: 0x04006C5F RID: 27743
		protected new ITransitionPopupLeftBottomTransition_SetValue PocoInterface;
	}
}
