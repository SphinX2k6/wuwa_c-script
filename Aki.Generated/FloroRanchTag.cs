using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D98 RID: 3480
	public struct FloroRanchTag : IFlatbufferObject
	{
		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06007A6A RID: 31338 RVA: 0x0025C664 File Offset: 0x0025A864
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06007A6B RID: 31339 RVA: 0x0025C671 File Offset: 0x0025A871
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06007A6C RID: 31340 RVA: 0x0025C678 File Offset: 0x0025A878
		public static FloroRanchTag GetRootAsFloroRanchTag(ByteBuffer _bb)
		{
			return FloroRanchTag.GetRootAsFloroRanchTag(_bb, default(FloroRanchTag));
		}

		// Token: 0x06007A6D RID: 31341 RVA: 0x0025C694 File Offset: 0x0025A894
		public static FloroRanchTag GetRootAsFloroRanchTag(ByteBuffer _bb, FloroRanchTag obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06007A6E RID: 31342 RVA: 0x0025C6B1 File Offset: 0x0025A8B1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06007A6F RID: 31343 RVA: 0x0025C6C0 File Offset: 0x0025A8C0
		public FloroRanchTag __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06007A70 RID: 31344 RVA: 0x0025C6D0 File Offset: 0x0025A8D0
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

		// Token: 0x1700139C RID: 5020
		// (get) Token: 0x06007A71 RID: 31345 RVA: 0x0025C70C File Offset: 0x0025A90C
		public string Name
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

		// Token: 0x06007A72 RID: 31346 RVA: 0x0025C743 File Offset: 0x0025A943
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06007A73 RID: 31347 RVA: 0x0025C752 File Offset: 0x0025A952
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x06007A74 RID: 31348 RVA: 0x0025C76C File Offset: 0x0025A96C
		public string NameParam(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700139D RID: 5021
		// (get) Token: 0x06007A75 RID: 31349 RVA: 0x0025C7A8 File Offset: 0x0025A9A8
		public int NameParamLength
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

		// Token: 0x1700139E RID: 5022
		// (get) Token: 0x06007A76 RID: 31350 RVA: 0x0025C7D4 File Offset: 0x0025A9D4
		public string N
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

		// Token: 0x06007A77 RID: 31351 RVA: 0x0025C80C File Offset: 0x0025AA0C
		public Span<byte> GetNBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06007A78 RID: 31352 RVA: 0x0025C81C File Offset: 0x0025AA1C
		public byte[] GetNArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700139F RID: 5023
		// (get) Token: 0x06007A79 RID: 31353 RVA: 0x0025C834 File Offset: 0x0025AA34
		public string M
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

		// Token: 0x06007A7A RID: 31354 RVA: 0x0025C86C File Offset: 0x0025AA6C
		public Span<byte> GetMBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06007A7B RID: 31355 RVA: 0x0025C87C File Offset: 0x0025AA7C
		public byte[] GetMArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170013A0 RID: 5024
		// (get) Token: 0x06007A7C RID: 31356 RVA: 0x0025C894 File Offset: 0x0025AA94
		public string P
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

		// Token: 0x06007A7D RID: 31357 RVA: 0x0025C8CC File Offset: 0x0025AACC
		public Span<byte> GetPBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06007A7E RID: 31358 RVA: 0x0025C8DC File Offset: 0x0025AADC
		public byte[] GetPArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x06007A7F RID: 31359 RVA: 0x0025C8F4 File Offset: 0x0025AAF4
		[NullableContext(1)]
		public string[] NameParam()
		{
			return this.NameParamIter().ToArray<string>();
		}

		// Token: 0x06007A80 RID: 31360 RVA: 0x0025C901 File Offset: 0x0025AB01
		[NullableContext(1)]
		public IEnumerable<string> NameParamIter()
		{
			FloroRanchTag.<NameParamIter>d__30 <NameParamIter>d__ = new FloroRanchTag.<NameParamIter>d__30(-2);
			<NameParamIter>d__.<>3__<>4__this = this;
			return <NameParamIter>d__;
		}

		// Token: 0x04005303 RID: 21251
		private Table __p;
	}
}
