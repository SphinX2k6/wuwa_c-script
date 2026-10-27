using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200103D RID: 4157
	public struct RoleBreach : IFlatbufferObject
	{
		// Token: 0x1700320A RID: 12810
		// (get) Token: 0x0600C779 RID: 51065 RVA: 0x002F7FE1 File Offset: 0x002F61E1
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600C77A RID: 51066 RVA: 0x002F7FEE File Offset: 0x002F61EE
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600C77B RID: 51067 RVA: 0x002F7FF8 File Offset: 0x002F61F8
		public static RoleBreach GetRootAsRoleBreach(ByteBuffer _bb)
		{
			return RoleBreach.GetRootAsRoleBreach(_bb, default(RoleBreach));
		}

		// Token: 0x0600C77C RID: 51068 RVA: 0x002F8014 File Offset: 0x002F6214
		public static RoleBreach GetRootAsRoleBreach(ByteBuffer _bb, RoleBreach obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600C77D RID: 51069 RVA: 0x002F8031 File Offset: 0x002F6231
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600C77E RID: 51070 RVA: 0x002F8040 File Offset: 0x002F6240
		public RoleBreach __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700320B RID: 12811
		// (get) Token: 0x0600C77F RID: 51071 RVA: 0x002F8050 File Offset: 0x002F6250
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

		// Token: 0x1700320C RID: 12812
		// (get) Token: 0x0600C780 RID: 51072 RVA: 0x002F808C File Offset: 0x002F628C
		public int BreachGroupId
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

		// Token: 0x1700320D RID: 12813
		// (get) Token: 0x0600C781 RID: 51073 RVA: 0x002F80C8 File Offset: 0x002F62C8
		public int BreachLevel
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

		// Token: 0x1700320E RID: 12814
		// (get) Token: 0x0600C782 RID: 51074 RVA: 0x002F8104 File Offset: 0x002F6304
		public int MaxLevel
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C783 RID: 51075 RVA: 0x002F8144 File Offset: 0x002F6344
		public DicIntInt? BreachConsume(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700320F RID: 12815
		// (get) Token: 0x0600C784 RID: 51076 RVA: 0x002F81A8 File Offset: 0x002F63A8
		public int BreachConsumeLength
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

		// Token: 0x17003210 RID: 12816
		// (get) Token: 0x0600C785 RID: 51077 RVA: 0x002F81D4 File Offset: 0x002F63D4
		public int BreachReward
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

		// Token: 0x17003211 RID: 12817
		// (get) Token: 0x0600C786 RID: 51078 RVA: 0x002F8214 File Offset: 0x002F6414
		public int ConditionId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600C787 RID: 51079 RVA: 0x002F8254 File Offset: 0x002F6454
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BreachConsumeFrozenDict()缓存字典，遍历请使用BreachConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BreachConsume()
		{
			return this.BreachConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600C788 RID: 51080 RVA: 0x002F82AA File Offset: 0x002F64AA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BreachConsumeIter()
		{
			RoleBreach.<BreachConsumeIter>d__24 <BreachConsumeIter>d__ = new RoleBreach.<BreachConsumeIter>d__24(-2);
			<BreachConsumeIter>d__.<>3__<>4__this = this;
			return <BreachConsumeIter>d__;
		}

		// Token: 0x0600C789 RID: 51081 RVA: 0x002F82C0 File Offset: 0x002F64C0
		public int? GetBreachConsume(int key)
		{
			this.EnsureBreachConsumeCacheIfNeeded();
			int value;
			if (!this.BreachConsumeCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600C78A RID: 51082 RVA: 0x002F82F4 File Offset: 0x002F64F4
		private void EnsureBreachConsumeCacheIfNeeded()
		{
			if (this.BreachConsumeCache != null)
			{
				return;
			}
			this.BreachConsumeCache = this.BreachConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600C78B RID: 51083 RVA: 0x002F835A File Offset: 0x002F655A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBreachConsumeFrozenDict(int key)
		{
			this.EnsureBreachConsumeCacheIfNeeded();
			return this.BreachConsumeCache;
		}

		// Token: 0x0400513A RID: 20794
		private Table __p;

		// Token: 0x0400513B RID: 20795
		[Nullable(2)]
		private FrozenDictionary<int, int> BreachConsumeCache;
	}
}
