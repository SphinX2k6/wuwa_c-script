using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007D1C RID: 32028
	public struct IVehicleNewSplineStopTarget : IFlatbufferObject
	{
		// Token: 0x1700EFBF RID: 61375
		// (get) Token: 0x06039D02 RID: 236802 RVA: 0x007CCCD0 File Offset: 0x007CAED0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06039D03 RID: 236803 RVA: 0x007CCCDD File Offset: 0x007CAEDD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06039D04 RID: 236804 RVA: 0x007CCCE4 File Offset: 0x007CAEE4
		public static IVehicleNewSplineStopTarget GetRootAsIVehicleNewSplineStopTarget(ByteBuffer _bb)
		{
			return IVehicleNewSplineStopTarget.GetRootAsIVehicleNewSplineStopTarget(_bb, default(IVehicleNewSplineStopTarget));
		}

		// Token: 0x06039D05 RID: 236805 RVA: 0x007CCD00 File Offset: 0x007CAF00
		public static IVehicleNewSplineStopTarget GetRootAsIVehicleNewSplineStopTarget(ByteBuffer _bb, IVehicleNewSplineStopTarget obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06039D06 RID: 236806 RVA: 0x007CCD1D File Offset: 0x007CAF1D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06039D07 RID: 236807 RVA: 0x007CCD2C File Offset: 0x007CAF2C
		public IVehicleNewSplineStopTarget __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700EFC0 RID: 61376
		// (get) Token: 0x06039D08 RID: 236808 RVA: 0x007CCD3C File Offset: 0x007CAF3C
		public ENewSplineMoveTargetType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ENewSplineMoveTargetType.Player;
				}
				return (ENewSplineMoveTargetType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700EFC1 RID: 61377
		// (get) Token: 0x06039D09 RID: 236809 RVA: 0x007CCD78 File Offset: 0x007CAF78
		public TTargetVehicle TargetVehicleType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TTargetVehicle.NONE;
				}
				return (TTargetVehicle)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06039D0A RID: 236810 RVA: 0x007CCDB4 File Offset: 0x007CAFB4
		public TTable? TargetVehicle<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06039D0B RID: 236811 RVA: 0x007CCDF8 File Offset: 0x007CAFF8
		public IAppointedVehicle TargetVehicleAsIAppointedVehicle()
		{
			return this.TargetVehicle<IAppointedVehicle>().Value;
		}

		// Token: 0x06039D0C RID: 236812 RVA: 0x007CCE14 File Offset: 0x007CB014
		public ICurrentVehicle TargetVehicleAsICurrentVehicle()
		{
			return this.TargetVehicle<ICurrentVehicle>().Value;
		}

		// Token: 0x06039D0D RID: 236813 RVA: 0x007CCE30 File Offset: 0x007CB030
		public IFishingBoatVehicle TargetVehicleAsIFishingBoatVehicle()
		{
			return this.TargetVehicle<IFishingBoatVehicle>().Value;
		}

		// Token: 0x06039D0E RID: 236814 RVA: 0x007CCE4C File Offset: 0x007CB04C
		public ISelfVehicle TargetVehicleAsISelfVehicle()
		{
			return this.TargetVehicle<ISelfVehicle>().Value;
		}

		// Token: 0x06039D0F RID: 236815 RVA: 0x007CCE68 File Offset: 0x007CB068
		public ITriggeredVehicle TargetVehicleAsITriggeredVehicle()
		{
			return this.TargetVehicle<ITriggeredVehicle>().Value;
		}

		// Token: 0x06039D10 RID: 236816 RVA: 0x007CCE84 File Offset: 0x007CB084
		public IVehiclePlayerMotor TargetVehicleAsIVehiclePlayerMotor()
		{
			return this.TargetVehicle<IVehiclePlayerMotor>().Value;
		}

		// Token: 0x06039D11 RID: 236817 RVA: 0x007CCEA0 File Offset: 0x007CB0A0
		public IVehicleTeam TargetVehicleAsIVehicleTeam()
		{
			return this.TargetVehicle<IVehicleTeam>().Value;
		}

		// Token: 0x06039D12 RID: 236818 RVA: 0x007CCEBB File Offset: 0x007CB0BB
		public static Offset<IVehicleNewSplineStopTarget> CreateIVehicleNewSplineStopTarget(FlatBufferBuilder builder, ENewSplineMoveTargetType Type = ENewSplineMoveTargetType.Player, TTargetVehicle TargetVehicle_type = TTargetVehicle.NONE, int TargetVehicleOffset = 0)
		{
			builder.StartTable(3);
			IVehicleNewSplineStopTarget.AddTargetVehicle(builder, TargetVehicleOffset);
			IVehicleNewSplineStopTarget.AddTargetVehicleType(builder, TargetVehicle_type);
			IVehicleNewSplineStopTarget.AddType(builder, Type);
			return IVehicleNewSplineStopTarget.EndIVehicleNewSplineStopTarget(builder);
		}

		// Token: 0x06039D13 RID: 236819 RVA: 0x007CCEDF File Offset: 0x007CB0DF
		public static void StartIVehicleNewSplineStopTarget(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06039D14 RID: 236820 RVA: 0x007CCEE8 File Offset: 0x007CB0E8
		public static void AddType(FlatBufferBuilder builder, ENewSplineMoveTargetType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06039D15 RID: 236821 RVA: 0x007CCEF3 File Offset: 0x007CB0F3
		public static void AddTargetVehicleType(FlatBufferBuilder builder, TTargetVehicle targetVehicleType)
		{
			builder.AddByte(1, (byte)targetVehicleType, 0);
		}

		// Token: 0x06039D16 RID: 236822 RVA: 0x007CCEFE File Offset: 0x007CB0FE
		public static void AddTargetVehicle(FlatBufferBuilder builder, int targetVehicleOffset)
		{
			builder.AddOffset(2, targetVehicleOffset, 0);
		}

		// Token: 0x06039D17 RID: 236823 RVA: 0x007CCF09 File Offset: 0x007CB109
		public static Offset<IVehicleNewSplineStopTarget> EndIVehicleNewSplineStopTarget(FlatBufferBuilder builder)
		{
			return new Offset<IVehicleNewSplineStopTarget>(builder.EndTable());
		}

		// Token: 0x06039D18 RID: 236824 RVA: 0x007CCF18 File Offset: 0x007CB118
		public IVehicleNewSplineStopTargetT UnPack()
		{
			IVehicleNewSplineStopTargetT vehicleNewSplineStopTargetT = new IVehicleNewSplineStopTargetT();
			this.UnPackTo(vehicleNewSplineStopTargetT);
			return vehicleNewSplineStopTargetT;
		}

		// Token: 0x06039D19 RID: 236825 RVA: 0x007CCF34 File Offset: 0x007CB134
		public void UnPackTo(IVehicleNewSplineStopTargetT _o)
		{
			_o.Type = this.Type;
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

		// Token: 0x06039D1A RID: 236826 RVA: 0x007CD118 File Offset: 0x007CB318
		public static Offset<IVehicleNewSplineStopTarget> Pack(FlatBufferBuilder builder, IVehicleNewSplineStopTargetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IVehicleNewSplineStopTarget>);
			}
			TTargetVehicle targetVehicle_type = (_o.TargetVehicle == null) ? TTargetVehicle.NONE : _o.TargetVehicle.Type;
			int targetVehicleOffset = (_o.TargetVehicle == null) ? 0 : TTargetVehicleUnion.Pack(builder, _o.TargetVehicle);
			return IVehicleNewSplineStopTarget.CreateIVehicleNewSplineStopTarget(builder, _o.Type, targetVehicle_type, targetVehicleOffset);
		}

		// Token: 0x04013449 RID: 78921
		private Table __p;
	}
}
