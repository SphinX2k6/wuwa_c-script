using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0F RID: 3087
	public struct BattleTag : IFlatbufferObject
	{
		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x060052A6 RID: 21158 RVA: 0x00202F2D File Offset: 0x0020112D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060052A7 RID: 21159 RVA: 0x00202F3A File Offset: 0x0020113A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060052A8 RID: 21160 RVA: 0x00202F44 File Offset: 0x00201144
		public static BattleTag GetRootAsBattleTag(ByteBuffer _bb)
		{
			return BattleTag.GetRootAsBattleTag(_bb, default(BattleTag));
		}

		// Token: 0x060052A9 RID: 21161 RVA: 0x00202F60 File Offset: 0x00201160
		public static BattleTag GetRootAsBattleTag(ByteBuffer _bb, BattleTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060052AA RID: 21162 RVA: 0x00202F7D File Offset: 0x0020117D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060052AB RID: 21163 RVA: 0x00202F8C File Offset: 0x0020118C
		public BattleTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x060052AC RID: 21164 RVA: 0x00202F9C File Offset: 0x0020119C
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

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x060052AD RID: 21165 RVA: 0x00202FD8 File Offset: 0x002011D8
		public string Desc
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

		// Token: 0x060052AE RID: 21166 RVA: 0x0020300F File Offset: 0x0020120F
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060052AF RID: 21167 RVA: 0x0020301E File Offset: 0x0020121E
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000549 RID: 1353
		// (get) Token: 0x060052B0 RID: 21168 RVA: 0x00203038 File Offset: 0x00201238
		public string AddTag
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

		// Token: 0x060052B1 RID: 21169 RVA: 0x0020306F File Offset: 0x0020126F
		public Span<byte> GetAddTagBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060052B2 RID: 21170 RVA: 0x0020307E File Offset: 0x0020127E
		public byte[] GetAddTagArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x060052B3 RID: 21171 RVA: 0x00203098 File Offset: 0x00201298
		public string FinishTag
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

		// Token: 0x060052B4 RID: 21172 RVA: 0x002030D0 File Offset: 0x002012D0
		public Span<byte> GetFinishTagBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060052B5 RID: 21173 RVA: 0x002030E0 File Offset: 0x002012E0
		public byte[] GetFinishTagArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005107 RID: 20743
		private Table __p;
	}
}
