using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A3D RID: 19005
	public struct ITripleScoreZone : IFlatbufferObject
	{
		// Token: 0x17008555 RID: 34133
		// (get) Token: 0x0601C8A2 RID: 116898 RVA: 0x004070DE File Offset: 0x004052DE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C8A3 RID: 116899 RVA: 0x004070EB File Offset: 0x004052EB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C8A4 RID: 116900 RVA: 0x004070F4 File Offset: 0x004052F4
		public static ITripleScoreZone GetRootAsITripleScoreZone(ByteBuffer _bb)
		{
			return ITripleScoreZone.GetRootAsITripleScoreZone(_bb, default(ITripleScoreZone));
		}

		// Token: 0x0601C8A5 RID: 116901 RVA: 0x00407110 File Offset: 0x00405310
		public static ITripleScoreZone GetRootAsITripleScoreZone(ByteBuffer _bb, ITripleScoreZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C8A6 RID: 116902 RVA: 0x0040712D File Offset: 0x0040532D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C8A7 RID: 116903 RVA: 0x0040713C File Offset: 0x0040533C
		public ITripleScoreZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008556 RID: 34134
		// (get) Token: 0x0601C8A8 RID: 116904 RVA: 0x0040714C File Offset: 0x0040534C
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

		// Token: 0x17008557 RID: 34135
		// (get) Token: 0x0601C8A9 RID: 116905 RVA: 0x00407188 File Offset: 0x00405388
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

		// Token: 0x17008558 RID: 34136
		// (get) Token: 0x0601C8AA RID: 116906 RVA: 0x004071C4 File Offset: 0x004053C4
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

		// Token: 0x0601C8AB RID: 116907 RVA: 0x00407200 File Offset: 0x00405400
		public static Offset<ITripleScoreZone> CreateITripleScoreZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull, int Score = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ITripleScoreZone.AddScore(builder, Score);
			ITripleScoreZone.AddNullMask(builder, NullMask);
			ITripleScoreZone.AddType(builder, Type);
			return ITripleScoreZone.EndITripleScoreZone(builder);
		}

		// Token: 0x0601C8AC RID: 116908 RVA: 0x00407224 File Offset: 0x00405424
		public static void StartITripleScoreZone(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C8AD RID: 116909 RVA: 0x0040722D File Offset: 0x0040542D
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C8AE RID: 116910 RVA: 0x00407238 File Offset: 0x00405438
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601C8AF RID: 116911 RVA: 0x00407243 File Offset: 0x00405443
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601C8B0 RID: 116912 RVA: 0x0040724E File Offset: 0x0040544E
		public static Offset<ITripleScoreZone> EndITripleScoreZone(FlatBufferBuilder builder)
		{
			return new Offset<ITripleScoreZone>(builder.EndTable());
		}

		// Token: 0x0601C8B1 RID: 116913 RVA: 0x0040725C File Offset: 0x0040545C
		public ITripleScoreZoneT UnPack()
		{
			ITripleScoreZoneT tripleScoreZoneT = new ITripleScoreZoneT();
			this.UnPackTo(tripleScoreZoneT);
			return tripleScoreZoneT;
		}

		// Token: 0x0601C8B2 RID: 116914 RVA: 0x00407277 File Offset: 0x00405477
		public void UnPackTo(ITripleScoreZoneT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C8B3 RID: 116915 RVA: 0x004072A0 File Offset: 0x004054A0
		public static Offset<ITripleScoreZone> Pack(FlatBufferBuilder builder, ITripleScoreZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITripleScoreZone>);
			}
			return ITripleScoreZone.CreateITripleScoreZone(builder, _o.Type, _o.Score, _o.NullMask);
		}

		// Token: 0x0400D0D8 RID: 53464
		private Table __p;
	}
}
