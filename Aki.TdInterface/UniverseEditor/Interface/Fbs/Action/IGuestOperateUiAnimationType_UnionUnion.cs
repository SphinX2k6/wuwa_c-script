using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F57 RID: 28503
	public class IGuestOperateUiAnimationType_UnionUnion
	{
		// Token: 0x1700D0DA RID: 53466
		// (get) Token: 0x06031544 RID: 202052 RVA: 0x006AE66D File Offset: 0x006AC86D
		// (set) Token: 0x06031545 RID: 202053 RVA: 0x006AE675 File Offset: 0x006AC875
		public IGuestOperateUiAnimationType_Union Type { get; set; }

		// Token: 0x1700D0DB RID: 53467
		// (get) Token: 0x06031546 RID: 202054 RVA: 0x006AE67E File Offset: 0x006AC87E
		// (set) Token: 0x06031547 RID: 202055 RVA: 0x006AE686 File Offset: 0x006AC886
		public object Value { get; set; }

		// Token: 0x06031548 RID: 202056 RVA: 0x006AE68F File Offset: 0x006AC88F
		public IGuestOperateUiAnimationType_UnionUnion()
		{
			this.Type = IGuestOperateUiAnimationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031549 RID: 202057 RVA: 0x006AE6A5 File Offset: 0x006AC8A5
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0603154A RID: 202058 RVA: 0x006AE6B7 File Offset: 0x006AC8B7
		public IGuestOperateUiAnimationTypeT AsIGuestOperateUiAnimationType()
		{
			return this.As<IGuestOperateUiAnimationTypeT>();
		}

		// Token: 0x0603154B RID: 202059 RVA: 0x006AE6BF File Offset: 0x006AC8BF
		public static IGuestOperateUiAnimationType_UnionUnion FromIGuestOperateUiAnimationType(IGuestOperateUiAnimationTypeT _iguestoperateuianimationtype)
		{
			return new IGuestOperateUiAnimationType_UnionUnion
			{
				Type = IGuestOperateUiAnimationType_Union.IGuestOperateUiAnimationType,
				Value = _iguestoperateuianimationtype
			};
		}

		// Token: 0x0603154C RID: 202060 RVA: 0x006AE6D4 File Offset: 0x006AC8D4
		public IPlayGuestUiAnimationT AsIPlayGuestUiAnimation()
		{
			return this.As<IPlayGuestUiAnimationT>();
		}

		// Token: 0x0603154D RID: 202061 RVA: 0x006AE6DC File Offset: 0x006AC8DC
		public static IGuestOperateUiAnimationType_UnionUnion FromIPlayGuestUiAnimation(IPlayGuestUiAnimationT _iplayguestuianimation)
		{
			return new IGuestOperateUiAnimationType_UnionUnion
			{
				Type = IGuestOperateUiAnimationType_Union.IPlayGuestUiAnimation,
				Value = _iplayguestuianimation
			};
		}

		// Token: 0x0603154E RID: 202062 RVA: 0x006AE6F1 File Offset: 0x006AC8F1
		public IStopGuestUiAnimationT AsIStopGuestUiAnimation()
		{
			return this.As<IStopGuestUiAnimationT>();
		}

		// Token: 0x0603154F RID: 202063 RVA: 0x006AE6F9 File Offset: 0x006AC8F9
		public static IGuestOperateUiAnimationType_UnionUnion FromIStopGuestUiAnimation(IStopGuestUiAnimationT _istopguestuianimation)
		{
			return new IGuestOperateUiAnimationType_UnionUnion
			{
				Type = IGuestOperateUiAnimationType_Union.IStopGuestUiAnimation,
				Value = _istopguestuianimation
			};
		}

		// Token: 0x06031550 RID: 202064 RVA: 0x006AE710 File Offset: 0x006AC910
		public static int Pack(FlatBufferBuilder builder, IGuestOperateUiAnimationType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IGuestOperateUiAnimationType_Union.IGuestOperateUiAnimationType:
				return IGuestOperateUiAnimationType.Pack(builder, _o.AsIGuestOperateUiAnimationType()).Value;
			case IGuestOperateUiAnimationType_Union.IPlayGuestUiAnimation:
				return IPlayGuestUiAnimation.Pack(builder, _o.AsIPlayGuestUiAnimation()).Value;
			case IGuestOperateUiAnimationType_Union.IStopGuestUiAnimation:
				return IStopGuestUiAnimation.Pack(builder, _o.AsIStopGuestUiAnimation()).Value;
			default:
				return 0;
			}
		}
	}
}
