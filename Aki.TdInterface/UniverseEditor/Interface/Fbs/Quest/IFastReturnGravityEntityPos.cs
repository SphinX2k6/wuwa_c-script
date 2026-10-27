using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E1E RID: 15902
	public struct IFastReturnGravityEntityPos : IFlatbufferObject
	{
		// Token: 0x17006DF0 RID: 28144
		// (get) Token: 0x06016450 RID: 91216 RVA: 0x0033713C File Offset: 0x0033533C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06016451 RID: 91217 RVA: 0x00337149 File Offset: 0x00335349
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06016452 RID: 91218 RVA: 0x00337150 File Offset: 0x00335350
		public static IFastReturnGravityEntityPos GetRootAsIFastReturnGravityEntityPos(ByteBuffer _bb)
		{
			return IFastReturnGravityEntityPos.GetRootAsIFastReturnGravityEntityPos(_bb, default(IFastReturnGravityEntityPos));
		}

		// Token: 0x06016453 RID: 91219 RVA: 0x0033716C File Offset: 0x0033536C
		public static IFastReturnGravityEntityPos GetRootAsIFastReturnGravityEntityPos(ByteBuffer _bb, IFastReturnGravityEntityPos obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06016454 RID: 91220 RVA: 0x00337189 File Offset: 0x00335389
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06016455 RID: 91221 RVA: 0x00337198 File Offset: 0x00335398
		public IFastReturnGravityEntityPos __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DF1 RID: 28145
		// (get) Token: 0x06016456 RID: 91222 RVA: 0x003371A8 File Offset: 0x003353A8
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

		// Token: 0x17006DF2 RID: 28146
		// (get) Token: 0x06016457 RID: 91223 RVA: 0x003371E4 File Offset: 0x003353E4
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

		// Token: 0x17006DF3 RID: 28147
		// (get) Token: 0x06016458 RID: 91224 RVA: 0x00337220 File Offset: 0x00335420
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

		// Token: 0x06016459 RID: 91225 RVA: 0x0033725C File Offset: 0x0033545C
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0601645A RID: 91226 RVA: 0x003372A4 File Offset: 0x003354A4
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x0601645B RID: 91227 RVA: 0x003372C0 File Offset: 0x003354C0
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x0601645C RID: 91228 RVA: 0x003372DC File Offset: 0x003354DC
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x0601645D RID: 91229 RVA: 0x003372F8 File Offset: 0x003354F8
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x0601645E RID: 91230 RVA: 0x00337314 File Offset: 0x00335514
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x0601645F RID: 91231 RVA: 0x00337330 File Offset: 0x00335530
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06016460 RID: 91232 RVA: 0x0033734C File Offset: 0x0033554C
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06016461 RID: 91233 RVA: 0x00337368 File Offset: 0x00335568
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06016462 RID: 91234 RVA: 0x00337384 File Offset: 0x00335584
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06016463 RID: 91235 RVA: 0x003373A0 File Offset: 0x003355A0
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06016464 RID: 91236 RVA: 0x003373BC File Offset: 0x003355BC
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x06016465 RID: 91237 RVA: 0x003373D7 File Offset: 0x003355D7
		public static Offset<IFastReturnGravityEntityPos> CreateIFastReturnGravityEntityPos(FlatBufferBuilder builder, EFastReturnPosType Type = EFastReturnPosType.EntityPos, int EntityId = 0, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0)
		{
			builder.StartTable(4);
			IFastReturnGravityEntityPos.AddTransitionOption(builder, TransitionOptionOffset);
			IFastReturnGravityEntityPos.AddEntityId(builder, EntityId);
			IFastReturnGravityEntityPos.AddTransitionOptionType(builder, TransitionOption_type);
			IFastReturnGravityEntityPos.AddType(builder, Type);
			return IFastReturnGravityEntityPos.EndIFastReturnGravityEntityPos(builder);
		}

		// Token: 0x06016466 RID: 91238 RVA: 0x00337403 File Offset: 0x00335603
		public static void StartIFastReturnGravityEntityPos(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x06016467 RID: 91239 RVA: 0x0033740C File Offset: 0x0033560C
		public static void AddType(FlatBufferBuilder builder, EFastReturnPosType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06016468 RID: 91240 RVA: 0x00337417 File Offset: 0x00335617
		public static void AddEntityId(FlatBufferBuilder builder, int entityId)
		{
			builder.AddInt(1, entityId, 0);
		}

		// Token: 0x06016469 RID: 91241 RVA: 0x00337422 File Offset: 0x00335622
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(2, (byte)transitionOptionType, 0);
		}

		// Token: 0x0601646A RID: 91242 RVA: 0x0033742D File Offset: 0x0033562D
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(3, transitionOptionOffset, 0);
		}

		// Token: 0x0601646B RID: 91243 RVA: 0x00337438 File Offset: 0x00335638
		public static Offset<IFastReturnGravityEntityPos> EndIFastReturnGravityEntityPos(FlatBufferBuilder builder)
		{
			return new Offset<IFastReturnGravityEntityPos>(builder.EndTable());
		}

		// Token: 0x0601646C RID: 91244 RVA: 0x00337448 File Offset: 0x00335648
		public IFastReturnGravityEntityPosT UnPack()
		{
			IFastReturnGravityEntityPosT fastReturnGravityEntityPosT = new IFastReturnGravityEntityPosT();
			this.UnPackTo(fastReturnGravityEntityPosT);
			return fastReturnGravityEntityPosT;
		}

		// Token: 0x0601646D RID: 91245 RVA: 0x00337464 File Offset: 0x00335664
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

		// Token: 0x0601646E RID: 91246 RVA: 0x00337744 File Offset: 0x00335944
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

		// Token: 0x0400B79B RID: 47003
		private Table __p;
	}
}
