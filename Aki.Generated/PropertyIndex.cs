using System;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5C RID: 3932
	public struct PropertyIndex : IFlatbufferObject
	{
		// Token: 0x17002B08 RID: 11016
		// (get) Token: 0x0600B390 RID: 45968 RVA: 0x002CBBF0 File Offset: 0x002C9DF0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B391 RID: 45969 RVA: 0x002CBBFD File Offset: 0x002C9DFD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B392 RID: 45970 RVA: 0x002CBC04 File Offset: 0x002C9E04
		public static PropertyIndex GetRootAsPropertyIndex(ByteBuffer _bb)
		{
			return PropertyIndex.GetRootAsPropertyIndex(_bb, default(PropertyIndex));
		}

		// Token: 0x0600B393 RID: 45971 RVA: 0x002CBC20 File Offset: 0x002C9E20
		public static PropertyIndex GetRootAsPropertyIndex(ByteBuffer _bb, PropertyIndex obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B394 RID: 45972 RVA: 0x002CBC3D File Offset: 0x002C9E3D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B395 RID: 45973 RVA: 0x002CBC4C File Offset: 0x002C9E4C
		public PropertyIndex __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B09 RID: 11017
		// (get) Token: 0x0600B396 RID: 45974 RVA: 0x002CBC5C File Offset: 0x002C9E5C
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

		// Token: 0x17002B0A RID: 11018
		// (get) Token: 0x0600B397 RID: 45975 RVA: 0x002CBC98 File Offset: 0x002C9E98
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

		// Token: 0x0600B398 RID: 45976 RVA: 0x002CBCCF File Offset: 0x002C9ECF
		public Span<byte> GetKeyBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600B399 RID: 45977 RVA: 0x002CBCDE File Offset: 0x002C9EDE
		public byte[] GetKeyArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B0B RID: 11019
		// (get) Token: 0x0600B39A RID: 45978 RVA: 0x002CBCF8 File Offset: 0x002C9EF8
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

		// Token: 0x0600B39B RID: 45979 RVA: 0x002CBD2F File Offset: 0x002C9F2F
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600B39C RID: 45980 RVA: 0x002CBD3E File Offset: 0x002C9F3E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B0C RID: 11020
		// (get) Token: 0x0600B39D RID: 45981 RVA: 0x002CBD58 File Offset: 0x002C9F58
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

		// Token: 0x0600B39E RID: 45982 RVA: 0x002CBD90 File Offset: 0x002C9F90
		public Span<byte> GetAnotherNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600B39F RID: 45983 RVA: 0x002CBDA0 File Offset: 0x002C9FA0
		public byte[] GetAnotherNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B0D RID: 11021
		// (get) Token: 0x0600B3A0 RID: 45984 RVA: 0x002CBDB8 File Offset: 0x002C9FB8
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

		// Token: 0x17002B0E RID: 11022
		// (get) Token: 0x0600B3A1 RID: 45985 RVA: 0x002CBDF8 File Offset: 0x002C9FF8
		public bool IsShow
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B0F RID: 11023
		// (get) Token: 0x0600B3A2 RID: 45986 RVA: 0x002CBE38 File Offset: 0x002CA038
		public bool IsPercent
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17002B10 RID: 11024
		// (get) Token: 0x0600B3A3 RID: 45987 RVA: 0x002CBE78 File Offset: 0x002CA078
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

		// Token: 0x17002B11 RID: 11025
		// (get) Token: 0x0600B3A4 RID: 45988 RVA: 0x002CBEB8 File Offset: 0x002CA0B8
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

		// Token: 0x0600B3A5 RID: 45989 RVA: 0x002CBEF0 File Offset: 0x002CA0F0
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600B3A6 RID: 45990 RVA: 0x002CBF00 File Offset: 0x002CA100
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17002B12 RID: 11026
		// (get) Token: 0x0600B3A7 RID: 45991 RVA: 0x002CBF18 File Offset: 0x002CA118
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

		// Token: 0x0600B3A8 RID: 45992 RVA: 0x002CBF50 File Offset: 0x002CA150
		public Span<byte> GetDecBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600B3A9 RID: 45993 RVA: 0x002CBF60 File Offset: 0x002CA160
		public byte[] GetDecArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x04005029 RID: 20521
		private Table __p;
	}
}
