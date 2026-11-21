using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007B63 RID: 31587
	public struct ITeleportDungeon : IFlatbufferObject
	{
		// Token: 0x1700EC78 RID: 60536
		// (get) Token: 0x06038E09 RID: 232969 RVA: 0x007B0600 File Offset: 0x007AE800
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06038E0A RID: 232970 RVA: 0x007B060D File Offset: 0x007AE80D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06038E0B RID: 232971 RVA: 0x007B0614 File Offset: 0x007AE814
		public static ITeleportDungeon GetRootAsITeleportDungeon(ByteBuffer _bb)
		{
			return ITeleportDungeon.GetRootAsITeleportDungeon(_bb, default(ITeleportDungeon));
		}

		// Token: 0x06038E0C RID: 232972 RVA: 0x007B0630 File Offset: 0x007AE830
		public static ITeleportDungeon GetRootAsITeleportDungeon(ByteBuffer _bb, ITeleportDungeon obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06038E0D RID: 232973 RVA: 0x007B064D File Offset: 0x007AE84D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06038E0E RID: 232974 RVA: 0x007B065C File Offset: 0x007AE85C
		public ITeleportDungeon __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EC79 RID: 60537
		// (get) Token: 0x06038E0F RID: 232975 RVA: 0x007B066C File Offset: 0x007AE86C
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

		// Token: 0x1700EC7A RID: 60538
		// (get) Token: 0x06038E10 RID: 232976 RVA: 0x007B06A8 File Offset: 0x007AE8A8
		public bool IsRegroup
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EC7B RID: 60539
		// (get) Token: 0x06038E11 RID: 232977 RVA: 0x007B06E8 File Offset: 0x007AE8E8
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

		// Token: 0x1700EC7C RID: 60540
		// (get) Token: 0x06038E12 RID: 232978 RVA: 0x007B0724 File Offset: 0x007AE924
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

		// Token: 0x06038E13 RID: 232979 RVA: 0x007B0764 File Offset: 0x007AE964
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06038E14 RID: 232980 RVA: 0x007B07AC File Offset: 0x007AE9AC
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06038E15 RID: 232981 RVA: 0x007B07C8 File Offset: 0x007AE9C8
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06038E16 RID: 232982 RVA: 0x007B07E4 File Offset: 0x007AE9E4
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06038E17 RID: 232983 RVA: 0x007B0800 File Offset: 0x007AEA00
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06038E18 RID: 232984 RVA: 0x007B081C File Offset: 0x007AEA1C
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06038E19 RID: 232985 RVA: 0x007B0838 File Offset: 0x007AEA38
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06038E1A RID: 232986 RVA: 0x007B0854 File Offset: 0x007AEA54
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06038E1B RID: 232987 RVA: 0x007B0870 File Offset: 0x007AEA70
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06038E1C RID: 232988 RVA: 0x007B088C File Offset: 0x007AEA8C
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06038E1D RID: 232989 RVA: 0x007B08A8 File Offset: 0x007AEAA8
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06038E1E RID: 232990 RVA: 0x007B08C4 File Offset: 0x007AEAC4
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700EC7D RID: 60541
		// (get) Token: 0x06038E1F RID: 232991 RVA: 0x007B08E0 File Offset: 0x007AEAE0
		public bool IsNeedSecondaryConfirmation
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EC7E RID: 60542
		// (get) Token: 0x06038E20 RID: 232992 RVA: 0x007B0920 File Offset: 0x007AEB20
		public bool UseLocationEntityGravity
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EC7F RID: 60543
		// (get) Token: 0x06038E21 RID: 232993 RVA: 0x007B0960 File Offset: 0x007AEB60
		public bool ContinueSave
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EC80 RID: 60544
		// (get) Token: 0x06038E22 RID: 232994 RVA: 0x007B09A0 File Offset: 0x007AEBA0
		public bool IsBanMapSound
		{
			get
			{
				int num = this.__p.__offset(20);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700EC81 RID: 60545
		// (get) Token: 0x06038E23 RID: 232995 RVA: 0x007B09E0 File Offset: 0x007AEBE0
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

		// Token: 0x06038E24 RID: 232996 RVA: 0x007B0A20 File Offset: 0x007AEC20
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

		// Token: 0x06038E25 RID: 232997 RVA: 0x007B0A88 File Offset: 0x007AEC88
		public static void StartITeleportDungeon(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x06038E26 RID: 232998 RVA: 0x007B0A92 File Offset: 0x007AEC92
		public static void AddDungeonId(FlatBufferBuilder builder, int dungeonId)
		{
			builder.AddInt(0, dungeonId, 0);
		}

		// Token: 0x06038E27 RID: 232999 RVA: 0x007B0A9D File Offset: 0x007AEC9D
		public static void AddIsRegroup(FlatBufferBuilder builder, bool isRegroup)
		{
			builder.AddBool(1, isRegroup, false);
		}

		// Token: 0x06038E28 RID: 233000 RVA: 0x007B0AA8 File Offset: 0x007AECA8
		public static void AddLocationEntityId(FlatBufferBuilder builder, int locationEntityId)
		{
			builder.AddInt(2, locationEntityId, 0);
		}

		// Token: 0x06038E29 RID: 233001 RVA: 0x007B0AB3 File Offset: 0x007AECB3
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(3, (byte)transitionOptionType, 0);
		}

		// Token: 0x06038E2A RID: 233002 RVA: 0x007B0ABE File Offset: 0x007AECBE
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(4, transitionOptionOffset, 0);
		}

		// Token: 0x06038E2B RID: 233003 RVA: 0x007B0AC9 File Offset: 0x007AECC9
		public static void AddIsNeedSecondaryConfirmation(FlatBufferBuilder builder, bool isNeedSecondaryConfirmation)
		{
			builder.AddBool(5, isNeedSecondaryConfirmation, false);
		}

		// Token: 0x06038E2C RID: 233004 RVA: 0x007B0AD4 File Offset: 0x007AECD4
		public static void AddUseLocationEntityGravity(FlatBufferBuilder builder, bool useLocationEntityGravity)
		{
			builder.AddBool(6, useLocationEntityGravity, false);
		}

		// Token: 0x06038E2D RID: 233005 RVA: 0x007B0ADF File Offset: 0x007AECDF
		public static void AddContinueSave(FlatBufferBuilder builder, bool continueSave)
		{
			builder.AddBool(7, continueSave, false);
		}

		// Token: 0x06038E2E RID: 233006 RVA: 0x007B0AEA File Offset: 0x007AECEA
		public static void AddIsBanMapSound(FlatBufferBuilder builder, bool isBanMapSound)
		{
			builder.AddBool(8, isBanMapSound, false);
		}

		// Token: 0x06038E2F RID: 233007 RVA: 0x007B0AF5 File Offset: 0x007AECF5
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06038E30 RID: 233008 RVA: 0x007B0B01 File Offset: 0x007AED01
		public static Offset<ITeleportDungeon> EndITeleportDungeon(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportDungeon>(builder.EndTable());
		}

		// Token: 0x06038E31 RID: 233009 RVA: 0x007B0B10 File Offset: 0x007AED10
		public ITeleportDungeonT UnPack()
		{
			ITeleportDungeonT teleportDungeonT = new ITeleportDungeonT();
			this.UnPackTo(teleportDungeonT);
			return teleportDungeonT;
		}

		// Token: 0x06038E32 RID: 233010 RVA: 0x007B0B2C File Offset: 0x007AED2C
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

		// Token: 0x06038E33 RID: 233011 RVA: 0x007B0E7C File Offset: 0x007AF07C
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

		// Token: 0x040131A9 RID: 78249
		private Table __p;
	}
}
