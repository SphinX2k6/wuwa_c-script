using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E16 RID: 3606
	public struct MonsterHandBookType : IFlatbufferObject
	{
		// Token: 0x17001F73 RID: 8051
		// (get) Token: 0x06009514 RID: 38164 RVA: 0x00287A41 File Offset: 0x00285C41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009515 RID: 38165 RVA: 0x00287A4E File Offset: 0x00285C4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009516 RID: 38166 RVA: 0x00287A58 File Offset: 0x00285C58
		public static MonsterHandBookType GetRootAsMonsterHandBookType(ByteBuffer _bb)
		{
			return MonsterHandBookType.GetRootAsMonsterHandBookType(_bb, default(MonsterHandBookType));
		}

		// Token: 0x06009517 RID: 38167 RVA: 0x00287A74 File Offset: 0x00285C74
		public static MonsterHandBookType GetRootAsMonsterHandBookType(ByteBuffer _bb, MonsterHandBookType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009518 RID: 38168 RVA: 0x00287A91 File Offset: 0x00285C91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009519 RID: 38169 RVA: 0x00287AA0 File Offset: 0x00285CA0
		public MonsterHandBookType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F74 RID: 8052
		// (get) Token: 0x0600951A RID: 38170 RVA: 0x00287AB0 File Offset: 0x00285CB0
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

		// Token: 0x17001F75 RID: 8053
		// (get) Token: 0x0600951B RID: 38171 RVA: 0x00287AEC File Offset: 0x00285CEC
		public string Descrtption
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

		// Token: 0x0600951C RID: 38172 RVA: 0x00287B23 File Offset: 0x00285D23
		public Span<byte> GetDescrtptionBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600951D RID: 38173 RVA: 0x00287B32 File Offset: 0x00285D32
		public byte[] GetDescrtptionArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004EBB RID: 20155
		private Table __p;
	}
}
