using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007241 RID: 29249
	public struct ISunSpiritDifficultyReduction : IFlatbufferObject
	{
		// Token: 0x1700D907 RID: 55559
		// (get) Token: 0x06033E04 RID: 212484 RVA: 0x006FA9E9 File Offset: 0x006F8BE9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06033E05 RID: 212485 RVA: 0x006FA9F6 File Offset: 0x006F8BF6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06033E06 RID: 212486 RVA: 0x006FAA00 File Offset: 0x006F8C00
		public static ISunSpiritDifficultyReduction GetRootAsISunSpiritDifficultyReduction(ByteBuffer _bb)
		{
			return ISunSpiritDifficultyReduction.GetRootAsISunSpiritDifficultyReduction(_bb, default(ISunSpiritDifficultyReduction));
		}

		// Token: 0x06033E07 RID: 212487 RVA: 0x006FAA1C File Offset: 0x006F8C1C
		public static ISunSpiritDifficultyReduction GetRootAsISunSpiritDifficultyReduction(ByteBuffer _bb, ISunSpiritDifficultyReduction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06033E08 RID: 212488 RVA: 0x006FAA39 File Offset: 0x006F8C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06033E09 RID: 212489 RVA: 0x006FAA48 File Offset: 0x006F8C48
		public ISunSpiritDifficultyReduction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D908 RID: 55560
		// (get) Token: 0x06033E0A RID: 212490 RVA: 0x006FAA58 File Offset: 0x006F8C58
		public int LoseTimes
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D909 RID: 55561
		// (get) Token: 0x06033E0B RID: 212491 RVA: 0x006FAA94 File Offset: 0x006F8C94
		public int SubstituteId
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

		// Token: 0x06033E0C RID: 212492 RVA: 0x006FAAD0 File Offset: 0x006F8CD0
		public static Offset<ISunSpiritDifficultyReduction> CreateISunSpiritDifficultyReduction(FlatBufferBuilder builder, int LoseTimes = 0, int SubstituteId = 0)
		{
			builder.StartTable(2);
			ISunSpiritDifficultyReduction.AddSubstituteId(builder, SubstituteId);
			ISunSpiritDifficultyReduction.AddLoseTimes(builder, LoseTimes);
			return ISunSpiritDifficultyReduction.EndISunSpiritDifficultyReduction(builder);
		}

		// Token: 0x06033E0D RID: 212493 RVA: 0x006FAAED File Offset: 0x006F8CED
		public static void StartISunSpiritDifficultyReduction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033E0E RID: 212494 RVA: 0x006FAAF6 File Offset: 0x006F8CF6
		public static void AddLoseTimes(FlatBufferBuilder builder, int loseTimes)
		{
			builder.AddInt(0, loseTimes, 0);
		}

		// Token: 0x06033E0F RID: 212495 RVA: 0x006FAB01 File Offset: 0x006F8D01
		public static void AddSubstituteId(FlatBufferBuilder builder, int substituteId)
		{
			builder.AddInt(1, substituteId, 0);
		}

		// Token: 0x06033E10 RID: 212496 RVA: 0x006FAB0C File Offset: 0x006F8D0C
		public static Offset<ISunSpiritDifficultyReduction> EndISunSpiritDifficultyReduction(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritDifficultyReduction>(builder.EndTable());
		}

		// Token: 0x06033E11 RID: 212497 RVA: 0x006FAB1C File Offset: 0x006F8D1C
		public ISunSpiritDifficultyReductionT UnPack()
		{
			ISunSpiritDifficultyReductionT sunSpiritDifficultyReductionT = new ISunSpiritDifficultyReductionT();
			this.UnPackTo(sunSpiritDifficultyReductionT);
			return sunSpiritDifficultyReductionT;
		}

		// Token: 0x06033E12 RID: 212498 RVA: 0x006FAB37 File Offset: 0x006F8D37
		public void UnPackTo(ISunSpiritDifficultyReductionT _o)
		{
			_o.LoseTimes = this.LoseTimes;
			_o.SubstituteId = this.SubstituteId;
		}

		// Token: 0x06033E13 RID: 212499 RVA: 0x006FAB54 File Offset: 0x006F8D54
		public static Offset<ISunSpiritDifficultyReduction> Pack(FlatBufferBuilder builder, ISunSpiritDifficultyReductionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritDifficultyReduction>);
			}
			return ISunSpiritDifficultyReduction.CreateISunSpiritDifficultyReduction(builder, _o.LoseTimes, _o.SubstituteId);
		}

		// Token: 0x04011D32 RID: 73010
		private Table __p;
	}
}
