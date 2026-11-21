using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000CCA RID: 3274
	public struct DetectionTabType : IFlatbufferObject
	{
		// Token: 0x17000C97 RID: 3223
		// (get) Token: 0x06006749 RID: 26441 RVA: 0x002310C9 File Offset: 0x0022F2C9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600674A RID: 26442 RVA: 0x002310D6 File Offset: 0x0022F2D6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600674B RID: 26443 RVA: 0x002310E0 File Offset: 0x0022F2E0
		public static DetectionTabType GetRootAsDetectionTabType(ByteBuffer _bb)
		{
			return DetectionTabType.GetRootAsDetectionTabType(_bb, default(DetectionTabType));
		}

		// Token: 0x0600674C RID: 26444 RVA: 0x002310FC File Offset: 0x0022F2FC
		public static DetectionTabType GetRootAsDetectionTabType(ByteBuffer _bb, DetectionTabType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600674D RID: 26445 RVA: 0x00231119 File Offset: 0x0022F319
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600674E RID: 26446 RVA: 0x00231128 File Offset: 0x0022F328
		public DetectionTabType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C98 RID: 3224
		// (get) Token: 0x0600674F RID: 26447 RVA: 0x00231138 File Offset: 0x0022F338
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

		// Token: 0x17000C99 RID: 3225
		// (get) Token: 0x06006750 RID: 26448 RVA: 0x00231174 File Offset: 0x0022F374
		public int Type
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

		// Token: 0x17000C9A RID: 3226
		// (get) Token: 0x06006751 RID: 26449 RVA: 0x002311B0 File Offset: 0x0022F3B0
		public string Icon
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

		// Token: 0x06006752 RID: 26450 RVA: 0x002311E7 File Offset: 0x0022F3E7
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06006753 RID: 26451 RVA: 0x002311F6 File Offset: 0x0022F3F6
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C9B RID: 3227
		// (get) Token: 0x06006754 RID: 26452 RVA: 0x00231210 File Offset: 0x0022F410
		public string Text
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

		// Token: 0x06006755 RID: 26453 RVA: 0x00231248 File Offset: 0x0022F448
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006756 RID: 26454 RVA: 0x00231258 File Offset: 0x0022F458
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C9C RID: 3228
		// (get) Token: 0x06006757 RID: 26455 RVA: 0x00231270 File Offset: 0x0022F470
		public int Order
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

		// Token: 0x040051F7 RID: 20983
		private Table __p;
	}
}
