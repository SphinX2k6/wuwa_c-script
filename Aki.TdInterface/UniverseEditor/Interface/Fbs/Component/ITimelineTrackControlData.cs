using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x0200608C RID: 24716
	public struct ITimelineTrackControlData : IFlatbufferObject
	{
		// Token: 0x1700B7B9 RID: 47033
		// (get) Token: 0x06029CD3 RID: 171219 RVA: 0x005B50EF File Offset: 0x005B32EF
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029CD4 RID: 171220 RVA: 0x005B50FC File Offset: 0x005B32FC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029CD5 RID: 171221 RVA: 0x005B5104 File Offset: 0x005B3304
		public static ITimelineTrackControlData GetRootAsITimelineTrackControlData(ByteBuffer _bb)
		{
			return ITimelineTrackControlData.GetRootAsITimelineTrackControlData(_bb, default(ITimelineTrackControlData));
		}

		// Token: 0x06029CD6 RID: 171222 RVA: 0x005B5120 File Offset: 0x005B3320
		public static ITimelineTrackControlData GetRootAsITimelineTrackControlData(ByteBuffer _bb, ITimelineTrackControlData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029CD7 RID: 171223 RVA: 0x005B513D File Offset: 0x005B333D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029CD8 RID: 171224 RVA: 0x005B514C File Offset: 0x005B334C
		public ITimelineTrackControlData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7BA RID: 47034
		// (get) Token: 0x06029CD9 RID: 171225 RVA: 0x005B515C File Offset: 0x005B335C
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

		// Token: 0x06029CDA RID: 171226 RVA: 0x005B5198 File Offset: 0x005B3398
		public static Offset<ITimelineTrackControlData> CreateITimelineTrackControlData(FlatBufferBuilder builder, ETrackControlMode Type = ETrackControlMode.Sequence)
		{
			builder.StartTable(1);
			ITimelineTrackControlData.AddType(builder, Type);
			return ITimelineTrackControlData.EndITimelineTrackControlData(builder);
		}

		// Token: 0x06029CDB RID: 171227 RVA: 0x005B51AE File Offset: 0x005B33AE
		public static void StartITimelineTrackControlData(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06029CDC RID: 171228 RVA: 0x005B51B7 File Offset: 0x005B33B7
		public static void AddType(FlatBufferBuilder builder, ETrackControlMode type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029CDD RID: 171229 RVA: 0x005B51C2 File Offset: 0x005B33C2
		public static Offset<ITimelineTrackControlData> EndITimelineTrackControlData(FlatBufferBuilder builder)
		{
			return new Offset<ITimelineTrackControlData>(builder.EndTable());
		}

		// Token: 0x06029CDE RID: 171230 RVA: 0x005B51D0 File Offset: 0x005B33D0
		public ITimelineTrackControlDataT UnPack()
		{
			ITimelineTrackControlDataT timelineTrackControlDataT = new ITimelineTrackControlDataT();
			this.UnPackTo(timelineTrackControlDataT);
			return timelineTrackControlDataT;
		}

		// Token: 0x06029CDF RID: 171231 RVA: 0x005B51EB File Offset: 0x005B33EB
		public void UnPackTo(ITimelineTrackControlDataT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06029CE0 RID: 171232 RVA: 0x005B51FC File Offset: 0x005B33FC
		public static Offset<ITimelineTrackControlData> Pack(FlatBufferBuilder builder, ITimelineTrackControlDataT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimelineTrackControlData>);
			}
			return ITimelineTrackControlData.CreateITimelineTrackControlData(builder, _o.Type);
		}

		// Token: 0x0400FE28 RID: 65064
		private Table __p;
	}
}
