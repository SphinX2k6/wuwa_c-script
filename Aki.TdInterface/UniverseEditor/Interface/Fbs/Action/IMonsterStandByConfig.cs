using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AEB RID: 27371
	public struct IMonsterStandByConfig : IFlatbufferObject
	{
		// Token: 0x1700CB09 RID: 51977
		// (get) Token: 0x0602FF94 RID: 196500 RVA: 0x00685E42 File Offset: 0x00684042
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FF95 RID: 196501 RVA: 0x00685E4F File Offset: 0x0068404F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FF96 RID: 196502 RVA: 0x00685E58 File Offset: 0x00684058
		public static IMonsterStandByConfig GetRootAsIMonsterStandByConfig(ByteBuffer _bb)
		{
			return IMonsterStandByConfig.GetRootAsIMonsterStandByConfig(_bb, default(IMonsterStandByConfig));
		}

		// Token: 0x0602FF97 RID: 196503 RVA: 0x00685E74 File Offset: 0x00684074
		public static IMonsterStandByConfig GetRootAsIMonsterStandByConfig(ByteBuffer _bb, IMonsterStandByConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FF98 RID: 196504 RVA: 0x00685E91 File Offset: 0x00684091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FF99 RID: 196505 RVA: 0x00685EA0 File Offset: 0x006840A0
		public IMonsterStandByConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CB0A RID: 51978
		// (get) Token: 0x0602FF9A RID: 196506 RVA: 0x00685EB0 File Offset: 0x006840B0
		public string Tag
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FF9B RID: 196507 RVA: 0x00685EE7 File Offset: 0x006840E7
		public Span<byte> GetTagBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602FF9C RID: 196508 RVA: 0x00685EF6 File Offset: 0x006840F6
		public byte[] GetTagArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700CB0B RID: 51979
		// (get) Token: 0x0602FF9D RID: 196509 RVA: 0x00685F04 File Offset: 0x00684104
		public float Duration
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB0C RID: 51980
		// (get) Token: 0x0602FF9E RID: 196510 RVA: 0x00685F44 File Offset: 0x00684144
		public int RepeatTimes
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

		// Token: 0x1700CB0D RID: 51981
		// (get) Token: 0x0602FF9F RID: 196511 RVA: 0x00685F80 File Offset: 0x00684180
		public int EmotionId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CB0E RID: 51982
		// (get) Token: 0x0602FFA0 RID: 196512 RVA: 0x00685FC0 File Offset: 0x006841C0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FFA1 RID: 196513 RVA: 0x00685FFD File Offset: 0x006841FD
		public static Offset<IMonsterStandByConfig> CreateIMonsterStandByConfig(FlatBufferBuilder builder, StringOffset TagOffset = default(StringOffset), float Duration = 0f, int RepeatTimes = 0, int EmotionId = 0, byte NullMask = 0)
		{
			builder.StartTable(5);
			IMonsterStandByConfig.AddEmotionId(builder, EmotionId);
			IMonsterStandByConfig.AddRepeatTimes(builder, RepeatTimes);
			IMonsterStandByConfig.AddDuration(builder, Duration);
			IMonsterStandByConfig.AddTag(builder, TagOffset);
			IMonsterStandByConfig.AddNullMask(builder, NullMask);
			return IMonsterStandByConfig.EndIMonsterStandByConfig(builder);
		}

		// Token: 0x0602FFA2 RID: 196514 RVA: 0x00686031 File Offset: 0x00684231
		public static void StartIMonsterStandByConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x0602FFA3 RID: 196515 RVA: 0x0068603A File Offset: 0x0068423A
		public static void AddTag(FlatBufferBuilder builder, StringOffset tagOffset)
		{
			builder.AddOffset(0, tagOffset.Value, 0);
		}

		// Token: 0x0602FFA4 RID: 196516 RVA: 0x0068604A File Offset: 0x0068424A
		public static void AddDuration(FlatBufferBuilder builder, float duration)
		{
			builder.AddFloat(1, duration, 0.0);
		}

		// Token: 0x0602FFA5 RID: 196517 RVA: 0x0068605D File Offset: 0x0068425D
		public static void AddRepeatTimes(FlatBufferBuilder builder, int repeatTimes)
		{
			builder.AddInt(2, repeatTimes, 0);
		}

		// Token: 0x0602FFA6 RID: 196518 RVA: 0x00686068 File Offset: 0x00684268
		public static void AddEmotionId(FlatBufferBuilder builder, int emotionId)
		{
			builder.AddInt(3, emotionId, 0);
		}

		// Token: 0x0602FFA7 RID: 196519 RVA: 0x00686073 File Offset: 0x00684273
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602FFA8 RID: 196520 RVA: 0x0068607E File Offset: 0x0068427E
		public static Offset<IMonsterStandByConfig> EndIMonsterStandByConfig(FlatBufferBuilder builder)
		{
			return new Offset<IMonsterStandByConfig>(builder.EndTable());
		}

		// Token: 0x0602FFA9 RID: 196521 RVA: 0x0068608C File Offset: 0x0068428C
		public IMonsterStandByConfigT UnPack()
		{
			IMonsterStandByConfigT monsterStandByConfigT = new IMonsterStandByConfigT();
			this.UnPackTo(monsterStandByConfigT);
			return monsterStandByConfigT;
		}

		// Token: 0x0602FFAA RID: 196522 RVA: 0x006860A7 File Offset: 0x006842A7
		public void UnPackTo(IMonsterStandByConfigT _o)
		{
			_o.Tag = this.Tag;
			_o.Duration = this.Duration;
			_o.RepeatTimes = this.RepeatTimes;
			_o.EmotionId = this.EmotionId;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602FFAB RID: 196523 RVA: 0x006860E8 File Offset: 0x006842E8
		public static Offset<IMonsterStandByConfig> Pack(FlatBufferBuilder builder, IMonsterStandByConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMonsterStandByConfig>);
			}
			StringOffset tagOffset = (_o.Tag == null) ? default(StringOffset) : builder.CreateString(_o.Tag);
			return IMonsterStandByConfig.CreateIMonsterStandByConfig(builder, tagOffset, _o.Duration, _o.RepeatTimes, _o.EmotionId, _o.NullMask);
		}

		// Token: 0x0401133D RID: 70461
		private Table __p;
	}
}
