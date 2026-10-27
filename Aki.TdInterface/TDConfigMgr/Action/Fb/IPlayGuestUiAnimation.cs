using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A0F RID: 10767
	[NullableContext(1)]
	[Nullable(0)]
	public class IPlayGuestUiAnimation : IGuestOperateUiAnimationType
	{
		// Token: 0x0600ED74 RID: 60788 RVA: 0x00229DE2 File Offset: 0x00227FE2
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

		// Token: 0x17004B18 RID: 19224
		// (get) Token: 0x0600ED75 RID: 60789 RVA: 0x00229E01 File Offset: 0x00228001
		public override EGuestOperateUiAnimation Type
		{
			get
			{
				return (EGuestOperateUiAnimation)this.Instance.Type;
			}
		}

		// Token: 0x17004B19 RID: 19225
		// (get) Token: 0x0600ED76 RID: 60790 RVA: 0x00229E0E File Offset: 0x0022800E
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

		// Token: 0x040082B3 RID: 33459
		private IPlayGuestUiAnimation Instance;

		// Token: 0x040082B4 RID: 33460
		[Nullable(2)]
		private IPlayGuestCartethyia _PlayGuestUiAnimationCache;

		// Token: 0x040082B5 RID: 33461
		private bool _PlayGuestUiAnimationInited;
	}
}
