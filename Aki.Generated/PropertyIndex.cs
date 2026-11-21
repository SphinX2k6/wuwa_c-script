using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001043 RID: 4163
	public struct PropertyIndex : IFlatbufferObject
	{
		// Token: 0x17002B80 RID: 11136
		// (get) Token: 0x0600B9CD RID: 47565 RVA: 0x002E88A4 File Offset: 0x002E6AA4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9CE RID: 47566 RVA: 0x002E88B1 File Offset: 0x002E6AB1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B9CF RID: 47567 RVA: 0x002E88B8 File Offset: 0x002E6AB8
		public static PropertyIndex GetRootAsPropertyIndex(ByteBuffer _bb)
		{
			return PropertyIndex.GetRootAsPropertyIndex(_bb, default(PropertyIndex));
		}

		// Token: 0x0600B9D0 RID: 47568 RVA: 0x002E88D4 File Offset: 0x002E6AD4
		public static PropertyIndex GetRootAsPropertyIndex(ByteBuffer _bb, PropertyIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B9D1 RID: 47569 RVA: 0x002E88F1 File Offset: 0x002E6AF1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B9D2 RID: 47570 RVA: 0x002E8900 File Offset: 0x002E6B00
		public PropertyIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B81 RID: 11137
		// (get) Token: 0x0600B9D3 RID: 47571 RVA: 0x002E8910 File Offset: 0x002E6B10
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

		// Token: 0x17002B82 RID: 11138
		// (get) Token: 0x0600B9D4 RID: 47572 RVA: 0x002E894C File Offset: 0x002E6B4C
		public string Key
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

		// Token: 0x0600B9D5 RID: 47573 RVA: 0x002E8983 File Offset: 0x002E6B83
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B9D6 RID: 47574 RVA: 0x002E8992 File Offset: 0x002E6B92
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B83 RID: 11139
		// (get) Token: 0x0600B9D7 RID: 47575 RVA: 0x002E89AC File Offset: 0x002E6BAC
		public string Name
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

		// Token: 0x0600B9D8 RID: 47576 RVA: 0x002E89E3 File Offset: 0x002E6BE3
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B9D9 RID: 47577 RVA: 0x002E89F2 File Offset: 0x002E6BF2
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B84 RID: 11140
		// (get) Token: 0x0600B9DA RID: 47578 RVA: 0x002E8A0C File Offset: 0x002E6C0C
		public string AnotherName
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

		// Token: 0x0600B9DB RID: 47579 RVA: 0x002E8A44 File Offset: 0x002E6C44
		public Span<byte> GetAnotherNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B9DC RID: 47580 RVA: 0x002E8A54 File Offset: 0x002E6C54
		public byte[] GetAnotherNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B85 RID: 11141
		// (get) Token: 0x0600B9DD RID: 47581 RVA: 0x002E8A6C File Offset: 0x002E6C6C
		public int ConvertToWhiteId
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

		// Token: 0x17002B86 RID: 11142
		// (get) Token: 0x0600B9DE RID: 47582 RVA: 0x002E8AAC File Offset: 0x002E6CAC
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B87 RID: 11143
		// (get) Token: 0x0600B9DF RID: 47583 RVA: 0x002E8AEC File Offset: 0x002E6CEC
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x0600B9E0 RID: 47584 RVA: 0x002E8B2C File Offset: 0x002E6D2C
		public int Priority
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x0600B9E1 RID: 47585 RVA: 0x002E8B6C File Offset: 0x002E6D6C
		public string Icon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B9E2 RID: 47586 RVA: 0x002E8BA4 File Offset: 0x002E6DA4
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B9E3 RID: 47587 RVA: 0x002E8BB4 File Offset: 0x002E6DB4
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x0600B9E4 RID: 47588 RVA: 0x002E8BCC File Offset: 0x002E6DCC
		public string Dec
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600B9E5 RID: 47589 RVA: 0x002E8C04 File Offset: 0x002E6E04
		public Span<byte> GetDecBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B9E6 RID: 47590 RVA: 0x002E8C14 File Offset: 0x002E6E14
		public byte[] GetDecArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005610 RID: 22032
		private Table __p;
	}
}
