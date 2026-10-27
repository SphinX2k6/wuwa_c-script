using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007708 RID: 30472
	public class TLiftMoveTypeUnion
	{
		// Token: 0x1700E649 RID: 58953
		// (get) Token: 0x0603766E RID: 226926 RVA: 0x00780BF6 File Offset: 0x0077EDF6
		// (set) Token: 0x0603766F RID: 226927 RVA: 0x00780BFE File Offset: 0x0077EDFE
		public TLiftMoveType Type { get; set; }

		// Token: 0x1700E64A RID: 58954
		// (get) Token: 0x06037670 RID: 226928 RVA: 0x00780C07 File Offset: 0x0077EE07
		// (set) Token: 0x06037671 RID: 226929 RVA: 0x00780C0F File Offset: 0x0077EE0F
		public object Value { get; set; }

		// Token: 0x06037672 RID: 226930 RVA: 0x00780C18 File Offset: 0x0077EE18
		public TLiftMoveTypeUnion()
		{
			this.Type = TLiftMoveType.NONE;
			this.Value = null;
		}

		// Token: 0x06037673 RID: 226931 RVA: 0x00780C2E File Offset: 0x0077EE2E
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037674 RID: 226932 RVA: 0x00780C40 File Offset: 0x0077EE40
		public ILiftMoveTypeCircularT AsILiftMoveTypeCircular()
		{
			return this.As<ILiftMoveTypeCircularT>();
		}

		// Token: 0x06037675 RID: 226933 RVA: 0x00780C48 File Offset: 0x0077EE48
		public static TLiftMoveTypeUnion FromILiftMoveTypeCircular(ILiftMoveTypeCircularT _iliftmovetypecircular)
		{
			return new TLiftMoveTypeUnion
			{
				Type = TLiftMoveType.ILiftMoveTypeCircular,
				Value = _iliftmovetypecircular
			};
		}

		// Token: 0x06037676 RID: 226934 RVA: 0x00780C5D File Offset: 0x0077EE5D
		public ILiftMoveTypeCustomSpeedT AsILiftMoveTypeCustomSpeed()
		{
			return this.As<ILiftMoveTypeCustomSpeedT>();
		}

		// Token: 0x06037677 RID: 226935 RVA: 0x00780C65 File Offset: 0x0077EE65
		public static TLiftMoveTypeUnion FromILiftMoveTypeCustomSpeed(ILiftMoveTypeCustomSpeedT _iliftmovetypecustomspeed)
		{
			return new TLiftMoveTypeUnion
			{
				Type = TLiftMoveType.ILiftMoveTypeCustomSpeed,
				Value = _iliftmovetypecustomspeed
			};
		}

		// Token: 0x06037678 RID: 226936 RVA: 0x00780C7A File Offset: 0x0077EE7A
		public ILiftMoveTypeDefaultT AsILiftMoveTypeDefault()
		{
			return this.As<ILiftMoveTypeDefaultT>();
		}

		// Token: 0x06037679 RID: 226937 RVA: 0x00780C82 File Offset: 0x0077EE82
		public static TLiftMoveTypeUnion FromILiftMoveTypeDefault(ILiftMoveTypeDefaultT _iliftmovetypedefault)
		{
			return new TLiftMoveTypeUnion
			{
				Type = TLiftMoveType.ILiftMoveTypeDefault,
				Value = _iliftmovetypedefault
			};
		}

		// Token: 0x0603767A RID: 226938 RVA: 0x00780C97 File Offset: 0x0077EE97
		public ILiftMoveTypeTeleportT AsILiftMoveTypeTeleport()
		{
			return this.As<ILiftMoveTypeTeleportT>();
		}

		// Token: 0x0603767B RID: 226939 RVA: 0x00780C9F File Offset: 0x0077EE9F
		public static TLiftMoveTypeUnion FromILiftMoveTypeTeleport(ILiftMoveTypeTeleportT _iliftmovetypeteleport)
		{
			return new TLiftMoveTypeUnion
			{
				Type = TLiftMoveType.ILiftMoveTypeTeleport,
				Value = _iliftmovetypeteleport
			};
		}

		// Token: 0x0603767C RID: 226940 RVA: 0x00780CB4 File Offset: 0x0077EEB4
		public static int Pack(FlatBufferBuilder builder, TLiftMoveTypeUnion _o)
		{
			switch (_o.Type)
			{
			case TLiftMoveType.ILiftMoveTypeCircular:
				return ILiftMoveTypeCircular.Pack(builder, _o.AsILiftMoveTypeCircular()).Value;
			case TLiftMoveType.ILiftMoveTypeCustomSpeed:
				return ILiftMoveTypeCustomSpeed.Pack(builder, _o.AsILiftMoveTypeCustomSpeed()).Value;
			case TLiftMoveType.ILiftMoveTypeDefault:
				return ILiftMoveTypeDefault.Pack(builder, _o.AsILiftMoveTypeDefault()).Value;
			case TLiftMoveType.ILiftMoveTypeTeleport:
				return ILiftMoveTypeTeleport.Pack(builder, _o.AsILiftMoveTypeTeleport()).Value;
			default:
				return 0;
			}
		}
	}
}
