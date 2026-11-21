using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020054BD RID: 21693
	public struct IChargingDevice : IFlatbufferObject
	{
		// Token: 0x17009AC6 RID: 39622
		// (get) Token: 0x06022313 RID: 140051 RVA: 0x004B69EB File Offset: 0x004B4BEB
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06022314 RID: 140052 RVA: 0x004B69F8 File Offset: 0x004B4BF8
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06022315 RID: 140053 RVA: 0x004B6A00 File Offset: 0x004B4C00
		public static IChargingDevice GetRootAsIChargingDevice(ByteBuffer _bb)
		{
			return IChargingDevice.GetRootAsIChargingDevice(_bb, default(IChargingDevice));
		}

		// Token: 0x06022316 RID: 140054 RVA: 0x004B6A1C File Offset: 0x004B4C1C
		public static IChargingDevice GetRootAsIChargingDevice(ByteBuffer _bb, IChargingDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06022317 RID: 140055 RVA: 0x004B6A39 File Offset: 0x004B4C39
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06022318 RID: 140056 RVA: 0x004B6A48 File Offset: 0x004B4C48
		public IChargingDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009AC7 RID: 39623
		// (get) Token: 0x06022319 RID: 140057 RVA: 0x004B6A58 File Offset: 0x004B4C58
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

		// Token: 0x17009AC8 RID: 39624
		// (get) Token: 0x0602231A RID: 140058 RVA: 0x004B6A94 File Offset: 0x004B4C94
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

		// Token: 0x17009AC9 RID: 39625
		// (get) Token: 0x0602231B RID: 140059 RVA: 0x004B6AD0 File Offset: 0x004B4CD0
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

		// Token: 0x17009ACA RID: 39626
		// (get) Token: 0x0602231C RID: 140060 RVA: 0x004B6B0C File Offset: 0x004B4D0C
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

		// Token: 0x17009ACB RID: 39627
		// (get) Token: 0x0602231D RID: 140061 RVA: 0x004B6B4C File Offset: 0x004B4D4C
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

		// Token: 0x17009ACC RID: 39628
		// (get) Token: 0x0602231E RID: 140062 RVA: 0x004B6B8C File Offset: 0x004B4D8C
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

		// Token: 0x17009ACD RID: 39629
		// (get) Token: 0x0602231F RID: 140063 RVA: 0x004B6BCC File Offset: 0x004B4DCC
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

		// Token: 0x06022320 RID: 140064 RVA: 0x004B6C0C File Offset: 0x004B4E0C
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

		// Token: 0x06022321 RID: 140065 RVA: 0x004B6C5B File Offset: 0x004B4E5B
		public static void StartIChargingDevice(FlatBufferBuilder builder)
		{
			builder.StartTable(7);
		}

		// Token: 0x06022322 RID: 140066 RVA: 0x004B6C64 File Offset: 0x004B4E64
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06022323 RID: 140067 RVA: 0x004B6C6F File Offset: 0x004B4E6F
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x06022324 RID: 140068 RVA: 0x004B6C7A File Offset: 0x004B4E7A
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x06022325 RID: 140069 RVA: 0x004B6C85 File Offset: 0x004B4E85
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x06022326 RID: 140070 RVA: 0x004B6C90 File Offset: 0x004B4E90
		public static void AddIncreaseSpeed(FlatBufferBuilder builder, int increaseSpeed)
		{
			builder.AddInt(4, increaseSpeed, 0);
		}

		// Token: 0x06022327 RID: 140071 RVA: 0x004B6C9B File Offset: 0x004B4E9B
		public static void AddHitExtraValue(FlatBufferBuilder builder, int hitExtraValue)
		{
			builder.AddInt(5, hitExtraValue, 0);
		}

		// Token: 0x06022328 RID: 140072 RVA: 0x004B6CA6 File Offset: 0x004B4EA6
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(6, nullMask, 0);
		}

		// Token: 0x06022329 RID: 140073 RVA: 0x004B6CB1 File Offset: 0x004B4EB1
		public static Offset<IChargingDevice> EndIChargingDevice(FlatBufferBuilder builder)
		{
			return new Offset<IChargingDevice>(builder.EndTable());
		}

		// Token: 0x0602232A RID: 140074 RVA: 0x004B6CC0 File Offset: 0x004B4EC0
		public IChargingDeviceT UnPack()
		{
			IChargingDeviceT chargingDeviceT = new IChargingDeviceT();
			this.UnPackTo(chargingDeviceT);
			return chargingDeviceT;
		}

		// Token: 0x0602232B RID: 140075 RVA: 0x004B6CDC File Offset: 0x004B4EDC
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

		// Token: 0x0602232C RID: 140076 RVA: 0x004B6D40 File Offset: 0x004B4F40
		public static Offset<IChargingDevice> Pack(FlatBufferBuilder builder, IChargingDeviceT _o)
		{
			if (_o == null)
			{
				return default(Offset<IChargingDevice>);
			}
			return IChargingDevice.CreateIChargingDevice(builder, _o.Type, _o.MaxValue, _o.InitValue, _o.ProgressPerformanceAttribute, _o.IncreaseSpeed, _o.HitExtraValue, _o.NullMask);
		}

		// Token: 0x0400E9F4 RID: 59892
		private Table __p;
	}
}
