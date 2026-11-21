using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060C2 RID: 24770
	public class ITimeScheduleRefreshPosition_UnionUnion
	{
		// Token: 0x1700B81A RID: 47130
		// (get) Token: 0x06029E80 RID: 171648 RVA: 0x005B83DD File Offset: 0x005B65DD
		// (set) Token: 0x06029E81 RID: 171649 RVA: 0x005B83E5 File Offset: 0x005B65E5
		public ITimeScheduleRefreshPosition_Union Type { get; set; }

		// Token: 0x1700B81B RID: 47131
		// (get) Token: 0x06029E82 RID: 171650 RVA: 0x005B83EE File Offset: 0x005B65EE
		// (set) Token: 0x06029E83 RID: 171651 RVA: 0x005B83F6 File Offset: 0x005B65F6
		public object Value { get; set; }

		// Token: 0x06029E84 RID: 171652 RVA: 0x005B83FF File Offset: 0x005B65FF
		public ITimeScheduleRefreshPosition_UnionUnion()
		{
			this.Type = ITimeScheduleRefreshPosition_Union.NONE;
			this.Value = null;
		}

		// Token: 0x06029E85 RID: 171653 RVA: 0x005B8415 File Offset: 0x005B6615
		public T As<T>() where T : class
		{
			return this.Value as T;
		}

		// Token: 0x06029E86 RID: 171654 RVA: 0x005B8427 File Offset: 0x005B6627
		public ITimeScheduleRefreshPositionT AsITimeScheduleRefreshPosition()
		{
			return this.As<ITimeScheduleRefreshPositionT>();
		}

		// Token: 0x06029E87 RID: 171655 RVA: 0x005B842F File Offset: 0x005B662F
		public static ITimeScheduleRefreshPosition_UnionUnion FromITimeScheduleRefreshPosition(ITimeScheduleRefreshPositionT _itimeschedulerefreshposition)
		{
			return new ITimeScheduleRefreshPosition_UnionUnion
			{
				Type = ITimeScheduleRefreshPosition_Union.ITimeScheduleRefreshPosition,
				Value = _itimeschedulerefreshposition
			};
		}

		// Token: 0x06029E88 RID: 171656 RVA: 0x005B8444 File Offset: 0x005B6644
		public ITimeScheduleFixedPositionsT AsITimeScheduleFixedPositions()
		{
			return this.As<ITimeScheduleFixedPositionsT>();
		}

		// Token: 0x06029E89 RID: 171657 RVA: 0x005B844C File Offset: 0x005B664C
		public static ITimeScheduleRefreshPosition_UnionUnion FromITimeScheduleFixedPositions(ITimeScheduleFixedPositionsT _itimeschedulefixedpositions)
		{
			return new ITimeScheduleRefreshPosition_UnionUnion
			{
				Type = ITimeScheduleRefreshPosition_Union.ITimeScheduleFixedPositions,
				Value = _itimeschedulefixedpositions
			};
		}

		// Token: 0x06029E8A RID: 171658 RVA: 0x005B8464 File Offset: 0x005B6664
		public static int Pack(FlatBufferBuilder builder, ITimeScheduleRefreshPosition_UnionUnion _o)
		{
			ITimeScheduleRefreshPosition_Union type = _o.Type;
			if (type == ITimeScheduleRefreshPosition_Union.ITimeScheduleRefreshPosition)
			{
				return ITimeScheduleRefreshPosition.Pack(builder, _o.AsITimeScheduleRefreshPosition()).Value;
			}
			if (type != ITimeScheduleRefreshPosition_Union.ITimeScheduleFixedPositions)
			{
				return 0;
			}
			return ITimeScheduleFixedPositions.Pack(builder, _o.AsITimeScheduleFixedPositions()).Value;
		}
	}
}
