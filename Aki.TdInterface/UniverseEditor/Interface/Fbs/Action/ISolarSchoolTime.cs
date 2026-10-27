using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007166 RID: 29030
	public struct ISolarSchoolTime : IFlatbufferObject
	{
		// Token: 0x1700D7B1 RID: 55217
		// (get) Token: 0x06033782 RID: 210818 RVA: 0x006EF175 File Offset: 0x006ED375
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033783 RID: 210819 RVA: 0x006EF182 File Offset: 0x006ED382
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033784 RID: 210820 RVA: 0x006EF18C File Offset: 0x006ED38C
		public static ISolarSchoolTime GetRootAsISolarSchoolTime(ByteBuffer _bb)
		{
			return ISolarSchoolTime.GetRootAsISolarSchoolTime(_bb, default(ISolarSchoolTime));
		}

		// Token: 0x06033785 RID: 210821 RVA: 0x006EF1A8 File Offset: 0x006ED3A8
		public static ISolarSchoolTime GetRootAsISolarSchoolTime(ByteBuffer _bb, ISolarSchoolTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033786 RID: 210822 RVA: 0x006EF1C5 File Offset: 0x006ED3C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033787 RID: 210823 RVA: 0x006EF1D4 File Offset: 0x006ED3D4
		public ISolarSchoolTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D7B2 RID: 55218
		// (get) Token: 0x06033788 RID: 210824 RVA: 0x006EF1E4 File Offset: 0x006ED3E4
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

		// Token: 0x1700D7B3 RID: 55219
		// (get) Token: 0x06033789 RID: 210825 RVA: 0x006EF244 File Offset: 0x006ED444
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

		// Token: 0x0603378A RID: 210826 RVA: 0x006EF280 File Offset: 0x006ED480
		public static Offset<ISolarSchoolTime> CreateISolarSchoolTime(FlatBufferBuilder builder, Offset<IVisualNovelDate> DateOffset = default(Offset<IVisualNovelDate>), int PeriodId = 0)
		{
			builder.StartTable(2);
			ISolarSchoolTime.AddPeriodId(builder, PeriodId);
			ISolarSchoolTime.AddDate(builder, DateOffset);
			return ISolarSchoolTime.EndISolarSchoolTime(builder);
		}

		// Token: 0x0603378B RID: 210827 RVA: 0x006EF29D File Offset: 0x006ED49D
		public static void StartISolarSchoolTime(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0603378C RID: 210828 RVA: 0x006EF2A6 File Offset: 0x006ED4A6
		public static void AddDate(FlatBufferBuilder builder, Offset<IVisualNovelDate> dateOffset)
		{
			builder.AddOffset(0, dateOffset.Value, 0);
		}

		// Token: 0x0603378D RID: 210829 RVA: 0x006EF2B6 File Offset: 0x006ED4B6
		public static void AddPeriodId(FlatBufferBuilder builder, int periodId)
		{
			builder.AddInt(1, periodId, 0);
		}

		// Token: 0x0603378E RID: 210830 RVA: 0x006EF2C1 File Offset: 0x006ED4C1
		public static Offset<ISolarSchoolTime> EndISolarSchoolTime(FlatBufferBuilder builder)
		{
			return new Offset<ISolarSchoolTime>(builder.EndTable());
		}

		// Token: 0x0603378F RID: 210831 RVA: 0x006EF2D0 File Offset: 0x006ED4D0
		public ISolarSchoolTimeT UnPack()
		{
			ISolarSchoolTimeT solarSchoolTimeT = new ISolarSchoolTimeT();
			this.UnPackTo(solarSchoolTimeT);
			return solarSchoolTimeT;
		}

		// Token: 0x06033790 RID: 210832 RVA: 0x006EF2EC File Offset: 0x006ED4EC
		public void UnPackTo(ISolarSchoolTimeT _o)
		{
			_o.Date = ((this.Date != null) ? this.Date.Value.UnPack() : null);
			_o.PeriodId = this.PeriodId;
		}

		// Token: 0x06033791 RID: 210833 RVA: 0x006EF334 File Offset: 0x006ED534
		public static Offset<ISolarSchoolTime> Pack(FlatBufferBuilder builder, ISolarSchoolTimeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISolarSchoolTime>);
			}
			Offset<IVisualNovelDate> dateOffset = (_o.Date == null) ? default(Offset<IVisualNovelDate>) : IVisualNovelDate.Pack(builder, _o.Date);
			return ISolarSchoolTime.CreateISolarSchoolTime(builder, dateOffset, _o.PeriodId);
		}

		// Token: 0x04011C09 RID: 72713
		private Table __p;
	}
}
