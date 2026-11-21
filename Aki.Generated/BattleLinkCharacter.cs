using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000C08 RID: 3080
	public struct BattleLinkCharacter : IFlatbufferObject
	{
		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06005202 RID: 20994 RVA: 0x00201530 File Offset: 0x001FF730
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06005203 RID: 20995 RVA: 0x0020153D File Offset: 0x001FF73D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06005204 RID: 20996 RVA: 0x00201544 File Offset: 0x001FF744
		public static BattleLinkCharacter GetRootAsBattleLinkCharacter(ByteBuffer _bb)
		{
			return BattleLinkCharacter.GetRootAsBattleLinkCharacter(_bb, default(BattleLinkCharacter));
		}

		// Token: 0x06005205 RID: 20997 RVA: 0x00201560 File Offset: 0x001FF760
		public static BattleLinkCharacter GetRootAsBattleLinkCharacter(ByteBuffer _bb, BattleLinkCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06005206 RID: 20998 RVA: 0x0020157D File Offset: 0x001FF77D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06005207 RID: 20999 RVA: 0x0020158C File Offset: 0x001FF78C
		public BattleLinkCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06005208 RID: 21000 RVA: 0x0020159C File Offset: 0x001FF79C
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

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06005209 RID: 21001 RVA: 0x002015D8 File Offset: 0x001FF7D8
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

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x0600520A RID: 21002 RVA: 0x00201614 File Offset: 0x001FF814
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

		// Token: 0x0600520B RID: 21003 RVA: 0x0020164B File Offset: 0x001FF84B
		public Span<byte> GetCharacterDataAssetBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600520C RID: 21004 RVA: 0x0020165A File Offset: 0x001FF85A
		public byte[] GetCharacterDataAssetArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600520D RID: 21005 RVA: 0x00201674 File Offset: 0x001FF874
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

		// Token: 0x0600520E RID: 21006 RVA: 0x002016AC File Offset: 0x001FF8AC
		public Span<byte> GetSeqBytes()
		{
			return this.__p.__vector_as_span<byte>(10, 1);
		}

		// Token: 0x0600520F RID: 21007 RVA: 0x002016BC File Offset: 0x001FF8BC
		public byte[] GetSeqArray()
		{
			return this.__p.__vector_as_array<byte>(10) ?? Array.Empty<byte>();
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06005210 RID: 21008 RVA: 0x002016D4 File Offset: 0x001FF8D4
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

		// Token: 0x06005211 RID: 21009 RVA: 0x0020170C File Offset: 0x001FF90C
		public Span<byte> GetPoseBytes()
		{
			return this.__p.__vector_as_span<byte>(12, 1);
		}

		// Token: 0x06005212 RID: 21010 RVA: 0x0020171C File Offset: 0x001FF91C
		public byte[] GetPoseArray()
		{
			return this.__p.__vector_as_array<byte>(12) ?? Array.Empty<byte>();
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06005213 RID: 21011 RVA: 0x00201734 File Offset: 0x001FF934
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

		// Token: 0x06005214 RID: 21012 RVA: 0x0020176C File Offset: 0x001FF96C
		public Span<byte> GetRogueSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(14, 1);
		}

		// Token: 0x06005215 RID: 21013 RVA: 0x0020177C File Offset: 0x001FF97C
		public byte[] GetRogueSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(14) ?? Array.Empty<byte>();
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06005216 RID: 21014 RVA: 0x00201794 File Offset: 0x001FF994
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

		// Token: 0x06005217 RID: 21015 RVA: 0x002017CC File Offset: 0x001FF9CC
		public Span<byte> GetRogueSkillDescBytes()
		{
			return this.__p.__vector_as_span<byte>(16, 1);
		}

		// Token: 0x06005218 RID: 21016 RVA: 0x002017DC File Offset: 0x001FF9DC
		public byte[] GetRogueSkillDescArray()
		{
			return this.__p.__vector_as_array<byte>(16) ?? Array.Empty<byte>();
		}

		// Token: 0x06005219 RID: 21017 RVA: 0x002017F4 File Offset: 0x001FF9F4
		public string RogueSkillDescParam(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600521A RID: 21018 RVA: 0x00201830 File Offset: 0x001FFA30
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

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x0600521B RID: 21019 RVA: 0x0020185C File Offset: 0x001FFA5C
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

		// Token: 0x0600521C RID: 21020 RVA: 0x00201894 File Offset: 0x001FFA94
		public Span<byte> GetRogueSkillTitleBytes()
		{
			return this.__p.__vector_as_span<byte>(20, 1);
		}

		// Token: 0x0600521D RID: 21021 RVA: 0x002018A4 File Offset: 0x001FFAA4
		public byte[] GetRogueSkillTitleArray()
		{
			return this.__p.__vector_as_array<byte>(20) ?? Array.Empty<byte>();
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x0600521E RID: 21022 RVA: 0x002018BC File Offset: 0x001FFABC
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

		// Token: 0x0600521F RID: 21023 RVA: 0x002018F4 File Offset: 0x001FFAF4
		public Span<byte> GetRoleLinkAudioBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06005220 RID: 21024 RVA: 0x00201904 File Offset: 0x001FFB04
		public byte[] GetRoleLinkAudioArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06005221 RID: 21025 RVA: 0x0020191C File Offset: 0x001FFB1C
		public int FormationSkillList(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06005222 RID: 21026 RVA: 0x0020195C File Offset: 0x001FFB5C
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

		// Token: 0x06005223 RID: 21027 RVA: 0x00201988 File Offset: 0x001FFB88
		public Span<int> GetFormationSkillListBytes()
		{
			return this.__p.__vector_as_span<int>(24, 4);
		}

		// Token: 0x06005224 RID: 21028 RVA: 0x00201998 File Offset: 0x001FFB98
		public int[] GetFormationSkillListArray()
		{
			return this.__p.__vector_as_array<int>(24) ?? Array.Empty<int>();
		}

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06005225 RID: 21029 RVA: 0x002019B0 File Offset: 0x001FFBB0
		public bool IsShowInTeamView
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x06005226 RID: 21030 RVA: 0x002019F0 File Offset: 0x001FFBF0
		[NullableContext(1)]
		public int[] FormationSkillList()
		{
			return this.GetFormationSkillListArray();
		}

		// Token: 0x06005227 RID: 21031 RVA: 0x002019F8 File Offset: 0x001FFBF8
		[NullableContext(1)]
		public IEnumerable<int> FormationSkillListIter()
		{
			BattleLinkCharacter.<FormationSkillListIter>d__51 <FormationSkillListIter>d__ = new BattleLinkCharacter.<FormationSkillListIter>d__51(-2);
			<FormationSkillListIter>d__.<>3__<>4__this = this;
			return <FormationSkillListIter>d__;
		}

		// Token: 0x06005228 RID: 21032 RVA: 0x00201A0D File Offset: 0x001FFC0D
		[NullableContext(1)]
		public string[] RogueSkillDescParam()
		{
			return this.RogueSkillDescParamIter().ToArray<string>();
		}

		// Token: 0x06005229 RID: 21033 RVA: 0x00201A1A File Offset: 0x001FFC1A
		[NullableContext(1)]
		public IEnumerable<string> RogueSkillDescParamIter()
		{
			BattleLinkCharacter.<RogueSkillDescParamIter>d__53 <RogueSkillDescParamIter>d__ = new BattleLinkCharacter.<RogueSkillDescParamIter>d__53(-2);
			<RogueSkillDescParamIter>d__.<>3__<>4__this = this;
			return <RogueSkillDescParamIter>d__;
		}

		// Token: 0x040050FA RID: 20730
		private Table __p;
	}
}
