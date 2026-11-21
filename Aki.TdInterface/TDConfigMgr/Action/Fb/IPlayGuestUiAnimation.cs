using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002CFC RID: 11516
	public class IPlayGuestUiAnimation : IGuestOperateUiAnimationType
	{
		// Token: 0x0600FC0B RID: 64523 RVA: 0x00247766 File Offset: 0x00245966
		public static IPlayGuestUiAnimation Create(IPlayGuestUiAnimation? instance)
		{
			if (instance == null)
			{
				return null;
			}
			return new IPlayGuestUiAnimation
			{
				Instance = instance.Value
			};
		}

		// Token: 0x17004EC1 RID: 20161
		// (get) Token: 0x0600FC0C RID: 64524 RVA: 0x00247785 File Offset: 0x00245985
		public override EGuestOperateUiAnimation Type
		{
			get
			{
				return (EGuestOperateUiAnimation)this.Instance.Type;
			}
		}

		// Token: 0x17004EC2 RID: 20162
		// (get) Token: 0x0600FC0D RID: 64525 RVA: 0x00247792 File Offset: 0x00245992
		public virtual IPlayGuestCartethyia PlayGuestUiAnimation
		{
			get
			{
				if (this._PlayGuestUiAnimationInited)
				{
					return this._PlayGuestUiAnimationCache;
				}
				this._PlayGuestUiAnimationInited = true;
				this._PlayGuestUiAnimationCache = IPlayGuestCartethyia.Create(this.Instance.PlayGuestUiAnimation);
				return this._PlayGuestUiAnimationCache;
			}
		}

		// Token: 0x040089A4 RID: 35236
		private IPlayGuestUiAnimation Instance;

		// Token: 0x040089A5 RID: 35237
		[Nullable(2)]
		private IPlayGuestCartethyia _PlayGuestUiAnimationCache;

		// Token: 0x040089A6 RID: 35238
		private bool _PlayGuestUiAnimationInited;
	}
}
