using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005527 RID: 21799
	public struct IMatchTargetChargingDevice : IFlatbufferObject
	{
		// Token: 0x1700A0EC RID: 41196
		// (get) Token: 0x0602402B RID: 147499 RVA: 0x004F9D9F File Offset: 0x004F7F9F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602402C RID: 147500 RVA: 0x004F9DAC File Offset: 0x004F7FAC
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602402D RID: 147501 RVA: 0x004F9DB4 File Offset: 0x004F7FB4
		public static IMatchTargetChargingDevice GetRootAsIMatchTargetChargingDevice(ByteBuffer _bb)
		{
			return IMatchTargetChargingDevice.GetRootAsIMatchTargetChargingDevice(_bb, default(IMatchTargetChargingDevice));
		}

		// Token: 0x0602402E RID: 147502 RVA: 0x004F9DD0 File Offset: 0x004F7FD0
		public static IMatchTargetChargingDevice GetRootAsIMatchTargetChargingDevice(ByteBuffer _bb, IMatchTargetChargingDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602402F RID: 147503 RVA: 0x004F9DED File Offset: 0x004F7FED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06024030 RID: 147504 RVA: 0x004F9DFC File Offset: 0x004F7FFC
		public IMatchTargetChargingDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A0ED RID: 41197
		// (get) Token: 0x06024031 RID: 147505 RVA: 0x004F9E0C File Offset: 0x004F800C
		public EProgressBarControlType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EProgressBarControlType.CaptureStrategicPoint;
				}
				return (EProgressBarControlType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A0EE RID: 41198
		// (get) Token: 0x06024032 RID: 147506 RVA: 0x004F9E48 File Offset: 0x004F8048
		public int MaxValue
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A0EF RID: 41199
		// (get) Token: 0x06024033 RID: 147507 RVA: 0x004F9E84 File Offset: 0x004F8084
		public int InitValue
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

		// Token: 0x1700A0F0 RID: 41200
		// (get) Token: 0x06024034 RID: 147508 RVA: 0x004F9EC0 File Offset: 0x004F80C0
		public int ProgressPerformanceAttribute
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A0F1 RID: 41201
		// (get) Token: 0x06024035 RID: 147509 RVA: 0x004F9F00 File Offset: 0x004F8100
		public IEntityMatch? Match
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IEntityMatch?(default(IEntityMatch).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A0F2 RID: 41202
		// (get) Token: 0x06024036 RID: 147510 RVA: 0x004F9F60 File Offset: 0x004F8160
		public int IncreaseSpeed
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A0F3 RID: 41203
		// (get) Token: 0x06024037 RID: 147511 RVA: 0x004F9FA0 File Offset: 0x004F81A0
		public int DecreaseSpeed
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700A0F4 RID: 41204
		// (get) Token: 0x06024038 RID: 147512 RVA: 0x004F9FE0 File Offset: 0x004F81E0
		public bool RayCastCheck
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A0F5 RID: 41205
		// (get) Token: 0x06024039 RID: 147513 RVA: 0x004FA020 File Offset: 0x004F8220
		public IVectorInfo? RayCastCenter
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700A0F6 RID: 41206
		// (get) Token: 0x0602403A RID: 147514 RVA: 0x004FA080 File Offset: 0x004F8280
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602403B RID: 147515 RVA: 0x004FA0C0 File Offset: 0x004F82C0
		public static Offset<IMatchTargetChargingDevice> CreateIMatchTargetChargingDevice(FlatBufferBuilder builder, EProgressBarControlType Type = EProgressBarControlType.CaptureStrategicPoint, int MaxValue = 0, int InitValue = 0, int ProgressPerformanceAttribute = 0, Offset<IEntityMatch> MatchOffset = default(Offset<IEntityMatch>), int IncreaseSpeed = 0, int DecreaseSpeed = 0, bool RayCastCheck = false, Offset<IVectorInfo> RayCastCenterOffset = default(Offset<IVectorInfo>), byte NullMask = 0)
		{
			builder.StartTable(10);
			IMatchTargetChargingDevice.AddRayCastCenter(builder, RayCastCenterOffset);
			IMatchTargetChargingDevice.AddDecreaseSpeed(builder, DecreaseSpeed);
			IMatchTargetChargingDevice.AddIncreaseSpeed(builder, IncreaseSpeed);
			IMatchTargetChargingDevice.AddMatch(builder, MatchOffset);
			IMatchTargetChargingDevice.AddProgressPerformanceAttribute(builder, ProgressPerformanceAttribute);
			IMatchTargetChargingDevice.AddInitValue(builder, InitValue);
			IMatchTargetChargingDevice.AddMaxValue(builder, MaxValue);
			IMatchTargetChargingDevice.AddNullMask(builder, NullMask);
			IMatchTargetChargingDevice.AddRayCastCheck(builder, RayCastCheck);
			IMatchTargetChargingDevice.AddType(builder, Type);
			return IMatchTargetChargingDevice.EndIMatchTargetChargingDevice(builder);
		}

		// Token: 0x0602403C RID: 147516 RVA: 0x004FA128 File Offset: 0x004F8328
		public static void StartIMatchTargetChargingDevice(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x0602403D RID: 147517 RVA: 0x004FA132 File Offset: 0x004F8332
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602403E RID: 147518 RVA: 0x004FA13D File Offset: 0x004F833D
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x0602403F RID: 147519 RVA: 0x004FA148 File Offset: 0x004F8348
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x06024040 RID: 147520 RVA: 0x004FA153 File Offset: 0x004F8353
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x06024041 RID: 147521 RVA: 0x004FA15E File Offset: 0x004F835E
		public static void AddMatch(FlatBufferBuilder builder, Offset<IEntityMatch> matchOffset)
		{
			builder.AddOffset(4, matchOffset.Value, 0);
		}

		// Token: 0x06024042 RID: 147522 RVA: 0x004FA16E File Offset: 0x004F836E
		public static void AddIncreaseSpeed(FlatBufferBuilder builder, int increaseSpeed)
		{
			builder.AddInt(5, increaseSpeed, 0);
		}

		// Token: 0x06024043 RID: 147523 RVA: 0x004FA179 File Offset: 0x004F8379
		public static void AddDecreaseSpeed(FlatBufferBuilder builder, int decreaseSpeed)
		{
			builder.AddInt(6, decreaseSpeed, 0);
		}

		// Token: 0x06024044 RID: 147524 RVA: 0x004FA184 File Offset: 0x004F8384
		public static void AddRayCastCheck(FlatBufferBuilder builder, bool rayCastCheck)
		{
			builder.AddBool(7, rayCastCheck, false);
		}

		// Token: 0x06024045 RID: 147525 RVA: 0x004FA18F File Offset: 0x004F838F
		public static void AddRayCastCenter(FlatBufferBuilder builder, Offset<IVectorInfo> rayCastCenterOffset)
		{
			builder.AddOffset(8, rayCastCenterOffset.Value, 0);
		}

		// Token: 0x06024046 RID: 147526 RVA: 0x004FA19F File Offset: 0x004F839F
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06024047 RID: 147527 RVA: 0x004FA1AB File Offset: 0x004F83AB
		public static Offset<IMatchTargetChargingDevice> EndIMatchTargetChargingDevice(FlatBufferBuilder builder)
		{
			return new Offset<IMatchTargetChargingDevice>(builder.EndTable());
		}

		// Token: 0x06024048 RID: 147528 RVA: 0x004FA1B8 File Offset: 0x004F83B8
		public IMatchTargetChargingDeviceT UnPack()
		{
			IMatchTargetChargingDeviceT matchTargetChargingDeviceT = new IMatchTargetChargingDeviceT();
			this.UnPackTo(matchTargetChargingDeviceT);
			return matchTargetChargingDeviceT;
		}

		// Token: 0x06024049 RID: 147529 RVA: 0x004FA1D4 File Offset: 0x004F83D4
		public void UnPackTo(IMatchTargetChargingDeviceT _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
			_o.InitValue = this.InitValue;
			_o.ProgressPerformanceAttribute = this.ProgressPerformanceAttribute;
			_o.Match = ((this.Match != null) ? this.Match.Value.UnPack() : null);
			_o.IncreaseSpeed = this.IncreaseSpeed;
			_o.DecreaseSpeed = this.DecreaseSpeed;
			_o.RayCastCheck = this.RayCastCheck;
			_o.RayCastCenter = ((this.RayCastCenter != null) ? this.RayCastCenter.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602404A RID: 147530 RVA: 0x004FA2A0 File Offset: 0x004F84A0
		public static Offset<IMatchTargetChargingDevice> Pack(FlatBufferBuilder builder, IMatchTargetChargingDeviceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMatchTargetChargingDevice>);
			}
			Offset<IEntityMatch> matchOffset = (_o.Match == null) ? default(Offset<IEntityMatch>) : IEntityMatch.Pack(builder, _o.Match);
			Offset<IVectorInfo> rayCastCenterOffset = (_o.RayCastCenter == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.RayCastCenter);
			return IMatchTargetChargingDevice.CreateIMatchTargetChargingDevice(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, matchOffset, _o.IncreaseSpeed, _o.DecreaseSpeed, _o.RayCastCheck, rayCastCenterOffset, _o.NullMask);
		}

		// Token: 0x0400E81D RID: 59421
		private Table __p;
	}
}
