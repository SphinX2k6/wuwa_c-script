using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E8F RID: 3727
	public struct KurotatoMonsterBody : IFlatbufferObject
	{
		// Token: 0x17001C42 RID: 7234
		// (get) Token: 0x060090F3 RID: 37107 RVA: 0x0028F5D4 File Offset: 0x0028D7D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060090F4 RID: 37108 RVA: 0x0028F5E1 File Offset: 0x0028D7E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060090F5 RID: 37109 RVA: 0x0028F5E8 File Offset: 0x0028D7E8
		public static KurotatoMonsterBody GetRootAsKurotatoMonsterBody(ByteBuffer _bb)
		{
			return KurotatoMonsterBody.GetRootAsKurotatoMonsterBody(_bb, default(KurotatoMonsterBody));
		}

		// Token: 0x060090F6 RID: 37110 RVA: 0x0028F604 File Offset: 0x0028D804
		public static KurotatoMonsterBody GetRootAsKurotatoMonsterBody(ByteBuffer _bb, KurotatoMonsterBody obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060090F7 RID: 37111 RVA: 0x0028F621 File Offset: 0x0028D821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060090F8 RID: 37112 RVA: 0x0028F630 File Offset: 0x0028D830
		public KurotatoMonsterBody __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001C43 RID: 7235
		// (get) Token: 0x060090F9 RID: 37113 RVA: 0x0028F640 File Offset: 0x0028D840
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

		// Token: 0x17001C44 RID: 7236
		// (get) Token: 0x060090FA RID: 37114 RVA: 0x0028F67C File Offset: 0x0028D87C
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

		// Token: 0x060090FB RID: 37115 RVA: 0x0028F6B3 File Offset: 0x0028D8B3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060090FC RID: 37116 RVA: 0x0028F6C2 File Offset: 0x0028D8C2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04005421 RID: 21537
		private Table __p;
	}
}
