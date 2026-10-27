using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Var
{
	// Token: 0x02003A22 RID: 14882
	public class IBlackBoard_UnionUnion
	{
		// Token: 0x17006604 RID: 26116
		// (get) Token: 0x060141F9 RID: 82425 RVA: 0x002F1ABB File Offset: 0x002EFCBB
		// (set) Token: 0x060141FA RID: 82426 RVA: 0x002F1AC3 File Offset: 0x002EFCC3
		public IBlackBoard_Union Type { get; set; }

		// Token: 0x17006605 RID: 26117
		// (get) Token: 0x060141FB RID: 82427 RVA: 0x002F1ACC File Offset: 0x002EFCCC
		// (set) Token: 0x060141FC RID: 82428 RVA: 0x002F1AD4 File Offset: 0x002EFCD4
		public object Value { get; set; }

		// Token: 0x060141FD RID: 82429 RVA: 0x002F1ADD File Offset: 0x002EFCDD
		public IBlackBoard_UnionUnion()
		{
			this.Type = IBlackBoard_Union.NONE;
			this.Value = null;
		}

		// Token: 0x060141FE RID: 82430 RVA: 0x002F1AF3 File Offset: 0x002EFCF3
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x060141FF RID: 82431 RVA: 0x002F1B05 File Offset: 0x002EFD05
		public IBlackBoardT AsIBlackBoard()
		{
			return this.As<IBlackBoardT>();
		}

		// Token: 0x06014200 RID: 82432 RVA: 0x002F1B0D File Offset: 0x002EFD0D
		public static IBlackBoard_UnionUnion FromIBlackBoard(IBlackBoardT _iblackboard)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoard,
				Value = _iblackboard
			};
		}

		// Token: 0x06014201 RID: 82433 RVA: 0x002F1B22 File Offset: 0x002EFD22
		public IBlackBoardBooleanT AsIBlackBoardBoolean()
		{
			return this.As<IBlackBoardBooleanT>();
		}

		// Token: 0x06014202 RID: 82434 RVA: 0x002F1B2A File Offset: 0x002EFD2A
		public static IBlackBoard_UnionUnion FromIBlackBoardBoolean(IBlackBoardBooleanT _iblackboardboolean)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardBoolean,
				Value = _iblackboardboolean
			};
		}

		// Token: 0x06014203 RID: 82435 RVA: 0x002F1B3F File Offset: 0x002EFD3F
		public IBlackBoardIntT AsIBlackBoardInt()
		{
			return this.As<IBlackBoardIntT>();
		}

		// Token: 0x06014204 RID: 82436 RVA: 0x002F1B47 File Offset: 0x002EFD47
		public static IBlackBoard_UnionUnion FromIBlackBoardInt(IBlackBoardIntT _iblackboardint)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardInt,
				Value = _iblackboardint
			};
		}

		// Token: 0x06014205 RID: 82437 RVA: 0x002F1B5C File Offset: 0x002EFD5C
		public IBlackBoardEntityIdT AsIBlackBoardEntityId()
		{
			return this.As<IBlackBoardEntityIdT>();
		}

		// Token: 0x06014206 RID: 82438 RVA: 0x002F1B64 File Offset: 0x002EFD64
		public static IBlackBoard_UnionUnion FromIBlackBoardEntityId(IBlackBoardEntityIdT _iblackboardentityid)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardEntityId,
				Value = _iblackboardentityid
			};
		}

		// Token: 0x06014207 RID: 82439 RVA: 0x002F1B79 File Offset: 0x002EFD79
		public IBlackBoardFloatT AsIBlackBoardFloat()
		{
			return this.As<IBlackBoardFloatT>();
		}

		// Token: 0x06014208 RID: 82440 RVA: 0x002F1B81 File Offset: 0x002EFD81
		public static IBlackBoard_UnionUnion FromIBlackBoardFloat(IBlackBoardFloatT _iblackboardfloat)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardFloat,
				Value = _iblackboardfloat
			};
		}

		// Token: 0x06014209 RID: 82441 RVA: 0x002F1B96 File Offset: 0x002EFD96
		public IBlackBoardStringT AsIBlackBoardString()
		{
			return this.As<IBlackBoardStringT>();
		}

		// Token: 0x0601420A RID: 82442 RVA: 0x002F1B9E File Offset: 0x002EFD9E
		public static IBlackBoard_UnionUnion FromIBlackBoardString(IBlackBoardStringT _iblackboardstring)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardString,
				Value = _iblackboardstring
			};
		}

		// Token: 0x0601420B RID: 82443 RVA: 0x002F1BB3 File Offset: 0x002EFDB3
		public IBlackBoardVectorT AsIBlackBoardVector()
		{
			return this.As<IBlackBoardVectorT>();
		}

		// Token: 0x0601420C RID: 82444 RVA: 0x002F1BBB File Offset: 0x002EFDBB
		public static IBlackBoard_UnionUnion FromIBlackBoardVector(IBlackBoardVectorT _iblackboardvector)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardVector,
				Value = _iblackboardvector
			};
		}

		// Token: 0x0601420D RID: 82445 RVA: 0x002F1BD0 File Offset: 0x002EFDD0
		public IBlackBoardEntityPosT AsIBlackBoardEntityPos()
		{
			return this.As<IBlackBoardEntityPosT>();
		}

		// Token: 0x0601420E RID: 82446 RVA: 0x002F1BD8 File Offset: 0x002EFDD8
		public static IBlackBoard_UnionUnion FromIBlackBoardEntityPos(IBlackBoardEntityPosT _iblackboardentitypos)
		{
			return new IBlackBoard_UnionUnion
			{
				Type = IBlackBoard_Union.IBlackBoardEntityPos,
				Value = _iblackboardentitypos
			};
		}

		// Token: 0x0601420F RID: 82447 RVA: 0x002F1BF0 File Offset: 0x002EFDF0
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
