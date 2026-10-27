using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A7F RID: 23167
	public struct ITimelineTrackControlData : IFlatbufferObject
	{
		// Token: 0x1700AE81 RID: 44673
		// (get) Token: 0x0602775B RID: 161627 RVA: 0x0056E0E3 File Offset: 0x0056C2E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602775C RID: 161628 RVA: 0x0056E0F0 File Offset: 0x0056C2F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602775D RID: 161629 RVA: 0x0056E0F8 File Offset: 0x0056C2F8
		public static ITimelineTrackControlData GetRootAsITimelineTrackControlData(ByteBuffer _bb)
		{
			return ITimelineTrackControlData.GetRootAsITimelineTrackControlData(_bb, default(ITimelineTrackControlData));
		}

		// Token: 0x0602775E RID: 161630 RVA: 0x0056E114 File Offset: 0x0056C314
		public static ITimelineTrackControlData GetRootAsITimelineTrackControlData(ByteBuffer _bb, ITimelineTrackControlData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602775F RID: 161631 RVA: 0x0056E131 File Offset: 0x0056C331
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027760 RID: 161632 RVA: 0x0056E140 File Offset: 0x0056C340
		public ITimelineTrackControlData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AE82 RID: 44674
		// (get) Token: 0x06027761 RID: 161633 RVA: 0x0056E150 File Offset: 0x0056C350
		public ETrackControlMode Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETrackControlMode.Sequence;
				}
				return (ETrackControlMode)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06027762 RID: 161634 RVA: 0x0056E18C File Offset: 0x0056C38C
		public static Offset<ITimelineTrackControlData> CreateITimelineTrackControlData(FlatBufferBuilder builder, ETrackControlMode Type = ETrackControlMode.Sequence)
		{
			builder.StartTable(1);
			ITimelineTrackControlData.AddType(builder, Type);
			return ITimelineTrackControlData.EndITimelineTrackControlData(builder);
		}

		// Token: 0x06027763 RID: 161635 RVA: 0x0056E1A2 File Offset: 0x0056C3A2
		public static void StartITimelineTrackControlData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027764 RID: 161636 RVA: 0x0056E1AB File Offset: 0x0056C3AB
		public static void AddType(FlatBufferBuilder builder, ETrackControlMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027765 RID: 161637 RVA: 0x0056E1B6 File Offset: 0x0056C3B6
		public static Offset<ITimelineTrackControlData> EndITimelineTrackControlData(FlatBufferBuilder builder)
		{
			return new Offset<ITimelineTrackControlData>(builder.EndTable());
		}

		// Token: 0x06027766 RID: 161638 RVA: 0x0056E1C4 File Offset: 0x0056C3C4
		public ITimelineTrackControlDataT UnPack()
		{
			ITimelineTrackControlDataT timelineTrackControlDataT = new ITimelineTrackControlDataT();
			this.UnPackTo(timelineTrackControlDataT);
			return timelineTrackControlDataT;
		}

		// Token: 0x06027767 RID: 161639 RVA: 0x0056E1DF File Offset: 0x0056C3DF
		public void UnPackTo(ITimelineTrackControlDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06027768 RID: 161640 RVA: 0x0056E1F0 File Offset: 0x0056C3F0
		public static Offset<ITimelineTrackControlData> Pack(FlatBufferBuilder builder, ITimelineTrackControlDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimelineTrackControlData>);
			}
			return ITimelineTrackControlData.CreateITimelineTrackControlData(builder, _o.Type);
		}

		// Token: 0x0400F131 RID: 61745
		private Table __p;
	}
}
