using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001256 RID: 4694
	public struct TermConfig : IFlatbufferObject
	{
		// Token: 0x17003D63 RID: 15715
		// (get) Token: 0x0600EB08 RID: 60168 RVA: 0x00356792 File Offset: 0x00354992
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600EB09 RID: 60169 RVA: 0x0035679F File Offset: 0x0035499F
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600EB0A RID: 60170 RVA: 0x003567A8 File Offset: 0x003549A8
		public static TermConfig GetRootAsTermConfig(ByteBuffer _bb)
		{
			return TermConfig.GetRootAsTermConfig(_bb, default(TermConfig));
		}

		// Token: 0x0600EB0B RID: 60171 RVA: 0x003567C4 File Offset: 0x003549C4
		public static TermConfig GetRootAsTermConfig(ByteBuffer _bb, TermConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600EB0C RID: 60172 RVA: 0x003567E1 File Offset: 0x003549E1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600EB0D RID: 60173 RVA: 0x003567F0 File Offset: 0x003549F0
		public TermConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003D64 RID: 15716
		// (get) Token: 0x0600EB0E RID: 60174 RVA: 0x00356800 File Offset: 0x00354A00
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

		// Token: 0x17003D65 RID: 15717
		// (get) Token: 0x0600EB0F RID: 60175 RVA: 0x0035683C File Offset: 0x00354A3C
		public string Term
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

		// Token: 0x0600EB10 RID: 60176 RVA: 0x00356873 File Offset: 0x00354A73
		public Span<byte> GetTermBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600EB11 RID: 60177 RVA: 0x00356882 File Offset: 0x00354A82
		public byte[] GetTermArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003D66 RID: 15718
		// (get) Token: 0x0600EB12 RID: 60178 RVA: 0x0035689C File Offset: 0x00354A9C
		public string Color
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

		// Token: 0x0600EB13 RID: 60179 RVA: 0x003568D3 File Offset: 0x00354AD3
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600EB14 RID: 60180 RVA: 0x003568E2 File Offset: 0x00354AE2
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600EB15 RID: 60181 RVA: 0x003568FC File Offset: 0x00354AFC
		public string Placeholder(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003D67 RID: 15719
		// (get) Token: 0x0600EB16 RID: 60182 RVA: 0x00356938 File Offset: 0x00354B38
		public int PlaceholderLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600EB17 RID: 60183 RVA: 0x00356964 File Offset: 0x00354B64
		[NullableContext(1)]
		public string[] Placeholder()
		{
			return this.PlaceholderIter().ToArray<string>();
		}

		// Token: 0x0600EB18 RID: 60184 RVA: 0x00356971 File Offset: 0x00354B71
		[NullableContext(1)]
		public IEnumerable<string> PlaceholderIter()
		{
			TermConfig.<PlaceholderIter>d__22 <PlaceholderIter>d__ = new TermConfig.<PlaceholderIter>d__22(-2);
			<PlaceholderIter>d__.<>3__<>4__this = this;
			return <PlaceholderIter>d__;
		}

		// Token: 0x040058A0 RID: 22688
		private Table __p;
	}
}
