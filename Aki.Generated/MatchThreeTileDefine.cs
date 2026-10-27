using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E04 RID: 3588
	public struct MatchThreeTileDefine : IFlatbufferObject
	{
		// Token: 0x17001EC6 RID: 7878
		// (get) Token: 0x0600934F RID: 37711 RVA: 0x002838B9 File Offset: 0x00281AB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009350 RID: 37712 RVA: 0x002838C6 File Offset: 0x00281AC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009351 RID: 37713 RVA: 0x002838D0 File Offset: 0x00281AD0
		public static MatchThreeTileDefine GetRootAsMatchThreeTileDefine(ByteBuffer _bb)
		{
			return MatchThreeTileDefine.GetRootAsMatchThreeTileDefine(_bb, default(MatchThreeTileDefine));
		}

		// Token: 0x06009352 RID: 37714 RVA: 0x002838EC File Offset: 0x00281AEC
		public static MatchThreeTileDefine GetRootAsMatchThreeTileDefine(ByteBuffer _bb, MatchThreeTileDefine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009353 RID: 37715 RVA: 0x00283909 File Offset: 0x00281B09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009354 RID: 37716 RVA: 0x00283918 File Offset: 0x00281B18
		public MatchThreeTileDefine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001EC7 RID: 7879
		// (get) Token: 0x06009355 RID: 37717 RVA: 0x00283928 File Offset: 0x00281B28
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

		// Token: 0x17001EC8 RID: 7880
		// (get) Token: 0x06009356 RID: 37718 RVA: 0x00283964 File Offset: 0x00281B64
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

		// Token: 0x06009357 RID: 37719 RVA: 0x0028399B File Offset: 0x00281B9B
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06009358 RID: 37720 RVA: 0x002839AA File Offset: 0x00281BAA
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001EC9 RID: 7881
		// (get) Token: 0x06009359 RID: 37721 RVA: 0x002839C4 File Offset: 0x00281BC4
		public string Description
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

		// Token: 0x0600935A RID: 37722 RVA: 0x002839FB File Offset: 0x00281BFB
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600935B RID: 37723 RVA: 0x00283A0A File Offset: 0x00281C0A
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17001ECA RID: 7882
		// (get) Token: 0x0600935C RID: 37724 RVA: 0x00283A24 File Offset: 0x00281C24
		public string TileIconPath
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

		// Token: 0x0600935D RID: 37725 RVA: 0x00283A5C File Offset: 0x00281C5C
		public Span<byte> GetTileIconPathBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600935E RID: 37726 RVA: 0x00283A6C File Offset: 0x00281C6C
		public byte[] GetTileIconPathArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17001ECB RID: 7883
		// (get) Token: 0x0600935F RID: 37727 RVA: 0x00283A84 File Offset: 0x00281C84
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x04004EA5 RID: 20133
		private Table __p;
	}
}
