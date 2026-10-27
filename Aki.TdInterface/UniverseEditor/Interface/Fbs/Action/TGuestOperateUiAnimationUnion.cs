using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076E1 RID: 30433
	public class TGuestOperateUiAnimationUnion
	{
		// Token: 0x1700E62F RID: 58927
		// (get) Token: 0x06037554 RID: 226644 RVA: 0x0077EE1E File Offset: 0x0077D01E
		// (set) Token: 0x06037555 RID: 226645 RVA: 0x0077EE26 File Offset: 0x0077D026
		public TGuestOperateUiAnimation Type { get; set; }

		// Token: 0x1700E630 RID: 58928
		// (get) Token: 0x06037556 RID: 226646 RVA: 0x0077EE2F File Offset: 0x0077D02F
		// (set) Token: 0x06037557 RID: 226647 RVA: 0x0077EE37 File Offset: 0x0077D037
		public object Value { get; set; }

		// Token: 0x06037558 RID: 226648 RVA: 0x0077EE40 File Offset: 0x0077D040
		public TGuestOperateUiAnimationUnion()
		{
			this.Type = TGuestOperateUiAnimation.NONE;
			this.Value = null;
		}

		// Token: 0x06037559 RID: 226649 RVA: 0x0077EE56 File Offset: 0x0077D056
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603755A RID: 226650 RVA: 0x0077EE68 File Offset: 0x0077D068
		public IPlayGuestUiAnimationT AsIPlayGuestUiAnimation()
		{
			return this.As<IPlayGuestUiAnimationT>();
		}

		// Token: 0x0603755B RID: 226651 RVA: 0x0077EE70 File Offset: 0x0077D070
		public static TGuestOperateUiAnimationUnion FromIPlayGuestUiAnimation(IPlayGuestUiAnimationT _iplayguestuianimation)
		{
			return new TGuestOperateUiAnimationUnion
			{
				Type = TGuestOperateUiAnimation.IPlayGuestUiAnimation,
				Value = _iplayguestuianimation
			};
		}

		// Token: 0x0603755C RID: 226652 RVA: 0x0077EE85 File Offset: 0x0077D085
		public IStopGuestUiAnimationT AsIStopGuestUiAnimation()
		{
			return this.As<IStopGuestUiAnimationT>();
		}

		// Token: 0x0603755D RID: 226653 RVA: 0x0077EE8D File Offset: 0x0077D08D
		public static TGuestOperateUiAnimationUnion FromIStopGuestUiAnimation(IStopGuestUiAnimationT _istopguestuianimation)
		{
			return new TGuestOperateUiAnimationUnion
			{
				Type = TGuestOperateUiAnimation.IStopGuestUiAnimation,
				Value = _istopguestuianimation
			};
		}

		// Token: 0x0603755E RID: 226654 RVA: 0x0077EEA4 File Offset: 0x0077D0A4
		public static int Pack(FlatBufferBuilder builder, TGuestOperateUiAnimationUnion _o)
		{
			TGuestOperateUiAnimation type = _o.Type;
			if (type == TGuestOperateUiAnimation.IPlayGuestUiAnimation)
			{
				return IPlayGuestUiAnimation.Pack(builder, _o.AsIPlayGuestUiAnimation()).Value;
			}
			if (type != TGuestOperateUiAnimation.IStopGuestUiAnimation)
			{
				return 0;
			}
			return IStopGuestUiAnimation.Pack(builder, _o.AsIStopGuestUiAnimation()).Value;
		}
	}
}
