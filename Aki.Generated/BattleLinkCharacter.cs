using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000B28 RID: 2856
	public struct BattleLinkCharacter : IFlatbufferObject
	{
		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06004C40 RID: 19520 RVA: 0x001E1118 File Offset: 0x001DF318
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06004C41 RID: 19521 RVA: 0x001E1125 File Offset: 0x001DF325
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06004C42 RID: 19522 RVA: 0x001E112C File Offset: 0x001DF32C
		public static BattleLinkCharacter GetRootAsBattleLinkCharacter(ByteBuffer _bb)
		{
			return BattleLinkCharacter.GetRootAsBattleLinkCharacter(_bb, default(BattleLinkCharacter));
		}

		// Token: 0x06004C43 RID: 19523 RVA: 0x001E1148 File Offset: 0x001DF348
		public static BattleLinkCharacter GetRootAsBattleLinkCharacter(ByteBuffer _bb, BattleLinkCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06004C44 RID: 19524 RVA: 0x001E1165 File Offset: 0x001DF365
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06004C45 RID: 19525 RVA: 0x001E1174 File Offset: 0x001DF374
		public BattleLinkCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06004C46 RID: 19526 RVA: 0x001E1184 File Offset: 0x001DF384
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

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06004C47 RID: 19527 RVA: 0x001E11C0 File Offset: 0x001DF3C0
		public int NeedLoadMesh
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

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06004C48 RID: 19528 RVA: 0x001E11FC File Offset: 0x001DF3FC
		public string CharacterDataAsset
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

		// Token: 0x06004C49 RID: 19529 RVA: 0x001E1233 File Offset: 0x001DF433
		public Span<byte> GetCharacterDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x06004C4A RID: 19530 RVA: 0x001E1242 File Offset: 0x001DF442
		public byte[] GetCharacterDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06004C4B RID: 19531 RVA: 0x001E125C File Offset: 0x001DF45C
		public string Seq
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

		// Token: 0x06004C4C RID: 19532 RVA: 0x001E1294 File Offset: 0x001DF494
		public Span<byte> GetSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x06004C4D RID: 19533 RVA: 0x001E12A4 File Offset: 0x001DF4A4
		public byte[] GetSeqArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06004C4E RID: 19534 RVA: 0x001E12BC File Offset: 0x001DF4BC
		public string Pose
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004C4F RID: 19535 RVA: 0x001E12F4 File Offset: 0x001DF4F4
		public Span<byte> GetPoseBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06004C50 RID: 19536 RVA: 0x001E1304 File Offset: 0x001DF504
		public byte[] GetPoseArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06004C51 RID: 19537 RVA: 0x001E131C File Offset: 0x001DF51C
		public string RogueSkillIcon
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

		// Token: 0x06004C52 RID: 19538 RVA: 0x001E1354 File Offset: 0x001DF554
		public Span<byte> GetRogueSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06004C53 RID: 19539 RVA: 0x001E1364 File Offset: 0x001DF564
		public byte[] GetRogueSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06004C54 RID: 19540 RVA: 0x001E137C File Offset: 0x001DF57C
		public string RogueSkillDesc
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

		// Token: 0x06004C55 RID: 19541 RVA: 0x001E13B4 File Offset: 0x001DF5B4
		public Span<byte> GetRogueSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06004C56 RID: 19542 RVA: 0x001E13C4 File Offset: 0x001DF5C4
		public byte[] GetRogueSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06004C57 RID: 19543 RVA: 0x001E13DC File Offset: 0x001DF5DC
		public string RogueSkillDescParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06004C58 RID: 19544 RVA: 0x001E1418 File Offset: 0x001DF618
		public int RogueSkillDescParamLength
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

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06004C59 RID: 19545 RVA: 0x001E1444 File Offset: 0x001DF644
		public string RogueSkillTitle
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06004C5A RID: 19546 RVA: 0x001E147C File Offset: 0x001DF67C
		public Span<byte> GetRogueSkillTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x06004C5B RID: 19547 RVA: 0x001E148C File Offset: 0x001DF68C
		public byte[] GetRogueSkillTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06004C5C RID: 19548 RVA: 0x001E14A4 File Offset: 0x001DF6A4
		public string RoleLinkAudio
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

		// Token: 0x06004C5D RID: 19549 RVA: 0x001E14DC File Offset: 0x001DF6DC
		public Span<byte> GetRoleLinkAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06004C5E RID: 19550 RVA: 0x001E14EC File Offset: 0x001DF6EC
		public byte[] GetRoleLinkAudioArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06004C5F RID: 19551 RVA: 0x001E1504 File Offset: 0x001DF704
		public int FormationSkillList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06004C60 RID: 19552 RVA: 0x001E1544 File Offset: 0x001DF744
		public int FormationSkillListLength
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

		// Token: 0x06004C61 RID: 19553 RVA: 0x001E1570 File Offset: 0x001DF770
		public Span<int> GetFormationSkillListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06004C62 RID: 19554 RVA: 0x001E1580 File Offset: 0x001DF780
		public int[] GetFormationSkillListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06004C63 RID: 19555 RVA: 0x001E1598 File Offset: 0x001DF798
		public bool IsShowInTeamView
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06004C64 RID: 19556 RVA: 0x001E15D8 File Offset: 0x001DF7D8
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用FormationSkillListIter()或GetFormationSkillListBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly int[] FormationSkillList()
		{
			BattleLinkCharacter battleLinkCharacter = this;
			return battleLinkCharacter.GetFormationSkillListArray() ?? Array.Empty<int>();
		}

		// Token: 0x06004C65 RID: 19557 RVA: 0x001E15FC File Offset: 0x001DF7FC
		[NullableContext(1)]
		public readonly IEnumerable<int> FormationSkillListIter()
		{
			BattleLinkCharacter.<FormationSkillListIter>d__51 <FormationSkillListIter>d__ = new BattleLinkCharacter.<FormationSkillListIter>d__51(-2);
			<FormationSkillListIter>d__.<>3__<>4__this = this;
			return <FormationSkillListIter>d__;
		}

		// Token: 0x06004C66 RID: 19558 RVA: 0x001E1611 File Offset: 0x001DF811
		[NullableContext(1)]
		[Obsolete("本方法用于缓存,遍历请使用RogueSkillDescParamIter()或GetRogueSkillDescParamBytes()版本", UrlFormat = "https://kurogame.feishu.cn/wiki/QnadwbnC4i3zsmktEDgcBWuOnJb")]
		public readonly string[] RogueSkillDescParam()
		{
			return this.RogueSkillDescParamIter().ToArray<string>();
		}

		// Token: 0x06004C67 RID: 19559 RVA: 0x001E161E File Offset: 0x001DF81E
		[NullableContext(1)]
		public readonly IEnumerable<string> RogueSkillDescParamIter()
		{
			BattleLinkCharacter.<RogueSkillDescParamIter>d__53 <RogueSkillDescParamIter>d__ = new BattleLinkCharacter.<RogueSkillDescParamIter>d__53(-2);
			<RogueSkillDescParamIter>d__.<>3__<>4__this = this;
			return <RogueSkillDescParamIter>d__;
		}

		// Token: 0x04004B1A RID: 19226
		private Table __p;
	}
}
