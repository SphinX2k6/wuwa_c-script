using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001D12 RID: 7442
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayGuestUiAnimation : IGuestOperateUiAnimationType
	{
		// Token: 0x06009FA9 RID: 40873 RVA: 0x0016C940 File Offset: 0x0016AB40
		private IPlayGuestUiAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IPlayGuestUiAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IPlayGuestUiAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IPlayGuestUiAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x0016C978 File Offset: 0x0016AB78
		public static IPlayGuestUiAnimation Create([Nullable(2)] IPlayGuestUiAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayGuestUiAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x06009FAB RID: 40875 RVA: 0x0016C98B File Offset: 0x0016AB8B
		public static IPlayGuestUiAnimation CreateFromSetValue([Nullable(2)] IPlayGuestUiAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IPlayGuestUiAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x06009FAC RID: 40876 RVA: 0x0016C99E File Offset: 0x0016AB9E
		public new IPlayGuestUiAnimation_SetValue ToSetValue()
		{
			return new IPlayGuestUiAnimation_SetValue
			{
				Type = this.Type,
				PlayGuestUiAnimation = this.PlayGuestUiAnimation
			};
		}

		// Token: 0x17003190 RID: 12688
		// (get) Token: 0x06009FAD RID: 40877 RVA: 0x0016C9BD File Offset: 0x0016ABBD
		// (set) Token: 0x06009FAE RID: 40878 RVA: 0x0016C9E8 File Offset: 0x0016ABE8
		public override EGuestOperateUiAnimation Type
		{
			get
			{
				if (this.FbInstance != null)
				{
					return this.FbInstance.Type;
				}
				if (this.PocoInterface == null)
				{
					return EGuestOperateUiAnimation.Play;
				}
				return this.PocoInterface.Type;
			}
			set
			{
				this.GetOrCreatePoco().Type = value;
			}
		}

		// Token: 0x17003191 RID: 12689
		// (get) Token: 0x06009FAF RID: 40879 RVA: 0x0016C9F8 File Offset: 0x0016ABF8
		// (set) Token: 0x06009FB0 RID: 40880 RVA: 0x0016CA59 File Offset: 0x0016AC59
		public virtual IPlayGuestCartethyia PlayGuestUiAnimation
		{
			get
			{
				if (this._PlayGuestUiAnimationInited)
				{
					return this._PlayGuestUiAnimationCache;
				}
				this._PlayGuestUiAnimationInited = true;
				if (this.FbInstance != null)
				{
					this._PlayGuestUiAnimationCache = IPlayGuestCartethyia.Create(this.FbInstance.PlayGuestUiAnimation);
				}
				else
				{
					IPlayGuestUiAnimation_SetValue pocoInterface = this.PocoInterface;
					this._PlayGuestUiAnimationCache = ((pocoInterface != null) ? pocoInterface.PlayGuestUiAnimation : null);
				}
				return this._PlayGuestUiAnimationCache;
			}
			set
			{
				this.GetOrCreatePoco().PlayGuestUiAnimation = value;
				this._PlayGuestUiAnimationInited = false;
			}
		}

		// Token: 0x04006053 RID: 24659
		[Nullable(2)]
		protected new IPlayGuestUiAnimation FbInstance;

		// Token: 0x04006054 RID: 24660
		[Nullable(2)]
		protected new IPlayGuestUiAnimation_SetValue PocoInterface;

		// Token: 0x04006055 RID: 24661
		private IPlayGuestCartethyia _PlayGuestUiAnimationCache;

		// Token: 0x04006056 RID: 24662
		private bool _PlayGuestUiAnimationInited;
	}
}
