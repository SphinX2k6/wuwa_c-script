using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AB5 RID: 2741
	public struct AbyssRoleLevel : IFlatbufferObject
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060041D1 RID: 16849 RVA: 0x001C8751 File Offset: 0x001C6951
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060041D2 RID: 16850 RVA: 0x001C875E File Offset: 0x001C695E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060041D3 RID: 16851 RVA: 0x001C8768 File Offset: 0x001C6968
		public static AbyssRoleLevel GetRootAsAbyssRoleLevel(ByteBuffer _bb)
		{
			return AbyssRoleLevel.GetRootAsAbyssRoleLevel(_bb, default(AbyssRoleLevel));
		}

		// Token: 0x060041D4 RID: 16852 RVA: 0x001C8784 File Offset: 0x001C6984
		public static AbyssRoleLevel GetRootAsAbyssRoleLevel(ByteBuffer _bb, AbyssRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060041D5 RID: 16853 RVA: 0x001C87A1 File Offset: 0x001C69A1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060041D6 RID: 16854 RVA: 0x001C87B0 File Offset: 0x001C69B0
		public AbyssRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060041D7 RID: 16855 RVA: 0x001C87C0 File Offset: 0x001C69C0
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

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060041D8 RID: 16856 RVA: 0x001C87FC File Offset: 0x001C69FC
		public int Level
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

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060041D9 RID: 16857 RVA: 0x001C8838 File Offset: 0x001C6A38
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060041DA RID: 16858 RVA: 0x001C8874 File Offset: 0x001C6A74
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060041DB RID: 16859 RVA: 0x001C88D8 File Offset: 0x001C6AD8
		public int ConsumeLength
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

		// Token: 0x060041DC RID: 16860 RVA: 0x001C8904 File Offset: 0x001C6B04
		public ConfigPropValue? Prop(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060041DD RID: 16861 RVA: 0x001C8968 File Offset: 0x001C6B68
		public int PropLength
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

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060041DE RID: 16862 RVA: 0x001C8994 File Offset: 0x001C6B94
		public int PluginNum
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060041DF RID: 16863 RVA: 0x001C89D4 File Offset: 0x001C6BD4
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeFrozenDict()缓存字典，遍历请使用ConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060041E0 RID: 16864 RVA: 0x001C8A2A File Offset: 0x001C6C2A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeIter()
		{
			AbyssRoleLevel.<ConsumeIter>d__23 <ConsumeIter>d__ = new AbyssRoleLevel.<ConsumeIter>d__23(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x060041E1 RID: 16865 RVA: 0x001C8A3F File Offset: 0x001C6C3F
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropIter()或GetPropBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ConfigPropValue[] Prop()
		{
			return this.PropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x060041E2 RID: 16866 RVA: 0x001C8A4C File Offset: 0x001C6C4C
		[NullableContext(1)]
		public readonly IEnumerable<ConfigPropValue> PropIter()
		{
			AbyssRoleLevel.<PropIter>d__25 <PropIter>d__ = new AbyssRoleLevel.<PropIter>d__25(-2);
			<PropIter>d__.<>3__<>4__this = this;
			return <PropIter>d__;
		}

		// Token: 0x060041E3 RID: 16867 RVA: 0x001C8A64 File Offset: 0x001C6C64
		public int? GetConsume(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			int value;
			if (!this.ConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060041E4 RID: 16868 RVA: 0x001C8A98 File Offset: 0x001C6C98
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060041E5 RID: 16869 RVA: 0x001C8AFE File Offset: 0x001C6CFE
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x04004A8B RID: 19083
		private Table __p;

		// Token: 0x04004A8C RID: 19084
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
