using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D65 RID: 3429
	public struct InfrLevel : IFlatbufferObject
	{
		// Token: 0x170018E8 RID: 6376
		// (get) Token: 0x0600833F RID: 33599 RVA: 0x0025E785 File Offset: 0x0025C985
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008340 RID: 33600 RVA: 0x0025E792 File Offset: 0x0025C992
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008341 RID: 33601 RVA: 0x0025E79C File Offset: 0x0025C99C
		public static InfrLevel GetRootAsInfrLevel(ByteBuffer _bb)
		{
			return InfrLevel.GetRootAsInfrLevel(_bb, default(InfrLevel));
		}

		// Token: 0x06008342 RID: 33602 RVA: 0x0025E7B8 File Offset: 0x0025C9B8
		public static InfrLevel GetRootAsInfrLevel(ByteBuffer _bb, InfrLevel obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008343 RID: 33603 RVA: 0x0025E7D5 File Offset: 0x0025C9D5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008344 RID: 33604 RVA: 0x0025E7E4 File Offset: 0x0025C9E4
		public InfrLevel __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170018E9 RID: 6377
		// (get) Token: 0x06008345 RID: 33605 RVA: 0x0025E7F4 File Offset: 0x0025C9F4
		public int Level
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

		// Token: 0x170018EA RID: 6378
		// (get) Token: 0x06008346 RID: 33606 RVA: 0x0025E830 File Offset: 0x0025CA30
		public int Exp
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

		// Token: 0x170018EB RID: 6379
		// (get) Token: 0x06008347 RID: 33607 RVA: 0x0025E86C File Offset: 0x0025CA6C
		public int ConditionId
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

		// Token: 0x06008348 RID: 33608 RVA: 0x0025E8A8 File Offset: 0x0025CAA8
		public DicIntInt? Requirement(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06008349 RID: 33609 RVA: 0x0025E90C File Offset: 0x0025CB0C
		public int RequirementLength
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

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x0600834A RID: 33610 RVA: 0x0025E938 File Offset: 0x0025CB38
		public int RoadCoinAdd
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

		// Token: 0x170018EE RID: 6382
		// (get) Token: 0x0600834B RID: 33611 RVA: 0x0025E978 File Offset: 0x0025CB78
		public int Reward
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

		// Token: 0x170018EF RID: 6383
		// (get) Token: 0x0600834C RID: 33612 RVA: 0x0025E9B8 File Offset: 0x0025CBB8
		public string Description
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

		// Token: 0x0600834D RID: 33613 RVA: 0x0025E9F0 File Offset: 0x0025CBF0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x0600834E RID: 33614 RVA: 0x0025EA00 File Offset: 0x0025CC00
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x0600834F RID: 33615 RVA: 0x0025EA18 File Offset: 0x0025CC18
		public string QuestDescriptions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018F0 RID: 6384
		// (get) Token: 0x06008350 RID: 33616 RVA: 0x0025EA54 File Offset: 0x0025CC54
		public int QuestDescriptionsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008351 RID: 33617 RVA: 0x0025EA80 File Offset: 0x0025CC80
		public int QuestIds(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018F1 RID: 6385
		// (get) Token: 0x06008352 RID: 33618 RVA: 0x0025EAC0 File Offset: 0x0025CCC0
		public int QuestIdsLength
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

		// Token: 0x06008353 RID: 33619 RVA: 0x0025EAEC File Offset: 0x0025CCEC
		public Span<int> GetQuestIdsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x06008354 RID: 33620 RVA: 0x0025EAFC File Offset: 0x0025CCFC
		public int[] GetQuestIdsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x170018F2 RID: 6386
		// (get) Token: 0x06008355 RID: 33621 RVA: 0x0025EB14 File Offset: 0x0025CD14
		public string Name
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

		// Token: 0x06008356 RID: 33622 RVA: 0x0025EB4C File Offset: 0x0025CD4C
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008357 RID: 33623 RVA: 0x0025EB5C File Offset: 0x0025CD5C
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06008358 RID: 33624 RVA: 0x0025EB74 File Offset: 0x0025CD74
		public string EffectDes(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170018F3 RID: 6387
		// (get) Token: 0x06008359 RID: 33625 RVA: 0x0025EBB0 File Offset: 0x0025CDB0
		public int EffectDesLength
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170018F4 RID: 6388
		// (get) Token: 0x0600835A RID: 33626 RVA: 0x0025EBDC File Offset: 0x0025CDDC
		public string StageDescription
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600835B RID: 33627 RVA: 0x0025EC14 File Offset: 0x0025CE14
		public Span<byte> GetStageDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x0600835C RID: 33628 RVA: 0x0025EC24 File Offset: 0x0025CE24
		public byte[] GetStageDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x170018F5 RID: 6389
		// (get) Token: 0x0600835D RID: 33629 RVA: 0x0025EC3C File Offset: 0x0025CE3C
		public string InfoPicturePath
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600835E RID: 33630 RVA: 0x0025EC74 File Offset: 0x0025CE74
		public Span<byte> GetInfoPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(28, 1);
		}

		// Token: 0x0600835F RID: 33631 RVA: 0x0025EC84 File Offset: 0x0025CE84
		public byte[] GetInfoPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(28) ?? Array.Empty<byte>();
		}

		// Token: 0x170018F6 RID: 6390
		// (get) Token: 0x06008360 RID: 33632 RVA: 0x0025EC9C File Offset: 0x0025CE9C
		public string MarkStageName
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008361 RID: 33633 RVA: 0x0025ECD4 File Offset: 0x0025CED4
		public Span<byte> GetMarkStageNameBytes()
		{
			return this.__p.__vector_as_span<byte>(30, 1);
		}

		// Token: 0x06008362 RID: 33634 RVA: 0x0025ECE4 File Offset: 0x0025CEE4
		public byte[] GetMarkStageNameArray()
		{
			return this.__p.__vector_as_array<byte>(30) ?? Array.Empty<byte>();
		}

		// Token: 0x170018F7 RID: 6391
		// (get) Token: 0x06008363 RID: 33635 RVA: 0x0025ECFC File Offset: 0x0025CEFC
		public string BuildSuccessDes
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008364 RID: 33636 RVA: 0x0025ED34 File Offset: 0x0025CF34
		public Span<byte> GetBuildSuccessDesBytes()
		{
			return this.__p.__vector_as_span<byte>(32, 1);
		}

		// Token: 0x06008365 RID: 33637 RVA: 0x0025ED44 File Offset: 0x0025CF44
		public byte[] GetBuildSuccessDesArray()
		{
			return this.__p.__vector_as_array<byte>(32) ?? Array.Empty<byte>();
		}

		// Token: 0x170018F8 RID: 6392
		// (get) Token: 0x06008366 RID: 33638 RVA: 0x0025ED5C File Offset: 0x0025CF5C
		public string ScenePath
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008367 RID: 33639 RVA: 0x0025ED94 File Offset: 0x0025CF94
		public Span<byte> GetScenePathBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x06008368 RID: 33640 RVA: 0x0025EDA4 File Offset: 0x0025CFA4
		public byte[] GetScenePathArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x170018F9 RID: 6393
		// (get) Token: 0x06008369 RID: 33641 RVA: 0x0025EDBC File Offset: 0x0025CFBC
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170018FA RID: 6394
		// (get) Token: 0x0600836A RID: 33642 RVA: 0x0025EDFC File Offset: 0x0025CFFC
		public string VideoName
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600836B RID: 33643 RVA: 0x0025EE34 File Offset: 0x0025D034
		public Span<byte> GetVideoNameBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x0600836C RID: 33644 RVA: 0x0025EE44 File Offset: 0x0025D044
		public byte[] GetVideoNameArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x170018FB RID: 6395
		// (get) Token: 0x0600836D RID: 33645 RVA: 0x0025EE5C File Offset: 0x0025D05C
		public string VideoPath
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600836E RID: 33646 RVA: 0x0025EE94 File Offset: 0x0025D094
		public Span<byte> GetVideoPathBytes()
		{
			return this.__p.__vector_as_span<byte>(40, 1);
		}

		// Token: 0x0600836F RID: 33647 RVA: 0x0025EEA4 File Offset: 0x0025D0A4
		public byte[] GetVideoPathArray()
		{
			return this.__p.__vector_as_array<byte>(40) ?? Array.Empty<byte>();
		}

		// Token: 0x06008370 RID: 33648 RVA: 0x0025EEBC File Offset: 0x0025D0BC
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectDesIter()或GetEffectDesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EffectDes()
		{
			return this.EffectDesIter().ToArray<string>();
		}

		// Token: 0x06008371 RID: 33649 RVA: 0x0025EEC9 File Offset: 0x0025D0C9
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectDesIter()
		{
			InfrLevel.<EffectDesIter>d__71 <EffectDesIter>d__ = new InfrLevel.<EffectDesIter>d__71(-2);
			<EffectDesIter>d__.<>3__<>4__this = this;
			return <EffectDesIter>d__;
		}

		// Token: 0x06008372 RID: 33650 RVA: 0x0025EEDE File Offset: 0x0025D0DE
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestDescriptionsIter()或GetQuestDescriptionsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] QuestDescriptions()
		{
			return this.QuestDescriptionsIter().ToArray<string>();
		}

		// Token: 0x06008373 RID: 33651 RVA: 0x0025EEEB File Offset: 0x0025D0EB
		[NullableContext(1)]
		public readonly IEnumerable<string> QuestDescriptionsIter()
		{
			InfrLevel.<QuestDescriptionsIter>d__73 <QuestDescriptionsIter>d__ = new InfrLevel.<QuestDescriptionsIter>d__73(-2);
			<QuestDescriptionsIter>d__.<>3__<>4__this = this;
			return <QuestDescriptionsIter>d__;
		}

		// Token: 0x06008374 RID: 33652 RVA: 0x0025EF00 File Offset: 0x0025D100
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用QuestIdsIter()或GetQuestIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] QuestIds()
		{
			InfrLevel infrLevel = this;
			return infrLevel.GetQuestIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x06008375 RID: 33653 RVA: 0x0025EF24 File Offset: 0x0025D124
		[NullableContext(1)]
		public readonly IEnumerable<int> QuestIdsIter()
		{
			InfrLevel.<QuestIdsIter>d__75 <QuestIdsIter>d__ = new InfrLevel.<QuestIdsIter>d__75(-2);
			<QuestIdsIter>d__.<>3__<>4__this = this;
			return <QuestIdsIter>d__;
		}

		// Token: 0x06008376 RID: 33654 RVA: 0x0025EF3C File Offset: 0x0025D13C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RequirementFrozenDict()缓存字典，遍历请使用RequirementIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Requirement()
		{
			return this.RequirementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x06008377 RID: 33655 RVA: 0x0025EF92 File Offset: 0x0025D192
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RequirementIter()
		{
			InfrLevel.<RequirementIter>d__77 <RequirementIter>d__ = new InfrLevel.<RequirementIter>d__77(-2);
			<RequirementIter>d__.<>3__<>4__this = this;
			return <RequirementIter>d__;
		}

		// Token: 0x06008378 RID: 33656 RVA: 0x0025EFA8 File Offset: 0x0025D1A8
		public int? GetRequirement(int key)
		{
			this.EnsureRequirementCacheIfNeeded();
			int value;
			if (!this.RequirementCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x06008379 RID: 33657 RVA: 0x0025EFDC File Offset: 0x0025D1DC
		private void EnsureRequirementCacheIfNeeded()
		{
			if (this.RequirementCache != null)
			{
				return;
			}
			this.RequirementCache = this.RequirementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600837A RID: 33658 RVA: 0x0025F042 File Offset: 0x0025D242
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRequirementFrozenDict(int key)
		{
			this.EnsureRequirementCacheIfNeeded();
			return this.RequirementCache;
		}

		// Token: 0x04004DE4 RID: 19940
		private Table __p;

		// Token: 0x04004DE5 RID: 19941
		[Nullable(2)]
		private FrozenDictionary<int, int> RequirementCache;
	}
}
