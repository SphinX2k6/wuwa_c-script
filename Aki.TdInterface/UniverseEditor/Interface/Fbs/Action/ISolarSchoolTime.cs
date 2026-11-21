using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007932 RID: 31026
	public struct ISolarSchoolTime : IFlatbufferObject
	{
		// Token: 0x1700E396 RID: 58262
		// (get) Token: 0x06036A2C RID: 223788 RVA: 0x0074F981 File Offset: 0x0074DB81
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036A2D RID: 223789 RVA: 0x0074F98E File Offset: 0x0074DB8E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036A2E RID: 223790 RVA: 0x0074F998 File Offset: 0x0074DB98
		public static ISolarSchoolTime GetRootAsISolarSchoolTime(ByteBuffer _bb)
		{
			return ISolarSchoolTime.GetRootAsISolarSchoolTime(_bb, default(ISolarSchoolTime));
		}

		// Token: 0x06036A2F RID: 223791 RVA: 0x0074F9B4 File Offset: 0x0074DBB4
		public static ISolarSchoolTime GetRootAsISolarSchoolTime(ByteBuffer _bb, ISolarSchoolTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036A30 RID: 223792 RVA: 0x0074F9D1 File Offset: 0x0074DBD1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036A31 RID: 223793 RVA: 0x0074F9E0 File Offset: 0x0074DBE0
		public ISolarSchoolTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E397 RID: 58263
		// (get) Token: 0x06036A32 RID: 223794 RVA: 0x0074F9F0 File Offset: 0x0074DBF0
		public IVisualNovelDate? Date
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVisualNovelDate?(default(IVisualNovelDate).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E398 RID: 58264
		// (get) Token: 0x06036A33 RID: 223795 RVA: 0x0074FA50 File Offset: 0x0074DC50
		public int PeriodId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036A34 RID: 223796 RVA: 0x0074FA8C File Offset: 0x0074DC8C
		public static Offset<ISolarSchoolTime> CreateISolarSchoolTime(FlatBufferBuilder builder, Offset<IVisualNovelDate> DateOffset = default(Offset<IVisualNovelDate>), int PeriodId = 0)
		{
			builder.StartTable(2);
			ISolarSchoolTime.AddPeriodId(builder, PeriodId);
			ISolarSchoolTime.AddDate(builder, DateOffset);
			return ISolarSchoolTime.EndISolarSchoolTime(builder);
		}

		// Token: 0x06036A35 RID: 223797 RVA: 0x0074FAA9 File Offset: 0x0074DCA9
		public static void StartISolarSchoolTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036A36 RID: 223798 RVA: 0x0074FAB2 File Offset: 0x0074DCB2
		public static void AddDate(FlatBufferBuilder builder, Offset<IVisualNovelDate> dateOffset)
		{
			builder.AddOffset(0, dateOffset.Value, 0);
		}

		// Token: 0x06036A37 RID: 223799 RVA: 0x0074FAC2 File Offset: 0x0074DCC2
		public static void AddPeriodId(FlatBufferBuilder builder, int periodId)
		{
			builder.AddInt(1, periodId, 0);
		}

		// Token: 0x06036A38 RID: 223800 RVA: 0x0074FACD File Offset: 0x0074DCCD
		public static Offset<ISolarSchoolTime> EndISolarSchoolTime(FlatBufferBuilder builder)
		{
			return new Offset<ISolarSchoolTime>(builder.EndTable());
		}

		// Token: 0x06036A39 RID: 223801 RVA: 0x0074FADC File Offset: 0x0074DCDC
		public ISolarSchoolTimeT UnPack()
		{
			ISolarSchoolTimeT solarSchoolTimeT = new ISolarSchoolTimeT();
			this.UnPackTo(solarSchoolTimeT);
			return solarSchoolTimeT;
		}

		// Token: 0x06036A3A RID: 223802 RVA: 0x0074FAF8 File Offset: 0x0074DCF8
		public void UnPackTo(ISolarSchoolTimeT _o)
		{
			_o.Date = ((this.Date != null) ? this.Date.Value.UnPack() : null);
			_o.PeriodId = this.PeriodId;
		}

		// Token: 0x06036A3B RID: 223803 RVA: 0x0074FB40 File Offset: 0x0074DD40
		public static Offset<ISolarSchoolTime> Pack(FlatBufferBuilder builder, ISolarSchoolTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISolarSchoolTime>);
			}
			Offset<IVisualNovelDate> dateOffset = (_o.Date == null) ? default(Offset<IVisualNovelDate>) : IVisualNovelDate.Pack(builder, _o.Date);
			return ISolarSchoolTime.CreateISolarSchoolTime(builder, dateOffset, _o.PeriodId);
		}

		// Token: 0x04012BF8 RID: 76792
		private Table __p;
	}
}
