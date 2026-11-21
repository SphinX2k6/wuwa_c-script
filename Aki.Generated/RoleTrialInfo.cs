using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200115F RID: 4447
	public struct RoleTrialInfo : IFlatbufferObject
	{
		// Token: 0x17003490 RID: 13456
		// (get) Token: 0x0600D359 RID: 54105 RVA: 0x0032092E File Offset: 0x0031EB2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D35A RID: 54106 RVA: 0x0032093B File Offset: 0x0031EB3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D35B RID: 54107 RVA: 0x00320944 File Offset: 0x0031EB44
		public static RoleTrialInfo GetRootAsRoleTrialInfo(ByteBuffer _bb)
		{
			return RoleTrialInfo.GetRootAsRoleTrialInfo(_bb, default(RoleTrialInfo));
		}

		// Token: 0x0600D35C RID: 54108 RVA: 0x00320960 File Offset: 0x0031EB60
		public static RoleTrialInfo GetRootAsRoleTrialInfo(ByteBuffer _bb, RoleTrialInfo obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D35D RID: 54109 RVA: 0x0032097D File Offset: 0x0031EB7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D35E RID: 54110 RVA: 0x0032098C File Offset: 0x0031EB8C
		public RoleTrialInfo __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17003491 RID: 13457
		// (get) Token: 0x0600D35F RID: 54111 RVA: 0x0032099C File Offset: 0x0031EB9C
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

		// Token: 0x17003492 RID: 13458
		// (get) Token: 0x0600D360 RID: 54112 RVA: 0x003209D8 File Offset: 0x0031EBD8
		public int RoleId
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

		// Token: 0x17003493 RID: 13459
		// (get) Token: 0x0600D361 RID: 54113 RVA: 0x00320A14 File Offset: 0x0031EC14
		public int TrialRoleId
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

		// Token: 0x17003494 RID: 13460
		// (get) Token: 0x0600D362 RID: 54114 RVA: 0x00320A50 File Offset: 0x0031EC50
		public string InstanceText
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

		// Token: 0x0600D363 RID: 54115 RVA: 0x00320A88 File Offset: 0x0031EC88
		public Span<byte> GetInstanceTextBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600D364 RID: 54116 RVA: 0x00320A98 File Offset: 0x0031EC98
		public byte[] GetInstanceTextArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17003495 RID: 13461
		// (get) Token: 0x0600D365 RID: 54117 RVA: 0x00320AB0 File Offset: 0x0031ECB0
		public int InstanceId
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

		// Token: 0x0600D366 RID: 54118 RVA: 0x00320AF0 File Offset: 0x0031ECF0
		public DicIntInt? RewardItem(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003496 RID: 13462
		// (get) Token: 0x0600D367 RID: 54119 RVA: 0x00320B54 File Offset: 0x0031ED54
		public int RewardItemLength
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003497 RID: 13463
		// (get) Token: 0x0600D368 RID: 54120 RVA: 0x00320B80 File Offset: 0x0031ED80
		public int GachaId
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

		// Token: 0x0600D369 RID: 54121 RVA: 0x00320BC0 File Offset: 0x0031EDC0
		[NullableContext(1)]
		public Dictionary<int, int> RewardItem()
		{
			return this.RewardItemIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D36A RID: 54122 RVA: 0x00320C16 File Offset: 0x0031EE16
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardItemIter()
		{
			RoleTrialInfo.<RewardItemIter>d__26 <RewardItemIter>d__ = new RoleTrialInfo.<RewardItemIter>d__26(-2);
			<RewardItemIter>d__.<>3__<>4__this = this;
			return <RewardItemIter>d__;
		}

		// Token: 0x0600D36B RID: 54123 RVA: 0x00320C2C File Offset: 0x0031EE2C
		public int? GetRewardItem(int key)
		{
			this.EnsureRewardItemCacheIfNeeded();
			int value;
			if (!this.RewardItemCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D36C RID: 54124 RVA: 0x00320C60 File Offset: 0x0031EE60
		private void EnsureRewardItemCacheIfNeeded()
		{
			if (this.RewardItemCache != null)
			{
				return;
			}
			this.RewardItemCache = this.RewardItemIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D36D RID: 54125 RVA: 0x00320CC6 File Offset: 0x0031EEC6
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardItemFrozenDict()
		{
			this.EnsureRewardItemCacheIfNeeded();
			return this.RewardItemCache;
		}

		// Token: 0x04005767 RID: 22375
		private Table __p;

		// Token: 0x04005768 RID: 22376
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardItemCache;
	}
}
