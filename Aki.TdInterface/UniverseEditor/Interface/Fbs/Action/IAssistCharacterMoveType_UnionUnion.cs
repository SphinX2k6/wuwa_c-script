using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200619E RID: 24990
	public class IAssistCharacterMoveType_UnionUnion
	{
		// Token: 0x1700BA44 RID: 47684
		// (get) Token: 0x0602B0AA RID: 176298 RVA: 0x005EFBB9 File Offset: 0x005EDDB9
		// (set) Token: 0x0602B0AB RID: 176299 RVA: 0x005EFBC1 File Offset: 0x005EDDC1
		public IAssistCharacterMoveType_Union Type { get; set; }

		// Token: 0x1700BA45 RID: 47685
		// (get) Token: 0x0602B0AC RID: 176300 RVA: 0x005EFBCA File Offset: 0x005EDDCA
		// (set) Token: 0x0602B0AD RID: 176301 RVA: 0x005EFBD2 File Offset: 0x005EDDD2
		public object Value { get; set; }

		// Token: 0x0602B0AE RID: 176302 RVA: 0x005EFBDB File Offset: 0x005EDDDB
		public IAssistCharacterMoveType_UnionUnion()
		{
			this.Type = IAssistCharacterMoveType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602B0AF RID: 176303 RVA: 0x005EFBF1 File Offset: 0x005EDDF1
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602B0B0 RID: 176304 RVA: 0x005EFC03 File Offset: 0x005EDE03
		public IAssistCharacterMoveTypeT AsIAssistCharacterMoveType()
		{
			return this.As<IAssistCharacterMoveTypeT>();
		}

		// Token: 0x0602B0B1 RID: 176305 RVA: 0x005EFC0B File Offset: 0x005EDE0B
		public static IAssistCharacterMoveType_UnionUnion FromIAssistCharacterMoveType(IAssistCharacterMoveTypeT _iassistcharactermovetype)
		{
			return new IAssistCharacterMoveType_UnionUnion
			{
				Type = IAssistCharacterMoveType_Union.IAssistCharacterMoveType,
				Value = _iassistcharactermovetype
			};
		}

		// Token: 0x0602B0B2 RID: 176306 RVA: 0x005EFC20 File Offset: 0x005EDE20
		public IAssistCharacterNavigationMoveT AsIAssistCharacterNavigationMove()
		{
			return this.As<IAssistCharacterNavigationMoveT>();
		}

		// Token: 0x0602B0B3 RID: 176307 RVA: 0x005EFC28 File Offset: 0x005EDE28
		public static IAssistCharacterMoveType_UnionUnion FromIAssistCharacterNavigationMove(IAssistCharacterNavigationMoveT _iassistcharacternavigationmove)
		{
			return new IAssistCharacterMoveType_UnionUnion
			{
				Type = IAssistCharacterMoveType_Union.IAssistCharacterNavigationMove,
				Value = _iassistcharacternavigationmove
			};
		}

		// Token: 0x0602B0B4 RID: 176308 RVA: 0x005EFC3D File Offset: 0x005EDE3D
		public IAssistCharacterSplineMoveT AsIAssistCharacterSplineMove()
		{
			return this.As<IAssistCharacterSplineMoveT>();
		}

		// Token: 0x0602B0B5 RID: 176309 RVA: 0x005EFC45 File Offset: 0x005EDE45
		public static IAssistCharacterMoveType_UnionUnion FromIAssistCharacterSplineMove(IAssistCharacterSplineMoveT _iassistcharactersplinemove)
		{
			return new IAssistCharacterMoveType_UnionUnion
			{
				Type = IAssistCharacterMoveType_Union.IAssistCharacterSplineMove,
				Value = _iassistcharactersplinemove
			};
		}

		// Token: 0x0602B0B6 RID: 176310 RVA: 0x005EFC5C File Offset: 0x005EDE5C
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
