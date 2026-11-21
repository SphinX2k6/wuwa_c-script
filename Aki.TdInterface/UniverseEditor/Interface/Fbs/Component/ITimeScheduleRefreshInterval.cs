using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060BB RID: 24763
	public struct ITimeScheduleRefreshInterval : IFlatbufferObject
	{
		// Token: 0x1700B812 RID: 47122
		// (get) Token: 0x06029E58 RID: 171608 RVA: 0x005B8046 File Offset: 0x005B6246
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029E59 RID: 171609 RVA: 0x005B8053 File Offset: 0x005B6253
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029E5A RID: 171610 RVA: 0x005B805C File Offset: 0x005B625C
		public static ITimeScheduleRefreshInterval GetRootAsITimeScheduleRefreshInterval(ByteBuffer _bb)
		{
			return ITimeScheduleRefreshInterval.GetRootAsITimeScheduleRefreshInterval(_bb, default(ITimeScheduleRefreshInterval));
		}

		// Token: 0x06029E5B RID: 171611 RVA: 0x005B8078 File Offset: 0x005B6278
		public static ITimeScheduleRefreshInterval GetRootAsITimeScheduleRefreshInterval(ByteBuffer _bb, ITimeScheduleRefreshInterval obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029E5C RID: 171612 RVA: 0x005B8095 File Offset: 0x005B6295
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029E5D RID: 171613 RVA: 0x005B80A4 File Offset: 0x005B62A4
		public ITimeScheduleRefreshInterval __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B813 RID: 47123
		// (get) Token: 0x06029E5E RID: 171614 RVA: 0x005B80B4 File Offset: 0x005B62B4
		public float MaxInterval
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B814 RID: 47124
		// (get) Token: 0x06029E5F RID: 171615 RVA: 0x005B80F4 File Offset: 0x005B62F4
		public float MinInterval
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06029E60 RID: 171616 RVA: 0x005B8134 File Offset: 0x005B6334
		public static Offset<ITimeScheduleRefreshInterval> CreateITimeScheduleRefreshInterval(FlatBufferBuilder builder, float MaxInterval = 0f, float MinInterval = 0f)
		{
			builder.StartTable(2);
			ITimeScheduleRefreshInterval.AddMinInterval(builder, MinInterval);
			ITimeScheduleRefreshInterval.AddMaxInterval(builder, MaxInterval);
			return ITimeScheduleRefreshInterval.EndITimeScheduleRefreshInterval(builder);
		}

		// Token: 0x06029E61 RID: 171617 RVA: 0x005B8151 File Offset: 0x005B6351
		public static void StartITimeScheduleRefreshInterval(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06029E62 RID: 171618 RVA: 0x005B815A File Offset: 0x005B635A
		public static void AddMaxInterval(FlatBufferBuilder builder, float maxInterval)
		{
			builder.AddFloat(0, maxInterval, 0.0);
		}

		// Token: 0x06029E63 RID: 171619 RVA: 0x005B816D File Offset: 0x005B636D
		public static void AddMinInterval(FlatBufferBuilder builder, float minInterval)
		{
			builder.AddFloat(1, minInterval, 0.0);
		}

		// Token: 0x06029E64 RID: 171620 RVA: 0x005B8180 File Offset: 0x005B6380
		public static Offset<ITimeScheduleRefreshInterval> EndITimeScheduleRefreshInterval(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleRefreshInterval>(builder.EndTable());
		}

		// Token: 0x06029E65 RID: 171621 RVA: 0x005B8190 File Offset: 0x005B6390
		public ITimeScheduleRefreshIntervalT UnPack()
		{
			ITimeScheduleRefreshIntervalT timeScheduleRefreshIntervalT = new ITimeScheduleRefreshIntervalT();
			this.UnPackTo(timeScheduleRefreshIntervalT);
			return timeScheduleRefreshIntervalT;
		}

		// Token: 0x06029E66 RID: 171622 RVA: 0x005B81AB File Offset: 0x005B63AB
		public void UnPackTo(ITimeScheduleRefreshIntervalT _o)
		{
			_o.MaxInterval = this.MaxInterval;
			_o.MinInterval = this.MinInterval;
		}

		// Token: 0x06029E67 RID: 171623 RVA: 0x005B81C8 File Offset: 0x005B63C8
		public static Offset<ITimeScheduleRefreshInterval> Pack(FlatBufferBuilder builder, ITimeScheduleRefreshIntervalT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleRefreshInterval>);
			}
			return ITimeScheduleRefreshInterval.CreateITimeScheduleRefreshInterval(builder, _o.MaxInterval, _o.MinInterval);
		}

		// Token: 0x0400FE6B RID: 65131
		private Table __p;
	}
}
