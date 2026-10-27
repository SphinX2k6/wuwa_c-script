using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020070C7 RID: 28871
	public struct ISheriffStartTrack : IFlatbufferObject
	{
		// Token: 0x1700D678 RID: 54904
		// (get) Token: 0x0603322A RID: 209450 RVA: 0x006E52EE File Offset: 0x006E34EE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603322B RID: 209451 RVA: 0x006E52FB File Offset: 0x006E34FB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603322C RID: 209452 RVA: 0x006E5304 File Offset: 0x006E3504
		public static ISheriffStartTrack GetRootAsISheriffStartTrack(ByteBuffer _bb)
		{
			return ISheriffStartTrack.GetRootAsISheriffStartTrack(_bb, default(ISheriffStartTrack));
		}

		// Token: 0x0603322D RID: 209453 RVA: 0x006E5320 File Offset: 0x006E3520
		public static ISheriffStartTrack GetRootAsISheriffStartTrack(ByteBuffer _bb, ISheriffStartTrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603322E RID: 209454 RVA: 0x006E533D File Offset: 0x006E353D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603322F RID: 209455 RVA: 0x006E534C File Offset: 0x006E354C
		public ISheriffStartTrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D679 RID: 54905
		// (get) Token: 0x06033230 RID: 209456 RVA: 0x006E535C File Offset: 0x006E355C
		public ECommonTipType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECommonTipType.ChallengeCondition;
				}
				return (ECommonTipType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700D67A RID: 54906
		// (get) Token: 0x06033231 RID: 209457 RVA: 0x006E5398 File Offset: 0x006E3598
		public int AnomalyId
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

		// Token: 0x06033232 RID: 209458 RVA: 0x006E53D4 File Offset: 0x006E35D4
		public static Offset<ISheriffStartTrack> CreateISheriffStartTrack(FlatBufferBuilder builder, ECommonTipType Type = ECommonTipType.ChallengeCondition, int AnomalyId = 0)
		{
			builder.StartTable(2);
			ISheriffStartTrack.AddAnomalyId(builder, AnomalyId);
			ISheriffStartTrack.AddType(builder, Type);
			return ISheriffStartTrack.EndISheriffStartTrack(builder);
		}

		// Token: 0x06033233 RID: 209459 RVA: 0x006E53F1 File Offset: 0x006E35F1
		public static void StartISheriffStartTrack(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06033234 RID: 209460 RVA: 0x006E53FA File Offset: 0x006E35FA
		public static void AddType(FlatBufferBuilder builder, ECommonTipType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06033235 RID: 209461 RVA: 0x006E5405 File Offset: 0x006E3605
		public static void AddAnomalyId(FlatBufferBuilder builder, int anomalyId)
		{
			builder.AddInt(1, anomalyId, 0);
		}

		// Token: 0x06033236 RID: 209462 RVA: 0x006E5410 File Offset: 0x006E3610
		public static Offset<ISheriffStartTrack> EndISheriffStartTrack(FlatBufferBuilder builder)
		{
			return new Offset<ISheriffStartTrack>(builder.EndTable());
		}

		// Token: 0x06033237 RID: 209463 RVA: 0x006E5420 File Offset: 0x006E3620
		public ISheriffStartTrackT UnPack()
		{
			ISheriffStartTrackT sheriffStartTrackT = new ISheriffStartTrackT();
			this.UnPackTo(sheriffStartTrackT);
			return sheriffStartTrackT;
		}

		// Token: 0x06033238 RID: 209464 RVA: 0x006E543B File Offset: 0x006E363B
		public void UnPackTo(ISheriffStartTrackT _o)
		{
			_o.Type = this.Type;
			_o.AnomalyId = this.AnomalyId;
		}

		// Token: 0x06033239 RID: 209465 RVA: 0x006E5458 File Offset: 0x006E3658
		public static Offset<ISheriffStartTrack> Pack(FlatBufferBuilder builder, ISheriffStartTrackT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISheriffStartTrack>);
			}
			return ISheriffStartTrack.CreateISheriffStartTrack(builder, _o.Type, _o.AnomalyId);
		}

		// Token: 0x04011B36 RID: 72502
		private Table __p;
	}
}
