using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D28 RID: 32040
	public struct IVehicleSprint : IFlatbufferObject
	{
		// Token: 0x1700EFD7 RID: 61399
		// (get) Token: 0x06039D77 RID: 236919 RVA: 0x007CDC61 File Offset: 0x007CBE61
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039D78 RID: 236920 RVA: 0x007CDC6E File Offset: 0x007CBE6E
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039D79 RID: 236921 RVA: 0x007CDC78 File Offset: 0x007CBE78
		public static IVehicleSprint GetRootAsIVehicleSprint(ByteBuffer _bb)
		{
			return IVehicleSprint.GetRootAsIVehicleSprint(_bb, default(IVehicleSprint));
		}

		// Token: 0x06039D7A RID: 236922 RVA: 0x007CDC94 File Offset: 0x007CBE94
		public static IVehicleSprint GetRootAsIVehicleSprint(ByteBuffer _bb, IVehicleSprint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039D7B RID: 236923 RVA: 0x007CDCB1 File Offset: 0x007CBEB1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039D7C RID: 236924 RVA: 0x007CDCC0 File Offset: 0x007CBEC0
		public IVehicleSprint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFD8 RID: 61400
		// (get) Token: 0x06039D7D RID: 236925 RVA: 0x007CDCD0 File Offset: 0x007CBED0
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

		// Token: 0x06039D7E RID: 236926 RVA: 0x007CDD0C File Offset: 0x007CBF0C
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039D7F RID: 236927 RVA: 0x007CDD50 File Offset: 0x007CBF50
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x06039D80 RID: 236928 RVA: 0x007CDD6C File Offset: 0x007CBF6C
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x06039D81 RID: 236929 RVA: 0x007CDD88 File Offset: 0x007CBF88
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06039D82 RID: 236930 RVA: 0x007CDDA4 File Offset: 0x007CBFA4
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x06039D83 RID: 236931 RVA: 0x007CDDC0 File Offset: 0x007CBFC0
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x06039D84 RID: 236932 RVA: 0x007CDDDC File Offset: 0x007CBFDC
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06039D85 RID: 236933 RVA: 0x007CDDF8 File Offset: 0x007CBFF8
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x06039D86 RID: 236934 RVA: 0x007CDE13 File Offset: 0x007CC013
		public static Offset<IVehicleSprint> CreateIVehicleSprint(FlatBufferBuilder builder, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0)
		{
			builder.StartTable(2);
			IVehicleSprint.AddTargetVehicle(builder, TargetVehicleOffset);
			IVehicleSprint.AddTargetVehicleType(builder, TargetVehicle_type);
			return IVehicleSprint.EndIVehicleSprint(builder);
		}

		// Token: 0x06039D87 RID: 236935 RVA: 0x007CDE30 File Offset: 0x007CC030
		public static void StartIVehicleSprint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06039D88 RID: 236936 RVA: 0x007CDE39 File Offset: 0x007CC039
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(0, (byte)targetVehicleType, 0);
		}

		// Token: 0x06039D89 RID: 236937 RVA: 0x007CDE44 File Offset: 0x007CC044
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(1, targetVehicleOffset, 0);
		}

		// Token: 0x06039D8A RID: 236938 RVA: 0x007CDE4F File Offset: 0x007CC04F
		public static Offset<IVehicleSprint> EndIVehicleSprint(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleSprint>(builder.EndTable());
		}

		// Token: 0x06039D8B RID: 236939 RVA: 0x007CDE5C File Offset: 0x007CC05C
		public IVehicleSprintT UnPack()
		{
			IVehicleSprintT vehicleSprintT = new IVehicleSprintT();
			this.UnPackTo(vehicleSprintT);
			return vehicleSprintT;
		}

		// Token: 0x06039D8C RID: 236940 RVA: 0x007CDE78 File Offset: 0x007CC078
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

		// Token: 0x06039D8D RID: 236941 RVA: 0x007CE050 File Offset: 0x007CC250
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

		// Token: 0x04013457 RID: 78935
		private Table __p;
	}
}
