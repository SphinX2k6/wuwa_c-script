using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071D6 RID: 29142
	public class IStopGuestUiAnimationType_UnionUnion
	{
		// Token: 0x1700D87D RID: 55421
		// (get) Token: 0x06033B13 RID: 211731 RVA: 0x006F5CA9 File Offset: 0x006F3EA9
		// (set) Token: 0x06033B14 RID: 211732 RVA: 0x006F5CB1 File Offset: 0x006F3EB1
		public IStopGuestUiAnimationType_Union Type { get; set; }

		// Token: 0x1700D87E RID: 55422
		// (get) Token: 0x06033B15 RID: 211733 RVA: 0x006F5CBA File Offset: 0x006F3EBA
		// (set) Token: 0x06033B16 RID: 211734 RVA: 0x006F5CC2 File Offset: 0x006F3EC2
		public object Value { get; set; }

		// Token: 0x06033B17 RID: 211735 RVA: 0x006F5CCB File Offset: 0x006F3ECB
		public IStopGuestUiAnimationType_UnionUnion()
		{
			this.Type = IStopGuestUiAnimationType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06033B18 RID: 211736 RVA: 0x006F5CE1 File Offset: 0x006F3EE1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06033B19 RID: 211737 RVA: 0x006F5CF3 File Offset: 0x006F3EF3
		public IStopGuestUiAnimationTypeT AsIStopGuestUiAnimationType()
		{
			return this.As<IStopGuestUiAnimationTypeT>();
		}

		// Token: 0x06033B1A RID: 211738 RVA: 0x006F5CFB File Offset: 0x006F3EFB
		public static IStopGuestUiAnimationType_UnionUnion FromIStopGuestUiAnimationType(IStopGuestUiAnimationTypeT _istopguestuianimationtype)
		{
			return new IStopGuestUiAnimationType_UnionUnion
			{
				Type = IStopGuestUiAnimationType_Union.IStopGuestUiAnimationType,
				Value = _istopguestuianimationtype
			};
		}

		// Token: 0x06033B1B RID: 211739 RVA: 0x006F5D10 File Offset: 0x006F3F10
		public IStopGuestCartethyiaT AsIStopGuestCartethyia()
		{
			return this.As<IStopGuestCartethyiaT>();
		}

		// Token: 0x06033B1C RID: 211740 RVA: 0x006F5D18 File Offset: 0x006F3F18
		public static IStopGuestUiAnimationType_UnionUnion FromIStopGuestCartethyia(IStopGuestCartethyiaT _istopguestcartethyia)
		{
			return new IStopGuestUiAnimationType_UnionUnion
			{
				Type = IStopGuestUiAnimationType_Union.IStopGuestCartethyia,
				Value = _istopguestcartethyia
			};
		}

		// Token: 0x06033B1D RID: 211741 RVA: 0x006F5D30 File Offset: 0x006F3F30
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
