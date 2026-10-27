using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006D21 RID: 27937
	public class IPlayGuestUiAnimationType_UnionUnion
	{
		// Token: 0x1700CFFE RID: 53246
		// (get) Token: 0x0603142C RID: 201772 RVA: 0x006AE419 File Offset: 0x006AC619
		// (set) Token: 0x0603142D RID: 201773 RVA: 0x006AE421 File Offset: 0x006AC621
		public IPlayGuestUiAnimationType_Union Type { get; set; }

		// Token: 0x1700CFFF RID: 53247
		// (get) Token: 0x0603142E RID: 201774 RVA: 0x006AE42A File Offset: 0x006AC62A
		// (set) Token: 0x0603142F RID: 201775 RVA: 0x006AE432 File Offset: 0x006AC632
		public object Value { get; set; }

		// Token: 0x06031430 RID: 201776 RVA: 0x006AE43B File Offset: 0x006AC63B
		public IPlayGuestUiAnimationType_UnionUnion()
		{
			this.Type = IPlayGuestUiAnimationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06031431 RID: 201777 RVA: 0x006AE451 File Offset: 0x006AC651
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06031432 RID: 201778 RVA: 0x006AE463 File Offset: 0x006AC663
		public IPlayGuestUiAnimationTypeT AsIPlayGuestUiAnimationType()
		{
			return this.As<IPlayGuestUiAnimationTypeT>();
		}

		// Token: 0x06031433 RID: 201779 RVA: 0x006AE46B File Offset: 0x006AC66B
		public static IPlayGuestUiAnimationType_UnionUnion FromIPlayGuestUiAnimationType(IPlayGuestUiAnimationTypeT _iplayguestuianimationtype)
		{
			return new IPlayGuestUiAnimationType_UnionUnion
			{
				Type = IPlayGuestUiAnimationType_Union.IPlayGuestUiAnimationType,
				Value = _iplayguestuianimationtype
			};
		}

		// Token: 0x06031434 RID: 201780 RVA: 0x006AE480 File Offset: 0x006AC680
		public IPlayGuestCartethyiaT AsIPlayGuestCartethyia()
		{
			return this.As<IPlayGuestCartethyiaT>();
		}

		// Token: 0x06031435 RID: 201781 RVA: 0x006AE488 File Offset: 0x006AC688
		public static IPlayGuestUiAnimationType_UnionUnion FromIPlayGuestCartethyia(IPlayGuestCartethyiaT _iplayguestcartethyia)
		{
			return new IPlayGuestUiAnimationType_UnionUnion
			{
				Type = IPlayGuestUiAnimationType_Union.IPlayGuestCartethyia,
				Value = _iplayguestcartethyia
			};
		}

		// Token: 0x06031436 RID: 201782 RVA: 0x006AE4A0 File Offset: 0x006AC6A0
		public static int Pack(FlatBufferBuilder builder, IPlayGuestUiAnimationType_UnionUnion _o)
		{
			IPlayGuestUiAnimationType_Union type = _o.Type;
			if (type == IPlayGuestUiAnimationType_Union.IPlayGuestUiAnimationType)
			{
				return IPlayGuestUiAnimationType.Pack(builder, _o.AsIPlayGuestUiAnimationType()).Value;
			}
			if (type != IPlayGuestUiAnimationType_Union.IPlayGuestCartethyia)
			{
				return 0;
			}
			return IPlayGuestCartethyia.Pack(builder, _o.AsIPlayGuestCartethyia()).Value;
		}
	}
}
