using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.LevelPlay
{
	// Token: 0x02004A19 RID: 18969
	public struct ISingleScoreZone : IFlatbufferObject
	{
		// Token: 0x1700850F RID: 34063
		// (get) Token: 0x0601C76A RID: 116586 RVA: 0x00404EC8 File Offset: 0x004030C8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601C76B RID: 116587 RVA: 0x00404ED5 File Offset: 0x004030D5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601C76C RID: 116588 RVA: 0x00404EDC File Offset: 0x004030DC
		public static ISingleScoreZone GetRootAsISingleScoreZone(ByteBuffer _bb)
		{
			return ISingleScoreZone.GetRootAsISingleScoreZone(_bb, default(ISingleScoreZone));
		}

		// Token: 0x0601C76D RID: 116589 RVA: 0x00404EF8 File Offset: 0x004030F8
		public static ISingleScoreZone GetRootAsISingleScoreZone(ByteBuffer _bb, ISingleScoreZone obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601C76E RID: 116590 RVA: 0x00404F15 File Offset: 0x00403115
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601C76F RID: 116591 RVA: 0x00404F24 File Offset: 0x00403124
		public ISingleScoreZone __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008510 RID: 34064
		// (get) Token: 0x0601C770 RID: 116592 RVA: 0x00404F34 File Offset: 0x00403134
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

		// Token: 0x17008511 RID: 34065
		// (get) Token: 0x0601C771 RID: 116593 RVA: 0x00404F70 File Offset: 0x00403170
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

		// Token: 0x17008512 RID: 34066
		// (get) Token: 0x0601C772 RID: 116594 RVA: 0x00404FAC File Offset: 0x004031AC
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

		// Token: 0x0601C773 RID: 116595 RVA: 0x00404FE8 File Offset: 0x004031E8
		public static Offset<ISingleScoreZone> CreateISingleScoreZone(FlatBufferBuilder builder, EDartboardZoneType Type = EDartboardZoneType.CenterBull, int Score = 0, byte NullMask = 0)
		{
			builder.StartTable(3);
			ISingleScoreZone.AddScore(builder, Score);
			ISingleScoreZone.AddNullMask(builder, NullMask);
			ISingleScoreZone.AddType(builder, Type);
			return ISingleScoreZone.EndISingleScoreZone(builder);
		}

		// Token: 0x0601C774 RID: 116596 RVA: 0x0040500C File Offset: 0x0040320C
		public static void StartISingleScoreZone(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0601C775 RID: 116597 RVA: 0x00405015 File Offset: 0x00403215
		public static void AddType(FlatBufferBuilder builder, EDartboardZoneType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601C776 RID: 116598 RVA: 0x00405020 File Offset: 0x00403220
		public static void AddScore(FlatBufferBuilder builder, int score)
		{
			builder.AddInt(1, score, 0);
		}

		// Token: 0x0601C777 RID: 116599 RVA: 0x0040502B File Offset: 0x0040322B
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(2, nullMask, 0);
		}

		// Token: 0x0601C778 RID: 116600 RVA: 0x00405036 File Offset: 0x00403236
		public static Offset<ISingleScoreZone> EndISingleScoreZone(FlatBufferBuilder builder)
		{
			return new Offset<ISingleScoreZone>(builder.EndTable());
		}

		// Token: 0x0601C779 RID: 116601 RVA: 0x00405044 File Offset: 0x00403244
		public ISingleScoreZoneT UnPack()
		{
			ISingleScoreZoneT singleScoreZoneT = new ISingleScoreZoneT();
			this.UnPackTo(singleScoreZoneT);
			return singleScoreZoneT;
		}

		// Token: 0x0601C77A RID: 116602 RVA: 0x0040505F File Offset: 0x0040325F
		public void UnPackTo(ISingleScoreZoneT _o)
		{
			_o.Type = this.Type;
			_o.Score = this.Score;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0601C77B RID: 116603 RVA: 0x00405088 File Offset: 0x00403288
		public static Offset<ISingleScoreZone> Pack(FlatBufferBuilder builder, ISingleScoreZoneT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISingleScoreZone>);
			}
			return ISingleScoreZone.CreateISingleScoreZone(builder, _o.Type, _o.Score, _o.NullMask);
		}

		// Token: 0x0400D0A9 RID: 53417
		private Table __p;
	}
}
