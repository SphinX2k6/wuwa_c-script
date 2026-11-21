using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020079AB RID: 31147
	public class IStopGuestUiAnimationType_UnionUnion
	{
		// Token: 0x1700E476 RID: 58486
		// (get) Token: 0x06036E15 RID: 224789 RVA: 0x00757009 File Offset: 0x00755209
		// (set) Token: 0x06036E16 RID: 224790 RVA: 0x00757011 File Offset: 0x00755211
		public IStopGuestUiAnimationType_Union Type { get; set; }

		// Token: 0x1700E477 RID: 58487
		// (get) Token: 0x06036E17 RID: 224791 RVA: 0x0075701A File Offset: 0x0075521A
		// (set) Token: 0x06036E18 RID: 224792 RVA: 0x00757022 File Offset: 0x00755222
		public object Value { get; set; }

		// Token: 0x06036E19 RID: 224793 RVA: 0x0075702B File Offset: 0x0075522B
		public IStopGuestUiAnimationType_UnionUnion()
		{
			this.Type = IStopGuestUiAnimationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06036E1A RID: 224794 RVA: 0x00757041 File Offset: 0x00755241
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06036E1B RID: 224795 RVA: 0x00757053 File Offset: 0x00755253
		public IStopGuestUiAnimationTypeT AsIStopGuestUiAnimationType()
		{
			return this.As<IStopGuestUiAnimationTypeT>();
		}

		// Token: 0x06036E1C RID: 224796 RVA: 0x0075705B File Offset: 0x0075525B
		public static IStopGuestUiAnimationType_UnionUnion FromIStopGuestUiAnimationType(IStopGuestUiAnimationTypeT _istopguestuianimationtype)
		{
			return new IStopGuestUiAnimationType_UnionUnion
			{
				Type = IStopGuestUiAnimationType_Union.IStopGuestUiAnimationType,
				Value = _istopguestuianimationtype
			};
		}

		// Token: 0x06036E1D RID: 224797 RVA: 0x00757070 File Offset: 0x00755270
		public IStopGuestCartethyiaT AsIStopGuestCartethyia()
		{
			return this.As<IStopGuestCartethyiaT>();
		}

		// Token: 0x06036E1E RID: 224798 RVA: 0x00757078 File Offset: 0x00755278
		public static IStopGuestUiAnimationType_UnionUnion FromIStopGuestCartethyia(IStopGuestCartethyiaT _istopguestcartethyia)
		{
			return new IStopGuestUiAnimationType_UnionUnion
			{
				Type = IStopGuestUiAnimationType_Union.IStopGuestCartethyia,
				Value = _istopguestcartethyia
			};
		}

		// Token: 0x06036E1F RID: 224799 RVA: 0x00757090 File Offset: 0x00755290
		public static int Pack(FlatBufferBuilder builder, IStopGuestUiAnimationType_UnionUnion _o)
		{
			IStopGuestUiAnimationType_Union type = _o.Type;
			if (type == IStopGuestUiAnimationType_Union.IStopGuestUiAnimationType)
			{
				return IStopGuestUiAnimationType.Pack(builder, _o.AsIStopGuestUiAnimationType()).Value;
			}
			if (type != IStopGuestUiAnimationType_Union.IStopGuestCartethyia)
			{
				return 0;
			}
			return IStopGuestCartethyia.Pack(builder, _o.AsIStopGuestCartethyia()).Value;
		}
	}
}
