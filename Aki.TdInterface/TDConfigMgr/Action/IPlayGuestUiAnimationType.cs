using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F25 RID: 7973
	public class IPlayGuestUiAnimationType
	{
		// Token: 0x0600A99F RID: 43423 RVA: 0x00180EA4 File Offset: 0x0017F0A4
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

		// Token: 0x0600A9A0 RID: 43424 RVA: 0x00180EDC File Offset: 0x0017F0DC
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

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x00180EEF File Offset: 0x0017F0EF
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

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x00180F02 File Offset: 0x0017F102
		public IPlayGuestUiAnimationType_SetValue ToSetValue()
		{
			return new IPlayGuestUiAnimationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003426 RID: 13350
		// (get) Token: 0x0600A9A3 RID: 43427 RVA: 0x00180F15 File Offset: 0x0017F115
		// (set) Token: 0x0600A9A4 RID: 43428 RVA: 0x00180F40 File Offset: 0x0017F140
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

		// Token: 0x040065D5 RID: 26069
		[Nullable(2)]
		protected IPlayGuestUiAnimationType FbInstance;

		// Token: 0x040065D6 RID: 26070
		[Nullable(2)]
		protected IPlayGuestUiAnimationType_SetValue PocoInterface;
	}
}
