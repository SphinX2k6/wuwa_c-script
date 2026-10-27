using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001120 RID: 4384
	public struct TermConfig : IFlatbufferObject
	{
		// Token: 0x17003A0D RID: 14861
		// (get) Token: 0x0600DDBD RID: 56765 RVA: 0x0032B695 File Offset: 0x00329895
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DDBE RID: 56766 RVA: 0x0032B6A2 File Offset: 0x003298A2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DDBF RID: 56767 RVA: 0x0032B6AC File Offset: 0x003298AC
		public static TermConfig GetRootAsTermConfig(ByteBuffer _bb)
		{
			return TermConfig.GetRootAsTermConfig(_bb, default(TermConfig));
		}

		// Token: 0x0600DDC0 RID: 56768 RVA: 0x0032B6C8 File Offset: 0x003298C8
		public static TermConfig GetRootAsTermConfig(ByteBuffer _bb, TermConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DDC1 RID: 56769 RVA: 0x0032B6E5 File Offset: 0x003298E5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DDC2 RID: 56770 RVA: 0x0032B6F4 File Offset: 0x003298F4
		public TermConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003A0E RID: 14862
		// (get) Token: 0x0600DDC3 RID: 56771 RVA: 0x0032B704 File Offset: 0x00329904
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

		// Token: 0x17003A0F RID: 14863
		// (get) Token: 0x0600DDC4 RID: 56772 RVA: 0x0032B740 File Offset: 0x00329940
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

		// Token: 0x0600DDC5 RID: 56773 RVA: 0x0032B777 File Offset: 0x00329977
		public Span<byte> GetTermBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600DDC6 RID: 56774 RVA: 0x0032B786 File Offset: 0x00329986
		public byte[] GetTermArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003A10 RID: 14864
		// (get) Token: 0x0600DDC7 RID: 56775 RVA: 0x0032B7A0 File Offset: 0x003299A0
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

		// Token: 0x0600DDC8 RID: 56776 RVA: 0x0032B7D7 File Offset: 0x003299D7
		public Span<byte> GetColorBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DDC9 RID: 56777 RVA: 0x0032B7E6 File Offset: 0x003299E6
		public byte[] GetColorArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DDCA RID: 56778 RVA: 0x0032B800 File Offset: 0x00329A00
		public string Placeholder(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003A11 RID: 14865
		// (get) Token: 0x0600DDCB RID: 56779 RVA: 0x0032B83C File Offset: 0x00329A3C
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

		// Token: 0x0600DDCC RID: 56780 RVA: 0x0032B868 File Offset: 0x00329A68
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PlaceholderIter()或GetPlaceholderBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] Placeholder()
		{
			return this.PlaceholderIter().ToArray<string>();
		}

		// Token: 0x0600DDCD RID: 56781 RVA: 0x0032B875 File Offset: 0x00329A75
		[NullableContext(1)]
		public readonly IEnumerable<string> PlaceholderIter()
		{
			TermConfig.<PlaceholderIter>d__22 <PlaceholderIter>d__ = new TermConfig.<PlaceholderIter>d__22(-2);
			<PlaceholderIter>d__.<>3__<>4__this = this;
			return <PlaceholderIter>d__;
		}

		// Token: 0x0400525D RID: 21085
		private Table __p;
	}
}
