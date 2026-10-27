using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x020045D5 RID: 17877
	public struct ITripleScoreZone : IFlatbufferObject
	{
		// Token: 0x17007F14 RID: 32532
		// (get) Token: 0x0601B0CD RID: 110797 RVA: 0x003DAE42 File Offset: 0x003D9042
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601B0CE RID: 110798 RVA: 0x003DAE4F File Offset: 0x003D904F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601B0CF RID: 110799 RVA: 0x003DAE58 File Offset: 0x003D9058
		public static ITripleScoreZone GetRootAsITripleScoreZone(ByteBuffer _bb)
		{
			return ITripleScoreZone.GetRootAsITripleScoreZone(_bb, default(ITripleScoreZone));
		}

		// Token: 0x0601B0D0 RID: 110800 RVA: 0x003DAE74 File Offset: 0x003D9074
		public static ITripleScoreZone GetRootAsITripleScoreZone(ByteBuffer _bb, ITripleScoreZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601B0D1 RID: 110801 RVA: 0x003DAE91 File Offset: 0x003D9091
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601B0D2 RID: 110802 RVA: 0x003DAEA0 File Offset: 0x003D90A0
		public ITripleScoreZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17007F15 RID: 32533
		// (get) Token: 0x0601B0D3 RID: 110803 RVA: 0x003DAEB0 File Offset: 0x003D90B0
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

		// Token: 0x17007F16 RID: 32534
		// (get) Token: 0x0601B0D4 RID: 110804 RVA: 0x003DAEEC File Offset: 0x003D90EC
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

		// Token: 0x17007F17 RID: 32535
		// (get) Token: 0x0601B0D5 RID: 110805 RVA: 0x003DAF28 File Offset: 0x003D9128
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

		// Token: 0x0601B0D6 RID: 110806 RVA: 0x003DAF64 File Offset: 0x003D9164
		public static Offset<ITripleScoreZone> CreateITripleScoreZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull, int Score = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITripleScoreZone.AddScore(builder, Score);
			ITripleScoreZone.AddNullMask(builder, NullMask);
			ITripleScoreZone.AddType(builder, Type);
			return ITripleScoreZone.EndITripleScoreZone(builder);
		}

		// Token: 0x0601B0D7 RID: 110807 RVA: 0x003DAF88 File Offset: 0x003D9188
		public static void StartITripleScoreZone(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601B0D8 RID: 110808 RVA: 0x003DAF91 File Offset: 0x003D9191
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601B0D9 RID: 110809 RVA: 0x003DAF9C File Offset: 0x003D919C
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601B0DA RID: 110810 RVA: 0x003DAFA7 File Offset: 0x003D91A7
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601B0DB RID: 110811 RVA: 0x003DAFB2 File Offset: 0x003D91B2
		public static Offset<ITripleScoreZone> EndITripleScoreZone(FlatBufferBuilder builder)
		{
			return new Offset<ITripleScoreZone>(builder.EndTable());
		}

		// Token: 0x0601B0DC RID: 110812 RVA: 0x003DAFC0 File Offset: 0x003D91C0
		public ITripleScoreZoneT UnPack()
		{
			ITripleScoreZoneT tripleScoreZoneT = new ITripleScoreZoneT();
			this.UnPackTo(tripleScoreZoneT);
			return tripleScoreZoneT;
		}

		// Token: 0x0601B0DD RID: 110813 RVA: 0x003DAFDB File Offset: 0x003D91DB
		public void UnPackTo(ITripleScoreZoneT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601B0DE RID: 110814 RVA: 0x003DB004 File Offset: 0x003D9204
		public static Offset<ITripleScoreZone> Pack(FlatBufferBuilder builder, ITripleScoreZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITripleScoreZone>);
			}
			return ITripleScoreZone.CreateITripleScoreZone(builder, _o.Type, _o.Score, _o.NullMask);
		}

		// Token: 0x0400C6A9 RID: 50857
		private Table __p;
	}
}
