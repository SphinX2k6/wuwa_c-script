using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020063FD RID: 25597
	public struct IClientTeleportVehicle : IFlatbufferObject
	{
		// Token: 0x1700BE98 RID: 48792
		// (get) Token: 0x0602C475 RID: 181365 RVA: 0x00613AA8 File Offset: 0x00611CA8
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602C476 RID: 181366 RVA: 0x00613AB5 File Offset: 0x00611CB5
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602C477 RID: 181367 RVA: 0x00613ABC File Offset: 0x00611CBC
		public static IClientTeleportVehicle GetRootAsIClientTeleportVehicle(ByteBuffer _bb)
		{
			return IClientTeleportVehicle.GetRootAsIClientTeleportVehicle(_bb, default(IClientTeleportVehicle));
		}

		// Token: 0x0602C478 RID: 181368 RVA: 0x00613AD8 File Offset: 0x00611CD8
		public static IClientTeleportVehicle GetRootAsIClientTeleportVehicle(ByteBuffer _bb, IClientTeleportVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602C479 RID: 181369 RVA: 0x00613AF5 File Offset: 0x00611CF5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602C47A RID: 181370 RVA: 0x00613B04 File Offset: 0x00611D04
		public IClientTeleportVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BE99 RID: 48793
		// (get) Token: 0x0602C47B RID: 181371 RVA: 0x00613B14 File Offset: 0x00611D14
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

		// Token: 0x0602C47C RID: 181372 RVA: 0x00613B50 File Offset: 0x00611D50
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602C47D RID: 181373 RVA: 0x00613B94 File Offset: 0x00611D94
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x0602C47E RID: 181374 RVA: 0x00613BB0 File Offset: 0x00611DB0
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x0602C47F RID: 181375 RVA: 0x00613BCC File Offset: 0x00611DCC
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x0602C480 RID: 181376 RVA: 0x00613BE8 File Offset: 0x00611DE8
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x0602C481 RID: 181377 RVA: 0x00613C04 File Offset: 0x00611E04
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x0602C482 RID: 181378 RVA: 0x00613C20 File Offset: 0x00611E20
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x0602C483 RID: 181379 RVA: 0x00613C3C File Offset: 0x00611E3C
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x1700BE9A RID: 48794
		// (get) Token: 0x0602C484 RID: 181380 RVA: 0x00613C58 File Offset: 0x00611E58
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

		// Token: 0x1700BE9B RID: 48795
		// (get) Token: 0x0602C485 RID: 181381 RVA: 0x00613CB8 File Offset: 0x00611EB8
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

		// Token: 0x0602C486 RID: 181382 RVA: 0x00613D16 File Offset: 0x00611F16
		public static Offset<IClientTeleportVehicle> CreateIClientTeleportVehicle(FlatBufferBuilder builder, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IClientTeleportVehicle.AddRot(builder, RotOffset);
			IClientTeleportVehicle.AddPos(builder, PosOffset);
			IClientTeleportVehicle.AddTargetVehicle(builder, TargetVehicleOffset);
			IClientTeleportVehicle.AddTargetVehicleType(builder, TargetVehicle_type);
			return IClientTeleportVehicle.EndIClientTeleportVehicle(builder);
		}

		// Token: 0x0602C487 RID: 181383 RVA: 0x00613D42 File Offset: 0x00611F42
		public static void StartIClientTeleportVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602C488 RID: 181384 RVA: 0x00613D4B File Offset: 0x00611F4B
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(0, (byte)targetVehicleType, 0);
		}

		// Token: 0x0602C489 RID: 181385 RVA: 0x00613D56 File Offset: 0x00611F56
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(1, targetVehicleOffset, 0);
		}

		// Token: 0x0602C48A RID: 181386 RVA: 0x00613D61 File Offset: 0x00611F61
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0602C48B RID: 181387 RVA: 0x00613D71 File Offset: 0x00611F71
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(3, rotOffset.Value, 0);
		}

		// Token: 0x0602C48C RID: 181388 RVA: 0x00613D81 File Offset: 0x00611F81
		public static Offset<IClientTeleportVehicle> EndIClientTeleportVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IClientTeleportVehicle>(builder.EndTable());
		}

		// Token: 0x0602C48D RID: 181389 RVA: 0x00613D90 File Offset: 0x00611F90
		public IClientTeleportVehicleT UnPack()
		{
			IClientTeleportVehicleT clientTeleportVehicleT = new IClientTeleportVehicleT();
			this.UnPackTo(clientTeleportVehicleT);
			return clientTeleportVehicleT;
		}

		// Token: 0x0602C48E RID: 181390 RVA: 0x00613DAC File Offset: 0x00611FAC
		public void UnPackTo(IClientTeleportVehicleT _o)
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
		}

		// Token: 0x0602C48F RID: 181391 RVA: 0x00614000 File Offset: 0x00612200
		public static Offset<IClientTeleportVehicle> Pack(FlatBufferBuilder builder, IClientTeleportVehicleT _o)
		{
			if (_o == null)
			{
				return default(Offset<IClientTeleportVehicle>);
			}
			TTargetVehicle targetVehicle_type = (_o.TargetVehicle == null) ? TTargetVehicle.NONE : _o.TargetVehicle.Type;
			int targetVehicleOffset = (_o.TargetVehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.TargetVehicle);
			Offset<IVectorInfo> posOffset = (_o.Pos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Pos);
			Offset<IVectorInfo> rotOffset = (_o.Rot == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.Rot);
			return IClientTeleportVehicle.CreateIClientTeleportVehicle(builder, targetVehicle_type, targetVehicleOffset, posOffset, rotOffset);
		}

		// Token: 0x040109E8 RID: 68072
		private Table __p;
	}
}
