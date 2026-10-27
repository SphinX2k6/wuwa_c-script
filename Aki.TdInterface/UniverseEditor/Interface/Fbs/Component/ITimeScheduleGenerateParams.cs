using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AA5 RID: 23205
	public struct ITimeScheduleGenerateParams : IFlatbufferObject
	{
		// Token: 0x1700AECA RID: 44746
		// (get) Token: 0x0602789A RID: 161946 RVA: 0x00570771 File Offset: 0x0056E971
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602789B RID: 161947 RVA: 0x0057077E File Offset: 0x0056E97E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602789C RID: 161948 RVA: 0x00570788 File Offset: 0x0056E988
		public static ITimeScheduleGenerateParams GetRootAsITimeScheduleGenerateParams(ByteBuffer _bb)
		{
			return ITimeScheduleGenerateParams.GetRootAsITimeScheduleGenerateParams(_bb, default(ITimeScheduleGenerateParams));
		}

		// Token: 0x0602789D RID: 161949 RVA: 0x005707A4 File Offset: 0x0056E9A4
		public static ITimeScheduleGenerateParams GetRootAsITimeScheduleGenerateParams(ByteBuffer _bb, ITimeScheduleGenerateParams obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602789E RID: 161950 RVA: 0x005707C1 File Offset: 0x0056E9C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602789F RID: 161951 RVA: 0x005707D0 File Offset: 0x0056E9D0
		public ITimeScheduleGenerateParams __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AECB RID: 44747
		// (get) Token: 0x060278A0 RID: 161952 RVA: 0x005707E0 File Offset: 0x0056E9E0
		public ITimeScheduleGameDailyRefresh? RefreshType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScheduleGameDailyRefresh?(default(ITimeScheduleGameDailyRefresh).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700AECC RID: 44748
		// (get) Token: 0x060278A1 RID: 161953 RVA: 0x00570840 File Offset: 0x0056EA40
		public int MaxCount
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

		// Token: 0x1700AECD RID: 44749
		// (get) Token: 0x060278A2 RID: 161954 RVA: 0x0057087C File Offset: 0x0056EA7C
		public int MinCount
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

		// Token: 0x1700AECE RID: 44750
		// (get) Token: 0x060278A3 RID: 161955 RVA: 0x005708B8 File Offset: 0x0056EAB8
		public ITimeScheduleRandomSchedulePositionDistribution? DistributionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new ITimeScheduleRandomSchedulePositionDistribution?(default(ITimeScheduleRandomSchedulePositionDistribution).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x060278A4 RID: 161956 RVA: 0x00570916 File Offset: 0x0056EB16
		public static Offset<ITimeScheduleGenerateParams> CreateITimeScheduleGenerateParams(FlatBufferBuilder builder, Offset<ITimeScheduleGameDailyRefresh> RefreshTypeOffset = default(Offset<ITimeScheduleGameDailyRefresh>), int MaxCount = 0, int MinCount = 0, Offset<ITimeScheduleRandomSchedulePositionDistribution> DistributionTypeOffset = default(Offset<ITimeScheduleRandomSchedulePositionDistribution>))
		{
			builder.StartTable(4);
			ITimeScheduleGenerateParams.AddDistributionType(builder, DistributionTypeOffset);
			ITimeScheduleGenerateParams.AddMinCount(builder, MinCount);
			ITimeScheduleGenerateParams.AddMaxCount(builder, MaxCount);
			ITimeScheduleGenerateParams.AddRefreshType(builder, RefreshTypeOffset);
			return ITimeScheduleGenerateParams.EndITimeScheduleGenerateParams(builder);
		}

		// Token: 0x060278A5 RID: 161957 RVA: 0x00570942 File Offset: 0x0056EB42
		public static void StartITimeScheduleGenerateParams(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x060278A6 RID: 161958 RVA: 0x0057094B File Offset: 0x0056EB4B
		public static void AddRefreshType(FlatBufferBuilder builder, Offset<ITimeScheduleGameDailyRefresh> refreshTypeOffset)
		{
			builder.AddOffset(0, refreshTypeOffset.Value, 0);
		}

		// Token: 0x060278A7 RID: 161959 RVA: 0x0057095B File Offset: 0x0056EB5B
		public static void AddMaxCount(FlatBufferBuilder builder, int maxCount)
		{
			builder.AddInt(1, maxCount, 0);
		}

		// Token: 0x060278A8 RID: 161960 RVA: 0x00570966 File Offset: 0x0056EB66
		public static void AddMinCount(FlatBufferBuilder builder, int minCount)
		{
			builder.AddInt(2, minCount, 0);
		}

		// Token: 0x060278A9 RID: 161961 RVA: 0x00570971 File Offset: 0x0056EB71
		public static void AddDistributionType(FlatBufferBuilder builder, Offset<ITimeScheduleRandomSchedulePositionDistribution> distributionTypeOffset)
		{
			builder.AddOffset(3, distributionTypeOffset.Value, 0);
		}

		// Token: 0x060278AA RID: 161962 RVA: 0x00570981 File Offset: 0x0056EB81
		public static Offset<ITimeScheduleGenerateParams> EndITimeScheduleGenerateParams(FlatBufferBuilder builder)
		{
			return new Offset<ITimeScheduleGenerateParams>(builder.EndTable());
		}

		// Token: 0x060278AB RID: 161963 RVA: 0x00570990 File Offset: 0x0056EB90
		public ITimeScheduleGenerateParamsT UnPack()
		{
			ITimeScheduleGenerateParamsT timeScheduleGenerateParamsT = new ITimeScheduleGenerateParamsT();
			this.UnPackTo(timeScheduleGenerateParamsT);
			return timeScheduleGenerateParamsT;
		}

		// Token: 0x060278AC RID: 161964 RVA: 0x005709AC File Offset: 0x0056EBAC
		public void UnPackTo(ITimeScheduleGenerateParamsT _o)
		{
			_o.RefreshType = ((this.RefreshType != null) ? this.RefreshType.Value.UnPack() : null);
			_o.MaxCount = this.MaxCount;
			_o.MinCount = this.MinCount;
			_o.DistributionType = ((this.DistributionType != null) ? this.DistributionType.Value.UnPack() : null);
		}

		// Token: 0x060278AD RID: 161965 RVA: 0x00570A30 File Offset: 0x0056EC30
		public static Offset<ITimeScheduleGenerateParams> Pack(FlatBufferBuilder builder, ITimeScheduleGenerateParamsT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITimeScheduleGenerateParams>);
			}
			Offset<ITimeScheduleGameDailyRefresh> refreshTypeOffset = (_o.RefreshType == null) ? default(Offset<ITimeScheduleGameDailyRefresh>) : ITimeScheduleGameDailyRefresh.Pack(builder, _o.RefreshType);
			Offset<ITimeScheduleRandomSchedulePositionDistribution> distributionTypeOffset = (_o.DistributionType == null) ? default(Offset<ITimeScheduleRandomSchedulePositionDistribution>) : ITimeScheduleRandomSchedulePositionDistribution.Pack(builder, _o.DistributionType);
			return ITimeScheduleGenerateParams.CreateITimeScheduleGenerateParams(builder, refreshTypeOffset, _o.MaxCount, _o.MinCount, distributionTypeOffset);
		}

		// Token: 0x0400F166 RID: 61798
		private Table __p;
	}
}
