using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E28 RID: 15912
	public class IFastReturnPosBase_UnionUnion
	{
		// Token: 0x17006E05 RID: 28165
		// (get) Token: 0x060164BD RID: 91325 RVA: 0x00338295 File Offset: 0x00336495
		// (set) Token: 0x060164BE RID: 91326 RVA: 0x0033829D File Offset: 0x0033649D
		public IFastReturnPosBase_Union Type { get; set; }

		// Token: 0x17006E06 RID: 28166
		// (get) Token: 0x060164BF RID: 91327 RVA: 0x003382A6 File Offset: 0x003364A6
		// (set) Token: 0x060164C0 RID: 91328 RVA: 0x003382AE File Offset: 0x003364AE
		public object Value { get; set; }

		// Token: 0x060164C1 RID: 91329 RVA: 0x003382B7 File Offset: 0x003364B7
		public IFastReturnPosBase_UnionUnion()
		{
			this.Type = IFastReturnPosBase_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060164C2 RID: 91330 RVA: 0x003382CD File Offset: 0x003364CD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060164C3 RID: 91331 RVA: 0x003382DF File Offset: 0x003364DF
		public IFastReturnPosBaseT AsIFastReturnPosBase()
		{
			return this.As<IFastReturnPosBaseT>();
		}

		// Token: 0x060164C4 RID: 91332 RVA: 0x003382E7 File Offset: 0x003364E7
		public static IFastReturnPosBase_UnionUnion FromIFastReturnPosBase(IFastReturnPosBaseT _ifastreturnposbase)
		{
			return new IFastReturnPosBase_UnionUnion
			{
				Type = IFastReturnPosBase_Union.IFastReturnPosBase,
				Value = _ifastreturnposbase
			};
		}

		// Token: 0x060164C5 RID: 91333 RVA: 0x003382FC File Offset: 0x003364FC
		public IFastReturnEntityPosT AsIFastReturnEntityPos()
		{
			return this.As<IFastReturnEntityPosT>();
		}

		// Token: 0x060164C6 RID: 91334 RVA: 0x00338304 File Offset: 0x00336504
		public static IFastReturnPosBase_UnionUnion FromIFastReturnEntityPos(IFastReturnEntityPosT _ifastreturnentitypos)
		{
			return new IFastReturnPosBase_UnionUnion
			{
				Type = IFastReturnPosBase_Union.IFastReturnEntityPos,
				Value = _ifastreturnentitypos
			};
		}

		// Token: 0x060164C7 RID: 91335 RVA: 0x00338319 File Offset: 0x00336519
		public IFastReturnGravityEntityPosT AsIFastReturnGravityEntityPos()
		{
			return this.As<IFastReturnGravityEntityPosT>();
		}

		// Token: 0x060164C8 RID: 91336 RVA: 0x00338321 File Offset: 0x00336521
		public static IFastReturnPosBase_UnionUnion FromIFastReturnGravityEntityPos(IFastReturnGravityEntityPosT _ifastreturngravityentitypos)
		{
			return new IFastReturnPosBase_UnionUnion
			{
				Type = IFastReturnPosBase_Union.IFastReturnGravityEntityPos,
				Value = _ifastreturngravityentitypos
			};
		}

		// Token: 0x060164C9 RID: 91337 RVA: 0x00338338 File Offset: 0x00336538
		public static int Pack(FlatBufferBuilder builder, IFastReturnPosBase_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IFastReturnPosBase_Union.IFastReturnPosBase:
				return IFastReturnPosBase.Pack(builder, _o.AsIFastReturnPosBase()).Value;
			case IFastReturnPosBase_Union.IFastReturnEntityPos:
				return IFastReturnEntityPos.Pack(builder, _o.AsIFastReturnEntityPos()).Value;
			case IFastReturnPosBase_Union.IFastReturnGravityEntityPos:
				return IFastReturnGravityEntityPos.Pack(builder, _o.AsIFastReturnGravityEntityPos()).Value;
			default:
				return 0;
			}
		}
	}
}
