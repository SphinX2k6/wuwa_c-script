using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007EF2 RID: 32498
	public class TGuestOperateUiAnimationUnion
	{
		// Token: 0x1700F26F RID: 62063
		// (get) Token: 0x0603AA15 RID: 240149 RVA: 0x007E322E File Offset: 0x007E142E
		// (set) Token: 0x0603AA16 RID: 240150 RVA: 0x007E3236 File Offset: 0x007E1436
		public TGuestOperateUiAnimation Type { get; set; }

		// Token: 0x1700F270 RID: 62064
		// (get) Token: 0x0603AA17 RID: 240151 RVA: 0x007E323F File Offset: 0x007E143F
		// (set) Token: 0x0603AA18 RID: 240152 RVA: 0x007E3247 File Offset: 0x007E1447
		public object Value { get; set; }

		// Token: 0x0603AA19 RID: 240153 RVA: 0x007E3250 File Offset: 0x007E1450
		public TGuestOperateUiAnimationUnion()
		{
			this.Type = TGuestOperateUiAnimation.NONE;
			this.Value = null;
		}

		// Token: 0x0603AA1A RID: 240154 RVA: 0x007E3266 File Offset: 0x007E1466
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603AA1B RID: 240155 RVA: 0x007E3278 File Offset: 0x007E1478
		public IPlayGuestUiAnimationT AsIPlayGuestUiAnimation()
		{
			return this.As<IPlayGuestUiAnimationT>();
		}

		// Token: 0x0603AA1C RID: 240156 RVA: 0x007E3280 File Offset: 0x007E1480
		public static TGuestOperateUiAnimationUnion FromIPlayGuestUiAnimation(IPlayGuestUiAnimationT _iplayguestuianimation)
		{
			return new TGuestOperateUiAnimationUnion
			{
				Type = TGuestOperateUiAnimation.IPlayGuestUiAnimation,
				Value = _iplayguestuianimation
			};
		}

		// Token: 0x0603AA1D RID: 240157 RVA: 0x007E3295 File Offset: 0x007E1495
		public IStopGuestUiAnimationT AsIStopGuestUiAnimation()
		{
			return this.As<IStopGuestUiAnimationT>();
		}

		// Token: 0x0603AA1E RID: 240158 RVA: 0x007E329D File Offset: 0x007E149D
		public static TGuestOperateUiAnimationUnion FromIStopGuestUiAnimation(IStopGuestUiAnimationT _istopguestuianimation)
		{
			return new TGuestOperateUiAnimationUnion
			{
				Type = TGuestOperateUiAnimation.IStopGuestUiAnimation,
				Value = _istopguestuianimation
			};
		}

		// Token: 0x0603AA1F RID: 240159 RVA: 0x007E32B4 File Offset: 0x007E14B4
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
