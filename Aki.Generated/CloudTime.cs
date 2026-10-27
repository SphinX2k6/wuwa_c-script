using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B83 RID: 2947
	public struct CloudTime : IFlatbufferObject
	{
		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x06005626 RID: 22054 RVA: 0x001F78C4 File Offset: 0x001F5AC4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005627 RID: 22055 RVA: 0x001F78D1 File Offset: 0x001F5AD1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005628 RID: 22056 RVA: 0x001F78D8 File Offset: 0x001F5AD8
		public static CloudTime GetRootAsCloudTime(ByteBuffer _bb)
		{
			return CloudTime.GetRootAsCloudTime(_bb, default(CloudTime));
		}

		// Token: 0x06005629 RID: 22057 RVA: 0x001F78F4 File Offset: 0x001F5AF4
		public static CloudTime GetRootAsCloudTime(ByteBuffer _bb, CloudTime obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600562A RID: 22058 RVA: 0x001F7911 File Offset: 0x001F5B11
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600562B RID: 22059 RVA: 0x001F7920 File Offset: 0x001F5B20
		public CloudTime __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x0600562C RID: 22060 RVA: 0x001F7930 File Offset: 0x001F5B30
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

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x0600562D RID: 22061 RVA: 0x001F796C File Offset: 0x001F5B6C
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

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x0600562E RID: 22062 RVA: 0x001F79A8 File Offset: 0x001F5BA8
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

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x0600562F RID: 22063 RVA: 0x001F79E8 File Offset: 0x001F5BE8
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

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x06005630 RID: 22064 RVA: 0x001F7A28 File Offset: 0x001F5C28
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

		// Token: 0x06005631 RID: 22065 RVA: 0x001F7A60 File Offset: 0x001F5C60
		public Span<byte> GetStageImageBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005632 RID: 22066 RVA: 0x001F7A70 File Offset: 0x001F5C70
		public byte[] GetStageImageArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x06005633 RID: 22067 RVA: 0x001F7A88 File Offset: 0x001F5C88
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

		// Token: 0x06005634 RID: 22068 RVA: 0x001F7AC0 File Offset: 0x001F5CC0
		public Span<byte> GetShowStageImageBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005635 RID: 22069 RVA: 0x001F7AD0 File Offset: 0x001F5CD0
		public byte[] GetShowStageImageArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06005636 RID: 22070 RVA: 0x001F7AE8 File Offset: 0x001F5CE8
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

		// Token: 0x06005637 RID: 22071 RVA: 0x001F7B20 File Offset: 0x001F5D20
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005638 RID: 22072 RVA: 0x001F7B30 File Offset: 0x001F5D30
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06005639 RID: 22073 RVA: 0x001F7B48 File Offset: 0x001F5D48
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

		// Token: 0x0600563A RID: 22074 RVA: 0x001F7B80 File Offset: 0x001F5D80
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600563B RID: 22075 RVA: 0x001F7B90 File Offset: 0x001F5D90
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B87 RID: 19335
		private Table __p;
	}
}
