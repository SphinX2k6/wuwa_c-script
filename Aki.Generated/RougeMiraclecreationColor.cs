using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001167 RID: 4455
	public struct RougeMiraclecreationColor : IFlatbufferObject
	{
		// Token: 0x170034CC RID: 13516
		// (get) Token: 0x0600D407 RID: 54279 RVA: 0x00321F85 File Offset: 0x00320185
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D408 RID: 54280 RVA: 0x00321F92 File Offset: 0x00320192
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D409 RID: 54281 RVA: 0x00321F9C File Offset: 0x0032019C
		public static RougeMiraclecreationColor GetRootAsRougeMiraclecreationColor(ByteBuffer _bb)
		{
			return RougeMiraclecreationColor.GetRootAsRougeMiraclecreationColor(_bb, default(RougeMiraclecreationColor));
		}

		// Token: 0x0600D40A RID: 54282 RVA: 0x00321FB8 File Offset: 0x003201B8
		public static RougeMiraclecreationColor GetRootAsRougeMiraclecreationColor(ByteBuffer _bb, RougeMiraclecreationColor obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D40B RID: 54283 RVA: 0x00321FD5 File Offset: 0x003201D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D40C RID: 54284 RVA: 0x00321FE4 File Offset: 0x003201E4
		public RougeMiraclecreationColor __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170034CD RID: 13517
		// (get) Token: 0x0600D40D RID: 54285 RVA: 0x00321FF4 File Offset: 0x003201F4
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

		// Token: 0x170034CE RID: 13518
		// (get) Token: 0x0600D40E RID: 54286 RVA: 0x00322030 File Offset: 0x00320230
		public string NiaColor
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

		// Token: 0x0600D40F RID: 54287 RVA: 0x00322067 File Offset: 0x00320267
		public Span<byte> GetNiaColorBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D410 RID: 54288 RVA: 0x00322076 File Offset: 0x00320276
		public byte[] GetNiaColorArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170034CF RID: 13519
		// (get) Token: 0x0600D411 RID: 54289 RVA: 0x00322090 File Offset: 0x00320290
		public string NiaNorColor
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

		// Token: 0x0600D412 RID: 54290 RVA: 0x003220C7 File Offset: 0x003202C7
		public Span<byte> GetNiaNorColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600D413 RID: 54291 RVA: 0x003220D6 File Offset: 0x003202D6
		public byte[] GetNiaNorColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170034D0 RID: 13520
		// (get) Token: 0x0600D414 RID: 54292 RVA: 0x003220F0 File Offset: 0x003202F0
		public string NiaSelectColor
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

		// Token: 0x0600D415 RID: 54293 RVA: 0x00322128 File Offset: 0x00320328
		public Span<byte> GetNiaSelectColorBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D416 RID: 54294 RVA: 0x00322138 File Offset: 0x00320338
		public byte[] GetNiaSelectColorArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170034D1 RID: 13521
		// (get) Token: 0x0600D417 RID: 54295 RVA: 0x00322150 File Offset: 0x00320350
		public string NiaSelect1Color
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

		// Token: 0x0600D418 RID: 54296 RVA: 0x00322188 File Offset: 0x00320388
		public Span<byte> GetNiaSelect1ColorBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x0600D419 RID: 54297 RVA: 0x00322198 File Offset: 0x00320398
		public byte[] GetNiaSelect1ColorArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170034D2 RID: 13522
		// (get) Token: 0x0600D41A RID: 54298 RVA: 0x003221B0 File Offset: 0x003203B0
		public string SmallBg
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

		// Token: 0x0600D41B RID: 54299 RVA: 0x003221E8 File Offset: 0x003203E8
		public Span<byte> GetSmallBgBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600D41C RID: 54300 RVA: 0x003221F8 File Offset: 0x003203F8
		public byte[] GetSmallBgArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170034D3 RID: 13523
		// (get) Token: 0x0600D41D RID: 54301 RVA: 0x00322210 File Offset: 0x00320410
		public int Sort
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

		// Token: 0x04005770 RID: 22384
		private Table __p;
	}
}
