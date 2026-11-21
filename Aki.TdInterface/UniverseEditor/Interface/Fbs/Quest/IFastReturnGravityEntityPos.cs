using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02004259 RID: 16985
	public struct IFastReturnGravityEntityPos : IFlatbufferObject
	{
		// Token: 0x170073D6 RID: 29654
		// (get) Token: 0x06017A7D RID: 96893 RVA: 0x0035FD34 File Offset: 0x0035DF34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06017A7E RID: 96894 RVA: 0x0035FD41 File Offset: 0x0035DF41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06017A7F RID: 96895 RVA: 0x0035FD48 File Offset: 0x0035DF48
		public static IFastReturnGravityEntityPos GetRootAsIFastReturnGravityEntityPos(ByteBuffer _bb)
		{
			return IFastReturnGravityEntityPos.GetRootAsIFastReturnGravityEntityPos(_bb, default(IFastReturnGravityEntityPos));
		}

		// Token: 0x06017A80 RID: 96896 RVA: 0x0035FD64 File Offset: 0x0035DF64
		public static IFastReturnGravityEntityPos GetRootAsIFastReturnGravityEntityPos(ByteBuffer _bb, IFastReturnGravityEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06017A81 RID: 96897 RVA: 0x0035FD81 File Offset: 0x0035DF81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06017A82 RID: 96898 RVA: 0x0035FD90 File Offset: 0x0035DF90
		public IFastReturnGravityEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x170073D7 RID: 29655
		// (get) Token: 0x06017A83 RID: 96899 RVA: 0x0035FDA0 File Offset: 0x0035DFA0
		public EFastReturnPosType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EFastReturnPosType.EntityPos;
				}
				return (EFastReturnPosType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x170073D8 RID: 29656
		// (get) Token: 0x06017A84 RID: 96900 RVA: 0x0035FDDC File Offset: 0x0035DFDC
		public int EntityId
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

		// Token: 0x170073D9 RID: 29657
		// (get) Token: 0x06017A85 RID: 96901 RVA: 0x0035FE18 File Offset: 0x0035E018
		public TTeleportTransitionOption TransitionOptionType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06017A86 RID: 96902 RVA: 0x0035FE54 File Offset: 0x0035E054
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06017A87 RID: 96903 RVA: 0x0035FE9C File Offset: 0x0035E09C
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06017A88 RID: 96904 RVA: 0x0035FEB8 File Offset: 0x0035E0B8
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06017A89 RID: 96905 RVA: 0x0035FED4 File Offset: 0x0035E0D4
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06017A8A RID: 96906 RVA: 0x0035FEF0 File Offset: 0x0035E0F0
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06017A8B RID: 96907 RVA: 0x0035FF0C File Offset: 0x0035E10C
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06017A8C RID: 96908 RVA: 0x0035FF28 File Offset: 0x0035E128
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06017A8D RID: 96909 RVA: 0x0035FF44 File Offset: 0x0035E144
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06017A8E RID: 96910 RVA: 0x0035FF60 File Offset: 0x0035E160
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06017A8F RID: 96911 RVA: 0x0035FF7C File Offset: 0x0035E17C
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06017A90 RID: 96912 RVA: 0x0035FF98 File Offset: 0x0035E198
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06017A91 RID: 96913 RVA: 0x0035FFB4 File Offset: 0x0035E1B4
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x06017A92 RID: 96914 RVA: 0x0035FFCF File Offset: 0x0035E1CF
		public static Offset<IFastReturnGravityEntityPos> CreateIFastReturnGravityEntityPos(FlatBufferBuilder builder, EFastReturnPosType Type = EFastReturnPosType.EntityPos, int EntityId = 0, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0)
		{
			builder.StartTable(4);
			IFastReturnGravityEntityPos.AddTransitionOption(builder, TransitionOptionOffset);
			IFastReturnGravityEntityPos.AddEntityId(builder, EntityId);
			IFastReturnGravityEntityPos.AddTransitionOptionType(builder, TransitionOption_type);
			IFastReturnGravityEntityPos.AddType(builder, Type);
			return IFastReturnGravityEntityPos.EndIFastReturnGravityEntityPos(builder);
		}

		// Token: 0x06017A93 RID: 96915 RVA: 0x0035FFFB File Offset: 0x0035E1FB
		public static void StartIFastReturnGravityEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06017A94 RID: 96916 RVA: 0x00360004 File Offset: 0x0035E204
		public static void AddType(FlatBufferBuilder builder, EFastReturnPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06017A95 RID: 96917 RVA: 0x0036000F File Offset: 0x0035E20F
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06017A96 RID: 96918 RVA: 0x0036001A File Offset: 0x0035E21A
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(2, (byte)transitionOptionType, 0);
		}

		// Token: 0x06017A97 RID: 96919 RVA: 0x00360025 File Offset: 0x0035E225
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(3, transitionOptionOffset, 0);
		}

		// Token: 0x06017A98 RID: 96920 RVA: 0x00360030 File Offset: 0x0035E230
		public static Offset<IFastReturnGravityEntityPos> EndIFastReturnGravityEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IFastReturnGravityEntityPos>(builder.EndTable());
		}

		// Token: 0x06017A99 RID: 96921 RVA: 0x00360040 File Offset: 0x0035E240
		public IFastReturnGravityEntityPosT UnPack()
		{
			IFastReturnGravityEntityPosT fastReturnGravityEntityPosT = new IFastReturnGravityEntityPosT();
			this.UnPackTo(fastReturnGravityEntityPosT);
			return fastReturnGravityEntityPosT;
		}

		// Token: 0x06017A9A RID: 96922 RVA: 0x0036005C File Offset: 0x0035E25C
		public void UnPackTo(IFastReturnGravityEntityPosT _o)
		{
			_o.Type = this.Type;
			_o.EntityId = this.EntityId;
			_o.TransitionOption = new TTeleportTransitionOptionUnion();
			_o.TransitionOption.Type = this.TransitionOptionType;
			switch (this.TransitionOptionType)
			{
			case TTeleportTransitionOption.ITeleportTransitionInDigitalScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInDigitalScreen>() != null) ? this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionInSeamlessType:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionInSeamlessType>() != null) ? this.TransitionOption<ITeleportTransitionInSeamlessType>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithCenterText:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCenterText>() != null) ? this.TransitionOption<ITeleportTransitionWithCenterText>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithCharacterDisplay:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCharacterDisplay>() != null) ? this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithCustomScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithCustomScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithEffect:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithEffect>() != null) ? this.TransitionOption<ITeleportTransitionWithEffect>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithFadeInScreen:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithFadeInScreen>() != null) ? this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithMp4:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithMp4>() != null) ? this.TransitionOption<ITeleportTransitionWithMp4>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithPlayFlow:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithPlayFlow>() != null) ? this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value.UnPack() : null);
				return;
			case TTeleportTransitionOption.ITeleportTransitionWithSpecialCustomLoading:
				_o.TransitionOption.Value = ((this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>() != null) ? this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06017A9B RID: 96923 RVA: 0x0036033C File Offset: 0x0035E53C
		public static Offset<IFastReturnGravityEntityPos> Pack(FlatBufferBuilder builder, IFastReturnGravityEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFastReturnGravityEntityPos>);
			}
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			return IFastReturnGravityEntityPos.CreateIFastReturnGravityEntityPos(builder, _o.Type, _o.EntityId, transitionOption_type, transitionOptionOffset);
		}

		// Token: 0x0400C173 RID: 49523
		private Table __p;
	}
}
