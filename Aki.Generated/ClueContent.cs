using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B84 RID: 2948
	public struct ClueContent : IFlatbufferObject
	{
		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x0600563C RID: 22076 RVA: 0x001F7BA8 File Offset: 0x001F5DA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600563D RID: 22077 RVA: 0x001F7BB5 File Offset: 0x001F5DB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600563E RID: 22078 RVA: 0x001F7BBC File Offset: 0x001F5DBC
		public static ClueContent GetRootAsClueContent(ByteBuffer _bb)
		{
			return ClueContent.GetRootAsClueContent(_bb, default(ClueContent));
		}

		// Token: 0x0600563F RID: 22079 RVA: 0x001F7BD8 File Offset: 0x001F5DD8
		public static ClueContent GetRootAsClueContent(ByteBuffer _bb, ClueContent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005640 RID: 22080 RVA: 0x001F7BF5 File Offset: 0x001F5DF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005641 RID: 22081 RVA: 0x001F7C04 File Offset: 0x001F5E04
		public ClueContent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06005642 RID: 22082 RVA: 0x001F7C14 File Offset: 0x001F5E14
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

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06005643 RID: 22083 RVA: 0x001F7C50 File Offset: 0x001F5E50
		public int GroupId
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

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x06005644 RID: 22084 RVA: 0x001F7C8C File Offset: 0x001F5E8C
		public string Texture
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

		// Token: 0x06005645 RID: 22085 RVA: 0x001F7CC3 File Offset: 0x001F5EC3
		public Span<byte> GetTextureBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005646 RID: 22086 RVA: 0x001F7CD2 File Offset: 0x001F5ED2
		public byte[] GetTextureArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x06005647 RID: 22087 RVA: 0x001F7CEC File Offset: 0x001F5EEC
		public string Desc
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

		// Token: 0x06005648 RID: 22088 RVA: 0x001F7D24 File Offset: 0x001F5F24
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06005649 RID: 22089 RVA: 0x001F7D34 File Offset: 0x001F5F34
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x04004B88 RID: 19336
		private Table __p;
	}
}
