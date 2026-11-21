using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D50 RID: 3408
	public struct FightPhotoTab : IFlatbufferObject
	{
		// Token: 0x17001140 RID: 4416
		// (get) Token: 0x06007426 RID: 29734 RVA: 0x0024D6E2 File Offset: 0x0024B8E2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007427 RID: 29735 RVA: 0x0024D6EF File Offset: 0x0024B8EF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007428 RID: 29736 RVA: 0x0024D6F8 File Offset: 0x0024B8F8
		public static FightPhotoTab GetRootAsFightPhotoTab(ByteBuffer _bb)
		{
			return FightPhotoTab.GetRootAsFightPhotoTab(_bb, default(FightPhotoTab));
		}

		// Token: 0x06007429 RID: 29737 RVA: 0x0024D714 File Offset: 0x0024B914
		public static FightPhotoTab GetRootAsFightPhotoTab(ByteBuffer _bb, FightPhotoTab obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600742A RID: 29738 RVA: 0x0024D731 File Offset: 0x0024B931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600742B RID: 29739 RVA: 0x0024D740 File Offset: 0x0024B940
		public FightPhotoTab __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001141 RID: 4417
		// (get) Token: 0x0600742C RID: 29740 RVA: 0x0024D750 File Offset: 0x0024B950
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

		// Token: 0x17001142 RID: 4418
		// (get) Token: 0x0600742D RID: 29741 RVA: 0x0024D78C File Offset: 0x0024B98C
		public int SortId
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

		// Token: 0x17001143 RID: 4419
		// (get) Token: 0x0600742E RID: 29742 RVA: 0x0024D7C8 File Offset: 0x0024B9C8
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

		// Token: 0x0600742F RID: 29743 RVA: 0x0024D7FF File Offset: 0x0024B9FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06007430 RID: 29744 RVA: 0x0024D80E File Offset: 0x0024BA0E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001144 RID: 4420
		// (get) Token: 0x06007431 RID: 29745 RVA: 0x0024D828 File Offset: 0x0024BA28
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

		// Token: 0x06007432 RID: 29746 RVA: 0x0024D860 File Offset: 0x0024BA60
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007433 RID: 29747 RVA: 0x0024D870 File Offset: 0x0024BA70
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001145 RID: 4421
		// (get) Token: 0x06007434 RID: 29748 RVA: 0x0024D888 File Offset: 0x0024BA88
		public string UnselectedIcon
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

		// Token: 0x06007435 RID: 29749 RVA: 0x0024D8C0 File Offset: 0x0024BAC0
		public Span<byte> GetUnselectedIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007436 RID: 29750 RVA: 0x0024D8D0 File Offset: 0x0024BAD0
		public byte[] GetUnselectedIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17001146 RID: 4422
		// (get) Token: 0x06007437 RID: 29751 RVA: 0x0024D8E8 File Offset: 0x0024BAE8
		public bool IsShowRedDot
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0400529B RID: 21147
		private Table __p;
	}
}
