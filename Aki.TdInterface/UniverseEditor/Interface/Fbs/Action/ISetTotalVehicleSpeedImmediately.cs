using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007869 RID: 30825
	public struct ISetTotalVehicleSpeedImmediately : IFlatbufferObject
	{
		// Token: 0x1700E212 RID: 57874
		// (get) Token: 0x0603635D RID: 222045 RVA: 0x00742ECA File Offset: 0x007410CA
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603635E RID: 222046 RVA: 0x00742ED7 File Offset: 0x007410D7
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603635F RID: 222047 RVA: 0x00742EE0 File Offset: 0x007410E0
		public static ISetTotalVehicleSpeedImmediately GetRootAsISetTotalVehicleSpeedImmediately(ByteBuffer _bb)
		{
			return ISetTotalVehicleSpeedImmediately.GetRootAsISetTotalVehicleSpeedImmediately(_bb, default(ISetTotalVehicleSpeedImmediately));
		}

		// Token: 0x06036360 RID: 222048 RVA: 0x00742EFC File Offset: 0x007410FC
		public static ISetTotalVehicleSpeedImmediately GetRootAsISetTotalVehicleSpeedImmediately(ByteBuffer _bb, ISetTotalVehicleSpeedImmediately obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036361 RID: 222049 RVA: 0x00742F19 File Offset: 0x00741119
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036362 RID: 222050 RVA: 0x00742F28 File Offset: 0x00741128
		public ISetTotalVehicleSpeedImmediately __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E213 RID: 57875
		// (get) Token: 0x06036363 RID: 222051 RVA: 0x00742F38 File Offset: 0x00741138
		public ESetVehicleSpeedImmediatelyType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetVehicleSpeedImmediatelyType.TotalSpeed;
				}
				return (ESetVehicleSpeedImmediatelyType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E214 RID: 57876
		// (get) Token: 0x06036364 RID: 222052 RVA: 0x00742F74 File Offset: 0x00741174
		public TProcessedValue SpeedType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return TProcessedValue.NONE;
				}
				return (TProcessedValue)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06036365 RID: 222053 RVA: 0x00742FB0 File Offset: 0x007411B0
		public TTable? Speed<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06036366 RID: 222054 RVA: 0x00742FF4 File Offset: 0x007411F4
		public IProcessedValueConstant SpeedAsIProcessedValueConstant()
		{
			return this.Speed<IProcessedValueConstant>().Value;
		}

		// Token: 0x06036367 RID: 222055 RVA: 0x00743010 File Offset: 0x00741210
		public IProcessedValueConstraint SpeedAsIProcessedValueConstraint()
		{
			return this.Speed<IProcessedValueConstraint>().Value;
		}

		// Token: 0x06036368 RID: 222056 RVA: 0x0074302B File Offset: 0x0074122B
		public static Offset<ISetTotalVehicleSpeedImmediately> CreateISetTotalVehicleSpeedImmediately(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType Type = ESetVehicleSpeedImmediatelyType.TotalSpeed, TProcessedValue Speed_type = TProcessedValue.NONE, int SpeedOffset = 0)
		{
			builder.StartTable(3);
			ISetTotalVehicleSpeedImmediately.AddSpeed(builder, SpeedOffset);
			ISetTotalVehicleSpeedImmediately.AddSpeedType(builder, Speed_type);
			ISetTotalVehicleSpeedImmediately.AddType(builder, Type);
			return ISetTotalVehicleSpeedImmediately.EndISetTotalVehicleSpeedImmediately(builder);
		}

		// Token: 0x06036369 RID: 222057 RVA: 0x0074304F File Offset: 0x0074124F
		public static void StartISetTotalVehicleSpeedImmediately(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0603636A RID: 222058 RVA: 0x00743058 File Offset: 0x00741258
		public static void AddType(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603636B RID: 222059 RVA: 0x00743063 File Offset: 0x00741263
		public static void AddSpeedType(FlatBufferBuilder builder, TProcessedValue speedType)
		{
			builder.AddByte(1, (byte)speedType, 0);
		}

		// Token: 0x0603636C RID: 222060 RVA: 0x0074306E File Offset: 0x0074126E
		public static void AddSpeed(FlatBufferBuilder builder, int speedOffset)
		{
			builder.AddOffset(2, speedOffset, 0);
		}

		// Token: 0x0603636D RID: 222061 RVA: 0x00743079 File Offset: 0x00741279
		public static Offset<ISetTotalVehicleSpeedImmediately> EndISetTotalVehicleSpeedImmediately(FlatBufferBuilder builder)
		{
			return new Offset<ISetTotalVehicleSpeedImmediately>(builder.EndTable());
		}

		// Token: 0x0603636E RID: 222062 RVA: 0x00743088 File Offset: 0x00741288
		public ISetTotalVehicleSpeedImmediatelyT UnPack()
		{
			ISetTotalVehicleSpeedImmediatelyT setTotalVehicleSpeedImmediatelyT = new ISetTotalVehicleSpeedImmediatelyT();
			this.UnPackTo(setTotalVehicleSpeedImmediatelyT);
			return setTotalVehicleSpeedImmediatelyT;
		}

		// Token: 0x0603636F RID: 222063 RVA: 0x007430A4 File Offset: 0x007412A4
		public void UnPackTo(ISetTotalVehicleSpeedImmediatelyT _o)
		{
			_o.Type = this.Type;
			_o.Speed = new TProcessedValueUnion();
			_o.Speed.Type = this.SpeedType;
			TProcessedValue speedType = this.SpeedType;
			if (speedType == TProcessedValue.IProcessedValueConstant)
			{
				_o.Speed.Value = ((this.Speed<IProcessedValueConstant>() != null) ? this.Speed<IProcessedValueConstant>().Value.UnPack() : null);
				return;
			}
			if (speedType != TProcessedValue.IProcessedValueConstraint)
			{
				return;
			}
			_o.Speed.Value = ((this.Speed<IProcessedValueConstraint>() != null) ? this.Speed<IProcessedValueConstraint>().Value.UnPack() : null);
		}

		// Token: 0x06036370 RID: 222064 RVA: 0x00743154 File Offset: 0x00741354
		public static Offset<ISetTotalVehicleSpeedImmediately> Pack(FlatBufferBuilder builder, ISetTotalVehicleSpeedImmediatelyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetTotalVehicleSpeedImmediately>);
			}
			TProcessedValue speed_type = (_o.Speed == null) ? TProcessedValue.NONE : _o.Speed.Type;
			int speedOffset = (_o.Speed == null) ? 0 : TProcessedValueUnion.Pack(builder, _o.Speed);
			return ISetTotalVehicleSpeedImmediately.CreateISetTotalVehicleSpeedImmediately(builder, _o.Type, speed_type, speedOffset);
		}

		// Token: 0x04012AF3 RID: 76531
		private Table __p;
	}
}
