using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000EF3 RID: 3827
	public struct MonsterBattleConf : IFlatbufferObject
	{
		// Token: 0x17001F91 RID: 8081
		// (get) Token: 0x06009A90 RID: 39568 RVA: 0x002A4178 File Offset: 0x002A2378
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009A91 RID: 39569 RVA: 0x002A4185 File Offset: 0x002A2385
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009A92 RID: 39570 RVA: 0x002A418C File Offset: 0x002A238C
		public static MonsterBattleConf GetRootAsMonsterBattleConf(ByteBuffer _bb)
		{
			return MonsterBattleConf.GetRootAsMonsterBattleConf(_bb, default(MonsterBattleConf));
		}

		// Token: 0x06009A93 RID: 39571 RVA: 0x002A41A8 File Offset: 0x002A23A8
		public static MonsterBattleConf GetRootAsMonsterBattleConf(ByteBuffer _bb, MonsterBattleConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009A94 RID: 39572 RVA: 0x002A41C5 File Offset: 0x002A23C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009A95 RID: 39573 RVA: 0x002A41D4 File Offset: 0x002A23D4
		public MonsterBattleConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F92 RID: 8082
		// (get) Token: 0x06009A96 RID: 39574 RVA: 0x002A41E4 File Offset: 0x002A23E4
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

		// Token: 0x17001F93 RID: 8083
		// (get) Token: 0x06009A97 RID: 39575 RVA: 0x002A4220 File Offset: 0x002A2420
		public int RoleMappingId
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

		// Token: 0x06009A98 RID: 39576 RVA: 0x002A425C File Offset: 0x002A245C
		public int ExecutionId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F94 RID: 8084
		// (get) Token: 0x06009A99 RID: 39577 RVA: 0x002A429C File Offset: 0x002A249C
		public int ExecutionIdLength
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

		// Token: 0x06009A9A RID: 39578 RVA: 0x002A42C7 File Offset: 0x002A24C7
		public Span<int> GetExecutionIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x06009A9B RID: 39579 RVA: 0x002A42D6 File Offset: 0x002A24D6
		public int[] GetExecutionIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001F95 RID: 8085
		// (get) Token: 0x06009A9C RID: 39580 RVA: 0x002A42F0 File Offset: 0x002A24F0
		public float ExecutionRadius
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 3f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F96 RID: 8086
		// (get) Token: 0x06009A9D RID: 39581 RVA: 0x002A4334 File Offset: 0x002A2534
		public float ForceLockOnCoefficient
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F97 RID: 8087
		// (get) Token: 0x06009A9E RID: 39582 RVA: 0x002A4378 File Offset: 0x002A2578
		public int MonsterSizeId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001F98 RID: 8088
		// (get) Token: 0x06009A9F RID: 39583 RVA: 0x002A43B8 File Offset: 0x002A25B8
		public int MonsterPerformanceId
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

		// Token: 0x17001F99 RID: 8089
		// (get) Token: 0x06009AA0 RID: 39584 RVA: 0x002A43F8 File Offset: 0x002A25F8
		public bool FixedLocation
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F9A RID: 8090
		// (get) Token: 0x06009AA1 RID: 39585 RVA: 0x002A4438 File Offset: 0x002A2638
		public int WeaknessExploitWeapon
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06009AA2 RID: 39586 RVA: 0x002A4475 File Offset: 0x002A2675
		[NullableContext(1)]
		public int[] ExecutionId()
		{
			return this.GetExecutionIdArray();
		}

		// Token: 0x06009AA3 RID: 39587 RVA: 0x002A447D File Offset: 0x002A267D
		[NullableContext(1)]
		public IEnumerable<int> ExecutionIdIter()
		{
			MonsterBattleConf.<ExecutionIdIter>d__30 <ExecutionIdIter>d__ = new MonsterBattleConf.<ExecutionIdIter>d__30(-2);
			<ExecutionIdIter>d__.<>3__<>4__this = this;
			return <ExecutionIdIter>d__;
		}

		// Token: 0x04005498 RID: 21656
		private Table __p;
	}
}
