using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E90 RID: 3728
	public struct KurotatoMonsterRisk : IFlatbufferObject
	{
		// Token: 0x17001C45 RID: 7237
		// (get) Token: 0x060090FD RID: 37117 RVA: 0x0028F6D9 File Offset: 0x0028D8D9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090FE RID: 37118 RVA: 0x0028F6E6 File Offset: 0x0028D8E6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090FF RID: 37119 RVA: 0x0028F6F0 File Offset: 0x0028D8F0
		public static KurotatoMonsterRisk GetRootAsKurotatoMonsterRisk(ByteBuffer _bb)
		{
			return KurotatoMonsterRisk.GetRootAsKurotatoMonsterRisk(_bb, default(KurotatoMonsterRisk));
		}

		// Token: 0x06009100 RID: 37120 RVA: 0x0028F70C File Offset: 0x0028D90C
		public static KurotatoMonsterRisk GetRootAsKurotatoMonsterRisk(ByteBuffer _bb, KurotatoMonsterRisk obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009101 RID: 37121 RVA: 0x0028F729 File Offset: 0x0028D929
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009102 RID: 37122 RVA: 0x0028F738 File Offset: 0x0028D938
		public KurotatoMonsterRisk __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C46 RID: 7238
		// (get) Token: 0x06009103 RID: 37123 RVA: 0x0028F748 File Offset: 0x0028D948
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

		// Token: 0x17001C47 RID: 7239
		// (get) Token: 0x06009104 RID: 37124 RVA: 0x0028F784 File Offset: 0x0028D984
		public string Name
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009105 RID: 37125 RVA: 0x0028F7BB File Offset: 0x0028D9BB
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009106 RID: 37126 RVA: 0x0028F7CA File Offset: 0x0028D9CA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C48 RID: 7240
		// (get) Token: 0x06009107 RID: 37127 RVA: 0x0028F7E4 File Offset: 0x0028D9E4
		public string GridQualityPath
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

		// Token: 0x06009108 RID: 37128 RVA: 0x0028F81B File Offset: 0x0028DA1B
		public Span<byte> GetGridQualityPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009109 RID: 37129 RVA: 0x0028F82A File Offset: 0x0028DA2A
		public byte[] GetGridQualityPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C49 RID: 7241
		// (get) Token: 0x0600910A RID: 37130 RVA: 0x0028F844 File Offset: 0x0028DA44
		public string DescQualityPath
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

		// Token: 0x0600910B RID: 37131 RVA: 0x0028F87C File Offset: 0x0028DA7C
		public Span<byte> GetDescQualityPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600910C RID: 37132 RVA: 0x0028F88C File Offset: 0x0028DA8C
		public byte[] GetDescQualityPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001C4A RID: 7242
		// (get) Token: 0x0600910D RID: 37133 RVA: 0x0028F8A4 File Offset: 0x0028DAA4
		public string Icon
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

		// Token: 0x0600910E RID: 37134 RVA: 0x0028F8DC File Offset: 0x0028DADC
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600910F RID: 37135 RVA: 0x0028F8EC File Offset: 0x0028DAEC
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04005422 RID: 21538
		private Table __p;
	}
}
