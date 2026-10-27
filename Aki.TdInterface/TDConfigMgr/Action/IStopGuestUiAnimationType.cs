using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001EC1 RID: 7873
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopGuestUiAnimationType
	{
		// Token: 0x0600A88C RID: 43148 RVA: 0x0017C8B0 File Offset: 0x0017AAB0
		private IStopGuestUiAnimationType_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopGuestUiAnimationType 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopGuestUiAnimationType_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopGuestUiAnimationType_SetValue());
			}
			return result;
		}

		// Token: 0x0600A88D RID: 43149 RVA: 0x0017C8E8 File Offset: 0x0017AAE8
		public static IStopGuestUiAnimationType Create([Nullable(2)] IStopGuestUiAnimationType instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopGuestUiAnimationType
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600A88E RID: 43150 RVA: 0x0017C8FB File Offset: 0x0017AAFB
		public static IStopGuestUiAnimationType CreateFromSetValue([Nullable(2)] IStopGuestUiAnimationType_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopGuestUiAnimationType
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600A88F RID: 43151 RVA: 0x0017C90E File Offset: 0x0017AB0E
		public IStopGuestUiAnimationType_SetValue ToSetValue()
		{
			return new IStopGuestUiAnimationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x1700337C RID: 13180
		// (get) Token: 0x0600A890 RID: 43152 RVA: 0x0017C921 File Offset: 0x0017AB21
		// (set) Token: 0x0600A891 RID: 43153 RVA: 0x0017C94C File Offset: 0x0017AB4C
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

		// Token: 0x04006469 RID: 25705
		[Nullable(2)]
		protected IStopGuestUiAnimationType FbInstance;

		// Token: 0x0400646A RID: 25706
		[Nullable(2)]
		protected IStopGuestUiAnimationType_SetValue PocoInterface;
	}
}
