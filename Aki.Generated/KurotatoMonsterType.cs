using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DAD RID: 3501
	public struct KurotatoMonsterType : IFlatbufferObject
	{
		// Token: 0x17001BEC RID: 7148
		// (get) Token: 0x06008B04 RID: 35588 RVA: 0x00271170 File Offset: 0x0026F370
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008B05 RID: 35589 RVA: 0x0027117D File Offset: 0x0026F37D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008B06 RID: 35590 RVA: 0x00271184 File Offset: 0x0026F384
		public static KurotatoMonsterType GetRootAsKurotatoMonsterType(ByteBuffer _bb)
		{
			return KurotatoMonsterType.GetRootAsKurotatoMonsterType(_bb, default(KurotatoMonsterType));
		}

		// Token: 0x06008B07 RID: 35591 RVA: 0x002711A0 File Offset: 0x0026F3A0
		public static KurotatoMonsterType GetRootAsKurotatoMonsterType(ByteBuffer _bb, KurotatoMonsterType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008B08 RID: 35592 RVA: 0x002711BD File Offset: 0x0026F3BD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008B09 RID: 35593 RVA: 0x002711CC File Offset: 0x0026F3CC
		public KurotatoMonsterType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BED RID: 7149
		// (get) Token: 0x06008B0A RID: 35594 RVA: 0x002711DC File Offset: 0x0026F3DC
		public int Id
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

		// Token: 0x17001BEE RID: 7150
		// (get) Token: 0x06008B0B RID: 35595 RVA: 0x00271218 File Offset: 0x0026F418
		public int RiskType
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

		// Token: 0x17001BEF RID: 7151
		// (get) Token: 0x06008B0C RID: 35596 RVA: 0x00271254 File Offset: 0x0026F454
		public string Name
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008B0D RID: 35597 RVA: 0x0027128B File Offset: 0x0026F48B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008B0E RID: 35598 RVA: 0x0027129A File Offset: 0x0026F49A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BF0 RID: 7152
		// (get) Token: 0x06008B0F RID: 35599 RVA: 0x002712B4 File Offset: 0x0026F4B4
		public int TemplateId
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

		// Token: 0x17001BF1 RID: 7153
		// (get) Token: 0x06008B10 RID: 35600 RVA: 0x002712F4 File Offset: 0x0026F4F4
		public int BodyType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001BF2 RID: 7154
		// (get) Token: 0x06008B11 RID: 35601 RVA: 0x00271334 File Offset: 0x0026F534
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008B12 RID: 35602 RVA: 0x0027136C File Offset: 0x0026F56C
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008B13 RID: 35603 RVA: 0x0027137C File Offset: 0x0026F57C
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E3F RID: 20031
		private Table __p;
	}
}
