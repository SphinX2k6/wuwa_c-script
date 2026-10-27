using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8D RID: 2957
	public struct CommonRewardViewDisplay : IFlatbufferObject
	{
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x0600575B RID: 22363 RVA: 0x001FA84D File Offset: 0x001F8A4D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600575C RID: 22364 RVA: 0x001FA85A File Offset: 0x001F8A5A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600575D RID: 22365 RVA: 0x001FA864 File Offset: 0x001F8A64
		public static CommonRewardViewDisplay GetRootAsCommonRewardViewDisplay(ByteBuffer _bb)
		{
			return CommonRewardViewDisplay.GetRootAsCommonRewardViewDisplay(_bb, default(CommonRewardViewDisplay));
		}

		// Token: 0x0600575E RID: 22366 RVA: 0x001FA880 File Offset: 0x001F8A80
		public static CommonRewardViewDisplay GetRootAsCommonRewardViewDisplay(ByteBuffer _bb, CommonRewardViewDisplay obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600575F RID: 22367 RVA: 0x001FA89D File Offset: 0x001F8A9D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005760 RID: 22368 RVA: 0x001FA8AC File Offset: 0x001F8AAC
		public CommonRewardViewDisplay __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x06005761 RID: 22369 RVA: 0x001FA8BC File Offset: 0x001F8ABC
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

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x06005762 RID: 22370 RVA: 0x001FA8F8 File Offset: 0x001F8AF8
		public string Title
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

		// Token: 0x06005763 RID: 22371 RVA: 0x001FA92F File Offset: 0x001F8B2F
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06005764 RID: 22372 RVA: 0x001FA93E File Offset: 0x001F8B3E
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x06005765 RID: 22373 RVA: 0x001FA958 File Offset: 0x001F8B58
		public string ContinueText
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

		// Token: 0x06005766 RID: 22374 RVA: 0x001FA98F File Offset: 0x001F8B8F
		public Span<byte> GetContinueTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005767 RID: 22375 RVA: 0x001FA99E File Offset: 0x001F8B9E
		public byte[] GetContinueTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x06005768 RID: 22376 RVA: 0x001FA9B8 File Offset: 0x001F8BB8
		public bool IsItemVisible
		{
			get
			{
				int num = this.__p.__offset(10);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x06005769 RID: 22377 RVA: 0x001FA9F8 File Offset: 0x001F8BF8
		public bool IsSuccess
		{
			get
			{
				int num = this.__p.__offset(12);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x0600576A RID: 22378 RVA: 0x001FAA38 File Offset: 0x001F8C38
		public string AudioId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600576B RID: 22379 RVA: 0x001FAA70 File Offset: 0x001F8C70
		public Span<byte> GetAudioIdBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600576C RID: 22380 RVA: 0x001FAA80 File Offset: 0x001F8C80
		public byte[] GetAudioIdArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B9C RID: 19356
		private Table __p;
	}
}
