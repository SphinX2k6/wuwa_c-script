using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000D69 RID: 3433
	public struct InfrRoadBuild : IFlatbufferObject
	{
		// Token: 0x17001907 RID: 6407
		// (get) Token: 0x0600839B RID: 33691 RVA: 0x0025F3E0 File Offset: 0x0025D5E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600839C RID: 33692 RVA: 0x0025F3ED File Offset: 0x0025D5ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600839D RID: 33693 RVA: 0x0025F3F4 File Offset: 0x0025D5F4
		public static InfrRoadBuild GetRootAsInfrRoadBuild(ByteBuffer _bb)
		{
			return InfrRoadBuild.GetRootAsInfrRoadBuild(_bb, default(InfrRoadBuild));
		}

		// Token: 0x0600839E RID: 33694 RVA: 0x0025F410 File Offset: 0x0025D610
		public static InfrRoadBuild GetRootAsInfrRoadBuild(ByteBuffer _bb, InfrRoadBuild obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600839F RID: 33695 RVA: 0x0025F42D File Offset: 0x0025D62D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060083A0 RID: 33696 RVA: 0x0025F43C File Offset: 0x0025D63C
		public InfrRoadBuild __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001908 RID: 6408
		// (get) Token: 0x060083A1 RID: 33697 RVA: 0x0025F44C File Offset: 0x0025D64C
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

		// Token: 0x17001909 RID: 6409
		// (get) Token: 0x060083A2 RID: 33698 RVA: 0x0025F488 File Offset: 0x0025D688
		public int MarkId
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

		// Token: 0x1700190A RID: 6410
		// (get) Token: 0x060083A3 RID: 33699 RVA: 0x0025F4C4 File Offset: 0x0025D6C4
		public int DungeonId
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

		// Token: 0x1700190B RID: 6411
		// (get) Token: 0x060083A4 RID: 33700 RVA: 0x0025F500 File Offset: 0x0025D700
		public int ConditionId
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

		// Token: 0x1700190C RID: 6412
		// (get) Token: 0x060083A5 RID: 33701 RVA: 0x0025F540 File Offset: 0x0025D740
		public int BuildQuest
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

		// Token: 0x1700190D RID: 6413
		// (get) Token: 0x060083A6 RID: 33702 RVA: 0x0025F580 File Offset: 0x0025D780
		public int BuildConditionQuestId
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

		// Token: 0x1700190E RID: 6414
		// (get) Token: 0x060083A7 RID: 33703 RVA: 0x0025F5C0 File Offset: 0x0025D7C0
		public int JumpId
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700190F RID: 6415
		// (get) Token: 0x060083A8 RID: 33704 RVA: 0x0025F600 File Offset: 0x0025D800
		public int Difficulty
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060083A9 RID: 33705 RVA: 0x0025F640 File Offset: 0x0025D840
		public DicIntInt? Requirement(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001910 RID: 6416
		// (get) Token: 0x060083AA RID: 33706 RVA: 0x0025F6A4 File Offset: 0x0025D8A4
		public int RequirementLength
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

		// Token: 0x17001911 RID: 6417
		// (get) Token: 0x060083AB RID: 33707 RVA: 0x0025F6D0 File Offset: 0x0025D8D0
		public int FireExpReward
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001912 RID: 6418
		// (get) Token: 0x060083AC RID: 33708 RVA: 0x0025F710 File Offset: 0x0025D910
		public int GiftCount
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

		// Token: 0x17001913 RID: 6419
		// (get) Token: 0x060083AD RID: 33709 RVA: 0x0025F750 File Offset: 0x0025D950
		public int GiftCD
		{
			get
			{
				int num = this.__p.__offset(26);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060083AE RID: 33710 RVA: 0x0025F790 File Offset: 0x0025D990
		public DicIntInt? WeightPasser(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17001914 RID: 6420
		// (get) Token: 0x060083AF RID: 33711 RVA: 0x0025F7F4 File Offset: 0x0025D9F4
		public int WeightPasserLength
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060083B0 RID: 33712 RVA: 0x0025F820 File Offset: 0x0025DA20
		public int LoadDataLayers(int j)
		{
			int num = this.__p.__offset(30);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001915 RID: 6421
		// (get) Token: 0x060083B1 RID: 33713 RVA: 0x0025F860 File Offset: 0x0025DA60
		public int LoadDataLayersLength
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

		// Token: 0x060083B2 RID: 33714 RVA: 0x0025F88C File Offset: 0x0025DA8C
		public Span<int> GetLoadDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(30, 4);
		}

		// Token: 0x060083B3 RID: 33715 RVA: 0x0025F89C File Offset: 0x0025DA9C
		public int[] GetLoadDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(30) ?? Array.Empty<int>();
		}

		// Token: 0x060083B4 RID: 33716 RVA: 0x0025F8B4 File Offset: 0x0025DAB4
		public int UnloadDataLayers(int j)
		{
			int num = this.__p.__offset(32);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001916 RID: 6422
		// (get) Token: 0x060083B5 RID: 33717 RVA: 0x0025F8F4 File Offset: 0x0025DAF4
		public int UnloadDataLayersLength
		{
			get
			{
				int num = this.__p.__offset(32);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x060083B6 RID: 33718 RVA: 0x0025F920 File Offset: 0x0025DB20
		public Span<int> GetUnloadDataLayersBytes()
		{
			return this.__p.__vector_as_span<int>(32, 4);
		}

		// Token: 0x060083B7 RID: 33719 RVA: 0x0025F930 File Offset: 0x0025DB30
		public int[] GetUnloadDataLayersArray()
		{
			return this.__p.__vector_as_array<int>(32) ?? Array.Empty<int>();
		}

		// Token: 0x17001917 RID: 6423
		// (get) Token: 0x060083B8 RID: 33720 RVA: 0x0025F948 File Offset: 0x0025DB48
		public string Name
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

		// Token: 0x060083B9 RID: 33721 RVA: 0x0025F980 File Offset: 0x0025DB80
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(34, 1);
		}

		// Token: 0x060083BA RID: 33722 RVA: 0x0025F990 File Offset: 0x0025DB90
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(34) ?? Array.Empty<byte>();
		}

		// Token: 0x17001918 RID: 6424
		// (get) Token: 0x060083BB RID: 33723 RVA: 0x0025F9A8 File Offset: 0x0025DBA8
		public string Description
		{
			get
			{
				int num = this.__p.__offset(36);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060083BC RID: 33724 RVA: 0x0025F9E0 File Offset: 0x0025DBE0
		public Span<byte> GetDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(36, 1);
		}

		// Token: 0x060083BD RID: 33725 RVA: 0x0025F9F0 File Offset: 0x0025DBF0
		public byte[] GetDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(36) ?? Array.Empty<byte>();
		}

		// Token: 0x17001919 RID: 6425
		// (get) Token: 0x060083BE RID: 33726 RVA: 0x0025FA08 File Offset: 0x0025DC08
		public string BuildDoneDes
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

		// Token: 0x060083BF RID: 33727 RVA: 0x0025FA40 File Offset: 0x0025DC40
		public Span<byte> GetBuildDoneDesBytes()
		{
			return this.__p.__vector_as_span<byte>(38, 1);
		}

		// Token: 0x060083C0 RID: 33728 RVA: 0x0025FA50 File Offset: 0x0025DC50
		public byte[] GetBuildDoneDesArray()
		{
			return this.__p.__vector_as_array<byte>(38) ?? Array.Empty<byte>();
		}

		// Token: 0x060083C1 RID: 33729 RVA: 0x0025FA68 File Offset: 0x0025DC68
		public string EffectDes(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700191A RID: 6426
		// (get) Token: 0x060083C2 RID: 33730 RVA: 0x0025FAA4 File Offset: 0x0025DCA4
		public int EffectDesLength
		{
			get
			{
				int num = this.__p.__offset(40);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700191B RID: 6427
		// (get) Token: 0x060083C3 RID: 33731 RVA: 0x0025FAD0 File Offset: 0x0025DCD0
		public string BuildDoneEffectDes
		{
			get
			{
				int num = this.__p.__offset(42);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060083C4 RID: 33732 RVA: 0x0025FB08 File Offset: 0x0025DD08
		public Span<byte> GetBuildDoneEffectDesBytes()
		{
			return this.__p.__vector_as_span<byte>(42, 1);
		}

		// Token: 0x060083C5 RID: 33733 RVA: 0x0025FB18 File Offset: 0x0025DD18
		public byte[] GetBuildDoneEffectDesArray()
		{
			return this.__p.__vector_as_array<byte>(42) ?? Array.Empty<byte>();
		}

		// Token: 0x1700191C RID: 6428
		// (get) Token: 0x060083C6 RID: 33734 RVA: 0x0025FB30 File Offset: 0x0025DD30
		public string QuestDescription
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060083C7 RID: 33735 RVA: 0x0025FB68 File Offset: 0x0025DD68
		public Span<byte> GetQuestDescriptionBytes()
		{
			return this.__p.__vector_as_span<byte>(44, 1);
		}

		// Token: 0x060083C8 RID: 33736 RVA: 0x0025FB78 File Offset: 0x0025DD78
		public byte[] GetQuestDescriptionArray()
		{
			return this.__p.__vector_as_array<byte>(44) ?? Array.Empty<byte>();
		}

		// Token: 0x1700191D RID: 6429
		// (get) Token: 0x060083C9 RID: 33737 RVA: 0x0025FB90 File Offset: 0x0025DD90
		public int Length
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

		// Token: 0x1700191E RID: 6430
		// (get) Token: 0x060083CA RID: 33738 RVA: 0x0025FBD0 File Offset: 0x0025DDD0
		public string InfoPicturePath
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060083CB RID: 33739 RVA: 0x0025FC08 File Offset: 0x0025DE08
		public Span<byte> GetInfoPicturePathBytes()
		{
			return this.__p.__vector_as_span<byte>(48, 1);
		}

		// Token: 0x060083CC RID: 33740 RVA: 0x0025FC18 File Offset: 0x0025DE18
		public byte[] GetInfoPicturePathArray()
		{
			return this.__p.__vector_as_array<byte>(48) ?? Array.Empty<byte>();
		}

		// Token: 0x1700191F RID: 6431
		// (get) Token: 0x060083CD RID: 33741 RVA: 0x0025FC30 File Offset: 0x0025DE30
		public string BodyCameraSettingsName
		{
			get
			{
				int num = this.__p.__offset(50);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060083CE RID: 33742 RVA: 0x0025FC68 File Offset: 0x0025DE68
		public Span<byte> GetBodyCameraSettingsNameBytes()
		{
			return this.__p.__vector_as_span<byte>(50, 1);
		}

		// Token: 0x060083CF RID: 33743 RVA: 0x0025FC78 File Offset: 0x0025DE78
		public byte[] GetBodyCameraSettingsNameArray()
		{
			return this.__p.__vector_as_array<byte>(50) ?? Array.Empty<byte>();
		}

		// Token: 0x17001920 RID: 6432
		// (get) Token: 0x060083D0 RID: 33744 RVA: 0x0025FC90 File Offset: 0x0025DE90
		public bool DisableMark
		{
			get
			{
				int num = this.__p.__offset(52);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x060083D1 RID: 33745 RVA: 0x0025FCD0 File Offset: 0x0025DED0
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用EffectDesIter()或GetEffectDesBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] EffectDes()
		{
			return this.EffectDesIter().ToArray<string>();
		}

		// Token: 0x060083D2 RID: 33746 RVA: 0x0025FCDD File Offset: 0x0025DEDD
		[NullableContext(1)]
		public readonly IEnumerable<string> EffectDesIter()
		{
			InfrRoadBuild.<EffectDesIter>d__82 <EffectDesIter>d__ = new InfrRoadBuild.<EffectDesIter>d__82(-2);
			<EffectDesIter>d__.<>3__<>4__this = this;
			return <EffectDesIter>d__;
		}

		// Token: 0x060083D3 RID: 33747 RVA: 0x0025FCF4 File Offset: 0x0025DEF4
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用LoadDataLayersIter()或GetLoadDataLayersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] LoadDataLayers()
		{
			InfrRoadBuild infrRoadBuild = this;
			return infrRoadBuild.GetLoadDataLayersArray() ?? Array.Empty<int>();
		}

		// Token: 0x060083D4 RID: 33748 RVA: 0x0025FD18 File Offset: 0x0025DF18
		[NullableContext(1)]
		public readonly IEnumerable<int> LoadDataLayersIter()
		{
			InfrRoadBuild.<LoadDataLayersIter>d__84 <LoadDataLayersIter>d__ = new InfrRoadBuild.<LoadDataLayersIter>d__84(-2);
			<LoadDataLayersIter>d__.<>3__<>4__this = this;
			return <LoadDataLayersIter>d__;
		}

		// Token: 0x060083D5 RID: 33749 RVA: 0x0025FD30 File Offset: 0x0025DF30
		[NullableContext(1)]
		[Obsolete("已废弃，请使用RequirementFrozenDict()缓存字典，遍历请使用RequirementIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> Requirement()
		{
			return this.RequirementIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060083D6 RID: 33750 RVA: 0x0025FD86 File Offset: 0x0025DF86
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> RequirementIter()
		{
			InfrRoadBuild.<RequirementIter>d__86 <RequirementIter>d__ = new InfrRoadBuild.<RequirementIter>d__86(-2);
			<RequirementIter>d__.<>3__<>4__this = this;
			return <RequirementIter>d__;
		}

		// Token: 0x060083D7 RID: 33751 RVA: 0x0025FD9C File Offset: 0x0025DF9C
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用UnloadDataLayersIter()或GetUnloadDataLayersBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] UnloadDataLayers()
		{
			InfrRoadBuild infrRoadBuild = this;
			return infrRoadBuild.GetUnloadDataLayersArray() ?? Array.Empty<int>();
		}

		// Token: 0x060083D8 RID: 33752 RVA: 0x0025FDC0 File Offset: 0x0025DFC0
		[NullableContext(1)]
		public readonly IEnumerable<int> UnloadDataLayersIter()
		{
			InfrRoadBuild.<UnloadDataLayersIter>d__88 <UnloadDataLayersIter>d__ = new InfrRoadBuild.<UnloadDataLayersIter>d__88(-2);
			<UnloadDataLayersIter>d__.<>3__<>4__this = this;
			return <UnloadDataLayersIter>d__;
		}

		// Token: 0x060083D9 RID: 33753 RVA: 0x0025FDD8 File Offset: 0x0025DFD8
		[NullableContext(1)]
		[Obsolete("已废弃，请使用WeightPasserFrozenDict()缓存字典，遍历请使用WeightPasserIter()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly Dictionary<int, int> WeightPasser()
		{
			return this.WeightPasserIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x060083DA RID: 33754 RVA: 0x0025FE2E File Offset: 0x0025E02E
		[NullableContext(1)]
		public readonly IEnumerable<DicIntInt> WeightPasserIter()
		{
			InfrRoadBuild.<WeightPasserIter>d__90 <WeightPasserIter>d__ = new InfrRoadBuild.<WeightPasserIter>d__90(-2);
			<WeightPasserIter>d__.<>3__<>4__this = this;
			return <WeightPasserIter>d__;
		}

		// Token: 0x060083DB RID: 33755 RVA: 0x0025FE44 File Offset: 0x0025E044
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

		// Token: 0x060083DC RID: 33756 RVA: 0x0025FE78 File Offset: 0x0025E078
		public int? GetWeightPasser(int key)
		{
			this.EnsureWeightPasserCacheIfNeeded();
			int value;
			if (!this.WeightPasserCache.TryGetValue(key, out value))
			{
				return null;
			}
			return new int?(value);
		}

		// Token: 0x060083DD RID: 33757 RVA: 0x0025FEAC File Offset: 0x0025E0AC
		private void EnsureRequirementCacheIfNeeded()
		{
			if (this.RequirementCache != null)
			{
				return;
			}
			this.RequirementCache = this.RequirementIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060083DE RID: 33758 RVA: 0x0025FF14 File Offset: 0x0025E114
		private void EnsureWeightPasserCacheIfNeeded()
		{
			if (this.WeightPasserCache != null)
			{
				return;
			}
			this.WeightPasserCache = this.WeightPasserIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x060083DF RID: 33759 RVA: 0x0025FF7A File Offset: 0x0025E17A
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetRequirementFrozenDict(int key)
		{
			this.EnsureRequirementCacheIfNeeded();
			return this.RequirementCache;
		}

		// Token: 0x060083E0 RID: 33760 RVA: 0x0025FF88 File Offset: 0x0025E188
		[NullableContext(2)]
		public FrozenDictionary<int, int> GetWeightPasserFrozenDict(int key)
		{
			this.EnsureWeightPasserCacheIfNeeded();
			return this.WeightPasserCache;
		}

		// Token: 0x04004DE9 RID: 19945
		private Table __p;

		// Token: 0x04004DEA RID: 19946
		[Nullable(2)]
		private FrozenDictionary<int, int> RequirementCache;

		// Token: 0x04004DEB RID: 19947
		[Nullable(2)]
		private FrozenDictionary<int, int> WeightPasserCache;
	}
}
