using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A16 RID: 31254
	public struct ISunSpiritDifficultyReduction : IFlatbufferObject
	{
		// Token: 0x1700E500 RID: 58624
		// (get) Token: 0x06037106 RID: 225542 RVA: 0x0075BD49 File Offset: 0x00759F49
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06037107 RID: 225543 RVA: 0x0075BD56 File Offset: 0x00759F56
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06037108 RID: 225544 RVA: 0x0075BD60 File Offset: 0x00759F60
		public static ISunSpiritDifficultyReduction GetRootAsISunSpiritDifficultyReduction(ByteBuffer _bb)
		{
			return ISunSpiritDifficultyReduction.GetRootAsISunSpiritDifficultyReduction(_bb, default(ISunSpiritDifficultyReduction));
		}

		// Token: 0x06037109 RID: 225545 RVA: 0x0075BD7C File Offset: 0x00759F7C
		public static ISunSpiritDifficultyReduction GetRootAsISunSpiritDifficultyReduction(ByteBuffer _bb, ISunSpiritDifficultyReduction obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603710A RID: 225546 RVA: 0x0075BD99 File Offset: 0x00759F99
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603710B RID: 225547 RVA: 0x0075BDA8 File Offset: 0x00759FA8
		public ISunSpiritDifficultyReduction __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E501 RID: 58625
		// (get) Token: 0x0603710C RID: 225548 RVA: 0x0075BDB8 File Offset: 0x00759FB8
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

		// Token: 0x1700E502 RID: 58626
		// (get) Token: 0x0603710D RID: 225549 RVA: 0x0075BDF4 File Offset: 0x00759FF4
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

		// Token: 0x0603710E RID: 225550 RVA: 0x0075BE30 File Offset: 0x0075A030
		public static Offset<ISunSpiritDifficultyReduction> CreateISunSpiritDifficultyReduction(FlatBufferBuilder builder, int LoseTimes = 0, int SubstituteId = 0)
		{
			builder.StartTable(2);
			ISunSpiritDifficultyReduction.AddSubstituteId(builder, SubstituteId);
			ISunSpiritDifficultyReduction.AddLoseTimes(builder, LoseTimes);
			return ISunSpiritDifficultyReduction.EndISunSpiritDifficultyReduction(builder);
		}

		// Token: 0x0603710F RID: 225551 RVA: 0x0075BE4D File Offset: 0x0075A04D
		public static void StartISunSpiritDifficultyReduction(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06037110 RID: 225552 RVA: 0x0075BE56 File Offset: 0x0075A056
		public static void AddLoseTimes(FlatBufferBuilder builder, int loseTimes)
		{
			builder.AddInt(0, loseTimes, 0);
		}

		// Token: 0x06037111 RID: 225553 RVA: 0x0075BE61 File Offset: 0x0075A061
		public static void AddSubstituteId(FlatBufferBuilder builder, int substituteId)
		{
			builder.AddInt(1, substituteId, 0);
		}

		// Token: 0x06037112 RID: 225554 RVA: 0x0075BE6C File Offset: 0x0075A06C
		public static Offset<ISunSpiritDifficultyReduction> EndISunSpiritDifficultyReduction(FlatBufferBuilder builder)
		{
			return new Offset<ISunSpiritDifficultyReduction>(builder.EndTable());
		}

		// Token: 0x06037113 RID: 225555 RVA: 0x0075BE7C File Offset: 0x0075A07C
		public ISunSpiritDifficultyReductionT UnPack()
		{
			ISunSpiritDifficultyReductionT sunSpiritDifficultyReductionT = new ISunSpiritDifficultyReductionT();
			this.UnPackTo(sunSpiritDifficultyReductionT);
			return sunSpiritDifficultyReductionT;
		}

		// Token: 0x06037114 RID: 225556 RVA: 0x0075BE97 File Offset: 0x0075A097
		public void UnPackTo(ISunSpiritDifficultyReductionT _o)
		{
			_o.LoseTimes = this.LoseTimes;
			_o.SubstituteId = this.SubstituteId;
		}

		// Token: 0x06037115 RID: 225557 RVA: 0x0075BEB4 File Offset: 0x0075A0B4
		public static Offset<ISunSpiritDifficultyReduction> Pack(FlatBufferBuilder builder, ISunSpiritDifficultyReductionT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISunSpiritDifficultyReduction>);
			}
			return ISunSpiritDifficultyReduction.CreateISunSpiritDifficultyReduction(builder, _o.LoseTimes, _o.SubstituteId);
		}

		// Token: 0x04012D34 RID: 77108
		private Table __p;
	}
}
