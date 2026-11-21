using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020FA RID: 8442
	public class IStopGuestUiAnimationType
	{
		// Token: 0x0600B35E RID: 45918 RVA: 0x001928A8 File Offset: 0x00190AA8
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

		// Token: 0x0600B35F RID: 45919 RVA: 0x001928E0 File Offset: 0x00190AE0
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

		// Token: 0x0600B360 RID: 45920 RVA: 0x001928F3 File Offset: 0x00190AF3
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

		// Token: 0x0600B361 RID: 45921 RVA: 0x00192906 File Offset: 0x00190B06
		public IStopGuestUiAnimationType_SetValue ToSetValue()
		{
			return new IStopGuestUiAnimationType_SetValue
			{
				Type = this.Type
			};
		}

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600B362 RID: 45922 RVA: 0x00192919 File Offset: 0x00190B19
		// (set) Token: 0x0600B363 RID: 45923 RVA: 0x00192944 File Offset: 0x00190B44
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

		// Token: 0x04006A58 RID: 27224
		[Nullable(2)]
		protected IStopGuestUiAnimationType FbInstance;

		// Token: 0x04006A59 RID: 27225
		[Nullable(2)]
		protected IStopGuestUiAnimationType_SetValue PocoInterface;
	}
}
