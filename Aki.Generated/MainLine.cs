using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DE6 RID: 3558
	public struct MainLine : IFlatbufferObject
	{
		// Token: 0x17001DBA RID: 7610
		// (get) Token: 0x0600906E RID: 36974 RVA: 0x0027CF48 File Offset: 0x0027B148
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600906F RID: 36975 RVA: 0x0027CF55 File Offset: 0x0027B155
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009070 RID: 36976 RVA: 0x0027CF5C File Offset: 0x0027B15C
		public static MainLine GetRootAsMainLine(ByteBuffer _bb)
		{
			return MainLine.GetRootAsMainLine(_bb, default(MainLine));
		}

		// Token: 0x06009071 RID: 36977 RVA: 0x0027CF78 File Offset: 0x0027B178
		public static MainLine GetRootAsMainLine(ByteBuffer _bb, MainLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009072 RID: 36978 RVA: 0x0027CF95 File Offset: 0x0027B195
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009073 RID: 36979 RVA: 0x0027CFA4 File Offset: 0x0027B1A4
		public MainLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001DBB RID: 7611
		// (get) Token: 0x06009074 RID: 36980 RVA: 0x0027CFB4 File Offset: 0x0027B1B4
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

		// Token: 0x17001DBC RID: 7612
		// (get) Token: 0x06009075 RID: 36981 RVA: 0x0027CFF0 File Offset: 0x0027B1F0
		public int TaskId
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

		// Token: 0x17001DBD RID: 7613
		// (get) Token: 0x06009076 RID: 36982 RVA: 0x0027D02C File Offset: 0x0027B22C
		public int PrevTaskId
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

		// Token: 0x17001DBE RID: 7614
		// (get) Token: 0x06009077 RID: 36983 RVA: 0x0027D068 File Offset: 0x0027B268
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009078 RID: 36984 RVA: 0x0027D0A0 File Offset: 0x0027B2A0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009079 RID: 36985 RVA: 0x0027D0B0 File Offset: 0x0027B2B0
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DBF RID: 7615
		// (get) Token: 0x0600907A RID: 36986 RVA: 0x0027D0C8 File Offset: 0x0027B2C8
		public string UnlockTip
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600907B RID: 36987 RVA: 0x0027D100 File Offset: 0x0027B300
		public Span<byte> GetUnlockTipBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600907C RID: 36988 RVA: 0x0027D110 File Offset: 0x0027B310
		public byte[] GetUnlockTipArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DC0 RID: 7616
		// (get) Token: 0x0600907D RID: 36989 RVA: 0x0027D128 File Offset: 0x0027B328
		public string TaskName
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

		// Token: 0x0600907E RID: 36990 RVA: 0x0027D160 File Offset: 0x0027B360
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600907F RID: 36991 RVA: 0x0027D170 File Offset: 0x0027B370
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001DC1 RID: 7617
		// (get) Token: 0x06009080 RID: 36992 RVA: 0x0027D188 File Offset: 0x0027B388
		public int TaskType
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

		// Token: 0x04004E82 RID: 20098
		private Table __p;
	}
}
