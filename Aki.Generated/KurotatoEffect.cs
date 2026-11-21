using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E81 RID: 3713
	public struct KurotatoEffect : IFlatbufferObject
	{
		// Token: 0x17001BB4 RID: 7092
		// (get) Token: 0x06008F65 RID: 36709 RVA: 0x0028BFBD File Offset: 0x0028A1BD
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008F66 RID: 36710 RVA: 0x0028BFCA File Offset: 0x0028A1CA
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008F67 RID: 36711 RVA: 0x0028BFD4 File Offset: 0x0028A1D4
		public static KurotatoEffect GetRootAsKurotatoEffect(ByteBuffer _bb)
		{
			return KurotatoEffect.GetRootAsKurotatoEffect(_bb, default(KurotatoEffect));
		}

		// Token: 0x06008F68 RID: 36712 RVA: 0x0028BFF0 File Offset: 0x0028A1F0
		public static KurotatoEffect GetRootAsKurotatoEffect(ByteBuffer _bb, KurotatoEffect obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008F69 RID: 36713 RVA: 0x0028C00D File Offset: 0x0028A20D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008F6A RID: 36714 RVA: 0x0028C01C File Offset: 0x0028A21C
		public KurotatoEffect __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001BB5 RID: 7093
		// (get) Token: 0x06008F6B RID: 36715 RVA: 0x0028C02C File Offset: 0x0028A22C
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

		// Token: 0x17001BB6 RID: 7094
		// (get) Token: 0x06008F6C RID: 36716 RVA: 0x0028C068 File Offset: 0x0028A268
		public string Type
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

		// Token: 0x06008F6D RID: 36717 RVA: 0x0028C09F File Offset: 0x0028A29F
		public Span<byte> GetTypeBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06008F6E RID: 36718 RVA: 0x0028C0AE File Offset: 0x0028A2AE
		public byte[] GetTypeArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06008F6F RID: 36719 RVA: 0x0028C0C8 File Offset: 0x0028A2C8
		public int DisableShow
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

		// Token: 0x17001BB8 RID: 7096
		// (get) Token: 0x06008F70 RID: 36720 RVA: 0x0028C104 File Offset: 0x0028A304
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

		// Token: 0x06008F71 RID: 36721 RVA: 0x0028C13C File Offset: 0x0028A33C
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06008F72 RID: 36722 RVA: 0x0028C14C File Offset: 0x0028A34C
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06008F73 RID: 36723 RVA: 0x0028C164 File Offset: 0x0028A364
		public int DescArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001BB9 RID: 7097
		// (get) Token: 0x06008F74 RID: 36724 RVA: 0x0028C1A4 File Offset: 0x0028A3A4
		public int DescArgsLength
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F75 RID: 36725 RVA: 0x0028C1D0 File Offset: 0x0028A3D0
		public Span<int> GetDescArgsBytes()
		{
			return this.__p.__vector_as_span<int>(12, 4);
		}

		// Token: 0x06008F76 RID: 36726 RVA: 0x0028C1E0 File Offset: 0x0028A3E0
		public int[] GetDescArgsArray()
		{
			return this.__p.__vector_as_array<int>(12) ?? Array.Empty<int>();
		}

		// Token: 0x17001BBA RID: 7098
		// (get) Token: 0x06008F77 RID: 36727 RVA: 0x0028C1F8 File Offset: 0x0028A3F8
		public string Param1
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

		// Token: 0x06008F78 RID: 36728 RVA: 0x0028C230 File Offset: 0x0028A430
		public Span<byte> GetParam1Bytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06008F79 RID: 36729 RVA: 0x0028C240 File Offset: 0x0028A440
		public byte[] GetParam1Array()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BBB RID: 7099
		// (get) Token: 0x06008F7A RID: 36730 RVA: 0x0028C258 File Offset: 0x0028A458
		public string Param2
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

		// Token: 0x06008F7B RID: 36731 RVA: 0x0028C290 File Offset: 0x0028A490
		public Span<byte> GetParam2Bytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06008F7C RID: 36732 RVA: 0x0028C2A0 File Offset: 0x0028A4A0
		public byte[] GetParam2Array()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BBC RID: 7100
		// (get) Token: 0x06008F7D RID: 36733 RVA: 0x0028C2B8 File Offset: 0x0028A4B8
		public string Param3
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

		// Token: 0x06008F7E RID: 36734 RVA: 0x0028C2F0 File Offset: 0x0028A4F0
		public Span<byte> GetParam3Bytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008F7F RID: 36735 RVA: 0x0028C300 File Offset: 0x0028A500
		public byte[] GetParam3Array()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BBD RID: 7101
		// (get) Token: 0x06008F80 RID: 36736 RVA: 0x0028C318 File Offset: 0x0028A518
		public string Param4
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

		// Token: 0x06008F81 RID: 36737 RVA: 0x0028C350 File Offset: 0x0028A550
		public Span<byte> GetParam4Bytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008F82 RID: 36738 RVA: 0x0028C360 File Offset: 0x0028A560
		public byte[] GetParam4Array()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17001BBE RID: 7102
		// (get) Token: 0x06008F83 RID: 36739 RVA: 0x0028C378 File Offset: 0x0028A578
		public string Param5
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

		// Token: 0x06008F84 RID: 36740 RVA: 0x0028C3B0 File Offset: 0x0028A5B0
		public Span<byte> GetParam5Bytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008F85 RID: 36741 RVA: 0x0028C3C0 File Offset: 0x0028A5C0
		public byte[] GetParam5Array()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06008F86 RID: 36742 RVA: 0x0028C3D8 File Offset: 0x0028A5D8
		[NullableContext(1)]
		public int[] DescArgs()
		{
			return this.GetDescArgsArray();
		}

		// Token: 0x06008F87 RID: 36743 RVA: 0x0028C3E0 File Offset: 0x0028A5E0
		[NullableContext(1)]
		public IEnumerable<int> DescArgsIter()
		{
			KurotatoEffect.<DescArgsIter>d__46 <DescArgsIter>d__ = new KurotatoEffect.<DescArgsIter>d__46(-2);
			<DescArgsIter>d__.<>3__<>4__this = this;
			return <DescArgsIter>d__;
		}

		// Token: 0x04005411 RID: 21521
		private Table __p;
	}
}
