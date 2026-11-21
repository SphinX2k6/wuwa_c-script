using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020060A6 RID: 24742
	public struct ITimeScheduleFixedIntervalRefresh : IFlatbufferObject
	{
		// Token: 0x1700B7F3 RID: 47091
		// (get) Token: 0x06029DC8 RID: 171464 RVA: 0x005B6F75 File Offset: 0x005B5175
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06029DC9 RID: 171465 RVA: 0x005B6F82 File Offset: 0x005B5182
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06029DCA RID: 171466 RVA: 0x005B6F8C File Offset: 0x005B518C
		public static ITimeScheduleFixedIntervalRefresh GetRootAsITimeScheduleFixedIntervalRefresh(ByteBuffer _bb)
		{
			return ITimeScheduleFixedIntervalRefresh.GetRootAsITimeScheduleFixedIntervalRefresh(_bb, default(ITimeScheduleFixedIntervalRefresh));
		}

		// Token: 0x06029DCB RID: 171467 RVA: 0x005B6FA8 File Offset: 0x005B51A8
		public static ITimeScheduleFixedIntervalRefresh GetRootAsITimeScheduleFixedIntervalRefresh(ByteBuffer _bb, ITimeScheduleFixedIntervalRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06029DCC RID: 171468 RVA: 0x005B6FC5 File Offset: 0x005B51C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06029DCD RID: 171469 RVA: 0x005B6FD4 File Offset: 0x005B51D4
		public ITimeScheduleFixedIntervalRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700B7F4 RID: 47092
		// (get) Token: 0x06029DCE RID: 171470 RVA: 0x005B6FE4 File Offset: 0x005B51E4
		public ETimeScheduleGenerateType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleGenerateType.FixedIntervalRefresh;
				}
				return (ETimeScheduleGenerateType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B7F5 RID: 47093
		// (get) Token: 0x06029DCF RID: 171471 RVA: 0x005B7020 File Offset: 0x005B5220
		public ITimeScheduleRefreshInterval? RefreshInterval
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScheduleRefreshInterval?(default(ITimeScheduleRefreshInterval).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700B7F6 RID: 47094
		// (get) Token: 0x06029DD0 RID: 171472 RVA: 0x005B7080 File Offset: 0x005B5280
		public int RefreshCount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700B7F7 RID: 47095
		// (get) Token: 0x06029DD1 RID: 171473 RVA: 0x005B70BC File Offset: 0x005B52BC
		public ITimeScheduleFixedPositions? RefreshPosition
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScheduleFixedPositions?(default(ITimeScheduleFixedPositions).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06029DD2 RID: 171474 RVA: 0x005B711A File Offset: 0x005B531A
		public static Offset<ITimeScheduleFixedIntervalRefresh> CreateITimeScheduleFixedIntervalRefresh(FlatBufferBuilder builder, ETimeScheduleGenerateType Type = ETimeScheduleGenerateType.FixedIntervalRefresh, Offset<ITimeScheduleRefreshInterval> RefreshIntervalOffset = default(Offset<ITimeScheduleRefreshInterval>), int RefreshCount = 0, Offset<ITimeScheduleFixedPositions> RefreshPositionOffset = default(Offset<ITimeScheduleFixedPositions>))
		{
			builder.StartTable(4);
			ITimeScheduleFixedIntervalRefresh.AddRefreshPosition(builder, RefreshPositionOffset);
			ITimeScheduleFixedIntervalRefresh.AddRefreshCount(builder, RefreshCount);
			ITimeScheduleFixedIntervalRefresh.AddRefreshInterval(builder, RefreshIntervalOffset);
			ITimeScheduleFixedIntervalRefresh.AddType(builder, Type);
			return ITimeScheduleFixedIntervalRefresh.EndITimeScheduleFixedIntervalRefresh(builder);
		}

		// Token: 0x06029DD3 RID: 171475 RVA: 0x005B7146 File Offset: 0x005B5346
		public static void StartITimeScheduleFixedIntervalRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06029DD4 RID: 171476 RVA: 0x005B714F File Offset: 0x005B534F
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleGenerateType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06029DD5 RID: 171477 RVA: 0x005B715A File Offset: 0x005B535A
		public static void AddRefreshInterval(FlatBufferBuilder builder, Offset<ITimeScheduleRefreshInterval> refreshIntervalOffset)
		{
			builder.AddOffset(1, refreshIntervalOffset.Value, 0);
		}

		// Token: 0x06029DD6 RID: 171478 RVA: 0x005B716A File Offset: 0x005B536A
		public static void AddRefreshCount(FlatBufferBuilder builder, int refreshCount)
		{
			builder.AddInt(2, refreshCount, 0);
		}

		// Token: 0x06029DD7 RID: 171479 RVA: 0x005B7175 File Offset: 0x005B5375
		public static void AddRefreshPosition(FlatBufferBuilder builder, Offset<ITimeScheduleFixedPositions> refreshPositionOffset)
		{
			builder.AddOffset(3, refreshPositionOffset.Value, 0);
		}

		// Token: 0x06029DD8 RID: 171480 RVA: 0x005B7185 File Offset: 0x005B5385
		public static Offset<ITimeScheduleFixedIntervalRefresh> EndITimeScheduleFixedIntervalRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleFixedIntervalRefresh>(builder.EndTable());
		}

		// Token: 0x06029DD9 RID: 171481 RVA: 0x005B7194 File Offset: 0x005B5394
		public ITimeScheduleFixedIntervalRefreshT UnPack()
		{
			ITimeScheduleFixedIntervalRefreshT timeScheduleFixedIntervalRefreshT = new ITimeScheduleFixedIntervalRefreshT();
			this.UnPackTo(timeScheduleFixedIntervalRefreshT);
			return timeScheduleFixedIntervalRefreshT;
		}

		// Token: 0x06029DDA RID: 171482 RVA: 0x005B71B0 File Offset: 0x005B53B0
		public void UnPackTo(ITimeScheduleFixedIntervalRefreshT _o)
		{
			_o.Type = this.Type;
			_o.RefreshInterval = ((this.RefreshInterval != null) ? this.RefreshInterval.Value.UnPack() : null);
			_o.RefreshCount = this.RefreshCount;
			_o.RefreshPosition = ((this.RefreshPosition != null) ? this.RefreshPosition.Value.UnPack() : null);
		}

		// Token: 0x06029DDB RID: 171483 RVA: 0x005B7234 File Offset: 0x005B5434
		public static Offset<ITimeScheduleFixedIntervalRefresh> Pack(FlatBufferBuilder builder, ITimeScheduleFixedIntervalRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleFixedIntervalRefresh>);
			}
			Offset<ITimeScheduleRefreshInterval> refreshIntervalOffset = (_o.RefreshInterval == null) ? default(Offset<ITimeScheduleRefreshInterval>) : ITimeScheduleRefreshInterval.Pack(builder, _o.RefreshInterval);
			Offset<ITimeScheduleFixedPositions> refreshPositionOffset = (_o.RefreshPosition == null) ? default(Offset<ITimeScheduleFixedPositions>) : ITimeScheduleFixedPositions.Pack(builder, _o.RefreshPosition);
			return ITimeScheduleFixedIntervalRefresh.CreateITimeScheduleFixedIntervalRefresh(builder, _o.Type, refreshIntervalOffset, _o.RefreshCount, refreshPositionOffset);
		}

		// Token: 0x0400FE4F RID: 65103
		private Table __p;
	}
}
