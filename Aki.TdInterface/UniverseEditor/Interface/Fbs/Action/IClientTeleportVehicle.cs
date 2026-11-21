using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A7D RID: 27261
	public struct IClientTeleportVehicle : IFlatbufferObject
	{
		// Token: 0x1700C832 RID: 51250
		// (get) Token: 0x0602EC4B RID: 191563 RVA: 0x0065F934 File Offset: 0x0065DB34
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602EC4C RID: 191564 RVA: 0x0065F941 File Offset: 0x0065DB41
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602EC4D RID: 191565 RVA: 0x0065F948 File Offset: 0x0065DB48
		public static IClientTeleportVehicle GetRootAsIClientTeleportVehicle(ByteBuffer _bb)
		{
			return IClientTeleportVehicle.GetRootAsIClientTeleportVehicle(_bb, default(IClientTeleportVehicle));
		}

		// Token: 0x0602EC4E RID: 191566 RVA: 0x0065F964 File Offset: 0x0065DB64
		public static IClientTeleportVehicle GetRootAsIClientTeleportVehicle(ByteBuffer _bb, IClientTeleportVehicle obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602EC4F RID: 191567 RVA: 0x0065F981 File Offset: 0x0065DB81
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602EC50 RID: 191568 RVA: 0x0065F990 File Offset: 0x0065DB90
		public IClientTeleportVehicle __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C833 RID: 51251
		// (get) Token: 0x0602EC51 RID: 191569 RVA: 0x0065F9A0 File Offset: 0x0065DBA0
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

		// Token: 0x0602EC52 RID: 191570 RVA: 0x0065F9DC File Offset: 0x0065DBDC
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602EC53 RID: 191571 RVA: 0x0065FA20 File Offset: 0x0065DC20
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x0602EC54 RID: 191572 RVA: 0x0065FA3C File Offset: 0x0065DC3C
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x0602EC55 RID: 191573 RVA: 0x0065FA58 File Offset: 0x0065DC58
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x0602EC56 RID: 191574 RVA: 0x0065FA74 File Offset: 0x0065DC74
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x0602EC57 RID: 191575 RVA: 0x0065FA90 File Offset: 0x0065DC90
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x0602EC58 RID: 191576 RVA: 0x0065FAAC File Offset: 0x0065DCAC
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x0602EC59 RID: 191577 RVA: 0x0065FAC8 File Offset: 0x0065DCC8
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x1700C834 RID: 51252
		// (get) Token: 0x0602EC5A RID: 191578 RVA: 0x0065FAE4 File Offset: 0x0065DCE4
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

		// Token: 0x1700C835 RID: 51253
		// (get) Token: 0x0602EC5B RID: 191579 RVA: 0x0065FB44 File Offset: 0x0065DD44
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

		// Token: 0x0602EC5C RID: 191580 RVA: 0x0065FBA2 File Offset: 0x0065DDA2
		public static Offset<IClientTeleportVehicle> CreateIClientTeleportVehicle(FlatBufferBuilder builder, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0, Offset<IVectorInfo> PosOffset = default(Offset<IVectorInfo>), Offset<IVectorInfo> RotOffset = default(Offset<IVectorInfo>))
		{
			builder.StartTable(4);
			IClientTeleportVehicle.AddRot(builder, RotOffset);
			IClientTeleportVehicle.AddPos(builder, PosOffset);
			IClientTeleportVehicle.AddTargetVehicle(builder, TargetVehicleOffset);
			IClientTeleportVehicle.AddTargetVehicleType(builder, TargetVehicle_type);
			return IClientTeleportVehicle.EndIClientTeleportVehicle(builder);
		}

		// Token: 0x0602EC5D RID: 191581 RVA: 0x0065FBCE File Offset: 0x0065DDCE
		public static void StartIClientTeleportVehicle(FlatBufferBuilder builder)
		{
			builder.StartTable(4);
		}

		// Token: 0x0602EC5E RID: 191582 RVA: 0x0065FBD7 File Offset: 0x0065DDD7
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(0, (byte)targetVehicleType, 0);
		}

		// Token: 0x0602EC5F RID: 191583 RVA: 0x0065FBE2 File Offset: 0x0065DDE2
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(1, targetVehicleOffset, 0);
		}

		// Token: 0x0602EC60 RID: 191584 RVA: 0x0065FBED File Offset: 0x0065DDED
		public static void AddPos(FlatBufferBuilder builder, Offset<IVectorInfo> posOffset)
		{
			builder.AddOffset(2, posOffset.Value, 0);
		}

		// Token: 0x0602EC61 RID: 191585 RVA: 0x0065FBFD File Offset: 0x0065DDFD
		public static void AddRot(FlatBufferBuilder builder, Offset<IVectorInfo> rotOffset)
		{
			builder.AddOffset(3, rotOffset.Value, 0);
		}

		// Token: 0x0602EC62 RID: 191586 RVA: 0x0065FC0D File Offset: 0x0065DE0D
		public static Offset<IClientTeleportVehicle> EndIClientTeleportVehicle(FlatBufferBuilder builder)
		{
			return new Offset<IClientTeleportVehicle>(builder.EndTable());
		}

		// Token: 0x0602EC63 RID: 191587 RVA: 0x0065FC1C File Offset: 0x0065DE1C
		public IClientTeleportVehicleT UnPack()
		{
			IClientTeleportVehicleT clientTeleportVehicleT = new IClientTeleportVehicleT();
			this.UnPackTo(clientTeleportVehicleT);
			return clientTeleportVehicleT;
		}

		// Token: 0x0602EC64 RID: 191588 RVA: 0x0065FC38 File Offset: 0x0065DE38
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

		// Token: 0x0602EC65 RID: 191589 RVA: 0x0065FE8C File Offset: 0x0065E08C
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

		// Token: 0x0401180E RID: 71694
		private Table __p;
	}
}
