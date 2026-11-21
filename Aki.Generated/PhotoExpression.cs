using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000FEC RID: 4076
	public struct PhotoExpression : IFlatbufferObject
	{
		// Token: 0x1700281D RID: 10269
		// (get) Token: 0x0600B177 RID: 45431 RVA: 0x002D624A File Offset: 0x002D444A
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B178 RID: 45432 RVA: 0x002D6257 File Offset: 0x002D4457
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B179 RID: 45433 RVA: 0x002D6260 File Offset: 0x002D4460
		public static PhotoExpression GetRootAsPhotoExpression(ByteBuffer _bb)
		{
			return PhotoExpression.GetRootAsPhotoExpression(_bb, default(PhotoExpression));
		}

		// Token: 0x0600B17A RID: 45434 RVA: 0x002D627C File Offset: 0x002D447C
		public static PhotoExpression GetRootAsPhotoExpression(ByteBuffer _bb, PhotoExpression obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B17B RID: 45435 RVA: 0x002D6299 File Offset: 0x002D4499
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B17C RID: 45436 RVA: 0x002D62A8 File Offset: 0x002D44A8
		public PhotoExpression __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700281E RID: 10270
		// (get) Token: 0x0600B17D RID: 45437 RVA: 0x002D62B8 File Offset: 0x002D44B8
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

		// Token: 0x1700281F RID: 10271
		// (get) Token: 0x0600B17E RID: 45438 RVA: 0x002D62F4 File Offset: 0x002D44F4
		public int Gender
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002820 RID: 10272
		// (get) Token: 0x0600B17F RID: 45439 RVA: 0x002D6330 File Offset: 0x002D4530
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002821 RID: 10273
		// (get) Token: 0x0600B180 RID: 45440 RVA: 0x002D636C File Offset: 0x002D456C
		public string Icon
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

		// Token: 0x0600B181 RID: 45441 RVA: 0x002D63A4 File Offset: 0x002D45A4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B182 RID: 45442 RVA: 0x002D63B4 File Offset: 0x002D45B4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002822 RID: 10274
		// (get) Token: 0x0600B183 RID: 45443 RVA: 0x002D63CC File Offset: 0x002D45CC
		public string Name
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

		// Token: 0x0600B184 RID: 45444 RVA: 0x002D6404 File Offset: 0x002D4604
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600B185 RID: 45445 RVA: 0x002D6414 File Offset: 0x002D4614
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17002823 RID: 10275
		// (get) Token: 0x0600B186 RID: 45446 RVA: 0x002D642C File Offset: 0x002D462C
		public int RelativeItem
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002824 RID: 10276
		// (get) Token: 0x0600B187 RID: 45447 RVA: 0x002D646C File Offset: 0x002D466C
		public int MontageConfigDtId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002825 RID: 10277
		// (get) Token: 0x0600B188 RID: 45448 RVA: 0x002D64AC File Offset: 0x002D46AC
		public bool IsDefault
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x040055B4 RID: 21940
		private Table __p;
	}
}
