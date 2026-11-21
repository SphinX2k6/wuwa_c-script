using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7A RID: 3706
	public struct KurotatoActivityConfig : IFlatbufferObject
	{
		// Token: 0x17001B70 RID: 7024
		// (get) Token: 0x06008E94 RID: 36500 RVA: 0x0028A210 File Offset: 0x00288410
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008E95 RID: 36501 RVA: 0x0028A21D File Offset: 0x0028841D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008E96 RID: 36502 RVA: 0x0028A224 File Offset: 0x00288424
		public static KurotatoActivityConfig GetRootAsKurotatoActivityConfig(ByteBuffer _bb)
		{
			return KurotatoActivityConfig.GetRootAsKurotatoActivityConfig(_bb, default(KurotatoActivityConfig));
		}

		// Token: 0x06008E97 RID: 36503 RVA: 0x0028A240 File Offset: 0x00288440
		public static KurotatoActivityConfig GetRootAsKurotatoActivityConfig(ByteBuffer _bb, KurotatoActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008E98 RID: 36504 RVA: 0x0028A25D File Offset: 0x0028845D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008E99 RID: 36505 RVA: 0x0028A26C File Offset: 0x0028846C
		public KurotatoActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B71 RID: 7025
		// (get) Token: 0x06008E9A RID: 36506 RVA: 0x0028A27C File Offset: 0x0028847C
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

		// Token: 0x17001B72 RID: 7026
		// (get) Token: 0x06008E9B RID: 36507 RVA: 0x0028A2B8 File Offset: 0x002884B8
		public int ActivityId
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

		// Token: 0x17001B73 RID: 7027
		// (get) Token: 0x06008E9C RID: 36508 RVA: 0x0028A2F4 File Offset: 0x002884F4
		public int ScoreItem
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

		// Token: 0x17001B74 RID: 7028
		// (get) Token: 0x06008E9D RID: 36509 RVA: 0x0028A330 File Offset: 0x00288530
		public int CurrencyItemId
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

		// Token: 0x17001B75 RID: 7029
		// (get) Token: 0x06008E9E RID: 36510 RVA: 0x0028A370 File Offset: 0x00288570
		public int UpgradeRewardCount
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 4;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B76 RID: 7030
		// (get) Token: 0x06008E9F RID: 36511 RVA: 0x0028A3B0 File Offset: 0x002885B0
		public int ShopProductCount
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 4;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B77 RID: 7031
		// (get) Token: 0x06008EA0 RID: 36512 RVA: 0x0028A3F0 File Offset: 0x002885F0
		public int WeaponCount
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 6;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B78 RID: 7032
		// (get) Token: 0x06008EA1 RID: 36513 RVA: 0x0028A430 File Offset: 0x00288630
		public float DamageDefenseConst
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 20f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008EA2 RID: 36514 RVA: 0x0028A474 File Offset: 0x00288674
		public float HarvestingParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B79 RID: 7033
		// (get) Token: 0x06008EA3 RID: 36515 RVA: 0x0028A4B8 File Offset: 0x002886B8
		public int HarvestingParamsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008EA4 RID: 36516 RVA: 0x0028A4E4 File Offset: 0x002886E4
		public Span<float> GetHarvestingParamsBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x06008EA5 RID: 36517 RVA: 0x0028A4F4 File Offset: 0x002886F4
		public float[] GetHarvestingParamsArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x17001B7A RID: 7034
		// (get) Token: 0x06008EA6 RID: 36518 RVA: 0x0028A50C File Offset: 0x0028870C
		public int ConsecutiveKillMaxTimeInterval
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B7B RID: 7035
		// (get) Token: 0x06008EA7 RID: 36519 RVA: 0x0028A54C File Offset: 0x0028874C
		public int ConsecutiveKillHoldDuration
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 5;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008EA8 RID: 36520 RVA: 0x0028A58C File Offset: 0x0028878C
		public int ConsecutiveKillStartShowNumArray(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B7C RID: 7036
		// (get) Token: 0x06008EA9 RID: 36521 RVA: 0x0028A5CC File Offset: 0x002887CC
		public int ConsecutiveKillStartShowNumArrayLength
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008EAA RID: 36522 RVA: 0x0028A5F8 File Offset: 0x002887F8
		public Span<int> GetConsecutiveKillStartShowNumArrayBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x06008EAB RID: 36523 RVA: 0x0028A608 File Offset: 0x00288808
		public int[] GetConsecutiveKillStartShowNumArrayArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17001B7D RID: 7037
		// (get) Token: 0x06008EAC RID: 36524 RVA: 0x0028A620 File Offset: 0x00288820
		public int PersonalCardId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008EAD RID: 36525 RVA: 0x0028A660 File Offset: 0x00288860
		public DicIntInt? BulletCountMax(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001B7E RID: 7038
		// (get) Token: 0x06008EAE RID: 36526 RVA: 0x0028A6C4 File Offset: 0x002888C4
		public int BulletCountMaxLength
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17001B7F RID: 7039
		// (get) Token: 0x06008EAF RID: 36527 RVA: 0x0028A6F0 File Offset: 0x002888F0
		public float CameraShakeCd
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0.5f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008EB0 RID: 36528 RVA: 0x0028A734 File Offset: 0x00288934
		public DicIntString? CameraShake(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001B80 RID: 7040
		// (get) Token: 0x06008EB1 RID: 36529 RVA: 0x0028A798 File Offset: 0x00288998
		public int CameraShakeLength
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008EB2 RID: 36530 RVA: 0x0028A7C4 File Offset: 0x002889C4
		[NullableContext(1)]
		public Dictionary<int, int> BulletCountMax()
		{
			return this.BulletCountMaxIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008EB3 RID: 36531 RVA: 0x0028A81A File Offset: 0x00288A1A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> BulletCountMaxIter()
		{
			KurotatoActivityConfig.<BulletCountMaxIter>d__49 <BulletCountMaxIter>d__ = new KurotatoActivityConfig.<BulletCountMaxIter>d__49(-2);
			<BulletCountMaxIter>d__.<>3__<>4__this = this;
			return <BulletCountMaxIter>d__;
		}

		// Token: 0x06008EB4 RID: 36532 RVA: 0x0028A830 File Offset: 0x00288A30
		[NullableContext(1)]
		public Dictionary<int, string> CameraShake()
		{
			return this.CameraShakeIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06008EB5 RID: 36533 RVA: 0x0028A886 File Offset: 0x00288A86
		[NullableContext(1)]
		public IEnumerable<DicIntString> CameraShakeIter()
		{
			KurotatoActivityConfig.<CameraShakeIter>d__51 <CameraShakeIter>d__ = new KurotatoActivityConfig.<CameraShakeIter>d__51(-2);
			<CameraShakeIter>d__.<>3__<>4__this = this;
			return <CameraShakeIter>d__;
		}

		// Token: 0x06008EB6 RID: 36534 RVA: 0x0028A89B File Offset: 0x00288A9B
		[NullableContext(1)]
		public int[] ConsecutiveKillStartShowNumArray()
		{
			return this.GetConsecutiveKillStartShowNumArrayArray();
		}

		// Token: 0x06008EB7 RID: 36535 RVA: 0x0028A8A3 File Offset: 0x00288AA3
		[NullableContext(1)]
		public IEnumerable<int> ConsecutiveKillStartShowNumArrayIter()
		{
			KurotatoActivityConfig.<ConsecutiveKillStartShowNumArrayIter>d__53 <ConsecutiveKillStartShowNumArrayIter>d__ = new KurotatoActivityConfig.<ConsecutiveKillStartShowNumArrayIter>d__53(-2);
			<ConsecutiveKillStartShowNumArrayIter>d__.<>3__<>4__this = this;
			return <ConsecutiveKillStartShowNumArrayIter>d__;
		}

		// Token: 0x06008EB8 RID: 36536 RVA: 0x0028A8B8 File Offset: 0x00288AB8
		[NullableContext(1)]
		public float[] HarvestingParams()
		{
			return this.GetHarvestingParamsArray();
		}

		// Token: 0x06008EB9 RID: 36537 RVA: 0x0028A8C0 File Offset: 0x00288AC0
		[NullableContext(1)]
		public IEnumerable<float> HarvestingParamsIter()
		{
			KurotatoActivityConfig.<HarvestingParamsIter>d__55 <HarvestingParamsIter>d__ = new KurotatoActivityConfig.<HarvestingParamsIter>d__55(-2);
			<HarvestingParamsIter>d__.<>3__<>4__this = this;
			return <HarvestingParamsIter>d__;
		}

		// Token: 0x06008EBA RID: 36538 RVA: 0x0028A8D8 File Offset: 0x00288AD8
		public int? GetBulletCountMax(int key)
		{
			this.EnsureBulletCountMaxCacheIfNeeded();
			int value;
			if (!this.BulletCountMaxCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008EBB RID: 36539 RVA: 0x0028A90C File Offset: 0x00288B0C
		[NullableContext(2)]
		public string GetCameraShake(int key)
		{
			this.EnsureCameraShakeCacheIfNeeded();
			string result;
			if (!this.CameraShakeCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06008EBC RID: 36540 RVA: 0x0028A934 File Offset: 0x00288B34
		private void EnsureBulletCountMaxCacheIfNeeded()
		{
			if (this.BulletCountMaxCache != null)
			{
				return;
			}
			this.BulletCountMaxCache = this.BulletCountMaxIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x06008EBD RID: 36541 RVA: 0x0028A99C File Offset: 0x00288B9C
		private void EnsureCameraShakeCacheIfNeeded()
		{
			if (this.CameraShakeCache != null)
			{
				return;
			}
			this.CameraShakeCache = this.CameraShakeIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x06008EBE RID: 36542 RVA: 0x0028AA02 File Offset: 0x00288C02
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetBulletCountMaxFrozenDict()
		{
			this.EnsureBulletCountMaxCacheIfNeeded();
			return this.BulletCountMaxCache;
		}

		// Token: 0x06008EBF RID: 36543 RVA: 0x0028AA10 File Offset: 0x00288C10
		[NullableContext(1)]
		public FrozenDictionary<int, string> GetCameraShakeFrozenDict()
		{
			this.EnsureCameraShakeCacheIfNeeded();
			return this.CameraShakeCache;
		}

		// Token: 0x04005407 RID: 21511
		private Table __p;

		// Token: 0x04005408 RID: 21512
		[Nullable(2)]
		private FrozenDictionary<int, int> BulletCountMaxCache;

		// Token: 0x04005409 RID: 21513
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> CameraShakeCache;
	}
}
