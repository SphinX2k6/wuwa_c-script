using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010C3 RID: 4291
	public struct SkillLevel : IFlatbufferObject
	{
		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600D542 RID: 54594 RVA: 0x00317BF9 File Offset: 0x00315DF9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D543 RID: 54595 RVA: 0x00317C06 File Offset: 0x00315E06
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D544 RID: 54596 RVA: 0x00317C10 File Offset: 0x00315E10
		public static SkillLevel GetRootAsSkillLevel(ByteBuffer _bb)
		{
			return SkillLevel.GetRootAsSkillLevel(_bb, default(SkillLevel));
		}

		// Token: 0x0600D545 RID: 54597 RVA: 0x00317C2C File Offset: 0x00315E2C
		public static SkillLevel GetRootAsSkillLevel(ByteBuffer _bb, SkillLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D546 RID: 54598 RVA: 0x00317C49 File Offset: 0x00315E49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D547 RID: 54599 RVA: 0x00317C58 File Offset: 0x00315E58
		public SkillLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0600D548 RID: 54600 RVA: 0x00317C68 File Offset: 0x00315E68
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

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600D549 RID: 54601 RVA: 0x00317CA4 File Offset: 0x00315EA4
		public int SkillLevelGroupId
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

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600D54A RID: 54602 RVA: 0x00317CE0 File Offset: 0x00315EE0
		public int SkillId
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

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0600D54B RID: 54603 RVA: 0x00317D1C File Offset: 0x00315F1C
		public string LevelNewDescribe
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

		// Token: 0x0600D54C RID: 54604 RVA: 0x00317D54 File Offset: 0x00315F54
		public Span<byte> GetLevelNewDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D54D RID: 54605 RVA: 0x00317D64 File Offset: 0x00315F64
		public byte[] GetLevelNewDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D54E RID: 54606 RVA: 0x00317D7C File Offset: 0x00315F7C
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600D54F RID: 54607 RVA: 0x00317DE0 File Offset: 0x00315FE0
		public int ConsumeLength
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

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600D550 RID: 54608 RVA: 0x00317E0C File Offset: 0x0031600C
		public int Condition
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

		// Token: 0x0600D551 RID: 54609 RVA: 0x00317E4C File Offset: 0x0031604C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConsumeFrozenDict()缓存字典，遍历请使用ConsumeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D552 RID: 54610 RVA: 0x00317EA2 File Offset: 0x003160A2
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConsumeIter()
		{
			SkillLevel.<ConsumeIter>d__24 <ConsumeIter>d__ = new SkillLevel.<ConsumeIter>d__24(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600D553 RID: 54611 RVA: 0x00317EB8 File Offset: 0x003160B8
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

		// Token: 0x0600D554 RID: 54612 RVA: 0x00317EEC File Offset: 0x003160EC
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D555 RID: 54613 RVA: 0x00317F52 File Offset: 0x00316152
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict(int key)
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x040051EC RID: 20972
		private Table __p;

		// Token: 0x040051ED RID: 20973
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
