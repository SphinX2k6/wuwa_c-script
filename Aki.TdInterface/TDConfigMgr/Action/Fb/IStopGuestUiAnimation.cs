using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CFF RID: 11519
	public class IStopGuestUiAnimation : IGuestOperateUiAnimationType
	{
		// Token: 0x0600FC15 RID: 64533 RVA: 0x00247836 File Offset: 0x00245A36
		public static IStopGuestUiAnimation Create(IStopGuestUiAnimation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IStopGuestUiAnimation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EC5 RID: 20165
		// (get) Token: 0x0600FC16 RID: 64534 RVA: 0x00247855 File Offset: 0x00245A55
		public override EGuestOperateUiAnimation Type
		{
			get
			{
				return (EGuestOperateUiAnimation)this.Instance.Type;
			}
		}

		// Token: 0x17004EC6 RID: 20166
		// (get) Token: 0x0600FC17 RID: 64535 RVA: 0x00247862 File Offset: 0x00245A62
		public virtual IStopGuestCartethyia StopGuestUiAnimation
		{
			get
			{
				if (this._StopGuestUiAnimationInited)
				{
					return this._StopGuestUiAnimationCache;
				}
				this._StopGuestUiAnimationInited = true;
				this._StopGuestUiAnimationCache = IStopGuestCartethyia.Create(this.Instance.StopGuestUiAnimation);
				return this._StopGuestUiAnimationCache;
			}
		}

		// Token: 0x040089A9 RID: 35241
		private IStopGuestUiAnimation Instance;

		// Token: 0x040089AA RID: 35242
		[Nullable(2)]
		private IStopGuestCartethyia _StopGuestUiAnimationCache;

		// Token: 0x040089AB RID: 35243
		private bool _StopGuestUiAnimationInited;
	}
}
