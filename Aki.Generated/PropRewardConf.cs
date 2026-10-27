using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000F5D RID: 3933
	public struct PropRewardConf : IFlatbufferObject
	{
		// Token: 0x17002B13 RID: 11027
		// (get) Token: 0x0600B3AA RID: 45994 RVA: 0x002CBF78 File Offset: 0x002CA178
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B3AB RID: 45995 RVA: 0x002CBF85 File Offset: 0x002CA185
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B3AC RID: 45996 RVA: 0x002CBF8C File Offset: 0x002CA18C
		public static PropRewardConf GetRootAsPropRewardConf(ByteBuffer _bb)
		{
			return PropRewardConf.GetRootAsPropRewardConf(_bb, default(PropRewardConf));
		}

		// Token: 0x0600B3AD RID: 45997 RVA: 0x002CBFA8 File Offset: 0x002CA1A8
		public static PropRewardConf GetRootAsPropRewardConf(ByteBuffer _bb, PropRewardConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B3AE RID: 45998 RVA: 0x002CBFC5 File Offset: 0x002CA1C5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B3AF RID: 45999 RVA: 0x002CBFD4 File Offset: 0x002CA1D4
		public PropRewardConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B14 RID: 11028
		// (get) Token: 0x0600B3B0 RID: 46000 RVA: 0x002CBFE4 File Offset: 0x002CA1E4
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

		// Token: 0x0600B3B1 RID: 46001 RVA: 0x002CC020 File Offset: 0x002CA220
		public ConfigPropValue? Props(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002B15 RID: 11029
		// (get) Token: 0x0600B3B2 RID: 46002 RVA: 0x002CC080 File Offset: 0x002CA280
		public int PropsLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600B3B3 RID: 46003 RVA: 0x002CC0AC File Offset: 0x002CA2AC
		public DicStringInt? Tips(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002B16 RID: 11030
		// (get) Token: 0x0600B3B4 RID: 46004 RVA: 0x002CC10C File Offset: 0x002CA30C
		public int TipsLength
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

		// Token: 0x17002B17 RID: 11031
		// (get) Token: 0x0600B3B5 RID: 46005 RVA: 0x002CC138 File Offset: 0x002CA338
		public bool IsFormation
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B3B6 RID: 46006 RVA: 0x002CC178 File Offset: 0x002CA378
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用PropsIter()或GetPropsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly ConfigPropValue[] Props()
		{
			return this.PropsIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600B3B7 RID: 46007 RVA: 0x002CC185 File Offset: 0x002CA385
		[NullableContext(1)]
		public readonly IEnumerable<ConfigPropValue> PropsIter()
		{
			PropRewardConf.<PropsIter>d__19 <PropsIter>d__ = new PropRewardConf.<PropsIter>d__19(-2);
			<PropsIter>d__.<>3__<>4__this = this;
			return <PropsIter>d__;
		}

		// Token: 0x0600B3B8 RID: 46008 RVA: 0x002CC19C File Offset: 0x002CA39C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用TipsFrozenDict()缓存字典，遍历请使用TipsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, int> Tips()
		{
			return this.TipsIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600B3B9 RID: 46009 RVA: 0x002CC1F2 File Offset: 0x002CA3F2
		[NullableContext(1)]
		public readonly IEnumerable<DicStringInt> TipsIter()
		{
			PropRewardConf.<TipsIter>d__21 <TipsIter>d__ = new PropRewardConf.<TipsIter>d__21(-2);
			<TipsIter>d__.<>3__<>4__this = this;
			return <TipsIter>d__;
		}

		// Token: 0x0600B3BA RID: 46010 RVA: 0x002CC208 File Offset: 0x002CA408
		[NullableContext(1)]
		public int? GetTips(string key)
		{
			this.EnsureTipsCacheIfNeeded();
			int value;
			if (!this.TipsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600B3BB RID: 46011 RVA: 0x002CC23C File Offset: 0x002CA43C
		private void EnsureTipsCacheIfNeeded()
		{
			if (this.TipsCache != null)
			{
				return;
			}
			this.TipsCache = this.TipsIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B3BC RID: 46012 RVA: 0x002CC2A2 File Offset: 0x002CA4A2
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<string, int> GetTipsFrozenDict(string key)
		{
			this.EnsureTipsCacheIfNeeded();
			return this.TipsCache;
		}

		// Token: 0x0400502A RID: 20522
		private Table __p;

		// Token: 0x0400502B RID: 20523
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> TipsCache;
	}
}
