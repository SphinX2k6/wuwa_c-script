using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02004F8E RID: 20366
	public struct IChargingDevice : IFlatbufferObject
	{
		// Token: 0x1700934D RID: 37709
		// (get) Token: 0x060205C1 RID: 132545 RVA: 0x004809FB File Offset: 0x0047EBFB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060205C2 RID: 132546 RVA: 0x00480A08 File Offset: 0x0047EC08
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060205C3 RID: 132547 RVA: 0x00480A10 File Offset: 0x0047EC10
		public static IChargingDevice GetRootAsIChargingDevice(ByteBuffer _bb)
		{
			return IChargingDevice.GetRootAsIChargingDevice(_bb, default(IChargingDevice));
		}

		// Token: 0x060205C4 RID: 132548 RVA: 0x00480A2C File Offset: 0x0047EC2C
		public static IChargingDevice GetRootAsIChargingDevice(ByteBuffer _bb, IChargingDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060205C5 RID: 132549 RVA: 0x00480A49 File Offset: 0x0047EC49
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060205C6 RID: 132550 RVA: 0x00480A58 File Offset: 0x0047EC58
		public IChargingDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700934E RID: 37710
		// (get) Token: 0x060205C7 RID: 132551 RVA: 0x00480A68 File Offset: 0x0047EC68
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

		// Token: 0x1700934F RID: 37711
		// (get) Token: 0x060205C8 RID: 132552 RVA: 0x00480AA4 File Offset: 0x0047ECA4
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

		// Token: 0x17009350 RID: 37712
		// (get) Token: 0x060205C9 RID: 132553 RVA: 0x00480AE0 File Offset: 0x0047ECE0
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

		// Token: 0x17009351 RID: 37713
		// (get) Token: 0x060205CA RID: 132554 RVA: 0x00480B1C File Offset: 0x0047ED1C
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

		// Token: 0x17009352 RID: 37714
		// (get) Token: 0x060205CB RID: 132555 RVA: 0x00480B5C File Offset: 0x0047ED5C
		public int IncreaseSpeed
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17009353 RID: 37715
		// (get) Token: 0x060205CC RID: 132556 RVA: 0x00480B9C File Offset: 0x0047ED9C
		public int HitExtraValue
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

		// Token: 0x17009354 RID: 37716
		// (get) Token: 0x060205CD RID: 132557 RVA: 0x00480BDC File Offset: 0x0047EDDC
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x060205CE RID: 132558 RVA: 0x00480C1C File Offset: 0x0047EE1C
		public static Offset<IChargingDevice> CreateIChargingDevice(FlatBufferBuilder builder, EProgressBarControlType Type = EProgressBarControlType.CaptureStrategicPoint, int MaxValue = 0, int InitValue = 0, int ProgressPerformanceAttribute = 0, int IncreaseSpeed = 0, int HitExtraValue = 0, byte NullMask = 0)
		{
			builder.StartTable(7);
			IChargingDevice.AddHitExtraValue(builder, HitExtraValue);
			IChargingDevice.AddIncreaseSpeed(builder, IncreaseSpeed);
			IChargingDevice.AddProgressPerformanceAttribute(builder, ProgressPerformanceAttribute);
			IChargingDevice.AddInitValue(builder, InitValue);
			IChargingDevice.AddMaxValue(builder, MaxValue);
			IChargingDevice.AddNullMask(builder, NullMask);
			IChargingDevice.AddType(builder, Type);
			return IChargingDevice.EndIChargingDevice(builder);
		}

		// Token: 0x060205CF RID: 132559 RVA: 0x00480C6B File Offset: 0x0047EE6B
		public static void StartIChargingDevice(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x060205D0 RID: 132560 RVA: 0x00480C74 File Offset: 0x0047EE74
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060205D1 RID: 132561 RVA: 0x00480C7F File Offset: 0x0047EE7F
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x060205D2 RID: 132562 RVA: 0x00480C8A File Offset: 0x0047EE8A
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x060205D3 RID: 132563 RVA: 0x00480C95 File Offset: 0x0047EE95
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x060205D4 RID: 132564 RVA: 0x00480CA0 File Offset: 0x0047EEA0
		public static void AddIncreaseSpeed(FlatBufferBuilder builder, int increaseSpeed)
		{
			builder.AddInt(4, increaseSpeed, 0);
		}

		// Token: 0x060205D5 RID: 132565 RVA: 0x00480CAB File Offset: 0x0047EEAB
		public static void AddHitExtraValue(FlatBufferBuilder builder, int hitExtraValue)
		{
			builder.AddInt(5, hitExtraValue, 0);
		}

		// Token: 0x060205D6 RID: 132566 RVA: 0x00480CB6 File Offset: 0x0047EEB6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x060205D7 RID: 132567 RVA: 0x00480CC1 File Offset: 0x0047EEC1
		public static Offset<IChargingDevice> EndIChargingDevice(FlatBufferBuilder builder)
		{
			return new Offset<IChargingDevice>(builder.EndTable());
		}

		// Token: 0x060205D8 RID: 132568 RVA: 0x00480CD0 File Offset: 0x0047EED0
		public IChargingDeviceT UnPack()
		{
			IChargingDeviceT chargingDeviceT = new IChargingDeviceT();
			this.UnPackTo(chargingDeviceT);
			return chargingDeviceT;
		}

		// Token: 0x060205D9 RID: 132569 RVA: 0x00480CEC File Offset: 0x0047EEEC
		public void UnPackTo(IChargingDeviceT _o)
		{
			_o.Type = this.Type;
			_o.MaxValue = this.MaxValue;
			_o.InitValue = this.InitValue;
			_o.ProgressPerformanceAttribute = this.ProgressPerformanceAttribute;
			_o.IncreaseSpeed = this.IncreaseSpeed;
			_o.HitExtraValue = this.HitExtraValue;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x060205DA RID: 132570 RVA: 0x00480D50 File Offset: 0x0047EF50
		public static Offset<IChargingDevice> Pack(FlatBufferBuilder builder, IChargingDeviceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChargingDevice>);
			}
			return IChargingDevice.CreateIChargingDevice(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, _o.IncreaseSpeed, _o.HitExtraValue, _o.NullMask);
		}

		// Token: 0x0400DE4A RID: 56906
		private Table __p;
	}
}
