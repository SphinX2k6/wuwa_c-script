using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001F23 RID: 7971
	public class IPlayGuestUiAnimation : IGuestOperateUiAnimationType
	{
		// Token: 0x0600A995 RID: 43413 RVA: 0x00180D64 File Offset: 0x0017EF64
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

		// Token: 0x0600A996 RID: 43414 RVA: 0x00180D9C File Offset: 0x0017EF9C
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

		// Token: 0x0600A997 RID: 43415 RVA: 0x00180DAF File Offset: 0x0017EFAF
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

		// Token: 0x0600A998 RID: 43416 RVA: 0x00180DC2 File Offset: 0x0017EFC2
		public new IPlayGuestUiAnimation_SetValue ToSetValue()
		{
			return new IPlayGuestUiAnimation_SetValue
			{
				Type = this.Type,
				PlayGuestUiAnimation = this.PlayGuestUiAnimation
			};
		}

		// Token: 0x17003424 RID: 13348
		// (get) Token: 0x0600A999 RID: 43417 RVA: 0x00180DE1 File Offset: 0x0017EFE1
		// (set) Token: 0x0600A99A RID: 43418 RVA: 0x00180E0C File Offset: 0x0017F00C
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

		// Token: 0x17003425 RID: 13349
		// (get) Token: 0x0600A99B RID: 43419 RVA: 0x00180E1C File Offset: 0x0017F01C
		// (set) Token: 0x0600A99C RID: 43420 RVA: 0x00180E7D File Offset: 0x0017F07D
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

		// Token: 0x040065CF RID: 26063
		[Nullable(2)]
		protected new IPlayGuestUiAnimation FbInstance;

		// Token: 0x040065D0 RID: 26064
		[Nullable(2)]
		protected new IPlayGuestUiAnimation_SetValue PocoInterface;

		// Token: 0x040065D1 RID: 26065
		private IPlayGuestCartethyia _PlayGuestUiAnimationCache;

		// Token: 0x040065D2 RID: 26066
		private bool _PlayGuestUiAnimationInited;
	}
}
