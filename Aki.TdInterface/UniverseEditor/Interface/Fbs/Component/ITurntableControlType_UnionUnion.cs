using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02006110 RID: 24848
	public class ITurntableControlType_UnionUnion
	{
		// Token: 0x1700B8F9 RID: 47353
		// (get) Token: 0x0602A1E4 RID: 172516 RVA: 0x005BF9EE File Offset: 0x005BDBEE
		// (set) Token: 0x0602A1E5 RID: 172517 RVA: 0x005BF9F6 File Offset: 0x005BDBF6
		public ITurntableControlType_Union Type { get; set; }

		// Token: 0x1700B8FA RID: 47354
		// (get) Token: 0x0602A1E6 RID: 172518 RVA: 0x005BF9FF File Offset: 0x005BDBFF
		// (set) Token: 0x0602A1E7 RID: 172519 RVA: 0x005BFA07 File Offset: 0x005BDC07
		public object Value { get; set; }

		// Token: 0x0602A1E8 RID: 172520 RVA: 0x005BFA10 File Offset: 0x005BDC10
		public ITurntableControlType_UnionUnion()
		{
			this.Type = ITurntableControlType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602A1E9 RID: 172521 RVA: 0x005BFA26 File Offset: 0x005BDC26
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602A1EA RID: 172522 RVA: 0x005BFA38 File Offset: 0x005BDC38
		public ITurntableControlTypeT AsITurntableControlType()
		{
			return this.As<ITurntableControlTypeT>();
		}

		// Token: 0x0602A1EB RID: 172523 RVA: 0x005BFA40 File Offset: 0x005BDC40
		public static ITurntableControlType_UnionUnion FromITurntableControlType(ITurntableControlTypeT _iturntablecontroltype)
		{
			return new ITurntableControlType_UnionUnion
			{
				Type = ITurntableControlType_Union.ITurntableControlType,
				Value = _iturntablecontroltype
			};
		}

		// Token: 0x0602A1EC RID: 172524 RVA: 0x005BFA55 File Offset: 0x005BDC55
		public IFreeAngleTurntableT AsIFreeAngleTurntable()
		{
			return this.As<IFreeAngleTurntableT>();
		}

		// Token: 0x0602A1ED RID: 172525 RVA: 0x005BFA5D File Offset: 0x005BDC5D
		public static ITurntableControlType_UnionUnion FromIFreeAngleTurntable(IFreeAngleTurntableT _ifreeangleturntable)
		{
			return new ITurntableControlType_UnionUnion
			{
				Type = ITurntableControlType_Union.IFreeAngleTurntable,
				Value = _ifreeangleturntable
			};
		}

		// Token: 0x0602A1EE RID: 172526 RVA: 0x005BFA72 File Offset: 0x005BDC72
		public IFixedAngleTurntableT AsIFixedAngleTurntable()
		{
			return this.As<IFixedAngleTurntableT>();
		}

		// Token: 0x0602A1EF RID: 172527 RVA: 0x005BFA7A File Offset: 0x005BDC7A
		public static ITurntableControlType_UnionUnion FromIFixedAngleTurntable(IFixedAngleTurntableT _ifixedangleturntable)
		{
			return new ITurntableControlType_UnionUnion
			{
				Type = ITurntableControlType_Union.IFixedAngleTurntable,
				Value = _ifixedangleturntable
			};
		}

		// Token: 0x0602A1F0 RID: 172528 RVA: 0x005BFA90 File Offset: 0x005BDC90
		public static int Pack(FlatBufferBuilder builder, ITurntableControlType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case ITurntableControlType_Union.ITurntableControlType:
				return ITurntableControlType.Pack(builder, _o.AsITurntableControlType()).Value;
			case ITurntableControlType_Union.IFreeAngleTurntable:
				return IFreeAngleTurntable.Pack(builder, _o.AsIFreeAngleTurntable()).Value;
			case ITurntableControlType_Union.IFixedAngleTurntable:
				return IFixedAngleTurntable.Pack(builder, _o.AsIFixedAngleTurntable()).Value;
			default:
				return 0;
			}
		}
	}
}
