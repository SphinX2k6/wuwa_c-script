using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001018 RID: 4120
	public struct RogueResTaskTheme : IFlatbufferObject
	{
		// Token: 0x170030DD RID: 12509
		// (get) Token: 0x0600C438 RID: 50232 RVA: 0x002F0501 File Offset: 0x002EE701
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C439 RID: 50233 RVA: 0x002F050E File Offset: 0x002EE70E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C43A RID: 50234 RVA: 0x002F0518 File Offset: 0x002EE718
		public static RogueResTaskTheme GetRootAsRogueResTaskTheme(ByteBuffer _bb)
		{
			return RogueResTaskTheme.GetRootAsRogueResTaskTheme(_bb, default(RogueResTaskTheme));
		}

		// Token: 0x0600C43B RID: 50235 RVA: 0x002F0534 File Offset: 0x002EE734
		public static RogueResTaskTheme GetRootAsRogueResTaskTheme(ByteBuffer _bb, RogueResTaskTheme obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C43C RID: 50236 RVA: 0x002F0551 File Offset: 0x002EE751
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C43D RID: 50237 RVA: 0x002F0560 File Offset: 0x002EE760
		public RogueResTaskTheme __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170030DE RID: 12510
		// (get) Token: 0x0600C43E RID: 50238 RVA: 0x002F0570 File Offset: 0x002EE770
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

		// Token: 0x0600C43F RID: 50239 RVA: 0x002F05AC File Offset: 0x002EE7AC
		public int RoleImage(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170030DF RID: 12511
		// (get) Token: 0x0600C440 RID: 50240 RVA: 0x002F05EC File Offset: 0x002EE7EC
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

		// Token: 0x0600C441 RID: 50241 RVA: 0x002F0617 File Offset: 0x002EE817
		public Span<int> GetRoleImageBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x0600C442 RID: 50242 RVA: 0x002F0626 File Offset: 0x002EE826
		public int[] GetRoleImageArray()
		{
			return this.__p.__vector_as_array<int>(6) ?? Array.Empty<int>();
		}

		// Token: 0x0600C443 RID: 50243 RVA: 0x002F0640 File Offset: 0x002EE840
		public DicIntString? TabNames(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170030E0 RID: 12512
		// (get) Token: 0x0600C444 RID: 50244 RVA: 0x002F06A0 File Offset: 0x002EE8A0
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

		// Token: 0x0600C445 RID: 50245 RVA: 0x002F06CC File Offset: 0x002EE8CC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RoleImageIter()或GetRoleImageBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] RoleImage()
		{
			RogueResTaskTheme rogueResTaskTheme = this;
			return rogueResTaskTheme.GetRoleImageArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600C446 RID: 50246 RVA: 0x002F06F0 File Offset: 0x002EE8F0
		[NullableContext(1)]
		public readonly IEnumerable<int> RoleImageIter()
		{
			RogueResTaskTheme.<RoleImageIter>d__19 <RoleImageIter>d__ = new RogueResTaskTheme.<RoleImageIter>d__19(-2);
			<RoleImageIter>d__.<>3__<>4__this = this;
			return <RoleImageIter>d__;
		}

		// Token: 0x0600C447 RID: 50247 RVA: 0x002F0708 File Offset: 0x002EE908
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TabNamesFrozenDict()缓存字典，遍历请使用TabNamesIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> TabNames()
		{
			return this.TabNamesIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600C448 RID: 50248 RVA: 0x002F075E File Offset: 0x002EE95E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> TabNamesIter()
		{
			RogueResTaskTheme.<TabNamesIter>d__21 <TabNamesIter>d__ = new RogueResTaskTheme.<TabNamesIter>d__21(-2);
			<TabNamesIter>d__.<>3__<>4__this = this;
			return <TabNamesIter>d__;
		}

		// Token: 0x0600C449 RID: 50249 RVA: 0x002F0774 File Offset: 0x002EE974
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

		// Token: 0x0600C44A RID: 50250 RVA: 0x002F079C File Offset: 0x002EE99C
		private void EnsureTabNamesCacheIfNeeded()
		{
			if (this.TabNamesCache != null)
			{
				return;
			}
			this.TabNamesCache = this.TabNamesIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600C44B RID: 50251 RVA: 0x002F0802 File Offset: 0x002EEA02
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetTabNamesFrozenDict(int key)
		{
			this.EnsureTabNamesCacheIfNeeded();
			return this.TabNamesCache;
		}

		// Token: 0x04005106 RID: 20742
		private Table __p;

		// Token: 0x04005107 RID: 20743
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> TabNamesCache;
	}
}
