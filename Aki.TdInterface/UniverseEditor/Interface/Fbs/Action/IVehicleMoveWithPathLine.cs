using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007520 RID: 29984
	public struct IVehicleMoveWithPathLine : IFlatbufferObject
	{
		// Token: 0x1700E385 RID: 58245
		// (get) Token: 0x0603689E RID: 223390 RVA: 0x00768C60 File Offset: 0x00766E60
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603689F RID: 223391 RVA: 0x00768C6D File Offset: 0x00766E6D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060368A0 RID: 223392 RVA: 0x00768C74 File Offset: 0x00766E74
		public static IVehicleMoveWithPathLine GetRootAsIVehicleMoveWithPathLine(ByteBuffer _bb)
		{
			return IVehicleMoveWithPathLine.GetRootAsIVehicleMoveWithPathLine(_bb, default(IVehicleMoveWithPathLine));
		}

		// Token: 0x060368A1 RID: 223393 RVA: 0x00768C90 File Offset: 0x00766E90
		public static IVehicleMoveWithPathLine GetRootAsIVehicleMoveWithPathLine(ByteBuffer _bb, IVehicleMoveWithPathLine obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060368A2 RID: 223394 RVA: 0x00768CAD File Offset: 0x00766EAD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060368A3 RID: 223395 RVA: 0x00768CBC File Offset: 0x00766EBC
		public IVehicleMoveWithPathLine __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E386 RID: 58246
		// (get) Token: 0x060368A4 RID: 223396 RVA: 0x00768CCC File Offset: 0x00766ECC
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

		// Token: 0x060368A5 RID: 223397 RVA: 0x00768D08 File Offset: 0x00766F08
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060368A6 RID: 223398 RVA: 0x00768D4C File Offset: 0x00766F4C
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x060368A7 RID: 223399 RVA: 0x00768D68 File Offset: 0x00766F68
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x060368A8 RID: 223400 RVA: 0x00768D84 File Offset: 0x00766F84
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x060368A9 RID: 223401 RVA: 0x00768DA0 File Offset: 0x00766FA0
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x060368AA RID: 223402 RVA: 0x00768DBC File Offset: 0x00766FBC
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x060368AB RID: 223403 RVA: 0x00768DD8 File Offset: 0x00766FD8
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x060368AC RID: 223404 RVA: 0x00768DF4 File Offset: 0x00766FF4
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x1700E387 RID: 58247
		// (get) Token: 0x060368AD RID: 223405 RVA: 0x00768E10 File Offset: 0x00767010
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

		// Token: 0x1700E388 RID: 58248
		// (get) Token: 0x060368AE RID: 223406 RVA: 0x00768E4C File Offset: 0x0076704C
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

		// Token: 0x060368AF RID: 223407 RVA: 0x00768E8C File Offset: 0x0076708C
		public TTable? ControlType<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(12);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060368B0 RID: 223408 RVA: 0x00768ED4 File Offset: 0x007670D4
		public IVehicleEnterPathMove ControlTypeAsIVehicleEnterPathMove()
		{
			return this.ControlType<IVehicleEnterPathMove>().Value;
		}

		// Token: 0x060368B1 RID: 223409 RVA: 0x00768EF0 File Offset: 0x007670F0
		public IVehicleExitPathMove ControlTypeAsIVehicleExitPathMove()
		{
			return this.ControlType<IVehicleExitPathMove>().Value;
		}

		// Token: 0x060368B2 RID: 223410 RVA: 0x00768F0B File Offset: 0x0076710B
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

		// Token: 0x060368B3 RID: 223411 RVA: 0x00768F3F File Offset: 0x0076713F
		public static void StartIVehicleMoveWithPathLine(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060368B4 RID: 223412 RVA: 0x00768F48 File Offset: 0x00767148
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(0, (byte)targetVehicleType, 0);
		}

		// Token: 0x060368B5 RID: 223413 RVA: 0x00768F53 File Offset: 0x00767153
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(1, targetVehicleOffset, 0);
		}

		// Token: 0x060368B6 RID: 223414 RVA: 0x00768F5E File Offset: 0x0076715E
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(2, splineEntityId, 0);
		}

		// Token: 0x060368B7 RID: 223415 RVA: 0x00768F69 File Offset: 0x00767169
		public static void AddControlTypeType(FlatBufferBuilder builder, TVehicleControlType controlTypeType)
		{
			builder.AddByte(3, (byte)controlTypeType, 0);
		}

		// Token: 0x060368B8 RID: 223416 RVA: 0x00768F74 File Offset: 0x00767174
		public static void AddControlType(FlatBufferBuilder builder, int controlTypeOffset)
		{
			builder.AddOffset(4, controlTypeOffset, 0);
		}

		// Token: 0x060368B9 RID: 223417 RVA: 0x00768F7F File Offset: 0x0076717F
		public static Offset<IVehicleMoveWithPathLine> EndIVehicleMoveWithPathLine(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleMoveWithPathLine>(builder.EndTable());
		}

		// Token: 0x060368BA RID: 223418 RVA: 0x00768F8C File Offset: 0x0076718C
		public IVehicleMoveWithPathLineT UnPack()
		{
			IVehicleMoveWithPathLineT vehicleMoveWithPathLineT = new IVehicleMoveWithPathLineT();
			this.UnPackTo(vehicleMoveWithPathLineT);
			return vehicleMoveWithPathLineT;
		}

		// Token: 0x060368BB RID: 223419 RVA: 0x00768FA8 File Offset: 0x007671A8
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

		// Token: 0x060368BC RID: 223420 RVA: 0x00769240 File Offset: 0x00767440
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

		// Token: 0x0401240F RID: 74767
		private Table __p;
	}
}
