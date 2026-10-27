using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010F4 RID: 4340
	public struct SubLevelMap : IFlatbufferObject
	{
		// Token: 0x1700387A RID: 14458
		// (get) Token: 0x0600D99E RID: 55710 RVA: 0x00321C7C File Offset: 0x0031FE7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D99F RID: 55711 RVA: 0x00321C89 File Offset: 0x0031FE89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D9A0 RID: 55712 RVA: 0x00321C90 File Offset: 0x0031FE90
		public static SubLevelMap GetRootAsSubLevelMap(ByteBuffer _bb)
		{
			return SubLevelMap.GetRootAsSubLevelMap(_bb, default(SubLevelMap));
		}

		// Token: 0x0600D9A1 RID: 55713 RVA: 0x00321CAC File Offset: 0x0031FEAC
		public static SubLevelMap GetRootAsSubLevelMap(ByteBuffer _bb, SubLevelMap obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D9A2 RID: 55714 RVA: 0x00321CC9 File Offset: 0x0031FEC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D9A3 RID: 55715 RVA: 0x00321CD8 File Offset: 0x0031FED8
		public SubLevelMap __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700387B RID: 14459
		// (get) Token: 0x0600D9A4 RID: 55716 RVA: 0x00321CE8 File Offset: 0x0031FEE8
		public string MapPath
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D9A5 RID: 55717 RVA: 0x00321D1F File Offset: 0x0031FF1F
		public Span<byte> GetMapPathBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0600D9A6 RID: 55718 RVA: 0x00321D2E File Offset: 0x0031FF2E
		public byte[] GetMapPathArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x04005228 RID: 21032
		private Table __p;
	}
}
