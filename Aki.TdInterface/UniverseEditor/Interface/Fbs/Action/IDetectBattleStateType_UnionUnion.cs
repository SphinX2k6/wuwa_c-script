using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020065B6 RID: 26038
	public class IDetectBattleStateType_UnionUnion
	{
		// Token: 0x1700C14C RID: 49484
		// (get) Token: 0x0602D297 RID: 184983 RVA: 0x00631475 File Offset: 0x0062F675
		// (set) Token: 0x0602D298 RID: 184984 RVA: 0x0063147D File Offset: 0x0062F67D
		public IDetectBattleStateType_Union Type { get; set; }

		// Token: 0x1700C14D RID: 49485
		// (get) Token: 0x0602D299 RID: 184985 RVA: 0x00631486 File Offset: 0x0062F686
		// (set) Token: 0x0602D29A RID: 184986 RVA: 0x0063148E File Offset: 0x0062F68E
		public object Value { get; set; }

		// Token: 0x0602D29B RID: 184987 RVA: 0x00631497 File Offset: 0x0062F697
		public IDetectBattleStateType_UnionUnion()
		{
			this.Type = IDetectBattleStateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602D29C RID: 184988 RVA: 0x006314AD File Offset: 0x0062F6AD
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602D29D RID: 184989 RVA: 0x006314BF File Offset: 0x0062F6BF
		public IDetectBattleStateTypeT AsIDetectBattleStateType()
		{
			return this.As<IDetectBattleStateTypeT>();
		}

		// Token: 0x0602D29E RID: 184990 RVA: 0x006314C7 File Offset: 0x0062F6C7
		public static IDetectBattleStateType_UnionUnion FromIDetectBattleStateType(IDetectBattleStateTypeT _idetectbattlestatetype)
		{
			return new IDetectBattleStateType_UnionUnion
			{
				Type = IDetectBattleStateType_Union.IDetectBattleStateType,
				Value = _idetectbattlestatetype
			};
		}

		// Token: 0x0602D29F RID: 184991 RVA: 0x006314DC File Offset: 0x0062F6DC
		public IDetectBattleTagT AsIDetectBattleTag()
		{
			return this.As<IDetectBattleTagT>();
		}

		// Token: 0x0602D2A0 RID: 184992 RVA: 0x006314E4 File Offset: 0x0062F6E4
		public static IDetectBattleStateType_UnionUnion FromIDetectBattleTag(IDetectBattleTagT _idetectbattletag)
		{
			return new IDetectBattleStateType_UnionUnion
			{
				Type = IDetectBattleStateType_Union.IDetectBattleTag,
				Value = _idetectbattletag
			};
		}

		// Token: 0x0602D2A1 RID: 184993 RVA: 0x006314FC File Offset: 0x0062F6FC
		public static int Pack(FlatBufferBuilder builder, IDetectBattleStateType_UnionUnion _o)
		{
			IDetectBattleStateType_Union type = _o.Type;
			if (type == IDetectBattleStateType_Union.IDetectBattleStateType)
			{
				return IDetectBattleStateType.Pack(builder, _o.AsIDetectBattleStateType()).Value;
			}
			if (type != IDetectBattleStateType_Union.IDetectBattleTag)
			{
				return 0;
			}
			return IDetectBattleTag.Pack(builder, _o.AsIDetectBattleTag()).Value;
		}
	}
}
