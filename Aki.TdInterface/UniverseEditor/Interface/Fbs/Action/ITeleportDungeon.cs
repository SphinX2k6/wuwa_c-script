using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200737C RID: 29564
	public struct ITeleportDungeon : IFlatbufferObject
	{
		// Token: 0x1700E068 RID: 57448
		// (get) Token: 0x06035A6E RID: 219758 RVA: 0x0074E0C0 File Offset: 0x0074C2C0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035A6F RID: 219759 RVA: 0x0074E0CD File Offset: 0x0074C2CD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035A70 RID: 219760 RVA: 0x0074E0D4 File Offset: 0x0074C2D4
		public static ITeleportDungeon GetRootAsITeleportDungeon(ByteBuffer _bb)
		{
			return ITeleportDungeon.GetRootAsITeleportDungeon(_bb, default(ITeleportDungeon));
		}

		// Token: 0x06035A71 RID: 219761 RVA: 0x0074E0F0 File Offset: 0x0074C2F0
		public static ITeleportDungeon GetRootAsITeleportDungeon(ByteBuffer _bb, ITeleportDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035A72 RID: 219762 RVA: 0x0074E10D File Offset: 0x0074C30D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035A73 RID: 219763 RVA: 0x0074E11C File Offset: 0x0074C31C
		public ITeleportDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E069 RID: 57449
		// (get) Token: 0x06035A74 RID: 219764 RVA: 0x0074E12C File Offset: 0x0074C32C
		public int DungeonId
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

		// Token: 0x1700E06A RID: 57450
		// (get) Token: 0x06035A75 RID: 219765 RVA: 0x0074E168 File Offset: 0x0074C368
		public bool IsRegroup
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E06B RID: 57451
		// (get) Token: 0x06035A76 RID: 219766 RVA: 0x0074E1A8 File Offset: 0x0074C3A8
		public int LocationEntityId
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

		// Token: 0x1700E06C RID: 57452
		// (get) Token: 0x06035A77 RID: 219767 RVA: 0x0074E1E4 File Offset: 0x0074C3E4
		public TTeleportTransitionOption TransitionOptionType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A78 RID: 219768 RVA: 0x0074E224 File Offset: 0x0074C424
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035A79 RID: 219769 RVA: 0x0074E26C File Offset: 0x0074C46C
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06035A7A RID: 219770 RVA: 0x0074E288 File Offset: 0x0074C488
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06035A7B RID: 219771 RVA: 0x0074E2A4 File Offset: 0x0074C4A4
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06035A7C RID: 219772 RVA: 0x0074E2C0 File Offset: 0x0074C4C0
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06035A7D RID: 219773 RVA: 0x0074E2DC File Offset: 0x0074C4DC
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06035A7E RID: 219774 RVA: 0x0074E2F8 File Offset: 0x0074C4F8
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06035A7F RID: 219775 RVA: 0x0074E314 File Offset: 0x0074C514
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06035A80 RID: 219776 RVA: 0x0074E330 File Offset: 0x0074C530
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06035A81 RID: 219777 RVA: 0x0074E34C File Offset: 0x0074C54C
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06035A82 RID: 219778 RVA: 0x0074E368 File Offset: 0x0074C568
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06035A83 RID: 219779 RVA: 0x0074E384 File Offset: 0x0074C584
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700E06D RID: 57453
		// (get) Token: 0x06035A84 RID: 219780 RVA: 0x0074E3A0 File Offset: 0x0074C5A0
		public bool IsNeedSecondaryConfirmation
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E06E RID: 57454
		// (get) Token: 0x06035A85 RID: 219781 RVA: 0x0074E3E0 File Offset: 0x0074C5E0
		public bool UseLocationEntityGravity
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E06F RID: 57455
		// (get) Token: 0x06035A86 RID: 219782 RVA: 0x0074E420 File Offset: 0x0074C620
		public bool ContinueSave
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E070 RID: 57456
		// (get) Token: 0x06035A87 RID: 219783 RVA: 0x0074E460 File Offset: 0x0074C660
		public bool IsBanMapSound
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E071 RID: 57457
		// (get) Token: 0x06035A88 RID: 219784 RVA: 0x0074E4A0 File Offset: 0x0074C6A0
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035A89 RID: 219785 RVA: 0x0074E4E0 File Offset: 0x0074C6E0
		public static Offset<ITeleportDungeon> CreateITeleportDungeon(FlatBufferBuilder builder, int DungeonId = 0, bool IsRegroup = false, int LocationEntityId = 0, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0, bool IsNeedSecondaryConfirmation = false, bool UseLocationEntityGravity = false, bool ContinueSave = false, bool IsBanMapSound = false, byte NullMask = 0)
		{
			builder.StartTable(10);
			ITeleportDungeon.AddTransitionOption(builder, TransitionOptionOffset);
			ITeleportDungeon.AddLocationEntityId(builder, LocationEntityId);
			ITeleportDungeon.AddDungeonId(builder, DungeonId);
			ITeleportDungeon.AddNullMask(builder, NullMask);
			ITeleportDungeon.AddIsBanMapSound(builder, IsBanMapSound);
			ITeleportDungeon.AddContinueSave(builder, ContinueSave);
			ITeleportDungeon.AddUseLocationEntityGravity(builder, UseLocationEntityGravity);
			ITeleportDungeon.AddIsNeedSecondaryConfirmation(builder, IsNeedSecondaryConfirmation);
			ITeleportDungeon.AddTransitionOptionType(builder, TransitionOption_type);
			ITeleportDungeon.AddIsRegroup(builder, IsRegroup);
			return ITeleportDungeon.EndITeleportDungeon(builder);
		}

		// Token: 0x06035A8A RID: 219786 RVA: 0x0074E548 File Offset: 0x0074C748
		public static void StartITeleportDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06035A8B RID: 219787 RVA: 0x0074E552 File Offset: 0x0074C752
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(0, dungeonId, 0);
		}

		// Token: 0x06035A8C RID: 219788 RVA: 0x0074E55D File Offset: 0x0074C75D
		public static void AddIsRegroup(FlatBufferBuilder builder, bool isRegroup)
		{
			builder.AddBool(1, isRegroup, false);
		}

		// Token: 0x06035A8D RID: 219789 RVA: 0x0074E568 File Offset: 0x0074C768
		public static void AddLocationEntityId(FlatBufferBuilder builder, int locationEntityId)
		{
			builder.AddInt(2, locationEntityId, 0);
		}

		// Token: 0x06035A8E RID: 219790 RVA: 0x0074E573 File Offset: 0x0074C773
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(3, (byte)transitionOptionType, 0);
		}

		// Token: 0x06035A8F RID: 219791 RVA: 0x0074E57E File Offset: 0x0074C77E
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(4, transitionOptionOffset, 0);
		}

		// Token: 0x06035A90 RID: 219792 RVA: 0x0074E589 File Offset: 0x0074C789
		public static void AddIsNeedSecondaryConfirmation(FlatBufferBuilder builder, bool isNeedSecondaryConfirmation)
		{
			builder.AddBool(5, isNeedSecondaryConfirmation, false);
		}

		// Token: 0x06035A91 RID: 219793 RVA: 0x0074E594 File Offset: 0x0074C794
		public static void AddUseLocationEntityGravity(FlatBufferBuilder builder, bool useLocationEntityGravity)
		{
			builder.AddBool(6, useLocationEntityGravity, false);
		}

		// Token: 0x06035A92 RID: 219794 RVA: 0x0074E59F File Offset: 0x0074C79F
		public static void AddContinueSave(FlatBufferBuilder builder, bool continueSave)
		{
			builder.AddBool(7, continueSave, false);
		}

		// Token: 0x06035A93 RID: 219795 RVA: 0x0074E5AA File Offset: 0x0074C7AA
		public static void AddIsBanMapSound(FlatBufferBuilder builder, bool isBanMapSound)
		{
			builder.AddBool(8, isBanMapSound, false);
		}

		// Token: 0x06035A94 RID: 219796 RVA: 0x0074E5B5 File Offset: 0x0074C7B5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06035A95 RID: 219797 RVA: 0x0074E5C1 File Offset: 0x0074C7C1
		public static Offset<ITeleportDungeon> EndITeleportDungeon(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportDungeon>(builder.EndTable());
		}

		// Token: 0x06035A96 RID: 219798 RVA: 0x0074E5D0 File Offset: 0x0074C7D0
		public ITeleportDungeonT UnPack()
		{
			ITeleportDungeonT teleportDungeonT = new ITeleportDungeonT();
			this.UnPackTo(teleportDungeonT);
			return teleportDungeonT;
		}

		// Token: 0x06035A97 RID: 219799 RVA: 0x0074E5EC File Offset: 0x0074C7EC
		public void UnPackTo(ITeleportDungeonT _o)
		{
			_o.DungeonId = this.DungeonId;
			_o.IsRegroup = this.IsRegroup;
			_o.LocationEntityId = this.LocationEntityId;
			_o.TransitionOption = new TTeleportTransitionOptionUnion();
			_o.TransitionOption.Type = this.TransitionOptionType;
			switch (this.TransitionOptionType)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInDigitalScreen>() != null) ? this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInSeamlessType>() != null) ? this.TransitionOption<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCenterText>() != null) ? this.TransitionOption<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCharacterDisplay>() != null) ? this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithEffect>() != null) ? this.TransitionOption<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithFadeInScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithMp4>() != null) ? this.TransitionOption<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithPlayFlow>() != null) ? this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				break;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				break;
			}
			_o.IsNeedSecondaryConfirmation = this.IsNeedSecondaryConfirmation;
			_o.UseLocationEntityGravity = this.UseLocationEntityGravity;
			_o.ContinueSave = this.ContinueSave;
			_o.IsBanMapSound = this.IsBanMapSound;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035A98 RID: 219800 RVA: 0x0074E93C File Offset: 0x0074CB3C
		public static Offset<ITeleportDungeon> Pack(FlatBufferBuilder builder, ITeleportDungeonT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportDungeon>);
			}
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			return ITeleportDungeon.CreateITeleportDungeon(builder, _o.DungeonId, _o.IsRegroup, _o.LocationEntityId, transitionOption_type, transitionOptionOffset, _o.IsNeedSecondaryConfirmation, _o.UseLocationEntityGravity, _o.ContinueSave, _o.IsBanMapSound, _o.NullMask);
		}

		// Token: 0x04012190 RID: 74128
		private Table __p;
	}
}
