using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x0200462E RID: 17966
	public struct ITimeRange : IFlatbufferObject
	{
		// Token: 0x17007DA8 RID: 32168
		// (get) Token: 0x0601A48E RID: 107662 RVA: 0x003BDB0C File Offset: 0x003BBD0C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601A48F RID: 107663 RVA: 0x003BDB19 File Offset: 0x003BBD19
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601A490 RID: 107664 RVA: 0x003BDB20 File Offset: 0x003BBD20
		public static ITimeRange GetRootAsITimeRange(ByteBuffer _bb)
		{
			return ITimeRange.GetRootAsITimeRange(_bb, default(ITimeRange));
		}

		// Token: 0x0601A491 RID: 107665 RVA: 0x003BDB3C File Offset: 0x003BBD3C
		public static ITimeRange GetRootAsITimeRange(ByteBuffer _bb, ITimeRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601A492 RID: 107666 RVA: 0x003BDB59 File Offset: 0x003BBD59
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601A493 RID: 107667 RVA: 0x003BDB68 File Offset: 0x003BBD68
		public ITimeRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007DA9 RID: 32169
		// (get) Token: 0x0601A494 RID: 107668 RVA: 0x003BDB78 File Offset: 0x003BBD78
		public IDateTime? StartTime
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IDateTime?(default(IDateTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17007DAA RID: 32170
		// (get) Token: 0x0601A495 RID: 107669 RVA: 0x003BDBD8 File Offset: 0x003BBDD8
		public IDateTime? EndTime
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new IDateTime?(default(IDateTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0601A496 RID: 107670 RVA: 0x003BDC35 File Offset: 0x003BBE35
		public static Offset<ITimeRange> CreateITimeRange(FlatBufferBuilder builder, Offset<IDateTime> StartTimeOffset = default(Offset<IDateTime>), Offset<IDateTime> EndTimeOffset = default(Offset<IDateTime>))
		{
			builder.StartTable(2);
			ITimeRange.AddEndTime(builder, EndTimeOffset);
			ITimeRange.AddStartTime(builder, StartTimeOffset);
			return ITimeRange.EndITimeRange(builder);
		}

		// Token: 0x0601A497 RID: 107671 RVA: 0x003BDC52 File Offset: 0x003BBE52
		public static void StartITimeRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601A498 RID: 107672 RVA: 0x003BDC5B File Offset: 0x003BBE5B
		public static void AddStartTime(FlatBufferBuilder builder, Offset<IDateTime> startTimeOffset)
		{
			builder.AddOffset(0, startTimeOffset.Value, 0);
		}

		// Token: 0x0601A499 RID: 107673 RVA: 0x003BDC6B File Offset: 0x003BBE6B
		public static void AddEndTime(FlatBufferBuilder builder, Offset<IDateTime> endTimeOffset)
		{
			builder.AddOffset(1, endTimeOffset.Value, 0);
		}

		// Token: 0x0601A49A RID: 107674 RVA: 0x003BDC7B File Offset: 0x003BBE7B
		public static Offset<ITimeRange> EndITimeRange(FlatBufferBuilder builder)
		{
			return new Offset<ITimeRange>(builder.EndTable());
		}

		// Token: 0x0601A49B RID: 107675 RVA: 0x003BDC88 File Offset: 0x003BBE88
		public ITimeRangeT UnPack()
		{
			ITimeRangeT timeRangeT = new ITimeRangeT();
			this.UnPackTo(timeRangeT);
			return timeRangeT;
		}

		// Token: 0x0601A49C RID: 107676 RVA: 0x003BDCA4 File Offset: 0x003BBEA4
		public void UnPackTo(ITimeRangeT _o)
		{
			_o.StartTime = ((this.StartTime != null) ? this.StartTime.Value.UnPack() : null);
			_o.EndTime = ((this.EndTime != null) ? this.EndTime.Value.UnPack() : null);
		}

		// Token: 0x0601A49D RID: 107677 RVA: 0x003BDD10 File Offset: 0x003BBF10
		public static Offset<ITimeRange> Pack(FlatBufferBuilder builder, ITimeRangeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeRange>);
			}
			Offset<IDateTime> startTimeOffset = (_o.StartTime == null) ? default(Offset<IDateTime>) : IDateTime.Pack(builder, _o.StartTime);
			Offset<IDateTime> endTimeOffset = (_o.EndTime == null) ? default(Offset<IDateTime>) : IDateTime.Pack(builder, _o.EndTime);
			return ITimeRange.CreateITimeRange(builder, startTimeOffset, endTimeOffset);
		}

		// Token: 0x0400C829 RID: 51241
		private Table __p;
	}
}
