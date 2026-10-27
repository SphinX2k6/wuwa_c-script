using System;
using Aki.UniverseEditor.Interface.Fbs.Common;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x0200709D RID: 28829
	public struct ISetTotalVehicleSpeedImmediately : IFlatbufferObject
	{
		// Token: 0x1700D62F RID: 54831
		// (get) Token: 0x060330BB RID: 209083 RVA: 0x006E28BE File Offset: 0x006E0ABE
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060330BC RID: 209084 RVA: 0x006E28CB File Offset: 0x006E0ACB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060330BD RID: 209085 RVA: 0x006E28D4 File Offset: 0x006E0AD4
		public static ISetTotalVehicleSpeedImmediately GetRootAsISetTotalVehicleSpeedImmediately(ByteBuffer _bb)
		{
			return ISetTotalVehicleSpeedImmediately.GetRootAsISetTotalVehicleSpeedImmediately(_bb, default(ISetTotalVehicleSpeedImmediately));
		}

		// Token: 0x060330BE RID: 209086 RVA: 0x006E28F0 File Offset: 0x006E0AF0
		public static ISetTotalVehicleSpeedImmediately GetRootAsISetTotalVehicleSpeedImmediately(ByteBuffer _bb, ISetTotalVehicleSpeedImmediately obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060330BF RID: 209087 RVA: 0x006E290D File Offset: 0x006E0B0D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060330C0 RID: 209088 RVA: 0x006E291C File Offset: 0x006E0B1C
		public ISetTotalVehicleSpeedImmediately __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D630 RID: 54832
		// (get) Token: 0x060330C1 RID: 209089 RVA: 0x006E292C File Offset: 0x006E0B2C
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

		// Token: 0x1700D631 RID: 54833
		// (get) Token: 0x060330C2 RID: 209090 RVA: 0x006E2968 File Offset: 0x006E0B68
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

		// Token: 0x060330C3 RID: 209091 RVA: 0x006E29A4 File Offset: 0x006E0BA4
		public TTable? Speed<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x060330C4 RID: 209092 RVA: 0x006E29E8 File Offset: 0x006E0BE8
		public IProcessedValueConstant SpeedAsIProcessedValueConstant()
		{
			return this.Speed<IProcessedValueConstant>().Value;
		}

		// Token: 0x060330C5 RID: 209093 RVA: 0x006E2A04 File Offset: 0x006E0C04
		public IProcessedValueConstraint SpeedAsIProcessedValueConstraint()
		{
			return this.Speed<IProcessedValueConstraint>().Value;
		}

		// Token: 0x060330C6 RID: 209094 RVA: 0x006E2A1F File Offset: 0x006E0C1F
		public static Offset<ISetTotalVehicleSpeedImmediately> CreateISetTotalVehicleSpeedImmediately(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType Type = ESetVehicleSpeedImmediatelyType.TotalSpeed, TProcessedValue Speed_type = TProcessedValue.NONE, int SpeedOffset = 0)
		{
			builder.StartTable(3);
			ISetTotalVehicleSpeedImmediately.AddSpeed(builder, SpeedOffset);
			ISetTotalVehicleSpeedImmediately.AddSpeedType(builder, Speed_type);
			ISetTotalVehicleSpeedImmediately.AddType(builder, Type);
			return ISetTotalVehicleSpeedImmediately.EndISetTotalVehicleSpeedImmediately(builder);
		}

		// Token: 0x060330C7 RID: 209095 RVA: 0x006E2A43 File Offset: 0x006E0C43
		public static void StartISetTotalVehicleSpeedImmediately(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060330C8 RID: 209096 RVA: 0x006E2A4C File Offset: 0x006E0C4C
		public static void AddType(FlatBufferBuilder builder, ESetVehicleSpeedImmediatelyType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060330C9 RID: 209097 RVA: 0x006E2A57 File Offset: 0x006E0C57
		public static void AddSpeedType(FlatBufferBuilder builder, TProcessedValue speedType)
		{
			builder.AddByte(1, (byte)speedType, 0);
		}

		// Token: 0x060330CA RID: 209098 RVA: 0x006E2A62 File Offset: 0x006E0C62
		public static void AddSpeed(FlatBufferBuilder builder, int speedOffset)
		{
			builder.AddOffset(2, speedOffset, 0);
		}

		// Token: 0x060330CB RID: 209099 RVA: 0x006E2A6D File Offset: 0x006E0C6D
		public static Offset<ISetTotalVehicleSpeedImmediately> EndISetTotalVehicleSpeedImmediately(FlatBufferBuilder builder)
		{
			return new Offset<ISetTotalVehicleSpeedImmediately>(builder.EndTable());
		}

		// Token: 0x060330CC RID: 209100 RVA: 0x006E2A7C File Offset: 0x006E0C7C
		public ISetTotalVehicleSpeedImmediatelyT UnPack()
		{
			ISetTotalVehicleSpeedImmediatelyT setTotalVehicleSpeedImmediatelyT = new ISetTotalVehicleSpeedImmediatelyT();
			this.UnPackTo(setTotalVehicleSpeedImmediatelyT);
			return setTotalVehicleSpeedImmediatelyT;
		}

		// Token: 0x060330CD RID: 209101 RVA: 0x006E2A98 File Offset: 0x006E0C98
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

		// Token: 0x060330CE RID: 209102 RVA: 0x006E2B48 File Offset: 0x006E0D48
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

		// Token: 0x04011B05 RID: 72453
		private Table __p;
	}
}
