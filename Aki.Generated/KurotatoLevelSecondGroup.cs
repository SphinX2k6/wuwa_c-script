using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DA6 RID: 3494
	public struct KurotatoLevelSecondGroup : IFlatbufferObject
	{
		// Token: 0x17001BC2 RID: 7106
		// (get) Token: 0x06008A80 RID: 35456 RVA: 0x0027015C File Offset: 0x0026E35C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008A81 RID: 35457 RVA: 0x00270169 File Offset: 0x0026E369
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008A82 RID: 35458 RVA: 0x00270170 File Offset: 0x0026E370
		public static KurotatoLevelSecondGroup GetRootAsKurotatoLevelSecondGroup(ByteBuffer _bb)
		{
			return KurotatoLevelSecondGroup.GetRootAsKurotatoLevelSecondGroup(_bb, default(KurotatoLevelSecondGroup));
		}

		// Token: 0x06008A83 RID: 35459 RVA: 0x0027018C File Offset: 0x0026E38C
		public static KurotatoLevelSecondGroup GetRootAsKurotatoLevelSecondGroup(ByteBuffer _bb, KurotatoLevelSecondGroup obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008A84 RID: 35460 RVA: 0x002701A9 File Offset: 0x0026E3A9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008A85 RID: 35461 RVA: 0x002701B8 File Offset: 0x0026E3B8
		public KurotatoLevelSecondGroup __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BC3 RID: 7107
		// (get) Token: 0x06008A86 RID: 35462 RVA: 0x002701C8 File Offset: 0x0026E3C8
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

		// Token: 0x17001BC4 RID: 7108
		// (get) Token: 0x06008A87 RID: 35463 RVA: 0x00270204 File Offset: 0x0026E404
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

		// Token: 0x06008A88 RID: 35464 RVA: 0x0027023B File Offset: 0x0026E43B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008A89 RID: 35465 RVA: 0x0027024A File Offset: 0x0026E44A
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BC5 RID: 7109
		// (get) Token: 0x06008A8A RID: 35466 RVA: 0x00270264 File Offset: 0x0026E464
		public string TitleBg
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

		// Token: 0x06008A8B RID: 35467 RVA: 0x0027029B File Offset: 0x0026E49B
		public Span<byte> GetTitleBgBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06008A8C RID: 35468 RVA: 0x002702AA File Offset: 0x0026E4AA
		public byte[] GetTitleBgArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004E38 RID: 20024
		private Table __p;
	}
}
