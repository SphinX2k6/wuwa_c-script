using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020077CC RID: 30668
	public class TTalkOptionPreConditionUnion
	{
		// Token: 0x1700E6CB RID: 59083
		// (get) Token: 0x06037A1C RID: 227868 RVA: 0x0078626C File Offset: 0x0078446C
		// (set) Token: 0x06037A1D RID: 227869 RVA: 0x00786274 File Offset: 0x00784474
		public TTalkOptionPreCondition Type { get; set; }

		// Token: 0x1700E6CC RID: 59084
		// (get) Token: 0x06037A1E RID: 227870 RVA: 0x0078627D File Offset: 0x0078447D
		// (set) Token: 0x06037A1F RID: 227871 RVA: 0x00786285 File Offset: 0x00784485
		public object Value { get; set; }

		// Token: 0x06037A20 RID: 227872 RVA: 0x0078628E File Offset: 0x0078448E
		public TTalkOptionPreConditionUnion()
		{
			this.Type = TTalkOptionPreCondition.NONE;
			this.Value = null;
		}

		// Token: 0x06037A21 RID: 227873 RVA: 0x007862A4 File Offset: 0x007844A4
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06037A22 RID: 227874 RVA: 0x007862B6 File Offset: 0x007844B6
		public ITalkOptionConditionT AsITalkOptionCondition()
		{
			return this.As<ITalkOptionConditionT>();
		}

		// Token: 0x06037A23 RID: 227875 RVA: 0x007862BE File Offset: 0x007844BE
		public static TTalkOptionPreConditionUnion FromITalkOptionCondition(ITalkOptionConditionT _italkoptioncondition)
		{
			return new TTalkOptionPreConditionUnion
			{
				Type = TTalkOptionPreCondition.ITalkOptionCondition,
				Value = _italkoptioncondition
			};
		}

		// Token: 0x06037A24 RID: 227876 RVA: 0x007862D3 File Offset: 0x007844D3
		public ITalkOptionFirstSelectT AsITalkOptionFirstSelect()
		{
			return this.As<ITalkOptionFirstSelectT>();
		}

		// Token: 0x06037A25 RID: 227877 RVA: 0x007862DB File Offset: 0x007844DB
		public static TTalkOptionPreConditionUnion FromITalkOptionFirstSelect(ITalkOptionFirstSelectT _italkoptionfirstselect)
		{
			return new TTalkOptionPreConditionUnion
			{
				Type = TTalkOptionPreCondition.ITalkOptionFirstSelect,
				Value = _italkoptionfirstselect
			};
		}

		// Token: 0x06037A26 RID: 227878 RVA: 0x007862F0 File Offset: 0x007844F0
		public ITalkOptionPreOptionT AsITalkOptionPreOption()
		{
			return this.As<ITalkOptionPreOptionT>();
		}

		// Token: 0x06037A27 RID: 227879 RVA: 0x007862F8 File Offset: 0x007844F8
		public static TTalkOptionPreConditionUnion FromITalkOptionPreOption(ITalkOptionPreOptionT _italkoptionpreoption)
		{
			return new TTalkOptionPreConditionUnion
			{
				Type = TTalkOptionPreCondition.ITalkOptionPreOption,
				Value = _italkoptionpreoption
			};
		}

		// Token: 0x06037A28 RID: 227880 RVA: 0x0078630D File Offset: 0x0078450D
		public ITalkOptionSystemConditionT AsITalkOptionSystemCondition()
		{
			return this.As<ITalkOptionSystemConditionT>();
		}

		// Token: 0x06037A29 RID: 227881 RVA: 0x00786315 File Offset: 0x00784515
		public static TTalkOptionPreConditionUnion FromITalkOptionSystemCondition(ITalkOptionSystemConditionT _italkoptionsystemcondition)
		{
			return new TTalkOptionPreConditionUnion
			{
				Type = TTalkOptionPreCondition.ITalkOptionSystemCondition,
				Value = _italkoptionsystemcondition
			};
		}

		// Token: 0x06037A2A RID: 227882 RVA: 0x0078632C File Offset: 0x0078452C
		public static int Pack(FlatBufferBuilder builder, TTalkOptionPreConditionUnion _o)
		{
			switch (_o.Type)
			{
			case TTalkOptionPreCondition.ITalkOptionCondition:
				return ITalkOptionCondition.Pack(builder, _o.AsITalkOptionCondition()).Value;
			case TTalkOptionPreCondition.ITalkOptionFirstSelect:
				return ITalkOptionFirstSelect.Pack(builder, _o.AsITalkOptionFirstSelect()).Value;
			case TTalkOptionPreCondition.ITalkOptionPreOption:
				return ITalkOptionPreOption.Pack(builder, _o.AsITalkOptionPreOption()).Value;
			case TTalkOptionPreCondition.ITalkOptionSystemCondition:
				return ITalkOptionSystemCondition.Pack(builder, _o.AsITalkOptionSystemCondition()).Value;
			default:
				return 0;
			}
		}
	}
}
