using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8B RID: 2955
	public struct ComicPrefabConfig : IFlatbufferObject
	{
		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x06005746 RID: 22342 RVA: 0x001FA601 File Offset: 0x001F8801
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005747 RID: 22343 RVA: 0x001FA60E File Offset: 0x001F880E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005748 RID: 22344 RVA: 0x001FA618 File Offset: 0x001F8818
		public static ComicPrefabConfig GetRootAsComicPrefabConfig(ByteBuffer _bb)
		{
			return ComicPrefabConfig.GetRootAsComicPrefabConfig(_bb, default(ComicPrefabConfig));
		}

		// Token: 0x06005749 RID: 22345 RVA: 0x001FA634 File Offset: 0x001F8834
		public static ComicPrefabConfig GetRootAsComicPrefabConfig(ByteBuffer _bb, ComicPrefabConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600574A RID: 22346 RVA: 0x001FA651 File Offset: 0x001F8851
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600574B RID: 22347 RVA: 0x001FA660 File Offset: 0x001F8860
		public ComicPrefabConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x0600574C RID: 22348 RVA: 0x001FA670 File Offset: 0x001F8870
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

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x0600574D RID: 22349 RVA: 0x001FA6AC File Offset: 0x001F88AC
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

		// Token: 0x0600574E RID: 22350 RVA: 0x001FA6E3 File Offset: 0x001F88E3
		public Span<byte> GetPathBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600574F RID: 22351 RVA: 0x001FA6F2 File Offset: 0x001F88F2
		public byte[] GetPathArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B9A RID: 19354
		private Table __p;
	}
}
