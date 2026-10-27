using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020068B6 RID: 26806
	public class IGuestOperateUiAnimationType_UnionUnion
	{
		// Token: 0x1700C6F4 RID: 50932
		// (get) Token: 0x0602EC0A RID: 191498 RVA: 0x0065F5ED File Offset: 0x0065D7ED
		// (set) Token: 0x0602EC0B RID: 191499 RVA: 0x0065F5F5 File Offset: 0x0065D7F5
		public IGuestOperateUiAnimationType_Union Type { get; set; }

		// Token: 0x1700C6F5 RID: 50933
		// (get) Token: 0x0602EC0C RID: 191500 RVA: 0x0065F5FE File Offset: 0x0065D7FE
		// (set) Token: 0x0602EC0D RID: 191501 RVA: 0x0065F606 File Offset: 0x0065D806
		public object Value { get; set; }

		// Token: 0x0602EC0E RID: 191502 RVA: 0x0065F60F File Offset: 0x0065D80F
		public IGuestOperateUiAnimationType_UnionUnion()
		{
			this.Type = IGuestOperateUiAnimationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602EC0F RID: 191503 RVA: 0x0065F625 File Offset: 0x0065D825
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602EC10 RID: 191504 RVA: 0x0065F637 File Offset: 0x0065D837
		public IGuestOperateUiAnimationTypeT AsIGuestOperateUiAnimationType()
		{
			return this.As<IGuestOperateUiAnimationTypeT>();
		}

		// Token: 0x0602EC11 RID: 191505 RVA: 0x0065F63F File Offset: 0x0065D83F
		public static IGuestOperateUiAnimationType_UnionUnion FromIGuestOperateUiAnimationType(IGuestOperateUiAnimationTypeT _iguestoperateuianimationtype)
		{
			return new IGuestOperateUiAnimationType_UnionUnion
			{
				Type = IGuestOperateUiAnimationType_Union.IGuestOperateUiAnimationType,
				Value = _iguestoperateuianimationtype
			};
		}

		// Token: 0x0602EC12 RID: 191506 RVA: 0x0065F654 File Offset: 0x0065D854
		public IPlayGuestUiAnimationT AsIPlayGuestUiAnimation()
		{
			return this.As<IPlayGuestUiAnimationT>();
		}

		// Token: 0x0602EC13 RID: 191507 RVA: 0x0065F65C File Offset: 0x0065D85C
		public static IGuestOperateUiAnimationType_UnionUnion FromIPlayGuestUiAnimation(IPlayGuestUiAnimationT _iplayguestuianimation)
		{
			return new IGuestOperateUiAnimationType_UnionUnion
			{
				Type = IGuestOperateUiAnimationType_Union.IPlayGuestUiAnimation,
				Value = _iplayguestuianimation
			};
		}

		// Token: 0x0602EC14 RID: 191508 RVA: 0x0065F671 File Offset: 0x0065D871
		public IStopGuestUiAnimationT AsIStopGuestUiAnimation()
		{
			return this.As<IStopGuestUiAnimationT>();
		}

		// Token: 0x0602EC15 RID: 191509 RVA: 0x0065F679 File Offset: 0x0065D879
		public static IGuestOperateUiAnimationType_UnionUnion FromIStopGuestUiAnimation(IStopGuestUiAnimationT _istopguestuianimation)
		{
			return new IGuestOperateUiAnimationType_UnionUnion
			{
				Type = IGuestOperateUiAnimationType_Union.IStopGuestUiAnimation,
				Value = _istopguestuianimation
			};
		}

		// Token: 0x0602EC16 RID: 191510 RVA: 0x0065F690 File Offset: 0x0065D890
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
