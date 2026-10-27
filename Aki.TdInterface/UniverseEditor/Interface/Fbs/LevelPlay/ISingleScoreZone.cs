using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045B1 RID: 17841
	public struct ISingleScoreZone : IFlatbufferObject
	{
		// Token: 0x17007ECE RID: 32462
		// (get) Token: 0x0601AF95 RID: 110485 RVA: 0x003D8C2C File Offset: 0x003D6E2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601AF96 RID: 110486 RVA: 0x003D8C39 File Offset: 0x003D6E39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601AF97 RID: 110487 RVA: 0x003D8C40 File Offset: 0x003D6E40
		public static ISingleScoreZone GetRootAsISingleScoreZone(ByteBuffer _bb)
		{
			return ISingleScoreZone.GetRootAsISingleScoreZone(_bb, default(ISingleScoreZone));
		}

		// Token: 0x0601AF98 RID: 110488 RVA: 0x003D8C5C File Offset: 0x003D6E5C
		public static ISingleScoreZone GetRootAsISingleScoreZone(ByteBuffer _bb, ISingleScoreZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601AF99 RID: 110489 RVA: 0x003D8C79 File Offset: 0x003D6E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601AF9A RID: 110490 RVA: 0x003D8C88 File Offset: 0x003D6E88
		public ISingleScoreZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007ECF RID: 32463
		// (get) Token: 0x0601AF9B RID: 110491 RVA: 0x003D8C98 File Offset: 0x003D6E98
		public EDartboardZoneType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EDartboardZoneType.CenterBull;
				}
				return (EDartboardZoneType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17007ED0 RID: 32464
		// (get) Token: 0x0601AF9C RID: 110492 RVA: 0x003D8CD4 File Offset: 0x003D6ED4
		public int Score
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

		// Token: 0x17007ED1 RID: 32465
		// (get) Token: 0x0601AF9D RID: 110493 RVA: 0x003D8D10 File Offset: 0x003D6F10
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601AF9E RID: 110494 RVA: 0x003D8D4C File Offset: 0x003D6F4C
		public static Offset<ISingleScoreZone> CreateISingleScoreZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull, int Score = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISingleScoreZone.AddScore(builder, Score);
			ISingleScoreZone.AddNullMask(builder, NullMask);
			ISingleScoreZone.AddType(builder, Type);
			return ISingleScoreZone.EndISingleScoreZone(builder);
		}

		// Token: 0x0601AF9F RID: 110495 RVA: 0x003D8D70 File Offset: 0x003D6F70
		public static void StartISingleScoreZone(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601AFA0 RID: 110496 RVA: 0x003D8D79 File Offset: 0x003D6F79
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601AFA1 RID: 110497 RVA: 0x003D8D84 File Offset: 0x003D6F84
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601AFA2 RID: 110498 RVA: 0x003D8D8F File Offset: 0x003D6F8F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601AFA3 RID: 110499 RVA: 0x003D8D9A File Offset: 0x003D6F9A
		public static Offset<ISingleScoreZone> EndISingleScoreZone(FlatBufferBuilder builder)
		{
			return new Offset<ISingleScoreZone>(builder.EndTable());
		}

		// Token: 0x0601AFA4 RID: 110500 RVA: 0x003D8DA8 File Offset: 0x003D6FA8
		public ISingleScoreZoneT UnPack()
		{
			ISingleScoreZoneT singleScoreZoneT = new ISingleScoreZoneT();
			this.UnPackTo(singleScoreZoneT);
			return singleScoreZoneT;
		}

		// Token: 0x0601AFA5 RID: 110501 RVA: 0x003D8DC3 File Offset: 0x003D6FC3
		public void UnPackTo(ISingleScoreZoneT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601AFA6 RID: 110502 RVA: 0x003D8DEC File Offset: 0x003D6FEC
		public static Offset<ISingleScoreZone> Pack(FlatBufferBuilder builder, ISingleScoreZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISingleScoreZone>);
			}
			return ISingleScoreZone.CreateISingleScoreZone(builder, _o.Type, _o.Score, _o.NullMask);
		}

		// Token: 0x0400C67A RID: 50810
		private Table __p;
	}
}
