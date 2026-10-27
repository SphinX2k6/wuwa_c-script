using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B88 RID: 2952
	public struct ComboTeaching : IFlatbufferObject
	{
		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x060056D5 RID: 22229 RVA: 0x001F9708 File Offset: 0x001F7908
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060056D6 RID: 22230 RVA: 0x001F9715 File Offset: 0x001F7915
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060056D7 RID: 22231 RVA: 0x001F971C File Offset: 0x001F791C
		public static ComboTeaching GetRootAsComboTeaching(ByteBuffer _bb)
		{
			return ComboTeaching.GetRootAsComboTeaching(_bb, default(ComboTeaching));
		}

		// Token: 0x060056D8 RID: 22232 RVA: 0x001F9738 File Offset: 0x001F7938
		public static ComboTeaching GetRootAsComboTeaching(ByteBuffer _bb, ComboTeaching obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060056D9 RID: 22233 RVA: 0x001F9755 File Offset: 0x001F7955
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060056DA RID: 22234 RVA: 0x001F9764 File Offset: 0x001F7964
		public ComboTeaching __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x060056DB RID: 22235 RVA: 0x001F9774 File Offset: 0x001F7974
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

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x060056DC RID: 22236 RVA: 0x001F97B0 File Offset: 0x001F79B0
		public int NextRoleGuideID
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

		// Token: 0x060056DD RID: 22237 RVA: 0x001F97EC File Offset: 0x001F79EC
		public string KeyID(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x060056DE RID: 22238 RVA: 0x001F9828 File Offset: 0x001F7A28
		public int KeyIDLength
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

		// Token: 0x060056DF RID: 22239 RVA: 0x001F9854 File Offset: 0x001F7A54
		public string IconText(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x060056E0 RID: 22240 RVA: 0x001F9890 File Offset: 0x001F7A90
		public int IconTextLength
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

		// Token: 0x060056E1 RID: 22241 RVA: 0x001F98BC File Offset: 0x001F7ABC
		public string IconTagText(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x060056E2 RID: 22242 RVA: 0x001F98F8 File Offset: 0x001F7AF8
		public int IconTagTextLength
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

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x060056E3 RID: 22243 RVA: 0x001F9924 File Offset: 0x001F7B24
		public string DescriptionTitle
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

		// Token: 0x060056E4 RID: 22244 RVA: 0x001F995C File Offset: 0x001F7B5C
		public Span<byte> GetDescriptionTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x060056E5 RID: 22245 RVA: 0x001F996C File Offset: 0x001F7B6C
		public byte[] GetDescriptionTitleArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x060056E6 RID: 22246 RVA: 0x001F9984 File Offset: 0x001F7B84
		public string DescriptionContent
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

		// Token: 0x060056E7 RID: 22247 RVA: 0x001F99BC File Offset: 0x001F7BBC
		public Span<byte> GetDescriptionContentBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x060056E8 RID: 22248 RVA: 0x001F99CC File Offset: 0x001F7BCC
		public byte[] GetDescriptionContentArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x060056E9 RID: 22249 RVA: 0x001F99E4 File Offset: 0x001F7BE4
		public int CommandID(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x060056EA RID: 22250 RVA: 0x001F9A24 File Offset: 0x001F7C24
		public int CommandIDLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060056EB RID: 22251 RVA: 0x001F9A50 File Offset: 0x001F7C50
		public Span<int> GetCommandIDBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x060056EC RID: 22252 RVA: 0x001F9A60 File Offset: 0x001F7C60
		public int[] GetCommandIDArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x060056ED RID: 22253 RVA: 0x001F9A78 File Offset: 0x001F7C78
		public int GuideID(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x060056EE RID: 22254 RVA: 0x001F9AB8 File Offset: 0x001F7CB8
		public int GuideIDLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060056EF RID: 22255 RVA: 0x001F9AE4 File Offset: 0x001F7CE4
		public Span<int> GetGuideIDBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x060056F0 RID: 22256 RVA: 0x001F9AF4 File Offset: 0x001F7CF4
		public int[] GetGuideIDArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x060056F1 RID: 22257 RVA: 0x001F9B0C File Offset: 0x001F7D0C
		public string InputEnums(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x060056F2 RID: 22258 RVA: 0x001F9B48 File Offset: 0x001F7D48
		public int InputEnumsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060056F3 RID: 22259 RVA: 0x001F9B74 File Offset: 0x001F7D74
		public long AddBuffID(int j)
		{
			int num = this.__p.__offset(24);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x060056F4 RID: 22260 RVA: 0x001F9BC0 File Offset: 0x001F7DC0
		public int AddBuffIDLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060056F5 RID: 22261 RVA: 0x001F9BEC File Offset: 0x001F7DEC
		public Span<long> GetAddBuffIDBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(24, 8));
		}

		// Token: 0x060056F6 RID: 22262 RVA: 0x001F9C01 File Offset: 0x001F7E01
		public long[] GetAddBuffIDArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(24) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x060056F7 RID: 22263 RVA: 0x001F9C40 File Offset: 0x001F7E40
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddBuffIDIter()或GetAddBuffIDBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] AddBuffID()
		{
			ComboTeaching comboTeaching = this;
			return comboTeaching.GetAddBuffIDArray() ?? Array.Empty<long>();
		}

		// Token: 0x060056F8 RID: 22264 RVA: 0x001F9C64 File Offset: 0x001F7E64
		[NullableContext(1)]
		public readonly IEnumerable<long> AddBuffIDIter()
		{
			ComboTeaching.<AddBuffIDIter>d__48 <AddBuffIDIter>d__ = new ComboTeaching.<AddBuffIDIter>d__48(-2);
			<AddBuffIDIter>d__.<>3__<>4__this = this;
			return <AddBuffIDIter>d__;
		}

		// Token: 0x060056F9 RID: 22265 RVA: 0x001F9C7C File Offset: 0x001F7E7C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CommandIDIter()或GetCommandIDBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CommandID()
		{
			ComboTeaching comboTeaching = this;
			return comboTeaching.GetCommandIDArray() ?? Array.Empty<int>();
		}

		// Token: 0x060056FA RID: 22266 RVA: 0x001F9CA0 File Offset: 0x001F7EA0
		[NullableContext(1)]
		public readonly IEnumerable<int> CommandIDIter()
		{
			ComboTeaching.<CommandIDIter>d__50 <CommandIDIter>d__ = new ComboTeaching.<CommandIDIter>d__50(-2);
			<CommandIDIter>d__.<>3__<>4__this = this;
			return <CommandIDIter>d__;
		}

		// Token: 0x060056FB RID: 22267 RVA: 0x001F9CB8 File Offset: 0x001F7EB8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用GuideIDIter()或GetGuideIDBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] GuideID()
		{
			ComboTeaching comboTeaching = this;
			return comboTeaching.GetGuideIDArray() ?? Array.Empty<int>();
		}

		// Token: 0x060056FC RID: 22268 RVA: 0x001F9CDC File Offset: 0x001F7EDC
		[NullableContext(1)]
		public readonly IEnumerable<int> GuideIDIter()
		{
			ComboTeaching.<GuideIDIter>d__52 <GuideIDIter>d__ = new ComboTeaching.<GuideIDIter>d__52(-2);
			<GuideIDIter>d__.<>3__<>4__this = this;
			return <GuideIDIter>d__;
		}

		// Token: 0x060056FD RID: 22269 RVA: 0x001F9CF1 File Offset: 0x001F7EF1
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IconTagTextIter()或GetIconTagTextBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IconTagText()
		{
			return this.IconTagTextIter().ToArray<string>();
		}

		// Token: 0x060056FE RID: 22270 RVA: 0x001F9CFE File Offset: 0x001F7EFE
		[NullableContext(1)]
		public readonly IEnumerable<string> IconTagTextIter()
		{
			ComboTeaching.<IconTagTextIter>d__54 <IconTagTextIter>d__ = new ComboTeaching.<IconTagTextIter>d__54(-2);
			<IconTagTextIter>d__.<>3__<>4__this = this;
			return <IconTagTextIter>d__;
		}

		// Token: 0x060056FF RID: 22271 RVA: 0x001F9D13 File Offset: 0x001F7F13
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用IconTextIter()或GetIconTextBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] IconText()
		{
			return this.IconTextIter().ToArray<string>();
		}

		// Token: 0x06005700 RID: 22272 RVA: 0x001F9D20 File Offset: 0x001F7F20
		[NullableContext(1)]
		public readonly IEnumerable<string> IconTextIter()
		{
			ComboTeaching.<IconTextIter>d__56 <IconTextIter>d__ = new ComboTeaching.<IconTextIter>d__56(-2);
			<IconTextIter>d__.<>3__<>4__this = this;
			return <IconTextIter>d__;
		}

		// Token: 0x06005701 RID: 22273 RVA: 0x001F9D35 File Offset: 0x001F7F35
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用InputEnumsIter()或GetInputEnumsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] InputEnums()
		{
			return this.InputEnumsIter().ToArray<string>();
		}

		// Token: 0x06005702 RID: 22274 RVA: 0x001F9D42 File Offset: 0x001F7F42
		[NullableContext(1)]
		public readonly IEnumerable<string> InputEnumsIter()
		{
			ComboTeaching.<InputEnumsIter>d__58 <InputEnumsIter>d__ = new ComboTeaching.<InputEnumsIter>d__58(-2);
			<InputEnumsIter>d__.<>3__<>4__this = this;
			return <InputEnumsIter>d__;
		}

		// Token: 0x06005703 RID: 22275 RVA: 0x001F9D57 File Offset: 0x001F7F57
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用KeyIDIter()或GetKeyIDBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] KeyID()
		{
			return this.KeyIDIter().ToArray<string>();
		}

		// Token: 0x06005704 RID: 22276 RVA: 0x001F9D64 File Offset: 0x001F7F64
		[NullableContext(1)]
		public readonly IEnumerable<string> KeyIDIter()
		{
			ComboTeaching.<KeyIDIter>d__60 <KeyIDIter>d__ = new ComboTeaching.<KeyIDIter>d__60(-2);
			<KeyIDIter>d__.<>3__<>4__this = this;
			return <KeyIDIter>d__;
		}

		// Token: 0x04004B97 RID: 19351
		private Table __p;
	}
}
