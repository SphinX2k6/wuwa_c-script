using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BE RID: 4542
	public struct SkillLevel : IFlatbufferObject
	{
		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0600DD1F RID: 56607 RVA: 0x00336D7D File Offset: 0x00334F7D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DD20 RID: 56608 RVA: 0x00336D8A File Offset: 0x00334F8A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DD21 RID: 56609 RVA: 0x00336D94 File Offset: 0x00334F94
		public static SkillLevel GetRootAsSkillLevel(ByteBuffer _bb)
		{
			return SkillLevel.GetRootAsSkillLevel(_bb, default(SkillLevel));
		}

		// Token: 0x0600DD22 RID: 56610 RVA: 0x00336DB0 File Offset: 0x00334FB0
		public static SkillLevel GetRootAsSkillLevel(ByteBuffer _bb, SkillLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DD23 RID: 56611 RVA: 0x00336DCD File Offset: 0x00334FCD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DD24 RID: 56612 RVA: 0x00336DDC File Offset: 0x00334FDC
		public SkillLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0600DD25 RID: 56613 RVA: 0x00336DEC File Offset: 0x00334FEC
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

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600DD26 RID: 56614 RVA: 0x00336E28 File Offset: 0x00335028
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

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x0600DD27 RID: 56615 RVA: 0x00336E64 File Offset: 0x00335064
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

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x0600DD28 RID: 56616 RVA: 0x00336EA0 File Offset: 0x003350A0
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

		// Token: 0x0600DD29 RID: 56617 RVA: 0x00336ED8 File Offset: 0x003350D8
		public Span<byte> GetLevelNewDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600DD2A RID: 56618 RVA: 0x00336EE8 File Offset: 0x003350E8
		public byte[] GetLevelNewDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DD2B RID: 56619 RVA: 0x00336F00 File Offset: 0x00335100
		public DicIntInt? Consume(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x0600DD2C RID: 56620 RVA: 0x00336F64 File Offset: 0x00335164
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

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x0600DD2D RID: 56621 RVA: 0x00336F90 File Offset: 0x00335190
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

		// Token: 0x0600DD2E RID: 56622 RVA: 0x00336FD0 File Offset: 0x003351D0
		[NullableContext(1)]
		public Dictionary<int, int> Consume()
		{
			return this.ConsumeIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DD2F RID: 56623 RVA: 0x00337026 File Offset: 0x00335226
		[NullableContext(1)]
		public IEnumerable<DicIntInt> ConsumeIter()
		{
			SkillLevel.<ConsumeIter>d__24 <ConsumeIter>d__ = new SkillLevel.<ConsumeIter>d__24(-2);
			<ConsumeIter>d__.<>3__<>4__this = this;
			return <ConsumeIter>d__;
		}

		// Token: 0x0600DD30 RID: 56624 RVA: 0x0033703C File Offset: 0x0033523C
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

		// Token: 0x0600DD31 RID: 56625 RVA: 0x00337070 File Offset: 0x00335270
		private void EnsureConsumeCacheIfNeeded()
		{
			if (this.ConsumeCache != null)
			{
				return;
			}
			this.ConsumeCache = this.ConsumeIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DD32 RID: 56626 RVA: 0x003370D6 File Offset: 0x003352D6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetConsumeFrozenDict()
		{
			this.EnsureConsumeCacheIfNeeded();
			return this.ConsumeCache;
		}

		// Token: 0x040057EB RID: 22507
		private Table __p;

		// Token: 0x040057EC RID: 22508
		[Nullable(2)]
		private FrozenDictionary<int, int> ConsumeCache;
	}
}
