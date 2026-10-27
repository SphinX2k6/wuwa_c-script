using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FF6 RID: 4086
	public struct RogueResCollection : IFlatbufferObject
	{
		// Token: 0x17002FE1 RID: 12257
		// (get) Token: 0x0600C140 RID: 49472 RVA: 0x002EA001 File Offset: 0x002E8201
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C141 RID: 49473 RVA: 0x002EA00E File Offset: 0x002E820E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C142 RID: 49474 RVA: 0x002EA018 File Offset: 0x002E8218
		public static RogueResCollection GetRootAsRogueResCollection(ByteBuffer _bb)
		{
			return RogueResCollection.GetRootAsRogueResCollection(_bb, default(RogueResCollection));
		}

		// Token: 0x0600C143 RID: 49475 RVA: 0x002EA034 File Offset: 0x002E8234
		public static RogueResCollection GetRootAsRogueResCollection(ByteBuffer _bb, RogueResCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C144 RID: 49476 RVA: 0x002EA051 File Offset: 0x002E8251
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C145 RID: 49477 RVA: 0x002EA060 File Offset: 0x002E8260
		public RogueResCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002FE2 RID: 12258
		// (get) Token: 0x0600C146 RID: 49478 RVA: 0x002EA070 File Offset: 0x002E8270
		public int IdKey
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

		// Token: 0x17002FE3 RID: 12259
		// (get) Token: 0x0600C147 RID: 49479 RVA: 0x002EA0AC File Offset: 0x002E82AC
		public int Id
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

		// Token: 0x17002FE4 RID: 12260
		// (get) Token: 0x0600C148 RID: 49480 RVA: 0x002EA0E8 File Offset: 0x002E82E8
		public int Index
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

		// Token: 0x17002FE5 RID: 12261
		// (get) Token: 0x0600C149 RID: 49481 RVA: 0x002EA124 File Offset: 0x002E8324
		public int Type
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

		// Token: 0x17002FE6 RID: 12262
		// (get) Token: 0x0600C14A RID: 49482 RVA: 0x002EA164 File Offset: 0x002E8364
		public int SortId
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

		// Token: 0x17002FE7 RID: 12263
		// (get) Token: 0x0600C14B RID: 49483 RVA: 0x002EA1A4 File Offset: 0x002E83A4
		public string Desc
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

		// Token: 0x0600C14C RID: 49484 RVA: 0x002EA1DC File Offset: 0x002E83DC
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C14D RID: 49485 RVA: 0x002EA1EC File Offset: 0x002E83EC
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17002FE8 RID: 12264
		// (get) Token: 0x0600C14E RID: 49486 RVA: 0x002EA204 File Offset: 0x002E8404
		public int RuleId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002FE9 RID: 12265
		// (get) Token: 0x0600C14F RID: 49487 RVA: 0x002EA244 File Offset: 0x002E8444
		public int Cond
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002FEA RID: 12266
		// (get) Token: 0x0600C150 RID: 49488 RVA: 0x002EA284 File Offset: 0x002E8484
		public int Award
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x040050DE RID: 20702
		private Table __p;
	}
}
