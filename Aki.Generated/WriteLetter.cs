using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020012DE RID: 4830
	public struct WriteLetter : IFlatbufferObject
	{
		// Token: 0x170041E6 RID: 16870
		// (get) Token: 0x0600F6CA RID: 63178 RVA: 0x00370BD1 File Offset: 0x0036EDD1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600F6CB RID: 63179 RVA: 0x00370BDE File Offset: 0x0036EDDE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600F6CC RID: 63180 RVA: 0x00370BE8 File Offset: 0x0036EDE8
		public static WriteLetter GetRootAsWriteLetter(ByteBuffer _bb)
		{
			return WriteLetter.GetRootAsWriteLetter(_bb, default(WriteLetter));
		}

		// Token: 0x0600F6CD RID: 63181 RVA: 0x00370C04 File Offset: 0x0036EE04
		public static WriteLetter GetRootAsWriteLetter(ByteBuffer _bb, WriteLetter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600F6CE RID: 63182 RVA: 0x00370C21 File Offset: 0x0036EE21
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600F6CF RID: 63183 RVA: 0x00370C30 File Offset: 0x0036EE30
		public WriteLetter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170041E7 RID: 16871
		// (get) Token: 0x0600F6D0 RID: 63184 RVA: 0x00370C40 File Offset: 0x0036EE40
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

		// Token: 0x170041E8 RID: 16872
		// (get) Token: 0x0600F6D1 RID: 63185 RVA: 0x00370C7C File Offset: 0x0036EE7C
		public string Style
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

		// Token: 0x0600F6D2 RID: 63186 RVA: 0x00370CB3 File Offset: 0x0036EEB3
		public Span<byte> GetStyleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600F6D3 RID: 63187 RVA: 0x00370CC2 File Offset: 0x0036EEC2
		public byte[] GetStyleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F6D4 RID: 63188 RVA: 0x00370CDC File Offset: 0x0036EEDC
		public string Flow(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170041E9 RID: 16873
		// (get) Token: 0x0600F6D5 RID: 63189 RVA: 0x00370D18 File Offset: 0x0036EF18
		public int FlowLength
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

		// Token: 0x170041EA RID: 16874
		// (get) Token: 0x0600F6D6 RID: 63190 RVA: 0x00370D44 File Offset: 0x0036EF44
		public string Title
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

		// Token: 0x0600F6D7 RID: 63191 RVA: 0x00370D7C File Offset: 0x0036EF7C
		public Span<byte> GetTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600F6D8 RID: 63192 RVA: 0x00370D8C File Offset: 0x0036EF8C
		public byte[] GetTitleArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600F6D9 RID: 63193 RVA: 0x00370DA4 File Offset: 0x0036EFA4
		[NullableContext(1)]
		public string[] Flow()
		{
			return this.FlowIter().ToArray<string>();
		}

		// Token: 0x0600F6DA RID: 63194 RVA: 0x00370DB1 File Offset: 0x0036EFB1
		[NullableContext(1)]
		public IEnumerable<string> FlowIter()
		{
			WriteLetter.<FlowIter>d__22 <FlowIter>d__ = new WriteLetter.<FlowIter>d__22(-2);
			<FlowIter>d__.<>3__<>4__this = this;
			return <FlowIter>d__;
		}

		// Token: 0x04005938 RID: 22840
		private Table __p;
	}
}
