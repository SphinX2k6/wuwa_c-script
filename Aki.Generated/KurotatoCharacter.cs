using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x02000E7C RID: 3708
	public struct KurotatoCharacter : IFlatbufferObject
	{
		// Token: 0x17001B87 RID: 7047
		// (get) Token: 0x06008ED7 RID: 36567 RVA: 0x0028AD8C File Offset: 0x00288F8C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06008ED8 RID: 36568 RVA: 0x0028AD99 File Offset: 0x00288F99
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06008ED9 RID: 36569 RVA: 0x0028ADA0 File Offset: 0x00288FA0
		public static KurotatoCharacter GetRootAsKurotatoCharacter(ByteBuffer _bb)
		{
			return KurotatoCharacter.GetRootAsKurotatoCharacter(_bb, default(KurotatoCharacter));
		}

		// Token: 0x06008EDA RID: 36570 RVA: 0x0028ADBC File Offset: 0x00288FBC
		public static KurotatoCharacter GetRootAsKurotatoCharacter(ByteBuffer _bb, KurotatoCharacter obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06008EDB RID: 36571 RVA: 0x0028ADD9 File Offset: 0x00288FD9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06008EDC RID: 36572 RVA: 0x0028ADE8 File Offset: 0x00288FE8
		public KurotatoCharacter __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17001B88 RID: 7048
		// (get) Token: 0x06008EDD RID: 36573 RVA: 0x0028ADF8 File Offset: 0x00288FF8
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

		// Token: 0x17001B89 RID: 7049
		// (get) Token: 0x06008EDE RID: 36574 RVA: 0x0028AE34 File Offset: 0x00289034
		public int ActivityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 3401;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B8A RID: 7050
		// (get) Token: 0x06008EDF RID: 36575 RVA: 0x0028AE74 File Offset: 0x00289074
		public int BasicProperty
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

		// Token: 0x17001B8B RID: 7051
		// (get) Token: 0x06008EE0 RID: 36576 RVA: 0x0028AEB0 File Offset: 0x002890B0
		public int TemplateId
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

		// Token: 0x17001B8C RID: 7052
		// (get) Token: 0x06008EE1 RID: 36577 RVA: 0x0028AEF0 File Offset: 0x002890F0
		public int UnlockConditionId
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

		// Token: 0x06008EE2 RID: 36578 RVA: 0x0028AF30 File Offset: 0x00289130
		public int InitItemIds(int j)
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B8D RID: 7053
		// (get) Token: 0x06008EE3 RID: 36579 RVA: 0x0028AF70 File Offset: 0x00289170
		public int InitItemIdsLength
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

		// Token: 0x06008EE4 RID: 36580 RVA: 0x0028AF9C File Offset: 0x0028919C
		public Span<int> GetInitItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(14, 4);
		}

		// Token: 0x06008EE5 RID: 36581 RVA: 0x0028AFAC File Offset: 0x002891AC
		public int[] GetInitItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(14) ?? Array.Empty<int>();
		}

		// Token: 0x06008EE6 RID: 36582 RVA: 0x0028AFC4 File Offset: 0x002891C4
		public int InitWeaponIds(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B8E RID: 7054
		// (get) Token: 0x06008EE7 RID: 36583 RVA: 0x0028B004 File Offset: 0x00289204
		public int InitWeaponIdsLength
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

		// Token: 0x06008EE8 RID: 36584 RVA: 0x0028B030 File Offset: 0x00289230
		public Span<int> GetInitWeaponIdsBytes()
		{
			return this.__p.__vector_as_span<int>(16, 4);
		}

		// Token: 0x06008EE9 RID: 36585 RVA: 0x0028B040 File Offset: 0x00289240
		public int[] GetInitWeaponIdsArray()
		{
			return this.__p.__vector_as_array<int>(16) ?? Array.Empty<int>();
		}

		// Token: 0x17001B8F RID: 7055
		// (get) Token: 0x06008EEA RID: 36586 RVA: 0x0028B058 File Offset: 0x00289258
		public string Name
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

		// Token: 0x06008EEB RID: 36587 RVA: 0x0028B090 File Offset: 0x00289290
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x06008EEC RID: 36588 RVA: 0x0028B0A0 File Offset: 0x002892A0
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B90 RID: 7056
		// (get) Token: 0x06008EED RID: 36589 RVA: 0x0028B0B8 File Offset: 0x002892B8
		public int SortId
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B91 RID: 7057
		// (get) Token: 0x06008EEE RID: 36590 RVA: 0x0028B0F8 File Offset: 0x002892F8
		public string Desc
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

		// Token: 0x06008EEF RID: 36591 RVA: 0x0028B130 File Offset: 0x00289330
		public Span<byte> GetDescBytes()
		{
			return this.__p.__vector_as_span<byte>(22, 1);
		}

		// Token: 0x06008EF0 RID: 36592 RVA: 0x0028B140 File Offset: 0x00289340
		public byte[] GetDescArray()
		{
			return this.__p.__vector_as_array<byte>(22) ?? Array.Empty<byte>();
		}

		// Token: 0x06008EF1 RID: 36593 RVA: 0x0028B158 File Offset: 0x00289358
		public string DescParams(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B92 RID: 7058
		// (get) Token: 0x06008EF2 RID: 36594 RVA: 0x0028B194 File Offset: 0x00289394
		public int DescParamsLength
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

		// Token: 0x17001B93 RID: 7059
		// (get) Token: 0x06008EF3 RID: 36595 RVA: 0x0028B1C0 File Offset: 0x002893C0
		public string Icon
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

		// Token: 0x06008EF4 RID: 36596 RVA: 0x0028B1F8 File Offset: 0x002893F8
		public Span<byte> GetIconBytes()
		{
			return this.__p.__vector_as_span<byte>(26, 1);
		}

		// Token: 0x06008EF5 RID: 36597 RVA: 0x0028B208 File Offset: 0x00289408
		public byte[] GetIconArray()
		{
			return this.__p.__vector_as_array<byte>(26) ?? Array.Empty<byte>();
		}

		// Token: 0x17001B94 RID: 7060
		// (get) Token: 0x06008EF6 RID: 36598 RVA: 0x0028B220 File Offset: 0x00289420
		public int RelatedCharacterId
		{
			get
			{
				int num = this.__p.__offset(28);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17001B95 RID: 7061
		// (get) Token: 0x06008EF7 RID: 36599 RVA: 0x0028B260 File Offset: 0x00289460
		public int TrialRole
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

		// Token: 0x17001B96 RID: 7062
		// (get) Token: 0x06008EF8 RID: 36600 RVA: 0x0028B2A0 File Offset: 0x002894A0
		public int Type
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

		// Token: 0x06008EF9 RID: 36601 RVA: 0x0028B2E0 File Offset: 0x002894E0
		public string ExcludedTags(int j)
		{
			int num = this.__p.__offset(34);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06008EFA RID: 36602 RVA: 0x0028B31C File Offset: 0x0028951C
		public int ExcludedTagsLength
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

		// Token: 0x06008EFB RID: 36603 RVA: 0x0028B348 File Offset: 0x00289548
		public string RecommendedTags(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B98 RID: 7064
		// (get) Token: 0x06008EFC RID: 36604 RVA: 0x0028B384 File Offset: 0x00289584
		public int RecommendedTagsLength
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

		// Token: 0x06008EFD RID: 36605 RVA: 0x0028B3B0 File Offset: 0x002895B0
		public int ExcludedRecommendWeaponIds(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B99 RID: 7065
		// (get) Token: 0x06008EFE RID: 36606 RVA: 0x0028B3F0 File Offset: 0x002895F0
		public int ExcludedRecommendWeaponIdsLength
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

		// Token: 0x06008EFF RID: 36607 RVA: 0x0028B41C File Offset: 0x0028961C
		public Span<int> GetExcludedRecommendWeaponIdsBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x06008F00 RID: 36608 RVA: 0x0028B42C File Offset: 0x0028962C
		public int[] GetExcludedRecommendWeaponIdsArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x06008F01 RID: 36609 RVA: 0x0028B444 File Offset: 0x00289644
		public int ExcludedRecommendItemIds(int j)
		{
			int num = this.__p.__offset(40);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06008F02 RID: 36610 RVA: 0x0028B484 File Offset: 0x00289684
		public int ExcludedRecommendItemIdsLength
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

		// Token: 0x06008F03 RID: 36611 RVA: 0x0028B4B0 File Offset: 0x002896B0
		public Span<int> GetExcludedRecommendItemIdsBytes()
		{
			return this.__p.__vector_as_span<int>(40, 4);
		}

		// Token: 0x06008F04 RID: 36612 RVA: 0x0028B4C0 File Offset: 0x002896C0
		public int[] GetExcludedRecommendItemIdsArray()
		{
			return this.__p.__vector_as_array<int>(40) ?? Array.Empty<int>();
		}

		// Token: 0x17001B9B RID: 7067
		// (get) Token: 0x06008F05 RID: 36613 RVA: 0x0028B4D8 File Offset: 0x002896D8
		public int SimpleCombatSubtypeId
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

		// Token: 0x06008F06 RID: 36614 RVA: 0x0028B518 File Offset: 0x00289718
		public int InitBuffs(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9C RID: 7068
		// (get) Token: 0x06008F07 RID: 36615 RVA: 0x0028B558 File Offset: 0x00289758
		public int InitBuffsLength
		{
			get
			{
				int num = this.__p.__offset(44);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F08 RID: 36616 RVA: 0x0028B584 File Offset: 0x00289784
		public Span<int> GetInitBuffsBytes()
		{
			return this.__p.__vector_as_span<int>(44, 4);
		}

		// Token: 0x06008F09 RID: 36617 RVA: 0x0028B594 File Offset: 0x00289794
		public int[] GetInitBuffsArray()
		{
			return this.__p.__vector_as_array<int>(44) ?? Array.Empty<int>();
		}

		// Token: 0x06008F0A RID: 36618 RVA: 0x0028B5AC File Offset: 0x002897AC
		public int MainProperty(int j)
		{
			int num = this.__p.__offset(46);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06008F0B RID: 36619 RVA: 0x0028B5EC File Offset: 0x002897EC
		public int MainPropertyLength
		{
			get
			{
				int num = this.__p.__offset(46);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06008F0C RID: 36620 RVA: 0x0028B618 File Offset: 0x00289818
		public Span<int> GetMainPropertyBytes()
		{
			return this.__p.__vector_as_span<int>(46, 4);
		}

		// Token: 0x06008F0D RID: 36621 RVA: 0x0028B628 File Offset: 0x00289828
		public int[] GetMainPropertyArray()
		{
			return this.__p.__vector_as_array<int>(46) ?? Array.Empty<int>();
		}

		// Token: 0x17001B9E RID: 7070
		// (get) Token: 0x06008F0E RID: 36622 RVA: 0x0028B640 File Offset: 0x00289840
		public int JumpLevelId
		{
			get
			{
				int num = this.__p.__offset(48);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06008F0F RID: 36623 RVA: 0x0028B67D File Offset: 0x0028987D
		[NullableContext(1)]
		public string[] DescParams()
		{
			return this.DescParamsIter().ToArray<string>();
		}

		// Token: 0x06008F10 RID: 36624 RVA: 0x0028B68A File Offset: 0x0028988A
		[NullableContext(1)]
		public IEnumerable<string> DescParamsIter()
		{
			KurotatoCharacter.<DescParamsIter>d__82 <DescParamsIter>d__ = new KurotatoCharacter.<DescParamsIter>d__82(-2);
			<DescParamsIter>d__.<>3__<>4__this = this;
			return <DescParamsIter>d__;
		}

		// Token: 0x06008F11 RID: 36625 RVA: 0x0028B69F File Offset: 0x0028989F
		[NullableContext(1)]
		public int[] ExcludedRecommendItemIds()
		{
			return this.GetExcludedRecommendItemIdsArray();
		}

		// Token: 0x06008F12 RID: 36626 RVA: 0x0028B6A7 File Offset: 0x002898A7
		[NullableContext(1)]
		public IEnumerable<int> ExcludedRecommendItemIdsIter()
		{
			KurotatoCharacter.<ExcludedRecommendItemIdsIter>d__84 <ExcludedRecommendItemIdsIter>d__ = new KurotatoCharacter.<ExcludedRecommendItemIdsIter>d__84(-2);
			<ExcludedRecommendItemIdsIter>d__.<>3__<>4__this = this;
			return <ExcludedRecommendItemIdsIter>d__;
		}

		// Token: 0x06008F13 RID: 36627 RVA: 0x0028B6BC File Offset: 0x002898BC
		[NullableContext(1)]
		public int[] ExcludedRecommendWeaponIds()
		{
			return this.GetExcludedRecommendWeaponIdsArray();
		}

		// Token: 0x06008F14 RID: 36628 RVA: 0x0028B6C4 File Offset: 0x002898C4
		[NullableContext(1)]
		public IEnumerable<int> ExcludedRecommendWeaponIdsIter()
		{
			KurotatoCharacter.<ExcludedRecommendWeaponIdsIter>d__86 <ExcludedRecommendWeaponIdsIter>d__ = new KurotatoCharacter.<ExcludedRecommendWeaponIdsIter>d__86(-2);
			<ExcludedRecommendWeaponIdsIter>d__.<>3__<>4__this = this;
			return <ExcludedRecommendWeaponIdsIter>d__;
		}

		// Token: 0x06008F15 RID: 36629 RVA: 0x0028B6D9 File Offset: 0x002898D9
		[NullableContext(1)]
		public string[] ExcludedTags()
		{
			return this.ExcludedTagsIter().ToArray<string>();
		}

		// Token: 0x06008F16 RID: 36630 RVA: 0x0028B6E6 File Offset: 0x002898E6
		[NullableContext(1)]
		public IEnumerable<string> ExcludedTagsIter()
		{
			KurotatoCharacter.<ExcludedTagsIter>d__88 <ExcludedTagsIter>d__ = new KurotatoCharacter.<ExcludedTagsIter>d__88(-2);
			<ExcludedTagsIter>d__.<>3__<>4__this = this;
			return <ExcludedTagsIter>d__;
		}

		// Token: 0x06008F17 RID: 36631 RVA: 0x0028B6FB File Offset: 0x002898FB
		[NullableContext(1)]
		public int[] InitBuffs()
		{
			return this.GetInitBuffsArray();
		}

		// Token: 0x06008F18 RID: 36632 RVA: 0x0028B703 File Offset: 0x00289903
		[NullableContext(1)]
		public IEnumerable<int> InitBuffsIter()
		{
			KurotatoCharacter.<InitBuffsIter>d__90 <InitBuffsIter>d__ = new KurotatoCharacter.<InitBuffsIter>d__90(-2);
			<InitBuffsIter>d__.<>3__<>4__this = this;
			return <InitBuffsIter>d__;
		}

		// Token: 0x06008F19 RID: 36633 RVA: 0x0028B718 File Offset: 0x00289918
		[NullableContext(1)]
		public int[] InitItemIds()
		{
			return this.GetInitItemIdsArray();
		}

		// Token: 0x06008F1A RID: 36634 RVA: 0x0028B720 File Offset: 0x00289920
		[NullableContext(1)]
		public IEnumerable<int> InitItemIdsIter()
		{
			KurotatoCharacter.<InitItemIdsIter>d__92 <InitItemIdsIter>d__ = new KurotatoCharacter.<InitItemIdsIter>d__92(-2);
			<InitItemIdsIter>d__.<>3__<>4__this = this;
			return <InitItemIdsIter>d__;
		}

		// Token: 0x06008F1B RID: 36635 RVA: 0x0028B735 File Offset: 0x00289935
		[NullableContext(1)]
		public int[] InitWeaponIds()
		{
			return this.GetInitWeaponIdsArray();
		}

		// Token: 0x06008F1C RID: 36636 RVA: 0x0028B73D File Offset: 0x0028993D
		[NullableContext(1)]
		public IEnumerable<int> InitWeaponIdsIter()
		{
			KurotatoCharacter.<InitWeaponIdsIter>d__94 <InitWeaponIdsIter>d__ = new KurotatoCharacter.<InitWeaponIdsIter>d__94(-2);
			<InitWeaponIdsIter>d__.<>3__<>4__this = this;
			return <InitWeaponIdsIter>d__;
		}

		// Token: 0x06008F1D RID: 36637 RVA: 0x0028B752 File Offset: 0x00289952
		[NullableContext(1)]
		public int[] MainProperty()
		{
			return this.GetMainPropertyArray();
		}

		// Token: 0x06008F1E RID: 36638 RVA: 0x0028B75A File Offset: 0x0028995A
		[NullableContext(1)]
		public IEnumerable<int> MainPropertyIter()
		{
			KurotatoCharacter.<MainPropertyIter>d__96 <MainPropertyIter>d__ = new KurotatoCharacter.<MainPropertyIter>d__96(-2);
			<MainPropertyIter>d__.<>3__<>4__this = this;
			return <MainPropertyIter>d__;
		}

		// Token: 0x06008F1F RID: 36639 RVA: 0x0028B76F File Offset: 0x0028996F
		[NullableContext(1)]
		public string[] RecommendedTags()
		{
			return this.RecommendedTagsIter().ToArray<string>();
		}

		// Token: 0x06008F20 RID: 36640 RVA: 0x0028B77C File Offset: 0x0028997C
		[NullableContext(1)]
		public IEnumerable<string> RecommendedTagsIter()
		{
			KurotatoCharacter.<RecommendedTagsIter>d__98 <RecommendedTagsIter>d__ = new KurotatoCharacter.<RecommendedTagsIter>d__98(-2);
			<RecommendedTagsIter>d__.<>3__<>4__this = this;
			return <RecommendedTagsIter>d__;
		}

		// Token: 0x0400540C RID: 21516
		private Table __p;
	}
}
