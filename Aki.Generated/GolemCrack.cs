using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000DEE RID: 3566
	public struct GolemCrack : IFlatbufferObject
	{
		// Token: 0x1700164A RID: 5706
		// (get) Token: 0x0600817B RID: 33147 RVA: 0x0026BD7F File Offset: 0x00269F7F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600817C RID: 33148 RVA: 0x0026BD8C File Offset: 0x00269F8C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600817D RID: 33149 RVA: 0x0026BD94 File Offset: 0x00269F94
		public static GolemCrack GetRootAsGolemCrack(ByteBuffer _bb)
		{
			return GolemCrack.GetRootAsGolemCrack(_bb, default(GolemCrack));
		}

		// Token: 0x0600817E RID: 33150 RVA: 0x0026BDB0 File Offset: 0x00269FB0
		public static GolemCrack GetRootAsGolemCrack(ByteBuffer _bb, GolemCrack obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600817F RID: 33151 RVA: 0x0026BDCD File Offset: 0x00269FCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008180 RID: 33152 RVA: 0x0026BDDC File Offset: 0x00269FDC
		public GolemCrack __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700164B RID: 5707
		// (get) Token: 0x06008181 RID: 33153 RVA: 0x0026BDEC File Offset: 0x00269FEC
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

		// Token: 0x1700164C RID: 5708
		// (get) Token: 0x06008182 RID: 33154 RVA: 0x0026BE28 File Offset: 0x0026A028
		public int ActivityId
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

		// Token: 0x06008183 RID: 33155 RVA: 0x0026BE64 File Offset: 0x0026A064
		public int ConfigIds(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700164D RID: 5709
		// (get) Token: 0x06008184 RID: 33156 RVA: 0x0026BEA4 File Offset: 0x0026A0A4
		public int ConfigIdsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008185 RID: 33157 RVA: 0x0026BECF File Offset: 0x0026A0CF
		public Span<int> GetConfigIdsBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06008186 RID: 33158 RVA: 0x0026BEDE File Offset: 0x0026A0DE
		public int[] GetConfigIdsArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x1700164E RID: 5710
		// (get) Token: 0x06008187 RID: 33159 RVA: 0x0026BEF8 File Offset: 0x0026A0F8
		public int Group
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return -1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700164F RID: 5711
		// (get) Token: 0x06008188 RID: 33160 RVA: 0x0026BF38 File Offset: 0x0026A138
		public int UnlockId
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

		// Token: 0x17001650 RID: 5712
		// (get) Token: 0x06008189 RID: 33161 RVA: 0x0026BF78 File Offset: 0x0026A178
		public int OpenDay
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

		// Token: 0x17001651 RID: 5713
		// (get) Token: 0x0600818A RID: 33162 RVA: 0x0026BFB8 File Offset: 0x0026A1B8
		public int DropId
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

		// Token: 0x17001652 RID: 5714
		// (get) Token: 0x0600818B RID: 33163 RVA: 0x0026BFF8 File Offset: 0x0026A1F8
		public string Title
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

		// Token: 0x0600818C RID: 33164 RVA: 0x0026C030 File Offset: 0x0026A230
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600818D RID: 33165 RVA: 0x0026C040 File Offset: 0x0026A240
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001653 RID: 5715
		// (get) Token: 0x0600818E RID: 33166 RVA: 0x0026C058 File Offset: 0x0026A258
		public string Desc
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

		// Token: 0x0600818F RID: 33167 RVA: 0x0026C090 File Offset: 0x0026A290
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06008190 RID: 33168 RVA: 0x0026C0A0 File Offset: 0x0026A2A0
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x06008191 RID: 33169 RVA: 0x0026C0B8 File Offset: 0x0026A2B8
		[NullableContext(1)]
		public int[] ConfigIds()
		{
			return this.GetConfigIdsArray();
		}

		// Token: 0x06008192 RID: 33170 RVA: 0x0026C0C0 File Offset: 0x0026A2C0
		[NullableContext(1)]
		public IEnumerable<int> ConfigIdsIter()
		{
			GolemCrack.<ConfigIdsIter>d__34 <ConfigIdsIter>d__ = new GolemCrack.<ConfigIdsIter>d__34(-2);
			<ConfigIdsIter>d__.<>3__<>4__this = this;
			return <ConfigIdsIter>d__;
		}

		// Token: 0x04005364 RID: 21348
		private Table __p;
	}
}
