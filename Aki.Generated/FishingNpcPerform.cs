using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C84 RID: 3204
	public struct FishingNpcPerform : IFlatbufferObject
	{
		// Token: 0x1700118A RID: 4490
		// (get) Token: 0x06006FBB RID: 28603 RVA: 0x00232114 File Offset: 0x00230314
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006FBC RID: 28604 RVA: 0x00232121 File Offset: 0x00230321
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006FBD RID: 28605 RVA: 0x00232128 File Offset: 0x00230328
		public static FishingNpcPerform GetRootAsFishingNpcPerform(ByteBuffer _bb)
		{
			return FishingNpcPerform.GetRootAsFishingNpcPerform(_bb, default(FishingNpcPerform));
		}

		// Token: 0x06006FBE RID: 28606 RVA: 0x00232144 File Offset: 0x00230344
		public static FishingNpcPerform GetRootAsFishingNpcPerform(ByteBuffer _bb, FishingNpcPerform obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006FBF RID: 28607 RVA: 0x00232161 File Offset: 0x00230361
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006FC0 RID: 28608 RVA: 0x00232170 File Offset: 0x00230370
		public FishingNpcPerform __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700118B RID: 4491
		// (get) Token: 0x06006FC1 RID: 28609 RVA: 0x00232180 File Offset: 0x00230380
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

		// Token: 0x06006FC2 RID: 28610 RVA: 0x002321B7 File Offset: 0x002303B7
		public Span<byte> GetIdBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06006FC3 RID: 28611 RVA: 0x002321C6 File Offset: 0x002303C6
		public byte[] GetIdArray()
		{
			return this.__p.__vector_as_array<byte>(4) ?? Array.Empty<byte>();
		}

		// Token: 0x1700118C RID: 4492
		// (get) Token: 0x06006FC4 RID: 28612 RVA: 0x002321E0 File Offset: 0x002303E0
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

		// Token: 0x06006FC5 RID: 28613 RVA: 0x00232217 File Offset: 0x00230417
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06006FC6 RID: 28614 RVA: 0x00232226 File Offset: 0x00230426
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x1700118D RID: 4493
		// (get) Token: 0x06006FC7 RID: 28615 RVA: 0x00232240 File Offset: 0x00230440
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

		// Token: 0x06006FC8 RID: 28616 RVA: 0x00232277 File Offset: 0x00230477
		public Span<byte> GetContentBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006FC9 RID: 28617 RVA: 0x00232286 File Offset: 0x00230486
		public byte[] GetContentArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x1700118E RID: 4494
		// (get) Token: 0x06006FCA RID: 28618 RVA: 0x002322A0 File Offset: 0x002304A0
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

		// Token: 0x06006FCB RID: 28619 RVA: 0x002322D8 File Offset: 0x002304D8
		public Span<byte> GetAudioEventBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006FCC RID: 28620 RVA: 0x002322E8 File Offset: 0x002304E8
		public byte[] GetAudioEventArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700118F RID: 4495
		// (get) Token: 0x06006FCD RID: 28621 RVA: 0x00232300 File Offset: 0x00230500
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

		// Token: 0x06006FCE RID: 28622 RVA: 0x00232338 File Offset: 0x00230538
		public Span<byte> GetMontagePathBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06006FCF RID: 28623 RVA: 0x00232348 File Offset: 0x00230548
		public byte[] GetMontagePathArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x04004CD4 RID: 19668
		private Table __p;
	}
}
