using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AB1 RID: 23217
	public struct ITimeScheduleRefreshConfig : IFlatbufferObject
	{
		// Token: 0x1700AEDB RID: 44763
		// (get) Token: 0x060278E8 RID: 162024 RVA: 0x00570F7D File Offset: 0x0056F17D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060278E9 RID: 162025 RVA: 0x00570F8A File Offset: 0x0056F18A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060278EA RID: 162026 RVA: 0x00570F94 File Offset: 0x0056F194
		public static ITimeScheduleRefreshConfig GetRootAsITimeScheduleRefreshConfig(ByteBuffer _bb)
		{
			return ITimeScheduleRefreshConfig.GetRootAsITimeScheduleRefreshConfig(_bb, default(ITimeScheduleRefreshConfig));
		}

		// Token: 0x060278EB RID: 162027 RVA: 0x00570FB0 File Offset: 0x0056F1B0
		public static ITimeScheduleRefreshConfig GetRootAsITimeScheduleRefreshConfig(ByteBuffer _bb, ITimeScheduleRefreshConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060278EC RID: 162028 RVA: 0x00570FCD File Offset: 0x0056F1CD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060278ED RID: 162029 RVA: 0x00570FDC File Offset: 0x0056F1DC
		public ITimeScheduleRefreshConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEDC RID: 44764
		// (get) Token: 0x060278EE RID: 162030 RVA: 0x00570FEC File Offset: 0x0056F1EC
		public ETimeScheduleRefreshType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ETimeScheduleRefreshType.GameDaily;
				}
				return (ETimeScheduleRefreshType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060278EF RID: 162031 RVA: 0x00571028 File Offset: 0x0056F228
		public static Offset<ITimeScheduleRefreshConfig> CreateITimeScheduleRefreshConfig(FlatBufferBuilder builder, ETimeScheduleRefreshType Type = ETimeScheduleRefreshType.GameDaily)
		{
			builder.StartTable(1);
			ITimeScheduleRefreshConfig.AddType(builder, Type);
			return ITimeScheduleRefreshConfig.EndITimeScheduleRefreshConfig(builder);
		}

		// Token: 0x060278F0 RID: 162032 RVA: 0x0057103E File Offset: 0x0056F23E
		public static void StartITimeScheduleRefreshConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060278F1 RID: 162033 RVA: 0x00571047 File Offset: 0x0056F247
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060278F2 RID: 162034 RVA: 0x00571052 File Offset: 0x0056F252
		public static Offset<ITimeScheduleRefreshConfig> EndITimeScheduleRefreshConfig(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleRefreshConfig>(builder.EndTable());
		}

		// Token: 0x060278F3 RID: 162035 RVA: 0x00571060 File Offset: 0x0056F260
		public ITimeScheduleRefreshConfigT UnPack()
		{
			ITimeScheduleRefreshConfigT timeScheduleRefreshConfigT = new ITimeScheduleRefreshConfigT();
			this.UnPackTo(timeScheduleRefreshConfigT);
			return timeScheduleRefreshConfigT;
		}

		// Token: 0x060278F4 RID: 162036 RVA: 0x0057107B File Offset: 0x0056F27B
		public void UnPackTo(ITimeScheduleRefreshConfigT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060278F5 RID: 162037 RVA: 0x0057108C File Offset: 0x0056F28C
		public static Offset<ITimeScheduleRefreshConfig> Pack(FlatBufferBuilder builder, ITimeScheduleRefreshConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleRefreshConfig>);
			}
			return ITimeScheduleRefreshConfig.CreateITimeScheduleRefreshConfig(builder, _o.Type);
		}

		// Token: 0x0400F175 RID: 61813
		private Table __p;
	}
}
