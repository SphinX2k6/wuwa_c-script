using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010DE RID: 4318
	public struct RogueResCollection : IFlatbufferObject
	{
		// Token: 0x1700305C RID: 12380
		// (get) Token: 0x0600C78A RID: 51082 RVA: 0x003062AB File Offset: 0x003044AB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C78B RID: 51083 RVA: 0x003062B8 File Offset: 0x003044B8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C78C RID: 51084 RVA: 0x003062C0 File Offset: 0x003044C0
		public static RogueResCollection GetRootAsRogueResCollection(ByteBuffer _bb)
		{
			return RogueResCollection.GetRootAsRogueResCollection(_bb, default(RogueResCollection));
		}

		// Token: 0x0600C78D RID: 51085 RVA: 0x003062DC File Offset: 0x003044DC
		public static RogueResCollection GetRootAsRogueResCollection(ByteBuffer _bb, RogueResCollection obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C78E RID: 51086 RVA: 0x003062F9 File Offset: 0x003044F9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C78F RID: 51087 RVA: 0x00306308 File Offset: 0x00304508
		public RogueResCollection __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700305D RID: 12381
		// (get) Token: 0x0600C790 RID: 51088 RVA: 0x00306318 File Offset: 0x00304518
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

		// Token: 0x1700305E RID: 12382
		// (get) Token: 0x0600C791 RID: 51089 RVA: 0x00306354 File Offset: 0x00304554
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

		// Token: 0x1700305F RID: 12383
		// (get) Token: 0x0600C792 RID: 51090 RVA: 0x00306390 File Offset: 0x00304590
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

		// Token: 0x17003060 RID: 12384
		// (get) Token: 0x0600C793 RID: 51091 RVA: 0x003063CC File Offset: 0x003045CC
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

		// Token: 0x17003061 RID: 12385
		// (get) Token: 0x0600C794 RID: 51092 RVA: 0x0030640C File Offset: 0x0030460C
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

		// Token: 0x17003062 RID: 12386
		// (get) Token: 0x0600C795 RID: 51093 RVA: 0x0030644C File Offset: 0x0030464C
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

		// Token: 0x0600C796 RID: 51094 RVA: 0x00306484 File Offset: 0x00304684
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600C797 RID: 51095 RVA: 0x00306494 File Offset: 0x00304694
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17003063 RID: 12387
		// (get) Token: 0x0600C798 RID: 51096 RVA: 0x003064AC File Offset: 0x003046AC
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

		// Token: 0x17003064 RID: 12388
		// (get) Token: 0x0600C799 RID: 51097 RVA: 0x003064EC File Offset: 0x003046EC
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

		// Token: 0x17003065 RID: 12389
		// (get) Token: 0x0600C79A RID: 51098 RVA: 0x0030652C File Offset: 0x0030472C
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

		// Token: 0x040056C6 RID: 22214
		private Table __p;
	}
}
