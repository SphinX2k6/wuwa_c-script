using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C0C RID: 3084
	public struct BattlePassUnlockPop : IFlatbufferObject
	{
		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06005276 RID: 21110 RVA: 0x00202890 File Offset: 0x00200A90
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005277 RID: 21111 RVA: 0x0020289D File Offset: 0x00200A9D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005278 RID: 21112 RVA: 0x002028A4 File Offset: 0x00200AA4
		public static BattlePassUnlockPop GetRootAsBattlePassUnlockPop(ByteBuffer _bb)
		{
			return BattlePassUnlockPop.GetRootAsBattlePassUnlockPop(_bb, default(BattlePassUnlockPop));
		}

		// Token: 0x06005279 RID: 21113 RVA: 0x002028C0 File Offset: 0x00200AC0
		public static BattlePassUnlockPop GetRootAsBattlePassUnlockPop(ByteBuffer _bb, BattlePassUnlockPop obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600527A RID: 21114 RVA: 0x002028DD File Offset: 0x00200ADD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600527B RID: 21115 RVA: 0x002028EC File Offset: 0x00200AEC
		public BattlePassUnlockPop __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x0600527C RID: 21116 RVA: 0x002028FC File Offset: 0x00200AFC
		public int TpyeID
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

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x0600527D RID: 21117 RVA: 0x00202938 File Offset: 0x00200B38
		public string UnlockTitle
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600527E RID: 21118 RVA: 0x0020296F File Offset: 0x00200B6F
		public Span<byte> GetUnlockTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600527F RID: 21119 RVA: 0x0020297E File Offset: 0x00200B7E
		public byte[] GetUnlockTitleArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06005280 RID: 21120 RVA: 0x00202998 File Offset: 0x00200B98
		public string UnlockText
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06005281 RID: 21121 RVA: 0x002029CF File Offset: 0x00200BCF
		public Span<byte> GetUnlockTextBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06005282 RID: 21122 RVA: 0x002029DE File Offset: 0x00200BDE
		public byte[] GetUnlockTextArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x06005283 RID: 21123 RVA: 0x002029F8 File Offset: 0x00200BF8
		public DicIntInt? UnlockReward(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06005284 RID: 21124 RVA: 0x00202A5C File Offset: 0x00200C5C
		public int UnlockRewardLength
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

		// Token: 0x06005285 RID: 21125 RVA: 0x00202A88 File Offset: 0x00200C88
		[NullableContext(1)]
		public Dictionary<int, int> UnlockReward()
		{
			return this.UnlockRewardIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06005286 RID: 21126 RVA: 0x00202ADE File Offset: 0x00200CDE
		[NullableContext(1)]
		public IEnumerable<DicIntInt> UnlockRewardIter()
		{
			BattlePassUnlockPop.<UnlockRewardIter>d__22 <UnlockRewardIter>d__ = new BattlePassUnlockPop.<UnlockRewardIter>d__22(-2);
			<UnlockRewardIter>d__.<>3__<>4__this = this;
			return <UnlockRewardIter>d__;
		}

		// Token: 0x06005287 RID: 21127 RVA: 0x00202AF4 File Offset: 0x00200CF4
		public int? GetUnlockReward(int key)
		{
			this.EnsureUnlockRewardCacheIfNeeded();
			int value;
			if (!this.UnlockRewardCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06005288 RID: 21128 RVA: 0x00202B28 File Offset: 0x00200D28
		private void EnsureUnlockRewardCacheIfNeeded()
		{
			if (this.UnlockRewardCache != null)
			{
				return;
			}
			this.UnlockRewardCache = this.UnlockRewardIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06005289 RID: 21129 RVA: 0x00202B8E File Offset: 0x00200D8E
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetUnlockRewardFrozenDict()
		{
			this.EnsureUnlockRewardCacheIfNeeded();
			return this.UnlockRewardCache;
		}

		// Token: 0x04005103 RID: 20739
		private Table __p;

		// Token: 0x04005104 RID: 20740
		[Nullable(2)]
		private FrozenDictionary<int, int> UnlockRewardCache;
	}
}
