using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C64 RID: 3172
	public struct CloudTime : IFlatbufferObject
	{
		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06005BF4 RID: 23540 RVA: 0x0021767C File Offset: 0x0021587C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005BF5 RID: 23541 RVA: 0x00217689 File Offset: 0x00215889
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005BF6 RID: 23542 RVA: 0x00217690 File Offset: 0x00215890
		public static CloudTime GetRootAsCloudTime(ByteBuffer _bb)
		{
			return CloudTime.GetRootAsCloudTime(_bb, default(CloudTime));
		}

		// Token: 0x06005BF7 RID: 23543 RVA: 0x002176AC File Offset: 0x002158AC
		public static CloudTime GetRootAsCloudTime(ByteBuffer _bb, CloudTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005BF8 RID: 23544 RVA: 0x002176C9 File Offset: 0x002158C9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005BF9 RID: 23545 RVA: 0x002176D8 File Offset: 0x002158D8
		public CloudTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06005BFA RID: 23546 RVA: 0x002176E8 File Offset: 0x002158E8
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

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06005BFB RID: 23547 RVA: 0x00217724 File Offset: 0x00215924
		public int Day
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

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06005BFC RID: 23548 RVA: 0x00217760 File Offset: 0x00215960
		public float Amount
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06005BFD RID: 23549 RVA: 0x002177A0 File Offset: 0x002159A0
		public int Timeout
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06005BFE RID: 23550 RVA: 0x002177E0 File Offset: 0x002159E0
		public string StageImage
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

		// Token: 0x06005BFF RID: 23551 RVA: 0x00217818 File Offset: 0x00215A18
		public Span<byte> GetStageImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005C00 RID: 23552 RVA: 0x00217828 File Offset: 0x00215A28
		public byte[] GetStageImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06005C01 RID: 23553 RVA: 0x00217840 File Offset: 0x00215A40
		public string ShowStageImage
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

		// Token: 0x06005C02 RID: 23554 RVA: 0x00217878 File Offset: 0x00215A78
		public Span<byte> GetShowStageImageBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005C03 RID: 23555 RVA: 0x00217888 File Offset: 0x00215A88
		public byte[] GetShowStageImageArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06005C04 RID: 23556 RVA: 0x002178A0 File Offset: 0x00215AA0
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C05 RID: 23557 RVA: 0x002178D8 File Offset: 0x00215AD8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005C06 RID: 23558 RVA: 0x002178E8 File Offset: 0x00215AE8
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06005C07 RID: 23559 RVA: 0x00217900 File Offset: 0x00215B00
		public string Desc
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005C08 RID: 23560 RVA: 0x00217938 File Offset: 0x00215B38
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06005C09 RID: 23561 RVA: 0x00217948 File Offset: 0x00215B48
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04005168 RID: 20840
		private Table __p;
	}
}
