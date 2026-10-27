using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020010BC RID: 4284
	public struct SkillCommonButton : IFlatbufferObject
	{
		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600D421 RID: 54305 RVA: 0x00314C91 File Offset: 0x00312E91
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600D422 RID: 54306 RVA: 0x00314C9E File Offset: 0x00312E9E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600D423 RID: 54307 RVA: 0x00314CA8 File Offset: 0x00312EA8
		public static SkillCommonButton GetRootAsSkillCommonButton(ByteBuffer _bb)
		{
			return SkillCommonButton.GetRootAsSkillCommonButton(_bb, default(SkillCommonButton));
		}

		// Token: 0x0600D424 RID: 54308 RVA: 0x00314CC4 File Offset: 0x00312EC4
		public static SkillCommonButton GetRootAsSkillCommonButton(ByteBuffer _bb, SkillCommonButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600D425 RID: 54309 RVA: 0x00314CE1 File Offset: 0x00312EE1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600D426 RID: 54310 RVA: 0x00314CF0 File Offset: 0x00312EF0
		public SkillCommonButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600D427 RID: 54311 RVA: 0x00314D00 File Offset: 0x00312F00
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

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600D428 RID: 54312 RVA: 0x00314D3C File Offset: 0x00312F3C
		public string Name
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

		// Token: 0x0600D429 RID: 54313 RVA: 0x00314D73 File Offset: 0x00312F73
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(6, 1);
		}

		// Token: 0x0600D42A RID: 54314 RVA: 0x00314D82 File Offset: 0x00312F82
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(6) ?? Array.Empty<byte>();
		}

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600D42B RID: 54315 RVA: 0x00314D9C File Offset: 0x00312F9C
		public int ButtonType
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

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600D42C RID: 54316 RVA: 0x00314DD8 File Offset: 0x00312FD8
		public int ActionType
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

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600D42D RID: 54317 RVA: 0x00314E18 File Offset: 0x00313018
		public int SkillId
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

		// Token: 0x0600D42E RID: 54318 RVA: 0x00314E58 File Offset: 0x00313058
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600D42F RID: 54319 RVA: 0x00314EBC File Offset: 0x003130BC
		public int SkillIdTagMapLength
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

		// Token: 0x0600D430 RID: 54320 RVA: 0x00314EE8 File Offset: 0x003130E8
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600D431 RID: 54321 RVA: 0x00314F28 File Offset: 0x00313128
		public int SkillIconTagsLength
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

		// Token: 0x0600D432 RID: 54322 RVA: 0x00314F54 File Offset: 0x00313154
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x00314F64 File Offset: 0x00313164
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x00314F7C File Offset: 0x0031317C
		public int EnableTags(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600D435 RID: 54325 RVA: 0x00314FBC File Offset: 0x003131BC
		public int EnableTagsLength
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

		// Token: 0x0600D436 RID: 54326 RVA: 0x00314FE8 File Offset: 0x003131E8
		public Span<int> GetEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(18, 4);
		}

		// Token: 0x0600D437 RID: 54327 RVA: 0x00314FF8 File Offset: 0x003131F8
		public int[] GetEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(18) ?? Array.Empty<int>();
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x00315010 File Offset: 0x00313210
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600D439 RID: 54329 RVA: 0x00315050 File Offset: 0x00313250
		public int DisableTagsLength
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

		// Token: 0x0600D43A RID: 54330 RVA: 0x0031507C File Offset: 0x0031327C
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600D43B RID: 54331 RVA: 0x0031508C File Offset: 0x0031328C
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600D43C RID: 54332 RVA: 0x003150A4 File Offset: 0x003132A4
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600D43D RID: 54333 RVA: 0x00315108 File Offset: 0x00313308
		public int DisableSkillIdTagsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D43E RID: 54334 RVA: 0x00315134 File Offset: 0x00313334
		public int VisibleTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600D43F RID: 54335 RVA: 0x00315174 File Offset: 0x00313374
		public int VisibleTagsLength
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

		// Token: 0x0600D440 RID: 54336 RVA: 0x003151A0 File Offset: 0x003133A0
		public Span<int> GetVisibleTagsBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x0600D441 RID: 54337 RVA: 0x003151B0 File Offset: 0x003133B0
		public int[] GetVisibleTagsArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x0600D442 RID: 54338 RVA: 0x003151C8 File Offset: 0x003133C8
		public int HiddenTags(int j)
		{
			int num = this.__p.__offset(26);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600D443 RID: 54339 RVA: 0x00315208 File Offset: 0x00313408
		public int HiddenTagsLength
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

		// Token: 0x0600D444 RID: 54340 RVA: 0x00315234 File Offset: 0x00313434
		public Span<int> GetHiddenTagsBytes()
		{
			return this.__p.__vector_as_span<int>(26, 4);
		}

		// Token: 0x0600D445 RID: 54341 RVA: 0x00315244 File Offset: 0x00313444
		public int[] GetHiddenTagsArray()
		{
			return this.__p.__vector_as_array<int>(26) ?? Array.Empty<int>();
		}

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600D446 RID: 54342 RVA: 0x0031525C File Offset: 0x0031345C
		public bool IsCdVisible
		{
			get
			{
				int num = this.__p.__offset(28);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600D447 RID: 54343 RVA: 0x0031529C File Offset: 0x0031349C
		public int AttributeId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600D448 RID: 54344 RVA: 0x003152DC File Offset: 0x003134DC
		public int MaxAttributeId
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D449 RID: 54345 RVA: 0x0031531C File Offset: 0x0031351C
		public DicIntIntArray? AttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600D44A RID: 54346 RVA: 0x00315380 File Offset: 0x00313580
		public int AttributeIdTagMapLength
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

		// Token: 0x0600D44B RID: 54347 RVA: 0x003153AC File Offset: 0x003135AC
		public int AttributeEnableTags(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600D44C RID: 54348 RVA: 0x003153EC File Offset: 0x003135EC
		public int AttributeEnableTagsLength
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D44D RID: 54349 RVA: 0x00315418 File Offset: 0x00313618
		public Span<int> GetAttributeEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(36, 4);
		}

		// Token: 0x0600D44E RID: 54350 RVA: 0x00315428 File Offset: 0x00313628
		public int[] GetAttributeEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(36) ?? Array.Empty<int>();
		}

		// Token: 0x0600D44F RID: 54351 RVA: 0x00315440 File Offset: 0x00313640
		public DicIntInt? FormationAttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600D450 RID: 54352 RVA: 0x003154A4 File Offset: 0x003136A4
		public int FormationAttributeIdTagMapLength
		{
			get
			{
				int num = this.__p.__offset(38);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600D451 RID: 54353 RVA: 0x003154D0 File Offset: 0x003136D0
		public int MaxAttributeBurstEffectId
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600D452 RID: 54354 RVA: 0x00315510 File Offset: 0x00313710
		public int CdCompletedEffectId
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600D453 RID: 54355 RVA: 0x00315550 File Offset: 0x00313750
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(44);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600D454 RID: 54356 RVA: 0x00315590 File Offset: 0x00313790
		public int LongPressTime
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D455 RID: 54357 RVA: 0x003155D0 File Offset: 0x003137D0
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600D456 RID: 54358 RVA: 0x00315634 File Offset: 0x00313834
		public int DynamicEffectTagMapLength
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D457 RID: 54359 RVA: 0x00315660 File Offset: 0x00313860
		public int ShowLongPressTags(int j)
		{
			int num = this.__p.__offset(50);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600D458 RID: 54360 RVA: 0x003156A0 File Offset: 0x003138A0
		public int ShowLongPressTagsLength
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D459 RID: 54361 RVA: 0x003156CC File Offset: 0x003138CC
		public Span<int> GetShowLongPressTagsBytes()
		{
			return this.__p.__vector_as_span<int>(50, 4);
		}

		// Token: 0x0600D45A RID: 54362 RVA: 0x003156DC File Offset: 0x003138DC
		public int[] GetShowLongPressTagsArray()
		{
			return this.__p.__vector_as_array<int>(50) ?? Array.Empty<int>();
		}

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600D45B RID: 54363 RVA: 0x003156F4 File Offset: 0x003138F4
		public int CustomHandleId
		{
			get
			{
				int num = this.__p.__offset(52);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600D45C RID: 54364 RVA: 0x00315734 File Offset: 0x00313934
		public int CustomHandleIds(int j)
		{
			int num = this.__p.__offset(54);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600D45D RID: 54365 RVA: 0x00315774 File Offset: 0x00313974
		public int CustomHandleIdsLength
		{
			get
			{
				int num = this.__p.__offset(54);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x003157A0 File Offset: 0x003139A0
		public Span<int> GetCustomHandleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(54, 4);
		}

		// Token: 0x0600D45F RID: 54367 RVA: 0x003157B0 File Offset: 0x003139B0
		public int[] GetCustomHandleIdsArray()
		{
			return this.__p.__vector_as_array<int>(54) ?? Array.Empty<int>();
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x003157C8 File Offset: 0x003139C8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用AttributeEnableTagsIter()或GetAttributeEnableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] AttributeEnableTags()
		{
			SkillCommonButton skillCommonButton = this;
			return skillCommonButton.GetAttributeEnableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D461 RID: 54369 RVA: 0x003157EC File Offset: 0x003139EC
		[NullableContext(1)]
		public readonly IEnumerable<int> AttributeEnableTagsIter()
		{
			SkillCommonButton.<AttributeEnableTagsIter>d__92 <AttributeEnableTagsIter>d__ = new SkillCommonButton.<AttributeEnableTagsIter>d__92(-2);
			<AttributeEnableTagsIter>d__.<>3__<>4__this = this;
			return <AttributeEnableTagsIter>d__;
		}

		// Token: 0x0600D462 RID: 54370 RVA: 0x00315804 File Offset: 0x00313A04
		[NullableContext(1)]
		[Obsolete("已废弃，请使用AttributeIdTagMapFrozenDict()缓存字典，遍历请使用AttributeIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> AttributeIdTagMap()
		{
			return this.AttributeIdTagMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D463 RID: 54371 RVA: 0x0031585A File Offset: 0x00313A5A
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> AttributeIdTagMapIter()
		{
			SkillCommonButton.<AttributeIdTagMapIter>d__94 <AttributeIdTagMapIter>d__ = new SkillCommonButton.<AttributeIdTagMapIter>d__94(-2);
			<AttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <AttributeIdTagMapIter>d__;
		}

		// Token: 0x0600D464 RID: 54372 RVA: 0x00315870 File Offset: 0x00313A70
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用CustomHandleIdsIter()或GetCustomHandleIdsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] CustomHandleIds()
		{
			SkillCommonButton skillCommonButton = this;
			return skillCommonButton.GetCustomHandleIdsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D465 RID: 54373 RVA: 0x00315894 File Offset: 0x00313A94
		[NullableContext(1)]
		public readonly IEnumerable<int> CustomHandleIdsIter()
		{
			SkillCommonButton.<CustomHandleIdsIter>d__96 <CustomHandleIdsIter>d__ = new SkillCommonButton.<CustomHandleIdsIter>d__96(-2);
			<CustomHandleIdsIter>d__.<>3__<>4__this = this;
			return <CustomHandleIdsIter>d__;
		}

		// Token: 0x0600D466 RID: 54374 RVA: 0x003158AC File Offset: 0x00313AAC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DisableSkillIdTagsFrozenDict()缓存字典，遍历请使用DisableSkillIdTagsIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600D467 RID: 54375 RVA: 0x00315902 File Offset: 0x00313B02
		[NullableContext(1)]
		public readonly IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillCommonButton.<DisableSkillIdTagsIter>d__98 <DisableSkillIdTagsIter>d__ = new SkillCommonButton.<DisableSkillIdTagsIter>d__98(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600D468 RID: 54376 RVA: 0x00315918 File Offset: 0x00313B18
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用DisableTagsIter()或GetDisableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] DisableTags()
		{
			SkillCommonButton skillCommonButton = this;
			return skillCommonButton.GetDisableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D469 RID: 54377 RVA: 0x0031593C File Offset: 0x00313B3C
		[NullableContext(1)]
		public readonly IEnumerable<int> DisableTagsIter()
		{
			SkillCommonButton.<DisableTagsIter>d__100 <DisableTagsIter>d__ = new SkillCommonButton.<DisableTagsIter>d__100(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600D46A RID: 54378 RVA: 0x00315954 File Offset: 0x00313B54
		[NullableContext(1)]
		[Obsolete("已废弃，请使用DynamicEffectTagMapFrozenDict()缓存字典，遍历请使用DynamicEffectTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D46B RID: 54379 RVA: 0x003159AA File Offset: 0x00313BAA
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillCommonButton.<DynamicEffectTagMapIter>d__102 <DynamicEffectTagMapIter>d__ = new SkillCommonButton.<DynamicEffectTagMapIter>d__102(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600D46C RID: 54380 RVA: 0x003159C0 File Offset: 0x00313BC0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EnableTagsIter()或GetEnableTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] EnableTags()
		{
			SkillCommonButton skillCommonButton = this;
			return skillCommonButton.GetEnableTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D46D RID: 54381 RVA: 0x003159E4 File Offset: 0x00313BE4
		[NullableContext(1)]
		public readonly IEnumerable<int> EnableTagsIter()
		{
			SkillCommonButton.<EnableTagsIter>d__104 <EnableTagsIter>d__ = new SkillCommonButton.<EnableTagsIter>d__104(-2);
			<EnableTagsIter>d__.<>3__<>4__this = this;
			return <EnableTagsIter>d__;
		}

		// Token: 0x0600D46E RID: 54382 RVA: 0x003159FC File Offset: 0x00313BFC
		[NullableContext(1)]
		[Obsolete("已废弃，请使用FormationAttributeIdTagMapFrozenDict()缓存字典，遍历请使用FormationAttributeIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> FormationAttributeIdTagMap()
		{
			return this.FormationAttributeIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D46F RID: 54383 RVA: 0x00315A52 File Offset: 0x00313C52
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> FormationAttributeIdTagMapIter()
		{
			SkillCommonButton.<FormationAttributeIdTagMapIter>d__106 <FormationAttributeIdTagMapIter>d__ = new SkillCommonButton.<FormationAttributeIdTagMapIter>d__106(-2);
			<FormationAttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <FormationAttributeIdTagMapIter>d__;
		}

		// Token: 0x0600D470 RID: 54384 RVA: 0x00315A68 File Offset: 0x00313C68
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用HiddenTagsIter()或GetHiddenTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] HiddenTags()
		{
			SkillCommonButton skillCommonButton = this;
			return skillCommonButton.GetHiddenTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D471 RID: 54385 RVA: 0x00315A8C File Offset: 0x00313C8C
		[NullableContext(1)]
		public readonly IEnumerable<int> HiddenTagsIter()
		{
			SkillCommonButton.<HiddenTagsIter>d__108 <HiddenTagsIter>d__ = new SkillCommonButton.<HiddenTagsIter>d__108(-2);
			<HiddenTagsIter>d__.<>3__<>4__this = this;
			return <HiddenTagsIter>d__;
		}

		// Token: 0x0600D472 RID: 54386 RVA: 0x00315AA4 File Offset: 0x00313CA4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用ShowLongPressTagsIter()或GetShowLongPressTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] ShowLongPressTags()
		{
			SkillCommonButton skillCommonButton = this;
			return skillCommonButton.GetShowLongPressTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D473 RID: 54387 RVA: 0x00315AC8 File Offset: 0x00313CC8
		[NullableContext(1)]
		public readonly IEnumerable<int> ShowLongPressTagsIter()
		{
			SkillCommonButton.<ShowLongPressTagsIter>d__110 <ShowLongPressTagsIter>d__ = new SkillCommonButton.<ShowLongPressTagsIter>d__110(-2);
			<ShowLongPressTagsIter>d__.<>3__<>4__this = this;
			return <ShowLongPressTagsIter>d__;
		}

		// Token: 0x0600D474 RID: 54388 RVA: 0x00315AE0 File Offset: 0x00313CE0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用SkillIconTagsIter()或GetSkillIconTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] SkillIconTags()
		{
			SkillCommonButton skillCommonButton = this;
			return skillCommonButton.GetSkillIconTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D475 RID: 54389 RVA: 0x00315B04 File Offset: 0x00313D04
		[NullableContext(1)]
		public readonly IEnumerable<int> SkillIconTagsIter()
		{
			SkillCommonButton.<SkillIconTagsIter>d__112 <SkillIconTagsIter>d__ = new SkillCommonButton.<SkillIconTagsIter>d__112(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600D476 RID: 54390 RVA: 0x00315B1C File Offset: 0x00313D1C
		[NullableContext(1)]
		[Obsolete("已废弃，请使用SkillIdTagMapFrozenDict()缓存字典，遍历请使用SkillIdTagMapIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600D477 RID: 54391 RVA: 0x00315B72 File Offset: 0x00313D72
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillCommonButton.<SkillIdTagMapIter>d__114 <SkillIdTagMapIter>d__ = new SkillCommonButton.<SkillIdTagMapIter>d__114(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600D478 RID: 54392 RVA: 0x00315B88 File Offset: 0x00313D88
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用VisibleTagsIter()或GetVisibleTagsBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] VisibleTags()
		{
			SkillCommonButton skillCommonButton = this;
			return skillCommonButton.GetVisibleTagsArray() ?? Array.Empty<int>();
		}

		// Token: 0x0600D479 RID: 54393 RVA: 0x00315BAC File Offset: 0x00313DAC
		[NullableContext(1)]
		public readonly IEnumerable<int> VisibleTagsIter()
		{
			SkillCommonButton.<VisibleTagsIter>d__116 <VisibleTagsIter>d__ = new SkillCommonButton.<VisibleTagsIter>d__116(-2);
			<VisibleTagsIter>d__.<>3__<>4__this = this;
			return <VisibleTagsIter>d__;
		}

		// Token: 0x0600D47A RID: 54394 RVA: 0x00315BC4 File Offset: 0x00313DC4
		public IntArray? GetAttributeIdTagMap(int key)
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			IntArray value;
			if (!this.AttributeIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D47B RID: 54395 RVA: 0x00315BF8 File Offset: 0x00313DF8
		public IntArray? GetDisableSkillIdTags(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			IntArray value;
			if (!this.DisableSkillIdTagsCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new IntArray?(value);
		}

		// Token: 0x0600D47C RID: 54396 RVA: 0x00315C2C File Offset: 0x00313E2C
		public int? GetDynamicEffectTagMap(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			int value;
			if (!this.DynamicEffectTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D47D RID: 54397 RVA: 0x00315C60 File Offset: 0x00313E60
		public int? GetFormationAttributeIdTagMap(int key)
		{
			this.EnsureFormationAttributeIdTagMapCacheIfNeeded();
			int value;
			if (!this.FormationAttributeIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D47E RID: 54398 RVA: 0x00315C94 File Offset: 0x00313E94
		public int? GetSkillIdTagMap(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			int value;
			if (!this.SkillIdTagMapCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x0600D47F RID: 54399 RVA: 0x00315CC8 File Offset: 0x00313EC8
		private void EnsureAttributeIdTagMapCacheIfNeeded()
		{
			if (this.AttributeIdTagMapCache != null)
			{
				return;
			}
			this.AttributeIdTagMapCache = this.AttributeIdTagMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D480 RID: 54400 RVA: 0x00315D30 File Offset: 0x00313F30
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600D481 RID: 54401 RVA: 0x00315D98 File Offset: 0x00313F98
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D482 RID: 54402 RVA: 0x00315E00 File Offset: 0x00314000
		private void EnsureFormationAttributeIdTagMapCacheIfNeeded()
		{
			if (this.FormationAttributeIdTagMapCache != null)
			{
				return;
			}
			this.FormationAttributeIdTagMapCache = this.FormationAttributeIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D483 RID: 54403 RVA: 0x00315E68 File Offset: 0x00314068
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600D484 RID: 54404 RVA: 0x00315ECE File Offset: 0x003140CE
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetAttributeIdTagMapFrozenDict(int key)
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			return this.AttributeIdTagMapCache;
		}

		// Token: 0x0600D485 RID: 54405 RVA: 0x00315EDC File Offset: 0x003140DC
		[NullableContext(2)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict(int key)
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600D486 RID: 54406 RVA: 0x00315EEA File Offset: 0x003140EA
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict(int key)
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600D487 RID: 54407 RVA: 0x00315EF8 File Offset: 0x003140F8
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetFormationAttributeIdTagMapFrozenDict(int key)
		{
			this.EnsureFormationAttributeIdTagMapCacheIfNeeded();
			return this.FormationAttributeIdTagMapCache;
		}

		// Token: 0x0600D488 RID: 54408 RVA: 0x00315F06 File Offset: 0x00314106
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict(int key)
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040051DB RID: 20955
		private Table __p;

		// Token: 0x040051DC RID: 20956
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> AttributeIdTagMapCache;

		// Token: 0x040051DD RID: 20957
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040051DE RID: 20958
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040051DF RID: 20959
		[Nullable(2)]
		private FrozenDictionary<int, int> FormationAttributeIdTagMapCache;

		// Token: 0x040051E0 RID: 20960
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
