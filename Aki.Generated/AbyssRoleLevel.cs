using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B8A RID: 2954
	public struct AbyssRoleLevel : IFlatbufferObject
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060046CF RID: 18127 RVA: 0x001E79B1 File Offset: 0x001E5BB1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060046D0 RID: 18128 RVA: 0x001E79BE File Offset: 0x001E5BBE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060046D1 RID: 18129 RVA: 0x001E79C8 File Offset: 0x001E5BC8
		public static AbyssRoleLevel GetRootAsAbyssRoleLevel(ByteBuffer _bb)
		{
			return AbyssRoleLevel.GetRootAsAbyssRoleLevel(_bb, default(AbyssRoleLevel));
		}

		// Token: 0x060046D2 RID: 18130 RVA: 0x001E79E4 File Offset: 0x001E5BE4
		public static AbyssRoleLevel GetRootAsAbyssRoleLevel(ByteBuffer _bb, AbyssRoleLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060046D3 RID: 18131 RVA: 0x001E7A01 File Offset: 0x001E5C01
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060046D4 RID: 18132 RVA: 0x001E7A10 File Offset: 0x001E5C10
		public AbyssRoleLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060046D5 RID: 18133 RVA: 0x001E7A20 File Offset: 0x001E5C20
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
		// (get) Token: 0x060046D6 RID: 18134 RVA: 0x001E7A5C File Offset: 0x001E5C5C
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
		// (get) Token: 0x060046D7 RID: 18135 RVA: 0x001E7A98 File Offset: 0x001E5C98
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

		// Token: 0x060046D8 RID: 18136 RVA: 0x001E7AD4 File Offset: 0x001E5CD4
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
		// (get) Token: 0x060046D9 RID: 18137 RVA: 0x001E7B38 File Offset: 0x001E5D38
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

		// Token: 0x060046DA RID: 18138 RVA: 0x001E7B64 File Offset: 0x001E5D64
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
		// (get) Token: 0x060046DB RID: 18139 RVA: 0x001E7BC8 File Offset: 0x001E5DC8
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
		// (get) Token: 0x060046DC RID: 18140 RVA: 0x001E7BF4 File Offset: 0x001E5DF4
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

		// Token: 0x060046DD RID: 18141 RVA: 0x001E7C34 File Offset: 0x001E5E34
		[NullableContext(1)]
		public Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x001E7C8A File Offset: 0x001E5E8A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeIter()
		{
			AbyssRoleLevel.<ConsumeIter>d__23 <ConsumeIter>d__ = new AbyssRoleLevel.<ConsumeIter>d__23(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x001E7C9F File Offset: 0x001E5E9F
		[NullableContext(1)]
		public ConfigPropValue[] Prop()
		{
			return this.PropIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x001E7CAC File Offset: 0x001E5EAC
		[NullableContext(1)]
		public IEnumerable<ConfigPropValue> PropIter()
		{
			AbyssRoleLevel.<PropIter>d__25 <PropIter>d__ = new AbyssRoleLevel.<PropIter>d__25(-2);
			<PropIter>d__.<>3__<>4__this = this;
			return <PropIter>d__;
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x001E7CC4 File Offset: 0x001E5EC4
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

		// Token: 0x060046E2 RID: 18146 RVA: 0x001E7CF8 File Offset: 0x001E5EF8
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x001E7D5E File Offset: 0x001E5F5E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict()
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x0400505E RID: 20574
		private Table __p;

		// Token: 0x0400505F RID: 20575
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
