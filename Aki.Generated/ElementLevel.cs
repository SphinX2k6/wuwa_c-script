using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C28 RID: 3112
	public struct ElementLevel : IFlatbufferObject
	{
		// Token: 0x17000ECA RID: 3786
		// (get) Token: 0x06006844 RID: 26692 RVA: 0x00221684 File Offset: 0x0021F884
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06006845 RID: 26693 RVA: 0x00221691 File Offset: 0x0021F891
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06006846 RID: 26694 RVA: 0x00221698 File Offset: 0x0021F898
		public static ElementLevel GetRootAsElementLevel(ByteBuffer _bb)
		{
			return ElementLevel.GetRootAsElementLevel(_bb, default(ElementLevel));
		}

		// Token: 0x06006847 RID: 26695 RVA: 0x002216B4 File Offset: 0x0021F8B4
		public static ElementLevel GetRootAsElementLevel(ByteBuffer _bb, ElementLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06006848 RID: 26696 RVA: 0x002216D1 File Offset: 0x0021F8D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06006849 RID: 26697 RVA: 0x002216E0 File Offset: 0x0021F8E0
		public ElementLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000ECB RID: 3787
		// (get) Token: 0x0600684A RID: 26698 RVA: 0x002216F0 File Offset: 0x0021F8F0
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

		// Token: 0x17000ECC RID: 3788
		// (get) Token: 0x0600684B RID: 26699 RVA: 0x0022172C File Offset: 0x0021F92C
		public long BuffId
		{
			get
			{
				int num = this.__p.__offset(6);
				return (long)((num != 0) ? this.__p.bb.GetDouble(num + this.__p.bb_pos) : 0.0);
			}
		}

		// Token: 0x0600684C RID: 26700 RVA: 0x00221774 File Offset: 0x0021F974
		public long AddBuffs(int j)
		{
			int num = this.__p.__offset(8);
			return (long)((num != 0) ? this.__p.bb.GetDouble(this.__p.__vector(num) + j * 8) : 0.0);
		}

		// Token: 0x17000ECD RID: 3789
		// (get) Token: 0x0600684D RID: 26701 RVA: 0x002217C0 File Offset: 0x0021F9C0
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

		// Token: 0x0600684E RID: 26702 RVA: 0x002217EB File Offset: 0x0021F9EB
		public Span<long> GetAddBuffsBytes()
		{
			return MemoryMarshal.Cast<double, long>(this.__p.__vector_as_span<double>(8, 8));
		}

		// Token: 0x0600684F RID: 26703 RVA: 0x002217FF File Offset: 0x0021F9FF
		public long[] GetAddBuffsArray()
		{
			return Array.ConvertAll<double, long>(this.__p.__vector_as_array<double>(8) ?? Array.Empty<double>(), (double x) => (long)x);
		}

		// Token: 0x17000ECE RID: 3790
		// (get) Token: 0x06006850 RID: 26704 RVA: 0x0022183C File Offset: 0x0021FA3C
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

		// Token: 0x06006851 RID: 26705 RVA: 0x00221874 File Offset: 0x0021FA74
		public Span<byte> GetTextIdBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06006852 RID: 26706 RVA: 0x00221884 File Offset: 0x0021FA84
		public byte[] GetTextIdArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x06006853 RID: 26707 RVA: 0x0022189C File Offset: 0x0021FA9C
		public string TextIdArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000ECF RID: 3791
		// (get) Token: 0x06006854 RID: 26708 RVA: 0x002218D8 File Offset: 0x0021FAD8
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

		// Token: 0x06006855 RID: 26709 RVA: 0x00221904 File Offset: 0x0021FB04
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AddBuffsIter()或GetAddBuffsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly long[] AddBuffs()
		{
			ElementLevel elementLevel = this;
			return elementLevel.GetAddBuffsArray() ?? Array.Empty<long>();
		}

		// Token: 0x06006856 RID: 26710 RVA: 0x00221928 File Offset: 0x0021FB28
		[NullableContext(1)]
		public readonly IEnumerable<long> AddBuffsIter()
		{
			ElementLevel.<AddBuffsIter>d__25 <AddBuffsIter>d__ = new ElementLevel.<AddBuffsIter>d__25(-2);
			<AddBuffsIter>d__.<>3__<>4__this = this;
			return <AddBuffsIter>d__;
		}

		// Token: 0x06006857 RID: 26711 RVA: 0x0022193D File Offset: 0x0021FB3D
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用TextIdArgsIter()或GetTextIdArgsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] TextIdArgs()
		{
			return this.TextIdArgsIter().ToArray<string>();
		}

		// Token: 0x06006858 RID: 26712 RVA: 0x0022194A File Offset: 0x0021FB4A
		[NullableContext(1)]
		public readonly IEnumerable<string> TextIdArgsIter()
		{
			ElementLevel.<TextIdArgsIter>d__27 <TextIdArgsIter>d__ = new ElementLevel.<TextIdArgsIter>d__27(-2);
			<TextIdArgsIter>d__.<>3__<>4__this = this;
			return <TextIdArgsIter>d__;
		}

		// Token: 0x04004C68 RID: 19560
		private Table __p;
	}
}
