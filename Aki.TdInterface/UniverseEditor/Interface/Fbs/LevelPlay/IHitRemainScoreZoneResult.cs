using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x0200493E RID: 18750
	public struct IHitRemainScoreZoneResult : IFlatbufferObject
	{
		// Token: 0x1700829D RID: 33437
		// (get) Token: 0x0601BD3B RID: 113979 RVA: 0x003EE956 File Offset: 0x003ECB56
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BD3C RID: 113980 RVA: 0x003EE963 File Offset: 0x003ECB63
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BD3D RID: 113981 RVA: 0x003EE96C File Offset: 0x003ECB6C
		public static IHitRemainScoreZoneResult GetRootAsIHitRemainScoreZoneResult(ByteBuffer _bb)
		{
			return IHitRemainScoreZoneResult.GetRootAsIHitRemainScoreZoneResult(_bb, default(IHitRemainScoreZoneResult));
		}

		// Token: 0x0601BD3E RID: 113982 RVA: 0x003EE988 File Offset: 0x003ECB88
		public static IHitRemainScoreZoneResult GetRootAsIHitRemainScoreZoneResult(ByteBuffer _bb, IHitRemainScoreZoneResult obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BD3F RID: 113983 RVA: 0x003EE9A5 File Offset: 0x003ECBA5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BD40 RID: 113984 RVA: 0x003EE9B4 File Offset: 0x003ECBB4
		public IHitRemainScoreZoneResult __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700829E RID: 33438
		// (get) Token: 0x0601BD41 RID: 113985 RVA: 0x003EE9C4 File Offset: 0x003ECBC4
		public EDartSkillResultType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartSkillResultType.NoBust;
				}
				return (EDartSkillResultType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700829F RID: 33439
		// (get) Token: 0x0601BD42 RID: 113986 RVA: 0x003EEA00 File Offset: 0x003ECC00
		public int Probability
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

		// Token: 0x0601BD43 RID: 113987 RVA: 0x003EEA3C File Offset: 0x003ECC3C
		public static Offset<IHitRemainScoreZoneResult> CreateIHitRemainScoreZoneResult(FlatBufferBuilder builder, EDartSkillResultType Type = EDartSkillResultType.NoBust, int Probability = 0)
		{
			builder.StartTable(2);
			IHitRemainScoreZoneResult.AddProbability(builder, Probability);
			IHitRemainScoreZoneResult.AddType(builder, Type);
			return IHitRemainScoreZoneResult.EndIHitRemainScoreZoneResult(builder);
		}

		// Token: 0x0601BD44 RID: 113988 RVA: 0x003EEA59 File Offset: 0x003ECC59
		public static void StartIHitRemainScoreZoneResult(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601BD45 RID: 113989 RVA: 0x003EEA62 File Offset: 0x003ECC62
		public static void AddType(FlatBufferBuilder builder, EDartSkillResultType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BD46 RID: 113990 RVA: 0x003EEA6D File Offset: 0x003ECC6D
		public static void AddProbability(FlatBufferBuilder builder, int probability)
		{
			builder.AddInt(1, probability, 0);
		}

		// Token: 0x0601BD47 RID: 113991 RVA: 0x003EEA78 File Offset: 0x003ECC78
		public static Offset<IHitRemainScoreZoneResult> EndIHitRemainScoreZoneResult(FlatBufferBuilder builder)
		{
			return new Offset<IHitRemainScoreZoneResult>(builder.EndTable());
		}

		// Token: 0x0601BD48 RID: 113992 RVA: 0x003EEA88 File Offset: 0x003ECC88
		public IHitRemainScoreZoneResultT UnPack()
		{
			IHitRemainScoreZoneResultT hitRemainScoreZoneResultT = new IHitRemainScoreZoneResultT();
			this.UnPackTo(hitRemainScoreZoneResultT);
			return hitRemainScoreZoneResultT;
		}

		// Token: 0x0601BD49 RID: 113993 RVA: 0x003EEAA3 File Offset: 0x003ECCA3
		public void UnPackTo(IHitRemainScoreZoneResultT _o)
		{
			_o.Type = this.Type;
			_o.Probability = this.Probability;
		}

		// Token: 0x0601BD4A RID: 113994 RVA: 0x003EEAC0 File Offset: 0x003ECCC0
		public static Offset<IHitRemainScoreZoneResult> Pack(FlatBufferBuilder builder, IHitRemainScoreZoneResultT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHitRemainScoreZoneResult>);
			}
			return IHitRemainScoreZoneResult.CreateIHitRemainScoreZoneResult(builder, _o.Type, _o.Probability);
		}

		// Token: 0x0400CF1B RID: 53019
		private Table __p;
	}
}
