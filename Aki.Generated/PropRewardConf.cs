using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02001044 RID: 4164
	public struct PropRewardConf : IFlatbufferObject
	{
		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x0600B9E7 RID: 47591 RVA: 0x002E8C2C File Offset: 0x002E6E2C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600B9E8 RID: 47592 RVA: 0x002E8C39 File Offset: 0x002E6E39
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600B9E9 RID: 47593 RVA: 0x002E8C40 File Offset: 0x002E6E40
		public static PropRewardConf GetRootAsPropRewardConf(ByteBuffer _bb)
		{
			return PropRewardConf.GetRootAsPropRewardConf(_bb, default(PropRewardConf));
		}

		// Token: 0x0600B9EA RID: 47594 RVA: 0x002E8C5C File Offset: 0x002E6E5C
		public static PropRewardConf GetRootAsPropRewardConf(ByteBuffer _bb, PropRewardConf obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600B9EB RID: 47595 RVA: 0x002E8C79 File Offset: 0x002E6E79
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600B9EC RID: 47596 RVA: 0x002E8C88 File Offset: 0x002E6E88
		public PropRewardConf __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x0600B9ED RID: 47597 RVA: 0x002E8C98 File Offset: 0x002E6E98
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

		// Token: 0x0600B9EE RID: 47598 RVA: 0x002E8CD4 File Offset: 0x002E6ED4
		public ConfigPropValue? Props(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new ConfigPropValue?(default(ConfigPropValue).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x0600B9EF RID: 47599 RVA: 0x002E8D34 File Offset: 0x002E6F34
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

		// Token: 0x0600B9F0 RID: 47600 RVA: 0x002E8D60 File Offset: 0x002E6F60
		public DicStringInt? Tips(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new DicStringInt?(default(DicStringInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17002B8E RID: 11150
		// (get) Token: 0x0600B9F1 RID: 47601 RVA: 0x002E8DC0 File Offset: 0x002E6FC0
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

		// Token: 0x17002B8F RID: 11151
		// (get) Token: 0x0600B9F2 RID: 47602 RVA: 0x002E8DEC File Offset: 0x002E6FEC
		public bool IsFormation
		{
			get
			{
				int num = this.__p.__offset(10);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600B9F3 RID: 47603 RVA: 0x002E8E2C File Offset: 0x002E702C
		[NullableContext(1)]
		public ConfigPropValue[] Props()
		{
			return this.PropsIter().ToArray<ConfigPropValue>();
		}

		// Token: 0x0600B9F4 RID: 47604 RVA: 0x002E8E39 File Offset: 0x002E7039
		[NullableContext(1)]
		public IEnumerable<ConfigPropValue> PropsIter()
		{
			PropRewardConf.<PropsIter>d__19 <PropsIter>d__ = new PropRewardConf.<PropsIter>d__19(-2);
			<PropsIter>d__.<>3__<>4__this = this;
			return <PropsIter>d__;
		}

		// Token: 0x0600B9F5 RID: 47605 RVA: 0x002E8E50 File Offset: 0x002E7050
		[NullableContext(1)]
		public Dictionary<string, int> Tips()
		{
			return this.TipsIter().ToDictionary((DicStringInt element) => element.Key, (DicStringInt element) => element.Value);
		}

		// Token: 0x0600B9F6 RID: 47606 RVA: 0x002E8EA6 File Offset: 0x002E70A6
		[NullableContext(1)]
		public IEnumerable<DicStringInt> TipsIter()
		{
			PropRewardConf.<TipsIter>d__21 <TipsIter>d__ = new PropRewardConf.<TipsIter>d__21(-2);
			<TipsIter>d__.<>3__<>4__this = this;
			return <TipsIter>d__;
		}

		// Token: 0x0600B9F7 RID: 47607 RVA: 0x002E8EBC File Offset: 0x002E70BC
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

		// Token: 0x0600B9F8 RID: 47608 RVA: 0x002E8EF0 File Offset: 0x002E70F0
		private void EnsureTipsCacheIfNeeded()
		{
			if (this.TipsCache != null)
			{
				return;
			}
			this.TipsCache = this.TipsIter().ToFrozenDictionary((DicStringInt kvp) => kvp.Key, (DicStringInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600B9F9 RID: 47609 RVA: 0x002E8F56 File Offset: 0x002E7156
		[NullableContext(1)]
		public FrozenDictionary<string, int> GetTipsFrozenDict()
		{
			this.EnsureTipsCacheIfNeeded();
			return this.TipsCache;
		}

		// Token: 0x04005611 RID: 22033
		private Table __p;

		// Token: 0x04005612 RID: 22034
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<string, int> TipsCache;
	}
}
