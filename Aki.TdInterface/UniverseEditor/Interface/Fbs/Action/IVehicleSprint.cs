using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007532 RID: 30002
	public struct IVehicleSprint : IFlatbufferObject
	{
		// Token: 0x1700E3AD RID: 58285
		// (get) Token: 0x06036961 RID: 223585 RVA: 0x0076A9B9 File Offset: 0x00768BB9
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036962 RID: 223586 RVA: 0x0076A9C6 File Offset: 0x00768BC6
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036963 RID: 223587 RVA: 0x0076A9D0 File Offset: 0x00768BD0
		public static IVehicleSprint GetRootAsIVehicleSprint(ByteBuffer _bb)
		{
			return IVehicleSprint.GetRootAsIVehicleSprint(_bb, default(IVehicleSprint));
		}

		// Token: 0x06036964 RID: 223588 RVA: 0x0076A9EC File Offset: 0x00768BEC
		public static IVehicleSprint GetRootAsIVehicleSprint(ByteBuffer _bb, IVehicleSprint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036965 RID: 223589 RVA: 0x0076AA09 File Offset: 0x00768C09
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036966 RID: 223590 RVA: 0x0076AA18 File Offset: 0x00768C18
		public IVehicleSprint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E3AE RID: 58286
		// (get) Token: 0x06036967 RID: 223591 RVA: 0x0076AA28 File Offset: 0x00768C28
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

		// Token: 0x06036968 RID: 223592 RVA: 0x0076AA64 File Offset: 0x00768C64
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036969 RID: 223593 RVA: 0x0076AAA8 File Offset: 0x00768CA8
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x0603696A RID: 223594 RVA: 0x0076AAC4 File Offset: 0x00768CC4
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x0603696B RID: 223595 RVA: 0x0076AAE0 File Offset: 0x00768CE0
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x0603696C RID: 223596 RVA: 0x0076AAFC File Offset: 0x00768CFC
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x0603696D RID: 223597 RVA: 0x0076AB18 File Offset: 0x00768D18
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x0603696E RID: 223598 RVA: 0x0076AB34 File Offset: 0x00768D34
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x0603696F RID: 223599 RVA: 0x0076AB50 File Offset: 0x00768D50
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x06036970 RID: 223600 RVA: 0x0076AB6B File Offset: 0x00768D6B
		public static Offset<IVehicleSprint> CreateIVehicleSprint(FlatBufferBuilder builder, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0)
		{
			builder.StartTable(2);
			IVehicleSprint.AddTargetVehicle(builder, TargetVehicleOffset);
			IVehicleSprint.AddTargetVehicleType(builder, TargetVehicle_type);
			return IVehicleSprint.EndIVehicleSprint(builder);
		}

		// Token: 0x06036971 RID: 223601 RVA: 0x0076AB88 File Offset: 0x00768D88
		public static void StartIVehicleSprint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06036972 RID: 223602 RVA: 0x0076AB91 File Offset: 0x00768D91
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(0, (byte)targetVehicleType, 0);
		}

		// Token: 0x06036973 RID: 223603 RVA: 0x0076AB9C File Offset: 0x00768D9C
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(1, targetVehicleOffset, 0);
		}

		// Token: 0x06036974 RID: 223604 RVA: 0x0076ABA7 File Offset: 0x00768DA7
		public static Offset<IVehicleSprint> EndIVehicleSprint(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleSprint>(builder.EndTable());
		}

		// Token: 0x06036975 RID: 223605 RVA: 0x0076ABB4 File Offset: 0x00768DB4
		public IVehicleSprintT UnPack()
		{
			IVehicleSprintT vehicleSprintT = new IVehicleSprintT();
			this.UnPackTo(vehicleSprintT);
			return vehicleSprintT;
		}

		// Token: 0x06036976 RID: 223606 RVA: 0x0076ABD0 File Offset: 0x00768DD0
		public void UnPackTo(IVehicleSprintT _o)
		{
			_o.TargetVehicle = new TTargetVehicleUnion();
			_o.TargetVehicle.Type = this.TargetVehicleType;
			switch (this.TargetVehicleType)
			{
			case TTargetVehicle.IAppointedVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IAppointedVehicle>() != null) ? this.TargetVehicle<IAppointedVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ICurrentVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ICurrentVehicle>() != null) ? this.TargetVehicle<ICurrentVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IFishingBoatVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IFishingBoatVehicle>() != null) ? this.TargetVehicle<IFishingBoatVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ISelfVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ISelfVehicle>() != null) ? this.TargetVehicle<ISelfVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.ITriggeredVehicle:
				_o.TargetVehicle.Value = ((this.TargetVehicle<ITriggeredVehicle>() != null) ? this.TargetVehicle<ITriggeredVehicle>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IVehiclePlayerMotor:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehiclePlayerMotor>() != null) ? this.TargetVehicle<IVehiclePlayerMotor>().Value.UnPack() : null);
				return;
			case TTargetVehicle.IVehicleTeam:
				_o.TargetVehicle.Value = ((this.TargetVehicle<IVehicleTeam>() != null) ? this.TargetVehicle<IVehicleTeam>().Value.UnPack() : null);
				return;
			default:
				return;
			}
		}

		// Token: 0x06036977 RID: 223607 RVA: 0x0076ADA8 File Offset: 0x00768FA8
		public static Offset<IVehicleSprint> Pack(FlatBufferBuilder builder, IVehicleSprintT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleSprint>);
			}
			TTargetVehicle targetVehicle_type = (_o.TargetVehicle == null) ? TTargetVehicle.NONE : _o.TargetVehicle.Type;
			int targetVehicleOffset = (_o.TargetVehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.TargetVehicle);
			return IVehicleSprint.CreateIVehicleSprint(builder, targetVehicle_type, targetVehicleOffset);
		}

		// Token: 0x04012426 RID: 74790
		private Table __p;
	}
}
