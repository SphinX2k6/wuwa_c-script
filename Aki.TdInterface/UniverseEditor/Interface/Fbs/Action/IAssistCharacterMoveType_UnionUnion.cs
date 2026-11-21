using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006809 RID: 26633
	public class IAssistCharacterMoveType_UnionUnion
	{
		// Token: 0x1700C3C2 RID: 50114
		// (get) Token: 0x0602D7DB RID: 186331 RVA: 0x0063A42D File Offset: 0x0063862D
		// (set) Token: 0x0602D7DC RID: 186332 RVA: 0x0063A435 File Offset: 0x00638635
		public IAssistCharacterMoveType_Union Type { get; set; }

		// Token: 0x1700C3C3 RID: 50115
		// (get) Token: 0x0602D7DD RID: 186333 RVA: 0x0063A43E File Offset: 0x0063863E
		// (set) Token: 0x0602D7DE RID: 186334 RVA: 0x0063A446 File Offset: 0x00638646
		public object Value { get; set; }

		// Token: 0x0602D7DF RID: 186335 RVA: 0x0063A44F File Offset: 0x0063864F
		public IAssistCharacterMoveType_UnionUnion()
		{
			this.Type = IAssistCharacterMoveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D7E0 RID: 186336 RVA: 0x0063A465 File Offset: 0x00638665
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D7E1 RID: 186337 RVA: 0x0063A477 File Offset: 0x00638677
		public IAssistCharacterMoveTypeT AsIAssistCharacterMoveType()
		{
			return this.As<IAssistCharacterMoveTypeT>();
		}

		// Token: 0x0602D7E2 RID: 186338 RVA: 0x0063A47F File Offset: 0x0063867F
		public static IAssistCharacterMoveType_UnionUnion FromIAssistCharacterMoveType(IAssistCharacterMoveTypeT _iassistcharactermovetype)
		{
			return new IAssistCharacterMoveType_UnionUnion
			{
				Type = IAssistCharacterMoveType_Union.IAssistCharacterMoveType,
				Value = _iassistcharactermovetype
			};
		}

		// Token: 0x0602D7E3 RID: 186339 RVA: 0x0063A494 File Offset: 0x00638694
		public IAssistCharacterNavigationMoveT AsIAssistCharacterNavigationMove()
		{
			return this.As<IAssistCharacterNavigationMoveT>();
		}

		// Token: 0x0602D7E4 RID: 186340 RVA: 0x0063A49C File Offset: 0x0063869C
		public static IAssistCharacterMoveType_UnionUnion FromIAssistCharacterNavigationMove(IAssistCharacterNavigationMoveT _iassistcharacternavigationmove)
		{
			return new IAssistCharacterMoveType_UnionUnion
			{
				Type = IAssistCharacterMoveType_Union.IAssistCharacterNavigationMove,
				Value = _iassistcharacternavigationmove
			};
		}

		// Token: 0x0602D7E5 RID: 186341 RVA: 0x0063A4B1 File Offset: 0x006386B1
		public IAssistCharacterSplineMoveT AsIAssistCharacterSplineMove()
		{
			return this.As<IAssistCharacterSplineMoveT>();
		}

		// Token: 0x0602D7E6 RID: 186342 RVA: 0x0063A4B9 File Offset: 0x006386B9
		public static IAssistCharacterMoveType_UnionUnion FromIAssistCharacterSplineMove(IAssistCharacterSplineMoveT _iassistcharactersplinemove)
		{
			return new IAssistCharacterMoveType_UnionUnion
			{
				Type = IAssistCharacterMoveType_Union.IAssistCharacterSplineMove,
				Value = _iassistcharactersplinemove
			};
		}

		// Token: 0x0602D7E7 RID: 186343 RVA: 0x0063A4D0 File Offset: 0x006386D0
		public static int Pack(FlatBufferBuilder builder, IAssistCharacterMoveType_UnionUnion _o)
		{
			switch (_o.Type)
			{
			case IAssistCharacterMoveType_Union.IAssistCharacterMoveType:
				return IAssistCharacterMoveType.Pack(builder, _o.AsIAssistCharacterMoveType()).Value;
			case IAssistCharacterMoveType_Union.IAssistCharacterNavigationMove:
				return IAssistCharacterNavigationMove.Pack(builder, _o.AsIAssistCharacterNavigationMove()).Value;
			case IAssistCharacterMoveType_Union.IAssistCharacterSplineMove:
				return IAssistCharacterSplineMove.Pack(builder, _o.AsIAssistCharacterSplineMove()).Value;
			default:
				return 0;
			}
		}
	}
}
