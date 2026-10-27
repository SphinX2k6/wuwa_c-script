using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7A RID: 3706
	public struct MusicGameData : IFlatbufferObject
	{
		// Token: 0x170022C8 RID: 8904
		// (get) Token: 0x06009DDF RID: 40415 RVA: 0x0029B051 File Offset: 0x00299251
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009DE0 RID: 40416 RVA: 0x0029B05E File Offset: 0x0029925E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009DE1 RID: 40417 RVA: 0x0029B068 File Offset: 0x00299268
		public static MusicGameData GetRootAsMusicGameData(ByteBuffer _bb)
		{
			return MusicGameData.GetRootAsMusicGameData(_bb, default(MusicGameData));
		}

		// Token: 0x06009DE2 RID: 40418 RVA: 0x0029B084 File Offset: 0x00299284
		public static MusicGameData GetRootAsMusicGameData(ByteBuffer _bb, MusicGameData obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009DE3 RID: 40419 RVA: 0x0029B0A1 File Offset: 0x002992A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009DE4 RID: 40420 RVA: 0x0029B0B0 File Offset: 0x002992B0
		public MusicGameData __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170022C9 RID: 8905
		// (get) Token: 0x06009DE5 RID: 40421 RVA: 0x0029B0C0 File Offset: 0x002992C0
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

		// Token: 0x170022CA RID: 8906
		// (get) Token: 0x06009DE6 RID: 40422 RVA: 0x0029B0FC File Offset: 0x002992FC
		public float BgmOffset
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170022CB RID: 8907
		// (get) Token: 0x06009DE7 RID: 40423 RVA: 0x0029B13C File Offset: 0x0029933C
		public string Data
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

		// Token: 0x06009DE8 RID: 40424 RVA: 0x0029B173 File Offset: 0x00299373
		public Span<byte> GetDataBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06009DE9 RID: 40425 RVA: 0x0029B182 File Offset: 0x00299382
		public byte[] GetDataArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x04004F28 RID: 20264
		private Table __p;
	}
}
