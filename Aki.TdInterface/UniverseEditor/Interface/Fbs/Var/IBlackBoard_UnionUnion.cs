using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003DFD RID: 15869
	public class IBlackBoard_UnionUnion
	{
		// Token: 0x17006B34 RID: 27444
		// (get) Token: 0x06015515 RID: 87317 RVA: 0x00314CA7 File Offset: 0x00312EA7
		// (set) Token: 0x06015516 RID: 87318 RVA: 0x00314CAF File Offset: 0x00312EAF
		public IBlackBoard_Union Type { get; set; }

		// Token: 0x17006B35 RID: 27445
		// (get) Token: 0x06015517 RID: 87319 RVA: 0x00314CB8 File Offset: 0x00312EB8
		// (set) Token: 0x06015518 RID: 87320 RVA: 0x00314CC0 File Offset: 0x00312EC0
		public object Value { get; set; }

		// Token: 0x06015519 RID: 87321 RVA: 0x00314CC9 File Offset: 0x00312EC9
		public IBlackBoard_UnionUnion()
		{
			this.Type = IBlackBoard_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0601551A RID: 87322 RVA: 0x00314CDF File Offset: 0x00312EDF
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0601551B RID: 87323 RVA: 0x00314CF1 File Offset: 0x00312EF1
		public IBlackBoardT AsIBlackBoard()
		{
			return this.As<IBlackBoardT>();
		}

		// Token: 0x0601551C RID: 87324 RVA: 0x00314CF9 File Offset: 0x00312EF9
		public static IBlackBoard_UnionUnion FromIBlackBoard(IBlackBoardT _iblackboard)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoard,
				Value = _iblackboard
			};
		}

		// Token: 0x0601551D RID: 87325 RVA: 0x00314D0E File Offset: 0x00312F0E
		public IBlackBoardBooleanT AsIBlackBoardBoolean()
		{
			return this.As<IBlackBoardBooleanT>();
		}

		// Token: 0x0601551E RID: 87326 RVA: 0x00314D16 File Offset: 0x00312F16
		public static IBlackBoard_UnionUnion FromIBlackBoardBoolean(IBlackBoardBooleanT _iblackboardboolean)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardBoolean,
				Value = _iblackboardboolean
			};
		}

		// Token: 0x0601551F RID: 87327 RVA: 0x00314D2B File Offset: 0x00312F2B
		public IBlackBoardIntT AsIBlackBoardInt()
		{
			return this.As<IBlackBoardIntT>();
		}

		// Token: 0x06015520 RID: 87328 RVA: 0x00314D33 File Offset: 0x00312F33
		public static IBlackBoard_UnionUnion FromIBlackBoardInt(IBlackBoardIntT _iblackboardint)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardInt,
				Value = _iblackboardint
			};
		}

		// Token: 0x06015521 RID: 87329 RVA: 0x00314D48 File Offset: 0x00312F48
		public IBlackBoardEntityIdT AsIBlackBoardEntityId()
		{
			return this.As<IBlackBoardEntityIdT>();
		}

		// Token: 0x06015522 RID: 87330 RVA: 0x00314D50 File Offset: 0x00312F50
		public static IBlackBoard_UnionUnion FromIBlackBoardEntityId(IBlackBoardEntityIdT _iblackboardentityid)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardEntityId,
				Value = _iblackboardentityid
			};
		}

		// Token: 0x06015523 RID: 87331 RVA: 0x00314D65 File Offset: 0x00312F65
		public IBlackBoardFloatT AsIBlackBoardFloat()
		{
			return this.As<IBlackBoardFloatT>();
		}

		// Token: 0x06015524 RID: 87332 RVA: 0x00314D6D File Offset: 0x00312F6D
		public static IBlackBoard_UnionUnion FromIBlackBoardFloat(IBlackBoardFloatT _iblackboardfloat)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardFloat,
				Value = _iblackboardfloat
			};
		}

		// Token: 0x06015525 RID: 87333 RVA: 0x00314D82 File Offset: 0x00312F82
		public IBlackBoardStringT AsIBlackBoardString()
		{
			return this.As<IBlackBoardStringT>();
		}

		// Token: 0x06015526 RID: 87334 RVA: 0x00314D8A File Offset: 0x00312F8A
		public static IBlackBoard_UnionUnion FromIBlackBoardString(IBlackBoardStringT _iblackboardstring)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardString,
				Value = _iblackboardstring
			};
		}

		// Token: 0x06015527 RID: 87335 RVA: 0x00314D9F File Offset: 0x00312F9F
		public IBlackBoardVectorT AsIBlackBoardVector()
		{
			return this.As<IBlackBoardVectorT>();
		}

		// Token: 0x06015528 RID: 87336 RVA: 0x00314DA7 File Offset: 0x00312FA7
		public static IBlackBoard_UnionUnion FromIBlackBoardVector(IBlackBoardVectorT _iblackboardvector)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardVector,
				Value = _iblackboardvector
			};
		}

		// Token: 0x06015529 RID: 87337 RVA: 0x00314DBC File Offset: 0x00312FBC
		public IBlackBoardEntityPosT AsIBlackBoardEntityPos()
		{
			return this.As<IBlackBoardEntityPosT>();
		}

		// Token: 0x0601552A RID: 87338 RVA: 0x00314DC4 File Offset: 0x00312FC4
		public static IBlackBoard_UnionUnion FromIBlackBoardEntityPos(IBlackBoardEntityPosT _iblackboardentitypos)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardEntityPos,
				Value = _iblackboardentitypos
			};
		}

		// Token: 0x0601552B RID: 87339 RVA: 0x00314DDC File Offset: 0x00312FDC
		public static int Pack(FlatBufferBuilder builder, IBlackBoard_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IBlackBoard_Union.IBlackBoard:
				return IBlackBoard.Pack(builder, _o.AsIBlackBoard()).Value;
			case IBlackBoard_Union.IBlackBoardBoolean:
				return IBlackBoardBoolean.Pack(builder, _o.AsIBlackBoardBoolean()).Value;
			case IBlackBoard_Union.IBlackBoardInt:
				return IBlackBoardInt.Pack(builder, _o.AsIBlackBoardInt()).Value;
			case IBlackBoard_Union.IBlackBoardEntityId:
				return IBlackBoardEntityId.Pack(builder, _o.AsIBlackBoardEntityId()).Value;
			case IBlackBoard_Union.IBlackBoardFloat:
				return IBlackBoardFloat.Pack(builder, _o.AsIBlackBoardFloat()).Value;
			case IBlackBoard_Union.IBlackBoardString:
				return IBlackBoardString.Pack(builder, _o.AsIBlackBoardString()).Value;
			case IBlackBoard_Union.IBlackBoardVector:
				return IBlackBoardVector.Pack(builder, _o.AsIBlackBoardVector()).Value;
			case IBlackBoard_Union.IBlackBoardEntityPos:
				return IBlackBoardEntityPos.Pack(builder, _o.AsIBlackBoardEntityPos()).Value;
			default:
				return 0;
			}
		}
	}
}
