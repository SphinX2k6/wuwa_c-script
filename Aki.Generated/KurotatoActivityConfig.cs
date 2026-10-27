using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D95 RID: 3477
	public struct KurotatoActivityConfig : IFlatbufferObject
	{
		// Token: 0x17001B0C RID: 6924
		// (get) Token: 0x06008878 RID: 34936 RVA: 0x0026B4EC File Offset: 0x002696EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008879 RID: 34937 RVA: 0x0026B4F9 File Offset: 0x002696F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600887A RID: 34938 RVA: 0x0026B500 File Offset: 0x00269700
		public static KurotatoActivityConfig GetRootAsKurotatoActivityConfig(ByteBuffer _bb)
		{
			return KurotatoActivityConfig.GetRootAsKurotatoActivityConfig(_bb, default(KurotatoActivityConfig));
		}

		// Token: 0x0600887B RID: 34939 RVA: 0x0026B51C File Offset: 0x0026971C
		public static KurotatoActivityConfig GetRootAsKurotatoActivityConfig(ByteBuffer _bb, KurotatoActivityConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600887C RID: 34940 RVA: 0x0026B539 File Offset: 0x00269739
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600887D RID: 34941 RVA: 0x0026B548 File Offset: 0x00269748
		public KurotatoActivityConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B0D RID: 6925
		// (get) Token: 0x0600887E RID: 34942 RVA: 0x0026B558 File Offset: 0x00269758
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

		// Token: 0x17001B0E RID: 6926
		// (get) Token: 0x0600887F RID: 34943 RVA: 0x0026B594 File Offset: 0x00269794
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

		// Token: 0x17001B0F RID: 6927
		// (get) Token: 0x06008880 RID: 34944 RVA: 0x0026B5D0 File Offset: 0x002697D0
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

		// Token: 0x17001B10 RID: 6928
		// (get) Token: 0x06008881 RID: 34945 RVA: 0x0026B60C File Offset: 0x0026980C
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

		// Token: 0x17001B11 RID: 6929
		// (get) Token: 0x06008882 RID: 34946 RVA: 0x0026B64C File Offset: 0x0026984C
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

		// Token: 0x17001B12 RID: 6930
		// (get) Token: 0x06008883 RID: 34947 RVA: 0x0026B68C File Offset: 0x0026988C
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

		// Token: 0x17001B13 RID: 6931
		// (get) Token: 0x06008884 RID: 34948 RVA: 0x0026B6CC File Offset: 0x002698CC
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

		// Token: 0x17001B14 RID: 6932
		// (get) Token: 0x06008885 RID: 34949 RVA: 0x0026B70C File Offset: 0x0026990C
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

		// Token: 0x06008886 RID: 34950 RVA: 0x0026B750 File Offset: 0x00269950
		public float HarvestingParams(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0f;
			}
			return this.__p.bb.GetFloat(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B15 RID: 6933
		// (get) Token: 0x06008887 RID: 34951 RVA: 0x0026B794 File Offset: 0x00269994
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

		// Token: 0x06008888 RID: 34952 RVA: 0x0026B7C0 File Offset: 0x002699C0
		public Span<float> GetHarvestingParamsBytes()
		{
			return this.__p.__vector_as_span<float>(20, 4);
		}

		// Token: 0x06008889 RID: 34953 RVA: 0x0026B7D0 File Offset: 0x002699D0
		public float[] GetHarvestingParamsArray()
		{
			return this.__p.__vector_as_array<float>(20) ?? Array.Empty<float>();
		}

		// Token: 0x17001B16 RID: 6934
		// (get) Token: 0x0600888A RID: 34954 RVA: 0x0026B7E8 File Offset: 0x002699E8
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

		// Token: 0x17001B17 RID: 6935
		// (get) Token: 0x0600888B RID: 34955 RVA: 0x0026B828 File Offset: 0x00269A28
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

		// Token: 0x0600888C RID: 34956 RVA: 0x0026B868 File Offset: 0x00269A68
		public int ConsecutiveKillStartShowNumArray(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B18 RID: 6936
		// (get) Token: 0x0600888D RID: 34957 RVA: 0x0026B8A8 File Offset: 0x00269AA8
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

		// Token: 0x0600888E RID: 34958 RVA: 0x0026B8D4 File Offset: 0x00269AD4
		public Span<int> GetConsecutiveKillStartShowNumArrayBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600888F RID: 34959 RVA: 0x0026B8E4 File Offset: 0x00269AE4
		public int[] GetConsecutiveKillStartShowNumArrayArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x17001B19 RID: 6937
		// (get) Token: 0x06008890 RID: 34960 RVA: 0x0026B8FC File Offset: 0x00269AFC
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

		// Token: 0x06008891 RID: 34961 RVA: 0x0026B93C File Offset: 0x00269B3C
		public DicIntInt? BulletCountMax(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001B1A RID: 6938
		// (get) Token: 0x06008892 RID: 34962 RVA: 0x0026B9A0 File Offset: 0x00269BA0
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

		// Token: 0x17001B1B RID: 6939
		// (get) Token: 0x06008893 RID: 34963 RVA: 0x0026B9CC File Offset: 0x00269BCC
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

		// Token: 0x06008894 RID: 34964 RVA: 0x0026BA10 File Offset: 0x00269C10
		public DicIntString? CameraShake(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001B1C RID: 6940
		// (get) Token: 0x06008895 RID: 34965 RVA: 0x0026BA74 File Offset: 0x00269C74
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

		// Token: 0x06008896 RID: 34966 RVA: 0x0026BAA0 File Offset: 0x00269CA0
		[NullableContext(1)]
		[Obsolete("已废弃，请使用BulletCountMaxFrozenDict()缓存字典，遍历请使用BulletCountMaxIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> BulletCountMax()
		{
			return this.BulletCountMaxIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008897 RID: 34967 RVA: 0x0026BAF6 File Offset: 0x00269CF6
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> BulletCountMaxIter()
		{
			KurotatoActivityConfig.<BulletCountMaxIter>d__49 <BulletCountMaxIter>d__ = new KurotatoActivityConfig.<BulletCountMaxIter>d__49(-2);
			<BulletCountMaxIter>d__.<>3__<>4__this = this;
			return <BulletCountMaxIter>d__;
		}

		// Token: 0x06008898 RID: 34968 RVA: 0x0026BB0C File Offset: 0x00269D0C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用CameraShakeFrozenDict()缓存字典，遍历请使用CameraShakeIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> CameraShake()
		{
			return this.CameraShakeIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x06008899 RID: 34969 RVA: 0x0026BB62 File Offset: 0x00269D62
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> CameraShakeIter()
		{
			KurotatoActivityConfig.<CameraShakeIter>d__51 <CameraShakeIter>d__ = new KurotatoActivityConfig.<CameraShakeIter>d__51(-2);
			<CameraShakeIter>d__.<>3__<>4__this = this;
			return <CameraShakeIter>d__;
		}

		// Token: 0x0600889A RID: 34970 RVA: 0x0026BB78 File Offset: 0x00269D78
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ConsecutiveKillStartShowNumArrayIter()或GetConsecutiveKillStartShowNumArrayBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ConsecutiveKillStartShowNumArray()
		{
			KurotatoActivityConfig kurotatoActivityConfig = this;
			return kurotatoActivityConfig.GetConsecutiveKillStartShowNumArrayArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600889B RID: 34971 RVA: 0x0026BB9C File Offset: 0x00269D9C
		[NullableContext(1)]
		public readonly IEnumerable<int> ConsecutiveKillStartShowNumArrayIter()
		{
			KurotatoActivityConfig.<ConsecutiveKillStartShowNumArrayIter>d__53 <ConsecutiveKillStartShowNumArrayIter>d__ = new KurotatoActivityConfig.<ConsecutiveKillStartShowNumArrayIter>d__53(-2);
			<ConsecutiveKillStartShowNumArrayIter>d__.<>3__<>4__this = this;
			return <ConsecutiveKillStartShowNumArrayIter>d__;
		}

		// Token: 0x0600889C RID: 34972 RVA: 0x0026BBB4 File Offset: 0x00269DB4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HarvestingParamsIter()或GetHarvestingParamsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly float[] HarvestingParams()
		{
			KurotatoActivityConfig kurotatoActivityConfig = this;
			return kurotatoActivityConfig.GetHarvestingParamsArray() ?? Array.Empty<float>();
		}

		// Token: 0x0600889D RID: 34973 RVA: 0x0026BBD8 File Offset: 0x00269DD8
		[NullableContext(1)]
		public readonly IEnumerable<float> HarvestingParamsIter()
		{
			KurotatoActivityConfig.<HarvestingParamsIter>d__55 <HarvestingParamsIter>d__ = new KurotatoActivityConfig.<HarvestingParamsIter>d__55(-2);
			<HarvestingParamsIter>d__.<>3__<>4__this = this;
			return <HarvestingParamsIter>d__;
		}

		// Token: 0x0600889E RID: 34974 RVA: 0x0026BBF0 File Offset: 0x00269DF0
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

		// Token: 0x0600889F RID: 34975 RVA: 0x0026BC24 File Offset: 0x00269E24
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

		// Token: 0x060088A0 RID: 34976 RVA: 0x0026BC4C File Offset: 0x00269E4C
		private void EnsureBulletCountMaxCacheIfNeeded()
		{
			if (this.BulletCountMaxCache != null)
			{
				return;
			}
			this.BulletCountMaxCache = this.BulletCountMaxIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060088A1 RID: 34977 RVA: 0x0026BCB4 File Offset: 0x00269EB4
		private void EnsureCameraShakeCacheIfNeeded()
		{
			if (this.CameraShakeCache != null)
			{
				return;
			}
			this.CameraShakeCache = this.CameraShakeIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x060088A2 RID: 34978 RVA: 0x0026BD1A File Offset: 0x00269F1A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetBulletCountMaxFrozenDict(int key)
		{
			this.EnsureBulletCountMaxCacheIfNeeded();
			return this.BulletCountMaxCache;
		}

		// Token: 0x060088A3 RID: 34979 RVA: 0x0026BD28 File Offset: 0x00269F28
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetCameraShakeFrozenDict(int key)
		{
			this.EnsureCameraShakeCacheIfNeeded();
			return this.CameraShakeCache;
		}

		// Token: 0x04004E22 RID: 20002
		private Table __p;

		// Token: 0x04004E23 RID: 20003
		[Nullable(2)]
		private FrozenDictionary<int, int> BulletCountMaxCache;

		// Token: 0x04004E24 RID: 20004
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> CameraShakeCache;
	}
}
