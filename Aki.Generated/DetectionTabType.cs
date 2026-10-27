using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000BE8 RID: 3048
	public struct DetectionTabType : IFlatbufferObject
	{
		// Token: 0x17000C51 RID: 3153
		// (get) Token: 0x06006170 RID: 24944 RVA: 0x00211A9D File Offset: 0x0020FC9D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006171 RID: 24945 RVA: 0x00211AAA File Offset: 0x0020FCAA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006172 RID: 24946 RVA: 0x00211AB4 File Offset: 0x0020FCB4
		public static DetectionTabType GetRootAsDetectionTabType(ByteBuffer _bb)
		{
			return DetectionTabType.GetRootAsDetectionTabType(_bb, default(DetectionTabType));
		}

		// Token: 0x06006173 RID: 24947 RVA: 0x00211AD0 File Offset: 0x0020FCD0
		public static DetectionTabType GetRootAsDetectionTabType(ByteBuffer _bb, DetectionTabType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006174 RID: 24948 RVA: 0x00211AED File Offset: 0x0020FCED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006175 RID: 24949 RVA: 0x00211AFC File Offset: 0x0020FCFC
		public DetectionTabType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000C52 RID: 3154
		// (get) Token: 0x06006176 RID: 24950 RVA: 0x00211B0C File Offset: 0x0020FD0C
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

		// Token: 0x17000C53 RID: 3155
		// (get) Token: 0x06006177 RID: 24951 RVA: 0x00211B48 File Offset: 0x0020FD48
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

		// Token: 0x17000C54 RID: 3156
		// (get) Token: 0x06006178 RID: 24952 RVA: 0x00211B84 File Offset: 0x0020FD84
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

		// Token: 0x06006179 RID: 24953 RVA: 0x00211BBB File Offset: 0x0020FDBB
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600617A RID: 24954 RVA: 0x00211BCA File Offset: 0x0020FDCA
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C55 RID: 3157
		// (get) Token: 0x0600617B RID: 24955 RVA: 0x00211BE4 File Offset: 0x0020FDE4
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

		// Token: 0x0600617C RID: 24956 RVA: 0x00211C1C File Offset: 0x0020FE1C
		public Span<byte> GetTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600617D RID: 24957 RVA: 0x00211C2C File Offset: 0x0020FE2C
		public byte[] GetTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000C56 RID: 3158
		// (get) Token: 0x0600617E RID: 24958 RVA: 0x00211C44 File Offset: 0x0020FE44
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

		// Token: 0x04004C15 RID: 19477
		private Table __p;
	}
}
