using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004905 RID: 18693
	public struct IDoubleScoreZone : IFlatbufferObject
	{
		// Token: 0x17008230 RID: 33328
		// (get) Token: 0x0601BB55 RID: 113493 RVA: 0x003EB3E2 File Offset: 0x003E95E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601BB56 RID: 113494 RVA: 0x003EB3EF File Offset: 0x003E95EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601BB57 RID: 113495 RVA: 0x003EB3F8 File Offset: 0x003E95F8
		public static IDoubleScoreZone GetRootAsIDoubleScoreZone(ByteBuffer _bb)
		{
			return IDoubleScoreZone.GetRootAsIDoubleScoreZone(_bb, default(IDoubleScoreZone));
		}

		// Token: 0x0601BB58 RID: 113496 RVA: 0x003EB414 File Offset: 0x003E9614
		public static IDoubleScoreZone GetRootAsIDoubleScoreZone(ByteBuffer _bb, IDoubleScoreZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601BB59 RID: 113497 RVA: 0x003EB431 File Offset: 0x003E9631
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601BB5A RID: 113498 RVA: 0x003EB440 File Offset: 0x003E9640
		public IDoubleScoreZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008231 RID: 33329
		// (get) Token: 0x0601BB5B RID: 113499 RVA: 0x003EB450 File Offset: 0x003E9650
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

		// Token: 0x17008232 RID: 33330
		// (get) Token: 0x0601BB5C RID: 113500 RVA: 0x003EB48C File Offset: 0x003E968C
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

		// Token: 0x17008233 RID: 33331
		// (get) Token: 0x0601BB5D RID: 113501 RVA: 0x003EB4C8 File Offset: 0x003E96C8
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

		// Token: 0x0601BB5E RID: 113502 RVA: 0x003EB504 File Offset: 0x003E9704
		public static Offset<IDoubleScoreZone> CreateIDoubleScoreZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull, int Score = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			IDoubleScoreZone.AddScore(builder, Score);
			IDoubleScoreZone.AddNullMask(builder, NullMask);
			IDoubleScoreZone.AddType(builder, Type);
			return IDoubleScoreZone.EndIDoubleScoreZone(builder);
		}

		// Token: 0x0601BB5F RID: 113503 RVA: 0x003EB528 File Offset: 0x003E9728
		public static void StartIDoubleScoreZone(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601BB60 RID: 113504 RVA: 0x003EB531 File Offset: 0x003E9731
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601BB61 RID: 113505 RVA: 0x003EB53C File Offset: 0x003E973C
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601BB62 RID: 113506 RVA: 0x003EB547 File Offset: 0x003E9747
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601BB63 RID: 113507 RVA: 0x003EB552 File Offset: 0x003E9752
		public static Offset<IDoubleScoreZone> EndIDoubleScoreZone(FlatBufferBuilder builder)
		{
			return new Offset<IDoubleScoreZone>(builder.EndTable());
		}

		// Token: 0x0601BB64 RID: 113508 RVA: 0x003EB560 File Offset: 0x003E9760
		public IDoubleScoreZoneT UnPack()
		{
			IDoubleScoreZoneT doubleScoreZoneT = new IDoubleScoreZoneT();
			this.UnPackTo(doubleScoreZoneT);
			return doubleScoreZoneT;
		}

		// Token: 0x0601BB65 RID: 113509 RVA: 0x003EB57B File Offset: 0x003E977B
		public void UnPackTo(IDoubleScoreZoneT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601BB66 RID: 113510 RVA: 0x003EB5A4 File Offset: 0x003E97A4
		public static Offset<IDoubleScoreZone> Pack(FlatBufferBuilder builder, IDoubleScoreZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<IDoubleScoreZone>);
			}
			return IDoubleScoreZone.CreateIDoubleScoreZone(builder, _o.Type, _o.Score, _o.NullMask);
		}

		// Token: 0x0400CED3 RID: 52947
		private Table __p;
	}
}
