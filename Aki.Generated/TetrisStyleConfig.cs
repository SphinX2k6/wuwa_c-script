using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200112A RID: 4394
	public struct TetrisStyleConfig : IFlatbufferObject
	{
		// Token: 0x17003A5E RID: 14942
		// (get) Token: 0x0600DE96 RID: 56982 RVA: 0x0032D4F0 File Offset: 0x0032B6F0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DE97 RID: 56983 RVA: 0x0032D4FD File Offset: 0x0032B6FD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DE98 RID: 56984 RVA: 0x0032D504 File Offset: 0x0032B704
		public static TetrisStyleConfig GetRootAsTetrisStyleConfig(ByteBuffer _bb)
		{
			return TetrisStyleConfig.GetRootAsTetrisStyleConfig(_bb, default(TetrisStyleConfig));
		}

		// Token: 0x0600DE99 RID: 56985 RVA: 0x0032D520 File Offset: 0x0032B720
		public static TetrisStyleConfig GetRootAsTetrisStyleConfig(ByteBuffer _bb, TetrisStyleConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DE9A RID: 56986 RVA: 0x0032D53D File Offset: 0x0032B73D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DE9B RID: 56987 RVA: 0x0032D54C File Offset: 0x0032B74C
		public TetrisStyleConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A5F RID: 14943
		// (get) Token: 0x0600DE9C RID: 56988 RVA: 0x0032D55C File Offset: 0x0032B75C
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

		// Token: 0x17003A60 RID: 14944
		// (get) Token: 0x0600DE9D RID: 56989 RVA: 0x0032D598 File Offset: 0x0032B798
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

		// Token: 0x0600DE9E RID: 56990 RVA: 0x0032D5CF File Offset: 0x0032B7CF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DE9F RID: 56991 RVA: 0x0032D5DE File Offset: 0x0032B7DE
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A61 RID: 14945
		// (get) Token: 0x0600DEA0 RID: 56992 RVA: 0x0032D5F8 File Offset: 0x0032B7F8
		public string MaterialPath
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

		// Token: 0x0600DEA1 RID: 56993 RVA: 0x0032D62F File Offset: 0x0032B82F
		public Span<byte> GetMaterialPathBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DEA2 RID: 56994 RVA: 0x0032D63E File Offset: 0x0032B83E
		public byte[] GetMaterialPathArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A62 RID: 14946
		// (get) Token: 0x0600DEA3 RID: 56995 RVA: 0x0032D658 File Offset: 0x0032B858
		public string ImagePath
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

		// Token: 0x0600DEA4 RID: 56996 RVA: 0x0032D690 File Offset: 0x0032B890
		public Span<byte> GetImagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DEA5 RID: 56997 RVA: 0x0032D6A0 File Offset: 0x0032B8A0
		public byte[] GetImagePathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04005268 RID: 21096
		private Table __p;
	}
}
