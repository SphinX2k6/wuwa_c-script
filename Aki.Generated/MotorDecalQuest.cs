using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F18 RID: 3864
	public struct MotorDecalQuest : IFlatbufferObject
	{
		// Token: 0x17002095 RID: 8341
		// (get) Token: 0x06009D25 RID: 40229 RVA: 0x002A9739 File Offset: 0x002A7939
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06009D26 RID: 40230 RVA: 0x002A9746 File Offset: 0x002A7946
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06009D27 RID: 40231 RVA: 0x002A9750 File Offset: 0x002A7950
		public static MotorDecalQuest GetRootAsMotorDecalQuest(ByteBuffer _bb)
		{
			return MotorDecalQuest.GetRootAsMotorDecalQuest(_bb, default(MotorDecalQuest));
		}

		// Token: 0x06009D28 RID: 40232 RVA: 0x002A976C File Offset: 0x002A796C
		public static MotorDecalQuest GetRootAsMotorDecalQuest(ByteBuffer _bb, MotorDecalQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06009D29 RID: 40233 RVA: 0x002A9789 File Offset: 0x002A7989
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06009D2A RID: 40234 RVA: 0x002A9798 File Offset: 0x002A7998
		public MotorDecalQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002096 RID: 8342
		// (get) Token: 0x06009D2B RID: 40235 RVA: 0x002A97A8 File Offset: 0x002A79A8
		public int TaskId
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

		// Token: 0x17002097 RID: 8343
		// (get) Token: 0x06009D2C RID: 40236 RVA: 0x002A97E4 File Offset: 0x002A79E4
		public int Ip
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

		// Token: 0x17002098 RID: 8344
		// (get) Token: 0x06009D2D RID: 40237 RVA: 0x002A9820 File Offset: 0x002A7A20
		public int Sort
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

		// Token: 0x17002099 RID: 8345
		// (get) Token: 0x06009D2E RID: 40238 RVA: 0x002A985C File Offset: 0x002A7A5C
		public string TaskName
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

		// Token: 0x06009D2F RID: 40239 RVA: 0x002A9894 File Offset: 0x002A7A94
		public Span<byte> GetTaskNameBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06009D30 RID: 40240 RVA: 0x002A98A4 File Offset: 0x002A7AA4
		public byte[] GetTaskNameArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x1700209A RID: 8346
		// (get) Token: 0x06009D31 RID: 40241 RVA: 0x002A98BC File Offset: 0x002A7ABC
		public int AccessId
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

		// Token: 0x06009D32 RID: 40242 RVA: 0x002A98FC File Offset: 0x002A7AFC
		public DicIntInt? RewardInfo(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700209B RID: 8347
		// (get) Token: 0x06009D33 RID: 40243 RVA: 0x002A9960 File Offset: 0x002A7B60
		public int RewardInfoLength
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

		// Token: 0x06009D34 RID: 40244 RVA: 0x002A998C File Offset: 0x002A7B8C
		[NullableContext(1)]
		public Dictionary<int, int> RewardInfo()
		{
			return this.RewardInfoIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06009D35 RID: 40245 RVA: 0x002A99E2 File Offset: 0x002A7BE2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> RewardInfoIter()
		{
			MotorDecalQuest.<RewardInfoIter>d__24 <RewardInfoIter>d__ = new MotorDecalQuest.<RewardInfoIter>d__24(-2);
			<RewardInfoIter>d__.<>3__<>4__this = this;
			return <RewardInfoIter>d__;
		}

		// Token: 0x06009D36 RID: 40246 RVA: 0x002A99F8 File Offset: 0x002A7BF8
		public int? GetRewardInfo(int key)
		{
			this.EnsureRewardInfoCacheIfNeeded();
			int value;
			if (!this.RewardInfoCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06009D37 RID: 40247 RVA: 0x002A9A2C File Offset: 0x002A7C2C
		private void EnsureRewardInfoCacheIfNeeded()
		{
			if (this.RewardInfoCache != null)
			{
				return;
			}
			this.RewardInfoCache = this.RewardInfoIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06009D38 RID: 40248 RVA: 0x002A9A92 File Offset: 0x002A7C92
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetRewardInfoFrozenDict()
		{
			this.EnsureRewardInfoCacheIfNeeded();
			return this.RewardInfoCache;
		}

		// Token: 0x040054BD RID: 21693
		private Table __p;

		// Token: 0x040054BE RID: 21694
		[Nullable(2)]
		private FrozenDictionary<int, int> RewardInfoCache;
	}
}
