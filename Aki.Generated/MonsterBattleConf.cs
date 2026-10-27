using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E0E RID: 3598
	public struct MonsterBattleConf : IFlatbufferObject
	{
		// Token: 0x17001F2C RID: 7980
		// (get) Token: 0x06009470 RID: 38000 RVA: 0x00286374 File Offset: 0x00284574
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009471 RID: 38001 RVA: 0x00286381 File Offset: 0x00284581
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009472 RID: 38002 RVA: 0x00286388 File Offset: 0x00284588
		public static MonsterBattleConf GetRootAsMonsterBattleConf(ByteBuffer _bb)
		{
			return MonsterBattleConf.GetRootAsMonsterBattleConf(_bb, default(MonsterBattleConf));
		}

		// Token: 0x06009473 RID: 38003 RVA: 0x002863A4 File Offset: 0x002845A4
		public static MonsterBattleConf GetRootAsMonsterBattleConf(ByteBuffer _bb, MonsterBattleConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009474 RID: 38004 RVA: 0x002863C1 File Offset: 0x002845C1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009475 RID: 38005 RVA: 0x002863D0 File Offset: 0x002845D0
		public MonsterBattleConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001F2D RID: 7981
		// (get) Token: 0x06009476 RID: 38006 RVA: 0x002863E0 File Offset: 0x002845E0
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

		// Token: 0x17001F2E RID: 7982
		// (get) Token: 0x06009477 RID: 38007 RVA: 0x0028641C File Offset: 0x0028461C
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

		// Token: 0x06009478 RID: 38008 RVA: 0x00286458 File Offset: 0x00284658
		public int ExecutionId(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001F2F RID: 7983
		// (get) Token: 0x06009479 RID: 38009 RVA: 0x00286498 File Offset: 0x00284698
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

		// Token: 0x0600947A RID: 38010 RVA: 0x002864C3 File Offset: 0x002846C3
		public Span<int> GetExecutionIdBytes()
		{
			return this.__p.__vector_as_span<int>(8, 4);
		}

		// Token: 0x0600947B RID: 38011 RVA: 0x002864D2 File Offset: 0x002846D2
		public int[] GetExecutionIdArray()
		{
			return this.__p.__vector_as_array<int>(8) ?? Array.Empty<int>();
		}

		// Token: 0x17001F30 RID: 7984
		// (get) Token: 0x0600947C RID: 38012 RVA: 0x002864EC File Offset: 0x002846EC
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

		// Token: 0x17001F31 RID: 7985
		// (get) Token: 0x0600947D RID: 38013 RVA: 0x00286530 File Offset: 0x00284730
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

		// Token: 0x17001F32 RID: 7986
		// (get) Token: 0x0600947E RID: 38014 RVA: 0x00286574 File Offset: 0x00284774
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

		// Token: 0x17001F33 RID: 7987
		// (get) Token: 0x0600947F RID: 38015 RVA: 0x002865B4 File Offset: 0x002847B4
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

		// Token: 0x17001F34 RID: 7988
		// (get) Token: 0x06009480 RID: 38016 RVA: 0x002865F4 File Offset: 0x002847F4
		public bool FixedLocation
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17001F35 RID: 7989
		// (get) Token: 0x06009481 RID: 38017 RVA: 0x00286634 File Offset: 0x00284834
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

		// Token: 0x06009482 RID: 38018 RVA: 0x00286674 File Offset: 0x00284874
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ExecutionIdIter()或GetExecutionIdBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ExecutionId()
		{
			MonsterBattleConf monsterBattleConf = this;
			return monsterBattleConf.GetExecutionIdArray() ?? Array.Empty<int>();
		}

		// Token: 0x06009483 RID: 38019 RVA: 0x00286698 File Offset: 0x00284898
		[NullableContext(1)]
		public readonly IEnumerable<int> ExecutionIdIter()
		{
			MonsterBattleConf.<ExecutionIdIter>d__30 <ExecutionIdIter>d__ = new MonsterBattleConf.<ExecutionIdIter>d__30(-2);
			<ExecutionIdIter>d__.<>3__<>4__this = this;
			return <ExecutionIdIter>d__;
		}

		// Token: 0x04004EB3 RID: 20147
		private Table __p;
	}
}
