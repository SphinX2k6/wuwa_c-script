using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010A3 RID: 4259
	public struct SheriffQuest : IFlatbufferObject
	{
		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600D136 RID: 53558 RVA: 0x0030D835 File Offset: 0x0030BA35
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D137 RID: 53559 RVA: 0x0030D842 File Offset: 0x0030BA42
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D138 RID: 53560 RVA: 0x0030D84C File Offset: 0x0030BA4C
		public static SheriffQuest GetRootAsSheriffQuest(ByteBuffer _bb)
		{
			return SheriffQuest.GetRootAsSheriffQuest(_bb, default(SheriffQuest));
		}

		// Token: 0x0600D139 RID: 53561 RVA: 0x0030D868 File Offset: 0x0030BA68
		public static SheriffQuest GetRootAsSheriffQuest(ByteBuffer _bb, SheriffQuest obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D13A RID: 53562 RVA: 0x0030D885 File Offset: 0x0030BA85
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D13B RID: 53563 RVA: 0x0030D894 File Offset: 0x0030BA94
		public SheriffQuest __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600D13C RID: 53564 RVA: 0x0030D8A4 File Offset: 0x0030BAA4
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

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600D13D RID: 53565 RVA: 0x0030D8E0 File Offset: 0x0030BAE0
		public int SheriffZoneId
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

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600D13E RID: 53566 RVA: 0x0030D91C File Offset: 0x0030BB1C
		public int QuestId
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

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600D13F RID: 53567 RVA: 0x0030D958 File Offset: 0x0030BB58
		public int MarkId
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

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600D140 RID: 53568 RVA: 0x0030D998 File Offset: 0x0030BB98
		public int QuestType
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

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600D141 RID: 53569 RVA: 0x0030D9D8 File Offset: 0x0030BBD8
		public int UnlockConditionGroupId
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600D142 RID: 53570 RVA: 0x0030DA18 File Offset: 0x0030BC18
		public string UnFinishDesc
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D143 RID: 53571 RVA: 0x0030DA50 File Offset: 0x0030BC50
		public Span<byte> GetUnFinishDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600D144 RID: 53572 RVA: 0x0030DA60 File Offset: 0x0030BC60
		public byte[] GetUnFinishDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600D145 RID: 53573 RVA: 0x0030DA78 File Offset: 0x0030BC78
		public string GlobalVar
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

		// Token: 0x0600D146 RID: 53574 RVA: 0x0030DAB0 File Offset: 0x0030BCB0
		public Span<byte> GetGlobalVarBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600D147 RID: 53575 RVA: 0x0030DAC0 File Offset: 0x0030BCC0
		public byte[] GetGlobalVarArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600D148 RID: 53576 RVA: 0x0030DAD8 File Offset: 0x0030BCD8
		public DicIntString? FinishedDescDic(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntString?(default(DicIntString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600D149 RID: 53577 RVA: 0x0030DB3C File Offset: 0x0030BD3C
		public int FinishedDescDicLength
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

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600D14A RID: 53578 RVA: 0x0030DB68 File Offset: 0x0030BD68
		public string Picture
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D14B RID: 53579 RVA: 0x0030DBA0 File Offset: 0x0030BDA0
		public Span<byte> GetPictureBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x0600D14C RID: 53580 RVA: 0x0030DBB0 File Offset: 0x0030BDB0
		public byte[] GetPictureArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600D14D RID: 53581 RVA: 0x0030DBC8 File Offset: 0x0030BDC8
		public int TextVisibleScale
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

		// Token: 0x0600D14E RID: 53582 RVA: 0x0030DC08 File Offset: 0x0030BE08
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FinishedDescDicFrozenDict()缓存字典，遍历请使用FinishedDescDicIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, string> FinishedDescDic()
		{
			return this.FinishedDescDicIter().ToDictionary((DicIntString element) => element.Key, (DicIntString element) => element.Value);
		}

		// Token: 0x0600D14F RID: 53583 RVA: 0x0030DC5E File Offset: 0x0030BE5E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntString> FinishedDescDicIter()
		{
			SheriffQuest.<FinishedDescDicIter>d__38 <FinishedDescDicIter>d__ = new SheriffQuest.<FinishedDescDicIter>d__38(-2);
			<FinishedDescDicIter>d__.<>3__<>4__this = this;
			return <FinishedDescDicIter>d__;
		}

		// Token: 0x0600D150 RID: 53584 RVA: 0x0030DC74 File Offset: 0x0030BE74
		[NullableContext(2)]
		public string GetFinishedDescDic(int key)
		{
			this.EnsureFinishedDescDicCacheIfNeeded();
			string result;
			if (!this.FinishedDescDicCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x0600D151 RID: 53585 RVA: 0x0030DC9C File Offset: 0x0030BE9C
		private void EnsureFinishedDescDicCacheIfNeeded()
		{
			if (this.FinishedDescDicCache != null)
			{
				return;
			}
			this.FinishedDescDicCache = this.FinishedDescDicIter().ToFrozenDictionary((DicIntString kvp) => kvp.Key, (DicIntString kvp) => kvp.Value, null);
		}

		// Token: 0x0600D152 RID: 53586 RVA: 0x0030DD02 File Offset: 0x0030BF02
		[return: Nullable(new byte[]
		{
			2,
			1
		})]
		public FrozenDictionary<int, string> GetFinishedDescDicFrozenDict(int key)
		{
			this.EnsureFinishedDescDicCacheIfNeeded();
			return this.FinishedDescDicCache;
		}

		// Token: 0x040051B1 RID: 20913
		private Table __p;

		// Token: 0x040051B2 RID: 20914
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private FrozenDictionary<int, string> FinishedDescDicCache;
	}
}
