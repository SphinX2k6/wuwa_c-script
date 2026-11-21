using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003F4D RID: 16205
	public class TBlackBoardUnion
	{
		// Token: 0x17006DB6 RID: 28086
		// (get) Token: 0x060160A3 RID: 90275 RVA: 0x0032A33C File Offset: 0x0032853C
		// (set) Token: 0x060160A4 RID: 90276 RVA: 0x0032A344 File Offset: 0x00328544
		public TBlackBoard Type { get; set; }

		// Token: 0x17006DB7 RID: 28087
		// (get) Token: 0x060160A5 RID: 90277 RVA: 0x0032A34D File Offset: 0x0032854D
		// (set) Token: 0x060160A6 RID: 90278 RVA: 0x0032A355 File Offset: 0x00328555
		public object Value { get; set; }

		// Token: 0x060160A7 RID: 90279 RVA: 0x0032A35E File Offset: 0x0032855E
		public TBlackBoardUnion()
		{
			this.Type = TBlackBoard.NONE;
			this.Value = null;
		}

		// Token: 0x060160A8 RID: 90280 RVA: 0x0032A374 File Offset: 0x00328574
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060160A9 RID: 90281 RVA: 0x0032A386 File Offset: 0x00328586
		public IBlackBoardBooleanT AsIBlackBoardBoolean()
		{
			return this.As<IBlackBoardBooleanT>();
		}

		// Token: 0x060160AA RID: 90282 RVA: 0x0032A38E File Offset: 0x0032858E
		public static TBlackBoardUnion FromIBlackBoardBoolean(IBlackBoardBooleanT _iblackboardboolean)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardBoolean,
				Value = _iblackboardboolean
			};
		}

		// Token: 0x060160AB RID: 90283 RVA: 0x0032A3A3 File Offset: 0x003285A3
		public IBlackBoardEntityIdT AsIBlackBoardEntityId()
		{
			return this.As<IBlackBoardEntityIdT>();
		}

		// Token: 0x060160AC RID: 90284 RVA: 0x0032A3AB File Offset: 0x003285AB
		public static TBlackBoardUnion FromIBlackBoardEntityId(IBlackBoardEntityIdT _iblackboardentityid)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardEntityId,
				Value = _iblackboardentityid
			};
		}

		// Token: 0x060160AD RID: 90285 RVA: 0x0032A3C0 File Offset: 0x003285C0
		public IBlackBoardEntityPosT AsIBlackBoardEntityPos()
		{
			return this.As<IBlackBoardEntityPosT>();
		}

		// Token: 0x060160AE RID: 90286 RVA: 0x0032A3C8 File Offset: 0x003285C8
		public static TBlackBoardUnion FromIBlackBoardEntityPos(IBlackBoardEntityPosT _iblackboardentitypos)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardEntityPos,
				Value = _iblackboardentitypos
			};
		}

		// Token: 0x060160AF RID: 90287 RVA: 0x0032A3DD File Offset: 0x003285DD
		public IBlackBoardFloatT AsIBlackBoardFloat()
		{
			return this.As<IBlackBoardFloatT>();
		}

		// Token: 0x060160B0 RID: 90288 RVA: 0x0032A3E5 File Offset: 0x003285E5
		public static TBlackBoardUnion FromIBlackBoardFloat(IBlackBoardFloatT _iblackboardfloat)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardFloat,
				Value = _iblackboardfloat
			};
		}

		// Token: 0x060160B1 RID: 90289 RVA: 0x0032A3FA File Offset: 0x003285FA
		public IBlackBoardIntT AsIBlackBoardInt()
		{
			return this.As<IBlackBoardIntT>();
		}

		// Token: 0x060160B2 RID: 90290 RVA: 0x0032A402 File Offset: 0x00328602
		public static TBlackBoardUnion FromIBlackBoardInt(IBlackBoardIntT _iblackboardint)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardInt,
				Value = _iblackboardint
			};
		}

		// Token: 0x060160B3 RID: 90291 RVA: 0x0032A417 File Offset: 0x00328617
		public IBlackBoardStringT AsIBlackBoardString()
		{
			return this.As<IBlackBoardStringT>();
		}

		// Token: 0x060160B4 RID: 90292 RVA: 0x0032A41F File Offset: 0x0032861F
		public static TBlackBoardUnion FromIBlackBoardString(IBlackBoardStringT _iblackboardstring)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardString,
				Value = _iblackboardstring
			};
		}

		// Token: 0x060160B5 RID: 90293 RVA: 0x0032A434 File Offset: 0x00328634
		public IBlackBoardVectorT AsIBlackBoardVector()
		{
			return this.As<IBlackBoardVectorT>();
		}

		// Token: 0x060160B6 RID: 90294 RVA: 0x0032A43C File Offset: 0x0032863C
		public static TBlackBoardUnion FromIBlackBoardVector(IBlackBoardVectorT _iblackboardvector)
		{
			return new TBlackBoardUnion
			{
				Type = TBlackBoard.IBlackBoardVector,
				Value = _iblackboardvector
			};
		}

		// Token: 0x060160B7 RID: 90295 RVA: 0x0032A454 File Offset: 0x00328654
		public static int Pack(FlatBufferBuilder builder, TBlackBoardUnion _o)
		{
			switch (_o.Type)
			{
			case TBlackBoard.IBlackBoardBoolean:
				return IBlackBoardBoolean.Pack(builder, _o.AsIBlackBoardBoolean()).Value;
			case TBlackBoard.IBlackBoardEntityId:
				return IBlackBoardEntityId.Pack(builder, _o.AsIBlackBoardEntityId()).Value;
			case TBlackBoard.IBlackBoardEntityPos:
				return IBlackBoardEntityPos.Pack(builder, _o.AsIBlackBoardEntityPos()).Value;
			case TBlackBoard.IBlackBoardFloat:
				return IBlackBoardFloat.Pack(builder, _o.AsIBlackBoardFloat()).Value;
			case TBlackBoard.IBlackBoardInt:
				return IBlackBoardInt.Pack(builder, _o.AsIBlackBoardInt()).Value;
			case TBlackBoard.IBlackBoardString:
				return IBlackBoardString.Pack(builder, _o.AsIBlackBoardString()).Value;
			case TBlackBoard.IBlackBoardVector:
				return IBlackBoardVector.Pack(builder, _o.AsIBlackBoardVector()).Value;
			default:
				return 0;
			}
		}
	}
}
