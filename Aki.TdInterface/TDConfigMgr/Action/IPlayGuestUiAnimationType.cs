using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D14 RID: 7444
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayGuestUiAnimationType
	{
		// Token: 0x06009FB3 RID: 40883 RVA: 0x0016CA80 File Offset: 0x0016AC80
		private IPlayGuestUiAnimationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayGuestUiAnimationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayGuestUiAnimationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayGuestUiAnimationType_SetValue());
			}
			return result;
		}

		// Token: 0x06009FB4 RID: 40884 RVA: 0x0016CAB8 File Offset: 0x0016ACB8
		public static IPlayGuestUiAnimationType Create([Nullable(2)] IPlayGuestUiAnimationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayGuestUiAnimationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FB5 RID: 40885 RVA: 0x0016CACB File Offset: 0x0016ACCB
		public static IPlayGuestUiAnimationType CreateFromSetValue([Nullable(2)] IPlayGuestUiAnimationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayGuestUiAnimationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FB6 RID: 40886 RVA: 0x0016CADE File Offset: 0x0016ACDE
		public IPlayGuestUiAnimationType_SetValue ToSetValue()
		{
			return new IPlayGuestUiAnimationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003192 RID: 12690
		// (get) Token: 0x06009FB7 RID: 40887 RVA: 0x0016CAF1 File Offset: 0x0016ACF1
		// (set) Token: 0x06009FB8 RID: 40888 RVA: 0x0016CB1C File Offset: 0x0016AD1C
		public virtual EGuestUiAnimationType Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGuestUiAnimationType.GuestCartethyia;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x04006059 RID: 24665
		[Nullable(2)]
		protected IPlayGuestUiAnimationType FbInstance;

		// Token: 0x0400605A RID: 24666
		[Nullable(2)]
		protected IPlayGuestUiAnimationType_SetValue PocoInterface;
	}
}
