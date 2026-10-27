using System;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Quest
{
	// Token: 0x02003E18 RID: 15896
	public struct IFailedTeleport : IFlatbufferObject
	{
		// Token: 0x17006DDA RID: 28122
		// (get) Token: 0x060163F2 RID: 91122 RVA: 0x00335FEC File Offset: 0x003341EC
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060163F3 RID: 91123 RVA: 0x00335FF9 File Offset: 0x003341F9
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060163F4 RID: 91124 RVA: 0x00336000 File Offset: 0x00334200
		public static IFailedTeleport GetRootAsIFailedTeleport(ByteBuffer _bb)
		{
			return IFailedTeleport.GetRootAsIFailedTeleport(_bb, default(IFailedTeleport));
		}

		// Token: 0x060163F5 RID: 91125 RVA: 0x0033601C File Offset: 0x0033421C
		public static IFailedTeleport GetRootAsIFailedTeleport(ByteBuffer _bb, IFailedTeleport obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060163F6 RID: 91126 RVA: 0x00336039 File Offset: 0x00334239
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060163F7 RID: 91127 RVA: 0x00336048 File Offset: 0x00334248
		public IFailedTeleport __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17006DDB RID: 28123
		// (get) Token: 0x060163F8 RID: 91128 RVA: 0x00336058 File Offset: 0x00334258
		public IPosA? Position
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IPosA?(default(IPosA).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17006DDC RID: 28124
		// (get) Token: 0x060163F9 RID: 91129 RVA: 0x003360B8 File Offset: 0x003342B8
		public int PositionEntityId
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

		// Token: 0x17006DDD RID: 28125
		// (get) Token: 0x060163FA RID: 91130 RVA: 0x003360F4 File Offset: 0x003342F4
		public bool IsConfirm
		{
			get
			{
				int num = this.__p.__offset(8);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006DDE RID: 28126
		// (get) Token: 0x060163FB RID: 91131 RVA: 0x00336134 File Offset: 0x00334334
		public int ConfirmId
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

		// Token: 0x17006DDF RID: 28127
		// (get) Token: 0x060163FC RID: 91132 RVA: 0x00336174 File Offset: 0x00334374
		public TTeleportTransitionOption TransitionOptionType
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060163FD RID: 91133 RVA: 0x003361B4 File Offset: 0x003343B4
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(14);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060163FE RID: 91134 RVA: 0x003361FC File Offset: 0x003343FC
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x060163FF RID: 91135 RVA: 0x00336218 File Offset: 0x00334418
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06016400 RID: 91136 RVA: 0x00336234 File Offset: 0x00334434
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06016401 RID: 91137 RVA: 0x00336250 File Offset: 0x00334450
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06016402 RID: 91138 RVA: 0x0033626C File Offset: 0x0033446C
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06016403 RID: 91139 RVA: 0x00336288 File Offset: 0x00334488
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06016404 RID: 91140 RVA: 0x003362A4 File Offset: 0x003344A4
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06016405 RID: 91141 RVA: 0x003362C0 File Offset: 0x003344C0
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06016406 RID: 91142 RVA: 0x003362DC File Offset: 0x003344DC
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06016407 RID: 91143 RVA: 0x003362F8 File Offset: 0x003344F8
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06016408 RID: 91144 RVA: 0x00336314 File Offset: 0x00334514
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x17006DE0 RID: 28128
		// (get) Token: 0x06016409 RID: 91145 RVA: 0x00336330 File Offset: 0x00334530
		public bool GravityFlip
		{
			get
			{
				int num = this.__p.__offset(16);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x17006DE1 RID: 28129
		// (get) Token: 0x0601640A RID: 91146 RVA: 0x00336370 File Offset: 0x00334570
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0601640B RID: 91147 RVA: 0x003363B0 File Offset: 0x003345B0
		public static Offset<IFailedTeleport> CreateIFailedTeleport(FlatBufferBuilder builder, Offset<IPosA> PositionOffset = default(Offset<IPosA>), int PositionEntityId = 0, bool IsConfirm = false, int ConfirmId = 0, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0, bool GravityFlip = false, byte NullMask = 0)
		{
			builder.StartTable(8);
			IFailedTeleport.AddTransitionOption(builder, TransitionOptionOffset);
			IFailedTeleport.AddConfirmId(builder, ConfirmId);
			IFailedTeleport.AddPositionEntityId(builder, PositionEntityId);
			IFailedTeleport.AddPosition(builder, PositionOffset);
			IFailedTeleport.AddNullMask(builder, NullMask);
			IFailedTeleport.AddGravityFlip(builder, GravityFlip);
			IFailedTeleport.AddTransitionOptionType(builder, TransitionOption_type);
			IFailedTeleport.AddIsConfirm(builder, IsConfirm);
			return IFailedTeleport.EndIFailedTeleport(builder);
		}

		// Token: 0x0601640C RID: 91148 RVA: 0x00336407 File Offset: 0x00334607
		public static void StartIFailedTeleport(FlatBufferBuilder builder)
		{
			builder.StartTable(8);
		}

		// Token: 0x0601640D RID: 91149 RVA: 0x00336410 File Offset: 0x00334610
		public static void AddPosition(FlatBufferBuilder builder, Offset<IPosA> positionOffset)
		{
			builder.AddOffset(0, positionOffset.Value, 0);
		}

		// Token: 0x0601640E RID: 91150 RVA: 0x00336420 File Offset: 0x00334620
		public static void AddPositionEntityId(FlatBufferBuilder builder, int positionEntityId)
		{
			builder.AddInt(1, positionEntityId, 0);
		}

		// Token: 0x0601640F RID: 91151 RVA: 0x0033642B File Offset: 0x0033462B
		public static void AddIsConfirm(FlatBufferBuilder builder, bool isConfirm)
		{
			builder.AddBool(2, isConfirm, false);
		}

		// Token: 0x06016410 RID: 91152 RVA: 0x00336436 File Offset: 0x00334636
		public static void AddConfirmId(FlatBufferBuilder builder, int confirmId)
		{
			builder.AddInt(3, confirmId, 0);
		}

		// Token: 0x06016411 RID: 91153 RVA: 0x00336441 File Offset: 0x00334641
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(4, (byte)transitionOptionType, 0);
		}

		// Token: 0x06016412 RID: 91154 RVA: 0x0033644C File Offset: 0x0033464C
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(5, transitionOptionOffset, 0);
		}

		// Token: 0x06016413 RID: 91155 RVA: 0x00336457 File Offset: 0x00334657
		public static void AddGravityFlip(FlatBufferBuilder builder, bool gravityFlip)
		{
			builder.AddBool(6, gravityFlip, false);
		}

		// Token: 0x06016414 RID: 91156 RVA: 0x00336462 File Offset: 0x00334662
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(7, nullMask, 0);
		}

		// Token: 0x06016415 RID: 91157 RVA: 0x0033646D File Offset: 0x0033466D
		public static Offset<IFailedTeleport> EndIFailedTeleport(FlatBufferBuilder builder)
		{
			return new Offset<IFailedTeleport>(builder.EndTable());
		}

		// Token: 0x06016416 RID: 91158 RVA: 0x0033647C File Offset: 0x0033467C
		public IFailedTeleportT UnPack()
		{
			IFailedTeleportT failedTeleportT = new IFailedTeleportT();
			this.UnPackTo(failedTeleportT);
			return failedTeleportT;
		}

		// Token: 0x06016417 RID: 91159 RVA: 0x00336498 File Offset: 0x00334698
		public void UnPackTo(IFailedTeleportT _o)
		{
			_o.Position = ((this.Position != null) ? this.Position.Value.UnPack() : null);
			_o.PositionEntityId = this.PositionEntityId;
			_o.IsConfirm = this.IsConfirm;
			_o.ConfirmId = this.ConfirmId;
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
			_o.GravityFlip = this.GravityFlip;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06016418 RID: 91160 RVA: 0x003367F4 File Offset: 0x003349F4
		public static Offset<IFailedTeleport> Pack(FlatBufferBuilder builder, IFailedTeleportT _o)
		{
			if (_o == null)
			{
				return default(Offset<IFailedTeleport>);
			}
			Offset<IPosA> positionOffset = (_o.Position == null) ? default(Offset<IPosA>) : IPosA.Pack(builder, _o.Position);
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			return IFailedTeleport.CreateIFailedTeleport(builder, positionOffset, _o.PositionEntityId, _o.IsConfirm, _o.ConfirmId, transitionOption_type, transitionOptionOffset, _o.GravityFlip, _o.NullMask);
		}

		// Token: 0x0400B78F RID: 46991
		private Table __p;
	}
}
