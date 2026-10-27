using System;
using System.Runtime.CompilerServices;
using Aki.UniverseEditor.Interface.Fbs.Action;

namespace Aki.TDConfigMgr.Action.Fb
{
	// Token: 0x02002A12 RID: 10770
	[NullableContext(1)]
	[Nullable(0)]
	public class IStopGuestUiAnimation : IGuestOperateUiAnimationType
	{
		// Token: 0x0600ED7E RID: 60798 RVA: 0x00229EB2 File Offset: 0x002280B2
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

		// Token: 0x17004B1C RID: 19228
		// (get) Token: 0x0600ED7F RID: 60799 RVA: 0x00229ED1 File Offset: 0x002280D1
		public override EGuestOperateUiAnimation Type
		{
			get
			{
				return (EGuestOperateUiAnimation)this.Instance.Type;
			}
		}

		// Token: 0x17004B1D RID: 19229
		// (get) Token: 0x0600ED80 RID: 60800 RVA: 0x00229EDE File Offset: 0x002280DE
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

		// Token: 0x040082B8 RID: 33464
		private IStopGuestUiAnimation Instance;

		// Token: 0x040082B9 RID: 33465
		[Nullable(2)]
		private IStopGuestCartethyia _StopGuestUiAnimationCache;

		// Token: 0x040082BA RID: 33466
		private bool _StopGuestUiAnimationInited;
	}
}
