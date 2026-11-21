using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001100 RID: 4352
	public struct RogueResTaskTheme : IFlatbufferObject
	{
		// Token: 0x17003158 RID: 12632
		// (get) Token: 0x0600CA82 RID: 51842 RVA: 0x0030C5A1 File Offset: 0x0030A7A1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600CA83 RID: 51843 RVA: 0x0030C5AE File Offset: 0x0030A7AE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600CA84 RID: 51844 RVA: 0x0030C5B8 File Offset: 0x0030A7B8
		public static RogueResTaskTheme GetRootAsRogueResTaskTheme(ByteBuffer _bb)
		{
			return RogueResTaskTheme.GetRootAsRogueResTaskTheme(_bb, default(RogueResTaskTheme));
		}

		// Token: 0x0600CA85 RID: 51845 RVA: 0x0030C5D4 File Offset: 0x0030A7D4
		public static RogueResTaskTheme GetRootAsRogueResTaskTheme(ByteBuffer _bb, RogueResTaskTheme obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600CA86 RID: 51846 RVA: 0x0030C5F1 File Offset: 0x0030A7F1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600CA87 RID: 51847 RVA: 0x0030C600 File Offset: 0x0030A800
		public RogueResTaskTheme __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003159 RID: 12633
		// (get) Token: 0x0600CA88 RID: 51848 RVA: 0x0030C610 File Offset: 0x0030A810
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

		// Token: 0x0600CA89 RID: 51849 RVA: 0x0030C64C File Offset: 0x0030A84C
		public int RoleImage(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700315A RID: 12634
		// (get) Token: 0x0600CA8A RID: 51850 RVA: 0x0030C68C File Offset: 0x0030A88C
		public int RoleImageLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600CA8B RID: 51851 RVA: 0x0030C6B7 File Offset: 0x0030A8B7
		public Span<int> GetRoleImageBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600CA8C RID: 51852 RVA: 0x0030C6C6 File Offset: 0x0030A8C6
		public int[] GetRoleImageArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600CA8D RID: 51853 RVA: 0x0030C6E0 File Offset: 0x0030A8E0
		public DicIntString? TabNames(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700315B RID: 12635
		// (get) Token: 0x0600CA8E RID: 51854 RVA: 0x0030C740 File Offset: 0x0030A940
		public int TabNamesLength
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

		// Token: 0x0600CA8F RID: 51855 RVA: 0x0030C76B File Offset: 0x0030A96B
		[NullableContext(1)]
		public int[] RoleImage()
		{
			return this.GetRoleImageArray();
		}

		// Token: 0x0600CA90 RID: 51856 RVA: 0x0030C773 File Offset: 0x0030A973
		[NullableContext(1)]
		public IEnumerable<int> RoleImageIter()
		{
			RogueResTaskTheme.<RoleImageIter>d__19 <RoleImageIter>d__ = new RogueResTaskTheme.<RoleImageIter>d__19(-2);
			<RoleImageIter>d__.<>3__<>4__this = this;
			return <RoleImageIter>d__;
		}

		// Token: 0x0600CA91 RID: 51857 RVA: 0x0030C788 File Offset: 0x0030A988
		[NullableContext(1)]
		public Dictionary<int, string> TabNames()
		{
			return this.TabNamesIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600CA92 RID: 51858 RVA: 0x0030C7DE File Offset: 0x0030A9DE
		[NullableContext(1)]
		public IEnumerable<DicIntString> TabNamesIter()
		{
			RogueResTaskTheme.<TabNamesIter>d__21 <TabNamesIter>d__ = new RogueResTaskTheme.<TabNamesIter>d__21(-2);
			<TabNamesIter>d__.<>3__<>4__this = this;
			return <TabNamesIter>d__;
		}

		// Token: 0x0600CA93 RID: 51859 RVA: 0x0030C7F4 File Offset: 0x0030A9F4
		[NullableContext(2)]
		public string GetTabNames(int key)
		{
			this.EnsureTabNamesCacheIfNeeded();
			string result;
			if (!this.TabNamesCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600CA94 RID: 51860 RVA: 0x0030C81C File Offset: 0x0030AA1C
		private void EnsureTabNamesCacheIfNeeded()
		{
			if (this.TabNamesCache != null)
			{
				return;
			}
			this.TabNamesCache = this.TabNamesIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600CA95 RID: 51861 RVA: 0x0030C882 File Offset: 0x0030AA82
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetTabNamesFrozenDict()
		{
			this.EnsureTabNamesCacheIfNeeded();
			return this.TabNamesCache;
		}

		// Token: 0x040056EE RID: 22254
		private Table __p;

		// Token: 0x040056EF RID: 22255
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabNamesCache;
	}
}
