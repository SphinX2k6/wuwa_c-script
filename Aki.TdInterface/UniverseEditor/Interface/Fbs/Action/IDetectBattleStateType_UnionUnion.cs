using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006C1E RID: 27678
	public class IDetectBattleStateType_UnionUnion
	{
		// Token: 0x1700CADB RID: 51931
		// (get) Token: 0x0602FA1B RID: 195099 RVA: 0x0067D639 File Offset: 0x0067B839
		// (set) Token: 0x0602FA1C RID: 195100 RVA: 0x0067D641 File Offset: 0x0067B841
		public IDetectBattleStateType_Union Type { get; set; }

		// Token: 0x1700CADC RID: 51932
		// (get) Token: 0x0602FA1D RID: 195101 RVA: 0x0067D64A File Offset: 0x0067B84A
		// (set) Token: 0x0602FA1E RID: 195102 RVA: 0x0067D652 File Offset: 0x0067B852
		public object Value { get; set; }

		// Token: 0x0602FA1F RID: 195103 RVA: 0x0067D65B File Offset: 0x0067B85B
		public IDetectBattleStateType_UnionUnion()
		{
			this.Type = IDetectBattleStateType_Union.NONE;
			this.Value = null;
		}

		// Token: 0x0602FA20 RID: 195104 RVA: 0x0067D671 File Offset: 0x0067B871
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x0602FA21 RID: 195105 RVA: 0x0067D683 File Offset: 0x0067B883
		public IDetectBattleStateTypeT AsIDetectBattleStateType()
		{
			return this.As<IDetectBattleStateTypeT>();
		}

		// Token: 0x0602FA22 RID: 195106 RVA: 0x0067D68B File Offset: 0x0067B88B
		public static IDetectBattleStateType_UnionUnion FromIDetectBattleStateType(IDetectBattleStateTypeT _idetectbattlestatetype)
		{
			return new IDetectBattleStateType_UnionUnion
			{
				Type = IDetectBattleStateType_Union.IDetectBattleStateType,
				Value = _idetectbattlestatetype
			};
		}

		// Token: 0x0602FA23 RID: 195107 RVA: 0x0067D6A0 File Offset: 0x0067B8A0
		public IDetectBattleTagT AsIDetectBattleTag()
		{
			return this.As<IDetectBattleTagT>();
		}

		// Token: 0x0602FA24 RID: 195108 RVA: 0x0067D6A8 File Offset: 0x0067B8A8
		public static IDetectBattleStateType_UnionUnion FromIDetectBattleTag(IDetectBattleTagT _idetectbattletag)
		{
			return new IDetectBattleStateType_UnionUnion
			{
				Type = IDetectBattleStateType_Union.IDetectBattleTag,
				Value = _idetectbattletag
			};
		}

		// Token: 0x0602FA25 RID: 195109 RVA: 0x0067D6C0 File Offset: 0x0067B8C0
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
