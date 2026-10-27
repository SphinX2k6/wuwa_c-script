using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020073C4 RID: 29636
	public struct ITeleportVehicle : IFlatbufferObject
	{
		// Token: 0x1700E10D RID: 57613
		// (get) Token: 0x06035D0E RID: 220430 RVA: 0x007531E0 File Offset: 0x007513E0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035D0F RID: 220431 RVA: 0x007531ED File Offset: 0x007513ED
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035D10 RID: 220432 RVA: 0x007531F4 File Offset: 0x007513F4
		public static ITeleportVehicle GetRootAsITeleportVehicle(ByteBuffer _bb)
		{
			return ITeleportVehicle.GetRootAsITeleportVehicle(_bb, default(ITeleportVehicle));
		}

		// Token: 0x06035D11 RID: 220433 RVA: 0x00753210 File Offset: 0x00751410
		public static ITeleportVehicle GetRootAsITeleportVehicle(ByteBuffer _bb, ITeleportVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06035D12 RID: 220434 RVA: 0x0075322D File Offset: 0x0075142D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035D13 RID: 220435 RVA: 0x0075323C File Offset: 0x0075143C
		public ITeleportVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E10E RID: 57614
		// (get) Token: 0x06035D14 RID: 220436 RVA: 0x0075324C File Offset: 0x0075144C
		public TTargetVehicle TargetVehicleType
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return TTargetVehicle.NONE;
				}
				return (TTargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035D15 RID: 220437 RVA: 0x00753288 File Offset: 0x00751488
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035D16 RID: 220438 RVA: 0x007532CC File Offset: 0x007514CC
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x06035D17 RID: 220439 RVA: 0x007532E8 File Offset: 0x007514E8
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x06035D18 RID: 220440 RVA: 0x00753304 File Offset: 0x00751504
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06035D19 RID: 220441 RVA: 0x00753320 File Offset: 0x00751520
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x06035D1A RID: 220442 RVA: 0x0075333C File Offset: 0x0075153C
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x06035D1B RID: 220443 RVA: 0x00753358 File Offset: 0x00751558
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06035D1C RID: 220444 RVA: 0x00753374 File Offset: 0x00751574
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x1700E10F RID: 57615
		// (get) Token: 0x06035D1D RID: 220445 RVA: 0x00753390 File Offset: 0x00751590
		public IVectorInfo? Pos
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E110 RID: 57616
		// (get) Token: 0x06035D1E RID: 220446 RVA: 0x007533F0 File Offset: 0x007515F0
		public IVectorInfo? Rot
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E111 RID: 57617
		// (get) Token: 0x06035D1F RID: 220447 RVA: 0x00753450 File Offset: 0x00751650
		public int AppointedDock
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

		// Token: 0x1700E112 RID: 57618
		// (get) Token: 0x06035D20 RID: 220448 RVA: 0x00753490 File Offset: 0x00751690
		public bool IsTeleportNoLoading
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E113 RID: 57619
		// (get) Token: 0x06035D21 RID: 220449 RVA: 0x007534D0 File Offset: 0x007516D0
		public TTeleportTransitionOption TransitionOptionType
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return TTeleportTransitionOption.NONE;
				}
				return (TTeleportTransitionOption)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035D22 RID: 220450 RVA: 0x00753510 File Offset: 0x00751710
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06035D23 RID: 220451 RVA: 0x00753558 File Offset: 0x00751758
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x06035D24 RID: 220452 RVA: 0x00753574 File Offset: 0x00751774
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x06035D25 RID: 220453 RVA: 0x00753590 File Offset: 0x00751790
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x06035D26 RID: 220454 RVA: 0x007535AC File Offset: 0x007517AC
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x06035D27 RID: 220455 RVA: 0x007535C8 File Offset: 0x007517C8
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x06035D28 RID: 220456 RVA: 0x007535E4 File Offset: 0x007517E4
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x06035D29 RID: 220457 RVA: 0x00753600 File Offset: 0x00751800
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x06035D2A RID: 220458 RVA: 0x0075361C File Offset: 0x0075181C
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x06035D2B RID: 220459 RVA: 0x00753638 File Offset: 0x00751838
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x06035D2C RID: 220460 RVA: 0x00753654 File Offset: 0x00751854
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x06035D2D RID: 220461 RVA: 0x00753670 File Offset: 0x00751870
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700E114 RID: 57620
		// (get) Token: 0x06035D2E RID: 220462 RVA: 0x0075368C File Offset: 0x0075188C
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06035D2F RID: 220463 RVA: 0x007536CC File Offset: 0x007518CC
		public static Offset<ITeleportVehicle> CreateITeleportVehicle(FlatBufferBuilder builder, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>), int AppointedDock = 0, bool IsTeleportNoLoading = false, TTeleportTransitionOption TransitionOption_type = TTeleportTransitionOption.NONE, int TransitionOptionOffset = 0, byte NullMask = 0)
		{
			builder.StartTable(9);
			ITeleportVehicle.AddTransitionOption(builder, TransitionOptionOffset);
			ITeleportVehicle.AddAppointedDock(builder, AppointedDock);
			ITeleportVehicle.AddRot(builder, RotOffset);
			ITeleportVehicle.AddPos(builder, PosOffset);
			ITeleportVehicle.AddTargetVehicle(builder, TargetVehicleOffset);
			ITeleportVehicle.AddNullMask(builder, NullMask);
			ITeleportVehicle.AddTransitionOptionType(builder, TransitionOption_type);
			ITeleportVehicle.AddIsTeleportNoLoading(builder, IsTeleportNoLoading);
			ITeleportVehicle.AddTargetVehicleType(builder, TargetVehicle_type);
			return ITeleportVehicle.EndITeleportVehicle(builder);
		}

		// Token: 0x06035D30 RID: 220464 RVA: 0x0075372C File Offset: 0x0075192C
		public static void StartITeleportVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x06035D31 RID: 220465 RVA: 0x00753736 File Offset: 0x00751936
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(0, (byte)targetVehicleType, 0);
		}

		// Token: 0x06035D32 RID: 220466 RVA: 0x00753741 File Offset: 0x00751941
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(1, targetVehicleOffset, 0);
		}

		// Token: 0x06035D33 RID: 220467 RVA: 0x0075374C File Offset: 0x0075194C
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x06035D34 RID: 220468 RVA: 0x0075375C File Offset: 0x0075195C
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(3, rotOffset.Value, 0);
		}

		// Token: 0x06035D35 RID: 220469 RVA: 0x0075376C File Offset: 0x0075196C
		public static void AddAppointedDock(FlatBufferBuilder builder, int appointedDock)
		{
			builder.AddInt(4, appointedDock, 0);
		}

		// Token: 0x06035D36 RID: 220470 RVA: 0x00753777 File Offset: 0x00751977
		public static void AddIsTeleportNoLoading(FlatBufferBuilder builder, bool isTeleportNoLoading)
		{
			builder.AddBool(5, isTeleportNoLoading, false);
		}

		// Token: 0x06035D37 RID: 220471 RVA: 0x00753782 File Offset: 0x00751982
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(6, (byte)transitionOptionType, 0);
		}

		// Token: 0x06035D38 RID: 220472 RVA: 0x0075378D File Offset: 0x0075198D
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(7, transitionOptionOffset, 0);
		}

		// Token: 0x06035D39 RID: 220473 RVA: 0x00753798 File Offset: 0x00751998
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x06035D3A RID: 220474 RVA: 0x007537A3 File Offset: 0x007519A3
		public static Offset<ITeleportVehicle> EndITeleportVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportVehicle>(builder.EndTable());
		}

		// Token: 0x06035D3B RID: 220475 RVA: 0x007537B0 File Offset: 0x007519B0
		public ITeleportVehicleT UnPack()
		{
			ITeleportVehicleT teleportVehicleT = new ITeleportVehicleT();
			this.UnPackTo(teleportVehicleT);
			return teleportVehicleT;
		}

		// Token: 0x06035D3C RID: 220476 RVA: 0x007537CC File Offset: 0x007519CC
		public void UnPackTo(ITeleportVehicleT _o)
		{
			_o.TargetVehicle = new TTargetVehicleUnion();
			_o.TargetVehicle.Type = this.TargetVehicleType;
			switch (this.TargetVehicleType)
			{
			case TTargetVehicle.IAppointedVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IAppointedVehicle>() != null) ? this.TargetVehicle<IAppointedVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ICurrentVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ICurrentVehicle>() != null) ? this.TargetVehicle<ICurrentVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IFishingBoatVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IFishingBoatVehicle>() != null) ? this.TargetVehicle<IFishingBoatVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ISelfVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ISelfVehicle>() != null) ? this.TargetVehicle<ISelfVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.ITriggeredVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ITriggeredVehicle>() != null) ? this.TargetVehicle<ITriggeredVehicle>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IVehiclePlayerMotor:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehiclePlayerMotor>() != null) ? this.TargetVehicle<IVehiclePlayerMotor>().Value.UnPack() : null);
				break;
			case TTargetVehicle.IVehicleTeam:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehicleTeam>() != null) ? this.TargetVehicle<IVehicleTeam>().Value.UnPack() : null);
				break;
			}
			_o.Pos = ((this.Pos != null) ? this.Pos.Value.UnPack() : null);
			_o.Rot = ((this.Rot != null) ? this.Rot.Value.UnPack() : null);
			_o.AppointedDock = this.AppointedDock;
			_o.IsTeleportNoLoading = this.IsTeleportNoLoading;
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
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06035D3D RID: 220477 RVA: 0x00753D28 File Offset: 0x00751F28
		public static Offset<ITeleportVehicle> Pack(FlatBufferBuilder builder, ITeleportVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<ITeleportVehicle>);
			}
			TTargetVehicle targetVehicle_type = (_o.TargetVehicle == null) ? TTargetVehicle.NONE : _o.TargetVehicle.Type;
			int targetVehicleOffset = (_o.TargetVehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.TargetVehicle);
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			TTeleportTransitionOption transitionOption_type = (_o.TransitionOption == null) ? TTeleportTransitionOption.NONE : _o.TransitionOption.Type;
			int transitionOptionOffset = (_o.TransitionOption == null) ? 0 : TTeleportTransitionOptionUnion.Pack(builder, _o.TransitionOption);
			return ITeleportVehicle.CreateITeleportVehicle(builder, targetVehicle_type, targetVehicleOffset, posOffset, rotOffset, _o.AppointedDock, _o.IsTeleportNoLoading, transitionOption_type, transitionOptionOffset, _o.NullMask);
		}

		// Token: 0x04012206 RID: 74246
		private Table __p;
	}
}
