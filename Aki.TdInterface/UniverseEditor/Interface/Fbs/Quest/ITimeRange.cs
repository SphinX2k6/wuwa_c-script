using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x020041D5 RID: 16853
	public struct ITimeRange : IFlatbufferObject
	{
		// Token: 0x1700777C RID: 30588
		// (get) Token: 0x06018D38 RID: 101688 RVA: 0x003926B8 File Offset: 0x003908B8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06018D39 RID: 101689 RVA: 0x003926C5 File Offset: 0x003908C5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06018D3A RID: 101690 RVA: 0x003926CC File Offset: 0x003908CC
		public static ITimeRange GetRootAsITimeRange(ByteBuffer _bb)
		{
			return ITimeRange.GetRootAsITimeRange(_bb, default(ITimeRange));
		}

		// Token: 0x06018D3B RID: 101691 RVA: 0x003926E8 File Offset: 0x003908E8
		public static ITimeRange GetRootAsITimeRange(ByteBuffer _bb, ITimeRange obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06018D3C RID: 101692 RVA: 0x00392705 File Offset: 0x00390905
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06018D3D RID: 101693 RVA: 0x00392714 File Offset: 0x00390914
		public ITimeRange __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700777D RID: 30589
		// (get) Token: 0x06018D3E RID: 101694 RVA: 0x00392724 File Offset: 0x00390924
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

		// Token: 0x1700777E RID: 30590
		// (get) Token: 0x06018D3F RID: 101695 RVA: 0x00392784 File Offset: 0x00390984
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

		// Token: 0x06018D40 RID: 101696 RVA: 0x003927E1 File Offset: 0x003909E1
		public static Offset<ITimeRange> CreateITimeRange(FlatBufferBuilder builder, Offset<IDateTime> StartTimeOffset = default(Offset<IDateTime>), Offset<IDateTime> EndTimeOffset = default(Offset<IDateTime>))
		{
			builder.StartTable(2);
			ITimeRange.AddEndTime(builder, EndTimeOffset);
			ITimeRange.AddStartTime(builder, StartTimeOffset);
			return ITimeRange.EndITimeRange(builder);
		}

		// Token: 0x06018D41 RID: 101697 RVA: 0x003927FE File Offset: 0x003909FE
		public static void StartITimeRange(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06018D42 RID: 101698 RVA: 0x00392807 File Offset: 0x00390A07
		public static void AddStartTime(FlatBufferBuilder builder, Offset<IDateTime> startTimeOffset)
		{
			builder.AddOffset(0, startTimeOffset.Value, 0);
		}

		// Token: 0x06018D43 RID: 101699 RVA: 0x00392817 File Offset: 0x00390A17
		public static void AddEndTime(FlatBufferBuilder builder, Offset<IDateTime> endTimeOffset)
		{
			builder.AddOffset(1, endTimeOffset.Value, 0);
		}

		// Token: 0x06018D44 RID: 101700 RVA: 0x00392827 File Offset: 0x00390A27
		public static Offset<ITimeRange> EndITimeRange(FlatBufferBuilder builder)
		{
			return new Offset<ITimeRange>(builder.EndTable());
		}

		// Token: 0x06018D45 RID: 101701 RVA: 0x00392834 File Offset: 0x00390A34
		public ITimeRangeT UnPack()
		{
			ITimeRangeT timeRangeT = new ITimeRangeT();
			this.UnPackTo(timeRangeT);
			return timeRangeT;
		}

		// Token: 0x06018D46 RID: 101702 RVA: 0x00392850 File Offset: 0x00390A50
		public void UnPackTo(ITimeRangeT _o)
		{
			_o.StartTime = ((this.StartTime != null) ? this.StartTime.Value.UnPack() : null);
			_o.EndTime = ((this.EndTime != null) ? this.EndTime.Value.UnPack() : null);
		}

		// Token: 0x06018D47 RID: 101703 RVA: 0x003928BC File Offset: 0x00390ABC
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

		// Token: 0x0400BE1F RID: 48671
		private Table __p;
	}
}
