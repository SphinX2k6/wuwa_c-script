using System;
using System.Runtime.CompilerServices;
using Aki.TDConfigMgr.Action.Fb;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020020F8 RID: 8440
	public class IStopGuestUiAnimation : IGuestOperateUiAnimationType
	{
		// Token: 0x0600B354 RID: 45908 RVA: 0x00192768 File Offset: 0x00190968
		private IStopGuestUiAnimation_SetValue GetOrCreatePoco()
		{
			if (this.FbInstance != null)
			{
				throw new InvalidOperationException("IStopGuestUiAnimation 已绑定 FbInstance（Fb-backed 只读），不允许 set 写入 PocoInterface");
			}
			IStopGuestUiAnimation_SetValue result;
			if ((result = this.PocoInterface) == null)
			{
				result = (this.PocoInterface = new IStopGuestUiAnimation_SetValue());
			}
			return result;
		}

		// Token: 0x0600B355 RID: 45909 RVA: 0x001927A0 File Offset: 0x001909A0
		public static IStopGuestUiAnimation Create([Nullable(2)] IStopGuestUiAnimation instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopGuestUiAnimation
			{
				FbInstance = instance
			};
		}

		// Token: 0x0600B356 RID: 45910 RVA: 0x001927B3 File Offset: 0x001909B3
		public static IStopGuestUiAnimation CreateFromSetValue([Nullable(2)] IStopGuestUiAnimation_SetValue value)
		{
			if (value == null)
			{
				return null;
			}
			return new IStopGuestUiAnimation
			{
				PocoInterface = value
			};
		}

		// Token: 0x0600B357 RID: 45911 RVA: 0x001927C6 File Offset: 0x001909C6
		public new IStopGuestUiAnimation_SetValue ToSetValue()
		{
			return new IStopGuestUiAnimation_SetValue
			{
				Type = this.Type,
				StopGuestUiAnimation = this.StopGuestUiAnimation
			};
		}

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600B358 RID: 45912 RVA: 0x001927E5 File Offset: 0x001909E5
		// (set) Token: 0x0600B359 RID: 45913 RVA: 0x00192810 File Offset: 0x00190A10
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

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600B35A RID: 45914 RVA: 0x00192820 File Offset: 0x00190A20
		// (set) Token: 0x0600B35B RID: 45915 RVA: 0x00192881 File Offset: 0x00190A81
		public virtual IStopGuestCartethyia StopGuestUiAnimation
		{
			get
			{
				if (this._StopGuestUiAnimationInited)
				{
					return this._StopGuestUiAnimationCache;
				}
				this._StopGuestUiAnimationInited = true;
				if (this.FbInstance != null)
				{
					this._StopGuestUiAnimationCache = IStopGuestCartethyia.Create(this.FbInstance.StopGuestUiAnimation);
				}
				else
				{
					IStopGuestUiAnimation_SetValue pocoInterface = this.PocoInterface;
					this._StopGuestUiAnimationCache = ((pocoInterface != null) ? pocoInterface.StopGuestUiAnimation : null);
				}
				return this._StopGuestUiAnimationCache;
			}
			set
			{
				this.GetOrCreatePoco().StopGuestUiAnimation = value;
				this._StopGuestUiAnimationInited = false;
			}
		}

		// Token: 0x04006A52 RID: 27218
		[Nullable(2)]
		protected new IStopGuestUiAnimation FbInstance;

		// Token: 0x04006A53 RID: 27219
		[Nullable(2)]
		protected new IStopGuestUiAnimation_SetValue PocoInterface;

		// Token: 0x04006A54 RID: 27220
		private IStopGuestCartethyia _StopGuestUiAnimationCache;

		// Token: 0x04006A55 RID: 27221
		private bool _StopGuestUiAnimationInited;
	}
}
