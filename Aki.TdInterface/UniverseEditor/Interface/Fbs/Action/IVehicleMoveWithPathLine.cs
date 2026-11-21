using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D16 RID: 32022
	public struct IVehicleMoveWithPathLine : IFlatbufferObject
	{
		// Token: 0x1700EFAF RID: 61359
		// (get) Token: 0x06039CB4 RID: 236724 RVA: 0x007CBF08 File Offset: 0x007CA108
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039CB5 RID: 236725 RVA: 0x007CBF15 File Offset: 0x007CA115
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039CB6 RID: 236726 RVA: 0x007CBF1C File Offset: 0x007CA11C
		public static IVehicleMoveWithPathLine GetRootAsIVehicleMoveWithPathLine(ByteBuffer _bb)
		{
			return IVehicleMoveWithPathLine.GetRootAsIVehicleMoveWithPathLine(_bb, default(IVehicleMoveWithPathLine));
		}

		// Token: 0x06039CB7 RID: 236727 RVA: 0x007CBF38 File Offset: 0x007CA138
		public static IVehicleMoveWithPathLine GetRootAsIVehicleMoveWithPathLine(ByteBuffer _bb, IVehicleMoveWithPathLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039CB8 RID: 236728 RVA: 0x007CBF55 File Offset: 0x007CA155
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039CB9 RID: 236729 RVA: 0x007CBF64 File Offset: 0x007CA164
		public IVehicleMoveWithPathLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFB0 RID: 61360
		// (get) Token: 0x06039CBA RID: 236730 RVA: 0x007CBF74 File Offset: 0x007CA174
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

		// Token: 0x06039CBB RID: 236731 RVA: 0x007CBFB0 File Offset: 0x007CA1B0
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039CBC RID: 236732 RVA: 0x007CBFF4 File Offset: 0x007CA1F4
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x06039CBD RID: 236733 RVA: 0x007CC010 File Offset: 0x007CA210
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x06039CBE RID: 236734 RVA: 0x007CC02C File Offset: 0x007CA22C
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06039CBF RID: 236735 RVA: 0x007CC048 File Offset: 0x007CA248
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x06039CC0 RID: 236736 RVA: 0x007CC064 File Offset: 0x007CA264
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x06039CC1 RID: 236737 RVA: 0x007CC080 File Offset: 0x007CA280
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06039CC2 RID: 236738 RVA: 0x007CC09C File Offset: 0x007CA29C
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x1700EFB1 RID: 61361
		// (get) Token: 0x06039CC3 RID: 236739 RVA: 0x007CC0B8 File Offset: 0x007CA2B8
		public int SplineEntityId
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

		// Token: 0x1700EFB2 RID: 61362
		// (get) Token: 0x06039CC4 RID: 236740 RVA: 0x007CC0F4 File Offset: 0x007CA2F4
		public TVehicleControlType ControlTypeType
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return TVehicleControlType.NONE;
				}
				return (TVehicleControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039CC5 RID: 236741 RVA: 0x007CC134 File Offset: 0x007CA334
		public TTable? ControlType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039CC6 RID: 236742 RVA: 0x007CC17C File Offset: 0x007CA37C
		public IVehicleEnterPathMove ControlTypeAsIVehicleEnterPathMove()
		{
			return this.ControlType<IVehicleEnterPathMove>().Value;
		}

		// Token: 0x06039CC7 RID: 236743 RVA: 0x007CC198 File Offset: 0x007CA398
		public IVehicleExitPathMove ControlTypeAsIVehicleExitPathMove()
		{
			return this.ControlType<IVehicleExitPathMove>().Value;
		}

		// Token: 0x06039CC8 RID: 236744 RVA: 0x007CC1B3 File Offset: 0x007CA3B3
		public static Offset<IVehicleMoveWithPathLine> CreateIVehicleMoveWithPathLine(FlatBufferBuilder builder, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0, int SplineEntityId = 0, TVehicleControlType ControlType_type = TVehicleControlType.NONE, int ControlTypeOffset = 0)
		{
			builder.StartTable(5);
			IVehicleMoveWithPathLine.AddControlType(builder, ControlTypeOffset);
			IVehicleMoveWithPathLine.AddSplineEntityId(builder, SplineEntityId);
			IVehicleMoveWithPathLine.AddTargetVehicle(builder, TargetVehicleOffset);
			IVehicleMoveWithPathLine.AddControlTypeType(builder, ControlType_type);
			IVehicleMoveWithPathLine.AddTargetVehicleType(builder, TargetVehicle_type);
			return IVehicleMoveWithPathLine.EndIVehicleMoveWithPathLine(builder);
		}

		// Token: 0x06039CC9 RID: 236745 RVA: 0x007CC1E7 File Offset: 0x007CA3E7
		public static void StartIVehicleMoveWithPathLine(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06039CCA RID: 236746 RVA: 0x007CC1F0 File Offset: 0x007CA3F0
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(0, (byte)targetVehicleType, 0);
		}

		// Token: 0x06039CCB RID: 236747 RVA: 0x007CC1FB File Offset: 0x007CA3FB
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(1, targetVehicleOffset, 0);
		}

		// Token: 0x06039CCC RID: 236748 RVA: 0x007CC206 File Offset: 0x007CA406
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x06039CCD RID: 236749 RVA: 0x007CC211 File Offset: 0x007CA411
		public static void AddControlTypeType(FlatBufferBuilder builder, TVehicleControlType controlTypeType)
		{
			builder.AddByte(3, (byte)controlTypeType, 0);
		}

		// Token: 0x06039CCE RID: 236750 RVA: 0x007CC21C File Offset: 0x007CA41C
		public static void AddControlType(FlatBufferBuilder builder, int controlTypeOffset)
		{
			builder.AddOffset(4, controlTypeOffset, 0);
		}

		// Token: 0x06039CCF RID: 236751 RVA: 0x007CC227 File Offset: 0x007CA427
		public static Offset<IVehicleMoveWithPathLine> EndIVehicleMoveWithPathLine(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleMoveWithPathLine>(builder.EndTable());
		}

		// Token: 0x06039CD0 RID: 236752 RVA: 0x007CC234 File Offset: 0x007CA434
		public IVehicleMoveWithPathLineT UnPack()
		{
			IVehicleMoveWithPathLineT vehicleMoveWithPathLineT = new IVehicleMoveWithPathLineT();
			this.UnPackTo(vehicleMoveWithPathLineT);
			return vehicleMoveWithPathLineT;
		}

		// Token: 0x06039CD1 RID: 236753 RVA: 0x007CC250 File Offset: 0x007CA450
		public void UnPackTo(IVehicleMoveWithPathLineT _o)
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
			_o.SplineEntityId = this.SplineEntityId;
			_o.ControlType = new TVehicleControlTypeUnion();
			_o.ControlType.Type = this.ControlTypeType;
			TVehicleControlType controlTypeType = this.ControlTypeType;
			if (controlTypeType == TVehicleControlType.IVehicleEnterPathMove)
			{
				_o.ControlType.Value = ((this.ControlType<IVehicleEnterPathMove>() != null) ? this.ControlType<IVehicleEnterPathMove>().Value.UnPack() : null);
				return;
			}
			if (controlTypeType != TVehicleControlType.IVehicleExitPathMove)
			{
				return;
			}
			_o.ControlType.Value = ((this.ControlType<IVehicleExitPathMove>() != null) ? this.ControlType<IVehicleExitPathMove>().Value.UnPack() : null);
		}

		// Token: 0x06039CD2 RID: 236754 RVA: 0x007CC4E8 File Offset: 0x007CA6E8
		public static Offset<IVehicleMoveWithPathLine> Pack(FlatBufferBuilder builder, IVehicleMoveWithPathLineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleMoveWithPathLine>);
			}
			TTargetVehicle targetVehicle_type = (_o.TargetVehicle == null) ? TTargetVehicle.NONE : _o.TargetVehicle.Type;
			int targetVehicleOffset = (_o.TargetVehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.TargetVehicle);
			TVehicleControlType controlType_type = (_o.ControlType == null) ? TVehicleControlType.NONE : _o.ControlType.Type;
			int controlTypeOffset = (_o.ControlType == null) ? 0 : TVehicleControlTypeUnion.Pack(builder, _o.ControlType);
			return IVehicleMoveWithPathLine.CreateIVehicleMoveWithPathLine(builder, targetVehicle_type, targetVehicleOffset, _o.SplineEntityId, controlType_type, controlTypeOffset);
		}

		// Token: 0x04013440 RID: 78912
		private Table __p;
	}
}
