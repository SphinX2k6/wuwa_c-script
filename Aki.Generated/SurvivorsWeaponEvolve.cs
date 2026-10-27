using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x0200110D RID: 4365
	public struct SurvivorsWeaponEvolve : IFlatbufferObject
	{
		// Token: 0x1700396C RID: 14700
		// (get) Token: 0x0600DC3C RID: 56380 RVA: 0x00328020 File Offset: 0x00326220
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC3D RID: 56381 RVA: 0x0032802D File Offset: 0x0032622D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC3E RID: 56382 RVA: 0x00328034 File Offset: 0x00326234
		public static SurvivorsWeaponEvolve GetRootAsSurvivorsWeaponEvolve(ByteBuffer _bb)
		{
			return SurvivorsWeaponEvolve.GetRootAsSurvivorsWeaponEvolve(_bb, default(SurvivorsWeaponEvolve));
		}

		// Token: 0x0600DC3F RID: 56383 RVA: 0x00328050 File Offset: 0x00326250
		public static SurvivorsWeaponEvolve GetRootAsSurvivorsWeaponEvolve(ByteBuffer _bb, SurvivorsWeaponEvolve obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC40 RID: 56384 RVA: 0x0032806D File Offset: 0x0032626D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC41 RID: 56385 RVA: 0x0032807C File Offset: 0x0032627C
		public SurvivorsWeaponEvolve __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700396D RID: 14701
		// (get) Token: 0x0600DC42 RID: 56386 RVA: 0x0032808C File Offset: 0x0032628C
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

		// Token: 0x1700396E RID: 14702
		// (get) Token: 0x0600DC43 RID: 56387 RVA: 0x003280C8 File Offset: 0x003262C8
		public int WeaponId
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

		// Token: 0x1700396F RID: 14703
		// (get) Token: 0x0600DC44 RID: 56388 RVA: 0x00328104 File Offset: 0x00326304
		public int Quality
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

		// Token: 0x17003970 RID: 14704
		// (get) Token: 0x0600DC45 RID: 56389 RVA: 0x00328140 File Offset: 0x00326340
		public int ConditionType
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

		// Token: 0x0600DC46 RID: 56390 RVA: 0x00328180 File Offset: 0x00326380
		public DicIntInt? ConditionArgs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003971 RID: 14705
		// (get) Token: 0x0600DC47 RID: 56391 RVA: 0x003281E4 File Offset: 0x003263E4
		public int ConditionArgsLength
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

		// Token: 0x17003972 RID: 14706
		// (get) Token: 0x0600DC48 RID: 56392 RVA: 0x00328210 File Offset: 0x00326410
		public string EvolveName
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC49 RID: 56393 RVA: 0x00328248 File Offset: 0x00326448
		public Span<byte> GetEvolveNameBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x0600DC4A RID: 56394 RVA: 0x00328258 File Offset: 0x00326458
		public byte[] GetEvolveNameArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DC4B RID: 56395 RVA: 0x00328270 File Offset: 0x00326470
		public string UnlockDesc(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003973 RID: 14707
		// (get) Token: 0x0600DC4C RID: 56396 RVA: 0x003282AC File Offset: 0x003264AC
		public int UnlockDescLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x17003974 RID: 14708
		// (get) Token: 0x0600DC4D RID: 56397 RVA: 0x003282D8 File Offset: 0x003264D8
		public string Describe
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DC4E RID: 56398 RVA: 0x00328310 File Offset: 0x00326510
		public Span<byte> GetDescribeBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DC4F RID: 56399 RVA: 0x00328320 File Offset: 0x00326520
		public byte[] GetDescribeArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DC50 RID: 56400 RVA: 0x00328338 File Offset: 0x00326538
		[NullableContext(1)]
		[Obsolete("已废弃，请使用ConditionArgsFrozenDict()缓存字典，遍历请使用ConditionArgsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> ConditionArgs()
		{
			return this.ConditionArgsIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DC51 RID: 56401 RVA: 0x0032838E File Offset: 0x0032658E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> ConditionArgsIter()
		{
			SurvivorsWeaponEvolve.<ConditionArgsIter>d__31 <ConditionArgsIter>d__ = new SurvivorsWeaponEvolve.<ConditionArgsIter>d__31(-2);
			<ConditionArgsIter>d__.<>3__<>4__this = this;
			return <ConditionArgsIter>d__;
		}

		// Token: 0x0600DC52 RID: 56402 RVA: 0x003283A3 File Offset: 0x003265A3
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnlockDescIter()或GetUnlockDescBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] UnlockDesc()
		{
			return this.UnlockDescIter().ToArray<string>();
		}

		// Token: 0x0600DC53 RID: 56403 RVA: 0x003283B0 File Offset: 0x003265B0
		[NullableContext(1)]
		public readonly IEnumerable<string> UnlockDescIter()
		{
			SurvivorsWeaponEvolve.<UnlockDescIter>d__33 <UnlockDescIter>d__ = new SurvivorsWeaponEvolve.<UnlockDescIter>d__33(-2);
			<UnlockDescIter>d__.<>3__<>4__this = this;
			return <UnlockDescIter>d__;
		}

		// Token: 0x0600DC54 RID: 56404 RVA: 0x003283C8 File Offset: 0x003265C8
		public int? GetConditionArgs(int key)
		{
			this.EnsureConditionArgsCacheIfNeeded();
			int value;
			if (!this.ConditionArgsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600DC55 RID: 56405 RVA: 0x003283FC File Offset: 0x003265FC
		private void EnsureConditionArgsCacheIfNeeded()
		{
			if (this.ConditionArgsCache != null)
			{
				return;
			}
			this.ConditionArgsCache = this.ConditionArgsIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DC56 RID: 56406 RVA: 0x00328462 File Offset: 0x00326662
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetConditionArgsFrozenDict(int key)
		{
			this.EnsureConditionArgsCacheIfNeeded();
			return this.ConditionArgsCache;
		}

		// Token: 0x04005249 RID: 21065
		private Table __p;

		// Token: 0x0400524A RID: 21066
		[Nullable(2)]
		private FrozenDictionary<int, int> ConditionArgsCache;
	}
}
