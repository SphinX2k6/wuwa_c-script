using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007BAB RID: 31659
	public struct ITeleportVehicle : IFlatbufferObject
	{
		// Token: 0x1700ED1D RID: 60701
		// (get) Token: 0x060390A9 RID: 233641 RVA: 0x007B5720 File Offset: 0x007B3920
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060390AA RID: 233642 RVA: 0x007B572D File Offset: 0x007B392D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060390AB RID: 233643 RVA: 0x007B5734 File Offset: 0x007B3934
		public static ITeleportVehicle GetRootAsITeleportVehicle(ByteBuffer _bb)
		{
			return ITeleportVehicle.GetRootAsITeleportVehicle(_bb, default(ITeleportVehicle));
		}

		// Token: 0x060390AC RID: 233644 RVA: 0x007B5750 File Offset: 0x007B3950
		public static ITeleportVehicle GetRootAsITeleportVehicle(ByteBuffer _bb, ITeleportVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060390AD RID: 233645 RVA: 0x007B576D File Offset: 0x007B396D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060390AE RID: 233646 RVA: 0x007B577C File Offset: 0x007B397C
		public ITeleportVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ED1E RID: 60702
		// (get) Token: 0x060390AF RID: 233647 RVA: 0x007B578C File Offset: 0x007B398C
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

		// Token: 0x060390B0 RID: 233648 RVA: 0x007B57C8 File Offset: 0x007B39C8
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060390B1 RID: 233649 RVA: 0x007B580C File Offset: 0x007B3A0C
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x060390B2 RID: 233650 RVA: 0x007B5828 File Offset: 0x007B3A28
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x060390B3 RID: 233651 RVA: 0x007B5844 File Offset: 0x007B3A44
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x060390B4 RID: 233652 RVA: 0x007B5860 File Offset: 0x007B3A60
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x060390B5 RID: 233653 RVA: 0x007B587C File Offset: 0x007B3A7C
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x060390B6 RID: 233654 RVA: 0x007B5898 File Offset: 0x007B3A98
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x060390B7 RID: 233655 RVA: 0x007B58B4 File Offset: 0x007B3AB4
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x1700ED1F RID: 60703
		// (get) Token: 0x060390B8 RID: 233656 RVA: 0x007B58D0 File Offset: 0x007B3AD0
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

		// Token: 0x1700ED20 RID: 60704
		// (get) Token: 0x060390B9 RID: 233657 RVA: 0x007B5930 File Offset: 0x007B3B30
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

		// Token: 0x1700ED21 RID: 60705
		// (get) Token: 0x060390BA RID: 233658 RVA: 0x007B5990 File Offset: 0x007B3B90
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

		// Token: 0x1700ED22 RID: 60706
		// (get) Token: 0x060390BB RID: 233659 RVA: 0x007B59D0 File Offset: 0x007B3BD0
		public bool IsTeleportNoLoading
		{
			get
			{
				int num = this.__p.__offset(14);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700ED23 RID: 60707
		// (get) Token: 0x060390BC RID: 233660 RVA: 0x007B5A10 File Offset: 0x007B3C10
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

		// Token: 0x060390BD RID: 233661 RVA: 0x007B5A50 File Offset: 0x007B3C50
		public TTable? TransitionOption<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060390BE RID: 233662 RVA: 0x007B5A98 File Offset: 0x007B3C98
		public ITeleportTransitionInDigitalScreen TransitionOptionAsITeleportTransitionInDigitalScreen()
		{
			return this.TransitionOption<ITeleportTransitionInDigitalScreen>().Value;
		}

		// Token: 0x060390BF RID: 233663 RVA: 0x007B5AB4 File Offset: 0x007B3CB4
		public ITeleportTransitionInSeamlessType TransitionOptionAsITeleportTransitionInSeamlessType()
		{
			return this.TransitionOption<ITeleportTransitionInSeamlessType>().Value;
		}

		// Token: 0x060390C0 RID: 233664 RVA: 0x007B5AD0 File Offset: 0x007B3CD0
		public ITeleportTransitionWithCenterText TransitionOptionAsITeleportTransitionWithCenterText()
		{
			return this.TransitionOption<ITeleportTransitionWithCenterText>().Value;
		}

		// Token: 0x060390C1 RID: 233665 RVA: 0x007B5AEC File Offset: 0x007B3CEC
		public ITeleportTransitionWithCharacterDisplay TransitionOptionAsITeleportTransitionWithCharacterDisplay()
		{
			return this.TransitionOption<ITeleportTransitionWithCharacterDisplay>().Value;
		}

		// Token: 0x060390C2 RID: 233666 RVA: 0x007B5B08 File Offset: 0x007B3D08
		public ITeleportTransitionWithCustomLoading TransitionOptionAsITeleportTransitionWithCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomLoading>().Value;
		}

		// Token: 0x060390C3 RID: 233667 RVA: 0x007B5B24 File Offset: 0x007B3D24
		public ITeleportTransitionWithCustomScreen TransitionOptionAsITeleportTransitionWithCustomScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithCustomScreen>().Value;
		}

		// Token: 0x060390C4 RID: 233668 RVA: 0x007B5B40 File Offset: 0x007B3D40
		public ITeleportTransitionWithEffect TransitionOptionAsITeleportTransitionWithEffect()
		{
			return this.TransitionOption<ITeleportTransitionWithEffect>().Value;
		}

		// Token: 0x060390C5 RID: 233669 RVA: 0x007B5B5C File Offset: 0x007B3D5C
		public ITeleportTransitionWithFadeInScreen TransitionOptionAsITeleportTransitionWithFadeInScreen()
		{
			return this.TransitionOption<ITeleportTransitionWithFadeInScreen>().Value;
		}

		// Token: 0x060390C6 RID: 233670 RVA: 0x007B5B78 File Offset: 0x007B3D78
		public ITeleportTransitionWithMp4 TransitionOptionAsITeleportTransitionWithMp4()
		{
			return this.TransitionOption<ITeleportTransitionWithMp4>().Value;
		}

		// Token: 0x060390C7 RID: 233671 RVA: 0x007B5B94 File Offset: 0x007B3D94
		public ITeleportTransitionWithPlayFlow TransitionOptionAsITeleportTransitionWithPlayFlow()
		{
			return this.TransitionOption<ITeleportTransitionWithPlayFlow>().Value;
		}

		// Token: 0x060390C8 RID: 233672 RVA: 0x007B5BB0 File Offset: 0x007B3DB0
		public ITeleportTransitionWithSpecialCustomLoading TransitionOptionAsITeleportTransitionWithSpecialCustomLoading()
		{
			return this.TransitionOption<ITeleportTransitionWithSpecialCustomLoading>().Value;
		}

		// Token: 0x1700ED24 RID: 60708
		// (get) Token: 0x060390C9 RID: 233673 RVA: 0x007B5BCC File Offset: 0x007B3DCC
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

		// Token: 0x060390CA RID: 233674 RVA: 0x007B5C0C File Offset: 0x007B3E0C
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

		// Token: 0x060390CB RID: 233675 RVA: 0x007B5C6C File Offset: 0x007B3E6C
		public static void StartITeleportVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(9);
		}

		// Token: 0x060390CC RID: 233676 RVA: 0x007B5C76 File Offset: 0x007B3E76
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(0, (byte)targetVehicleType, 0);
		}

		// Token: 0x060390CD RID: 233677 RVA: 0x007B5C81 File Offset: 0x007B3E81
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(1, targetVehicleOffset, 0);
		}

		// Token: 0x060390CE RID: 233678 RVA: 0x007B5C8C File Offset: 0x007B3E8C
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x060390CF RID: 233679 RVA: 0x007B5C9C File Offset: 0x007B3E9C
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(3, rotOffset.Value, 0);
		}

		// Token: 0x060390D0 RID: 233680 RVA: 0x007B5CAC File Offset: 0x007B3EAC
		public static void AddAppointedDock(FlatBufferBuilder builder, int appointedDock)
		{
			builder.AddInt(4, appointedDock, 0);
		}

		// Token: 0x060390D1 RID: 233681 RVA: 0x007B5CB7 File Offset: 0x007B3EB7
		public static void AddIsTeleportNoLoading(FlatBufferBuilder builder, bool isTeleportNoLoading)
		{
			builder.AddBool(5, isTeleportNoLoading, false);
		}

		// Token: 0x060390D2 RID: 233682 RVA: 0x007B5CC2 File Offset: 0x007B3EC2
		public static void AddTransitionOptionType(FlatBufferBuilder builder, TTeleportTransitionOption transitionOptionType)
		{
			builder.AddByte(6, (byte)transitionOptionType, 0);
		}

		// Token: 0x060390D3 RID: 233683 RVA: 0x007B5CCD File Offset: 0x007B3ECD
		public static void AddTransitionOption(FlatBufferBuilder builder, int transitionOptionOffset)
		{
			builder.AddOffset(7, transitionOptionOffset, 0);
		}

		// Token: 0x060390D4 RID: 233684 RVA: 0x007B5CD8 File Offset: 0x007B3ED8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(8, nullMask, 0);
		}

		// Token: 0x060390D5 RID: 233685 RVA: 0x007B5CE3 File Offset: 0x007B3EE3
		public static Offset<ITeleportVehicle> EndITeleportVehicle(FlatBufferBuilder builder)
		{
			return new Offset<ITeleportVehicle>(builder.EndTable());
		}

		// Token: 0x060390D6 RID: 233686 RVA: 0x007B5CF0 File Offset: 0x007B3EF0
		public ITeleportVehicleT UnPack()
		{
			ITeleportVehicleT teleportVehicleT = new ITeleportVehicleT();
			this.UnPackTo(teleportVehicleT);
			return teleportVehicleT;
		}

		// Token: 0x060390D7 RID: 233687 RVA: 0x007B5D0C File Offset: 0x007B3F0C
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

		// Token: 0x060390D8 RID: 233688 RVA: 0x007B6268 File Offset: 0x007B4468
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

		// Token: 0x0401321F RID: 78367
		private Table __p;
	}
}
