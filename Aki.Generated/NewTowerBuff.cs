using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F70 RID: 3952
	public struct NewTowerBuff : IFlatbufferObject
	{
		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x0600A53A RID: 42298 RVA: 0x002BAF98 File Offset: 0x002B9198
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600A53B RID: 42299 RVA: 0x002BAFA5 File Offset: 0x002B91A5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600A53C RID: 42300 RVA: 0x002BAFAC File Offset: 0x002B91AC
		public static NewTowerBuff GetRootAsNewTowerBuff(ByteBuffer _bb)
		{
			return NewTowerBuff.GetRootAsNewTowerBuff(_bb, default(NewTowerBuff));
		}

		// Token: 0x0600A53D RID: 42301 RVA: 0x002BAFC8 File Offset: 0x002B91C8
		public static NewTowerBuff GetRootAsNewTowerBuff(ByteBuffer _bb, NewTowerBuff obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600A53E RID: 42302 RVA: 0x002BAFE5 File Offset: 0x002B91E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600A53F RID: 42303 RVA: 0x002BAFF4 File Offset: 0x002B91F4
		public NewTowerBuff __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0600A540 RID: 42304 RVA: 0x002BB004 File Offset: 0x002B9204
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

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0600A541 RID: 42305 RVA: 0x002BB040 File Offset: 0x002B9240
		public string Icon
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

		// Token: 0x0600A542 RID: 42306 RVA: 0x002BB077 File Offset: 0x002B9277
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600A543 RID: 42307 RVA: 0x002BB086 File Offset: 0x002B9286
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0600A544 RID: 42308 RVA: 0x002BB0A0 File Offset: 0x002B92A0
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

		// Token: 0x0600A545 RID: 42309 RVA: 0x002BB0D7 File Offset: 0x002B92D7
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600A546 RID: 42310 RVA: 0x002BB0E6 File Offset: 0x002B92E6
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170023A7 RID: 9127
		// (get) Token: 0x0600A547 RID: 42311 RVA: 0x002BB100 File Offset: 0x002B9300
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

		// Token: 0x0600A548 RID: 42312 RVA: 0x002BB138 File Offset: 0x002B9338
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600A549 RID: 42313 RVA: 0x002BB148 File Offset: 0x002B9348
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A54A RID: 42314 RVA: 0x002BB160 File Offset: 0x002B9360
		public string DescParam(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170023A8 RID: 9128
		// (get) Token: 0x0600A54B RID: 42315 RVA: 0x002BB19C File Offset: 0x002B939C
		public int DescParamLength
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

		// Token: 0x170023A9 RID: 9129
		// (get) Token: 0x0600A54C RID: 42316 RVA: 0x002BB1C8 File Offset: 0x002B93C8
		public string SmallIcon
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

		// Token: 0x0600A54D RID: 42317 RVA: 0x002BB200 File Offset: 0x002B9400
		public Span<byte> GetSmallIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600A54E RID: 42318 RVA: 0x002BB210 File Offset: 0x002B9410
		public byte[] GetSmallIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600A54F RID: 42319 RVA: 0x002BB228 File Offset: 0x002B9428
		[NullableContext(1)]
		public string[] DescParam()
		{
			return this.DescParamIter().ToArray<string>();
		}

		// Token: 0x0600A550 RID: 42320 RVA: 0x002BB235 File Offset: 0x002B9435
		[NullableContext(1)]
		public IEnumerable<string> DescParamIter()
		{
			NewTowerBuff.<DescParamIter>d__30 <DescParamIter>d__ = new NewTowerBuff.<DescParamIter>d__30(-2);
			<DescParamIter>d__.<>3__<>4__this = this;
			return <DescParamIter>d__;
		}

		// Token: 0x0400551E RID: 21790
		private Table __p;
	}
}
