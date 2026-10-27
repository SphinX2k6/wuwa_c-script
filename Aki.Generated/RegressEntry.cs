using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FAD RID: 4013
	public struct RegressEntry : IFlatbufferObject
	{
		// Token: 0x17002DA2 RID: 11682
		// (get) Token: 0x0600BAE7 RID: 47847 RVA: 0x002DBCD1 File Offset: 0x002D9ED1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600BAE8 RID: 47848 RVA: 0x002DBCDE File Offset: 0x002D9EDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600BAE9 RID: 47849 RVA: 0x002DBCE8 File Offset: 0x002D9EE8
		public static RegressEntry GetRootAsRegressEntry(ByteBuffer _bb)
		{
			return RegressEntry.GetRootAsRegressEntry(_bb, default(RegressEntry));
		}

		// Token: 0x0600BAEA RID: 47850 RVA: 0x002DBD04 File Offset: 0x002D9F04
		public static RegressEntry GetRootAsRegressEntry(ByteBuffer _bb, RegressEntry obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600BAEB RID: 47851 RVA: 0x002DBD21 File Offset: 0x002D9F21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600BAEC RID: 47852 RVA: 0x002DBD30 File Offset: 0x002D9F30
		public RegressEntry __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002DA3 RID: 11683
		// (get) Token: 0x0600BAED RID: 47853 RVA: 0x002DBD40 File Offset: 0x002D9F40
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

		// Token: 0x17002DA4 RID: 11684
		// (get) Token: 0x0600BAEE RID: 47854 RVA: 0x002DBD7C File Offset: 0x002D9F7C
		public int EntryType
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

		// Token: 0x17002DA5 RID: 11685
		// (get) Token: 0x0600BAEF RID: 47855 RVA: 0x002DBDB8 File Offset: 0x002D9FB8
		public string Title
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

		// Token: 0x0600BAF0 RID: 47856 RVA: 0x002DBDEF File Offset: 0x002D9FEF
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600BAF1 RID: 47857 RVA: 0x002DBDFE File Offset: 0x002D9FFE
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DA6 RID: 11686
		// (get) Token: 0x0600BAF2 RID: 47858 RVA: 0x002DBE18 File Offset: 0x002DA018
		public string IconPathF
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

		// Token: 0x0600BAF3 RID: 47859 RVA: 0x002DBE50 File Offset: 0x002DA050
		public Span<byte> GetIconPathFBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600BAF4 RID: 47860 RVA: 0x002DBE60 File Offset: 0x002DA060
		public byte[] GetIconPathFArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DA7 RID: 11687
		// (get) Token: 0x0600BAF5 RID: 47861 RVA: 0x002DBE78 File Offset: 0x002DA078
		public string IconPath
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

		// Token: 0x0600BAF6 RID: 47862 RVA: 0x002DBEB0 File Offset: 0x002DA0B0
		public Span<byte> GetIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600BAF7 RID: 47863 RVA: 0x002DBEC0 File Offset: 0x002DA0C0
		public byte[] GetIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002DA8 RID: 11688
		// (get) Token: 0x0600BAF8 RID: 47864 RVA: 0x002DBED8 File Offset: 0x002DA0D8
		public int GachaId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002DA9 RID: 11689
		// (get) Token: 0x0600BAF9 RID: 47865 RVA: 0x002DBF18 File Offset: 0x002DA118
		public int Grade
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04005086 RID: 20614
		private Table __p;
	}
}
