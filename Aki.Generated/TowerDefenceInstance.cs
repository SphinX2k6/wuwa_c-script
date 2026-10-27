using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001138 RID: 4408
	public struct TowerDefenceInstance : IFlatbufferObject
	{
		// Token: 0x17003ABD RID: 15037
		// (get) Token: 0x0600DFBC RID: 57276 RVA: 0x0032FDA5 File Offset: 0x0032DFA5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DFBD RID: 57277 RVA: 0x0032FDB2 File Offset: 0x0032DFB2
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DFBE RID: 57278 RVA: 0x0032FDBC File Offset: 0x0032DFBC
		public static TowerDefenceInstance GetRootAsTowerDefenceInstance(ByteBuffer _bb)
		{
			return TowerDefenceInstance.GetRootAsTowerDefenceInstance(_bb, default(TowerDefenceInstance));
		}

		// Token: 0x0600DFBF RID: 57279 RVA: 0x0032FDD8 File Offset: 0x0032DFD8
		public static TowerDefenceInstance GetRootAsTowerDefenceInstance(ByteBuffer _bb, TowerDefenceInstance obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DFC0 RID: 57280 RVA: 0x0032FDF5 File Offset: 0x0032DFF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DFC1 RID: 57281 RVA: 0x0032FE04 File Offset: 0x0032E004
		public TowerDefenceInstance __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003ABE RID: 15038
		// (get) Token: 0x0600DFC2 RID: 57282 RVA: 0x0032FE14 File Offset: 0x0032E014
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

		// Token: 0x17003ABF RID: 15039
		// (get) Token: 0x0600DFC3 RID: 57283 RVA: 0x0032FE50 File Offset: 0x0032E050
		public int InstanceId
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

		// Token: 0x17003AC0 RID: 15040
		// (get) Token: 0x0600DFC4 RID: 57284 RVA: 0x0032FE8C File Offset: 0x0032E08C
		public int ActivityId
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

		// Token: 0x17003AC1 RID: 15041
		// (get) Token: 0x0600DFC5 RID: 57285 RVA: 0x0032FEC8 File Offset: 0x0032E0C8
		public int GroupId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 999;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003AC2 RID: 15042
		// (get) Token: 0x0600DFC6 RID: 57286 RVA: 0x0032FF0C File Offset: 0x0032E10C
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003AC3 RID: 15043
		// (get) Token: 0x0600DFC7 RID: 57287 RVA: 0x0032FF4C File Offset: 0x0032E14C
		public bool BossRush
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003AC4 RID: 15044
		// (get) Token: 0x0600DFC8 RID: 57288 RVA: 0x0032FF8C File Offset: 0x0032E18C
		public int SortId
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

		// Token: 0x0600DFC9 RID: 57289 RVA: 0x0032FFCC File Offset: 0x0032E1CC
		public int OptionalBuff(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003AC5 RID: 15045
		// (get) Token: 0x0600DFCA RID: 57290 RVA: 0x0033000C File Offset: 0x0032E20C
		public int OptionalBuffLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600DFCB RID: 57291 RVA: 0x00330038 File Offset: 0x0032E238
		public Span<int> GetOptionalBuffBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600DFCC RID: 57292 RVA: 0x00330048 File Offset: 0x0032E248
		public int[] GetOptionalBuffArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x17003AC6 RID: 15046
		// (get) Token: 0x0600DFCD RID: 57293 RVA: 0x00330060 File Offset: 0x0032E260
		public int OpenDay
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

		// Token: 0x17003AC7 RID: 15047
		// (get) Token: 0x0600DFCE RID: 57294 RVA: 0x003300A0 File Offset: 0x0032E2A0
		public int Condition
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003AC8 RID: 15048
		// (get) Token: 0x0600DFCF RID: 57295 RVA: 0x003300E0 File Offset: 0x0032E2E0
		public int RewardId
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003AC9 RID: 15049
		// (get) Token: 0x0600DFD0 RID: 57296 RVA: 0x00330120 File Offset: 0x0032E320
		public int RewardScore
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ACA RID: 15050
		// (get) Token: 0x0600DFD1 RID: 57297 RVA: 0x00330160 File Offset: 0x0032E360
		public string LevelRewardDesc
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFD2 RID: 57298 RVA: 0x00330198 File Offset: 0x0032E398
		public Span<byte> GetLevelRewardDescBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600DFD3 RID: 57299 RVA: 0x003301A8 File Offset: 0x0032E3A8
		public byte[] GetLevelRewardDescArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x17003ACB RID: 15051
		// (get) Token: 0x0600DFD4 RID: 57300 RVA: 0x003301C0 File Offset: 0x0032E3C0
		public int BaseEntityId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ACC RID: 15052
		// (get) Token: 0x0600DFD5 RID: 57301 RVA: 0x00330200 File Offset: 0x0032E400
		public int UnlockScoreLimit
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003ACD RID: 15053
		// (get) Token: 0x0600DFD6 RID: 57302 RVA: 0x00330240 File Offset: 0x0032E440
		public bool IsDifficult
		{
			get
			{
				int num = this.__p.__offset(34);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17003ACE RID: 15054
		// (get) Token: 0x0600DFD7 RID: 57303 RVA: 0x00330280 File Offset: 0x0032E480
		public string BgPath
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DFD8 RID: 57304 RVA: 0x003302B8 File Offset: 0x0032E4B8
		public Span<byte> GetBgPathBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x003302C8 File Offset: 0x0032E4C8
		public byte[] GetBgPathArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DFDA RID: 57306 RVA: 0x003302E0 File Offset: 0x0032E4E0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用OptionalBuffIter()或GetOptionalBuffBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] OptionalBuff()
		{
			TowerDefenceInstance towerDefenceInstance = this;
			return towerDefenceInstance.GetOptionalBuffArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600DFDB RID: 57307 RVA: 0x00330304 File Offset: 0x0032E504
		[NullableContext(1)]
		public readonly IEnumerable<int> OptionalBuffIter()
		{
			TowerDefenceInstance.<OptionalBuffIter>d__50 <OptionalBuffIter>d__ = new TowerDefenceInstance.<OptionalBuffIter>d__50(-2);
			<OptionalBuffIter>d__.<>3__<>4__this = this;
			return <OptionalBuffIter>d__;
		}

		// Token: 0x04005279 RID: 21113
		private Table __p;
	}
}
