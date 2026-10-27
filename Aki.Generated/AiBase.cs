using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000AE7 RID: 2791
	public struct AiBase : IFlatbufferObject
	{
		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600462E RID: 17966 RVA: 0x001D1F89 File Offset: 0x001D0189
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600462F RID: 17967 RVA: 0x001D1F96 File Offset: 0x001D0196
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004630 RID: 17968 RVA: 0x001D1FA0 File Offset: 0x001D01A0
		public static AiBase GetRootAsAiBase(ByteBuffer _bb)
		{
			return AiBase.GetRootAsAiBase(_bb, default(AiBase));
		}

		// Token: 0x06004631 RID: 17969 RVA: 0x001D1FBC File Offset: 0x001D01BC
		public static AiBase GetRootAsAiBase(ByteBuffer _bb, AiBase obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004632 RID: 17970 RVA: 0x001D1FD9 File Offset: 0x001D01D9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004633 RID: 17971 RVA: 0x001D1FE8 File Offset: 0x001D01E8
		public AiBase __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06004634 RID: 17972 RVA: 0x001D1FF8 File Offset: 0x001D01F8
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

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06004635 RID: 17973 RVA: 0x001D2034 File Offset: 0x001D0234
		public string StateMachine
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

		// Token: 0x06004636 RID: 17974 RVA: 0x001D206B File Offset: 0x001D026B
		public Span<byte> GetStateMachineBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x06004637 RID: 17975 RVA: 0x001D207A File Offset: 0x001D027A
		public byte[] GetStateMachineArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06004638 RID: 17976 RVA: 0x001D2094 File Offset: 0x001D0294
		public string AiController
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

		// Token: 0x06004639 RID: 17977 RVA: 0x001D20CB File Offset: 0x001D02CB
		public Span<byte> GetAiControllerBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600463A RID: 17978 RVA: 0x001D20DA File Offset: 0x001D02DA
		public byte[] GetAiControllerArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600463B RID: 17979 RVA: 0x001D20F4 File Offset: 0x001D02F4
		public string BehaviorTree
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

		// Token: 0x0600463C RID: 17980 RVA: 0x001D212C File Offset: 0x001D032C
		public Span<byte> GetBehaviorTreeBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600463D RID: 17981 RVA: 0x001D213C File Offset: 0x001D033C
		public byte[] GetBehaviorTreeArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x0600463E RID: 17982 RVA: 0x001D2154 File Offset: 0x001D0354
		public DicStringString? SubBehaviorConfigs(int j)
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new DicStringString?(default(DicStringString).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600463F RID: 17983 RVA: 0x001D21B8 File Offset: 0x001D03B8
		public int SubBehaviorConfigsLength
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

		// Token: 0x17000249 RID: 585
		// (get) Token: 0x06004640 RID: 17984 RVA: 0x001D21E4 File Offset: 0x001D03E4
		public bool Team
		{
			get
			{
				int num = this.__p.__offset(14);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700024A RID: 586
		// (get) Token: 0x06004641 RID: 17985 RVA: 0x001D2224 File Offset: 0x001D0424
		public int MonsterType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 4;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004642 RID: 17986 RVA: 0x001D2264 File Offset: 0x001D0464
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SubBehaviorConfigsFrozenDict()缓存字典，遍历请使用SubBehaviorConfigsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<string, string> SubBehaviorConfigs()
		{
			return this.SubBehaviorConfigsIter().ToDictionary((DicStringString element) => element.Key, (DicStringString element) => element.Value);
		}

		// Token: 0x06004643 RID: 17987 RVA: 0x001D22BA File Offset: 0x001D04BA
		[NullableContext(1)]
		public readonly IEnumerable<DicStringString> SubBehaviorConfigsIter()
		{
			AiBase.<SubBehaviorConfigsIter>d__30 <SubBehaviorConfigsIter>d__ = new AiBase.<SubBehaviorConfigsIter>d__30(-2);
			<SubBehaviorConfigsIter>d__.<>3__<>4__this = this;
			return <SubBehaviorConfigsIter>d__;
		}

		// Token: 0x06004644 RID: 17988 RVA: 0x001D22D0 File Offset: 0x001D04D0
		[NullableContext(1)]
		[return: Nullable(2)]
		public string GetSubBehaviorConfigs(string key)
		{
			this.EnsureSubBehaviorConfigsCacheIfNeeded();
			string result;
			if (!this.SubBehaviorConfigsCache.TryGetValue(key, out result))
			{
				return null;
			}
			return result;
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x001D22F8 File Offset: 0x001D04F8
		private void EnsureSubBehaviorConfigsCacheIfNeeded()
		{
			if (this.SubBehaviorConfigsCache != null)
			{
				return;
			}
			this.SubBehaviorConfigsCache = this.SubBehaviorConfigsIter().ToFrozenDictionary((DicStringString kvp) => kvp.Key, (DicStringString kvp) => kvp.Value, null);
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x001D235E File Offset: 0x001D055E
		[NullableContext(1)]
		[return: Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		public FrozenDictionary<string, string> GetSubBehaviorConfigsFrozenDict(string key)
		{
			this.EnsureSubBehaviorConfigsCacheIfNeeded();
			return this.SubBehaviorConfigsCache;
		}

		// Token: 0x04004AC7 RID: 19143
		private Table __p;

		// Token: 0x04004AC8 RID: 19144
		[Nullable(new byte[]
		{
			2,
			1,
			1
		})]
		private FrozenDictionary<string, string> SubBehaviorConfigsCache;
	}
}
