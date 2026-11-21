using System;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005AAD RID: 23213
	public struct IMatchTargetChargingDevice : IFlatbufferObject
	{
		// Token: 0x1700A926 RID: 43302
		// (get) Token: 0x060260E5 RID: 155877 RVA: 0x00536EC3 File Offset: 0x005350C3
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060260E6 RID: 155878 RVA: 0x00536ED0 File Offset: 0x005350D0
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060260E7 RID: 155879 RVA: 0x00536ED8 File Offset: 0x005350D8
		public static IMatchTargetChargingDevice GetRootAsIMatchTargetChargingDevice(ByteBuffer _bb)
		{
			return IMatchTargetChargingDevice.GetRootAsIMatchTargetChargingDevice(_bb, default(IMatchTargetChargingDevice));
		}

		// Token: 0x060260E8 RID: 155880 RVA: 0x00536EF4 File Offset: 0x005350F4
		public static IMatchTargetChargingDevice GetRootAsIMatchTargetChargingDevice(ByteBuffer _bb, IMatchTargetChargingDevice obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060260E9 RID: 155881 RVA: 0x00536F11 File Offset: 0x00535111
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060260EA RID: 155882 RVA: 0x00536F20 File Offset: 0x00535120
		public IMatchTargetChargingDevice __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A927 RID: 43303
		// (get) Token: 0x060260EB RID: 155883 RVA: 0x00536F30 File Offset: 0x00535130
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

		// Token: 0x1700A928 RID: 43304
		// (get) Token: 0x060260EC RID: 155884 RVA: 0x00536F6C File Offset: 0x0053516C
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

		// Token: 0x1700A929 RID: 43305
		// (get) Token: 0x060260ED RID: 155885 RVA: 0x00536FA8 File Offset: 0x005351A8
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

		// Token: 0x1700A92A RID: 43306
		// (get) Token: 0x060260EE RID: 155886 RVA: 0x00536FE4 File Offset: 0x005351E4
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

		// Token: 0x1700A92B RID: 43307
		// (get) Token: 0x060260EF RID: 155887 RVA: 0x00537024 File Offset: 0x00535224
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

		// Token: 0x1700A92C RID: 43308
		// (get) Token: 0x060260F0 RID: 155888 RVA: 0x00537084 File Offset: 0x00535284
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

		// Token: 0x1700A92D RID: 43309
		// (get) Token: 0x060260F1 RID: 155889 RVA: 0x005370C4 File Offset: 0x005352C4
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

		// Token: 0x1700A92E RID: 43310
		// (get) Token: 0x060260F2 RID: 155890 RVA: 0x00537104 File Offset: 0x00535304
		public bool RayCastCheck
		{
			get
			{
				int num = this.__p.__offset(18);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700A92F RID: 43311
		// (get) Token: 0x060260F3 RID: 155891 RVA: 0x00537144 File Offset: 0x00535344
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

		// Token: 0x1700A930 RID: 43312
		// (get) Token: 0x060260F4 RID: 155892 RVA: 0x005371A4 File Offset: 0x005353A4
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

		// Token: 0x060260F5 RID: 155893 RVA: 0x005371E4 File Offset: 0x005353E4
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

		// Token: 0x060260F6 RID: 155894 RVA: 0x0053724C File Offset: 0x0053544C
		public static void StartIMatchTargetChargingDevice(FlatBufferBuilder builder)
		{
			builder.StartTable(10);
		}

		// Token: 0x060260F7 RID: 155895 RVA: 0x00537256 File Offset: 0x00535456
		public static void AddType(FlatBufferBuilder builder, EProgressBarControlType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060260F8 RID: 155896 RVA: 0x00537261 File Offset: 0x00535461
		public static void AddMaxValue(FlatBufferBuilder builder, int maxValue)
		{
			builder.AddInt(1, maxValue, 0);
		}

		// Token: 0x060260F9 RID: 155897 RVA: 0x0053726C File Offset: 0x0053546C
		public static void AddInitValue(FlatBufferBuilder builder, int initValue)
		{
			builder.AddInt(2, initValue, 0);
		}

		// Token: 0x060260FA RID: 155898 RVA: 0x00537277 File Offset: 0x00535477
		public static void AddProgressPerformanceAttribute(FlatBufferBuilder builder, int progressPerformanceAttribute)
		{
			builder.AddInt(3, progressPerformanceAttribute, 0);
		}

		// Token: 0x060260FB RID: 155899 RVA: 0x00537282 File Offset: 0x00535482
		public static void AddMatch(FlatBufferBuilder builder, Offset<IEntityMatch> matchOffset)
		{
			builder.AddOffset(4, matchOffset.Value, 0);
		}

		// Token: 0x060260FC RID: 155900 RVA: 0x00537292 File Offset: 0x00535492
		public static void AddIncreaseSpeed(FlatBufferBuilder builder, int increaseSpeed)
		{
			builder.AddInt(5, increaseSpeed, 0);
		}

		// Token: 0x060260FD RID: 155901 RVA: 0x0053729D File Offset: 0x0053549D
		public static void AddDecreaseSpeed(FlatBufferBuilder builder, int decreaseSpeed)
		{
			builder.AddInt(6, decreaseSpeed, 0);
		}

		// Token: 0x060260FE RID: 155902 RVA: 0x005372A8 File Offset: 0x005354A8
		public static void AddRayCastCheck(FlatBufferBuilder builder, bool rayCastCheck)
		{
			builder.AddBool(7, rayCastCheck, false);
		}

		// Token: 0x060260FF RID: 155903 RVA: 0x005372B3 File Offset: 0x005354B3
		public static void AddRayCastCenter(FlatBufferBuilder builder, Offset<IVectorInfo> rayCastCenterOffset)
		{
			builder.AddOffset(8, rayCastCenterOffset.Value, 0);
		}

		// Token: 0x06026100 RID: 155904 RVA: 0x005372C3 File Offset: 0x005354C3
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(9, nullMask, 0);
		}

		// Token: 0x06026101 RID: 155905 RVA: 0x005372CF File Offset: 0x005354CF
		public static Offset<IMatchTargetChargingDevice> EndIMatchTargetChargingDevice(FlatBufferBuilder builder)
		{
			return new Offset<IMatchTargetChargingDevice>(builder.EndTable());
		}

		// Token: 0x06026102 RID: 155906 RVA: 0x005372DC File Offset: 0x005354DC
		public IMatchTargetChargingDeviceT UnPack()
		{
			IMatchTargetChargingDeviceT matchTargetChargingDeviceT = new IMatchTargetChargingDeviceT();
			this.UnPackTo(matchTargetChargingDeviceT);
			return matchTargetChargingDeviceT;
		}

		// Token: 0x06026103 RID: 155907 RVA: 0x005372F8 File Offset: 0x005354F8
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

		// Token: 0x06026104 RID: 155908 RVA: 0x005373C4 File Offset: 0x005355C4
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

		// Token: 0x0400F44E RID: 62542
		private Table __p;
	}
}
