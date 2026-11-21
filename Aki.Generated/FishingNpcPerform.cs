using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D68 RID: 3432
	public struct FishingNpcPerform : IFlatbufferObject
	{
		// Token: 0x170011E7 RID: 4583
		// (get) Token: 0x060075C6 RID: 30150 RVA: 0x00251284 File Offset: 0x0024F484
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060075C7 RID: 30151 RVA: 0x00251291 File Offset: 0x0024F491
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060075C8 RID: 30152 RVA: 0x00251298 File Offset: 0x0024F498
		public static FishingNpcPerform GetRootAsFishingNpcPerform(ByteBuffer _bb)
		{
			return FishingNpcPerform.GetRootAsFishingNpcPerform(_bb, default(FishingNpcPerform));
		}

		// Token: 0x060075C9 RID: 30153 RVA: 0x002512B4 File Offset: 0x0024F4B4
		public static FishingNpcPerform GetRootAsFishingNpcPerform(ByteBuffer _bb, FishingNpcPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060075CA RID: 30154 RVA: 0x002512D1 File Offset: 0x0024F4D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060075CB RID: 30155 RVA: 0x002512E0 File Offset: 0x0024F4E0
		public FishingNpcPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170011E8 RID: 4584
		// (get) Token: 0x060075CC RID: 30156 RVA: 0x002512F0 File Offset: 0x0024F4F0
		public string Id
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

		// Token: 0x060075CD RID: 30157 RVA: 0x00251327 File Offset: 0x0024F527
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x060075CE RID: 30158 RVA: 0x00251336 File Offset: 0x0024F536
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x170011E9 RID: 4585
		// (get) Token: 0x060075CF RID: 30159 RVA: 0x00251350 File Offset: 0x0024F550
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

		// Token: 0x060075D0 RID: 30160 RVA: 0x00251387 File Offset: 0x0024F587
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x060075D1 RID: 30161 RVA: 0x00251396 File Offset: 0x0024F596
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170011EA RID: 4586
		// (get) Token: 0x060075D2 RID: 30162 RVA: 0x002513B0 File Offset: 0x0024F5B0
		public string Content
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

		// Token: 0x060075D3 RID: 30163 RVA: 0x002513E7 File Offset: 0x0024F5E7
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x060075D4 RID: 30164 RVA: 0x002513F6 File Offset: 0x0024F5F6
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170011EB RID: 4587
		// (get) Token: 0x060075D5 RID: 30165 RVA: 0x00251410 File Offset: 0x0024F610
		public string AudioEvent
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

		// Token: 0x060075D6 RID: 30166 RVA: 0x00251448 File Offset: 0x0024F648
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x060075D7 RID: 30167 RVA: 0x00251458 File Offset: 0x0024F658
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170011EC RID: 4588
		// (get) Token: 0x060075D8 RID: 30168 RVA: 0x00251470 File Offset: 0x0024F670
		public string MontagePath
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060075D9 RID: 30169 RVA: 0x002514A8 File Offset: 0x0024F6A8
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x060075DA RID: 30170 RVA: 0x002514B8 File Offset: 0x0024F6B8
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x040052B8 RID: 21176
		private Table __p;
	}
}
