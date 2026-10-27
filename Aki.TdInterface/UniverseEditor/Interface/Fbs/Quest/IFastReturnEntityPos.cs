using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E1B RID: 15899
	public struct IFastReturnEntityPos : IFlatbufferObject
	{
		// Token: 0x17006DE9 RID: 28137
		// (get) Token: 0x06016429 RID: 91177 RVA: 0x00336A0D File Offset: 0x00334C0D
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601642A RID: 91178 RVA: 0x00336A1A File Offset: 0x00334C1A
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601642B RID: 91179 RVA: 0x00336A24 File Offset: 0x00334C24
		public static IFastReturnEntityPos GetRootAsIFastReturnEntityPos(ByteBuffer _bb)
		{
			return IFastReturnEntityPos.GetRootAsIFastReturnEntityPos(_bb, default(IFastReturnEntityPos));
		}

		// Token: 0x0601642C RID: 91180 RVA: 0x00336A40 File Offset: 0x00334C40
		public static IFastReturnEntityPos GetRootAsIFastReturnEntityPos(ByteBuffer _bb, IFastReturnEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601642D RID: 91181 RVA: 0x00336A5D File Offset: 0x00334C5D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601642E RID: 91182 RVA: 0x00336A6C File Offset: 0x00334C6C
		public IFastReturnEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DEA RID: 28138
		// (get) Token: 0x0601642F RID: 91183 RVA: 0x00336A7C File Offset: 0x00334C7C
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

		// Token: 0x17006DEB RID: 28139
		// (get) Token: 0x06016430 RID: 91184 RVA: 0x00336AB8 File Offset: 0x00334CB8
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

		// Token: 0x17006DEC RID: 28140
		// (get) Token: 0x06016431 RID: 91185 RVA: 0x00336AF4 File Offset: 0x00334CF4
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

		// Token: 0x06016432 RID: 91186 RVA: 0x00336B30 File Offset: 0x00334D30
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06016433 RID: 91187 RVA: 0x00336B78 File Offset: 0x00334D78
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06016434 RID: 91188 RVA: 0x00336B94 File Offset: 0x00334D94
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06016435 RID: 91189 RVA: 0x00336BB0 File Offset: 0x00334DB0
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06016436 RID: 91190 RVA: 0x00336BCC File Offset: 0x00334DCC
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06016437 RID: 91191 RVA: 0x00336BE8 File Offset: 0x00334DE8
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06016438 RID: 91192 RVA: 0x00336C04 File Offset: 0x00334E04
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06016439 RID: 91193 RVA: 0x00336C20 File Offset: 0x00334E20
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x0601643A RID: 91194 RVA: 0x00336C3C File Offset: 0x00334E3C
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x0601643B RID: 91195 RVA: 0x00336C58 File Offset: 0x00334E58
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x0601643C RID: 91196 RVA: 0x00336C74 File Offset: 0x00334E74
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x0601643D RID: 91197 RVA: 0x00336C90 File Offset: 0x00334E90
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x0601643E RID: 91198 RVA: 0x00336CAB File Offset: 0x00334EAB
		public static Offset<IFastReturnEntityPos> CreateIFastReturnEntityPos(FlatBufferBuilder builder, EFastReturnPosType Type = EFastReturnPosType.EntityPos, int EntityId = 0, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0)
		{
			builder.StartTable(4);
			IFastReturnEntityPos.AddTransitionOption(builder, TransitionOptionOffset);
			IFastReturnEntityPos.AddEntityId(builder, EntityId);
			IFastReturnEntityPos.AddTransitionOptionType(builder, TransitionOption_type);
			IFastReturnEntityPos.AddType(builder, Type);
			return IFastReturnEntityPos.EndIFastReturnEntityPos(builder);
		}

		// Token: 0x0601643F RID: 91199 RVA: 0x00336CD7 File Offset: 0x00334ED7
		public static void StartIFastReturnEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016440 RID: 91200 RVA: 0x00336CE0 File Offset: 0x00334EE0
		public static void AddType(FlatBufferBuilder builder, EFastReturnPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016441 RID: 91201 RVA: 0x00336CEB File Offset: 0x00334EEB
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06016442 RID: 91202 RVA: 0x00336CF6 File Offset: 0x00334EF6
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(2, (byte)transitionOptionType, 0);
		}

		// Token: 0x06016443 RID: 91203 RVA: 0x00336D01 File Offset: 0x00334F01
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(3, transitionOptionOffset, 0);
		}

		// Token: 0x06016444 RID: 91204 RVA: 0x00336D0C File Offset: 0x00334F0C
		public static Offset<IFastReturnEntityPos> EndIFastReturnEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IFastReturnEntityPos>(builder.EndTable());
		}

		// Token: 0x06016445 RID: 91205 RVA: 0x00336D1C File Offset: 0x00334F1C
		public IFastReturnEntityPosT UnPack()
		{
			IFastReturnEntityPosT fastReturnEntityPosT = new IFastReturnEntityPosT();
			this.UnPackTo(fastReturnEntityPosT);
			return fastReturnEntityPosT;
		}

		// Token: 0x06016446 RID: 91206 RVA: 0x00336D38 File Offset: 0x00334F38
		public void UnPackTo(IFastReturnEntityPosT _o)
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

		// Token: 0x06016447 RID: 91207 RVA: 0x00337018 File Offset: 0x00335218
		public static Offset<IFastReturnEntityPos> Pack(FlatBufferBuilder builder, IFastReturnEntityPosT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFastReturnEntityPos>);
			}
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			return IFastReturnEntityPos.CreateIFastReturnEntityPos(builder, _o.Type, _o.EntityId, transitionOption_type, transitionOptionOffset);
		}

		// Token: 0x0400B797 RID: 46999
		private Table __p;
	}
}
