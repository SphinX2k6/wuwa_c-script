using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C6D RID: 3181
	public struct ComicPrefabConfig : IFlatbufferObject
	{
		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x06005D1F RID: 23839 RVA: 0x0021A3F9 File Offset: 0x002185F9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005D20 RID: 23840 RVA: 0x0021A406 File Offset: 0x00218606
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005D21 RID: 23841 RVA: 0x0021A410 File Offset: 0x00218610
		public static ComicPrefabConfig GetRootAsComicPrefabConfig(ByteBuffer _bb)
		{
			return ComicPrefabConfig.GetRootAsComicPrefabConfig(_bb, default(ComicPrefabConfig));
		}

		// Token: 0x06005D22 RID: 23842 RVA: 0x0021A42C File Offset: 0x0021862C
		public static ComicPrefabConfig GetRootAsComicPrefabConfig(ByteBuffer _bb, ComicPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005D23 RID: 23843 RVA: 0x0021A449 File Offset: 0x00218649
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005D24 RID: 23844 RVA: 0x0021A458 File Offset: 0x00218658
		public ComicPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x06005D25 RID: 23845 RVA: 0x0021A468 File Offset: 0x00218668
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

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x06005D26 RID: 23846 RVA: 0x0021A4A4 File Offset: 0x002186A4
		public string Path
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

		// Token: 0x06005D27 RID: 23847 RVA: 0x0021A4DB File Offset: 0x002186DB
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005D28 RID: 23848 RVA: 0x0021A4EA File Offset: 0x002186EA
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0400517C RID: 20860
		private Table __p;
	}
}
