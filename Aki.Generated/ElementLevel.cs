using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D0B RID: 3339
	public struct ElementLevel : IFlatbufferObject
	{
		// Token: 0x17000F23 RID: 3875
		// (get) Token: 0x06006E46 RID: 28230 RVA: 0x00240C08 File Offset: 0x0023EE08
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006E47 RID: 28231 RVA: 0x00240C15 File Offset: 0x0023EE15
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006E48 RID: 28232 RVA: 0x00240C1C File Offset: 0x0023EE1C
		public static ElementLevel GetRootAsElementLevel(ByteBuffer _bb)
		{
			return ElementLevel.GetRootAsElementLevel(_bb, default(ElementLevel));
		}

		// Token: 0x06006E49 RID: 28233 RVA: 0x00240C38 File Offset: 0x0023EE38
		public static ElementLevel GetRootAsElementLevel(ByteBuffer _bb, ElementLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006E4A RID: 28234 RVA: 0x00240C55 File Offset: 0x0023EE55
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006E4B RID: 28235 RVA: 0x00240C64 File Offset: 0x0023EE64
		public ElementLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000F24 RID: 3876
		// (get) Token: 0x06006E4C RID: 28236 RVA: 0x00240C74 File Offset: 0x0023EE74
		public int Level
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

		// Token: 0x17000F25 RID: 3877
		// (get) Token: 0x06006E4D RID: 28237 RVA: 0x00240CB0 File Offset: 0x0023EEB0
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x06006E4E RID: 28238 RVA: 0x00240CF8 File Offset: 0x0023EEF8
		public long AddBuffs(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000F26 RID: 3878
		// (get) Token: 0x06006E4F RID: 28239 RVA: 0x00240D44 File Offset: 0x0023EF44
		public int AddBuffsLength
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

		// Token: 0x06006E50 RID: 28240 RVA: 0x00240D6F File Offset: 0x0023EF6F
		public Span<long> GetAddBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x06006E51 RID: 28241 RVA: 0x00240D83 File Offset: 0x0023EF83
		public long[] GetAddBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17000F27 RID: 3879
		// (get) Token: 0x06006E52 RID: 28242 RVA: 0x00240DC0 File Offset: 0x0023EFC0
		public string TextId
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

		// Token: 0x06006E53 RID: 28243 RVA: 0x00240DF8 File Offset: 0x0023EFF8
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006E54 RID: 28244 RVA: 0x00240E08 File Offset: 0x0023F008
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06006E55 RID: 28245 RVA: 0x00240E20 File Offset: 0x0023F020
		public string TextIdArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000F28 RID: 3880
		// (get) Token: 0x06006E56 RID: 28246 RVA: 0x00240E5C File Offset: 0x0023F05C
		public int TextIdArgsLength
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

		// Token: 0x06006E57 RID: 28247 RVA: 0x00240E88 File Offset: 0x0023F088
		[NullableContext(1)]
		public long[] AddBuffs()
		{
			return this.GetAddBuffsArray();
		}

		// Token: 0x06006E58 RID: 28248 RVA: 0x00240E90 File Offset: 0x0023F090
		[NullableContext(1)]
		public IEnumerable<long> AddBuffsIter()
		{
			ElementLevel.<AddBuffsIter>d__25 <AddBuffsIter>d__ = new ElementLevel.<AddBuffsIter>d__25(-2);
			<AddBuffsIter>d__.<>3__<>4__this = this;
			return <AddBuffsIter>d__;
		}

		// Token: 0x06006E59 RID: 28249 RVA: 0x00240EA5 File Offset: 0x0023F0A5
		[NullableContext(1)]
		public string[] TextIdArgs()
		{
			return this.TextIdArgsIter().ToArray<string>();
		}

		// Token: 0x06006E5A RID: 28250 RVA: 0x00240EB2 File Offset: 0x0023F0B2
		[NullableContext(1)]
		public IEnumerable<string> TextIdArgsIter()
		{
			ElementLevel.<TextIdArgsIter>d__27 <TextIdArgsIter>d__ = new ElementLevel.<TextIdArgsIter>d__27(-2);
			<TextIdArgsIter>d__.<>3__<>4__this = this;
			return <TextIdArgsIter>d__;
		}

		// Token: 0x0400524B RID: 21067
		private Table __p;
	}
}
