using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005A9F RID: 23199
	public struct ITimeScheduleGameDailyRefresh : IFlatbufferObject
	{
		// Token: 0x1700AEC0 RID: 44736
		// (get) Token: 0x0602786E RID: 161902 RVA: 0x005701DD File Offset: 0x0056E3DD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602786F RID: 161903 RVA: 0x005701EA File Offset: 0x0056E3EA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027870 RID: 161904 RVA: 0x005701F4 File Offset: 0x0056E3F4
		public static ITimeScheduleGameDailyRefresh GetRootAsITimeScheduleGameDailyRefresh(ByteBuffer _bb)
		{
			return ITimeScheduleGameDailyRefresh.GetRootAsITimeScheduleGameDailyRefresh(_bb, default(ITimeScheduleGameDailyRefresh));
		}

		// Token: 0x06027871 RID: 161905 RVA: 0x00570210 File Offset: 0x0056E410
		public static ITimeScheduleGameDailyRefresh GetRootAsITimeScheduleGameDailyRefresh(ByteBuffer _bb, ITimeScheduleGameDailyRefresh obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027872 RID: 161906 RVA: 0x0057022D File Offset: 0x0056E42D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027873 RID: 161907 RVA: 0x0057023C File Offset: 0x0056E43C
		public ITimeScheduleGameDailyRefresh __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AEC1 RID: 44737
		// (get) Token: 0x06027874 RID: 161908 RVA: 0x0057024C File Offset: 0x0056E44C
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

		// Token: 0x06027875 RID: 161909 RVA: 0x00570288 File Offset: 0x0056E488
		public static Offset<ITimeScheduleGameDailyRefresh> CreateITimeScheduleGameDailyRefresh(FlatBufferBuilder builder, ETimeScheduleRefreshType Type = ETimeScheduleRefreshType.GameDaily)
		{
			builder.StartTable(1);
			ITimeScheduleGameDailyRefresh.AddType(builder, Type);
			return ITimeScheduleGameDailyRefresh.EndITimeScheduleGameDailyRefresh(builder);
		}

		// Token: 0x06027876 RID: 161910 RVA: 0x0057029E File Offset: 0x0056E49E
		public static void StartITimeScheduleGameDailyRefresh(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06027877 RID: 161911 RVA: 0x005702A7 File Offset: 0x0056E4A7
		public static void AddType(FlatBufferBuilder builder, ETimeScheduleRefreshType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06027878 RID: 161912 RVA: 0x005702B2 File Offset: 0x0056E4B2
		public static Offset<ITimeScheduleGameDailyRefresh> EndITimeScheduleGameDailyRefresh(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleGameDailyRefresh>(builder.EndTable());
		}

		// Token: 0x06027879 RID: 161913 RVA: 0x005702C0 File Offset: 0x0056E4C0
		public ITimeScheduleGameDailyRefreshT UnPack()
		{
			ITimeScheduleGameDailyRefreshT timeScheduleGameDailyRefreshT = new ITimeScheduleGameDailyRefreshT();
			this.UnPackTo(timeScheduleGameDailyRefreshT);
			return timeScheduleGameDailyRefreshT;
		}

		// Token: 0x0602787A RID: 161914 RVA: 0x005702DB File Offset: 0x0056E4DB
		public void UnPackTo(ITimeScheduleGameDailyRefreshT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602787B RID: 161915 RVA: 0x005702EC File Offset: 0x0056E4EC
		public static Offset<ITimeScheduleGameDailyRefresh> Pack(FlatBufferBuilder builder, ITimeScheduleGameDailyRefreshT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleGameDailyRefresh>);
			}
			return ITimeScheduleGameDailyRefresh.CreateITimeScheduleGameDailyRefresh(builder, _o.Type);
		}

		// Token: 0x0400F160 RID: 61792
		private Table __p;
	}
}
