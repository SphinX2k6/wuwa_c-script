using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AAC RID: 2732
	public struct AbyssCastDesc : IFlatbufferObject
	{
		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600404C RID: 16460 RVA: 0x001C4D41 File Offset: 0x001C2F41
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600404D RID: 16461 RVA: 0x001C4D4E File Offset: 0x001C2F4E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600404E RID: 16462 RVA: 0x001C4D58 File Offset: 0x001C2F58
		public static AbyssCastDesc GetRootAsAbyssCastDesc(ByteBuffer _bb)
		{
			return AbyssCastDesc.GetRootAsAbyssCastDesc(_bb, default(AbyssCastDesc));
		}

		// Token: 0x0600404F RID: 16463 RVA: 0x001C4D74 File Offset: 0x001C2F74
		public static AbyssCastDesc GetRootAsAbyssCastDesc(ByteBuffer _bb, AbyssCastDesc obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004050 RID: 16464 RVA: 0x001C4D91 File Offset: 0x001C2F91
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004051 RID: 16465 RVA: 0x001C4DA0 File Offset: 0x001C2FA0
		public AbyssCastDesc __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06004052 RID: 16466 RVA: 0x001C4DB0 File Offset: 0x001C2FB0
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

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x06004053 RID: 16467 RVA: 0x001C4DEC File Offset: 0x001C2FEC
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

		// Token: 0x06004054 RID: 16468 RVA: 0x001C4E23 File Offset: 0x001C3023
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004055 RID: 16469 RVA: 0x001C4E32 File Offset: 0x001C3032
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06004056 RID: 16470 RVA: 0x001C4E4C File Offset: 0x001C304C
		public string Icon
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

		// Token: 0x06004057 RID: 16471 RVA: 0x001C4E83 File Offset: 0x001C3083
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004058 RID: 16472 RVA: 0x001C4E92 File Offset: 0x001C3092
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004A7C RID: 19068
		private Table __p;
	}
}
