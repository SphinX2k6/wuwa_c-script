using System;
using System.Collections.Frozen;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Google.FlatBuffers;

namespace Aki.Config
{
	// Token: 0x020011BA RID: 4538
	public struct SkillFollowerButton : IFlatbufferObject
	{
		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600DC8B RID: 56459 RVA: 0x003356E3 File Offset: 0x003338E3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0600DC8C RID: 56460 RVA: 0x003356F0 File Offset: 0x003338F0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0600DC8D RID: 56461 RVA: 0x003356F8 File Offset: 0x003338F8
		public static SkillFollowerButton GetRootAsSkillFollowerButton(ByteBuffer _bb)
		{
			return SkillFollowerButton.GetRootAsSkillFollowerButton(_bb, default(SkillFollowerButton));
		}

		// Token: 0x0600DC8E RID: 56462 RVA: 0x00335714 File Offset: 0x00333914
		public static SkillFollowerButton GetRootAsSkillFollowerButton(ByteBuffer _bb, SkillFollowerButton obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0600DC8F RID: 56463 RVA: 0x00335731 File Offset: 0x00333931
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0600DC90 RID: 56464 RVA: 0x00335740 File Offset: 0x00333940
		public SkillFollowerButton __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600DC91 RID: 56465 RVA: 0x00335750 File Offset: 0x00333950
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

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600DC92 RID: 56466 RVA: 0x0033578C File Offset: 0x0033398C
		public int PbDataId
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

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600DC93 RID: 56467 RVA: 0x003357C8 File Offset: 0x003339C8
		public string Name
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

		// Token: 0x0600DC94 RID: 56468 RVA: 0x003357FF File Offset: 0x003339FF
		public Span<byte> GetNameBytes()
		{
			return this.__p.__vector_as_span<byte>(8, 1);
		}

		// Token: 0x0600DC95 RID: 56469 RVA: 0x0033580E File Offset: 0x00333A0E
		public byte[] GetNameArray()
		{
			return this.__p.__vector_as_array<byte>(8) ?? Array.Empty<byte>();
		}

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600DC96 RID: 56470 RVA: 0x00335828 File Offset: 0x00333A28
		public int ButtonType
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

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0600DC97 RID: 56471 RVA: 0x00335868 File Offset: 0x00333A68
		public int ActionType
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

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600DC98 RID: 56472 RVA: 0x003358A8 File Offset: 0x00333AA8
		public int SkillId
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

		// Token: 0x0600DC99 RID: 56473 RVA: 0x003358E8 File Offset: 0x00333AE8
		public DicIntInt? SkillIdTagMap(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600DC9A RID: 56474 RVA: 0x0033594C File Offset: 0x00333B4C
		public int SkillIdTagMapLength
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

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600DC9B RID: 56475 RVA: 0x00335978 File Offset: 0x00333B78
		public string SkillIcon
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

		// Token: 0x0600DC9C RID: 56476 RVA: 0x003359B0 File Offset: 0x00333BB0
		public Span<byte> GetSkillIconBytes()
		{
			return this.__p.__vector_as_span<byte>(18, 1);
		}

		// Token: 0x0600DC9D RID: 56477 RVA: 0x003359C0 File Offset: 0x00333BC0
		public byte[] GetSkillIconArray()
		{
			return this.__p.__vector_as_array<byte>(18) ?? Array.Empty<byte>();
		}

		// Token: 0x0600DC9E RID: 56478 RVA: 0x003359D8 File Offset: 0x00333BD8
		public int SkillIconTags(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600DC9F RID: 56479 RVA: 0x00335A18 File Offset: 0x00333C18
		public int SkillIconTagsLength
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

		// Token: 0x0600DCA0 RID: 56480 RVA: 0x00335A44 File Offset: 0x00333C44
		public Span<int> GetSkillIconTagsBytes()
		{
			return this.__p.__vector_as_span<int>(20, 4);
		}

		// Token: 0x0600DCA1 RID: 56481 RVA: 0x00335A54 File Offset: 0x00333C54
		public int[] GetSkillIconTagsArray()
		{
			return this.__p.__vector_as_array<int>(20) ?? Array.Empty<int>();
		}

		// Token: 0x0600DCA2 RID: 56482 RVA: 0x00335A6C File Offset: 0x00333C6C
		public int DisableTags(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600DCA3 RID: 56483 RVA: 0x00335AAC File Offset: 0x00333CAC
		public int DisableTagsLength
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

		// Token: 0x0600DCA4 RID: 56484 RVA: 0x00335AD8 File Offset: 0x00333CD8
		public Span<int> GetDisableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(22, 4);
		}

		// Token: 0x0600DCA5 RID: 56485 RVA: 0x00335AE8 File Offset: 0x00333CE8
		public int[] GetDisableTagsArray()
		{
			return this.__p.__vector_as_array<int>(22) ?? Array.Empty<int>();
		}

		// Token: 0x0600DCA6 RID: 56486 RVA: 0x00335B00 File Offset: 0x00333D00
		public DicIntIntArray? DisableSkillIdTags(int j)
		{
			int num = this.__p.__offset(24);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600DCA7 RID: 56487 RVA: 0x00335B64 File Offset: 0x00333D64
		public int DisableSkillIdTagsLength
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

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600DCA8 RID: 56488 RVA: 0x00335B90 File Offset: 0x00333D90
		public bool IsVisible
		{
			get
			{
				int num = this.__p.__offset(26);
				return num == 0 || this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0600DCA9 RID: 56489 RVA: 0x00335BD0 File Offset: 0x00333DD0
		public int NotOccupyTags(int j)
		{
			int num = this.__p.__offset(28);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600DCAA RID: 56490 RVA: 0x00335C10 File Offset: 0x00333E10
		public int NotOccupyTagsLength
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

		// Token: 0x0600DCAB RID: 56491 RVA: 0x00335C3C File Offset: 0x00333E3C
		public Span<int> GetNotOccupyTagsBytes()
		{
			return this.__p.__vector_as_span<int>(28, 4);
		}

		// Token: 0x0600DCAC RID: 56492 RVA: 0x00335C4C File Offset: 0x00333E4C
		public int[] GetNotOccupyTagsArray()
		{
			return this.__p.__vector_as_array<int>(28) ?? Array.Empty<int>();
		}

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600DCAD RID: 56493 RVA: 0x00335C64 File Offset: 0x00333E64
		public int ElementId
		{
			get
			{
				int num = this.__p.__offset(30);
				if (num == 0)
				{
					return 1;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600DCAE RID: 56494 RVA: 0x00335CA4 File Offset: 0x00333EA4
		public int AttributeId
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

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600DCAF RID: 56495 RVA: 0x00335CE4 File Offset: 0x00333EE4
		public int MaxAttributeId
		{
			get
			{
				int num = this.__p.__offset(34);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0600DCB0 RID: 56496 RVA: 0x00335D24 File Offset: 0x00333F24
		public DicIntIntArray? AttributeIdTagMap(int j)
		{
			int num = this.__p.__offset(36);
			if (num == 0)
			{
				return null;
			}
			return new DicIntIntArray?(default(DicIntIntArray).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600DCB1 RID: 56497 RVA: 0x00335D88 File Offset: 0x00333F88
		public int AttributeIdTagMapLength
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

		// Token: 0x0600DCB2 RID: 56498 RVA: 0x00335DB4 File Offset: 0x00333FB4
		public int AttributeEnableTags(int j)
		{
			int num = this.__p.__offset(38);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600DCB3 RID: 56499 RVA: 0x00335DF4 File Offset: 0x00333FF4
		public int AttributeEnableTagsLength
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

		// Token: 0x0600DCB4 RID: 56500 RVA: 0x00335E20 File Offset: 0x00334020
		public Span<int> GetAttributeEnableTagsBytes()
		{
			return this.__p.__vector_as_span<int>(38, 4);
		}

		// Token: 0x0600DCB5 RID: 56501 RVA: 0x00335E30 File Offset: 0x00334030
		public int[] GetAttributeEnableTagsArray()
		{
			return this.__p.__vector_as_array<int>(38) ?? Array.Empty<int>();
		}

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600DCB6 RID: 56502 RVA: 0x00335E48 File Offset: 0x00334048
		public bool IsLongPressControlCamera
		{
			get
			{
				int num = this.__p.__offset(40);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600DCB7 RID: 56503 RVA: 0x00335E88 File Offset: 0x00334088
		public int LongPressTime
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

		// Token: 0x0600DCB8 RID: 56504 RVA: 0x00335EC8 File Offset: 0x003340C8
		public DicIntInt? DynamicEffectTagMap(int j)
		{
			int num = this.__p.__offset(44);
			if (num == 0)
			{
				return null;
			}
			return new DicIntInt?(default(DicIntInt).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600DCB9 RID: 56505 RVA: 0x00335F2C File Offset: 0x0033412C
		public int DynamicEffectTagMapLength
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

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0600DCBA RID: 56506 RVA: 0x00335F58 File Offset: 0x00334158
		public int CustomHandleId
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

		// Token: 0x0600DCBB RID: 56507 RVA: 0x00335F98 File Offset: 0x00334198
		public int CustomHandleIds(int j)
		{
			int num = this.__p.__offset(48);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0600DCBC RID: 56508 RVA: 0x00335FD8 File Offset: 0x003341D8
		public int CustomHandleIdsLength
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

		// Token: 0x0600DCBD RID: 56509 RVA: 0x00336004 File Offset: 0x00334204
		public Span<int> GetCustomHandleIdsBytes()
		{
			return this.__p.__vector_as_span<int>(48, 4);
		}

		// Token: 0x0600DCBE RID: 56510 RVA: 0x00336014 File Offset: 0x00334214
		public int[] GetCustomHandleIdsArray()
		{
			return this.__p.__vector_as_array<int>(48) ?? Array.Empty<int>();
		}

		// Token: 0x0600DCBF RID: 56511 RVA: 0x0033602C File Offset: 0x0033422C
		[NullableContext(1)]
		public int[] AttributeEnableTags()
		{
			return this.GetAttributeEnableTagsArray();
		}

		// Token: 0x0600DCC0 RID: 56512 RVA: 0x00336034 File Offset: 0x00334234
		[NullableContext(1)]
		public IEnumerable<int> AttributeEnableTagsIter()
		{
			SkillFollowerButton.<AttributeEnableTagsIter>d__78 <AttributeEnableTagsIter>d__ = new SkillFollowerButton.<AttributeEnableTagsIter>d__78(-2);
			<AttributeEnableTagsIter>d__.<>3__<>4__this = this;
			return <AttributeEnableTagsIter>d__;
		}

		// Token: 0x0600DCC1 RID: 56513 RVA: 0x0033604C File Offset: 0x0033424C
		[NullableContext(1)]
		public Dictionary<int, IntArray> AttributeIdTagMap()
		{
			return this.AttributeIdTagMapIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DCC2 RID: 56514 RVA: 0x003360A2 File Offset: 0x003342A2
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> AttributeIdTagMapIter()
		{
			SkillFollowerButton.<AttributeIdTagMapIter>d__80 <AttributeIdTagMapIter>d__ = new SkillFollowerButton.<AttributeIdTagMapIter>d__80(-2);
			<AttributeIdTagMapIter>d__.<>3__<>4__this = this;
			return <AttributeIdTagMapIter>d__;
		}

		// Token: 0x0600DCC3 RID: 56515 RVA: 0x003360B7 File Offset: 0x003342B7
		[NullableContext(1)]
		public int[] CustomHandleIds()
		{
			return this.GetCustomHandleIdsArray();
		}

		// Token: 0x0600DCC4 RID: 56516 RVA: 0x003360BF File Offset: 0x003342BF
		[NullableContext(1)]
		public IEnumerable<int> CustomHandleIdsIter()
		{
			SkillFollowerButton.<CustomHandleIdsIter>d__82 <CustomHandleIdsIter>d__ = new SkillFollowerButton.<CustomHandleIdsIter>d__82(-2);
			<CustomHandleIdsIter>d__.<>3__<>4__this = this;
			return <CustomHandleIdsIter>d__;
		}

		// Token: 0x0600DCC5 RID: 56517 RVA: 0x003360D4 File Offset: 0x003342D4
		[NullableContext(1)]
		public Dictionary<int, IntArray> DisableSkillIdTags()
		{
			return this.DisableSkillIdTagsIter().ToDictionary((DicIntIntArray element) => element.Key, (DicIntIntArray element) => element.Value.Value);
		}

		// Token: 0x0600DCC6 RID: 56518 RVA: 0x0033612A File Offset: 0x0033432A
		[NullableContext(1)]
		public IEnumerable<DicIntIntArray> DisableSkillIdTagsIter()
		{
			SkillFollowerButton.<DisableSkillIdTagsIter>d__84 <DisableSkillIdTagsIter>d__ = new SkillFollowerButton.<DisableSkillIdTagsIter>d__84(-2);
			<DisableSkillIdTagsIter>d__.<>3__<>4__this = this;
			return <DisableSkillIdTagsIter>d__;
		}

		// Token: 0x0600DCC7 RID: 56519 RVA: 0x0033613F File Offset: 0x0033433F
		[NullableContext(1)]
		public int[] DisableTags()
		{
			return this.GetDisableTagsArray();
		}

		// Token: 0x0600DCC8 RID: 56520 RVA: 0x00336147 File Offset: 0x00334347
		[NullableContext(1)]
		public IEnumerable<int> DisableTagsIter()
		{
			SkillFollowerButton.<DisableTagsIter>d__86 <DisableTagsIter>d__ = new SkillFollowerButton.<DisableTagsIter>d__86(-2);
			<DisableTagsIter>d__.<>3__<>4__this = this;
			return <DisableTagsIter>d__;
		}

		// Token: 0x0600DCC9 RID: 56521 RVA: 0x0033615C File Offset: 0x0033435C
		[NullableContext(1)]
		public Dictionary<int, int> DynamicEffectTagMap()
		{
			return this.DynamicEffectTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DCCA RID: 56522 RVA: 0x003361B2 File Offset: 0x003343B2
		[NullableContext(1)]
		public IEnumerable<DicIntInt> DynamicEffectTagMapIter()
		{
			SkillFollowerButton.<DynamicEffectTagMapIter>d__88 <DynamicEffectTagMapIter>d__ = new SkillFollowerButton.<DynamicEffectTagMapIter>d__88(-2);
			<DynamicEffectTagMapIter>d__.<>3__<>4__this = this;
			return <DynamicEffectTagMapIter>d__;
		}

		// Token: 0x0600DCCB RID: 56523 RVA: 0x003361C7 File Offset: 0x003343C7
		[NullableContext(1)]
		public int[] NotOccupyTags()
		{
			return this.GetNotOccupyTagsArray();
		}

		// Token: 0x0600DCCC RID: 56524 RVA: 0x003361CF File Offset: 0x003343CF
		[NullableContext(1)]
		public IEnumerable<int> NotOccupyTagsIter()
		{
			SkillFollowerButton.<NotOccupyTagsIter>d__90 <NotOccupyTagsIter>d__ = new SkillFollowerButton.<NotOccupyTagsIter>d__90(-2);
			<NotOccupyTagsIter>d__.<>3__<>4__this = this;
			return <NotOccupyTagsIter>d__;
		}

		// Token: 0x0600DCCD RID: 56525 RVA: 0x003361E4 File Offset: 0x003343E4
		[NullableContext(1)]
		public int[] SkillIconTags()
		{
			return this.GetSkillIconTagsArray();
		}

		// Token: 0x0600DCCE RID: 56526 RVA: 0x003361EC File Offset: 0x003343EC
		[NullableContext(1)]
		public IEnumerable<int> SkillIconTagsIter()
		{
			SkillFollowerButton.<SkillIconTagsIter>d__92 <SkillIconTagsIter>d__ = new SkillFollowerButton.<SkillIconTagsIter>d__92(-2);
			<SkillIconTagsIter>d__.<>3__<>4__this = this;
			return <SkillIconTagsIter>d__;
		}

		// Token: 0x0600DCCF RID: 56527 RVA: 0x00336204 File Offset: 0x00334404
		[NullableContext(1)]
		public Dictionary<int, int> SkillIdTagMap()
		{
			return this.SkillIdTagMapIter().ToDictionary((DicIntInt element) => element.Key, (DicIntInt element) => element.Value);
		}

		// Token: 0x0600DCD0 RID: 56528 RVA: 0x0033625A File Offset: 0x0033445A
		[NullableContext(1)]
		public IEnumerable<DicIntInt> SkillIdTagMapIter()
		{
			SkillFollowerButton.<SkillIdTagMapIter>d__94 <SkillIdTagMapIter>d__ = new SkillFollowerButton.<SkillIdTagMapIter>d__94(-2);
			<SkillIdTagMapIter>d__.<>3__<>4__this = this;
			return <SkillIdTagMapIter>d__;
		}

		// Token: 0x0600DCD1 RID: 56529 RVA: 0x00336270 File Offset: 0x00334470
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

		// Token: 0x0600DCD2 RID: 56530 RVA: 0x003362A4 File Offset: 0x003344A4
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

		// Token: 0x0600DCD3 RID: 56531 RVA: 0x003362D8 File Offset: 0x003344D8
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

		// Token: 0x0600DCD4 RID: 56532 RVA: 0x0033630C File Offset: 0x0033450C
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

		// Token: 0x0600DCD5 RID: 56533 RVA: 0x00336340 File Offset: 0x00334540
		private void EnsureAttributeIdTagMapCacheIfNeeded()
		{
			if (this.AttributeIdTagMapCache != null)
			{
				return;
			}
			this.AttributeIdTagMapCache = this.AttributeIdTagMapIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DCD6 RID: 56534 RVA: 0x003363A8 File Offset: 0x003345A8
		private void EnsureDisableSkillIdTagsCacheIfNeeded()
		{
			if (this.DisableSkillIdTagsCache != null)
			{
				return;
			}
			this.DisableSkillIdTagsCache = this.DisableSkillIdTagsIter().ToFrozenDictionary((DicIntIntArray kvp) => kvp.Key, (DicIntIntArray kvp) => kvp.Value.Value, null);
		}

		// Token: 0x0600DCD7 RID: 56535 RVA: 0x00336410 File Offset: 0x00334610
		private void EnsureDynamicEffectTagMapCacheIfNeeded()
		{
			if (this.DynamicEffectTagMapCache != null)
			{
				return;
			}
			this.DynamicEffectTagMapCache = this.DynamicEffectTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DCD8 RID: 56536 RVA: 0x00336478 File Offset: 0x00334678
		private void EnsureSkillIdTagMapCacheIfNeeded()
		{
			if (this.SkillIdTagMapCache != null)
			{
				return;
			}
			this.SkillIdTagMapCache = this.SkillIdTagMapIter().ToFrozenDictionary((DicIntInt kvp) => kvp.Key, (DicIntInt kvp) => kvp.Value, null);
		}

		// Token: 0x0600DCD9 RID: 56537 RVA: 0x003364DE File Offset: 0x003346DE
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetAttributeIdTagMapFrozenDict()
		{
			this.EnsureAttributeIdTagMapCacheIfNeeded();
			return this.AttributeIdTagMapCache;
		}

		// Token: 0x0600DCDA RID: 56538 RVA: 0x003364EC File Offset: 0x003346EC
		[NullableContext(1)]
		public FrozenDictionary<int, IntArray> GetDisableSkillIdTagsFrozenDict()
		{
			this.EnsureDisableSkillIdTagsCacheIfNeeded();
			return this.DisableSkillIdTagsCache;
		}

		// Token: 0x0600DCDB RID: 56539 RVA: 0x003364FA File Offset: 0x003346FA
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetDynamicEffectTagMapFrozenDict()
		{
			this.EnsureDynamicEffectTagMapCacheIfNeeded();
			return this.DynamicEffectTagMapCache;
		}

		// Token: 0x0600DCDC RID: 56540 RVA: 0x00336508 File Offset: 0x00334708
		[NullableContext(1)]
		public FrozenDictionary<int, int> GetSkillIdTagMapFrozenDict()
		{
			this.EnsureSkillIdTagMapCacheIfNeeded();
			return this.SkillIdTagMapCache;
		}

		// Token: 0x040057E3 RID: 22499
		private Table __p;

		// Token: 0x040057E4 RID: 22500
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> AttributeIdTagMapCache;

		// Token: 0x040057E5 RID: 22501
		[Nullable(2)]
		private FrozenDictionary<int, IntArray> DisableSkillIdTagsCache;

		// Token: 0x040057E6 RID: 22502
		[Nullable(2)]
		private FrozenDictionary<int, int> DynamicEffectTagMapCache;

		// Token: 0x040057E7 RID: 22503
		[Nullable(2)]
		private FrozenDictionary<int, int> SkillIdTagMapCache;
	}
}
